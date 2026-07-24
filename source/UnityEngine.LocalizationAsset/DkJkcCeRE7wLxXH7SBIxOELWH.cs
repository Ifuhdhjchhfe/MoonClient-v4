using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200007B RID: 123
public static class DkJkcCeRE7wLxXH7SBIxOELWH
{
	// Token: 0x06000252 RID: 594 RVA: 0x00020EF0 File Offset: 0x0001F0F0
	public static void Dbsf0OgPcC5otCEri3n5DsC2O()
	{
		bool drawHorizontalInfoPanel = DfU4wrswBK5kLyiyV6mHZwOg8.drawHorizontalInfoPanel;
		if (drawHorizontalInfoPanel)
		{
			DkJkcCeRE7wLxXH7SBIxOELWH.DPG7giL0xCZ5k0dVSFi52I3qK();
		}
		bool flag = DfU4wrswBK5kLyiyV6mHZwOg8.useCustomCrosshair && Player.player != null;
		if (flag)
		{
			DkJkcCeRE7wLxXH7SBIxOELWH.D1a3ZuGqxCuy7z0AMUpIB6Os0();
		}
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00020F30 File Offset: 0x0001F130
	private static void D1a3ZuGqxCuy7z0AMUpIB6Os0()
	{
		int num = DfU4wrswBK5kLyiyV6mHZwOg8.crosshairHeight * 2;
		bool flag = DfU4wrswBK5kLyiyV6mHZwOg8.crosshairWidth % 2 == 0;
		DdAT8d84ifnXbB75Ww07uS98r crosshairType = DfU4wrswBK5kLyiyV6mHZwOg8.crosshairType;
		bool flag2 = crosshairType > DdAT8d84ifnXbB75Ww07uS98r.Solid;
		if (flag2)
		{
			bool flag3 = crosshairType == DdAT8d84ifnXbB75Ww07uS98r.Gap;
			if (flag3)
			{
				Rect rect = new Rect((float)(Screen.width / 2 - DfU4wrswBK5kLyiyV6mHZwOg8.crosshairWidth / 2), (float)(Screen.height / 2 - DfU4wrswBK5kLyiyV6mHZwOg8.crosshairWidth / 2), (float)(DfU4wrswBK5kLyiyV6mHZwOg8.crosshairWidth + (flag ? 1 : 0)), (float)(DfU4wrswBK5kLyiyV6mHZwOg8.crosshairWidth + (flag ? 1 : 0)));
				Rect rect2 = new Rect(rect.x, rect.y - (float)num, rect.width, (float)(num - DfU4wrswBK5kLyiyV6mHZwOg8.crosshairGap));
				Rect rect3 = new Rect(rect.x, rect.y + rect.height + (float)DfU4wrswBK5kLyiyV6mHZwOg8.crosshairGap, rect.width, (float)(num - DfU4wrswBK5kLyiyV6mHZwOg8.crosshairGap));
				Rect rect4 = new Rect(rect.x - (float)num, rect.y, (float)(num - DfU4wrswBK5kLyiyV6mHZwOg8.crosshairGap), rect.height);
				Rect rect5 = new Rect(rect.x + rect.width + (float)DfU4wrswBK5kLyiyV6mHZwOg8.crosshairGap, rect.y, (float)(num - DfU4wrswBK5kLyiyV6mHZwOg8.crosshairGap), rect.height);
				DrysTRTjdLdFqu5GJBDif6AoV.DT33ynUfwLxankDwm7mXB7OK4(rect2, DHTB5RKsHUihFrfj9ewuLh1f9.DazBzygjoFMvkTR5WZh79oJmJ, DNbYBVifu73t6Hq5vgTtgKwS7.DaXgkzF0n71hmkyAbipgooHRa("Crosshair color").DkJGdJpvFP4j4uWN4CyFixyQ3, false, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DT33ynUfwLxankDwm7mXB7OK4(rect3, DHTB5RKsHUihFrfj9ewuLh1f9.DazBzygjoFMvkTR5WZh79oJmJ, DNbYBVifu73t6Hq5vgTtgKwS7.DaXgkzF0n71hmkyAbipgooHRa("Crosshair color").DkJGdJpvFP4j4uWN4CyFixyQ3, false, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DT33ynUfwLxankDwm7mXB7OK4(rect4, DHTB5RKsHUihFrfj9ewuLh1f9.DazBzygjoFMvkTR5WZh79oJmJ, DNbYBVifu73t6Hq5vgTtgKwS7.DaXgkzF0n71hmkyAbipgooHRa("Crosshair color").DkJGdJpvFP4j4uWN4CyFixyQ3, false, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DT33ynUfwLxankDwm7mXB7OK4(rect5, DHTB5RKsHUihFrfj9ewuLh1f9.DazBzygjoFMvkTR5WZh79oJmJ, DNbYBVifu73t6Hq5vgTtgKwS7.DaXgkzF0n71hmkyAbipgooHRa("Crosshair color").DkJGdJpvFP4j4uWN4CyFixyQ3, false, ScaleMode.StretchToFill);
			}
		}
		else
		{
			Rect rect6 = new Rect((float)(Screen.width / 2 - DfU4wrswBK5kLyiyV6mHZwOg8.crosshairHeight), (float)(Screen.height / 2 - DfU4wrswBK5kLyiyV6mHZwOg8.crosshairWidth / 2), (float)(num + 1), (float)(DfU4wrswBK5kLyiyV6mHZwOg8.crosshairWidth + (flag ? 1 : 0)));
			Rect rect7 = new Rect((float)(Screen.width / 2 - DfU4wrswBK5kLyiyV6mHZwOg8.crosshairWidth / 2), (float)(Screen.height / 2 - DfU4wrswBK5kLyiyV6mHZwOg8.crosshairHeight), (float)(DfU4wrswBK5kLyiyV6mHZwOg8.crosshairWidth + (flag ? 1 : 0)), (float)(num + 1));
			DrysTRTjdLdFqu5GJBDif6AoV.DT33ynUfwLxankDwm7mXB7OK4(rect6, DHTB5RKsHUihFrfj9ewuLh1f9.DazBzygjoFMvkTR5WZh79oJmJ, DNbYBVifu73t6Hq5vgTtgKwS7.DaXgkzF0n71hmkyAbipgooHRa("Crosshair color").DkJGdJpvFP4j4uWN4CyFixyQ3, false, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DT33ynUfwLxankDwm7mXB7OK4(rect7, DHTB5RKsHUihFrfj9ewuLh1f9.DazBzygjoFMvkTR5WZh79oJmJ, DNbYBVifu73t6Hq5vgTtgKwS7.DaXgkzF0n71hmkyAbipgooHRa("Crosshair color").DkJGdJpvFP4j4uWN4CyFixyQ3, false, ScaleMode.StretchToFill);
		}
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00021198 File Offset: 0x0001F398
	private static void DPG7giL0xCZ5k0dVSFi52I3qK()
	{
		DHTB5RKsHUihFrfj9ewuLh1f9.DgrS1Khe0pBTJtuNOOIFIMr6Z.fontSize = DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelSize;
		DHTB5RKsHUihFrfj9ewuLh1f9.DgrS1Khe0pBTJtuNOOIFIMr6Z.normal.textColor = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Info panel text color");
		string text;
		try
		{
			text = string.Concat(new string[]
			{
				"MoonClient Unturned Public",
				" | ",
				DmErKmxWRjHNSG8p8mCUQIUbM.DSTazTWSW8NJjAmhdnS7ks0KO(DateTime.Now.Minute * 60 + DateTime.Now.Hour * 3600 + DateTime.Now.Second),
				" | ",
				Provider.isConnected ? string.Concat(new string[]
				{
					Provider.serverName,
					" | ",
					Parser.getIPFromUInt32(Provider.CurrentServerAdvertisement.ip) + ":" + Provider.CurrentServerAdvertisement.queryPort.ToString(),
					" | ",
					((int)(Provider.ping * 1000f)).ToString() + "ms"
				}) : "Not connected",
				" | ",
				DA99SI5vQ2bocOplrJX51I0fZ.DfXGp5saXCGNsfyCyrfp7YByx.ToString() + " FPS"
			});
		}
		catch
		{
			text = string.Concat(new string[]
			{
				"MoonClient Unturned Public",
				" | ",
				DmErKmxWRjHNSG8p8mCUQIUbM.DSTazTWSW8NJjAmhdnS7ks0KO(DateTime.Now.Minute * 60 + DateTime.Now.Hour * 3600 + DateTime.Now.Second),
				" | ",
				"Single Player",
				" | ",
				DA99SI5vQ2bocOplrJX51I0fZ.DfXGp5saXCGNsfyCyrfp7YByx.ToString() + " FPS"
			});
		}
		Vector2 vector = DHTB5RKsHUihFrfj9ewuLh1f9.DgrS1Khe0pBTJtuNOOIFIMr6Z.CalcSize(new GUIContent(text));
		Color color = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Menu background color");
		Color32 color2 = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Menu line color");
		float num = 4f;
		float num2 = 8f;
		Rect rect = new Rect((float)DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelPaddingFromScreen, (float)DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelPaddingFromScreen, vector.x + num2, vector.y + num * 2f);
		bool flag = DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelPaddingPlacement == DuS8uf732VHhCWZLtWsVr3zfy.Top;
		if (flag)
		{
			rect.y += (float)DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelPadding;
		}
		else
		{
			bool flag2 = DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelPaddingPlacement == DuS8uf732VHhCWZLtWsVr3zfy.Left;
			if (flag2)
			{
				rect.x += (float)DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelPadding;
			}
		}
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect, color, false, ScaleMode.StretchToFill);
		Texture2D watermarkBgTexture = DrysTRTjdLdFqu5GJBDif6AoV.GetWatermarkBgTexture();
		float num3 = Time.time * 8f % 24f;
		float num4 = num3 / 24f;
		Color color3 = GUI.color;
		GUI.color = Color.white;
		GUI.DrawTextureWithTexCoords(rect, watermarkBgTexture, new Rect(-num4, 0f, rect.width / 24f, rect.height / 24f), true);
		GUI.color = color3;
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, rect.width, 2f), color2, false, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + rect.height - 2f, rect.width, 2f), color2, false, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, 2f, rect.height), color2, false, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 2f, rect.y, 2f, rect.height), color2, false, ScaleMode.StretchToFill);
		Rect rect2 = new Rect(rect.x + num2 / 2f, rect.y + num, vector.x, vector.y);
		GUI.Label(rect2, text, DHTB5RKsHUihFrfj9ewuLh1f9.DgrS1Khe0pBTJtuNOOIFIMr6Z);
		DHTB5RKsHUihFrfj9ewuLh1f9.DgrS1Khe0pBTJtuNOOIFIMr6Z.normal.textColor = new Color32(100, 100, 100, byte.MaxValue);
		DHTB5RKsHUihFrfj9ewuLh1f9.DgrS1Khe0pBTJtuNOOIFIMr6Z.fontSize = 20;
	}
}
