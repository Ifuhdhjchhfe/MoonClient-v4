using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200004F RID: 79
public class DEdZvmBEAHUhmGO3WqaP1RVye : DOEkZ1zoBEuvfUmOs9QSpfX0X
{
	// Token: 0x06000173 RID: 371 RVA: 0x00014A20 File Offset: 0x00012C20
	public override string GetName()
	{
		return "Player Finder";
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00014A38 File Offset: 0x00012C38
	public override DYIPJORHeVCfbpocFHvJty4OE GetTabCounts()
	{
		return DYIPJORHeVCfbpocFHvJty4OE.Three;
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00014A4C File Offset: 0x00012C4C
	public override void DoTab(DYIPJORHeVCfbpocFHvJty4OE tc)
	{
		bool flag = tc == DYIPJORHeVCfbpocFHvJty4OE.One;
		bool flag2 = flag;
		if (flag2)
		{
			bool flag3 = DctFo1N3H1REM7tTTbNS0zMFm.Do9BgWpgEgWCPdRsavodBzZK0.Count == 0;
			bool flag4 = flag3;
			if (flag4)
			{
				GUILayout.Label("No players found", Array.Empty<GUILayoutOption>());
			}
			else
			{
				GUILayout.Label("Found:", Array.Empty<GUILayoutOption>());
				foreach (D5bADMxbfCFvG3WY9Gu4DXxc2 d5bADMxbfCFvG3WY9Gu4DXxc in DctFo1N3H1REM7tTTbNS0zMFm.Do9BgWpgEgWCPdRsavodBzZK0)
				{
					GUILayout.Label(string.Format("[{0}:{1}] {2} ({3})", new object[]
					{
						Parser.getIPFromUInt32(d5bADMxbfCFvG3WY9Gu4DXxc.D3XJYSi27OJvNWtyDo6HD4k2s),
						d5bADMxbfCFvG3WY9Gu4DXxc.D4Pd0nhobItTHR0G6QRCSGJ2k,
						d5bADMxbfCFvG3WY9Gu4DXxc.DpD6q0J0dxiY7ABvWfshJSJu6,
						d5bADMxbfCFvG3WY9Gu4DXxc.D2QipykXgcmh6DcKwJl9JQm8y
					}), Array.Empty<GUILayoutOption>());
				}
			}
		}
		else
		{
			bool flag5 = tc == DYIPJORHeVCfbpocFHvJty4OE.Two;
			bool flag6 = flag5;
			if (flag6)
			{
				bool flag7 = !DctFo1N3H1REM7tTTbNS0zMFm.Du63rJdwVDiFSuAn8z1xmL2WA && !DctFo1N3H1REM7tTTbNS0zMFm.DCsepIcVHGAxnfTORA2ru3dMD;
				bool flag8 = flag7;
				if (flag8)
				{
					GUILayout.Label("No data saved currently", Array.Empty<GUILayoutOption>());
				}
				else
				{
					bool du63rJdwVDiFSuAn8z1xmL2WA = DctFo1N3H1REM7tTTbNS0zMFm.Du63rJdwVDiFSuAn8z1xmL2WA;
					bool flag9 = du63rJdwVDiFSuAn8z1xmL2WA;
					if (flag9)
					{
						GUILayout.Label(string.Format("Scanned all servers ({0})", Provider.provider.matchmakingService.serverList.Count), Array.Empty<GUILayoutOption>());
					}
					else
					{
						bool flag10 = DctFo1N3H1REM7tTTbNS0zMFm.DCsepIcVHGAxnfTORA2ru3dMD && !DctFo1N3H1REM7tTTbNS0zMFm.Dx6tAxmLD4ao7rayEbofIUU6O;
						bool flag11 = flag10;
						if (flag11)
						{
							GUILayout.Label(string.Format("Fetching servers... (currently fetched {0})", Provider.provider.matchmakingService.serverList.Count), Array.Empty<GUILayoutOption>());
						}
						else
						{
							bool dcsepIcVHGAxnfTORA2ru3dMD = DctFo1N3H1REM7tTTbNS0zMFm.DCsepIcVHGAxnfTORA2ru3dMD;
							bool flag12 = dcsepIcVHGAxnfTORA2ru3dMD;
							if (flag12)
							{
								GUILayout.Label(string.Format("Servers fetched ({0})", Provider.provider.matchmakingService.serverList.Count), Array.Empty<GUILayoutOption>());
								GUILayout.Label(string.Format("Searching players ({0}/{1})", DctFo1N3H1REM7tTTbNS0zMFm.DrT4Un7f7TQcibF1EQRCFh40f, Provider.provider.matchmakingService.serverList.Count), Array.Empty<GUILayoutOption>());
							}
						}
					}
				}
			}
			else
			{
				bool flag13 = !DctFo1N3H1REM7tTTbNS0zMFm.DCsepIcVHGAxnfTORA2ru3dMD;
				bool flag14 = flag13;
				if (flag14)
				{
					GUILayout.Label("Enter username to search on unturned servers", Array.Empty<GUILayoutOption>());
					this.DrtRSRwH1MBrrcgC855FfYV0G = GUILayout.TextField(this.DrtRSRwH1MBrrcgC855FfYV0G, Array.Empty<GUILayoutOption>());
					bool flag15 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Start Searching", -1, true, null);
					bool flag16 = flag15;
					if (flag16)
					{
						DctFo1N3H1REM7tTTbNS0zMFm.Dxh9D78xpszRipcBnX4NnzBEh.D4b6Xgc7Vn87W91AEv0H5geTG(this.DrtRSRwH1MBrrcgC855FfYV0G);
					}
				}
				else
				{
					bool flag17 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Stop searching", -1, true, null);
					bool flag18 = flag17;
					if (flag18)
					{
						DctFo1N3H1REM7tTTbNS0zMFm.Dxh9D78xpszRipcBnX4NnzBEh.D07RAI1zVmNf0RGp4lloUzfZD();
					}
				}
			}
		}
	}

	// Token: 0x040001D4 RID: 468
	public string DrtRSRwH1MBrrcgC855FfYV0G = "";
}
