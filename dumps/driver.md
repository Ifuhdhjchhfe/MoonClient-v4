# MoonClient Driver

| IOCTL | desc |
|-------|-------------|
| `0x2220002C` | Register calling PID as authorized (max 16, first-come-first-served) |
| `0x22200048` | `ZwAllocateVirtualMemory` in target — MEM_COMMIT, PAGE_EXECUTE_READWRITE |
| `0x22200014` | `ZwFreeVirtualMemory` in target |
| `0x22200030` | `ZwProtectVirtualMemory` in target |
| `0x22200018` | Read process memory (physical addr translation + MmCopyMemory, max 64KB) |
| `0x2220001C` | Write process memory (same method, input at buffer offset 0x228) |
| `0x22200020` | Get module base address in target |
| `0x22200024` | Get main module base via PEB walk + caching |
| `0x22200028` | Thread lookup by PID |
| `0x22200034` | CreateRemoteThread (NtCreateThreadEx, dynamically resolved) |
| `0x22200038` | Suspend thread |
| `0x2220003C` | Resume thread |
| `0x22200040` | Get thread context (falls back to KTRAP_FRAME if ZwGetContextThread is NULL) |
| `0x22200044` | Set thread context (same fallback) |
