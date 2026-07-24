using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000AD RID: 173
public static class DRiUgFwe1bGGW0FKHIPOjT4PT
{
	// Token: 0x0600035E RID: 862 RVA: 0x00031148 File Offset: 0x0002F348
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DwVer2FaXUUHMb3K8sRS3BmCF()
	{
		List<ValueTuple<string, Font>> list = new List<ValueTuple<string, Font>>();
		foreach (string text in Font.GetOSInstalledFontNames())
		{
			Font font = Font.CreateDynamicFontFromOSFont(text, 14);
			bool flag = font != null;
			if (flag)
			{
				list.Add(new ValueTuple<string, Font>(text, font));
			}
		}
		DRiUgFwe1bGGW0FKHIPOjT4PT.DPjwh94gPzgXg5pL1YCdYACP9 = list.ToArray();
		foreach (ValueTuple<string, Font> valueTuple in DRiUgFwe1bGGW0FKHIPOjT4PT.DPjwh94gPzgXg5pL1YCdYACP9)
		{
			string item = valueTuple.Item1;
			Font item2 = valueTuple.Item2;
			DRiUgFwe1bGGW0FKHIPOjT4PT.DBnnqOFz4Q43TJmECcblR0OPO.Add(item2);
			DRiUgFwe1bGGW0FKHIPOjT4PT.DHhYdV8x6Xwu6z0tQ7DGWzWik.Add(item, item2);
		}
	}

	// Token: 0x040003A0 RID: 928
	public static ValueTuple<string, Font>[] DPjwh94gPzgXg5pL1YCdYACP9 = new ValueTuple<string, Font>[0];

	// Token: 0x040003A1 RID: 929
	public static Dictionary<string, Font> DHhYdV8x6Xwu6z0tQ7DGWzWik = new Dictionary<string, Font>();

	// Token: 0x040003A2 RID: 930
	public static List<Font> DBnnqOFz4Q43TJmECcblR0OPO = new List<Font>();
}
