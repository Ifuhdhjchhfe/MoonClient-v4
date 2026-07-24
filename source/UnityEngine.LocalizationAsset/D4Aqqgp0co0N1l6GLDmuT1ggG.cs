using System;
using UnityEngine;

// Token: 0x02000017 RID: 23
public class D4Aqqgp0co0N1l6GLDmuT1ggG : DybM0vc9ssOBM9irEDd2jwWNG
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000062 RID: 98 RVA: 0x00005CA8 File Offset: 0x00003EA8
	// (set) Token: 0x06000063 RID: 99 RVA: 0x00005CC5 File Offset: 0x00003EC5
	public bool option
	{
		get
		{
			return (bool)this.DInHPFtxebvVx7sh7DNy96Mrp;
		}
		set
		{
			this.DInHPFtxebvVx7sh7DNy96Mrp = value;
		}
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00005CD4 File Offset: 0x00003ED4
	public D4Aqqgp0co0N1l6GLDmuT1ggG(bool option, string optionName)
	{
		this.option = option;
		this.D91rDYarnT8c8JrOzD0hAuP1S = optionName;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00005CED File Offset: 0x00003EED
	public override void Serialize(DTQTgBvjhehJ9nKOGQCJPsaGO writer)
	{
		writer.DzjcnttV9066oi9WNYph9lY9r(this.option);
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00005CFD File Offset: 0x00003EFD
	public override void Deserialize(DUt0a6FCClF9uncpHt4baoWwu reader)
	{
		this.option = reader.DugoucznVJ1iWS8iior9p4Yvb();
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00005D0D File Offset: 0x00003F0D
	public override void DisplayOption()
	{
		this.option = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(this.option, this.D91rDYarnT8c8JrOzD0hAuP1S, Array.Empty<GUILayoutOption>());
	}

	// Token: 0x0400003D RID: 61
	public string D91rDYarnT8c8JrOzD0hAuP1S;
}
