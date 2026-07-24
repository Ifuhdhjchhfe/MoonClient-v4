using System;
using UnityEngine;

// Token: 0x020000E6 RID: 230
internal class DzyNHKLp09j52n0SlzuyYzWLO : DSvAEyoSitLrXzsZSSRwWfJ5T
{
	// Token: 0x0600043E RID: 1086 RVA: 0x0003F598 File Offset: 0x0003D798
	public override bool GetAviablity()
	{
		return DzyNHKLp09j52n0SlzuyYzWLO.D2z3wgffCs5mdzBDlB9Nos4z4;
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x0003F5B0 File Offset: 0x0003D7B0
	public override Vector2 GetSize()
	{
		return new Vector2(320f, 400f);
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x0003F5D4 File Offset: 0x0003D7D4
	public override bool IsShowOnMenu()
	{
		return true;
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x0003F5E8 File Offset: 0x0003D7E8
	public override void DrawWindow()
	{
		base.DZxuXSmWDxed28SbJ8XfD3yXH("Change Font");
		GUILayout.BeginArea(new Rect(base.windowRect.x, base.windowRect.y, 320f, 400f));
		GUILayout.Space(20f);
		bool flag = GUILayout.Button("Close", Array.Empty<GUILayoutOption>());
		if (flag)
		{
			DzyNHKLp09j52n0SlzuyYzWLO.D2z3wgffCs5mdzBDlB9Nos4z4 = false;
		}
		try
		{
			bool flag2 = GUILayout.Button("Reset font", Array.Empty<GUILayoutOption>());
			if (flag2)
			{
				Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[DzyNHKLp09j52n0SlzuyYzWLO.D2k9MbEp45loz9gMSYArPq7ff].D0x2CpNPv5G0vo17K1zILyhFc.font = DHTB5RKsHUihFrfj9ewuLh1f9.DSqLh3shLXYAnX4d0AcIljoVC.font;
				Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[DzyNHKLp09j52n0SlzuyYzWLO.D2k9MbEp45loz9gMSYArPq7ff].Dxn8NngmWnv3B0QlK16ladv8o.font = DHTB5RKsHUihFrfj9ewuLh1f9.DcCtNCaSVWm57cNorggPJBWVH.font;
				Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[DzyNHKLp09j52n0SlzuyYzWLO.D2k9MbEp45loz9gMSYArPq7ff].DtECvjV4pdRgipzbc5gFB02hU = "";
			}
			bool flag3 = DzyNHKLp09j52n0SlzuyYzWLO.DN0WFRexhy8yyrDalLHteZiAo == null;
			if (flag3)
			{
				DzyNHKLp09j52n0SlzuyYzWLO.DN0WFRexhy8yyrDalLHteZiAo = new GUIStyle(GUI.skin.button);
			}
		}
		catch
		{
		}
		DzyNHKLp09j52n0SlzuyYzWLO.DIycrtC0IXsGMV7uPE54EdLoZ = GUILayout.BeginScrollView(DzyNHKLp09j52n0SlzuyYzWLO.DIycrtC0IXsGMV7uPE54EdLoZ, Array.Empty<GUILayoutOption>());
		try
		{
			for (int i = 0; i < DRiUgFwe1bGGW0FKHIPOjT4PT.DPjwh94gPzgXg5pL1YCdYACP9.Length; i++)
			{
				DzyNHKLp09j52n0SlzuyYzWLO.DN0WFRexhy8yyrDalLHteZiAo.font = DRiUgFwe1bGGW0FKHIPOjT4PT.DPjwh94gPzgXg5pL1YCdYACP9[i].Item2;
				bool flag4 = GUILayout.Button(DRiUgFwe1bGGW0FKHIPOjT4PT.DPjwh94gPzgXg5pL1YCdYACP9[i].Item1, DzyNHKLp09j52n0SlzuyYzWLO.DN0WFRexhy8yyrDalLHteZiAo, Array.Empty<GUILayoutOption>());
				if (flag4)
				{
					Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[DzyNHKLp09j52n0SlzuyYzWLO.D2k9MbEp45loz9gMSYArPq7ff].D0x2CpNPv5G0vo17K1zILyhFc.font = DRiUgFwe1bGGW0FKHIPOjT4PT.DPjwh94gPzgXg5pL1YCdYACP9[i].Item2;
					Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[DzyNHKLp09j52n0SlzuyYzWLO.D2k9MbEp45loz9gMSYArPq7ff].Dxn8NngmWnv3B0QlK16ladv8o.font = DRiUgFwe1bGGW0FKHIPOjT4PT.DPjwh94gPzgXg5pL1YCdYACP9[i].Item2;
					Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[DzyNHKLp09j52n0SlzuyYzWLO.D2k9MbEp45loz9gMSYArPq7ff].DtECvjV4pdRgipzbc5gFB02hU = DRiUgFwe1bGGW0FKHIPOjT4PT.DPjwh94gPzgXg5pL1YCdYACP9[i].Item1;
				}
			}
		}
		catch
		{
		}
		GUILayout.EndScrollView();
		GUILayout.EndArea();
	}

	// Token: 0x04000494 RID: 1172
	public static bool D2z3wgffCs5mdzBDlB9Nos4z4 = false;

	// Token: 0x04000495 RID: 1173
	public static Vector2 DIycrtC0IXsGMV7uPE54EdLoZ = Vector2.zero;

	// Token: 0x04000496 RID: 1174
	public static int D2k9MbEp45loz9gMSYArPq7ff = 0;

	// Token: 0x04000497 RID: 1175
	public static GUIStyle DN0WFRexhy8yyrDalLHteZiAo;

	// Token: 0x04000498 RID: 1176
	public static int Db7DaTGTJ0h3p089mTo7y3Jzc = 14;
}
