using System;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000014 RID: 20
public class D3kl00ZWS09W0pnZ5Ny1wEUt7
{
	// Token: 0x06000058 RID: 88 RVA: 0x00005308 File Offset: 0x00003508
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(UseableStructure), "UpdatePendingPlacement", BindingFlags.Instance | BindingFlags.NonPublic, new Type[] { })]
	public static bool DxL2NdI5ee1YpTaq8mHpKGaW5(UseableStructure instance)
	{
		bool flag = DA1dZHkBmPouE1WuakM2TW4QH.DV5fBuuwwtgOKLKyiAmdzlRoa<bool>(instance, Array.Empty<object>());
		bool flag2 = D5l46jlssr4TRAzUSXzLj0uqu.freeCamera && DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr != null && instance.channel.IsLocalPlayer;
		bool flag3 = flag2;
		if (flag3)
		{
			Ray ray = new Ray(DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.transform.position, DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.transform.forward);
			RaycastHit raycastHit = default(RaycastHit);
			bool flag4 = !Physics.SphereCast(ray.origin, 0.1f, ray.direction, out raycastHit, instance.equippedStructureAsset.range, RayMasks.STRUCTURE_INTERACT);
			bool flag5 = flag4;
			if (flag5)
			{
				D3kl00ZWS09W0pnZ5Ny1wEUt7.DD7jFyB30Y9yaMzAMIfYsm3vs.Set(instance, Vector3.zero);
				return false;
			}
			D3kl00ZWS09W0pnZ5Ny1wEUt7.DD7jFyB30Y9yaMzAMIfYsm3vs.Set(instance, raycastHit.point);
			D3kl00ZWS09W0pnZ5Ny1wEUt7.D9WzdtQEvhSVXYLhqJjc6ISmF.Set(instance, DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.transform.eulerAngles.y);
		}
		else
		{
			bool customBuildOffset = D5l46jlssr4TRAzUSXzLj0uqu.customBuildOffset;
			bool flag6 = customBuildOffset;
			if (flag6)
			{
				Vector3 vector = MainCamera.instance.transform.position + MainCamera.instance.transform.forward * D5l46jlssr4TRAzUSXzLj0uqu.buildForwardOffset;
				vector.y += D5l46jlssr4TRAzUSXzLj0uqu.buildYOffset;
				D3kl00ZWS09W0pnZ5Ny1wEUt7.DD7jFyB30Y9yaMzAMIfYsm3vs.Set(instance, vector);
				D3kl00ZWS09W0pnZ5Ny1wEUt7.D9WzdtQEvhSVXYLhqJjc6ISmF.Set(instance, DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.transform.eulerAngles.y);
				return true;
			}
		}
		return D5l46jlssr4TRAzUSXzLj0uqu.ignoreStructurePlacementErrors || flag;
	}

	// Token: 0x04000030 RID: 48
	public static DGZv08vQyz81zrHxUqhmYuCdY<Vector3> DD7jFyB30Y9yaMzAMIfYsm3vs = new DGZv08vQyz81zrHxUqhmYuCdY<Vector3>(typeof(UseableStructure), "pendingPlacementPosition", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000031 RID: 49
	public static DGZv08vQyz81zrHxUqhmYuCdY<float> D9WzdtQEvhSVXYLhqJjc6ISmF = new DGZv08vQyz81zrHxUqhmYuCdY<float>(typeof(UseableStructure), "pendingPlacementYaw", BindingFlags.Instance | BindingFlags.NonPublic);
}
