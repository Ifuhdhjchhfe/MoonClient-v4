using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200000A RID: 10
public class D0MkIyl7CS81FHd522P7IXmir : DSvAEyoSitLrXzsZSSRwWfJ5T
{
	// Token: 0x06000027 RID: 39 RVA: 0x000037D0 File Offset: 0x000019D0
	public override bool GetAviablity()
	{
		return D0MkIyl7CS81FHd522P7IXmir.opened;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000037E8 File Offset: 0x000019E8
	public override bool IsShowOnMenu()
	{
		return true;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x000037FC File Offset: 0x000019FC
	public override Vector2 GetSize()
	{
		return new Vector2(320f, 400f);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00003820 File Offset: 0x00001A20
	public override void DrawWindow()
	{
		base.DZxuXSmWDxed28SbJ8XfD3yXH("Nearby items");
		D0MkIyl7CS81FHd522P7IXmir.findText = DqNh7bzS0xEILWgxFJA4tpJpp.DA0xO1x0ojIH3QqDbi5vOJWc5(D0MkIyl7CS81FHd522P7IXmir.findText);
		DqNh7bzS0xEILWgxFJA4tpJpp.DyBn18hxKzKkq5aDAdvau4Wv2(this.DTcM9b44DZ76jsbMJqLa2lyjE);
		foreach (List<InteractableItem> list in DHKOlhPS98QOeYArRzpLwTeId.DETnSkbBFwL4Y4VUu0KiicL8H.Values)
		{
			bool flag = list.Count == 1 && list[0] == null;
			bool flag2 = !flag;
			if (flag2)
			{
				int num = 0;
				string text = "";
				bool flag3 = list.Count == 1;
				bool flag4 = flag3;
				if (flag4)
				{
					num = 1;
					text = list[0].asset.itemName;
					bool flag5 = Vector3.Distance(Player.player.transform.position, list[0].transform.position) > 20f;
					bool flag6 = flag5;
					if (flag6)
					{
						continue;
					}
				}
				else
				{
					foreach (InteractableItem interactableItem in list)
					{
						bool flag7 = interactableItem != null && Vector3.Distance(Player.player.transform.position, interactableItem.transform.position) <= 20f;
						bool flag8 = flag7;
						if (flag8)
						{
							text = list[0].asset.itemName;
							num++;
						}
					}
					bool flag9 = num == 0;
					bool flag10 = flag9;
					if (flag10)
					{
						continue;
					}
				}
				bool flag11 = (string.IsNullOrEmpty(D0MkIyl7CS81FHd522P7IXmir.findText) || text.ToLower().Contains(D0MkIyl7CS81FHd522P7IXmir.findText.ToLower())) && DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(text + ((num > 1) ? string.Format(" ({0})", num) : ""));
				bool flag12 = flag11;
				if (flag12)
				{
					list[0].use();
				}
			}
		}
		this.DTcM9b44DZ76jsbMJqLa2lyjE = DqNh7bzS0xEILWgxFJA4tpJpp.De6903YEzOzl7pEaVTq3q7dnf();
		bool flag13 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF("Close");
		bool flag14 = flag13;
		if (flag14)
		{
			D0MkIyl7CS81FHd522P7IXmir.opened = false;
		}
	}

	// Token: 0x04000015 RID: 21
	[Dy6M3joVi08gNRZyTkEnTy5qj("NearbyItemsWindow.Opened")]
	public static bool opened = false;

	// Token: 0x04000016 RID: 22
	[Dy6M3joVi08gNRZyTkEnTy5qj("NearbyItemsWindow.FindText")]
	public static string findText = "";

	// Token: 0x04000017 RID: 23
	public Vector2 DTcM9b44DZ76jsbMJqLa2lyjE = Vector2.zero;
}
