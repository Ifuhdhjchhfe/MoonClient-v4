using System;
using UnityEngine;

// Token: 0x02000094 RID: 148
public class DOFx241sQSz07GkAdUwghFS1G : DSvAEyoSitLrXzsZSSRwWfJ5T
{
	// Token: 0x060002D3 RID: 723 RVA: 0x00029BBC File Offset: 0x00027DBC
	public override bool GetAviablity()
	{
		return DOFx241sQSz07GkAdUwghFS1G.isActive;
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00029BD4 File Offset: 0x00027DD4
	public override Vector2 GetSize()
	{
		return new Vector2(320f, 400f);
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00029BF8 File Offset: 0x00027DF8
	public override bool IsShowOnMenu()
	{
		return true;
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x00029C0C File Offset: 0x00027E0C
	public override void DrawWindow()
	{
		base.DZxuXSmWDxed28SbJ8XfD3yXH("Add item to auto pickup");
		DOFx241sQSz07GkAdUwghFS1G.findText = DqNh7bzS0xEILWgxFJA4tpJpp.DA0xO1x0ojIH3QqDbi5vOJWc5(DOFx241sQSz07GkAdUwghFS1G.findText);
		bool flag = string.IsNullOrEmpty(DOFx241sQSz07GkAdUwghFS1G.findText);
		bool flag2 = flag;
		if (flag2)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.DyBn18hxKzKkq5aDAdvau4Wv2(DOFx241sQSz07GkAdUwghFS1G.D5cJkgUbtkmE2mUZn0pT91fjD);
			for (int i = 0; i < DHKOlhPS98QOeYArRzpLwTeId.D4NYxH9hHVZz7r5I5BQPpqy3O.Count; i++)
			{
				bool flag3 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(DHKOlhPS98QOeYArRzpLwTeId.D4NYxH9hHVZz7r5I5BQPpqy3O[i].DjHtc6kil0ZuGKFFgQKYQvYK2) && !D5l46jlssr4TRAzUSXzLj0uqu.DzksjAWr7fP6HlkBNdY20fpHC.ContainsKey(DHKOlhPS98QOeYArRzpLwTeId.D4NYxH9hHVZz7r5I5BQPpqy3O[i].Dn06Kjd8jxL0Tj2Vfupj8Skcq);
				bool flag4 = flag3;
				if (flag4)
				{
					D5l46jlssr4TRAzUSXzLj0uqu.DzksjAWr7fP6HlkBNdY20fpHC.Add(DHKOlhPS98QOeYArRzpLwTeId.D4NYxH9hHVZz7r5I5BQPpqy3O[i].Dn06Kjd8jxL0Tj2Vfupj8Skcq, DHKOlhPS98QOeYArRzpLwTeId.D4NYxH9hHVZz7r5I5BQPpqy3O[i]);
				}
			}
			DOFx241sQSz07GkAdUwghFS1G.D5cJkgUbtkmE2mUZn0pT91fjD = DqNh7bzS0xEILWgxFJA4tpJpp.De6903YEzOzl7pEaVTq3q7dnf();
		}
		else
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.DyBn18hxKzKkq5aDAdvau4Wv2(DOFx241sQSz07GkAdUwghFS1G.D5cJkgUbtkmE2mUZn0pT91fjD);
			foreach (DDB8pIlWKKbHkw2jCuyAPcvL7 ddb8pIlWKKbHkw2jCuyAPcvL in DHKOlhPS98QOeYArRzpLwTeId.D4NYxH9hHVZz7r5I5BQPpqy3O)
			{
				bool flag5 = ddb8pIlWKKbHkw2jCuyAPcvL.DjHtc6kil0ZuGKFFgQKYQvYK2.ToLower().Contains(DOFx241sQSz07GkAdUwghFS1G.findText.ToLower()) && DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(ddb8pIlWKKbHkw2jCuyAPcvL.DjHtc6kil0ZuGKFFgQKYQvYK2) && !D5l46jlssr4TRAzUSXzLj0uqu.DzksjAWr7fP6HlkBNdY20fpHC.ContainsKey(ddb8pIlWKKbHkw2jCuyAPcvL.Dn06Kjd8jxL0Tj2Vfupj8Skcq);
				bool flag6 = flag5;
				if (flag6)
				{
					D5l46jlssr4TRAzUSXzLj0uqu.DzksjAWr7fP6HlkBNdY20fpHC.Add(ddb8pIlWKKbHkw2jCuyAPcvL.Dn06Kjd8jxL0Tj2Vfupj8Skcq, ddb8pIlWKKbHkw2jCuyAPcvL);
				}
			}
			DOFx241sQSz07GkAdUwghFS1G.D5cJkgUbtkmE2mUZn0pT91fjD = DqNh7bzS0xEILWgxFJA4tpJpp.De6903YEzOzl7pEaVTq3q7dnf();
		}
		bool flag7 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF("Close");
		bool flag8 = flag7;
		if (flag8)
		{
			DOFx241sQSz07GkAdUwghFS1G.isActive = false;
		}
	}

	// Token: 0x04000337 RID: 823
	[Dy6M3joVi08gNRZyTkEnTy5qj("AutoPickupItemWindow.Opened")]
	public static bool isActive = false;

	// Token: 0x04000338 RID: 824
	[Dy6M3joVi08gNRZyTkEnTy5qj("AutoPickupItemWindow.FindText")]
	public static string findText = "";

	// Token: 0x04000339 RID: 825
	public static Vector2 D5cJkgUbtkmE2mUZn0pT91fjD = Vector2.zero;
}
