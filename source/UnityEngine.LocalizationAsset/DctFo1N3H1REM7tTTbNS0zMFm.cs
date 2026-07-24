using System;
using System.Collections;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000041 RID: 65
public class DctFo1N3H1REM7tTTbNS0zMFm : MonoBehaviour
{
	// Token: 0x06000113 RID: 275 RVA: 0x0000BCA8 File Offset: 0x00009EA8
	public void Awake()
	{
		DctFo1N3H1REM7tTTbNS0zMFm.Dxh9D78xpszRipcBnX4NnzBEh = this;
		DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS = new ServerListFilters();
		DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS.attendance = EAttendance.HasPlayers;
		DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS.vacProtection = EVACProtectionFilter.Any;
		DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS.workshop = EWorkshop.ANY;
		DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS.plugins = EPlugins.ANY;
		DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS.password = EPassword.NO;
		DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS.camera = ECameraMode.ANY;
		DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS.thirdpartyAntiCheatProtection = EThirdpartyAntiCheatProtectionFilter.Any;
		DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS.cheats = ECheats.ANY;
		DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS.notFull = true;
		DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS.gold = EServerListGoldFilter.Any;
		DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS.listSource = ESteamServerList.INTERNET;
		DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS.combat = ECombat.ANY;
		DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS.monetization = EServerMonetizationTag.Any;
	}

	// Token: 0x06000114 RID: 276 RVA: 0x0000BD58 File Offset: 0x00009F58
	public void D4b6Xgc7Vn87W91AEv0H5geTG(string nickName)
	{
		bool flag = !string.IsNullOrEmpty(nickName);
		if (flag)
		{
			DctFo1N3H1REM7tTTbNS0zMFm.D4ucYVbnNMDGnNRix0cNTA0uN = nickName;
			DctFo1N3H1REM7tTTbNS0zMFm.DlHyTBtuSaGdOBkJ3wAoJz0Ww.Clear();
			DctFo1N3H1REM7tTTbNS0zMFm.Do9BgWpgEgWCPdRsavodBzZK0.Clear();
			DctFo1N3H1REM7tTTbNS0zMFm.DrT4Un7f7TQcibF1EQRCFh40f = 0;
			DctFo1N3H1REM7tTTbNS0zMFm.Dx6tAxmLD4ao7rayEbofIUU6O = false;
			DctFo1N3H1REM7tTTbNS0zMFm.Du63rJdwVDiFSuAn8z1xmL2WA = false;
			DctFo1N3H1REM7tTTbNS0zMFm.DCsepIcVHGAxnfTORA2ru3dMD = true;
			this.DeY2DDf4rFyncCwxk7SXfLTUH();
		}
	}

	// Token: 0x06000115 RID: 277 RVA: 0x0000BDB0 File Offset: 0x00009FB0
	public void DeY2DDf4rFyncCwxk7SXfLTUH()
	{
		this.Dw9zvLQLBnA5XCL1PeE3KN0QF = base.StartCoroutine(this.DTeMCNVvpp0I11wjHJIN0qgtI());
		Provider.provider.matchmakingService.refreshMasterServer(DctFo1N3H1REM7tTTbNS0zMFm.DcBb7zrQYLCg6wj6EpIHS4tKS);
	}

	// Token: 0x06000116 RID: 278 RVA: 0x0000BDDA File Offset: 0x00009FDA
	public IEnumerator DTeMCNVvpp0I11wjHJIN0qgtI()
	{
		yield return null;
	}

	// Token: 0x06000117 RID: 279 RVA: 0x0000BDEC File Offset: 0x00009FEC
	public void D07RAI1zVmNf0RGp4lloUzfZD()
	{
		for (int i = 0; i < DctFo1N3H1REM7tTTbNS0zMFm.DlHyTBtuSaGdOBkJ3wAoJz0Ww.Count; i++)
		{
			DctFo1N3H1REM7tTTbNS0zMFm.DlHyTBtuSaGdOBkJ3wAoJz0Ww[i].DPdivemBsU71Md6YGTsLk1qlJ();
		}
		bool flag = this.Dw9zvLQLBnA5XCL1PeE3KN0QF != null;
		if (flag)
		{
			base.StopCoroutine(this.Dw9zvLQLBnA5XCL1PeE3KN0QF);
			this.Dw9zvLQLBnA5XCL1PeE3KN0QF = null;
		}
		DctFo1N3H1REM7tTTbNS0zMFm.DlHyTBtuSaGdOBkJ3wAoJz0Ww.Clear();
		DctFo1N3H1REM7tTTbNS0zMFm.DCsepIcVHGAxnfTORA2ru3dMD = false;
	}

