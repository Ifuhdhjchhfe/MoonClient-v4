using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000B7 RID: 183
public class DSvAEyoSitLrXzsZSSRwWfJ5T
{
	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000391 RID: 913 RVA: 0x00036FA0 File Offset: 0x000351A0
	// (set) Token: 0x06000392 RID: 914 RVA: 0x00036FF1 File Offset: 0x000351F1
	public Vector2 windowRect
	{
		get
		{
			bool flag = this.UseStaticRect();
			bool flag2 = flag;
			Vector2 dkPiBrZfDuyssgVsFrnhxjO4v;
			if (flag2)
			{
				dkPiBrZfDuyssgVsFrnhxjO4v = new Vector2(this.GetStaticRect().x, this.GetStaticRect().y);
			}
			else
			{
				dkPiBrZfDuyssgVsFrnhxjO4v = this.DkPiBrZfDuyssgVsFrnhxjO4v;
			}
			return dkPiBrZfDuyssgVsFrnhxjO4v;
		}
		set
		{
			this.DkPiBrZfDuyssgVsFrnhxjO4v = value;
		}
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00036FFC File Offset: 0x000351FC
	public virtual Vector2 GetSize()
	{
		return new Vector2(100f, 100f);
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00037020 File Offset: 0x00035220
	public virtual Rect GetStaticRect()
	{
		return new Rect(0f, 0f, 100f, 100f);
	}

	// Token: 0x06000395 RID: 917 RVA: 0x0003704C File Offset: 0x0003524C
	public virtual bool UseStaticRect()
	{
		return false;
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00037060 File Offset: 0x00035260
	public virtual bool IsShowOnMenu()
	{
		return false;
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00037074 File Offset: 0x00035274
	public virtual bool GetAviablity()
	{
		return true;
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00037087 File Offset: 0x00035287
	public void DZxuXSmWDxed28SbJ8XfD3yXH(string text)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.D5TZm3XaifwCJ60CfYsgMYNMn(text, 14);
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00037094 File Offset: 0x00035294
	public void DTmNRoF1ji0C0gfIHdFoVPeKs()
	{
		GUI.color = (this.IsShowOnMenu() ? DL3tNdrQzY7o8FV1oIOKODOLQ.DhTK8vExKCigxPaJEUNom8G8Y() : DL3tNdrQzY7o8FV1oIOKODOLQ.DWZMLhXYOrreM11KKl2Yrzbdr());
		Color color = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Menu background color");
		Color32 color2 = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Menu line color");
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(this.windowRect.x, this.windowRect.y, this.GetSize().x, this.GetSize().y), color, this.IsShowOnMenu(), ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(this.windowRect.x, this.windowRect.y, this.GetSize().x, 1f), color2, this.IsShowOnMenu(), ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(this.windowRect.x, this.windowRect.y + this.GetSize().y - 1f, this.GetSize().x, 1f), color2, this.IsShowOnMenu(), ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(this.windowRect.x, this.windowRect.y, 1f, this.GetSize().y), color2, this.IsShowOnMenu(), ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(this.windowRect.x + this.GetSize().x - 1f, this.windowRect.y, 1f, this.GetSize().y), color2, this.IsShowOnMenu(), ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(this.windowRect.x, this.windowRect.y, this.GetSize().x, 22f), new Color32(18, 18, 20, byte.MaxValue), this.IsShowOnMenu(), ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(this.windowRect.x, this.windowRect.y + 22f, this.GetSize().x, 1f), color2, this.IsShowOnMenu(), ScaleMode.StretchToFill);
		DqNh7bzS0xEILWgxFJA4tpJpp.D0N2vkljxxCW0Fn0PI1WVCCTj(new Rect(this.windowRect.x + 2f, this.windowRect.y + 2f, this.GetSize().x - 4f, this.GetSize().y - 4f));
		this.DrawWindow();
		DqNh7bzS0xEILWgxFJA4tpJpp.DPwTKZ7HMwYN7gq8ega8BFo1i();
		bool flag = new Rect(this.windowRect.x, this.windowRect.y, this.GetSize().x, this.GetSize().y).Contains(new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y));
		bool flag2 = flag;
		if (flag2)
		{
			Rect rect = new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, 20f * GraphicsSettings.userInterfaceScale, 20f * GraphicsSettings.userInterfaceScale);
			GUI.DrawTexture(rect, DHTB5RKsHUihFrfj9ewuLh1f9.DJ5ccrBkXzthVBZKvdtf0TbaS);
		}
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00016AB7 File Offset: 0x00014CB7
	public virtual void DrawWindow()
	{
	}

	// Token: 0x040003DD RID: 989
	public Vector2 DkPiBrZfDuyssgVsFrnhxjO4v = new Vector2(100f, 100f);
}
