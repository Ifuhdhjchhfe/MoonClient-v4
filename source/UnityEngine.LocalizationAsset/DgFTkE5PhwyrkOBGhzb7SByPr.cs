using System;
using UnityEngine;

// Token: 0x0200005D RID: 93
public class DgFTkE5PhwyrkOBGhzb7SByPr
{
	// Token: 0x060001B9 RID: 441 RVA: 0x000171C0 File Offset: 0x000153C0
	public static void DfdU0FmLG6qC1LMht1Y27juNW(ref Rect rect)
	{
		bool flag = !Input.GetMouseButton(0) || Input.GetMouseButtonUp(0);
		bool flag2 = flag;
		if (flag2)
		{
			DgFTkE5PhwyrkOBGhzb7SByPr.DECcFT52FA5xC2s0lIlsdTd6D = false;
		}
		bool flag3 = (Input.GetMouseButtonDown(0) || DgFTkE5PhwyrkOBGhzb7SByPr.DECcFT52FA5xC2s0lIlsdTd6D) && rect.Contains(DgFTkE5PhwyrkOBGhzb7SByPr.DQeVKfUtSo91c04D4USEFBSTJ) && DgFTkE5PhwyrkOBGhzb7SByPr.DQeVKfUtSo91c04D4USEFBSTJ != new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		bool flag4 = flag3;
		if (flag4)
		{
			DgFTkE5PhwyrkOBGhzb7SByPr.DECcFT52FA5xC2s0lIlsdTd6D = true;
			rect.x -= DgFTkE5PhwyrkOBGhzb7SByPr.DQeVKfUtSo91c04D4USEFBSTJ.x - Input.mousePosition.x;
			rect.y -= DgFTkE5PhwyrkOBGhzb7SByPr.DQeVKfUtSo91c04D4USEFBSTJ.y - ((float)Screen.height - Input.mousePosition.y);
		}
	}

	// Token: 0x060001BA RID: 442 RVA: 0x0001728A File Offset: 0x0001548A
	public static void D5PoU1Z8B0TEead79RahhAYgM()
	{
		DgFTkE5PhwyrkOBGhzb7SByPr.DQeVKfUtSo91c04D4USEFBSTJ = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
	}

	// Token: 0x0400022F RID: 559
	public static bool DECcFT52FA5xC2s0lIlsdTd6D = false;

	// Token: 0x04000230 RID: 560
	public static Vector2 DQeVKfUtSo91c04D4USEFBSTJ = Vector2.zero;
}
