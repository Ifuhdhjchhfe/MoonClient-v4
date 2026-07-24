using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000C0 RID: 192
public class Dv3KaYixxs2GhAcLsyVSVCD48 : DybM0vc9ssOBM9irEDd2jwWNG
{
	// Token: 0x060003D2 RID: 978 RVA: 0x0003806C File Offset: 0x0003626C
	public Dv3KaYixxs2GhAcLsyVSVCD48()
	{
		this.DInHPFtxebvVx7sh7DNy96Mrp = new Dx0mI3VF7tws4aOTlUQV9RnyL();
		Dx0mI3VF7tws4aOTlUQV9RnyL dx0mI3VF7tws4aOTlUQV9RnyL = this.DInHPFtxebvVx7sh7DNy96Mrp as Dx0mI3VF7tws4aOTlUQV9RnyL;
		dx0mI3VF7tws4aOTlUQV9RnyL.DkcopsW2kYlTkNiHyikzClfPi = false;
		dx0mI3VF7tws4aOTlUQV9RnyL.DKvz06YBIXby4bzyzQBesuZZf = false;
		dx0mI3VF7tws4aOTlUQV9RnyL.DRmsWPTdgvBqovH0bGUwaAaU8 = false;
		dx0mI3VF7tws4aOTlUQV9RnyL.DkzMi11T0w2UxOfkt0ojQjo5Z = new Dictionary<ushort, DDB8pIlWKKbHkw2jCuyAPcvL7>();
		dx0mI3VF7tws4aOTlUQV9RnyL.DZiJVLx1YOES6umDzig25wx8J = new List<Type>();
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00016AB7 File Offset: 0x00014CB7
	public override void Serialize(DTQTgBvjhehJ9nKOGQCJPsaGO writer)
	{
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00016AB7 File Offset: 0x00014CB7
	public override void Deserialize(DUt0a6FCClF9uncpHt4baoWwu reader)
	{
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x000380C4 File Offset: 0x000362C4
	public override void DisplayOption()
	{
		Dx0mI3VF7tws4aOTlUQV9RnyL dx0mI3VF7tws4aOTlUQV9RnyL = this.DInHPFtxebvVx7sh7DNy96Mrp as Dx0mI3VF7tws4aOTlUQV9RnyL;
		dx0mI3VF7tws4aOTlUQV9RnyL.DkcopsW2kYlTkNiHyikzClfPi = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(dx0mI3VF7tws4aOTlUQV9RnyL.DkcopsW2kYlTkNiHyikzClfPi, "Sort items", Array.Empty<GUILayoutOption>());
		bool dkcopsW2kYlTkNiHyikzClfPi = dx0mI3VF7tws4aOTlUQV9RnyL.DkcopsW2kYlTkNiHyikzClfPi;
		bool flag = dkcopsW2kYlTkNiHyikzClfPi;
		if (flag)
		{
			dx0mI3VF7tws4aOTlUQV9RnyL.DKvz06YBIXby4bzyzQBesuZZf = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(dx0mI3VF7tws4aOTlUQV9RnyL.DKvz06YBIXby4bzyzQBesuZZf, "Is blacklist", Array.Empty<GUILayoutOption>());
			try
			{
				foreach (DDB8pIlWKKbHkw2jCuyAPcvL7 ddb8pIlWKKbHkw2jCuyAPcvL in dx0mI3VF7tws4aOTlUQV9RnyL.DkzMi11T0w2UxOfkt0ojQjo5Z.Values)
				{
					bool flag2 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv(ddb8pIlWKKbHkw2jCuyAPcvL.DjHtc6kil0ZuGKFFgQKYQvYK2, -1, true, null);
					bool flag3 = flag2;
					if (flag3)
					{
						DHKOlhPS98QOeYArRzpLwTeId.DvS0AYUQBKzcCD2W8lZEgSZ6k(ddb8pIlWKKbHkw2jCuyAPcvL.Dn06Kjd8jxL0Tj2Vfupj8Skcq);
					}
				}
			}
			catch
			{
			}
		}
		bool flag4 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Manage sort items", -1, true, null);
		bool flag5 = flag4;
		if (flag5)
		{
			DYMz7RDPFveX28vGc5VCgHkct.isActive = !DYMz7RDPFveX28vGc5VCgHkct.isActive;
		}
	}
}
