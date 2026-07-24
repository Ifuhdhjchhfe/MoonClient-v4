using System;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000084 RID: 132
public class DLNqAn9XdXD1cnazIVx491ZPQ
{
	// Token: 0x06000274 RID: 628 RVA: 0x000253B0 File Offset: 0x000235B0
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(LevelLighting), "updateLighting", new Type[] { })]
	public static void DP11Iz5aPrKYIU0eQRQ5M5MDF()
	{
		DLNqAn9XdXD1cnazIVx491ZPQ.DcFDZFRss61TGlOGzNB0vMEjU = LevelLighting.time;
		bool flag = D5l46jlssr4TRAzUSXzLj0uqu.customDayTime && !DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6;
		bool flag2 = flag;
		if (flag2)
		{
			DLNqAn9XdXD1cnazIVx491ZPQ.DkDIOYoMyC8Phf3ve8HzewBdw.Set(D5l46jlssr4TRAzUSXzLj0uqu.customTime);
		}
		DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(null, Array.Empty<object>());
		bool flag3 = D5l46jlssr4TRAzUSXzLj0uqu.customDayTime && !DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6;
		bool flag4 = flag3;
		if (flag4)
		{
			DLNqAn9XdXD1cnazIVx491ZPQ.DkDIOYoMyC8Phf3ve8HzewBdw.Set(DLNqAn9XdXD1cnazIVx491ZPQ.DcFDZFRss61TGlOGzNB0vMEjU);
		}
		DLNqAn9XdXD1cnazIVx491ZPQ.DHwF8PgjRdgw80nkVgZVxD9YB.RefereshFieldValue();
		bool dbjv74arVJtUMAqsSN0cWr9w = DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6;
		bool flag5 = dbjv74arVJtUMAqsSN0cWr9w;
		if (flag5)
		{
			DLNqAn9XdXD1cnazIVx491ZPQ.DFMxKLhMhmo4WqDXJsHRcVCTH.D8bo6z6P4C0fkdfFioOF82Ftk(Array.Empty<object>());
		}
		else
		{
			bool overrideSkyColor = D5l46jlssr4TRAzUSXzLj0uqu.overrideSkyColor;
			bool flag6 = overrideSkyColor;
			if (flag6)
			{
				DLNqAn9XdXD1cnazIVx491ZPQ.DHwF8PgjRdgw80nkVgZVxD9YB.fldValue.SetColor("_SkyColor", DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Custom Sky Color"));
			}
			else
			{
				DLNqAn9XdXD1cnazIVx491ZPQ.DFMxKLhMhmo4WqDXJsHRcVCTH.D8bo6z6P4C0fkdfFioOF82Ftk(Array.Empty<object>());
			}
			bool overrideSunColor = D5l46jlssr4TRAzUSXzLj0uqu.overrideSunColor;
			bool flag7 = overrideSunColor;
			if (flag7)
			{
				DLNqAn9XdXD1cnazIVx491ZPQ.DHwF8PgjRdgw80nkVgZVxD9YB.fldValue.SetColor("_SunColor", DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Custom Sun Color"));
			}
			bool overrideCloudsColor = D5l46jlssr4TRAzUSXzLj0uqu.overrideCloudsColor;
			bool flag8 = overrideCloudsColor;
			if (flag8)
			{
				DLNqAn9XdXD1cnazIVx491ZPQ.DHwF8PgjRdgw80nkVgZVxD9YB.fldValue.SetColor("_CloudColor", DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Custom Clouds"));
			}
			bool overrideCloudsRimColor = D5l46jlssr4TRAzUSXzLj0uqu.overrideCloudsRimColor;
			bool flag9 = overrideCloudsRimColor;
			if (flag9)
			{
				DLNqAn9XdXD1cnazIVx491ZPQ.DHwF8PgjRdgw80nkVgZVxD9YB.fldValue.SetColor("_CloudRimColor", DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Custom Clouds Rim"));
			}
		}
	}

	// Token: 0x0400030B RID: 779
	public static float DcFDZFRss61TGlOGzNB0vMEjU = 1200f;

	// Token: 0x0400030C RID: 780
	public static DGZv08vQyz81zrHxUqhmYuCdY<float> DkDIOYoMyC8Phf3ve8HzewBdw = new DGZv08vQyz81zrHxUqhmYuCdY<float>(typeof(LevelLighting), "_time", BindingFlags.Static | BindingFlags.NonPublic);

	// Token: 0x0400030D RID: 781
	public static DGZv08vQyz81zrHxUqhmYuCdY<Material> DHwF8PgjRdgw80nkVgZVxD9YB = new DGZv08vQyz81zrHxUqhmYuCdY<Material>(typeof(LevelLighting), "skybox", BindingFlags.Static | BindingFlags.NonPublic);

	// Token: 0x0400030E RID: 782
	public static DQyA1nzDa0rZuYtgcLmIWOUf8 DFMxKLhMhmo4WqDXJsHRcVCTH = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(LevelLighting), "updateSkyboxColors", BindingFlags.Static | BindingFlags.NonPublic);
}
