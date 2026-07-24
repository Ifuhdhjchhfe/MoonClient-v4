using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000DD RID: 221
public class DYMz7RDPFveX28vGc5VCgHkct : DSvAEyoSitLrXzsZSSRwWfJ5T
{
	// Token: 0x06000425 RID: 1061 RVA: 0x0003E6F0 File Offset: 0x0003C8F0
	public override bool GetAviablity()
	{
		return DYMz7RDPFveX28vGc5VCgHkct.isActive;
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x0003E708 File Offset: 0x0003C908
	public override Vector2 GetSize()
	{
		return new Vector2(404f, 404f);
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x0003E72C File Offset: 0x0003C92C
	public override bool IsShowOnMenu()
	{
		return true;
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x0003E740 File Offset: 0x0003C940
	public static string DJFz3RrjAhHLgLt2YkM0jEUNq(string text)
	{
		string text2 = text.Replace("Asset", "");
		for (int i = 0; i < text2.Length - 1; i++)
		{
			bool flag = i > 0 && text2[i - 1] != ' ' && text2[i] != ' ' && text2[i + 1] != ' ' && char.IsLower(text2[i]) && char.IsUpper(text2[i + 1]);
			bool flag2 = flag;
			if (flag2)
			{
				text2 = text2.Insert(i + 1, " ");
			}
		}
		return text2.ToLower();
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x0003E7E8 File Offset: 0x0003C9E8
	public override void DrawWindow()
	{
		base.DZxuXSmWDxed28SbJ8XfD3yXH("Add item");
		try
		{
			DYMz7RDPFveX28vGc5VCgHkct.findText = DqNh7bzS0xEILWgxFJA4tpJpp.DA0xO1x0ojIH3QqDbi5vOJWc5(DYMz7RDPFveX28vGc5VCgHkct.findText);
			DaDJKEXuXXWelEjFIsFjrqq81 currentArea = DqNh7bzS0xEILWgxFJA4tpJpp.currentArea;
			currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.x = currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.x + 5f;
			DaDJKEXuXXWelEjFIsFjrqq81 currentArea2 = DqNh7bzS0xEILWgxFJA4tpJpp.currentArea;
			currentArea2.D4BeFEx49h9DAVcFOFkaCZHbh.width = currentArea2.D4BeFEx49h9DAVcFOFkaCZHbh.width - 10f;
			(Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[1].DTyDRC9cdG8IGn9zMpTt5eaiL[0].DInHPFtxebvVx7sh7DNy96Mrp as Dx0mI3VF7tws4aOTlUQV9RnyL).DRmsWPTdgvBqovH0bGUwaAaU8 = DqNh7bzS0xEILWgxFJA4tpJpp.DlwMc0UCVjPOWI7FoW0ZmMlrk((Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[1].DTyDRC9cdG8IGn9zMpTt5eaiL[0].DInHPFtxebvVx7sh7DNy96Mrp as Dx0mI3VF7tws4aOTlUQV9RnyL).DRmsWPTdgvBqovH0bGUwaAaU8, "Is use category filtering");
			int offset = DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset;
			bool drmsWPTdgvBqovH0bGUwaAaU = (Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[1].DTyDRC9cdG8IGn9zMpTt5eaiL[0].DInHPFtxebvVx7sh7DNy96Mrp as Dx0mI3VF7tws4aOTlUQV9RnyL).DRmsWPTdgvBqovH0bGUwaAaU8;
			bool flag = drmsWPTdgvBqovH0bGUwaAaU;
			if (flag)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.width = 220f;
			}
			bool flag2 = string.IsNullOrEmpty(DYMz7RDPFveX28vGc5VCgHkct.findText);
			bool flag3 = flag2;
			if (flag3)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.DyBn18hxKzKkq5aDAdvau4Wv2(DYMz7RDPFveX28vGc5VCgHkct.D65NA6rbrUknH0UxkL4W9ngWO);
				for (int i = 0; i < DHKOlhPS98QOeYArRzpLwTeId.D4NYxH9hHVZz7r5I5BQPpqy3O.Count; i++)
				{
					bool flag4 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(DHKOlhPS98QOeYArRzpLwTeId.D4NYxH9hHVZz7r5I5BQPpqy3O[i].DjHtc6kil0ZuGKFFgQKYQvYK2);
					bool flag5 = flag4;
					if (flag5)
					{
						DHKOlhPS98QOeYArRzpLwTeId.DHWjfhOGQm3jFehLG6hDp0i4e(DHKOlhPS98QOeYArRzpLwTeId.D4NYxH9hHVZz7r5I5BQPpqy3O[i]);
					}
				}
				DYMz7RDPFveX28vGc5VCgHkct.D65NA6rbrUknH0UxkL4W9ngWO = DqNh7bzS0xEILWgxFJA4tpJpp.De6903YEzOzl7pEaVTq3q7dnf();
			}
			else
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.DyBn18hxKzKkq5aDAdvau4Wv2(DYMz7RDPFveX28vGc5VCgHkct.D65NA6rbrUknH0UxkL4W9ngWO);
				foreach (DDB8pIlWKKbHkw2jCuyAPcvL7 ddb8pIlWKKbHkw2jCuyAPcvL in DHKOlhPS98QOeYArRzpLwTeId.D4NYxH9hHVZz7r5I5BQPpqy3O)
				{
					bool flag6 = ddb8pIlWKKbHkw2jCuyAPcvL.DjHtc6kil0ZuGKFFgQKYQvYK2.ToLower().Contains(DYMz7RDPFveX28vGc5VCgHkct.findText.ToLower()) && DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(ddb8pIlWKKbHkw2jCuyAPcvL.DjHtc6kil0ZuGKFFgQKYQvYK2);
					bool flag7 = flag6;
					if (flag7)
					{
						DHKOlhPS98QOeYArRzpLwTeId.DHWjfhOGQm3jFehLG6hDp0i4e(ddb8pIlWKKbHkw2jCuyAPcvL);
					}
				}
				DYMz7RDPFveX28vGc5VCgHkct.D65NA6rbrUknH0UxkL4W9ngWO = DqNh7bzS0xEILWgxFJA4tpJpp.De6903YEzOzl7pEaVTq3q7dnf();
			}
			bool drmsWPTdgvBqovH0bGUwaAaU2 = (Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[1].DTyDRC9cdG8IGn9zMpTt5eaiL[0].DInHPFtxebvVx7sh7DNy96Mrp as Dx0mI3VF7tws4aOTlUQV9RnyL).DRmsWPTdgvBqovH0bGUwaAaU8;
			bool flag8 = drmsWPTdgvBqovH0bGUwaAaU2;
			if (flag8)
			{
				DaDJKEXuXXWelEjFIsFjrqq81 currentArea3 = DqNh7bzS0xEILWgxFJA4tpJpp.currentArea;
				currentArea3.D4BeFEx49h9DAVcFOFkaCZHbh.x = currentArea3.D4BeFEx49h9DAVcFOFkaCZHbh.x + 230f;
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset = offset;
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.width = 160f;
				byte b = 0;
				while ((int)b < DHKOlhPS98QOeYArRzpLwTeId.D1vkgiDHsaPtBWm3wQcDo0jvI.Count)
				{
					try
					{
						List<Type> dziJVLx1YOES6umDzig25wx8J = (Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[1].DTyDRC9cdG8IGn9zMpTt5eaiL[0].DInHPFtxebvVx7sh7DNy96Mrp as Dx0mI3VF7tws4aOTlUQV9RnyL).DZiJVLx1YOES6umDzig25wx8J;
						Type type = DHKOlhPS98QOeYArRzpLwTeId.D1vkgiDHsaPtBWm3wQcDo0jvI[(int)b];
						bool flag9 = dziJVLx1YOES6umDzig25wx8J.Contains(type);
						flag9 = DqNh7bzS0xEILWgxFJA4tpJpp.DlwMc0UCVjPOWI7FoW0ZmMlrk(flag9, "Filter " + DYMz7RDPFveX28vGc5VCgHkct.DJFz3RrjAhHLgLt2YkM0jEUNq(type.Name));
						bool flag10 = !dziJVLx1YOES6umDzig25wx8J.Contains(type) && flag9;
						bool flag11 = flag10;
						if (flag11)
						{
							dziJVLx1YOES6umDzig25wx8J.Add(type);
						}
						else
						{
							bool flag12 = dziJVLx1YOES6umDzig25wx8J.Contains(type) && !flag9;
							bool flag13 = flag12;
							if (flag13)
							{
								dziJVLx1YOES6umDzig25wx8J.Remove(type);
							}
						}
					}
					catch
					{
					}
					b += 1;
				}
			}
		}
		catch
		{
		}
		bool flag14 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF("Close");
		bool flag15 = flag14;
		if (flag15)
		{
			DYMz7RDPFveX28vGc5VCgHkct.isActive = false;
		}
	}

	// Token: 0x0400046A RID: 1130
	[Dy6M3joVi08gNRZyTkEnTy5qj("AddItemWindow.Opened")]
	public static bool isActive = false;

	// Token: 0x0400046B RID: 1131
	[Dy6M3joVi08gNRZyTkEnTy5qj("AddItemWindow.IsUseFiltering")]
	public static bool isUseFiltering = false;

	// Token: 0x0400046C RID: 1132
	[Dy6M3joVi08gNRZyTkEnTy5qj("AddItemWindow.FindText")]
	public static string findText = "";

	// Token: 0x0400046D RID: 1133
	public static Vector2 D65NA6rbrUknH0UxkL4W9ngWO = Vector2.zero;
}
