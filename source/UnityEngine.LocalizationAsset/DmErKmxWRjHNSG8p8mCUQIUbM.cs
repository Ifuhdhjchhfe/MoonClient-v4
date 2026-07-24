using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000087 RID: 135
public static class DmErKmxWRjHNSG8p8mCUQIUbM
{
	// Token: 0x0600027E RID: 638 RVA: 0x0002573C File Offset: 0x0002393C
	public static string DSTazTWSW8NJjAmhdnS7ks0KO(int givedSeconds)
	{
		int num = givedSeconds % 60;
		int num2 = givedSeconds / 60;
		int num3 = num2 / 60;
		int num4 = (givedSeconds - num3 * 3600) / 60;
		string text = ((num3 < 10) ? ("0" + num3.ToString()) : num3.ToString());
		string text2 = ((num4 < 10) ? ("0" + num4.ToString()) : num4.ToString());
		string text3 = ((num < 10) ? ("0" + num.ToString()) : num.ToString());
		return string.Concat(new string[] { text, ":", text2, ":", text3 });
	}

	// Token: 0x0600027F RID: 639 RVA: 0x000257FC File Offset: 0x000239FC
	public static string DdBiM5ftETp9lkzglEogbAaGC()
	{
		DateTime now = DateTime.Now;
		string text = ((now.Second < 10) ? ("0" + now.Second.ToString()) : now.Second.ToString());
		string text2 = ((now.Hour < 10) ? ("0" + now.Hour.ToString()) : now.Hour.ToString());
		string text3 = ((now.Minute < 10) ? ("0" + now.Minute.ToString()) : now.Minute.ToString());
		return string.Concat(new string[] { text2, ":", text3, ":", text });
	}

	// Token: 0x06000280 RID: 640 RVA: 0x000258E8 File Offset: 0x00023AE8
	public static Quaternion DMyVJrZKISQhUzJ303OEX5wMT(Vector3 origin, Vector3 pos)
	{
		return Quaternion.LookRotation(DmErKmxWRjHNSG8p8mCUQIUbM.DQ7woga033SaMk9IFXgJ8bH0h(pos - origin));
	}

	// Token: 0x06000281 RID: 641 RVA: 0x0002590C File Offset: 0x00023B0C
	public static Vector3 Dp0TyaMelufYHIv2RuI1cjCTN(Vector3 origin, Vector3 pos)
	{
		return Quaternion.LookRotation(DmErKmxWRjHNSG8p8mCUQIUbM.DQ7woga033SaMk9IFXgJ8bH0h(pos - origin)).eulerAngles;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00025938 File Offset: 0x00023B38
	public static Vector3 DWTJZMUdPCnE0MBXkaJ5OA6m0(Vector3 origin, Vector3 pos)
	{
		return DmErKmxWRjHNSG8p8mCUQIUbM.DQ7woga033SaMk9IFXgJ8bH0h(pos - origin);
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00025958 File Offset: 0x00023B58
	public static float DJt3hAqh4ZXULdGluWyDLh2hJ(Vector3 a, Vector3 b)
	{
		float num = a.x - b.x;
		float num2 = a.y - b.y;
		float num3 = a.z - b.z;
		return Mathf.Sqrt(num * num + num2 * num2 + num3 * num3);
	}

	// Token: 0x06000284 RID: 644 RVA: 0x000259A4 File Offset: 0x00023BA4
	public static Vector3 DQ7woga033SaMk9IFXgJ8bH0h(Vector3 vector)
	{
		return vector / (float)Math.Sqrt((double)(vector.x * vector.x + vector.y * vector.y + vector.z * vector.z));
	}

	// Token: 0x06000285 RID: 645 RVA: 0x000259EC File Offset: 0x00023BEC
	public static int D3lA05pX4HfBlOQWdxeK6L6B8()
	{
		bool setDistanceByGunRange = DCS4Jf0LRzsehKFc5QOLL06qw.setDistanceByGunRange;
		bool flag = setDistanceByGunRange;
		int num;
		if (flag)
		{
			bool flag2 = Player.player != null && Player.player.equipment.asset != null && Player.player.equipment.asset is ItemGunAsset;
			bool flag3 = flag2;
			if (flag3)
			{
				bool flag4 = DCS4Jf0LRzsehKFc5QOLL06qw.manuallyCalculateBallisticDistance && Provider.modeConfigData.Gameplay.Ballistics;
				bool flag5 = flag4;
				if (flag5)
				{
					num = (int)((Player.player.equipment.asset as ItemGunAsset).ballisticTravel * (float)((int)(Player.player.equipment.asset as ItemGunAsset).ballisticSteps + (D5l46jlssr4TRAzUSXzLj0uqu.extendBallisticRange ? D5l46jlssr4TRAzUSXzLj0uqu.additionalBallisticSteps : 0)) + (float)(D5l46jlssr4TRAzUSXzLj0uqu.extendBallisticRange ? 4 : 0) + (DCS4Jf0LRzsehKFc5QOLL06qw.expandRangeBySphere ? DCS4Jf0LRzsehKFc5QOLL06qw.Db55lznlFok53zZBv0jDuw4gi : 0f));
				}
				else
				{
					num = (int)(Player.player.equipment.asset as ItemGunAsset).range + (D5l46jlssr4TRAzUSXzLj0uqu.extendBallisticRange ? 4 : 0) + (int)(DCS4Jf0LRzsehKFc5QOLL06qw.expandRangeBySphere ? DCS4Jf0LRzsehKFc5QOLL06qw.Db55lznlFok53zZBv0jDuw4gi : 0f);
				}
			}
			else
			{
				bool flag6 = Player.player != null && Player.player.equipment.asset != null && Player.player.equipment.asset is ItemMeleeAsset;
				bool flag7 = flag6;
				if (flag7)
				{
					num = 19 + (int)(Player.player.equipment.asset as ItemMeleeAsset).range;
				}
				else
				{
					num = 21;
				}
			}
		}
		else
		{
			num = DCS4Jf0LRzsehKFc5QOLL06qw.aimTargetDistance;
		}
		return num;
	}
}
