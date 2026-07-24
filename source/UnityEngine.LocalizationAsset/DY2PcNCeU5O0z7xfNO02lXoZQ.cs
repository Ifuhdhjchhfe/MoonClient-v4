using System;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

// Token: 0x020000D5 RID: 213
public class DY2PcNCeU5O0z7xfNO02lXoZQ : MonoBehaviour
{
	// Token: 0x06000409 RID: 1033 RVA: 0x0003D424 File Offset: 0x0003B624
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DYFnBcbvS8F0JOYJsLrZ4ircr()
	{
		Provider.onClientConnected = (Provider.ClientConnected)Delegate.Combine(Provider.onClientConnected, new Provider.ClientConnected(DY2PcNCeU5O0z7xfNO02lXoZQ.D66euix3sk04DTYUOAcsNhO7Z));
		Provider.onServerConnected = (Provider.ServerConnected)Delegate.Combine(Provider.onServerConnected, new Provider.ServerConnected(delegate(CSteamID steamid)
		{
			DY2PcNCeU5O0z7xfNO02lXoZQ.D66euix3sk04DTYUOAcsNhO7Z();
		}));
		Provider.onClientDisconnected = (Provider.ClientDisconnected)Delegate.Combine(Provider.onClientDisconnected, new Provider.ClientDisconnected(DY2PcNCeU5O0z7xfNO02lXoZQ.DMaYVFFMVXRM0kyAukbKZoIJY));
		bool flag = D0Kr0NqRHBD41IMsgv7ajeW8M.DxcVo94CW4Y8vQkyhpKozFmcW && Provider.isConnected;
		bool flag2 = flag;
		if (flag2)
		{
			DY2PcNCeU5O0z7xfNO02lXoZQ.D66euix3sk04DTYUOAcsNhO7Z();
		}
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x0003D4C2 File Offset: 0x0003B6C2
	private static void D66euix3sk04DTYUOAcsNhO7Z()
	{
		DY2PcNCeU5O0z7xfNO02lXoZQ.DHSeh6qVA42V7flNcXbLJnoiG = D0Kr0NqRHBD41IMsgv7ajeW8M.D1tYt6KxEmATG67AhmCiQjAGN.AddComponent<DY2PcNCeU5O0z7xfNO02lXoZQ>();
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x0003D4D4 File Offset: 0x0003B6D4
	private static void DMaYVFFMVXRM0kyAukbKZoIJY()
	{
		global::UnityEngine.Object.Destroy(DY2PcNCeU5O0z7xfNO02lXoZQ.DHSeh6qVA42V7flNcXbLJnoiG);
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x0003D4E4 File Offset: 0x0003B6E4
	private void Update()
	{
		DVWbzlF8EMqi1xEQwNWSt4Ft9.Update();
		this.Dnyc5zg1ef11TUWUrQjh0jxqO += Time.unscaledDeltaTime;
		bool flag = this.Dnyc5zg1ef11TUWUrQjh0jxqO > 0.75f;
		bool flag2 = flag;
		if (flag2)
		{
			this.Dnyc5zg1ef11TUWUrQjh0jxqO -= 0.75f;
			DDddnUl0gHJ8ZiQTaRLEUBUS2.DLIKZ4jWqR7ohdwDdW9lFFyVo();
		}
	}

	// Token: 0x04000455 RID: 1109
	private const float D6DkoGdr0tGMaQVpcgT2zxzSZ = 0.75f;

	// Token: 0x04000456 RID: 1110
	private static DY2PcNCeU5O0z7xfNO02lXoZQ DHSeh6qVA42V7flNcXbLJnoiG;

	// Token: 0x04000457 RID: 1111
	private float Dnyc5zg1ef11TUWUrQjh0jxqO = 0f;
}
