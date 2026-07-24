using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000A4 RID: 164
public class DqNh7bzS0xEILWgxFJA4tpJpp
{
	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000324 RID: 804 RVA: 0x0002FBF0 File Offset: 0x0002DDF0
	// (set) Token: 0x06000325 RID: 805 RVA: 0x0002FC18 File Offset: 0x0002DE18
	public static DaDJKEXuXXWelEjFIsFjrqq81 currentArea
	{
		get
		{
			return DqNh7bzS0xEILWgxFJA4tpJpp.DM7QlSs5TLbaVI0MEFveGJYvn[DqNh7bzS0xEILWgxFJA4tpJpp.DM7QlSs5TLbaVI0MEFveGJYvn.Count - 1];
		}
		set
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.DM7QlSs5TLbaVI0MEFveGJYvn[DqNh7bzS0xEILWgxFJA4tpJpp.DM7QlSs5TLbaVI0MEFveGJYvn.Count - 1] = value;
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000326 RID: 806 RVA: 0x0002FC34 File Offset: 0x0002DE34
	// (set) Token: 0x06000327 RID: 807 RVA: 0x0002FC7B File Offset: 0x0002DE7B
	public static DVQma6Vck8PRIpG0GaJcWvaRC currentScroll
	{
		get
		{
			return (DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DaBMP7BYA2NHNjSWxFpQH3eRz.Count > 0) ? DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DaBMP7BYA2NHNjSWxFpQH3eRz[DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DaBMP7BYA2NHNjSWxFpQH3eRz.Count - 1] : null;
		}
		set
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DaBMP7BYA2NHNjSWxFpQH3eRz[DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DaBMP7BYA2NHNjSWxFpQH3eRz.Count - 1] = value;
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000328 RID: 808 RVA: 0x0002FCA0 File Offset: 0x0002DEA0
	public static bool hasScroll
	{
		get
		{
			return DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll != null;
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000329 RID: 809 RVA: 0x0002FCBC File Offset: 0x0002DEBC
	public static int width
	{
		get
		{
			return DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR ? ((int)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.width / DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DKmwvC6RNDVVeG8d69Pm5Fg4P - 4) : ((int)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.width);
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x0600032A RID: 810 RVA: 0x0002FD0C File Offset: 0x0002DF0C
	public static int padding
	{
		get
		{
			return (DqNh7bzS0xEILWgxFJA4tpJpp.hasScroll && (!DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR || DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DopMKXLWJDd2q8dZ73XJtnV7j == DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DopMKXLWJDd2q8dZ73XJtnV7j + 1) && DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.DjvPtwypcWLlMv70pkPG7GUSa > DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.DipSuAvkvl7C1QdK4Q9PopnFi) ? 22 : 0;
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x0600032B RID: 811 RVA: 0x0002FD64 File Offset: 0x0002DF64
	public static int rectX
	{
		get
		{
			return (DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR ? ((int)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.x + (int)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.width / DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DKmwvC6RNDVVeG8d69Pm5Fg4P * DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DopMKXLWJDd2q8dZ73XJtnV7j + 2) : ((int)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.x)) + DqNh7bzS0xEILWgxFJA4tpJpp.DxNefxtklJ0TtK0IHMa8HdxPs;
		}
	}

	// Token: 0x0600032C RID: 812 RVA: 0x0002FDD3 File Offset: 0x0002DFD3
	public static void D0N2vkljxxCW0Fn0PI1WVCCTj(Rect rect)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.DM7QlSs5TLbaVI0MEFveGJYvn.Add(new DaDJKEXuXXWelEjFIsFjrqq81(rect));
	}

	// Token: 0x0600032D RID: 813 RVA: 0x0002FDE7 File Offset: 0x0002DFE7
	public static void DPwTKZ7HMwYN7gq8ega8BFo1i()
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.DxNefxtklJ0TtK0IHMa8HdxPs = 0;
		DqNh7bzS0xEILWgxFJA4tpJpp.DM7QlSs5TLbaVI0MEFveGJYvn.RemoveAt(DqNh7bzS0xEILWgxFJA4tpJpp.DM7QlSs5TLbaVI0MEFveGJYvn.Count - 1);
	}

	// Token: 0x0600032E RID: 814 RVA: 0x0002FE08 File Offset: 0x0002E008
	public static void DxfvUr8FIYs7I3DH41taceBRV(int elementsCount, int offset = 20)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += offset;
		bool flag = !DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
		bool flag2 = flag;
		if (flag2)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= offset;
		}
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR = true;
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DKmwvC6RNDVVeG8d69Pm5Fg4P = elementsCount;
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DopMKXLWJDd2q8dZ73XJtnV7j = -1;
	}

	// Token: 0x0600032F RID: 815 RVA: 0x0002FE6C File Offset: 0x0002E06C
	public static void DAgZVjM0prBEgI85dvDAtwQn3()
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR = false;
	}

	// Token: 0x06000330 RID: 816 RVA: 0x0002FE7C File Offset: 0x0002E07C
	public static void DgXmj38MRUJwixi7YN7t50iiF(string text)
	{
		int num = Mathf.CeilToInt(GUI.skin.label.CalcSize(new GUIContent(text)).x / (float)DqNh7bzS0xEILWgxFJA4tpJpp.width);
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += 18 * num;
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
		bool flag2 = flag;
		if (flag2)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DdCuDnb7ElWx1hjFEsHeKX9Cq = Dh63Hx4jopHoLEn3FiEdGB5JQ.Text;
			GUI.Label(new Rect((float)(DqNh7bzS0xEILWgxFJA4tpJpp.rectX + 2), DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - (float)(18 * num), (float)(DqNh7bzS0xEILWgxFJA4tpJpp.width - 4), (float)(14 * num)), text);
		}
		else
		{
			bool flag3 = !DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR;
			bool flag4 = flag3;
			if (flag4)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= 18 * num;
			}
		}
	}

	// Token: 0x06000331 RID: 817 RVA: 0x0002FF54 File Offset: 0x0002E154
	public static void DWo7hzuC3CixPrnuTe7gy3kA3(string text, string tooltip)
	{
		int num = Mathf.CeilToInt(GUI.skin.label.CalcSize(new GUIContent(text)).x / (float)DqNh7bzS0xEILWgxFJA4tpJpp.width);
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += 18 * num;
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
		bool flag2 = flag;
		if (flag2)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DdCuDnb7ElWx1hjFEsHeKX9Cq = Dh63Hx4jopHoLEn3FiEdGB5JQ.Text;
			Rect rect = new Rect((float)(DqNh7bzS0xEILWgxFJA4tpJpp.rectX + 2), DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - (float)(18 * num), (float)(DqNh7bzS0xEILWgxFJA4tpJpp.width - 4), (float)(14 * num));
			GUI.Label(rect, text);
			bool flag3 = rect.Contains(DqNh7bzS0xEILWgxFJA4tpJpp.Dc534n7jhQser4gBuy4Srd98f);
			bool flag4 = flag3;
			if (flag4)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.tooltips.Add(new ValueTuple<Rect, string>(new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y + 20f * GraphicsSettings.userInterfaceScale, 600f, 30f), tooltip));
			}
		}
		else
		{
			bool flag5 = !DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR;
			bool flag6 = flag5;
			if (flag6)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= 18 * num;
			}
		}
	}

	// Token: 0x06000332 RID: 818 RVA: 0x00030090 File Offset: 0x0002E290
	public static bool DFAkpq47gdavJUYRkR3I29anF(string text)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += (int)GUI.skin.button.fixedHeight + 4;
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
		bool flag2 = flag;
		bool flag3;
		if (flag2)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DdCuDnb7ElWx1hjFEsHeKX9Cq = Dh63Hx4jopHoLEn3FiEdGB5JQ.Button;
			flag3 = GUI.Button(new Rect((float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - GUI.skin.button.fixedHeight - 4f, (float)(DqNh7bzS0xEILWgxFJA4tpJpp.width - DqNh7bzS0xEILWgxFJA4tpJpp.padding), GUI.skin.button.fixedHeight), text);
		}
		else
		{
			bool flag4 = !DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR;
			bool flag5 = flag4;
			if (flag5)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= (int)GUI.skin.button.fixedHeight + 4;
			}
			flag3 = false;
		}
		return flag3;
	}

	// Token: 0x06000333 RID: 819 RVA: 0x00030180 File Offset: 0x0002E380
	public static bool D62KBAU6ZTPh57c5B8pkQnRrG(string text, string tooltip)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += (int)GUI.skin.button.fixedHeight + 4;
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
		bool flag2 = flag;
		bool flag5;
		if (flag2)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DdCuDnb7ElWx1hjFEsHeKX9Cq = Dh63Hx4jopHoLEn3FiEdGB5JQ.Button;
			Rect rect = new Rect((float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - GUI.skin.button.fixedHeight - 4f, (float)(DqNh7bzS0xEILWgxFJA4tpJpp.width - DqNh7bzS0xEILWgxFJA4tpJpp.padding), GUI.skin.button.fixedHeight);
			bool flag3 = rect.Contains(DqNh7bzS0xEILWgxFJA4tpJpp.Dc534n7jhQser4gBuy4Srd98f);
			bool flag4 = flag3;
			if (flag4)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.tooltips.Add(new ValueTuple<Rect, string>(new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y + 20f * GraphicsSettings.userInterfaceScale, 600f, 30f), tooltip));
			}
			flag5 = GUI.Button(rect, text);
		}
		else
		{
			bool flag6 = !DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR;
			bool flag7 = flag6;
			if (flag7)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= (int)GUI.skin.button.fixedHeight + 4;
			}
			flag5 = false;
		}
		return flag5;
	}

	// Token: 0x06000334 RID: 820 RVA: 0x000302D8 File Offset: 0x0002E4D8
	public static bool D07UMn2Hlrb8EUae71mq5Resn(string text, GUIStyle style)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += (int)style.fixedHeight + 8;
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
		bool flag2 = flag;
		bool flag3;
		if (flag2)
		{
			flag3 = GUI.Button(new Rect((float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - GUI.skin.button.fixedHeight - 8f, (float)(DqNh7bzS0xEILWgxFJA4tpJpp.width - DqNh7bzS0xEILWgxFJA4tpJpp.padding), GUI.skin.button.fixedHeight), text, style);
		}
		else
		{
			bool flag4 = !DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR;
			bool flag5 = flag4;
			if (flag5)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= (int)style.fixedHeight + 8;
			}
			flag3 = false;
		}
		return flag3;
	}

	// Token: 0x06000335 RID: 821 RVA: 0x000303AC File Offset: 0x0002E5AC
	public static void DdPz7R4rqMVxYUu02MjIYP9QM(int space)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += space;
		bool flag = !DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
		bool flag2 = flag;
		if (flag2)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= space;
		}
	}

	// Token: 0x06000336 RID: 822 RVA: 0x000303EF File Offset: 0x0002E5EF
	public static void DeYh3ocHoNm17vIFopPOwsXZf(int space)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.DxNefxtklJ0TtK0IHMa8HdxPs += space;
	}

	// Token: 0x06000337 RID: 823 RVA: 0x00030400 File Offset: 0x0002E600
	public static bool DlwMc0UCVjPOWI7FoW0ZmMlrk(bool variable, string text)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += (int)GUI.skin.toggle.fixedHeight + 4;
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
		bool flag2 = flag;
		bool flag5;
		if (flag2)
		{
			bool flag3 = DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DdCuDnb7ElWx1hjFEsHeKX9Cq == Dh63Hx4jopHoLEn3FiEdGB5JQ.Button;
			bool flag4 = flag3;
			if (flag4)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.DdPz7R4rqMVxYUu02MjIYP9QM(4);
			}
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DdCuDnb7ElWx1hjFEsHeKX9Cq = Dh63Hx4jopHoLEn3FiEdGB5JQ.Toggle;
			Rect rect = new Rect((float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - GUI.skin.toggle.fixedHeight - 4f, (float)(DqNh7bzS0xEILWgxFJA4tpJpp.width - DqNh7bzS0xEILWgxFJA4tpJpp.padding), GUI.skin.toggle.fixedHeight);
			flag5 = GUI.Toggle(rect, variable, text);
		}
		else
		{
			bool flag6 = !DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR;
			bool flag7 = flag6;
			if (flag7)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= (int)GUI.skin.toggle.fixedHeight + 4;
			}
			flag5 = variable;
		}
		return flag5;
	}

	// Token: 0x06000338 RID: 824 RVA: 0x00030518 File Offset: 0x0002E718
	public static bool DnYwEjN5Q0R0Fv6S5WiPKWTxX(bool variable, string text, GUIStyle style)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += (int)GUI.skin.toggle.fixedHeight + 4;
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
		bool flag2 = flag;
		bool flag5;
		if (flag2)
		{
			bool flag3 = DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DdCuDnb7ElWx1hjFEsHeKX9Cq == Dh63Hx4jopHoLEn3FiEdGB5JQ.Button;
			bool flag4 = flag3;
			if (flag4)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.DdPz7R4rqMVxYUu02MjIYP9QM(4);
			}
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DdCuDnb7ElWx1hjFEsHeKX9Cq = Dh63Hx4jopHoLEn3FiEdGB5JQ.Toggle;
			Rect rect = new Rect((float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - GUI.skin.toggle.fixedHeight - 4f, (float)(DqNh7bzS0xEILWgxFJA4tpJpp.width - DqNh7bzS0xEILWgxFJA4tpJpp.padding), GUI.skin.toggle.fixedHeight);
			flag5 = GUI.Toggle(rect, variable, text, style);
		}
		else
		{
			bool flag6 = !DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR;
			bool flag7 = flag6;
			if (flag7)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= (int)GUI.skin.toggle.fixedHeight + 4;
			}
			flag5 = variable;
		}
		return flag5;
	}

	// Token: 0x06000339 RID: 825 RVA: 0x00030630 File Offset: 0x0002E830
	public static bool Dq0InBE1bzmFZxW4JsLMBtL2i(bool variable, string text, string tooltip)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += (int)GUI.skin.toggle.fixedHeight + 4;
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
		bool flag2 = flag;
		bool flag7;
		if (flag2)
		{
			bool flag3 = DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DdCuDnb7ElWx1hjFEsHeKX9Cq == Dh63Hx4jopHoLEn3FiEdGB5JQ.Button;
			bool flag4 = flag3;
			if (flag4)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.DdPz7R4rqMVxYUu02MjIYP9QM(4);
			}
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DdCuDnb7ElWx1hjFEsHeKX9Cq = Dh63Hx4jopHoLEn3FiEdGB5JQ.Toggle;
			Rect rect = new Rect((float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - GUI.skin.toggle.fixedHeight - 4f, (float)(DqNh7bzS0xEILWgxFJA4tpJpp.width - DqNh7bzS0xEILWgxFJA4tpJpp.padding), GUI.skin.toggle.fixedHeight);
			bool flag5 = rect.Contains(DqNh7bzS0xEILWgxFJA4tpJpp.Dc534n7jhQser4gBuy4Srd98f);
			bool flag6 = flag5;
			if (flag6)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.tooltips.Add(new ValueTuple<Rect, string>(new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y + 20f * GraphicsSettings.userInterfaceScale, 600f, 30f), tooltip));
			}
			flag7 = GUI.Toggle(rect, variable, text);
		}
		else
		{
			bool flag8 = !DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR;
			bool flag9 = flag8;
			if (flag9)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= (int)GUI.skin.toggle.fixedHeight + 4;
			}
			flag7 = variable;
		}
		return flag7;
	}

	// Token: 0x0600033A RID: 826 RVA: 0x000307A8 File Offset: 0x0002E9A8
	public static void DQXFOnbg0GOMla0jegOsR2odk(Texture2D texture, int width = -1, int height = 100)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += height + 4;
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
		bool flag2 = flag;
		if (flag2)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DdCuDnb7ElWx1hjFEsHeKX9Cq = Dh63Hx4jopHoLEn3FiEdGB5JQ.Box;
			bool flag3 = texture != null;
			bool flag4 = flag3;
			if (flag4)
			{
				GUI.DrawTexture(new Rect((float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - (float)(height + 4), (float)((width == -1) ? DqNh7bzS0xEILWgxFJA4tpJpp.width : width), (float)height), texture, ScaleMode.ScaleToFit);
			}
		}
		else
		{
			bool flag5 = !DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR;
			bool flag6 = flag5;
			if (flag6)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= height + 4;
			}
		}
	}

	// Token: 0x0600033B RID: 827 RVA: 0x00030868 File Offset: 0x0002EA68
	public static void D5TZm3XaifwCJ60CfYsgMYNMn(string text, int height = 14)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += height + 4;
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
		bool flag2 = flag;
		if (flag2)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DdCuDnb7ElWx1hjFEsHeKX9Cq = Dh63Hx4jopHoLEn3FiEdGB5JQ.Box;
			GUI.Box(new Rect((float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - (float)(height + 4), (float)DqNh7bzS0xEILWgxFJA4tpJpp.width, (float)height), text, GUI.skin.customStyles[0]);
		}
		else
		{
			bool flag3 = !DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR;
			bool flag4 = flag3;
			if (flag4)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= height + 4;
			}
		}
	}

	// Token: 0x0600033C RID: 828 RVA: 0x00030918 File Offset: 0x0002EB18
	public static float DaIL6XMZTDvtJWD6QLy7YAzSG(float value, float minValue, float maxValue)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += (int)GUI.skin.horizontalSlider.fixedHeight + 4;
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
		bool flag2 = flag;
		float num;
		if (flag2)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DdCuDnb7ElWx1hjFEsHeKX9Cq = Dh63Hx4jopHoLEn3FiEdGB5JQ.InputField;
			num = GUI.HorizontalSlider(new Rect((float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - GUI.skin.horizontalSlider.fixedHeight - 4f, (float)(DqNh7bzS0xEILWgxFJA4tpJpp.width - DqNh7bzS0xEILWgxFJA4tpJpp.padding - DqNh7bzS0xEILWgxFJA4tpJpp.DxNefxtklJ0TtK0IHMa8HdxPs), GUI.skin.horizontalSlider.fixedHeight), value, minValue, maxValue);
		}
		else
		{
			bool flag3 = !DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR;
			bool flag4 = flag3;
			if (flag4)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= (int)GUI.skin.horizontalSlider.fixedHeight + 4;
			}
			num = value;
		}
		return num;
	}

	// Token: 0x0600033D RID: 829 RVA: 0x00030A10 File Offset: 0x0002EC10
	public static bool DZjPwdrThVe0YGYIIXGJHRKMQ()
	{
		return DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll == null || (DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.D3sS6k0EkNDcAlJMaCKxD68b9 <= DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.Dqg0gTrHrYba94A1TWNNth964 + DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.DipSuAvkvl7C1QdK4Q9PopnFi && DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.Dqg0gTrHrYba94A1TWNNth964 < DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.D3sS6k0EkNDcAlJMaCKxD68b9 - DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.Dhgb79hu05nyUCa2FetmY3j7o / 2 - 1);
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00030A78 File Offset: 0x0002EC78
	public static string DA0xO1x0ojIH3QqDbi5vOJWc5(string text)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += (int)GUI.skin.textField.fixedHeight + 4;
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
		bool flag2 = flag;
		string text2;
		if (flag2)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DdCuDnb7ElWx1hjFEsHeKX9Cq = Dh63Hx4jopHoLEn3FiEdGB5JQ.InputField;
			text2 = GUI.TextField(new Rect((float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - GUI.skin.textField.fixedHeight - 4f, (float)(DqNh7bzS0xEILWgxFJA4tpJpp.width - DqNh7bzS0xEILWgxFJA4tpJpp.padding), GUI.skin.textField.fixedHeight), text);
		}
		else
		{
			bool flag3 = !DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DhMRJNZeRavE6LVktl4SUercR;
			bool flag4 = flag3;
			if (flag4)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= (int)GUI.skin.textField.fixedHeight + 4;
			}
			text2 = text;
		}
		return text2;
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00030B68 File Offset: 0x0002ED68
	public static float DL1L0GILOmnQk7ezgGyckxA9j(float val)
	{
		bool flag = val % 1f != 0f;
		return float.Parse(DqNh7bzS0xEILWgxFJA4tpJpp.DA0xO1x0ojIH3QqDbi5vOJWc5(val.ToString() + (flag ? "" : ",0")));
	}

	// Token: 0x06000340 RID: 832 RVA: 0x00030BB4 File Offset: 0x0002EDB4
	public static int DWdt7Ltu3wEzT6UoQkzoNOhoU(int val)
	{
		return int.Parse(DqNh7bzS0xEILWgxFJA4tpJpp.DA0xO1x0ojIH3QqDbi5vOJWc5(val.ToString()));
	}

	// Token: 0x06000341 RID: 833 RVA: 0x00030BD8 File Offset: 0x0002EDD8
	public static int D0BAZwdOrNmEbVv857U4LspBq(Rect rect, int value, int minValue, int maxValue)
	{
		return DqNh7bzS0xEILWgxFJA4tpJpp.D7pJNxcJxb4n0yEttNbIRi4jL(rect, rect, value, minValue, maxValue);
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00030BF4 File Offset: 0x0002EDF4
	public static int D7pJNxcJxb4n0yEttNbIRi4jL(Rect rect, Rect scrollViewport, int value, int minValue, int maxValue)
	{
		int num = value;
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect, new Color32(50, 50, 52, byte.MaxValue), true, ScaleMode.StretchToFill);
		int num2 = (int)((float)num * ((rect.height - 44f) / (float)(maxValue - minValue)));
		Rect rect2 = new Rect(rect.x + 2f, rect.y + 2f + (float)num2, rect.width - 4f, 40f);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect2, DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Menu lines color"), true, ScaleMode.StretchToFill);
		bool flag = !Input.GetMouseButton(0) || Input.GetMouseButtonUp(0);
		bool flag2 = flag;
		if (flag2)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.DXKFLHdv1skoR3IxXjoiTvZri = false;
		}
		bool flag3 = Input.GetMouseButtonDown(0) && rect2.Contains(DqNh7bzS0xEILWgxFJA4tpJpp.Dc534n7jhQser4gBuy4Srd98f);
		bool flag4 = flag3;
		if (flag4)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.DXKFLHdv1skoR3IxXjoiTvZri = true;
			DqNh7bzS0xEILWgxFJA4tpJpp.DfmDv7KbKO6gM1xgKPzw4n20I = rect;
		}
		bool flag5 = DqNh7bzS0xEILWgxFJA4tpJpp.DXKFLHdv1skoR3IxXjoiTvZri && rect == DqNh7bzS0xEILWgxFJA4tpJpp.DfmDv7KbKO6gM1xgKPzw4n20I;
		bool flag6 = flag5;
		if (flag6)
		{
			float num3 = DqNh7bzS0xEILWgxFJA4tpJpp.Dc534n7jhQser4gBuy4Srd98f.y - ((float)Screen.height - Input.mousePosition.y);
			float num4 = rect.height - rect2.height - 4f;
			float num5 = (float)(maxValue - minValue);
			float num6 = num3 / num4;
			float num7 = num6 * num5;
			num -= Mathf.RoundToInt(num7);
		}
		bool flag7 = Input.mouseScrollDelta.y != 0f && scrollViewport.Contains(DqNh7bzS0xEILWgxFJA4tpJpp.Dc534n7jhQser4gBuy4Srd98f);
		bool flag8 = flag7;
		if (flag8)
		{
			num -= (int)(Input.mouseScrollDelta.y * 8f);
		}
		return Mathf.Clamp(num, minValue, maxValue);
	}

	// Token: 0x06000343 RID: 835 RVA: 0x00030D98 File Offset: 0x0002EF98
	public static void DyBn18hxKzKkq5aDAdvau4Wv2(Vector2 scrollPosition)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DaBMP7BYA2NHNjSWxFpQH3eRz.Add(new DVQma6Vck8PRIpG0GaJcWvaRC((int)scrollPosition.y, (int)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.height - DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset, (int)scrollPosition.x));
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00030DF0 File Offset: 0x0002EFF0
	public static Vector2 De6903YEzOzl7pEaVTq3q7dnf()
	{
		int num = ((DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.D3sS6k0EkNDcAlJMaCKxD68b9 > DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.DipSuAvkvl7C1QdK4Q9PopnFi) ? DqNh7bzS0xEILWgxFJA4tpJpp.D7pJNxcJxb4n0yEttNbIRi4jL(new Rect((float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX + DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.width - 16f, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.DEitp5ATGEnThpvanflvVTdDz, 16f, (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.DipSuAvkvl7C1QdK4Q9PopnFi), new Rect((float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.DEitp5ATGEnThpvanflvVTdDz, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.width, (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.DipSuAvkvl7C1QdK4Q9PopnFi), DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.Dqg0gTrHrYba94A1TWNNth964, 0, DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.D3sS6k0EkNDcAlJMaCKxD68b9 - DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.DipSuAvkvl7C1QdK4Q9PopnFi) : 0);
		int d3sS6k0EkNDcAlJMaCKxD68b = DqNh7bzS0xEILWgxFJA4tpJpp.currentScroll.D3sS6k0EkNDcAlJMaCKxD68b9;
		DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DaBMP7BYA2NHNjSWxFpQH3eRz.RemoveAt(DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.DaBMP7BYA2NHNjSWxFpQH3eRz.Count - 1);
		return new Vector2((float)d3sS6k0EkNDcAlJMaCKxD68b, (float)num);
	}

	// Token: 0x06000345 RID: 837 RVA: 0x00030F08 File Offset: 0x0002F108
	public static void Update()
	{
		int depth = GUI.depth;
		GUI.depth = -1000;
		foreach (ValueTuple<Rect, string> valueTuple in DqNh7bzS0xEILWgxFJA4tpJpp.tooltips)
		{
			GUI.Label(valueTuple.Item1, valueTuple.Item2);
		}
		GUI.depth = depth;
		DqNh7bzS0xEILWgxFJA4tpJpp.tooltips.Clear();
		DqNh7bzS0xEILWgxFJA4tpJpp.Dc534n7jhQser4gBuy4Srd98f = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
	}

	// Token: 0x0400038D RID: 909
	public static List<DaDJKEXuXXWelEjFIsFjrqq81> DM7QlSs5TLbaVI0MEFveGJYvn = new List<DaDJKEXuXXWelEjFIsFjrqq81>();

	// Token: 0x0400038E RID: 910
	public static List<ValueTuple<Rect, string>> tooltips = new List<ValueTuple<Rect, string>>();

	// Token: 0x0400038F RID: 911
	public static bool DXKFLHdv1skoR3IxXjoiTvZri = false;

	// Token: 0x04000390 RID: 912
	public static Rect DfmDv7KbKO6gM1xgKPzw4n20I;

	// Token: 0x04000391 RID: 913
	public static Vector2 Dc534n7jhQser4gBuy4Srd98f;

	// Token: 0x04000392 RID: 914
	public static int DxNefxtklJ0TtK0IHMa8HdxPs = 0;
}
