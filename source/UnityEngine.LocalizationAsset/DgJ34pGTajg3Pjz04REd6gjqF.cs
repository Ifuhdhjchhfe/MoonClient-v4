using System;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

// Token: 0x0200005E RID: 94
public class DgJ34pGTajg3Pjz04REd6gjqF : MonoBehaviour
{
	// Token: 0x060001BD RID: 445 RVA: 0x000172C4 File Offset: 0x000154C4
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DHYT4izo0LH77WVT8cCo3KO2t()
	{
		Provider.onClientConnected = (Provider.ClientConnected)Delegate.Combine(Provider.onClientConnected, new Provider.ClientConnected(DgJ34pGTajg3Pjz04REd6gjqF.D8aaBQqlS1XtnwKrujO4J2rhW));
		Provider.onServerConnected = (Provider.ServerConnected)Delegate.Combine(Provider.onServerConnected, new Provider.ServerConnected(delegate(CSteamID steamid)
		{
			DgJ34pGTajg3Pjz04REd6gjqF.D8aaBQqlS1XtnwKrujO4J2rhW();
		}));
		Provider.onClientDisconnected = (Provider.ClientDisconnected)Delegate.Combine(Provider.onClientDisconnected, new Provider.ClientDisconnected(DgJ34pGTajg3Pjz04REd6gjqF.DQIldxBF2oSHi3mKzVXF05gno));
		bool flag = D0Kr0NqRHBD41IMsgv7ajeW8M.DxcVo94CW4Y8vQkyhpKozFmcW && Provider.isConnected;
		bool flag2 = flag;
		if (flag2)
		{
			DgJ34pGTajg3Pjz04REd6gjqF.D8aaBQqlS1XtnwKrujO4J2rhW();
		}
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00017362 File Offset: 0x00015562
	private static void D8aaBQqlS1XtnwKrujO4J2rhW()
	{
		DgJ34pGTajg3Pjz04REd6gjqF.DeoxxueKa042p3233fHnM0iYr = D0Kr0NqRHBD41IMsgv7ajeW8M.D1tYt6KxEmATG67AhmCiQjAGN.AddComponent<DgJ34pGTajg3Pjz04REd6gjqF>();
	}

	// Token: 0x060001BF RID: 447 RVA: 0x00017374 File Offset: 0x00015574
	private static void DQIldxBF2oSHi3mKzVXF05gno()
	{
		global::UnityEngine.Object.Destroy(DgJ34pGTajg3Pjz04REd6gjqF.DeoxxueKa042p3233fHnM0iYr);
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00017384 File Offset: 0x00015584
	private void Update()
	{
		DgJ34pGTajg3Pjz04REd6gjqF.D6yNvTchss7CUJsNd3wWg09fL = !DgJ34pGTajg3Pjz04REd6gjqF.D6yNvTchss7CUJsNd3wWg09fL;
		bool flag = !DgJ34pGTajg3Pjz04REd6gjqF.D6yNvTchss7CUJsNd3wWg09fL;
		bool flag2 = !flag;
		if (flag2)
		{
			Ddagemt6Wc3UeyV4EYXNrXcFf.Update();
		}
	}

	// Token: 0x04000231 RID: 561
	private static DgJ34pGTajg3Pjz04REd6gjqF DeoxxueKa042p3233fHnM0iYr;

	// Token: 0x04000232 RID: 562
	private static bool D6yNvTchss7CUJsNd3wWg09fL;
}
