using System;
using System.Collections.Generic;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

// Token: 0x02000069 RID: 105
public class DHKOlhPS98QOeYArRzpLwTeId : MonoBehaviour
{
	// Token: 0x1700001F RID: 31
	// (get) Token: 0x060001F3 RID: 499 RVA: 0x000194DC File Offset: 0x000176DC
	// (set) Token: 0x060001F4 RID: 500 RVA: 0x0001950B File Offset: 0x0001770B
	public static Dictionary<ushort, DDB8pIlWKKbHkw2jCuyAPcvL7> itemsToESP
	{
		get
		{
			return (Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[1].DTyDRC9cdG8IGn9zMpTt5eaiL[0].DInHPFtxebvVx7sh7DNy96Mrp as Dx0mI3VF7tws4aOTlUQV9RnyL).DkzMi11T0w2UxOfkt0ojQjo5Z;
		}
		set
		{
			(Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[1].DTyDRC9cdG8IGn9zMpTt5eaiL[0].DInHPFtxebvVx7sh7DNy96Mrp as Dx0mI3VF7tws4aOTlUQV9RnyL).DkzMi11T0w2UxOfkt0ojQjo5Z = value;
		}
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x0001952C File Offset: 0x0001772C
	[DyRHDWg89xeNs0wA42v5OHmTi]
	public static void D7Vau0sD6QDptueQxwj9tWI3h()
	{
		foreach (Type type in DHKOlhPS98QOeYArRzpLwTeId.D1vkgiDHsaPtBWm3wQcDo0jvI)
		{
			DHKOlhPS98QOeYArRzpLwTeId.DrfsvLu2uAeBZIcIFj70rO5Fq.Add(type.Name, type);
		}
		Provider.onClientConnected = (Provider.ClientConnected)Delegate.Combine(Provider.onClientConnected, new Provider.ClientConnected(DHKOlhPS98QOeYArRzpLwTeId.D2UlvteDcHCwSdHixJfFOV0Zb));
		Provider.onServerConnected = (Provider.ServerConnected)Delegate.Combine(Provider.onServerConnected, new Provider.ServerConnected(delegate(CSteamID steamid)
		{
			DHKOlhPS98QOeYArRzpLwTeId.D2UlvteDcHCwSdHixJfFOV0Zb();
		}));
		D0Kr0NqRHBD41IMsgv7ajeW8M.D1tYt6KxEmATG67AhmCiQjAGN.AddComponent<DHKOlhPS98QOeYArRzpLwTeId>();
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x000195EC File Offset: 0x000177EC
	public static void D2UlvteDcHCwSdHixJfFOV0Zb()
	{
		DHKOlhPS98QOeYArRzpLwTeId.D4NYxH9hHVZz7r5I5BQPpqy3O.Clear();
		try
		{
			for (ushort num = 0; num < 65535; num += 1)
			{
				Asset asset = Assets.find(EAssetType.ITEM, num);
				bool flag = asset != null && asset is ItemAsset && (asset as ItemAsset).itemName.ToLower() != "name";
				bool flag2 = flag;
				if (flag2)
				{
					DHKOlhPS98QOeYArRzpLwTeId.D4NYxH9hHVZz7r5I5BQPpqy3O.Add(new DDB8pIlWKKbHkw2jCuyAPcvL7(asset.id, (asset as ItemAsset).itemName));
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00019690 File Offset: 0x00017890
	public void Update()
	{
		DHKOlhPS98QOeYArRzpLwTeId.DzRc0qU4iXGCpCyhwrAYwcLMg += Time.deltaTime;
		bool flag = DHKOlhPS98QOeYArRzpLwTeId.DzRc0qU4iXGCpCyhwrAYwcLMg > 2f;
		bool flag2 = flag;
		if (flag2)
		{
			DHKOlhPS98QOeYArRzpLwTeId.DzRc0qU4iXGCpCyhwrAYwcLMg = 0f;
			DHKOlhPS98QOeYArRzpLwTeId.Dhd6dKsh0e6NOxF0kEgF2zpj3.Clear();
			DHKOlhPS98QOeYArRzpLwTeId.DETnSkbBFwL4Y4VUu0KiicL8H.Clear();
			foreach (InteractableItem interactableItem in DOHd7Krdup3atkFN2AOxPbqnA.DWSHDsX20pj51yeYJq0WnerH0)
			{
				bool flag3 = interactableItem != null && Vector3.Distance(Player.player.transform.position, interactableItem.transform.position) < 35f;
				bool flag4 = flag3;
				if (flag4)
				{
					DHKOlhPS98QOeYArRzpLwTeId.Dhd6dKsh0e6NOxF0kEgF2zpj3.Add(interactableItem);
					bool flag5 = !DHKOlhPS98QOeYArRzpLwTeId.DETnSkbBFwL4Y4VUu0KiicL8H.ContainsKey(interactableItem.asset.id);
					bool flag6 = flag5;
					if (flag6)
					{
						DHKOlhPS98QOeYArRzpLwTeId.DETnSkbBFwL4Y4VUu0KiicL8H.Add(interactableItem.asset.id, new List<InteractableItem> { interactableItem });
					}
					else
					{
						DHKOlhPS98QOeYArRzpLwTeId.DETnSkbBFwL4Y4VUu0KiicL8H[interactableItem.asset.id].Add(interactableItem);
					}
				}
			}
		}
		bool flag7 = D5l46jlssr4TRAzUSXzLj0uqu.autoItemPickup && Player.player != null;
		bool flag8 = flag7;
		if (flag8)
		{
			DHKOlhPS98QOeYArRzpLwTeId.D1RsnP9Pcan7bfrG0wP9TWzsq += Time.deltaTime;
			bool flag9 = DHKOlhPS98QOeYArRzpLwTeId.D1RsnP9Pcan7bfrG0wP9TWzsq > 0.3f;
			bool flag10 = flag9;
			if (flag10)
			{
				DHKOlhPS98QOeYArRzpLwTeId.D1RsnP9Pcan7bfrG0wP9TWzsq = 0f;
				foreach (InteractableItem interactableItem2 in DHKOlhPS98QOeYArRzpLwTeId.Dhd6dKsh0e6NOxF0kEgF2zpj3)
				{
					bool flag11 = interactableItem2 != null && D5l46jlssr4TRAzUSXzLj0uqu.DzksjAWr7fP6HlkBNdY20fpHC.ContainsKey(interactableItem2.asset.id) && Vector3.Distance(interactableItem2.transform.position, Player.player.transform.position) <= (float)D5l46jlssr4TRAzUSXzLj0uqu.autoItemPickupDistance;
					bool flag12 = flag11;
					if (flag12)
					{
						interactableItem2.use();
						break;
					}
				}
			}
		}
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x000198E4 File Offset: 0x00017AE4
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "WhitelistNearbyItem")]
	public static void Dew5BT9FQDweYWtB4OCnh2KIV()
	{
		InteractableItem interactableItem;
		DHKOlhPS98QOeYArRzpLwTeId.DLA96oVs6GkVKizjsmgY02urI(D5l46jlssr4TRAzUSXzLj0uqu.freeCamera ? ((int)Mathf.Clamp((float)D5l46jlssr4TRAzUSXzLj0uqu.pickupItemsThroughWallsDistance - Vector3.Distance(Player.player.look.getEyesPosition(), DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.transform.position), 0f, (float)D5l46jlssr4TRAzUSXzLj0uqu.pickupItemsThroughWallsDistance)) : D5l46jlssr4TRAzUSXzLj0uqu.pickupItemsThroughWallsDistance, DI8jSvGQa3grzg5wlLxwkRj27.DzGDOq0dZL2sIXJTdcfSy2A4v("Grab items through walls FOV"), out interactableItem);
		bool flag = interactableItem != null && !DHKOlhPS98QOeYArRzpLwTeId.itemsToESP.ContainsKey(interactableItem.asset.id);
		bool flag2 = flag;
		if (flag2)
		{
			DHKOlhPS98QOeYArRzpLwTeId.itemsToESP.Add(interactableItem.asset.id, new DDB8pIlWKKbHkw2jCuyAPcvL7(interactableItem.asset.id, interactableItem.asset.itemName));
		}
		else
		{
			bool flag3 = interactableItem != null && DHKOlhPS98QOeYArRzpLwTeId.itemsToESP.ContainsKey(interactableItem.asset.id);
			bool flag4 = flag3;
			if (flag4)
			{
				DHKOlhPS98QOeYArRzpLwTeId.itemsToESP.Remove(interactableItem.asset.id);
			}
		}
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x000199F0 File Offset: 0x00017BF0
	public static bool DLA96oVs6GkVKizjsmgY02urI(int distance, int fov, out InteractableItem rii)
	{
		int num = fov + 1;
		rii = null;
		foreach (InteractableItem interactableItem in DHKOlhPS98QOeYArRzpLwTeId.Dhd6dKsh0e6NOxF0kEgF2zpj3)
		{
			bool flag = interactableItem == null;
			bool flag2 = !flag;
			if (flag2)
			{
				bool flag3 = Vector3.Distance(interactableItem.transform.position, Player.player.transform.position) > (float)distance;
				bool flag4 = !flag3;
				if (flag4)
				{
					bool flag5 = !interactableItem.transform.position.DGxZdvjodtrVw5BNkkaZ9SGFr();
					bool flag6 = !flag5;
					if (flag6)
					{
						int num2 = (int)Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), interactableItem.transform.position.DEfdLut9iGJvTAJNGrXHRFglR());
						bool flag7 = num2 > fov;
						bool flag8 = !flag7;
						if (flag8)
						{
							bool flag9 = num2 < num;
							bool flag10 = flag9;
							if (flag10)
							{
								num = num2;
								rii = interactableItem;
							}
						}
					}
				}
			}
		}
		return rii != null;
	}

	// Token: 0x060001FA RID: 506 RVA: 0x00019B20 File Offset: 0x00017D20
	public static bool D22Fv6gmHdQIYQieDCB2jyGYG(InteractableItem ii)
	{
		return ii != null && (!(Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[1].DTyDRC9cdG8IGn9zMpTt5eaiL[0].DInHPFtxebvVx7sh7DNy96Mrp as Dx0mI3VF7tws4aOTlUQV9RnyL).DkcopsW2kYlTkNiHyikzClfPi || ((Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[1].DTyDRC9cdG8IGn9zMpTt5eaiL[0].DInHPFtxebvVx7sh7DNy96Mrp as Dx0mI3VF7tws4aOTlUQV9RnyL).DKvz06YBIXby4bzyzQBesuZZf ? (!DHKOlhPS98QOeYArRzpLwTeId.itemsToESP.ContainsKey(ii.asset.id)) : DHKOlhPS98QOeYArRzpLwTeId.itemsToESP.ContainsKey(ii.asset.id))) && (!(Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[1].DTyDRC9cdG8IGn9zMpTt5eaiL[0].DInHPFtxebvVx7sh7DNy96Mrp as Dx0mI3VF7tws4aOTlUQV9RnyL).DRmsWPTdgvBqovH0bGUwaAaU8 || (Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[1].DTyDRC9cdG8IGn9zMpTt5eaiL[0].DInHPFtxebvVx7sh7DNy96Mrp as Dx0mI3VF7tws4aOTlUQV9RnyL).DZiJVLx1YOES6umDzig25wx8J.Contains(ii.asset.GetType()));
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00019C00 File Offset: 0x00017E00
	public static void DHWjfhOGQm3jFehLG6hDp0i4e(DDB8pIlWKKbHkw2jCuyAPcvL7 ci)
	{
		bool flag = !DHKOlhPS98QOeYArRzpLwTeId.itemsToESP.ContainsKey(ci.Dn06Kjd8jxL0Tj2Vfupj8Skcq);
		bool flag2 = flag;
		if (flag2)
		{
			DHKOlhPS98QOeYArRzpLwTeId.itemsToESP.Add(ci.Dn06Kjd8jxL0Tj2Vfupj8Skcq, ci);
		}
	}

	// Token: 0x060001FC RID: 508 RVA: 0x00019C3C File Offset: 0x00017E3C
	public static void DvS0AYUQBKzcCD2W8lZEgSZ6k(ushort id)
	{
		bool flag = DHKOlhPS98QOeYArRzpLwTeId.itemsToESP.ContainsKey(id);
		bool flag2 = flag;
		if (flag2)
		{
			DHKOlhPS98QOeYArRzpLwTeId.itemsToESP.Remove(id);
		}
	}

	// Token: 0x0400027B RID: 635
	public static List<DDB8pIlWKKbHkw2jCuyAPcvL7> D4NYxH9hHVZz7r5I5BQPpqy3O = new List<DDB8pIlWKKbHkw2jCuyAPcvL7>();

	// Token: 0x0400027C RID: 636
	public static Dictionary<ushort, List<InteractableItem>> DETnSkbBFwL4Y4VUu0KiicL8H = new Dictionary<ushort, List<InteractableItem>>();

	// Token: 0x0400027D RID: 637
	public static List<InteractableItem> Dhd6dKsh0e6NOxF0kEgF2zpj3 = new List<InteractableItem>();

	// Token: 0x0400027E RID: 638
	public static List<Type> D1vkgiDHsaPtBWm3wQcDo0jvI = new List<Type>
	{
		typeof(ItemGunAsset),
		typeof(ItemMagazineAsset),
		typeof(ItemMedicalAsset),
		typeof(ItemFoodAsset),
		typeof(ItemWaterAsset),
		typeof(ItemBackpackAsset),
		typeof(ItemChargeAsset),
		typeof(ItemFuelAsset),
		typeof(ItemClothingAsset),
		typeof(ItemMeleeAsset),
		typeof(ItemFarmAsset),
		typeof(ItemConsumeableAsset)
	};

	// Token: 0x0400027F RID: 639
	public static Dictionary<string, Type> DrfsvLu2uAeBZIcIFj70rO5Fq = new Dictionary<string, Type>();

	// Token: 0x04000280 RID: 640
	public static float DzRc0qU4iXGCpCyhwrAYwcLMg = 0f;

	// Token: 0x04000281 RID: 641
	public static float D1RsnP9Pcan7bfrG0wP9TWzsq = 0f;
}
