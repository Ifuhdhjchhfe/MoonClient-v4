using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000E2 RID: 226
public static class DZeVuD2Z6mtCT0m18MfVNUFMP
{
	// Token: 0x06000430 RID: 1072 RVA: 0x0003EC48 File Offset: 0x0003CE48
	public static bool DVCHKPTidbpTa5xJoMlNKrP21(this Vector3 point)
	{
		return point.DJ3j3QiDZLecXEvpGxpUJ3o84(Player.player.look.aim.position, true) != Vector3.zero;
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x0003EC80 File Offset: 0x0003CE80
	public static bool D7jI6EoRIlVgppmv8T7nYuaAV(this Vector3 point, Vector3 camPos, out Vector3 returnVec, bool tryExpand = true)
	{
		returnVec = point.DJ3j3QiDZLecXEvpGxpUJ3o84(camPos, tryExpand);
		return returnVec != Vector3.zero;
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x0003ECB0 File Offset: 0x0003CEB0
	public static bool DJfKIDGo7o78PGeoQlUplDvpS(this Vector3 point, out Vector3 returnVec, bool tryExpand = true)
	{
		returnVec = point.DJ3j3QiDZLecXEvpGxpUJ3o84(Player.player.look.aim.position, tryExpand);
		return returnVec != Vector3.zero;
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x0003ECF4 File Offset: 0x0003CEF4
	public static Vector3 DuoaymeYCr8wEnFIzCb1Ug2U9(this Vector3 point, bool tryExpand = true)
	{
		return point.DJ3j3QiDZLecXEvpGxpUJ3o84(Player.player.look.aim.position, tryExpand);
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x0003ED24 File Offset: 0x0003CF24
	public static Vector3 DJ3j3QiDZLecXEvpGxpUJ3o84(this Vector3 point, Vector3 camPos, bool tryExpand = true)
	{
		bool flag = Vector3.Distance(camPos, point) <= DCS4Jf0LRzsehKFc5QOLL06qw.Db55lznlFok53zZBv0jDuw4gi && DCS4Jf0LRzsehKFc5QOLL06qw.setHitPointToCameraIfAviable;
		bool flag2 = flag;
		Vector3 vector;
		if (flag2)
		{
			vector = camPos;
		}
		else
		{
			bool flag3 = tryExpand && DCS4Jf0LRzsehKFc5QOLL06qw.expandRangeBySphere && Vector3.Distance(camPos, point) > (float)DmErKmxWRjHNSG8p8mCUQIUbM.D3lA05pX4HfBlOQWdxeK6L6B8() - DCS4Jf0LRzsehKFc5QOLL06qw.Db55lznlFok53zZBv0jDuw4gi;
			bool flag4 = flag3;
			if (flag4)
			{
				Vector3 vector2 = Vector3.zero;
				int num = DmErKmxWRjHNSG8p8mCUQIUbM.D3lA05pX4HfBlOQWdxeK6L6B8() + 2;
				foreach (Vector3 vector3 in DoLw5vYd2Gq0BYuUfcIXuj4Vo.DfCAnLXlM0BjQRdGSl6900LuF)
				{
					int num2 = (int)Vector3.Distance(camPos, point + vector3);
					bool flag5 = num2 < num && !Physics.Linecast(camPos, point + vector3, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore) && (!DCS4Jf0LRzsehKFc5QOLL06qw.verifySphereToPlayerPointByLinecast || !Physics.Linecast(point + vector3, point, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore));
					bool flag6 = flag5;
					if (flag6)
					{
						num = num2;
						vector2 = point + vector3;
					}
				}
				vector = ((vector2 != Vector3.zero && Vector3.Distance(camPos, vector2) <= (float)DmErKmxWRjHNSG8p8mCUQIUbM.D3lA05pX4HfBlOQWdxeK6L6B8() - DCS4Jf0LRzsehKFc5QOLL06qw.Db55lznlFok53zZBv0jDuw4gi) ? vector2 : Vector3.zero);
			}
			else
			{
				foreach (Vector3 vector4 in DoLw5vYd2Gq0BYuUfcIXuj4Vo.DfCAnLXlM0BjQRdGSl6900LuF)
				{
					bool flag7 = !Physics.Linecast(camPos, point + vector4, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore) && (!DCS4Jf0LRzsehKFc5QOLL06qw.verifySphereToPlayerPointByLinecast || !Physics.Linecast(point + vector4, point, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore));
					bool flag8 = flag7;
					if (flag8)
					{
						return point + vector4;
					}
				}
				vector = Vector3.zero;
			}
		}
		return vector;
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x0003EEEC File Offset: 0x0003D0EC
	public static Vector3 DRo8FCzYq07UKN1Az8u0OAdH9(this Vector3 point, Vector3 camPos, bool tryExpand = true)
	{
		bool flag = Vector3.Distance(point, camPos) <= DCS4Jf0LRzsehKFc5QOLL06qw.Db55lznlFok53zZBv0jDuw4gi && DCS4Jf0LRzsehKFc5QOLL06qw.setHitPointToCameraIfAviable;
		bool flag2 = flag;
		Vector3 vector;
		if (flag2)
		{
			vector = camPos;
		}
		else
		{
			bool flag3 = tryExpand && DCS4Jf0LRzsehKFc5QOLL06qw.expandRangeBySphere && Vector3.Distance(MainCamera.instance.transform.position, point) > (float)DmErKmxWRjHNSG8p8mCUQIUbM.D3lA05pX4HfBlOQWdxeK6L6B8() - DCS4Jf0LRzsehKFc5QOLL06qw.Db55lznlFok53zZBv0jDuw4gi;
			bool flag4 = flag3;
			if (flag4)
			{
				Vector3 vector2 = Vector3.zero;
				int num = (int)DCS4Jf0LRzsehKFc5QOLL06qw.Db55lznlFok53zZBv0jDuw4gi + DmErKmxWRjHNSG8p8mCUQIUbM.D3lA05pX4HfBlOQWdxeK6L6B8() + 2;
				foreach (Vector3 vector3 in DoLw5vYd2Gq0BYuUfcIXuj4Vo.DfCAnLXlM0BjQRdGSl6900LuF)
				{
					int num2 = (int)Vector3.Distance(MainCamera.instance.transform.position, point + vector3);
					bool flag5 = num2 < num && !Physics.Linecast(MainCamera.instance.transform.position, point + vector3, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore) && (!DCS4Jf0LRzsehKFc5QOLL06qw.verifySphereToPlayerPointByLinecast || !Physics.Linecast(point + vector3, point, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore));
					bool flag6 = flag5;
					if (flag6)
					{
						num = num2;
						vector2 = vector3;
					}
				}
				vector = ((Vector3.Distance(MainCamera.instance.transform.position, vector2) <= (float)DmErKmxWRjHNSG8p8mCUQIUbM.D3lA05pX4HfBlOQWdxeK6L6B8() - DCS4Jf0LRzsehKFc5QOLL06qw.Db55lznlFok53zZBv0jDuw4gi) ? vector2 : Vector3.zero);
			}
			else
			{
				foreach (Vector3 vector4 in DoLw5vYd2Gq0BYuUfcIXuj4Vo.DfCAnLXlM0BjQRdGSl6900LuF)
				{
					bool flag7 = !Physics.Linecast(camPos, point + vector4, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore) && (!DCS4Jf0LRzsehKFc5QOLL06qw.verifySphereToPlayerPointByLinecast || !Physics.Linecast(point + vector4, point, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore));
					bool flag8 = flag7;
					if (flag8)
					{
						return vector4;
					}
				}
				vector = Vector3.zero;
			}
		}
		return vector;
	}
}
