using System;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000054 RID: 84
public class DFdnTuJUrJ7ZxW6YnN3i0xkRL : PlayerInteract
{
	// Token: 0x06000185 RID: 389 RVA: 0x00015C4C File Offset: 0x00013E4C
	[DyRHDWg89xeNs0wA42v5OHmTi]
	public static void DImKDPqhgsiKWjDJrJw26uLYn()
	{
		DI4RfMJ7ziJuscMZZoy2MIzrV.De2hBwLmnyYClZ9fwAmbPOhqc = (DIDzNgrvnOa5xIZrJtz5ZO48o)Delegate.Combine(DI4RfMJ7ziJuscMZZoy2MIzrV.De2hBwLmnyYClZ9fwAmbPOhqc, new DIDzNgrvnOa5xIZrJtz5ZO48o(DFdnTuJUrJ7ZxW6YnN3i0xkRL.Dq0FUhMVuqfZTOqSGu0kTfxNu));
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00015C70 File Offset: 0x00013E70
	public static void Dq0FUhMVuqfZTOqSGu0kTfxNu()
	{
		bool pickupItemsThroughWalls = D5l46jlssr4TRAzUSXzLj0uqu.pickupItemsThroughWalls;
		bool flag = pickupItemsThroughWalls;
		if (flag)
		{
			DFdnTuJUrJ7ZxW6YnN3i0xkRL.D4AtAbBrV4PFnL1FI0wOeZHFU.value = default(RaycastHit);
		}
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00015CA0 File Offset: 0x00013EA0
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerInteract), "Update", new Type[] { })]
	private void DEjuRz5ikEeaXlDZsRj57Do9u()
	{
		try
		{
			bool isLocalPlayer = base.channel.IsLocalPlayer;
			bool flag = isLocalPlayer;
			if (flag)
			{
				InteractableItem interactableItem = null;
				bool flag2 = D5l46jlssr4TRAzUSXzLj0uqu.pickupItemsThroughWalls && !DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6 && DHKOlhPS98QOeYArRzpLwTeId.DLA96oVs6GkVKizjsmgY02urI(D5l46jlssr4TRAzUSXzLj0uqu.freeCamera ? ((int)Mathf.Clamp((float)D5l46jlssr4TRAzUSXzLj0uqu.pickupItemsThroughWallsDistance - Vector3.Distance(Player.player.look.getEyesPosition(), DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.transform.position), 0f, (float)D5l46jlssr4TRAzUSXzLj0uqu.pickupItemsThroughWallsDistance)) : D5l46jlssr4TRAzUSXzLj0uqu.pickupItemsThroughWallsDistance, DI8jSvGQa3grzg5wlLxwkRj27.DzGDOq0dZL2sIXJTdcfSy2A4v("Grab items through walls FOV"), out interactableItem);
				bool flag3 = flag2;
				if (flag3)
				{
					Collider collider = interactableItem.transform.GetComponent<Collider>();
					bool flag4 = true;
					bool flag5 = collider == null;
					bool flag6 = flag5;
					if (flag6)
					{
						flag4 = false;
						collider = interactableItem.transform.gameObject.AddComponent<BoxCollider>();
						((BoxCollider)collider).size = new Vector3(0.25f, 0.25f, 0.25f);
					}
					Vector3 vector = collider.bounds.center + new Vector3(0f, collider.bounds.extents.y + 0.1f, 0f);
					RaycastHit raycastHit = default(RaycastHit);
					Physics.Raycast(new Ray(vector, DmErKmxWRjHNSG8p8mCUQIUbM.DWTJZMUdPCnE0MBXkaJ5OA6m0(vector, collider.bounds.center)), out raycastHit, 4f, RayMasks.PLAYER_INTERACT);
					DFdnTuJUrJ7ZxW6YnN3i0xkRL.D4AtAbBrV4PFnL1FI0wOeZHFU.value = raycastHit;
					DFdnTuJUrJ7ZxW6YnN3i0xkRL.Drk3HzZDakXwMsHXFA5XFAfE9.value = Time.realtimeSinceStartup;
					DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, Array.Empty<object>());
					bool flag7 = !flag4;
					bool flag8 = flag7;
					if (flag8)
					{
						global::UnityEngine.Object.Destroy(collider);
					}
				}
				else
				{
					bool flag9 = D5l46jlssr4TRAzUSXzLj0uqu.freeCamera && !DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6;
					bool flag10 = flag9;
					if (flag10)
					{
						RaycastHit raycastHit2 = default(RaycastHit);
						Physics.Raycast(new Ray(DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.transform.position, DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.transform.forward), out raycastHit2, 20f, RayMasks.PLAYER_INTERACT);
						DFdnTuJUrJ7ZxW6YnN3i0xkRL.D4AtAbBrV4PFnL1FI0wOeZHFU.value = raycastHit2;
						DFdnTuJUrJ7ZxW6YnN3i0xkRL.Drk3HzZDakXwMsHXFA5XFAfE9.value = Time.realtimeSinceStartup;
						DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, Array.Empty<object>());
					}
					else
					{
						DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, Array.Empty<object>());
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00015F14 File Offset: 0x00014114
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerInteract), "get_salvageTime", new Type[] { })]
	private float DSLbZ2qRooyPJl2OKuK0USlff()
	{
		bool flag = DFdnTuJUrJ7ZxW6YnN3i0xkRL.DzVWskvAEt9y0EHl8zACF8rx6.Get(this);
		bool flag2 = flag;
		float num;
		if (flag2)
		{
			num = DFdnTuJUrJ7ZxW6YnN3i0xkRL.DPGiKQXsY6hwMY5vi045AggIj.Get(this) * D5l46jlssr4TRAzUSXzLj0uqu.salvageTimeMultiplier;
		}
		else
		{
			bool flag3 = Player.player.equipment.useable is UseableHousingPlanner;
			bool flag4 = flag3;
			if (flag4)
			{
				num = 0.5f * D5l46jlssr4TRAzUSXzLj0uqu.salvageTimeMultiplier;
			}
			else
			{
				bool flag5 = Provider.isServer || Player.player.channel.owner.isAdmin;
				bool flag6 = flag5;
				if (flag6)
				{
					LevelAsset asset = Level.getAsset();
					bool flag7 = asset == null || asset.enableAdminFasterSalvageDuration;
					bool flag8 = flag7;
					if (flag8)
					{
						return 1f * D5l46jlssr4TRAzUSXzLj0uqu.salvageTimeMultiplier;
					}
				}
				num = 8f * D5l46jlssr4TRAzUSXzLj0uqu.salvageTimeMultiplier;
			}
		}
		return num;
	}

	// Token: 0x040001E0 RID: 480
	public static DGZv08vQyz81zrHxUqhmYuCdY<RaycastHit> D4AtAbBrV4PFnL1FI0wOeZHFU = new DGZv08vQyz81zrHxUqhmYuCdY<RaycastHit>(typeof(PlayerInteract), "hit", BindingFlags.Static | BindingFlags.NonPublic);

	// Token: 0x040001E1 RID: 481
	public static DGZv08vQyz81zrHxUqhmYuCdY<float> Drk3HzZDakXwMsHXFA5XFAfE9 = new DGZv08vQyz81zrHxUqhmYuCdY<float>(typeof(PlayerInteract), "lastInteract", BindingFlags.Static | BindingFlags.NonPublic);

	// Token: 0x040001E2 RID: 482
	public static DGZv08vQyz81zrHxUqhmYuCdY<bool> DzVWskvAEt9y0EHl8zACF8rx6 = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(PlayerInteract), "shouldOverrideSalvageTime", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x040001E3 RID: 483
	public static DGZv08vQyz81zrHxUqhmYuCdY<float> DPGiKQXsY6hwMY5vi045AggIj = new DGZv08vQyz81zrHxUqhmYuCdY<float>(typeof(PlayerInteract), "overrideSalvageTimeValue", BindingFlags.Instance | BindingFlags.NonPublic);
}
