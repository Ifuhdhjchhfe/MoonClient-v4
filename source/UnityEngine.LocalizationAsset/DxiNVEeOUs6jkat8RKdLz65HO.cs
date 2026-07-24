using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000D2 RID: 210
public class DxiNVEeOUs6jkat8RKdLz65HO : DOEkZ1zoBEuvfUmOs9QSpfX0X
{
	// Token: 0x060003FC RID: 1020 RVA: 0x0003CC5C File Offset: 0x0003AE5C
	public override string GetName()
	{
		return "Skin changer";
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x0003CC74 File Offset: 0x0003AE74
	public override void DoTab(DYIPJORHeVCfbpocFHvJty4OE tc)
	{
		bool flag = tc == DYIPJORHeVCfbpocFHvJty4OE.One;
		if (flag)
		{
			foreach (DnFbkaUD6mnA1BajCnfh8ztdO dnFbkaUD6mnA1BajCnfh8ztdO in DNvjrDV53gpGJEJwnNwmyFRZw.DfvD7oGtLv9eVTgp0vv7bK8Az.Keys)
			{
				bool flag2 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv(dnFbkaUD6mnA1BajCnfh8ztdO.ToString(), -1, true, null);
				if (flag2)
				{
					this.DACL24fbvHAmosunrLKg91mHo = dnFbkaUD6mnA1BajCnfh8ztdO;
				}
			}
			bool flag3 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Clear skins", -1, true, null);
			if (flag3)
			{
				DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0.Clear();
				Player.player.clothing.firstClothes.visualHat = 0;
				Player.player.clothing.firstClothes.visualMask = 0;
				Player.player.clothing.firstClothes.visualGlasses = 0;
				Player.player.clothing.firstClothes.visualVest = 0;
				Player.player.clothing.firstClothes.visualBackpack = 0;
				Player.player.clothing.firstClothes.visualShirt = 0;
				Player.player.clothing.firstClothes.visualPants = 0;
				Player.player.clothing.thirdClothes.visualHat = 0;
				Player.player.clothing.thirdClothes.visualMask = 0;
				Player.player.clothing.thirdClothes.visualGlasses = 0;
				Player.player.clothing.thirdClothes.visualVest = 0;
				Player.player.clothing.thirdClothes.visualBackpack = 0;
				Player.player.clothing.thirdClothes.visualShirt = 0;
				Player.player.clothing.thirdClothes.visualPants = 0;
				Player.player.clothing.characterClothes.visualHat = 0;
				Player.player.clothing.characterClothes.visualMask = 0;
				Player.player.clothing.characterClothes.visualGlasses = 0;
				Player.player.clothing.characterClothes.visualVest = 0;
				Player.player.clothing.characterClothes.visualBackpack = 0;
				Player.player.clothing.characterClothes.visualShirt = 0;
				Player.player.clothing.characterClothes.visualPants = 0;
				Player.player.clothing.firstClothes.apply();
				Player.player.clothing.thirdClothes.apply();
				Player.player.clothing.characterClothes.apply();
			}
		}
		else
		{
			bool flag4 = DNvjrDV53gpGJEJwnNwmyFRZw.DfvD7oGtLv9eVTgp0vv7bK8Az.ContainsKey(this.DACL24fbvHAmosunrLKg91mHo);
			if (flag4)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.D0N2vkljxxCW0Fn0PI1WVCCTj(DrysTRTjdLdFqu5GJBDif6AoV.Dtib43oq6yhDjtGzggdWk0MwM);
				try
				{
					GUILayout.Space(20f);
					DxiNVEeOUs6jkat8RKdLz65HO.DnaZpxCFvli6UKm5oWGdB3Yai = GUILayout.TextField(DxiNVEeOUs6jkat8RKdLz65HO.DnaZpxCFvli6UKm5oWGdB3Yai, Array.Empty<GUILayoutOption>());
					D20i1Qc1Q96crSRmQYn2qE39Z[] array = DNvjrDV53gpGJEJwnNwmyFRZw.DfvD7oGtLv9eVTgp0vv7bK8Az[this.DACL24fbvHAmosunrLKg91mHo];
					bool flag5 = !string.IsNullOrEmpty(DxiNVEeOUs6jkat8RKdLz65HO.DnaZpxCFvli6UKm5oWGdB3Yai);
					string text = DxiNVEeOUs6jkat8RKdLz65HO.DnaZpxCFvli6UKm5oWGdB3Yai.ToLower();
					int num = 0;
					foreach (D20i1Qc1Q96crSRmQYn2qE39Z d20i1Qc1Q96crSRmQYn2qE39Z in array)
					{
						bool flag6 = !flag5 || d20i1Qc1Q96crSRmQYn2qE39Z.DHjVqpSoQXKdwRGlz0BdAiYjR.ToLower().Contains(text);
						if (flag6)
						{
							num++;
						}
					}
					float num2 = (float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX;
					float num3 = (float)(DqNh7bzS0xEILWgxFJA4tpJpp.width - DqNh7bzS0xEILWgxFJA4tpJpp.padding);
					float num4 = DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset;
					float num5 = DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height - num4 - 10f;
					num5 = Mathf.Max(num5, 100f);
					float num6 = 20f;
					float num7 = (float)num * num6;
					Rect rect = new Rect(num2, num4, num3, num5);
					Rect rect2 = new Rect(0f, 0f, num3 - 16f, num7);
					bool flag7 = flag5;
					Vector2 vector;
					if (flag7)
					{
						vector = this.DZR8oDF0bKGONL7lfvqPdV4SS;
					}
					else
					{
						bool flag8 = !this.DGpCx4zqkNsRXagnslf0cOz3K.ContainsKey(this.DACL24fbvHAmosunrLKg91mHo);
						if (flag8)
						{
							this.DGpCx4zqkNsRXagnslf0cOz3K[this.DACL24fbvHAmosunrLKg91mHo] = Vector2.zero;
						}
						vector = this.DGpCx4zqkNsRXagnslf0cOz3K[this.DACL24fbvHAmosunrLKg91mHo];
					}
					vector = GUI.BeginScrollView(rect, vector, rect2);
					int num8 = Mathf.Max(0, Mathf.FloorToInt(vector.y / num6) - 1);
					int num9 = Mathf.Min(num, Mathf.CeilToInt((vector.y + num5) / num6) + 1);
					int num10 = 0;
					for (int j = 0; j < array.Length; j++)
					{
						bool flag9 = flag5 && !array[j].DHjVqpSoQXKdwRGlz0BdAiYjR.ToLower().Contains(text);
						if (!flag9)
						{
							bool flag10 = num10 >= num8 && num10 < num9;
							if (flag10)
							{
								Rect rect3 = new Rect(0f, (float)num10 * num6, num3 - 16f, num6);
								bool flag11 = DrysTRTjdLdFqu5GJBDif6AoV.D2UPBO4RKVK2FGU73V1EA74Z1(rect3, array[j].DHjVqpSoQXKdwRGlz0BdAiYjR, -1, true);
								if (flag11)
								{
									DNvjrDV53gpGJEJwnNwmyFRZw.DBiu5zgu2TPYXgMbjOLO2p6cf(array[j]);
								}
							}
							num10++;
						}
					}
					GUI.EndScrollView();
					bool flag12 = flag5;
					if (flag12)
					{
						this.DZR8oDF0bKGONL7lfvqPdV4SS = vector;
					}
					else
					{
						this.DGpCx4zqkNsRXagnslf0cOz3K[this.DACL24fbvHAmosunrLKg91mHo] = vector;
					}
					DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += (int)num5;
				}
				finally
				{
					DqNh7bzS0xEILWgxFJA4tpJpp.DPwTKZ7HMwYN7gq8ega8BFo1i();
				}
			}
		}
	}

	// Token: 0x04000445 RID: 1093
	public Dictionary<DnFbkaUD6mnA1BajCnfh8ztdO, Vector2> DGpCx4zqkNsRXagnslf0cOz3K = new Dictionary<DnFbkaUD6mnA1BajCnfh8ztdO, Vector2>();

	// Token: 0x04000446 RID: 1094
	public Vector2 DZR8oDF0bKGONL7lfvqPdV4SS = Vector2.zero;

	// Token: 0x04000447 RID: 1095
	public DnFbkaUD6mnA1BajCnfh8ztdO DACL24fbvHAmosunrLKg91mHo;

	// Token: 0x04000448 RID: 1096
	public static string DnaZpxCFvli6UKm5oWGdB3Yai = "";
}
