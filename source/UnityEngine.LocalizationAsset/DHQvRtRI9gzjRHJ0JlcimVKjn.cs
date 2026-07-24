using System;
using UnityEngine;

// Token: 0x0200006C RID: 108
public class DHQvRtRI9gzjRHJ0JlcimVKjn : DOEkZ1zoBEuvfUmOs9QSpfX0X
{
	// Token: 0x06000215 RID: 533 RVA: 0x0001D470 File Offset: 0x0001B670
	public override string GetName()
	{
		return "Keybinds";
	}

	// Token: 0x06000216 RID: 534 RVA: 0x0001D488 File Offset: 0x0001B688
	public override DYIPJORHeVCfbpocFHvJty4OE GetTabCounts()
	{
		return DYIPJORHeVCfbpocFHvJty4OE.Three;
	}

	// Token: 0x06000217 RID: 535 RVA: 0x0001D49C File Offset: 0x0001B69C
	public override void DoTab(DYIPJORHeVCfbpocFHvJty4OE tc)
	{
		bool flag = tc == DYIPJORHeVCfbpocFHvJty4OE.One;
		bool flag2 = flag;
		if (flag2)
		{
			this.D64OmssaoFr4LMmnYAqSF8ZZD[0] = GUILayout.BeginScrollView(this.D64OmssaoFr4LMmnYAqSF8ZZD[0], Array.Empty<GUILayoutOption>());
			foreach (Dr3ZjnRxP0iAQVvAkuCp9m5Mb dr3ZjnRxP0iAQVvAkuCp9m5Mb in D78avTg9KcyX9xog2Gp420bvj.D8ZjqswnJ6Qd5Y9cj1DN6e0Om)
			{
				bool flag3 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv(string.Concat(new string[]
				{
					"[",
					(dr3ZjnRxP0iAQVvAkuCp9m5Mb.D3eAlPfDoZwNnDAcknyn7stsA == DKTrjQa1HNIdKaR8WkdJ1SrM6.Keyboard) ? dr3ZjnRxP0iAQVvAkuCp9m5Mb.DU2mPiOIQ9Bcy6xHJlZal0eNJ.ToString() : dr3ZjnRxP0iAQVvAkuCp9m5Mb.D3eAlPfDoZwNnDAcknyn7stsA.ToString(),
					"] ",
					D78avTg9KcyX9xog2Gp420bvj.DYefbQbp0hgXlm8EMjG3ntvLV[dr3ZjnRxP0iAQVvAkuCp9m5Mb.D00PVeHLDw7ARnIOpGcUNHUOG].DSeUndaogFZMCyQwuPXCHirHD,
					" > ",
					dr3ZjnRxP0iAQVvAkuCp9m5Mb.D00PVeHLDw7ARnIOpGcUNHUOG
				}), -1, true, null) && !D78avTg9KcyX9xog2Gp420bvj.DaDVuyXoGh5CtNAjpbSI9fhho;
				bool flag4 = flag3;
				if (flag4)
				{
					DHQvRtRI9gzjRHJ0JlcimVKjn.DTJICBRmaNmkP0dD3QCiL0YNJ = false;
					DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn = dr3ZjnRxP0iAQVvAkuCp9m5Mb;
				}
			}
			bool flag5 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Add key", -1, true, null);
			bool flag6 = flag5;
			if (flag6)
			{
				DHQvRtRI9gzjRHJ0JlcimVKjn.DQeMpWgq0hN8p0qnsAyf6Ey0I = false;
				DHQvRtRI9gzjRHJ0JlcimVKjn.DTJICBRmaNmkP0dD3QCiL0YNJ = true;
			}
			GUILayout.EndScrollView();
		}
		else
		{
			bool flag7 = tc == DYIPJORHeVCfbpocFHvJty4OE.Two;
			bool flag8 = flag7;
			if (flag8)
			{
				this.D64OmssaoFr4LMmnYAqSF8ZZD[1] = GUILayout.BeginScrollView(this.D64OmssaoFr4LMmnYAqSF8ZZD[1], Array.Empty<GUILayoutOption>());
				bool dtjicbrmaNmkP0dD3QCiL0YNJ = DHQvRtRI9gzjRHJ0JlcimVKjn.DTJICBRmaNmkP0dD3QCiL0YNJ;
				bool flag9 = dtjicbrmaNmkP0dD3QCiL0YNJ;
				if (flag9)
				{
					foreach (string text in D78avTg9KcyX9xog2Gp420bvj.DAlPjEdZCjnLRuPAOafKPVKP8)
					{
						bool flag10 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv(text, -1, true, null);
						bool flag11 = flag10;
						if (flag11)
						{
							DHQvRtRI9gzjRHJ0JlcimVKjn.D7jI9eH7AANSEr8V2hpWOY12B = text;
						}
					}
				}
				else
				{
					bool flag12 = DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn != null;
					bool flag13 = flag12;
					if (flag13)
					{
						GUILayout.Label(string.Concat(new string[]
						{
							"[",
							(DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn.D3eAlPfDoZwNnDAcknyn7stsA == DKTrjQa1HNIdKaR8WkdJ1SrM6.Keyboard) ? DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn.DU2mPiOIQ9Bcy6xHJlZal0eNJ.ToString() : DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn.D3eAlPfDoZwNnDAcknyn7stsA.ToString(),
							"] ",
							D78avTg9KcyX9xog2Gp420bvj.DYefbQbp0hgXlm8EMjG3ntvLV[DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn.D00PVeHLDw7ARnIOpGcUNHUOG].DSeUndaogFZMCyQwuPXCHirHD,
							" > ",
							DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn.D00PVeHLDw7ARnIOpGcUNHUOG
						}), Array.Empty<GUILayoutOption>());
						bool flag14 = D78avTg9KcyX9xog2Gp420bvj.DYefbQbp0hgXlm8EMjG3ntvLV[DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn.D00PVeHLDw7ARnIOpGcUNHUOG].Dv4vSs5g9egSFlqScEroJsFiM != null;
						bool flag15 = flag14;
						if (flag15)
						{
							GUILayout.Label("Operand: " + D78avTg9KcyX9xog2Gp420bvj.DYefbQbp0hgXlm8EMjG3ntvLV[DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn.D00PVeHLDw7ARnIOpGcUNHUOG].Dv4vSs5g9egSFlqScEroJsFiM.GetOperandValue(), Array.Empty<GUILayoutOption>());
							bool flag16 = D78avTg9KcyX9xog2Gp420bvj.DYefbQbp0hgXlm8EMjG3ntvLV[DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn.D00PVeHLDw7ARnIOpGcUNHUOG].DgcRwlgf80UjnZhCnm1m1Km6B == null && DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Change operand", -1, true, null);
							bool flag17 = flag16;
							if (flag17)
							{
								DHQvRtRI9gzjRHJ0JlcimVKjn.DQeMpWgq0hN8p0qnsAyf6Ey0I = !DHQvRtRI9gzjRHJ0JlcimVKjn.DQeMpWgq0hN8p0qnsAyf6Ey0I;
							}
						}
						bool flag18 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Change bind", -1, true, null);
						bool flag19 = flag18;
						if (flag19)
						{
							D78avTg9KcyX9xog2Gp420bvj.DkAprtFTHJouK7cd2EiFIp3gB(DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn.D00PVeHLDw7ARnIOpGcUNHUOG);
						}
						DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn.D3eAlPfDoZwNnDAcknyn7stsA = DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn.D3eAlPfDoZwNnDAcknyn7stsA.DdoC7WUc7IFAmnWoLcSWPOXFw("Bind type:", "");
						bool flag20 = DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn.D00PVeHLDw7ARnIOpGcUNHUOG == "Open menu";
						bool flag21 = flag20;
						if (flag21)
						{
							GUILayout.Label("You cannot delete this bind", Array.Empty<GUILayoutOption>());
						}
						else
						{
							bool flag22 = !D78avTg9KcyX9xog2Gp420bvj.DaDVuyXoGh5CtNAjpbSI9fhho && DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Remove key", -1, true, null);
							bool flag23 = flag22;
							if (flag23)
							{
								D78avTg9KcyX9xog2Gp420bvj.D0M8oqZSyGBdeTYSinVy9wlJt.Remove(DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn.D00PVeHLDw7ARnIOpGcUNHUOG);
								D78avTg9KcyX9xog2Gp420bvj.D8ZjqswnJ6Qd5Y9cj1DN6e0Om.Remove(DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn);
							}
						}
					}
					else
					{
						GUILayout.Label("Select a bind", Array.Empty<GUILayoutOption>());
					}
				}
				GUILayout.EndScrollView();
			}
			else
			{
				this.D64OmssaoFr4LMmnYAqSF8ZZD[2] = GUILayout.BeginScrollView(this.D64OmssaoFr4LMmnYAqSF8ZZD[2], Array.Empty<GUILayoutOption>());
				bool daDVuyXoGh5CtNAjpbSI9fhho = D78avTg9KcyX9xog2Gp420bvj.DaDVuyXoGh5CtNAjpbSI9fhho;
				bool flag24 = daDVuyXoGh5CtNAjpbSI9fhho;
				if (flag24)
				{
					GUILayout.Label("Press any key to bind it", Array.Empty<GUILayoutOption>());
				}
				else
				{
					bool dtjicbrmaNmkP0dD3QCiL0YNJ2 = DHQvRtRI9gzjRHJ0JlcimVKjn.DTJICBRmaNmkP0dD3QCiL0YNJ;
					bool flag25 = dtjicbrmaNmkP0dD3QCiL0YNJ2;
					if (flag25)
					{
						foreach (DGM8QBfL795yoNKOj7zPTCd8n dgm8QBfL795yoNKOj7zPTCd8n in D78avTg9KcyX9xog2Gp420bvj.DYefbQbp0hgXlm8EMjG3ntvLV.Values)
						{
							bool flag26 = dgm8QBfL795yoNKOj7zPTCd8n.DSeUndaogFZMCyQwuPXCHirHD == DHQvRtRI9gzjRHJ0JlcimVKjn.D7jI9eH7AANSEr8V2hpWOY12B && !D78avTg9KcyX9xog2Gp420bvj.D0M8oqZSyGBdeTYSinVy9wlJt.Contains(dgm8QBfL795yoNKOj7zPTCd8n.DNEeHq8jauwEHK1muB5dRDMee) && DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv(dgm8QBfL795yoNKOj7zPTCd8n.DNEeHq8jauwEHK1muB5dRDMee, -1, true, null);
							bool flag27 = flag26;
							if (flag27)
							{
								D78avTg9KcyX9xog2Gp420bvj.DkAprtFTHJouK7cd2EiFIp3gB(dgm8QBfL795yoNKOj7zPTCd8n.DNEeHq8jauwEHK1muB5dRDMee);
							}
						}
					}
					else
					{
						bool dqeMpWgq0hN8p0qnsAyf6Ey0I = DHQvRtRI9gzjRHJ0JlcimVKjn.DQeMpWgq0hN8p0qnsAyf6Ey0I;
						bool flag28 = dqeMpWgq0hN8p0qnsAyf6Ey0I;
						if (flag28)
						{
							D78avTg9KcyX9xog2Gp420bvj.DYefbQbp0hgXlm8EMjG3ntvLV[DHQvRtRI9gzjRHJ0JlcimVKjn.DAg4EZgqQaAj4vQKYLAHbbVBn.D00PVeHLDw7ARnIOpGcUNHUOG].Dv4vSs5g9egSFlqScEroJsFiM.DrawConfigureTab();
						}
					}
				}
				GUILayout.EndScrollView();
			}
		}
	}

	// Token: 0x04000296 RID: 662
	public static bool DTJICBRmaNmkP0dD3QCiL0YNJ = false;

	// Token: 0x04000297 RID: 663
	public static bool DQeMpWgq0hN8p0qnsAyf6Ey0I = false;

	// Token: 0x04000298 RID: 664
	public static Dr3ZjnRxP0iAQVvAkuCp9m5Mb DAg4EZgqQaAj4vQKYLAHbbVBn;

	// Token: 0x04000299 RID: 665
	public static string D7jI9eH7AANSEr8V2hpWOY12B = "";

	// Token: 0x0400029A RID: 666
	public Vector2[] D64OmssaoFr4LMmnYAqSF8ZZD = new Vector2[3];
}
