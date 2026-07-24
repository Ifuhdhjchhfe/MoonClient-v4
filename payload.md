# payload.dll — MoonClient C++ Injection Payload

## Overview

**File:** `payload.dll` (extracted from loader process memory during DeviceIoControl write)
**Type:** Windows x64 C++ DLL (native)
**ImageBase:** 0x180000000
**ImageSize:** 0x81000 (516KB)
**Text:** 0x3000 (12KB — tiny!)
**Data:** 0x79000 (484KB — huge!)
**Functions:** 105 total (32 native CRT/init, 14 VMP thunks, 9 VMP handlers, 11 VMP stubs, VM_EntryPoint, 2 VMP call gates, plus imports)
**Strings:** 5,980 (mostly C# type names and obfuscated identifiers)
**PDB:** `C:\Users\PC\Desktop\MoonClient Product Sources\MoonClient Unturned Internal4\DLL Source\UnityEngine.LocalizationAsset\obj\Debug\UnityEngine.LocalizationAsset.pdb`

## Architecture

```
DllEntryPoint
  └─ DLL_PROCESS_ATTACH
       ├─ InitSecurityCookie
       └─ DllMain_Real
            └─ DllMain_CRT_Dispatch (fdwReason=1)
                 └─ Initialize
                      ├─ InitializeRuntime
                      │    ├─ DetectCpuFeatures (CPUID GenuineIntel + AVX/AVX2/XSAVE)
                      │    └─ VMP_CallGate_0 × 2 (VMP init)
                      ├─ InitStep_DisableThreadLibraryCalls
                      ├─ InitStep_ConfigureNarrowArgv
                      ├─ RunInitTermFunctions (CRT static constructors)
                      ├─ initterm / initterm_e
                      ├─ DispatchGuardCall
                      └─ CreateInitThread
                           └─ CreateThread → VM_EntryPoint (PcValue)
                                └─ [VMP] Mono bootstrap + C# assembly load
```

When the DLL is injected into Unturned.exe (Unity game):
1. `DllMain` fires on `DLL_PROCESS_ATTACH`
2. CRT init runs (security cookie, CPU feature detection, static constructors)
3. A **new thread** is spawned via `CreateThread` targeting `VM_EntryPoint`
4. `VM_EntryPoint` is a 1027-byte VMP dispatcher — all actual logic is virtualized
5. Inside VMP: Mono runtime exports are resolved, the embedded C# assembly is loaded via `mono_image_open_from_data`, and cheat entry points are invoked

## Native Functions (32 total, all renamed)

### Entry Points
| Function | Address | Purpose |
|----------|---------|---------|
| `DllEntryPoint` | 0x180002484 | Raw DllMain — initializes security cookie, delegates to DllMain_Real |
| `DllMain_Real` | 0x18000235C | Real DllMain — dispatches attach/detach/thread events |
| `DllMain_CRT_Dispatch` | 0x180002170 | Switches on fdwReason: 0→Shutdown, 1→Initialize, 2→OnThreadAttach, 3→OnThreadDetach |

### Initialization
| Function | Address | Purpose |
|----------|---------|---------|
| `Initialize` | 0x1800021C0 | Full DLL init sequence. Runs runtime init, CRT initterm, spawns VMP thread |
| `InitializeRuntime` | 0x1800028A4 | CPU detection + calls VMP_CallGate_0 for VMP bootstrapping |
| `CreateInitThread` | 0x180002070 | Spawns thread: `CreateThread(NULL, 0, VM_EntryPoint, NULL, 0, NULL)` |
| `InitSecurityCookie` | 0x180002640 | CRT security cookie generation (GetSystemTimeAsFileTime ⊕ TID ⊕ PID ⊕ QPC) |
| `InitStep_DisableThreadLibraryCalls` | 0x1800026F0 | Disables DLL_THREAD_ATTACH/DETACH notifications |
| `InitStep_ConfigureNarrowArgv` | 0x18000271C | CRT narrow argv configuration |
| `IsInitializedCheck` | 0x1800027A8 | Checks if module is already initialized |
| `RunInitTermFunctions` | 0x180002BB4 | Calls CRT static constructor array |

### Shutdown
| Function | Address | Purpose |
|----------|---------|---------|
| `Shutdown` | 0x1800022D8 | Full cleanup sequence. Decrements refcount, runs cleanup, restores state |
| `Shutdown_Cleanup1` | 0x180002860 | Cleanup phase 1 |
| `Shutdown_Cleanup2` | 0x180002890 | Cleanup phase 2 |
| `Shutdown_Cleanup3` | 0x180002BF0 | Cleanup phase 3 |
| `ShutdownStep_FreeLibrary` | 0x180002700 | FreeLibrary cleanup step |

### Utility
| Function | Address | Purpose |
|----------|---------|---------|
| `DetectCpuFeatures` | 0x180002C30 | CPUID vendor check (GenuineIntel only) + AVX/AVX2/XSAVE/AVX512 detection |
| `VectoredExceptionHandler` | 0x180002A68 | SEH/VEH handler — captures context, unwinds stack, debugger check |
| `SaveInitState` | 0x180002738 | Saves initialization state for cleanup |
| `RestoreInitState` | 0x180002A04 | Restores initialization state |
| `CheckInitState` | 0x180002774 | Validates initialization state |
| `CheckModuleState` | 0x1800028E0 | Checks module initialization state |
| `DispatchGuardCall` | 0x18000296C | CFG guard dispatch via __guard_dispatch_icall |
| `GetGlobalFunctionPtr` | 0x180002A54 | Returns pointer to global function table |
| `InitializeNarrowEnvironment` | 0x180002800 | CRT narrow environment init |
| `FastFailHelper` | 0x180002A5C | __fastfail helper |
| `FailFastThunk` | 0x180002EC8 | Thin fastfail wrapper |

### Thread Events
| Function | Address | Purpose |
|----------|---------|---------|
| `OnThreadAttach` | 0x1800027C0 | DLL_THREAD_ATTACH handler |
| `OnThreadDetach` | 0x1800027E8 | DLL_THREAD_DETACH handler |
| `FinalizeInit` | 0x180002A28 | Post-initialization finalization |
| `DllMain_CheckFlags` | 0x1800020DC | Flag validation helper |

## VMP Functions (53 total, categorized)

### VM Entry Point
| Function | Address | Size | Purpose |
|----------|---------|------|---------|
| `VM_EntryPoint` (PcValue) | 0x180001C60 | 1027 bytes | VMP dispatcher — all Mono/C# loading logic. Called via CreateThread. Resolves mono_domain_get, mono_image_open_from_data, loads the embedded 484KB C# assembly from .data, calls cheat entry points |

### VMP Call Gates (2)
| Function | Address | Called by |
|----------|---------|-----------|
| `VMP_CallGate_0` | 0x180002F24 | InitializeRuntime (×2) |
| `VMP_CallGate_1` | 0x180002F28 | (internal) |

### VMP Thunks (15) — 0x1D or 0x2A bytes each
`VMP_Thunk_00` through `VMP_Thunk_14` at 0x180001000–0x180001330

### VMP Handlers (9) — 0x7B bytes each
`VMP_Handler_00` through `VMP_Handler_08` at 0x180001360–0x180001760

### VMP Stubs (12) — 0x37 or 0x38 bytes each
`VMP_Stub_00` through `VMP_Stub_11` at 0x1800017E0–0x180001C20

## Imports

**KERNEL32.dll:** CreateThread, FreeLibraryAndExitThread, GetModuleHandleW, GetProcAddress, RtlCaptureContext, RtlVirtualUnwind, UnhandledExceptionFilter, SetUnhandledExceptionFilter, GetCurrentProcess, TerminateProcess, IsDebuggerPresent, InitializeSListHead, GetSystemTimeAsFileTime, GetCurrentThreadId, GetCurrentProcessId, QueryPerformanceCounter, IsProcessorFeaturePresent, RtlLookupFunctionEntry, RtlPcToFileHeader

**VCRUNTIME140.dll:** __std_type_info_destroy_list, __C_specific_handler, memcpy, memset

**api-ms-win-crt-runtime-l1-1-0.dll:** _cexit, _execute_onexit_table, _initialize_onexit_table, _configure_narrow_argv, _seh_filter_dll, _initterm_e, _initterm, _initialize_narrow_environment

**Notable:** No direct imports for Mono/Unity. All Mono functions (`mono_domain_get`, `mono_image_open_from_data`, `mono_assembly_load_from`, `mono_class_get`, `mono_method_get`, `mono_runtime_invoke`, etc.) are resolved dynamically via `GetProcAddress` from within VMP code.

## Embedded C# Assembly

The `.data` section (0x180005000–0x18007E000, 484KB) contains:
- **Obfuscated .NET assembly** with ConfuserEx-style name mangling (all types/methods prefixed with 'D')
- `<Module>` metadata marker at 0x180058E9C
- **Unity module references:** `UnityEngine.IMGUIModule`, `UnityEngine.CoreModule`, `UnityEngine.ScreenCaptureModule`, `UnityEngine.TextRenderingModule`, `UnityEngine.ImageConversionModule`, `UnityEngine.InputLegacyModule`, `UnityEngine.AudioModule`, `UnityEngine.Experimental.Rendering`
- **MoonClient cheat identifiers:** `DGetMoonGradientText`, `ECheats`, `GameObjectPoolDictionary`, `ICommunityService`, `MonoBehaviour` wrappers, `OnUnityButtonClicked`, `OnUnityButtonRightClicked`
- **SDG/Unturned namespaces:** `SDG.Provider.Services.Community`, `USDG.Unturned.RandomEx, UnityEx`
- **C# assembly name:** `UnityEngine.LocalizationAsset` (used as disguise — appears to be a localization module but is actually the cheat payload)

## Execution Flow in Target (Unturned.exe)

```
1. Injector writes payload.dll bytes to Unturned.exe memory
2. CreateRemoteThread → LoadLibrary("payload.dll")
3. DllMain fires → Initialize → CreateThread → VM_EntryPoint
4. [VMP] GetModuleHandleW("mono.dll") or find Mono via Unity exports
5. [VMP] mono_domain_get() → get the game's Mono domain
6. [VMP] mono_image_open_from_data(embedded_assembly, 484KB) → load C# cheat
7. [VMP] Walk assembly types → find cheat entry point class
8. [VMP] mono_runtime_invoke(entry_method) → start cheat
9. [VMP] C# code initializes ImGui overlay, hooks Unity rendering, enables ESP/Aimbot/etc.
```

## Indicators

- PDB path: `C:\Users\PC\Desktop\MoonClient Product Sources\MoonClient Unturned Internal4\DLL Source\...`
- `[MoonClient]` debug prefix in kernel driver (same author)
- Uses VMP's `PcValue` naming convention for the entry point (standard VMP naming)
- CPU feature detection only accepts **GenuineIntel** vendor — crashes on AMD CPUs
- Embedded C# assembly disguised as `UnityEngine.LocalizationAsset` to blend in with Unity modules
- CRT security cookie generation matches kernel driver's pattern (same code, different file)
