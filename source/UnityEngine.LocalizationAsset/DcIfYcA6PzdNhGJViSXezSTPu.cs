using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200003E RID: 62
public class DcIfYcA6PzdNhGJViSXezSTPu : DOEkZ1zoBEuvfUmOs9QSpfX0X
{
	// Token: 0x06000109 RID: 265 RVA: 0x0000B6EC File Offset: 0x000098EC
	public override string GetName()
	{
		return "Other";
	}

	// Token: 0x0600010A RID: 266 RVA: 0x0000B704 File Offset: 0x00009904
	public override DYIPJORHeVCfbpocFHvJty4OE GetTabCounts()
	{
		return DYIPJORHeVCfbpocFHvJty4OE.Three;
	}

	// Token: 0x0600010B RID: 267 RVA: 0x0000B718 File Offset: 0x00009918
	public override void DoTab(DYIPJORHeVCfbpocFHvJty4OE tc)
	{
		bool flag = tc == DYIPJORHeVCfbpocFHvJty4OE.One;
		if (flag)
		{
			base.DGLNJE6Ld056OViYFjOM7IeMS("FOV Sizes");
			for (int i = 0; i < DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx.Length; i++)
			{
				bool flag2 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv(DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx[i].DWbR5ZP7ADKEsIvHcKBygMxjM, -1, true, null);
				if (flag2)
				{
					this.DgQb4LW2H7LyIGMvnGDoDw5rt = i;
				}
			}
		}
		else
		{
			bool flag3 = tc != DYIPJORHeVCfbpocFHvJty4OE.Two;
			if (flag3)
			{
				base.DGLNJE6Ld056OViYFjOM7IeMS("Experimental");
				bool flag4 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Disconnect from server", -1, true, null) && Provider.isConnected;
				if (flag4)
				{
					Provider.disconnect();
				}
				GUILayout.Label("bytesSent: " + Provider.bytesSent.ToString(), Array.Empty<GUILayoutOption>());
				GUILayout.Label("bytesRecieved: " + Provider.bytesReceived.ToString(), Array.Empty<GUILayoutOption>());
				GUILayout.Label("packetsSent: " + Provider.packetsSent.ToString(), Array.Empty<GUILayoutOption>());
				GUILayout.Label("packetsRecieved: " + Provider.packetsReceived.ToString(), Array.Empty<GUILayoutOption>());
			}
			else
			{
				bool flag5 = DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx.Length < this.DgQb4LW2H7LyIGMvnGDoDw5rt;
				if (flag5)
				{
					base.DGLNJE6Ld056OViYFjOM7IeMS("FOV option");
				}
				else
				{
					DxMhfufThyuW1UdZ5MxaTXe5X dxMhfufThyuW1UdZ5MxaTXe5X = DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx[this.DgQb4LW2H7LyIGMvnGDoDw5rt];
					base.DGLNJE6Ld056OViYFjOM7IeMS(dxMhfufThyuW1UdZ5MxaTXe5X.DWbR5ZP7ADKEsIvHcKBygMxjM);
					dxMhfufThyuW1UdZ5MxaTXe5X.DdJLT0ED9ZAHsRZNxEeJBnO0u = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(dxMhfufThyuW1UdZ5MxaTXe5X.DdJLT0ED9ZAHsRZNxEeJBnO0u, "Draw FOV", Array.Empty<GUILayoutOption>());
					bool flag6 = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(dxMhfufThyuW1UdZ5MxaTXe5X.DI0180nN7XhRNpDZgQD6PU9pk, "Rainbow fading", Array.Empty<GUILayoutOption>());
					bool flag7 = flag6 != dxMhfufThyuW1UdZ5MxaTXe5X.DI0180nN7XhRNpDZgQD6PU9pk;
					if (flag7)
					{
						dxMhfufThyuW1UdZ5MxaTXe5X.DI0180nN7XhRNpDZgQD6PU9pk = flag6;
						DSuKLIF35AtXmFdSPtbkEXBdM dsuKLIF35AtXmFdSPtbkEXBdM = DNbYBVifu73t6Hq5vgTtgKwS7.DaXgkzF0n71hmkyAbipgooHRa(dxMhfufThyuW1UdZ5MxaTXe5X.DrxOMnA0vrh16bqb8c31ceGwg);
						dsuKLIF35AtXmFdSPtbkEXBdM.isGradient = flag6;
					}
					try
					{
						dxMhfufThyuW1UdZ5MxaTXe5X.D90SIYM0nK4JzltkCLOO2tC9W = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(dxMhfufThyuW1UdZ5MxaTXe5X.D90SIYM0nK4JzltkCLOO2tC9W, "Use FOV scaled system", Array.Empty<GUILayoutOption>());
						bool d90SIYM0nK4JzltkCLOO2tC9W = dxMhfufThyuW1UdZ5MxaTXe5X.D90SIYM0nK4JzltkCLOO2tC9W;
						if (d90SIYM0nK4JzltkCLOO2tC9W)
						{
							dxMhfufThyuW1UdZ5MxaTXe5X.DUaDiNVOB0LNpeLRG2Kl45eCO = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("FOV scale: ", dxMhfufThyuW1UdZ5MxaTXe5X.DUaDiNVOB0LNpeLRG2Kl45eCO, 1, ((MainCamera.instance != null) ? ((int)MainCamera.instance.fieldOfView) : ((int)Camera.current.fieldOfView)) + 40, -1);
						}
						else
						{
							dxMhfufThyuW1UdZ5MxaTXe5X.DmRnVyPFw4pRyg9yK4EgKaCJ1 = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("FOV pixels: ", dxMhfufThyuW1UdZ5MxaTXe5X.DmRnVyPFw4pRyg9yK4EgKaCJ1, 1, 400, -1);
						}
					}
					catch
					{
					}
					DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx[this.DgQb4LW2H7LyIGMvnGDoDw5rt] = dxMhfufThyuW1UdZ5MxaTXe5X;
				}
			}
		}
	}

	// Token: 0x04000137 RID: 311
	public Vector2 D4N2IwRjbweaLQQNH6WRbTJIx = Vector2.zero;

	// Token: 0x04000138 RID: 312
	public int DgQb4LW2H7LyIGMvnGDoDw5rt;
}
