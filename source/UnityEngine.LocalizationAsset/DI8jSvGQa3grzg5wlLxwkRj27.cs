using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000071 RID: 113
public class DI8jSvGQa3grzg5wlLxwkRj27
{
	// Token: 0x0600022F RID: 559 RVA: 0x0001FECC File Offset: 0x0001E0CC
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void Dfds9L9hB5b6JAAlBSpl90xOY()
	{
		for (int i = 0; i < DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx.Length; i++)
		{
			DI8jSvGQa3grzg5wlLxwkRj27.DGRl1OSuWDfLHAwgfgXn2RDh5.Add(DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx[i].DWbR5ZP7ADKEsIvHcKBygMxjM, i);
		}
	}

	// Token: 0x06000230 RID: 560 RVA: 0x0001FF10 File Offset: 0x0001E110
	public static void DHGIUKVUc0616fllctrAq5z3g()
	{
		Camera camera = ((MainCamera.instance != null) ? MainCamera.instance : Camera.main);
		DI8jSvGQa3grzg5wlLxwkRj27.DQFkMWa2CkMTjfphEuqRxQPK1 = Screen.width / 2;
		DI8jSvGQa3grzg5wlLxwkRj27.DVyvEDJQf1gB3xjuAVRfelEv7 = Screen.height / 2;
		DDddnUl0gHJ8ZiQTaRLEUBUS2.DRU76pLEmpRdoUUcrMxfLqXNx.SetPass(0);
		GL.Begin(1);
		foreach (DxMhfufThyuW1UdZ5MxaTXe5X dxMhfufThyuW1UdZ5MxaTXe5X in DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx)
		{
			bool flag = !dxMhfufThyuW1UdZ5MxaTXe5X.DdJLT0ED9ZAHsRZNxEeJBnO0u || (dxMhfufThyuW1UdZ5MxaTXe5X.DOLmx5RkuOjHpeEjmTlxmZb3r != null && !dxMhfufThyuW1UdZ5MxaTXe5X.DOLmx5RkuOjHpeEjmTlxmZb3r());
			bool flag2 = !flag;
			if (flag2)
			{
				DSuKLIF35AtXmFdSPtbkEXBdM dsuKLIF35AtXmFdSPtbkEXBdM = DNbYBVifu73t6Hq5vgTtgKwS7.DaXgkzF0n71hmkyAbipgooHRa(dxMhfufThyuW1UdZ5MxaTXe5X.DrxOMnA0vrh16bqb8c31ceGwg);
				GL.Color(dsuKLIF35AtXmFdSPtbkEXBdM.settedColor);
				float num;
				try
				{
					num = (dxMhfufThyuW1UdZ5MxaTXe5X.D90SIYM0nK4JzltkCLOO2tC9W ? ((float)(Math.Tan((double)dxMhfufThyuW1UdZ5MxaTXe5X.DUaDiNVOB0LNpeLRG2Kl45eCO * 0.017453292519943295 / 2.0) / Math.Tan((double)camera.fieldOfView * 0.017453292519943295 / 2.0) * (double)Screen.height)) : ((float)dxMhfufThyuW1UdZ5MxaTXe5X.DmRnVyPFw4pRyg9yK4EgKaCJ1));
				}
				catch
				{
					num = (dxMhfufThyuW1UdZ5MxaTXe5X.D90SIYM0nK4JzltkCLOO2tC9W ? ((float)(Math.Tan((double)dxMhfufThyuW1UdZ5MxaTXe5X.DUaDiNVOB0LNpeLRG2Kl45eCO * 0.017453292519943295 / 2.0) / Math.Tan(0.3490658503988659) * (double)Screen.height)) : ((float)dxMhfufThyuW1UdZ5MxaTXe5X.DmRnVyPFw4pRyg9yK4EgKaCJ1));
				}
				bool flag3 = dxMhfufThyuW1UdZ5MxaTXe5X.DI0180nN7XhRNpDZgQD6PU9pk && dsuKLIF35AtXmFdSPtbkEXBdM.isGradient;
				bool flag4 = flag3;
				if (flag4)
				{
					for (float num2 = 0f; num2 < 6.2831855f; num2 += 0.05f)
					{
						float num3 = num2 * 0.15915494f + dsuKLIF35AtXmFdSPtbkEXBdM.DP0vPDFDOZUt4qFigtsVpWTYq;
						bool flag5 = num3 > 1f;
						bool flag6 = flag5;
						if (flag6)
						{
							num3 -= 1f;
						}
						GL.Color(DNbYBVifu73t6Hq5vgTtgKwS7.DENJqVQ0NvDFiPjELxslOY2IM(num3, dsuKLIF35AtXmFdSPtbkEXBdM.settedColor.a));
						GL.Vertex(new Vector3(Mathf.Cos(num2) * num + (float)DI8jSvGQa3grzg5wlLxwkRj27.DQFkMWa2CkMTjfphEuqRxQPK1, Mathf.Sin(num2) * num + (float)DI8jSvGQa3grzg5wlLxwkRj27.DVyvEDJQf1gB3xjuAVRfelEv7));
						GL.Vertex(new Vector3(Mathf.Cos(num2 + 0.05f) * num + (float)DI8jSvGQa3grzg5wlLxwkRj27.DQFkMWa2CkMTjfphEuqRxQPK1, Mathf.Sin(num2 + 0.05f) * num + (float)DI8jSvGQa3grzg5wlLxwkRj27.DVyvEDJQf1gB3xjuAVRfelEv7));
					}
				}
				else
				{
					for (float num4 = 0f; num4 < 6.2831855f; num4 += 0.05f)
					{
						GL.Vertex(new Vector3(Mathf.Cos(num4) * num + (float)DI8jSvGQa3grzg5wlLxwkRj27.DQFkMWa2CkMTjfphEuqRxQPK1, Mathf.Sin(num4) * num + (float)DI8jSvGQa3grzg5wlLxwkRj27.DVyvEDJQf1gB3xjuAVRfelEv7));
						GL.Vertex(new Vector3(Mathf.Cos(num4 + 0.05f) * num + (float)DI8jSvGQa3grzg5wlLxwkRj27.DQFkMWa2CkMTjfphEuqRxQPK1, Mathf.Sin(num4 + 0.05f) * num + (float)DI8jSvGQa3grzg5wlLxwkRj27.DVyvEDJQf1gB3xjuAVRfelEv7));
					}
				}
			}
		}
		GL.End();
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00020238 File Offset: 0x0001E438
	public static bool Dm3ve9IOegAxCqnOp7olhZmq2(string fovName, Vector2 point, int distance = -1)
	{
		DxMhfufThyuW1UdZ5MxaTXe5X dxMhfufThyuW1UdZ5MxaTXe5X = DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx[DI8jSvGQa3grzg5wlLxwkRj27.DGRl1OSuWDfLHAwgfgXn2RDh5[fovName]];
		bool flag = distance == -1;
		bool flag2 = flag;
		if (flag2)
		{
			distance = (int)Vector2.Distance(new Vector2((float)DI8jSvGQa3grzg5wlLxwkRj27.DQFkMWa2CkMTjfphEuqRxQPK1, (float)DI8jSvGQa3grzg5wlLxwkRj27.DVyvEDJQf1gB3xjuAVRfelEv7), point);
		}
		return distance < DI8jSvGQa3grzg5wlLxwkRj27.DiVnciTIS4luT6euJI5uVN1i1(dxMhfufThyuW1UdZ5MxaTXe5X);
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00020290 File Offset: 0x0001E490
	public static int DzGDOq0dZL2sIXJTdcfSy2A4v(string fovName)
	{
		return DI8jSvGQa3grzg5wlLxwkRj27.DiVnciTIS4luT6euJI5uVN1i1(DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx[DI8jSvGQa3grzg5wlLxwkRj27.DGRl1OSuWDfLHAwgfgXn2RDh5[fovName]]);
	}

	// Token: 0x06000233 RID: 563 RVA: 0x000202BC File Offset: 0x0001E4BC
	public static int DiVnciTIS4luT6euJI5uVN1i1(DxMhfufThyuW1UdZ5MxaTXe5X fov)
	{
		return fov.D90SIYM0nK4JzltkCLOO2tC9W ? ((int)(Math.Tan((double)fov.DUaDiNVOB0LNpeLRG2Kl45eCO * 0.017453292519943295 / 2.0) / Math.Tan((double)((MainCamera.instance != null) ? MainCamera.instance : Camera.main).fieldOfView * 0.017453292519943295 / 2.0) * (double)Screen.height)) : fov.DmRnVyPFw4pRyg9yK4EgKaCJ1;
	}

	// Token: 0x040002CC RID: 716
	public static DxMhfufThyuW1UdZ5MxaTXe5X[] Dn309fO43630bka11xdbHEzIx = new DxMhfufThyuW1UdZ5MxaTXe5X[]
	{
		new DxMhfufThyuW1UdZ5MxaTXe5X("Aimbot FOV", "Aimbot FOV color", null),
		new DxMhfufThyuW1UdZ5MxaTXe5X("Grab items through walls FOV", "Grab items through walls FOV color", null),
		new DxMhfufThyuW1UdZ5MxaTXe5X("Independent player info targeting FOV", "Independent player info targeting color", null)
	};

	// Token: 0x040002CD RID: 717
	public static Dictionary<string, int> DGRl1OSuWDfLHAwgfgXn2RDh5 = new Dictionary<string, int>();

	// Token: 0x040002CE RID: 718
	private static int DQFkMWa2CkMTjfphEuqRxQPK1 = 0;

	// Token: 0x040002CF RID: 719
	private static int DVyvEDJQf1gB3xjuAVRfelEv7 = 0;
}
