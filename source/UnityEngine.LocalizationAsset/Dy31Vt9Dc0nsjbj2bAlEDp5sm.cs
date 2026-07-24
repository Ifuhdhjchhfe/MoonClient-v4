using System;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000D6 RID: 214
public class Dy31Vt9Dc0nsjbj2bAlEDp5sm
{
	// Token: 0x0600040E RID: 1038 RVA: 0x0003D54C File Offset: 0x0003B74C
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(UseableBarricade), "checkSpace", BindingFlags.Instance | BindingFlags.NonPublic, new Type[] { })]
	public static bool DoSDNPVNXHpEfAJWeRQ0ZI0gn(UseableBarricade instance)
	{
		bool flag = DA1dZHkBmPouE1WuakM2TW4QH.DV5fBuuwwtgOKLKyiAmdzlRoa<bool>(instance, Array.Empty<object>());
		bool flag2 = D5l46jlssr4TRAzUSXzLj0uqu.freeCamera && DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr != null && instance.channel.IsLocalPlayer;
		bool flag3 = flag2;
		bool flag7;
		if (flag3)
		{
			Ray ray = new Ray(DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.transform.position, DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.transform.forward);
			RaycastHit raycastHit = default(RaycastHit);
			Physics.Raycast(ray.origin, ray.direction, out raycastHit, instance.equippedBarricadeAsset.range, RayMasks.SLOTS_INTERACT);
			Dy31Vt9Dc0nsjbj2bAlEDp5sm.DXt3vtu4WzzouXbqeEsaImlrp.Set(instance, raycastHit);
			bool flag4 = raycastHit.collider == null;
			bool flag5 = flag4;
			if (flag5)
			{
				Dy31Vt9Dc0nsjbj2bAlEDp5sm.DLfd0I71yDntPZNv3L64qZsnf.Set(instance, Vector3.zero);
				bool isLocalPlayer = instance.channel.IsLocalPlayer;
				bool flag6 = isLocalPlayer;
				if (flag6)
				{
					PlayerUI.hint(null, EPlayerMessage.WINDOW);
				}
				flag7 = false;
			}
			else
			{
				bool flag8 = raycastHit.normal.y > 0.75f;
				bool flag9 = flag8;
				Vector3 vector;
				if (flag9)
				{
					vector = raycastHit.point + raycastHit.normal * instance.equippedBarricadeAsset.offset;
				}
				else
				{
					vector = raycastHit.point + Vector3.up * instance.equippedBarricadeAsset.offset;
				}
				Dy31Vt9Dc0nsjbj2bAlEDp5sm.DLfd0I71yDntPZNv3L64qZsnf.Set(instance, vector);
				flag7 = true;
			}
		}
		else
		{
			bool customBuildOffset = D5l46jlssr4TRAzUSXzLj0uqu.customBuildOffset;
			bool flag10 = customBuildOffset;
			if (flag10)
			{
				RaycastHit raycastHit2 = default(RaycastHit);
				Physics.Raycast(new Ray(MainCamera.instance.transform.position, MainCamera.instance.transform.forward), out raycastHit2, instance.equippedBarricadeAsset.range, RayMasks.SLOTS_INTERACT);
				Dy31Vt9Dc0nsjbj2bAlEDp5sm.DXt3vtu4WzzouXbqeEsaImlrp.Set(instance, raycastHit2);
				Vector3 vector2 = MainCamera.instance.transform.position + MainCamera.instance.transform.forward * D5l46jlssr4TRAzUSXzLj0uqu.buildForwardOffset;
				vector2.y += D5l46jlssr4TRAzUSXzLj0uqu.buildYOffset;
				bool flag11 = raycastHit2.normal.y > 0.75f;
				bool flag12 = flag11;
				if (flag12)
				{
					vector2 += raycastHit2.normal * instance.equippedBarricadeAsset.offset;
				}
				else
				{
					vector2 += Vector3.up * instance.equippedBarricadeAsset.offset;
				}
				Dy31Vt9Dc0nsjbj2bAlEDp5sm.DLfd0I71yDntPZNv3L64qZsnf.Set(instance, vector2);
				flag7 = true;
			}
			else
			{
				flag7 = D5l46jlssr4TRAzUSXzLj0uqu.ignoreBarricadePlacementErrors || flag;
			}
		}
		return flag7;
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x0003D80C File Offset: 0x0003BA0C
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(UseableBarricade), "checkClaims", BindingFlags.Instance | BindingFlags.NonPublic, new Type[] { })]
	public static bool DQSKR3bwGQothYisRZm0EzYgw(UseableBarricade instance)
	{
		bool flag = DA1dZHkBmPouE1WuakM2TW4QH.DV5fBuuwwtgOKLKyiAmdzlRoa<bool>(instance, Array.Empty<object>());
		return D5l46jlssr4TRAzUSXzLj0uqu.ignoreBarricadePlacementErrors || flag;
	}

	// Token: 0x04000458 RID: 1112
	public static DGZv08vQyz81zrHxUqhmYuCdY<RaycastHit> DXt3vtu4WzzouXbqeEsaImlrp = new DGZv08vQyz81zrHxUqhmYuCdY<RaycastHit>(typeof(UseableBarricade), "hit", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000459 RID: 1113
	public static DGZv08vQyz81zrHxUqhmYuCdY<Vector3> DLfd0I71yDntPZNv3L64qZsnf = new DGZv08vQyz81zrHxUqhmYuCdY<Vector3>(typeof(UseableBarricade), "point", BindingFlags.Instance | BindingFlags.NonPublic);
}
