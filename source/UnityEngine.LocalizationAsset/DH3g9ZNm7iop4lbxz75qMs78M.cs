using System;
using UnityEngine;

// Token: 0x02000064 RID: 100
public class DH3g9ZNm7iop4lbxz75qMs78M : DSvAEyoSitLrXzsZSSRwWfJ5T
{
	// Token: 0x060001E2 RID: 482 RVA: 0x00018D3C File Offset: 0x00016F3C
	public bool D4zexObjNPAFqNcuq51rIIJ98()
	{
		return Mathf.Approximately((float)Screen.width / (float)Screen.height, 1.3333334f);
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x00018D68 File Offset: 0x00016F68
	public override bool GetAviablity()
	{
		return D5l46jlssr4TRAzUSXzLj0uqu.notifyAboutSpy && Time.realtimeSinceStartup - DI4RfMJ7ziJuscMZZoy2MIzrV.DSg3kbDAJsc0hSCt25O0Jas3q < 5f;
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x00018D98 File Offset: 0x00016F98
	public override bool IsShowOnMenu()
	{
		return false;
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x00018DAC File Offset: 0x00016FAC
	public override bool UseStaticRect()
	{
		return true;
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x00018DC0 File Offset: 0x00016FC0
	public override Vector2 GetSize()
	{
		return this.D4zexObjNPAFqNcuq51rIIJ98() ? new Vector2((float)D5l46jlssr4TRAzUSXzLj0uqu.spyWindowSize, (float)D5l46jlssr4TRAzUSXzLj0uqu.spyWindowSize * 0.75f + 18f) : new Vector2((float)D5l46jlssr4TRAzUSXzLj0uqu.spyWindowSize * 1.6f, (float)D5l46jlssr4TRAzUSXzLj0uqu.spyWindowSize * 0.9f + 18f);
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x00018E1C File Offset: 0x0001701C
	public override Rect GetStaticRect()
	{
		Vector2 size = this.GetSize();
		return new Rect((float)(Screen.width - 20) - size.x, 20f, size.x, size.y);
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00018E5C File Offset: 0x0001705C
	public override void DrawWindow()
	{
		Vector2 size = this.GetSize();
		bool flag = DI4RfMJ7ziJuscMZZoy2MIzrV.DIhV7K2mHRLxB8hrKabx7EYI9 != null;
		bool flag2 = flag;
		if (flag2)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.DQXFOnbg0GOMla0jegOsR2odk(DI4RfMJ7ziJuscMZZoy2MIzrV.DIhV7K2mHRLxB8hrKabx7EYI9, (int)(size.x - 4f), (int)(size.y - 22f));
		}
		DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("[WARNING] You have been spied by a server admin");
	}
}
