using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000012 RID: 18
public static class D3f0KiczWTsJY2M5PeRmfRwBr
{
	// Token: 0x06000052 RID: 82 RVA: 0x00004F68 File Offset: 0x00003168
	public static D7ElSFH0pY0XmMbO1Ij5Yf3Tp DKNSZQDiOqRmE91opKn8LhCXe(this Player p)
	{
		D7ElSFH0pY0XmMbO1Ij5Yf3Tp d7ElSFH0pY0XmMbO1Ij5Yf3Tp;
		bool flag = D7ElSFH0pY0XmMbO1Ij5Yf3Tp.Dvs6QtvhDlgYO3NyBTyui6hw6.TryGetValue(p.GetNetId().id, out d7ElSFH0pY0XmMbO1Ij5Yf3Tp) || D7ElSFH0pY0XmMbO1Ij5Yf3Tp.DI6hlaHSvDDrbtUXgu1QazZzt.TryGetValue(p, out d7ElSFH0pY0XmMbO1Ij5Yf3Tp);
		bool flag2 = flag;
		D7ElSFH0pY0XmMbO1Ij5Yf3Tp d7ElSFH0pY0XmMbO1Ij5Yf3Tp2;
		if (flag2)
		{
			d7ElSFH0pY0XmMbO1Ij5Yf3Tp2 = d7ElSFH0pY0XmMbO1Ij5Yf3Tp;
		}
		else
		{
			bool flag3 = p.TryGetComponent<D7ElSFH0pY0XmMbO1Ij5Yf3Tp>(out d7ElSFH0pY0XmMbO1Ij5Yf3Tp);
			bool flag4 = flag3;
			if (flag4)
			{
				d7ElSFH0pY0XmMbO1Ij5Yf3Tp2 = d7ElSFH0pY0XmMbO1Ij5Yf3Tp;
			}
			else
			{
				d7ElSFH0pY0XmMbO1Ij5Yf3Tp2 = p.gameObject.AddComponent<D7ElSFH0pY0XmMbO1Ij5Yf3Tp>();
			}
		}
		return d7ElSFH0pY0XmMbO1Ij5Yf3Tp2;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00004FDC File Offset: 0x000031DC
	public static Vector3 DqpvkRCCm2sxv8fMSwLej7Wt3(this Player p)
	{
		Vector3 vector;
		try
		{
			bool flag = DCS4Jf0LRzsehKFc5QOLL06qw.enableAimbot && !DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim;
			bool flag2 = flag;
			if (flag2)
			{
				bool bestAimbotPartPreselective = DCS4Jf0LRzsehKFc5QOLL06qw.bestAimbotPartPreselective;
				bool flag3 = bestAimbotPartPreselective;
				if (flag3)
				{
					vector = p.DKNSZQDiOqRmE91opKn8LhCXe().DB8DY4PxMp5j6tymH8MuHtu8L();
				}
				else
				{
					vector = p.DKNSZQDiOqRmE91opKn8LhCXe().Dzo9lNH7U2XEdXM6IlStBGiUs(DCS4Jf0LRzsehKFc5QOLL06qw.aimbotLimb);
				}
			}
			else
			{
				bool hitPointToTransform = DCS4Jf0LRzsehKFc5QOLL06qw.hitPointToTransform;
				bool flag4 = hitPointToTransform;
				if (flag4)
				{
					vector = p.transform.position;
				}
				else
				{
					bool bestSilentAimPartPreselective = DCS4Jf0LRzsehKFc5QOLL06qw.bestSilentAimPartPreselective;
					bool flag5 = bestSilentAimPartPreselective;
					if (flag5)
					{
						vector = p.DKNSZQDiOqRmE91opKn8LhCXe().DB8DY4PxMp5j6tymH8MuHtu8L();
					}
					else
					{
						vector = p.DKNSZQDiOqRmE91opKn8LhCXe().Dzo9lNH7U2XEdXM6IlStBGiUs(DCS4Jf0LRzsehKFc5QOLL06qw.silentAimHitPointLimb);
					}
				}
			}
		}
		catch
		{
			vector = p.transform.position;
		}
		return vector;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x000050B8 File Offset: 0x000032B8
	public static Transform DZ1neBHBeQuVqC6Wm1V5KB69h(this Player p)
	{
		bool flag = DCS4Jf0LRzsehKFc5QOLL06qw.enableAimbot && !DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim;
		bool flag2 = flag;
		Transform transform;
		if (flag2)
		{
			bool bestAimbotPartPreselective = DCS4Jf0LRzsehKFc5QOLL06qw.bestAimbotPartPreselective;
			bool flag3 = bestAimbotPartPreselective;
			if (flag3)
			{
				transform = p.DKNSZQDiOqRmE91opKn8LhCXe().Di1EVHMrJyeCCJIVX4L04N0Mf();
			}
			else
			{
				transform = p.DKNSZQDiOqRmE91opKn8LhCXe().DqNMwhnf1mKfT3pnYxoJt0pPe(DCS4Jf0LRzsehKFc5QOLL06qw.aimbotLimb);
			}
		}
		else
		{
			bool hitPointToTransform = DCS4Jf0LRzsehKFc5QOLL06qw.hitPointToTransform;
			bool flag4 = hitPointToTransform;
			if (flag4)
			{
				transform = p.transform;
			}
			else
			{
				bool bestSilentAimPartPreselective = DCS4Jf0LRzsehKFc5QOLL06qw.bestSilentAimPartPreselective;
				bool flag5 = bestSilentAimPartPreselective;
				if (flag5)
				{
					transform = p.DKNSZQDiOqRmE91opKn8LhCXe().Di1EVHMrJyeCCJIVX4L04N0Mf();
				}
				else
				{
					transform = p.DKNSZQDiOqRmE91opKn8LhCXe().DqNMwhnf1mKfT3pnYxoJt0pPe(DCS4Jf0LRzsehKFc5QOLL06qw.silentAimHitPointLimb);
				}
			}
		}
		return transform;
	}
}
