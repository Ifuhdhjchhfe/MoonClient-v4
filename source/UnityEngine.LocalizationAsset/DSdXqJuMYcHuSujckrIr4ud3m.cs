using System;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

// Token: 0x020000B5 RID: 181
public class DSdXqJuMYcHuSujckrIr4ud3m : MonoBehaviour
{
	// Token: 0x06000385 RID: 901 RVA: 0x00036D38 File Offset: 0x00034F38
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DhxwplKm0wUNhy63Sg6V8EhDA()
	{
		Provider.onClientConnected = (Provider.ClientConnected)Delegate.Combine(Provider.onClientConnected, new Provider.ClientConnected(DSdXqJuMYcHuSujckrIr4ud3m.D9JueHWCgl0WN3rPkp3qXyogv));
		Provider.onServerConnected = (Provider.ServerConnected)Delegate.Combine(Provider.onServerConnected, new Provider.ServerConnected(delegate(CSteamID steamid)
		{
			DSdXqJuMYcHuSujckrIr4ud3m.D9JueHWCgl0WN3rPkp3qXyogv();
		}));
		Provider.onClientDisconnected = (Provider.ClientDisconnected)Delegate.Combine(Provider.onClientDisconnected, new Provider.ClientDisconnected(DSdXqJuMYcHuSujckrIr4ud3m.DkQZAsH6LxP7zKARk1aToalp3));
		bool flag = D0Kr0NqRHBD41IMsgv7ajeW8M.DxcVo94CW4Y8vQkyhpKozFmcW && Provider.isConnected;
		bool flag2 = flag;
		if (flag2)
		{
			DSdXqJuMYcHuSujckrIr4ud3m.D9JueHWCgl0WN3rPkp3qXyogv();
		}
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00036DD6 File Offset: 0x00034FD6
	private static void D9JueHWCgl0WN3rPkp3qXyogv()
	{
		DSdXqJuMYcHuSujckrIr4ud3m.Do2E70GW9kMUPaw1tz30d8gEt = D0Kr0NqRHBD41IMsgv7ajeW8M.D1tYt6KxEmATG67AhmCiQjAGN.AddComponent<DSdXqJuMYcHuSujckrIr4ud3m>();
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00036DE8 File Offset: 0x00034FE8
	private static void DkQZAsH6LxP7zKARk1aToalp3()
	{
		global::UnityEngine.Object.Destroy(DSdXqJuMYcHuSujckrIr4ud3m.Do2E70GW9kMUPaw1tz30d8gEt);
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00036DF6 File Offset: 0x00034FF6
	private void Update()
	{
		DmPNupos8Sd6cXJNxXG0GuRXC.DR6u3Bkxz9jIBqdxQ2KyGGqCy();
	}

	// Token: 0x040003D4 RID: 980
	private static DSdXqJuMYcHuSujckrIr4ud3m Do2E70GW9kMUPaw1tz30d8gEt;
}
