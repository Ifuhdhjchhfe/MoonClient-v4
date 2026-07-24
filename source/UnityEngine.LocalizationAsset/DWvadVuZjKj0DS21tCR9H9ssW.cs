using System;
using System.Runtime.CompilerServices;
using HighlightingSystem;
using SDG.Unturned;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x020000CF RID: 207
public static class DWvadVuZjKj0DS21tCR9H9ssW
{
	// Token: 0x060003F0 RID: 1008 RVA: 0x0003B9C4 File Offset: 0x00039BC4
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "ClearCameraScripts")]
	public static void DK4LtFEbXnNhqVrnftTBVphWa()
	{
		bool flag = MainCamera.instance == null;
		bool flag2 = !flag;
		if (flag2)
		{
			DWvadVuZjKj0DS21tCR9H9ssW.Db0l77zLrAO5qC0MuxEr4Zipx(MainCamera.instance.GetComponent<DecalRenderer>());
			DWvadVuZjKj0DS21tCR9H9ssW.Db0l77zLrAO5qC0MuxEr4Zipx(MainCamera.instance.GetComponent<PostProcessLayer>());
			DWvadVuZjKj0DS21tCR9H9ssW.Db0l77zLrAO5qC0MuxEr4Zipx(MainCamera.instance.GetComponent<HighlightingRenderer>());
		}
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x0003BA18 File Offset: 0x00039C18
	[CompilerGenerated]
	internal static void Db0l77zLrAO5qC0MuxEr4Zipx(MonoBehaviour mb)
	{
		bool flag = mb != null;
		bool flag2 = flag;
		if (flag2)
		{
			global::UnityEngine.Object.Destroy(mb);
		}
	}
}
