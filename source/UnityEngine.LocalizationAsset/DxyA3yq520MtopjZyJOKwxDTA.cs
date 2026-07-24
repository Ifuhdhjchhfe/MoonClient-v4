using System;

// Token: 0x020000D4 RID: 212
public class DxyA3yq520MtopjZyJOKwxDTA : DybM0vc9ssOBM9irEDd2jwWNG
{
	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000403 RID: 1027 RVA: 0x0003D37C File Offset: 0x0003B57C
	// (set) Token: 0x06000404 RID: 1028 RVA: 0x0003D399 File Offset: 0x0003B599
	public int option
	{
		get
		{
			return (int)this.DInHPFtxebvVx7sh7DNy96Mrp;
		}
		set
		{
			this.DInHPFtxebvVx7sh7DNy96Mrp = value;
		}
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x0003D3A8 File Offset: 0x0003B5A8
	public DxyA3yq520MtopjZyJOKwxDTA(int defaultValue, int minValue, int maxValue, string optionName)
	{
		this.option = defaultValue;
		this.DNvP3fLRcPGd2usFCyxdtvjVp = optionName;
		this.DGNJ4SrA1SyTS7v10BMA0V3nm = minValue;
		this.D4aPgMU8cpEJlAKm0IbFWiMJR = maxValue;
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x0003D3D0 File Offset: 0x0003B5D0
	public override void Serialize(DTQTgBvjhehJ9nKOGQCJPsaGO writer)
	{
		writer.DwTWdG1zkzaGlxDGRH2ahyh0C(this.option);
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x0003D3E0 File Offset: 0x0003B5E0
	public override void Deserialize(DUt0a6FCClF9uncpHt4baoWwu reader)
	{
		this.option = reader.D4A9IMafSh9GwdPdbI0EZOAxx();
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x0003D3F0 File Offset: 0x0003B5F0
	public override void DisplayOption()
	{
		this.option = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr(this.DNvP3fLRcPGd2usFCyxdtvjVp + ": ", this.option, this.DGNJ4SrA1SyTS7v10BMA0V3nm, this.D4aPgMU8cpEJlAKm0IbFWiMJR, -1);
	}

	// Token: 0x04000452 RID: 1106
	public int DGNJ4SrA1SyTS7v10BMA0V3nm;

	// Token: 0x04000453 RID: 1107
	public int D4aPgMU8cpEJlAKm0IbFWiMJR;

	// Token: 0x04000454 RID: 1108
	public string DNvP3fLRcPGd2usFCyxdtvjVp;
}
