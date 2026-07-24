using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000032 RID: 50
public static class DaO9f3lpxmBiQYAqfDrnWqU7e
{
	// Token: 0x060000DE RID: 222 RVA: 0x0000A2D8 File Offset: 0x000084D8
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(ItemManager), "findSimulatedItemsInRadius", new Type[] { })]
	public static void DXGbW6BWbvY44BNp0qbVV8oHz(Vector3 center, float sqrRadius, List<InteractableItem> result)
	{
		sqrRadius = (D5l46jlssr4TRAzUSXzLj0uqu.extendPlayerRegion ? ((float)(D5l46jlssr4TRAzUSXzLj0uqu.extendRegionRange * D5l46jlssr4TRAzUSXzLj0uqu.extendRegionRange)) : sqrRadius);
		bool flag = ItemManager.clampedItems == null;
		bool flag2 = !flag;
		if (flag2)
		{
			foreach (InteractableItem interactableItem in ItemManager.clampedItems)
			{
				bool flag3 = interactableItem != null && (interactableItem.transform.position - center).sqrMagnitude <= sqrRadius;
				bool flag4 = flag3;
				if (flag4)
				{
					result.Add(interactableItem);
				}
			}
		}
	}
}
