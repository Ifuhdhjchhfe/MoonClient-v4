using System;
using UnityEngine;

// Token: 0x0200003D RID: 61
public class DchD7fh9x8frGDtOrmOVUvh5N : DybM0vc9ssOBM9irEDd2jwWNG
{
	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000103 RID: 259 RVA: 0x0000B654 File Offset: 0x00009854
	// (set) Token: 0x06000104 RID: 260 RVA: 0x0000B671 File Offset: 0x00009871
	public string option
	{
		get
		{
			return (string)this.DInHPFtxebvVx7sh7DNy96Mrp;
		}
		set
		{
			this.DInHPFtxebvVx7sh7DNy96Mrp = value;
		}
	}

	// Token: 0x06000105 RID: 261 RVA: 0x0000B67B File Offset: 0x0000987B
	public DchD7fh9x8frGDtOrmOVUvh5N(string option, string optionName)
	{
		this.option = option;
		this.DAyoRLOLCFbhVSgvpwpWQ4nbp = optionName;
	}

	// Token: 0x06000106 RID: 262 RVA: 0x0000B694 File Offset: 0x00009894
	public override void Serialize(DTQTgBvjhehJ9nKOGQCJPsaGO writer)
	{
		writer.DGDUglHFhs4KI2tPvrxsuSjzz(this.option);
	}

	// Token: 0x06000107 RID: 263 RVA: 0x0000B6A4 File Offset: 0x000098A4
	public override void Deserialize(DUt0a6FCClF9uncpHt4baoWwu reader)
	{
		this.option = reader.DwZMJgiflLxDLkLNV8ljFfb8p();
	}

	// Token: 0x06000108 RID: 264 RVA: 0x0000B6B4 File Offset: 0x000098B4
	public override void DisplayOption()
	{
		GUILayout.Label(this.DAyoRLOLCFbhVSgvpwpWQ4nbp + ": ", Array.Empty<GUILayoutOption>());
		this.option = GUILayout.TextField(this.option, Array.Empty<GUILayoutOption>());
	}

	// Token: 0x04000136 RID: 310
	public string DAyoRLOLCFbhVSgvpwpWQ4nbp;
}