	// Token: 0x06000118 RID: 280 RVA: 0x0000BE5C File Offset: 0x0000A05C
	public void DxKsw1RG7MLFomvWSWfK2NpL0(string nickname, float playTime, int index)
	{
		bool dcsepIcVHGAxnfTORA2ru3dMD = DctFo1N3H1REM7tTTbNS0zMFm.DCsepIcVHGAxnfTORA2ru3dMD;
		if (dcsepIcVHGAxnfTORA2ru3dMD)
		{
			for (int i = 0; i < DctFo1N3H1REM7tTTbNS0zMFm.DlHyTBtuSaGdOBkJ3wAoJz0Ww.Count; i++)
			{
				bool flag = DctFo1N3H1REM7tTTbNS0zMFm.DlHyTBtuSaGdOBkJ3wAoJz0Ww[i].DFdg9anZQIiXYtfRE3dClBRtI == index;
				if (flag)
				{
					bool flag2 = !string.IsNullOrEmpty(nickname);
					if (flag2)
					{
						TimeSpan timeSpan = TimeSpan.FromSeconds((double)playTime);
						string text = string.Empty;
						bool flag3 = timeSpan.Days > 0;
						if (flag3)
						{
							text = text + " " + timeSpan.Days.ToString() + "d";
						}
						bool flag4 = timeSpan.Hours > 0;
						if (flag4)
						{
							text = text + " " + timeSpan.Hours.ToString() + "h";
						}
						bool flag5 = timeSpan.Minutes > 0;
						if (flag5)
						{
							text = text + " " + timeSpan.Minutes.ToString() + "m";
						}
						bool flag6 = timeSpan.Seconds > 0;
						if (flag6)
						{
							text = text + " " + timeSpan.Seconds.ToString() + "s";
						}
						D5bADMxbfCFvG3WY9Gu4DXxc2 d5bADMxbfCFvG3WY9Gu4DXxc = new D5bADMxbfCFvG3WY9Gu4DXxc2(DctFo1N3H1REM7tTTbNS0zMFm.DlHyTBtuSaGdOBkJ3wAoJz0Ww[i].DG2qouuQuJUqxqtH7zDWPRKxk, DctFo1N3H1REM7tTTbNS0zMFm.DlHyTBtuSaGdOBkJ3wAoJz0Ww[i].Dv8vqZnNsoUNqGWltN04IG9Yl, nickname.ToLower(), text);
						DctFo1N3H1REM7tTTbNS0zMFm.Do9BgWpgEgWCPdRsavodBzZK0.Add(d5bADMxbfCFvG3WY9Gu4DXxc);
					}
					DctFo1N3H1REM7tTTbNS0zMFm.DlHyTBtuSaGdOBkJ3wAoJz0Ww.RemoveAt(i);
					break;
				}
			}
			bool flag7 = Provider.provider.matchmakingService.serverList.Count == DctFo1N3H1REM7tTTbNS0zMFm.DrT4Un7f7TQcibF1EQRCFh40f && DctFo1N3H1REM7tTTbNS0zMFm.DlHyTBtuSaGdOBkJ3wAoJz0Ww.Count == 0;
			if (flag7)
			{
				DctFo1N3H1REM7tTTbNS0zMFm.Du63rJdwVDiFSuAn8z1xmL2WA = true;
				DctFo1N3H1REM7tTTbNS0zMFm.DCsepIcVHGAxnfTORA2ru3dMD = false;
			}
			else
			{
				bool flag8 = Provider.provider.matchmakingService.serverList.Count != DctFo1N3H1REM7tTTbNS0zMFm.DrT4Un7f7TQcibF1EQRCFh40f;
				if (flag8)
				{
					SteamServerAdvertisement steamServerAdvertisement = Provider.provider.matchmakingService.serverList[DctFo1N3H1REM7tTTbNS0zMFm.DrT4Un7f7TQcibF1EQRCFh40f];
					D3jHiaQeLVJhKeFOEEaBExLtT d3jHiaQeLVJhKeFOEEaBExLtT = new D3jHiaQeLVJhKeFOEEaBExLtT(steamServerAdvertisement.ip, steamServerAdvertisement.queryPort, steamServerAdvertisement.connectionPort, DctFo1N3H1REM7tTTbNS0zMFm.DrT4Un7f7TQcibF1EQRCFh40f, new Action<string, float, int>(this.DxKsw1RG7MLFomvWSWfK2NpL0));
					DctFo1N3H1REM7tTTbNS0zMFm.DlHyTBtuSaGdOBkJ3wAoJz0Ww.Add(d3jHiaQeLVJhKeFOEEaBExLtT);
					d3jHiaQeLVJhKeFOEEaBExLtT.DDMdiDM2om0OgxUfu8y6vJPfj();
					DctFo1N3H1REM7tTTbNS0zMFm.DrT4Un7f7TQcibF1EQRCFh40f++;
				}
			}
		}
	}

	// Token: 0x04000171 RID: 369
	public static ServerListFilters DcBb7zrQYLCg6wj6EpIHS4tKS = null;

	// Token: 0x04000172 RID: 370
	public const int DeVZhOq0pb6JuqSmdPPsaKPxK = 5;

	// Token: 0x04000173 RID: 371
	public static string D4ucYVbnNMDGnNRix0cNTA0uN = "";

	// Token: 0x04000174 RID: 372
	public static List<D3jHiaQeLVJhKeFOEEaBExLtT> DlHyTBtuSaGdOBkJ3wAoJz0Ww = new List<D3jHiaQeLVJhKeFOEEaBExLtT>();

	// Token: 0x04000175 RID: 373
	public static List<D5bADMxbfCFvG3WY9Gu4DXxc2> Do9BgWpgEgWCPdRsavodBzZK0 = new List<D5bADMxbfCFvG3WY9Gu4DXxc2>();

	// Token: 0x04000176 RID: 374
	public static int DrT4Un7f7TQcibF1EQRCFh40f = 0;

	// Token: 0x04000177 RID: 375
	public static bool Dx6tAxmLD4ao7rayEbofIUU6O = false;

	// Token: 0x04000178 RID: 376
	public static bool Du63rJdwVDiFSuAn8z1xmL2WA = false;

	// Token: 0x04000179 RID: 377
	public static bool DCsepIcVHGAxnfTORA2ru3dMD = false;

	// Token: 0x0400017A RID: 378
	public static DctFo1N3H1REM7tTTbNS0zMFm Dxh9D78xpszRipcBnX4NnzBEh;

	// Token: 0x0400017B RID: 379
	public Coroutine Dw9zvLQLBnA5XCL1PeE3KN0QF;
}
