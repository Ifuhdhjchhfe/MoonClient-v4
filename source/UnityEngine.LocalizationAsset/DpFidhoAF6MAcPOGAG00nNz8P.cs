using System;
using System.Collections.Generic;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200009E RID: 158
public static class DpFidhoAF6MAcPOGAG00nNz8P
{
	// Token: 0x0600030B RID: 779 RVA: 0x0002D8F8 File Offset: 0x0002BAF8
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerDashboardInventoryUI), "updateNearbyDrops", new Type[] { })]
	public static void DDXBEKE7NJ30IVyMz07vVu5wt()
	{
		bool flag = !PlayerDashboardInventoryUI.active || DpFidhoAF6MAcPOGAG00nNz8P.DM7p0T8JYAqSX1XUfKjkz5M9N.value.Count < 1;
		bool flag2 = !flag;
		if (flag2)
		{
			int height = (int)DpFidhoAF6MAcPOGAG00nNz8P.DuhD0yD3MRw9eshJvhAgoMqfj.value.height;
			Vector3 eyesPositionWithoutLeaning = Player.player.look.GetEyesPositionWithoutLeaning();
			int num = Mathf.Max(0, DpFidhoAF6MAcPOGAG00nNz8P.DM7p0T8JYAqSX1XUfKjkz5M9N.value.Count - 20);
			for (int i = DpFidhoAF6MAcPOGAG00nNz8P.DM7p0T8JYAqSX1XUfKjkz5M9N.value.Count - 1; i >= num; i--)
			{
				InteractableItem interactableItem = DpFidhoAF6MAcPOGAG00nNz8P.DM7p0T8JYAqSX1XUfKjkz5M9N.value[i];
				DpFidhoAF6MAcPOGAG00nNz8P.DM7p0T8JYAqSX1XUfKjkz5M9N.value.RemoveAt(i);
				bool flag3 = !(interactableItem == null) && interactableItem.item != null;
				bool flag4 = flag3;
				if (flag4)
				{
					Renderer componentInChildren = interactableItem.transform.GetComponentInChildren<Renderer>();
					bool flag5 = !(componentInChildren == null);
					bool flag6 = flag5;
					if (flag6)
					{
						Vector3 center = componentInChildren.bounds.center;
						RaycastHit raycastHit = default(RaycastHit);
						bool flag7 = D5l46jlssr4TRAzUSXzLj0uqu.extendRegionInteractThroughWalls || !Physics.Linecast(eyesPositionWithoutLeaning, center, out raycastHit, RayMasks.BLOCK_PICKUP, QueryTriggerInteraction.Ignore);
						bool flag8 = flag7;
						if (flag8)
						{
							DpFidhoAF6MAcPOGAG00nNz8P.DizOTDNe0DZagkEbBQrC3xdsT.D8bo6z6P4C0fkdfFioOF82Ftk(new object[] { interactableItem });
						}
					}
				}
			}
			bool flag9 = (int)DpFidhoAF6MAcPOGAG00nNz8P.DuhD0yD3MRw9eshJvhAgoMqfj.value.height > height;
			bool flag10 = flag9;
			if (flag10)
			{
				DpFidhoAF6MAcPOGAG00nNz8P.DhRBWFbiMjT18lnb71mpg8XW4.D8bo6z6P4C0fkdfFioOF82Ftk(Array.Empty<object>());
			}
		}
	}

	// Token: 0x0400036C RID: 876
	public static DGZv08vQyz81zrHxUqhmYuCdY<List<InteractableItem>> DM7p0T8JYAqSX1XUfKjkz5M9N = new DGZv08vQyz81zrHxUqhmYuCdY<List<InteractableItem>>(typeof(PlayerDashboardInventoryUI), "pendingItemsInRadius", BindingFlags.Static | BindingFlags.NonPublic);

	// Token: 0x0400036D RID: 877
	public static DGZv08vQyz81zrHxUqhmYuCdY<Items> DuhD0yD3MRw9eshJvhAgoMqfj = new DGZv08vQyz81zrHxUqhmYuCdY<Items>(typeof(PlayerDashboardInventoryUI), "areaItems", BindingFlags.Static | BindingFlags.NonPublic);

	// Token: 0x0400036E RID: 878
	public static DQyA1nzDa0rZuYtgcLmIWOUf8 DizOTDNe0DZagkEbBQrC3xdsT = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(PlayerDashboardInventoryUI), "createElementForNearbyDrop", BindingFlags.Static | BindingFlags.NonPublic);

	// Token: 0x0400036F RID: 879
	public static DQyA1nzDa0rZuYtgcLmIWOUf8 DhRBWFbiMjT18lnb71mpg8XW4 = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(PlayerDashboardInventoryUI), "updateBoxAreas", BindingFlags.Static | BindingFlags.NonPublic);
}
