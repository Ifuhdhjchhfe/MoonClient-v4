using System;
using Steamworks;

// Token: 0x02000013 RID: 19
public class D3jHiaQeLVJhKeFOEEaBExLtT
{
	// Token: 0x06000055 RID: 85 RVA: 0x0000516C File Offset: 0x0000336C
	public D3jHiaQeLVJhKeFOEEaBExLtT(uint serverIP, ushort serverPort, ushort connectionPort, int index, Action<string, float, int> onPlayersRefreshed)
	{
		this.D05FXbBnT0C9WDdOVrTpoEXyn = onPlayersRefreshed;
		this.DFdg9anZQIiXYtfRE3dClBRtI = index;
		this.DG2qouuQuJUqxqtH7zDWPRKxk = serverIP;
		this.Dv8vqZnNsoUNqGWltN04IG9Yl = serverPort;
		this.DWnXVz6DZbDTTQSMm92TnC4T0 = connectionPort;
		this.D05FXbBnT0C9WDdOVrTpoEXyn = onPlayersRefreshed;
		this.DFdg9anZQIiXYtfRE3dClBRtI = index;
		this.DEE0Iz9P78r91RbhDv1m3zEiC = HServerQuery.Invalid;
		this.DGXPBKpcRfIDWyi8OIUwP9k42 = "";
		this.D3hd0KeBaJSG50lQvRz3qca4N = 0f;
		this.DXwthLJh46weJc4qmXrFlnM3q = new ISteamMatchmakingPlayersResponse(delegate(string playerName, int score, float playTime)
		{
			bool flag = playerName.ToLower().Contains(DctFo1N3H1REM7tTTbNS0zMFm.D4ucYVbnNMDGnNRix0cNTA0uN.ToLower());
			bool flag2 = flag;
			if (flag2)
			{
				this.DGXPBKpcRfIDWyi8OIUwP9k42 = playerName;
				this.D3hd0KeBaJSG50lQvRz3qca4N = playTime;
			}
		}, delegate
		{
			this.DDMdiDM2om0OgxUfu8y6vJPfj();
		}, delegate
		{
			this.DEE0Iz9P78r91RbhDv1m3zEiC = HServerQuery.Invalid;
			this.D05FXbBnT0C9WDdOVrTpoEXyn(this.DGXPBKpcRfIDWyi8OIUwP9k42, this.D3hd0KeBaJSG50lQvRz3qca4N, this.DFdg9anZQIiXYtfRE3dClBRtI);
		});
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00005250 File Offset: 0x00003450
	public void DDMdiDM2om0OgxUfu8y6vJPfj()
	{
		bool flag = this.DWsHOeEKphF9w54Px1IfkoMGz > 4;
		bool flag2 = flag;
		if (flag2)
		{
			this.DEE0Iz9P78r91RbhDv1m3zEiC = HServerQuery.Invalid;
			this.D05FXbBnT0C9WDdOVrTpoEXyn("", 0f, this.DFdg9anZQIiXYtfRE3dClBRtI);
		}
		else
		{
			this.DWsHOeEKphF9w54Px1IfkoMGz++;
			this.DEE0Iz9P78r91RbhDv1m3zEiC = SteamMatchmakingServers.PlayerDetails(this.DG2qouuQuJUqxqtH7zDWPRKxk, this.Dv8vqZnNsoUNqGWltN04IG9Yl, this.DXwthLJh46weJc4qmXrFlnM3q);
		}
	}

	// Token: 0x06000057 RID: 87 RVA: 0x000052C8 File Offset: 0x000034C8
	public void DPdivemBsU71Md6YGTsLk1qlJ()
	{
		bool flag = this.DEE0Iz9P78r91RbhDv1m3zEiC != HServerQuery.Invalid;
		bool flag2 = flag;
		if (flag2)
		{
			SteamMatchmakingServers.CancelServerQuery(this.DEE0Iz9P78r91RbhDv1m3zEiC);
			this.DEE0Iz9P78r91RbhDv1m3zEiC = HServerQuery.Invalid;
		}
	}

	// Token: 0x04000026 RID: 38
	public uint DG2qouuQuJUqxqtH7zDWPRKxk;

	// Token: 0x04000027 RID: 39
	public ushort Dv8vqZnNsoUNqGWltN04IG9Yl;

	// Token: 0x04000028 RID: 40
	public ushort DWnXVz6DZbDTTQSMm92TnC4T0;

	// Token: 0x04000029 RID: 41
	public int DFdg9anZQIiXYtfRE3dClBRtI;

	// Token: 0x0400002A RID: 42
	public Action<string, float, int> D05FXbBnT0C9WDdOVrTpoEXyn;

	// Token: 0x0400002B RID: 43
	public string DGXPBKpcRfIDWyi8OIUwP9k42 = "";

	// Token: 0x0400002C RID: 44
	public float D3hd0KeBaJSG50lQvRz3qca4N = 0f;

	// Token: 0x0400002D RID: 45
	public HServerQuery DEE0Iz9P78r91RbhDv1m3zEiC;

	// Token: 0x0400002E RID: 46
	public ISteamMatchmakingPlayersResponse DXwthLJh46weJc4qmXrFlnM3q;

	// Token: 0x0400002F RID: 47
	public int DWsHOeEKphF9w54Px1IfkoMGz = 0;
}
