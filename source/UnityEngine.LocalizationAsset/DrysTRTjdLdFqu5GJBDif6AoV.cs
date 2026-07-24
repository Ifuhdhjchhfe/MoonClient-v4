using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000B2 RID: 178
public static class DrysTRTjdLdFqu5GJBDif6AoV
{
	// Token: 0x06000363 RID: 867 RVA: 0x0003130C File Offset: 0x0002F50C
	public static Color32 GetAccentColor(byte alpha = 255)
	{
		Color32 color = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Menu accent color");
		color.a = alpha;
		return color;
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00031338 File Offset: 0x0002F538
	public static float DqSj2t1zG7WX2JTWDZOhvbfxt(string userText, float value, float min, float max, string end = "")
	{
		bool useLegacySliders = DfU4wrswBK5kLyiyV6mHZwOg8.useLegacySliders;
		bool flag = useLegacySliders;
		float num;
		if (flag)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF(userText + value.ToString() + end);
			DqNh7bzS0xEILWgxFJA4tpJpp.DdPz7R4rqMVxYUu02MjIYP9QM(-4);
			num = DqNh7bzS0xEILWgxFJA4tpJpp.DaIL6XMZTDvtJWD6QLy7YAzSG(value, min, max);
		}
		else
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += 14;
			bool flag2 = !DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
			bool flag3 = flag2;
			if (flag3)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= 14;
				num = value;
			}
			else
			{
				string text = (Mathf.Round(value * 1000f) * 0.001f).ToString();
				text = ((text.Length > 5) ? text.Substring(0, 5) : text);
				string text2 = userText + text + end;
				int num2 = (int)GUI.skin.label.CalcSize(new GUIContent(userText + ((int)max).ToString() + ",000" + end)).x + 8;
				GUI.Label(new Rect((float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - 14f, (float)num2, 14f), text2);
				float num3 = GUI.HorizontalSlider(new Rect((float)(DqNh7bzS0xEILWgxFJA4tpJpp.rectX + num2), DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - 18f, (float)(DqNh7bzS0xEILWgxFJA4tpJpp.width - DqNh7bzS0xEILWgxFJA4tpJpp.padding - num2), 14f), value, min, max);
				num = num3;
			}
		}
		return num;
	}

	// Token: 0x06000365 RID: 869 RVA: 0x000314D0 File Offset: 0x0002F6D0
	public static int DzYFrGEXcjEx3ES1qwjHEo7F3(string userText, int value, int min, int max, string end = "")
	{
		bool useLegacySliders = DfU4wrswBK5kLyiyV6mHZwOg8.useLegacySliders;
		bool flag = useLegacySliders;
		int num;
		if (flag)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF(userText + value.ToString() + end);
			DqNh7bzS0xEILWgxFJA4tpJpp.DdPz7R4rqMVxYUu02MjIYP9QM(-4);
			num = (int)DqNh7bzS0xEILWgxFJA4tpJpp.DaIL6XMZTDvtJWD6QLy7YAzSG((float)value, (float)min, (float)max);
		}
		else
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += 14;
			bool flag2 = !DqNh7bzS0xEILWgxFJA4tpJpp.DZjPwdrThVe0YGYIIXGJHRKMQ();
			bool flag3 = flag2;
			if (flag3)
			{
				DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.De48g0GOFgPvrYoYGKCfbyZh3 -= 14;
				num = value;
			}
			else
			{
				string text = userText + value.ToString() + end;
				int num2 = (int)GUI.skin.label.CalcSize(new GUIContent(userText + max.ToString() + end)).x + 8;
				GUI.Label(new Rect((float)DqNh7bzS0xEILWgxFJA4tpJpp.rectX, DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - 14f, (float)num2, 14f), text);
				int num3 = (int)GUI.HorizontalSlider(new Rect((float)(DqNh7bzS0xEILWgxFJA4tpJpp.rectX + num2), DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.D4BeFEx49h9DAVcFOFkaCZHbh.y + (float)DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset - 18f, (float)(DqNh7bzS0xEILWgxFJA4tpJpp.width - DqNh7bzS0xEILWgxFJA4tpJpp.padding - num2), 14f), (float)value, (float)min, (float)max);
				num = num3;
			}
		}
		return num;
	}

	// Token: 0x06000366 RID: 870 RVA: 0x00031633 File Offset: 0x0002F833
	public static void DTDaRQnb40S82p051KboT2mdX<T>(this DoBBXnQ70t7Pdvzomc3O1yC2C<T> es, string selectiveName, string enumName = "") where T : struct
	{
		DrysTRTjdLdFqu5GJBDif6AoV.DLBdImqWGORG4TqIutTr7sLBd<T>(selectiveName, es, -1, enumName);
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00031640 File Offset: 0x0002F840
	public static T DdoC7WUc7IFAmnWoLcSWPOXFw<T>(this T src, string selectiveName, string enumName = "") where T : struct
	{
		D4WIZXAOkc83nheh8yO4dQDGh d4WIZXAOkc83nheh8yO4dQDGh;
		bool flag = !DrysTRTjdLdFqu5GJBDif6AoV.DY94NDz4ZnJCIslCITVEIsblJ.TryGetValue(src.GetType(), out d4WIZXAOkc83nheh8yO4dQDGh);
		bool flag2 = flag;
		if (flag2)
		{
			d4WIZXAOkc83nheh8yO4dQDGh = new D4WIZXAOkc83nheh8yO4dQDGh(src);
			DrysTRTjdLdFqu5GJBDif6AoV.DY94NDz4ZnJCIslCITVEIsblJ.Add(src.GetType(), d4WIZXAOkc83nheh8yO4dQDGh);
		}
		DrysTRTjdLdFqu5GJBDif6AoV.DGp1eZv16qTIxmz4NvgI0zitc(selectiveName, d4WIZXAOkc83nheh8yO4dQDGh, -1, enumName);
		return (T)((object)d4WIZXAOkc83nheh8yO4dQDGh.DrFUpxbK1PdxnzRXQmVj0C6Kt);
	}

	// Token: 0x06000368 RID: 872 RVA: 0x000316B0 File Offset: 0x0002F8B0
	public static void DT33ynUfwLxankDwm7mXB7OK4(Rect rect, Texture2D tex, Color32 c, bool appendAlpha = true, ScaleMode sm = ScaleMode.StretchToFill)
	{
		if (appendAlpha)
		{
			c.a = (byte)(DL3tNdrQzY7o8FV1oIOKODOLQ.DsVlNI7hwmvLykhj6f2v4gFgu() * 255f);
		}
		rect = new Rect(Mathf.Round(rect.x), Mathf.Round(rect.y), Mathf.Round(rect.width), Mathf.Round(rect.height));
		GUI.DrawTexture(rect, tex, sm, true, 0f, c, 0f, 0f);
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00031730 File Offset: 0x0002F930
	public static void DytkmjKQAK1tAtNzrP40DgjrU(Rect rect, Color32 c, bool appendAlpha = true, ScaleMode sm = ScaleMode.StretchToFill)
	{
		if (appendAlpha)
		{
			c.a = (byte)(DL3tNdrQzY7o8FV1oIOKODOLQ.DsVlNI7hwmvLykhj6f2v4gFgu() * 255f);
		}
		rect = new Rect(Mathf.Round(rect.x), Mathf.Round(rect.y), Mathf.Round(rect.width), Mathf.Round(rect.height));
		GUI.DrawTexture(rect, DHTB5RKsHUihFrfj9ewuLh1f9.DazBzygjoFMvkTR5WZh79oJmJ, sm, false, 0f, c, 0f, 0f);
	}

	// Token: 0x0600036A RID: 874 RVA: 0x000317B2 File Offset: 0x0002F9B2
	public static void DeLTQCvgBrZjuiqrrmd5Qwyhp(Rect rect, global::System.Action action = null, int padding = 15)
	{
		DrysTRTjdLdFqu5GJBDif6AoV.D8RXErSQ3ONjP2GqTSabXlKWN(rect, new Color32(20, 20, 20, byte.MaxValue), new Color32(30, 30, 30, byte.MaxValue), new Color32(24, 24, 24, byte.MaxValue), action, padding);
	}

	// Token: 0x0600036B RID: 875 RVA: 0x000317F0 File Offset: 0x0002F9F0
	public static Texture2D GetAnimatedBgTexture()
	{
		bool flag = DrysTRTjdLdFqu5GJBDif6AoV.m_AnimatedBgTexture == null;
		if (flag)
		{
			DrysTRTjdLdFqu5GJBDif6AoV.m_AnimatedBgTexture = new Texture2D(24, 24);
			DrysTRTjdLdFqu5GJBDif6AoV.m_AnimatedBgTexture.wrapMode = TextureWrapMode.Repeat;
			Color32[] array = new Color32[576];
			for (int i = 0; i < 24; i++)
			{
				for (int j = 0; j < 24; j++)
				{
					int num = (j - i) % 24;
					bool flag2 = num < 0;
					if (flag2)
					{
						num += 24;
					}
					bool flag3 = num <= 1 || num >= 23;
					if (flag3)
					{
						array[i * 24 + j] = new Color32(0, 0, 0, 51);
					}
					else
					{
						array[i * 24 + j] = new Color32(0, 0, 0, 0);
					}
				}
			}
			DrysTRTjdLdFqu5GJBDif6AoV.m_AnimatedBgTexture.SetPixels32(array);
			DrysTRTjdLdFqu5GJBDif6AoV.m_AnimatedBgTexture.Apply();
		}
		return DrysTRTjdLdFqu5GJBDif6AoV.m_AnimatedBgTexture;
	}

	// Token: 0x0600036C RID: 876 RVA: 0x000318E8 File Offset: 0x0002FAE8
	public static Texture2D GetWatermarkBgTexture()
	{
		bool flag = DrysTRTjdLdFqu5GJBDif6AoV.m_WatermarkBgTexture == null;
		if (flag)
		{
			DrysTRTjdLdFqu5GJBDif6AoV.m_WatermarkBgTexture = new Texture2D(24, 24);
			DrysTRTjdLdFqu5GJBDif6AoV.m_WatermarkBgTexture.wrapMode = TextureWrapMode.Repeat;
			Color32[] array = new Color32[576];
			for (int i = 0; i < 24; i++)
			{
				for (int j = 0; j < 24; j++)
				{
					int num = (j - i) % 24;
					bool flag2 = num < 0;
					if (flag2)
					{
						num += 24;
					}
					bool flag3 = num <= 2 || num >= 22;
					if (flag3)
					{
						array[i * 24 + j] = new Color32(0, 0, 0, 85);
					}
					else
					{
						array[i * 24 + j] = new Color32(0, 0, 0, 0);
					}
				}
			}
			DrysTRTjdLdFqu5GJBDif6AoV.m_WatermarkBgTexture.SetPixels32(array);
			DrysTRTjdLdFqu5GJBDif6AoV.m_WatermarkBgTexture.Apply();
		}
		return DrysTRTjdLdFqu5GJBDif6AoV.m_WatermarkBgTexture;
	}

	// Token: 0x0600036D RID: 877 RVA: 0x000319E0 File Offset: 0x0002FBE0
	public static void D8RXErSQ3ONjP2GqTSabXlKWN(Rect rect, Color32 background, Color32 outline, Color32 content, global::System.Action action = null, int padding = 15)
	{
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x - 1f, rect.y - 1f, rect.width + 2f, rect.height + 2f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, rect.width, rect.height), content, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + 3f, 1f, 2f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 1f, rect.y + 2f, 1f, 1f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 2f, rect.y + 1f, 1f, 1f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 3f, rect.y, 2f, 1f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x - 1f, rect.y - 1f, 6f, 1f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x - 1f, rect.y - 1f, 1f, 6f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, 1f, 3f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, 3f, 1f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 1f, rect.y + 1f, 1f, 1f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 1f, rect.y + 3f, 1f, 2f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 2f, rect.y + 2f, 1f, 1f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 3f, rect.y + 1f, 1f, 1f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 5f, rect.y, 2f, 1f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 5f, rect.y - 1f, 6f, 1f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width, rect.y - 1f, 1f, 6f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 1f, rect.y, 1f, 3f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 3f, rect.y, 3f, 1f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 2f, rect.y + 1f, 1f, 1f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + rect.height - 5f, 1f, 2f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 1f, rect.y + rect.height - 3f, 1f, 1f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 2f, rect.y + rect.height - 2f, 1f, 1f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 3f, rect.y + rect.height - 1f, 2f, 1f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x - 1f, rect.y + rect.height, 6f, 1f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x - 1f, rect.y + rect.height - 5f, 1f, 5f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + rect.height - 1f, 3f, 1f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + rect.height - 3f, 1f, 3f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 1f, rect.y + rect.height - 2f, 1f, 1f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 1f, rect.y + rect.height - 5f, 1f, 2f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 2f, rect.y + rect.height - 3f, 1f, 1f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 3f, rect.y + rect.height - 2f, 1f, 1f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 5f, rect.y + rect.height - 1f, 2f, 1f), outline, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 5f, rect.y + rect.height, 6f, 1f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width, rect.y + rect.height - 5f, 1f, 6f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 3f, rect.y + rect.height - 1f, 3f, 1f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 1f, rect.y + rect.height - 3f, 1f, 3f), background, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 2f, rect.y + rect.height - 2f, 1f, 3f), background, true, ScaleMode.StretchToFill);
		bool flag = action == null;
		bool flag2 = !flag;
		if (flag2)
		{
			Rect rect2 = new Rect(rect.x + (float)padding, rect.y + (float)padding, rect.width - (float)(padding * 2), rect.height - (float)(padding * 2));
			DrysTRTjdLdFqu5GJBDif6AoV.Dtib43oq6yhDjtGzggdWk0MwM = rect2;
			GUILayout.BeginArea(rect2);
			try
			{
				action();
			}
			catch (Exception ex)
			{
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("error while draw tab");
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.Message);
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.StackTrace);
			}
			finally
			{
				GUILayout.EndArea();
			}
		}
	}

	// Token: 0x0600036E RID: 878 RVA: 0x000322D4 File Offset: 0x000304D4
	public static float DthVWrAR0a2RmWEgiCZM30SCV(string name, float value, float min, float max, int width = -1)
	{
		bool flag = !string.IsNullOrEmpty(DrysTRTjdLdFqu5GJBDif6AoV.featureSearchText) && !name.ToLower().Contains(DrysTRTjdLdFqu5GJBDif6AoV.featureSearchText.ToLower());
		float num;
		if (flag)
		{
			num = value;
		}
		else
		{
			Rect rect = GUILayoutUtility.GetRect((float)width, 24f);
			width = (int)rect.width;
			string text = name + "_sld_hover";
			string text2 = name + "_sld_fill";
			string text3 = name + "_sld_thumb";
			string text4 = name + "_sld_value";
			float num2;
			bool flag2 = !DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.TryGetValue(text4, out num2);
			if (flag2)
			{
				num2 = value;
				DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.Add(text4, value);
			}
			GUI.Label(new Rect(rect.x, rect.y, rect.width - 50f, 18f), name);
			Rect rect2 = new Rect(rect.x, rect.y + 17f, rect.width, 6f);
			int controlID = GUIUtility.GetControlID(FocusType.Passive);
			bool flag3 = DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj == null;
			if (flag3)
			{
				switch (Event.current.GetTypeForControl(controlID))
				{
				case EventType.MouseDown:
				{
					bool flag4 = rect2.Contains(Event.current.mousePosition) && Event.current.button == 0;
					if (flag4)
					{
						GUIUtility.hotControl = controlID;
						float num3 = (Event.current.mousePosition.x - rect2.x) / rect2.width;
						value = min + num3 * (max - min);
						value = Mathf.Clamp(value, min, max);
						Event.current.Use();
					}
					break;
				}
				case EventType.MouseUp:
				{
					bool flag5 = GUIUtility.hotControl == controlID && Event.current.button == 0;
					if (flag5)
					{
						GUIUtility.hotControl = 0;
						Event.current.Use();
					}
					break;
				}
				case EventType.MouseDrag:
				{
					bool flag6 = GUIUtility.hotControl == controlID;
					if (flag6)
					{
						float num4 = (Event.current.mousePosition.x - rect2.x) / rect2.width;
						value = min + num4 * (max - min);
						value = Mathf.Clamp(value, min, max);
						Event.current.Use();
					}
					break;
				}
				}
			}
			float num5;
			bool flag7 = !DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.TryGetValue(text, out num5);
			if (flag7)
			{
				num5 = 0f;
				DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.Add(text, 0f);
			}
			bool flag8 = rect2.Contains(Event.current.mousePosition);
			bool flag9 = Event.current.type == EventType.Repaint;
			if (flag9)
			{
				bool flag10 = flag8 || GUIUtility.hotControl == controlID;
				if (flag10)
				{
					num5 += Time.deltaTime * 5f;
				}
				else
				{
					num5 -= Time.deltaTime * 5f;
				}
				num5 = Mathf.Clamp01(num5);
				DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr[text] = num5;
				DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr[text4] = value;
			}
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect2, new Color32(20, 20, 22, byte.MaxValue), true, ScaleMode.StretchToFill);
			bool flag11 = GUIUtility.hotControl == controlID;
			Color32 accentColor;
			if (flag11)
			{
				accentColor = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
			}
			else
			{
				bool flag12 = num5 > 0f;
				if (flag12)
				{
					float num6 = Mathf.Sin(Time.time * 3f) * 0.1f + 0.9f;
					Color32 accentColor2 = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
					accentColor = new Color32((byte)((float)accentColor2.r * num6), (byte)((float)accentColor2.g * num6), (byte)((float)accentColor2.b * num6), (byte)(num5 * 150f));
				}
				else
				{
					accentColor = new Color32(65, 65, 70, byte.MaxValue);
				}
			}
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, rect2.width, 1f), accentColor, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y + rect2.height - 1f, rect2.width, 1f), accentColor, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, 1f, rect2.height), accentColor, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x + rect2.width - 1f, rect2.y, 1f, rect2.height), accentColor, true, ScaleMode.StretchToFill);
			float num7 = (value - min) / (max - min);
			float num8 = (num2 - min) / (max - min);
			float num9 = Mathf.Lerp(num8, num7, Time.deltaTime * 15f);
			float num10 = rect2.x + num9 * rect2.width;
			Rect rect3 = new Rect(rect2.x + 1f, rect2.y + 1f, Mathf.Max(0f, num10 - rect2.x - 1f), rect2.height - 2f);
			Color32 accentColor3 = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect3, accentColor3, true, ScaleMode.StretchToFill);
			float num11 = 1f;
			bool flag13 = GUIUtility.hotControl == controlID;
			if (flag13)
			{
				num11 = 0.9f;
			}
			else
			{
				bool flag14 = num5 > 0f;
				if (flag14)
				{
					num11 = 1f + num5 * 0.2f;
				}
			}
			float num12 = 6f * num11;
			float num13 = 12f * num11;
			Rect rect4 = new Rect(num10 - num12 / 2f, rect2.y + rect2.height / 2f - num13 / 2f, num12, num13);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect4, accentColor3, true, ScaleMode.StretchToFill);
			float num14 = Mathf.Lerp(num2, value, Time.deltaTime * 10f);
			float num15 = Mathf.Round(num14 * 10f) * 0.1f;
			Rect rect5 = new Rect(rect.x + (float)width - 46f, rect.y, 45f, 14f);
			Color32 accentColor4 = new Color32(65, 65, 70, byte.MaxValue);
			bool flag15 = Mathf.Abs(value - num2) > 0.01f;
			if (flag15)
			{
				accentColor4 = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
			}
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect5, new Color32(20, 20, 22, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect5.x, rect5.y, rect5.width, 1f), accentColor4, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect5.x, rect5.y + rect5.height - 1f, rect5.width, 1f), accentColor4, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect5.x, rect5.y, 1f, rect5.height), accentColor4, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect5.x + rect5.width - 1f, rect5.y, 1f, rect5.height), accentColor4, true, ScaleMode.StretchToFill);
			GUIStyle guistyle = new GUIStyle(GUI.skin.label);
			guistyle.alignment = TextAnchor.MiddleCenter;
			guistyle.fontSize = 10;
			guistyle.normal.textColor = new Color32(230, 230, 230, byte.MaxValue);
			GUI.Label(rect5, num15.ToString(), guistyle);
			GUILayout.Space(4f);
			num = value;
		}
		return num;
	}

	// Token: 0x0600036F RID: 879 RVA: 0x00032A68 File Offset: 0x00030C68
	public static int DhaoW4JmdlGy7n9uEK8N06dTr(string name, int value, int min, int max, int width = -1)
	{
		bool flag = !string.IsNullOrEmpty(DrysTRTjdLdFqu5GJBDif6AoV.featureSearchText) && !name.ToLower().Contains(DrysTRTjdLdFqu5GJBDif6AoV.featureSearchText.ToLower());
		int num;
		if (flag)
		{
			num = value;
		}
		else
		{
			Rect rect = GUILayoutUtility.GetRect((float)width, 24f);
			width = (int)rect.width;
			GUI.Label(new Rect(rect.x, rect.y, rect.width - 50f, 18f), name);
			Rect rect2 = new Rect(rect.x, rect.y + 17f, rect.width, 6f);
			int controlID = GUIUtility.GetControlID(FocusType.Passive);
			bool flag2 = DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj == null;
			if (flag2)
			{
				switch (Event.current.GetTypeForControl(controlID))
				{
				case EventType.MouseDown:
				{
					bool flag3 = rect2.Contains(Event.current.mousePosition) && Event.current.button == 0;
					if (flag3)
					{
						GUIUtility.hotControl = controlID;
						float num2 = (Event.current.mousePosition.x - rect2.x) / rect2.width;
						value = (int)((float)min + num2 * (float)(max - min));
						value = Mathf.Clamp(value, min, max);
						Event.current.Use();
					}
					break;
				}
				case EventType.MouseUp:
				{
					bool flag4 = GUIUtility.hotControl == controlID && Event.current.button == 0;
					if (flag4)
					{
						GUIUtility.hotControl = 0;
						Event.current.Use();
					}
					break;
				}
				case EventType.MouseDrag:
				{
					bool flag5 = GUIUtility.hotControl == controlID;
					if (flag5)
					{
						float num3 = (Event.current.mousePosition.x - rect2.x) / rect2.width;
						value = (int)((float)min + num3 * (float)(max - min));
						value = Mathf.Clamp(value, min, max);
						Event.current.Use();
					}
					break;
				}
				}
			}
			string text = name + "_sld";
			float num4;
			bool flag6 = !DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.TryGetValue(text, out num4);
			if (flag6)
			{
				num4 = 0f;
				DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.Add(text, 0f);
			}
			bool flag7 = rect2.Contains(Event.current.mousePosition);
			bool flag8 = Event.current.type == EventType.Repaint;
			if (flag8)
			{
				bool flag9 = flag7 || GUIUtility.hotControl == controlID;
				if (flag9)
				{
					num4 += Time.deltaTime * 5f;
				}
				else
				{
					num4 -= Time.deltaTime * 5f;
				}
				num4 = Mathf.Clamp01(num4);
				DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr[text] = num4;
			}
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect2, new Color32(20, 20, 22, byte.MaxValue), true, ScaleMode.StretchToFill);
			bool flag10 = GUIUtility.hotControl == controlID;
			Color32 color;
			if (flag10)
			{
				color = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
			}
			else
			{
				bool flag11 = num4 > 0f;
				if (flag11)
				{
					color = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor((byte)(num4 * 150f));
				}
				else
				{
					color = new Color32(65, 65, 70, byte.MaxValue);
				}
			}
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, rect2.width, 1f), color, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y + rect2.height - 1f, rect2.width, 1f), color, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, 1f, rect2.height), color, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x + rect2.width - 1f, rect2.y, 1f, rect2.height), color, true, ScaleMode.StretchToFill);
			float num5 = (float)(value - min) / (float)(max - min);
			float num6 = rect2.x + num5 * rect2.width;
			Rect rect3 = new Rect(rect2.x + 1f, rect2.y + 1f, Mathf.Max(0f, num6 - rect2.x - 1f), rect2.height - 2f);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect3, DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue), true, ScaleMode.StretchToFill);
			float num7 = Mathf.Lerp(1f, 1.3f, num4);
			float num8 = 6f * num7;
			float num9 = 12f * num7;
			Rect rect4 = new Rect(num6 - num8 / 2f, rect2.y + rect2.height / 2f - num9 / 2f, num8, num9);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect4, DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue), true, ScaleMode.StretchToFill);
			Rect rect5 = new Rect(rect.x + (float)width - 46f, rect.y, 45f, 14f);
			Color32 color2 = new Color32(65, 65, 70, byte.MaxValue);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect5, new Color32(20, 20, 22, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect5.x, rect5.y, rect5.width, 1f), color2, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect5.x, rect5.y + rect5.height - 1f, rect5.width, 1f), color2, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect5.x, rect5.y, 1f, rect5.height), color2, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect5.x + rect5.width - 1f, rect5.y, 1f, rect5.height), color2, true, ScaleMode.StretchToFill);
			GUIStyle guistyle = new GUIStyle(GUI.skin.label);
			guistyle.alignment = TextAnchor.MiddleCenter;
			guistyle.fontSize = 10;
			guistyle.normal.textColor = new Color32(230, 230, 230, byte.MaxValue);
			GUI.Label(rect5, value.ToString(), guistyle);
			GUILayout.Space(4f);
			num = value;
		}
		return num;
	}

	// Token: 0x06000370 RID: 880 RVA: 0x000330B0 File Offset: 0x000312B0
	public static float DiIzr0IyRE8047lHIEzXzzFRJ(float value, float min, float max, int width = -1)
	{
		Rect rect = GUILayoutUtility.GetRect((float)width, 8f);
		width = (int)rect.width;
		int controlID = GUIUtility.GetControlID(FocusType.Passive);
		bool flag = DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj == null;
		if (flag)
		{
			switch (Event.current.GetTypeForControl(controlID))
			{
			case EventType.MouseDown:
			{
				bool flag2 = rect.Contains(Event.current.mousePosition) && Event.current.button == 0;
				if (flag2)
				{
					GUIUtility.hotControl = controlID;
					float num = (Event.current.mousePosition.x - rect.x) / rect.width;
					value = min + num * (max - min);
					value = Mathf.Clamp(value, min, max);
					Event.current.Use();
				}
				break;
			}
			case EventType.MouseUp:
			{
				bool flag3 = GUIUtility.hotControl == controlID && Event.current.button == 0;
				if (flag3)
				{
					GUIUtility.hotControl = 0;
					Event.current.Use();
				}
				break;
			}
			case EventType.MouseDrag:
			{
				bool flag4 = GUIUtility.hotControl == controlID;
				if (flag4)
				{
					float num2 = (Event.current.mousePosition.x - rect.x) / rect.width;
					value = min + num2 * (max - min);
					value = Mathf.Clamp(value, min, max);
					Event.current.Use();
				}
				break;
			}
			}
		}
		string text = "raw_sld_" + rect.x.ToString() + "_" + rect.y.ToString();
		float num3;
		bool flag5 = !DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.TryGetValue(text, out num3);
		if (flag5)
		{
			num3 = 0f;
			DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.Add(text, 0f);
		}
		bool flag6 = rect.Contains(Event.current.mousePosition);
		bool flag7 = Event.current.type == EventType.Repaint;
		if (flag7)
		{
			bool flag8 = flag6 || GUIUtility.hotControl == controlID;
			if (flag8)
			{
				num3 += Time.deltaTime * 5f;
			}
			else
			{
				num3 -= Time.deltaTime * 5f;
			}
			num3 = Mathf.Clamp01(num3);
			DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr[text] = num3;
		}
		Rect rect2 = new Rect(rect.x, rect.y + 1f, rect.width, 6f);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect2, new Color32(20, 20, 22, byte.MaxValue), true, ScaleMode.StretchToFill);
		bool flag9 = GUIUtility.hotControl == controlID;
		Color32 color;
		if (flag9)
		{
			color = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
		}
		else
		{
			bool flag10 = num3 > 0f;
			if (flag10)
			{
				color = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor((byte)(num3 * 150f));
			}
			else
			{
				color = new Color32(65, 65, 70, byte.MaxValue);
			}
		}
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, rect2.width, 1f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y + rect2.height - 1f, rect2.width, 1f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, 1f, rect2.height), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x + rect2.width - 1f, rect2.y, 1f, rect2.height), color, true, ScaleMode.StretchToFill);
		float num4 = (value - min) / (max - min);
		float num5 = rect2.x + num4 * rect2.width;
		Rect rect3 = new Rect(rect2.x + 1f, rect2.y + 1f, Mathf.Max(0f, num5 - rect2.x - 1f), rect2.height - 2f);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect3, DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue), true, ScaleMode.StretchToFill);
		Rect rect4 = new Rect(num5 - 3f, rect2.y + rect2.height / 2f - 5f, 6f, 10f);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect4, DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue), true, ScaleMode.StretchToFill);
		return value;
	}

	// Token: 0x06000371 RID: 881 RVA: 0x00033508 File Offset: 0x00031708
	public static bool DrawCheckbox(bool state, string label, params GUILayoutOption[] options)
	{
		return DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(state, label, null, options);
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00033524 File Offset: 0x00031724
	public static bool DrawCheckbox(bool state, string label, GUIStyle style, params GUILayoutOption[] options)
	{
		bool flag = !string.IsNullOrEmpty(DrysTRTjdLdFqu5GJBDif6AoV.featureSearchText) && !label.ToLower().Contains(DrysTRTjdLdFqu5GJBDif6AoV.featureSearchText.ToLower());
		bool flag2;
		if (flag)
		{
			flag2 = state;
		}
		else
		{
			Rect rect = GUILayoutUtility.GetRect(-1f, 20f);
			string text = label + "_chk_hover";
			float num;
			bool flag3 = !DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.TryGetValue(text, out num);
			if (flag3)
			{
				num = 0f;
				DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.Add(text, 0f);
			}
			bool flag4 = rect.Contains(Event.current.mousePosition);
			bool flag5 = Event.current.type == EventType.Repaint;
			if (flag5)
			{
				bool flag6 = flag4;
				if (flag6)
				{
					num += Time.deltaTime * 5f;
				}
				else
				{
					num -= Time.deltaTime * 5f;
				}
				num = Mathf.Clamp01(num);
				DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr[text] = num;
				float num2 = (flag4 ? 1.1f : 1f);
				float num3 = Mathf.Lerp(1f, num2, num);
				Rect rect2 = new Rect(rect.x + 2f, rect.y + 4f, 12f, 12f);
				Vector2 vector = new Vector2(rect2.x + rect2.width / 2f, rect2.y + rect2.height / 2f);
				float num4 = rect2.width * num3;
				float num5 = rect2.height * num3;
				Rect rect3 = new Rect(vector.x - num4 / 2f, vector.y - num5 / 2f, num4, num5);
				Color32 color = new Color32(20, 20, 22, byte.MaxValue);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect3, color, true, ScaleMode.StretchToFill);
				bool flag7 = state;
				Color32 color2;
				if (flag7)
				{
					color2 = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
				}
				else
				{
					bool flag8 = num > 0f;
					if (flag8)
					{
						color2 = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor((byte)(num * 150f));
					}
					else
					{
						color2 = new Color32(65, 65, 70, byte.MaxValue);
					}
				}
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect3.x, rect3.y, rect3.width, 1f), color2, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect3.x, rect3.y + rect3.height - 1f, rect3.width, 1f), color2, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect3.x, rect3.y, 1f, rect3.height), color2, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect3.x + rect3.width - 1f, rect3.y, 1f, rect3.height), color2, true, ScaleMode.StretchToFill);
				bool flag9 = state;
				if (flag9)
				{
					float num6 = 6f * num3;
					float num7 = rect3.x + Mathf.Round((rect3.width - num6) / 2f);
					float num8 = rect3.y + Mathf.Round((rect3.height - num6) / 2f);
					float num9 = ((num > 0f) ? 1f : 0f);
					Rect rect4 = new Rect(num7, num8, num6 + num9, num6 + num9);
					DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect4, DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue), true, ScaleMode.StretchToFill);
				}
				Rect rect5 = new Rect(rect.x + 22f, rect.y, rect.width - 22f, rect.height);
				GUIStyle guistyle = style ?? DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2;
				Color32 color3 = guistyle.normal.textColor;
				bool flag10 = state;
				Color32 color4;
				if (flag10)
				{
					color4 = new Color32(230, 230, 230, byte.MaxValue);
				}
				else
				{
					bool flag11 = flag4;
					if (flag11)
					{
						color4 = new Color32(180, 180, 180, byte.MaxValue);
					}
					else
					{
						color4 = new Color32(150, 150, 150, byte.MaxValue);
					}
				}
				guistyle.normal.textColor = color4;
				GUI.Label(rect5, label, guistyle);
				guistyle.normal.textColor = color3;
			}
			bool flag12 = flag4 && Input.GetMouseButtonDown(0) && Event.current.type == EventType.MouseDown && (DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj == null || !DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.Contains(new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y)));
			bool flag13 = flag12;
			if (flag13)
			{
				state = !state;
				Event.current.Use();
			}
			flag2 = state;
		}
		return flag2;
	}

	// Token: 0x06000373 RID: 883 RVA: 0x000339F4 File Offset: 0x00031BF4
	public static bool DVkWLbfI0YmUX0p9Ex8l2OuXvIcon(string label, int iconType, int width = -1, bool checkEnum = true)
	{
		Rect rect = GUILayoutUtility.GetRect((float)width, 20f);
		float num;
		bool flag = !DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.TryGetValue(label, out num);
		bool flag2 = flag;
		if (flag2)
		{
			num = 0f;
			DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.Add(label, 0f);
		}
		bool flag3 = Event.current.type != EventType.Repaint;
		bool flag4 = !flag3;
		if (flag4)
		{
			byte b = (byte)(25f + 35f * num);
			Color32 color = new Color32(b, b, (byte)((float)b + 5f * num), byte.MaxValue);
			Color32 color2 = ((num > 0f) ? DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor((byte)(100f + 155f * num)) : new Color32(50, 50, 52, byte.MaxValue));
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 1f, rect.y + 1f, rect.width - 2f, rect.height - 2f), color, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, rect.width, 1f), color2, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + rect.height - 1f, rect.width, 1f), color2, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, 1f, rect.height), color2, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 1f, rect.y, 1f, rect.height), color2, true, ScaleMode.StretchToFill);
			Color32 color3 = new Color32(180, 180, 180, byte.MaxValue);
			bool flag5 = iconType == 0;
			if (flag5)
			{
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width / 2f - 6f, rect.y + 4f, 12f, 12f), color3, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width / 2f - 4f, rect.y + 10f, 8f, 5f), color, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width / 2f - 3f, rect.y + 4f, 6f, 4f), color, true, ScaleMode.StretchToFill);
			}
			else
			{
				bool flag6 = iconType == 1;
				if (flag6)
				{
					DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width / 2f - 7f, rect.y + 6f, 14f, 9f), color3, true, ScaleMode.StretchToFill);
					DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width / 2f - 7f, rect.y + 4f, 6f, 2f), color3, true, ScaleMode.StretchToFill);
					DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width / 2f - 5f, rect.y + 8f, 10f, 5f), color, true, ScaleMode.StretchToFill);
				}
				else
				{
					bool flag7 = iconType == 2;
					if (flag7)
					{
						DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width / 2f - 6f, rect.y + 5f, 12f, 2f), color3, true, ScaleMode.StretchToFill);
						DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width / 2f - 6f, rect.y + 9f, 12f, 2f), color3, true, ScaleMode.StretchToFill);
						DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width / 2f - 6f, rect.y + 13f, 12f, 2f), color3, true, ScaleMode.StretchToFill);
					}
				}
			}
			bool flag8 = rect.Contains(Event.current.mousePosition);
			if (flag8)
			{
				string text = "";
				bool flag9 = iconType == 0;
				if (flag9)
				{
					text = "Save configuration";
				}
				else
				{
					bool flag10 = iconType == 1;
					if (flag10)
					{
						text = "Load configuration";
					}
					else
					{
						bool flag11 = iconType == 2;
						if (flag11)
						{
							text = "Configuration folder";
						}
					}
				}
				bool flag12 = !string.IsNullOrEmpty(text);
				if (flag12)
				{
					DqNh7bzS0xEILWgxFJA4tpJpp.tooltips.Add(new ValueTuple<Rect, string>(new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y + 20f * GraphicsSettings.userInterfaceScale, 600f, 30f), text));
				}
			}
			bool flag13 = rect.Contains(Event.current.mousePosition) && num <= 0.5f;
			bool flag14 = flag13;
			if (flag14)
			{
				num += Mathf.Max(Mathf.Min(Time.deltaTime * 3.8f, 0.5f - (num + Time.deltaTime * 3.8f)), 0f);
			}
			else
			{
				num -= Time.deltaTime * 4.5f;
			}
			num = Mathf.Clamp(num, 0f, (num > 0.5f) ? 1f : 0.5f);
		}
		Vector2 vector = GUIUtility.GUIToScreenPoint(new Vector2(rect.x, rect.y));
		bool flag15 = rect.Contains(Event.current.mousePosition) && Input.GetMouseButtonDown(0) && Event.current.type == EventType.MouseDown && (!checkEnum || DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj == null || !DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.Contains(new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y)));
		bool flag16 = flag15 && DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + 140f < vector.x && DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + 80f < (float)Screen.height - vector.y;
		bool flag17 = flag16;
		if (flag17)
		{
			DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = null;
			num = 1f;
		}
		DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr[label] = num;
		return flag15;
	}

	// Token: 0x06000374 RID: 884 RVA: 0x0003408C File Offset: 0x0003228C
	public static bool DVkWLbfI0YmUX0p9Ex8l2OuXv(string label, int width = -1, bool checkEnum = true, string tooltip = null)
	{
		bool flag = !string.IsNullOrEmpty(DrysTRTjdLdFqu5GJBDif6AoV.featureSearchText) && !label.ToLower().Contains(DrysTRTjdLdFqu5GJBDif6AoV.featureSearchText.ToLower());
		bool flag2;
		if (flag)
		{
			flag2 = false;
		}
		else
		{
			Rect rect = GUILayoutUtility.GetRect((float)width, 20f);
			float num;
			bool flag3 = !DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.TryGetValue(label, out num);
			bool flag4 = flag3;
			if (flag4)
			{
				num = 0f;
				DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.Add(label, 0f);
			}
			bool flag5 = Event.current.type != EventType.Repaint;
			bool flag6 = !flag5;
			if (flag6)
			{
				byte b = (byte)(25f + 35f * num);
				Color32 color = new Color32(b, b, (byte)((float)b + 5f * num), byte.MaxValue);
				Color32 color2 = ((num > 0f) ? DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor((byte)(100f + 155f * num)) : new Color32(50, 50, 52, byte.MaxValue));
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 1f, rect.y + 1f, rect.width - 2f, rect.height - 2f), color, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, rect.width, 1f), color2, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + rect.height - 1f, rect.width, 1f), color2, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, 1f, rect.height), color2, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 1f, rect.y, 1f, rect.height), color2, true, ScaleMode.StretchToFill);
				GUI.Label(new Rect(rect.x + 20f, rect.y, rect.width - 40f, rect.height), label, DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2);
				bool flag7 = !string.IsNullOrEmpty(tooltip) && rect.Contains(Event.current.mousePosition);
				if (flag7)
				{
					DqNh7bzS0xEILWgxFJA4tpJpp.tooltips.Add(new ValueTuple<Rect, string>(new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y + 20f * GraphicsSettings.userInterfaceScale, 600f, 30f), tooltip));
				}
				bool flag8 = rect.Contains(Event.current.mousePosition) && num <= 0.5f;
				bool flag9 = flag8;
				if (flag9)
				{
					num += Mathf.Max(Mathf.Min(Time.deltaTime * 3.8f, 0.5f - (num + Time.deltaTime * 3.8f)), 0f);
				}
				else
				{
					num -= Time.deltaTime * 4.5f;
				}
				num = Mathf.Clamp(num, 0f, (num > 0.5f) ? 1f : 0.5f);
			}
			Vector2 vector = GUIUtility.GUIToScreenPoint(new Vector2(rect.x, rect.y));
			bool flag10 = rect.Contains(Event.current.mousePosition) && Input.GetMouseButtonDown(0) && Event.current.type == EventType.MouseDown && (!checkEnum || DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj == null || !DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.Contains(new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y)));
			bool flag11 = flag10 && DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + 140f < vector.x && DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + 80f < (float)Screen.height - vector.y;
			bool flag12 = flag11;
			if (flag12)
			{
				DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = null;
				num = 1f;
			}
			DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr[label] = num;
			flag2 = flag10;
		}
		return flag2;
	}

	// Token: 0x06000375 RID: 885 RVA: 0x000344AC File Offset: 0x000326AC
	public static bool D2UPBO4RKVK2FGU73V1EA74Z1(Rect rect, string label, int width = -1, bool checkEnum = true)
	{
		float num;
		bool flag = !DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.TryGetValue(label, out num);
		bool flag2 = flag;
		if (flag2)
		{
			num = 0f;
			DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.Add(label, 0f);
		}
		bool flag3 = Event.current.type != EventType.Repaint;
		bool flag4 = !flag3;
		if (flag4)
		{
			byte b = (byte)(25f + 35f * num);
			Color32 color = new Color32(b, b, (byte)((float)b + 5f * num), byte.MaxValue);
			Color32 color2 = ((num > 0f) ? DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor((byte)(100f + 155f * num)) : new Color32(50, 50, 52, byte.MaxValue));
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 1f, rect.y + 1f, rect.width - 2f, rect.height - 2f), color, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, rect.width, 1f), color2, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + rect.height - 1f, rect.width, 1f), color2, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, 1f, rect.height), color2, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 1f, rect.y, 1f, rect.height), color2, true, ScaleMode.StretchToFill);
			GUI.Label(new Rect(rect.x + 20f, rect.y, rect.width - 40f, rect.height), label, DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2);
			bool flag5 = rect.Contains(Event.current.mousePosition) && num <= 0.5f;
			bool flag6 = flag5;
			if (flag6)
			{
				num += Mathf.Max(Mathf.Min(Time.deltaTime * 3.8f, 0.5f - (num + Time.deltaTime * 3.8f)), 0f);
			}
			else
			{
				num -= Time.deltaTime * 4.5f;
			}
			num = Mathf.Clamp(num, 0f, (num > 0.5f) ? 1f : 0.5f);
		}
		Vector2 vector = GUIUtility.GUIToScreenPoint(new Vector2(rect.x, rect.y));
		bool flag7 = rect.Contains(Event.current.mousePosition) && Input.GetMouseButtonDown(0) && Event.current.type == EventType.MouseDown && (!checkEnum || DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj == null || !DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.Contains(new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y)));
		bool flag8 = flag7 && DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + 140f < vector.x && DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + 80f < (float)Screen.height - vector.y;
		bool flag9 = flag8;
		if (flag9)
		{
			DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = null;
			num = 1f;
		}
		DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr[label] = num;
		return flag7;
	}

	// Token: 0x06000376 RID: 886 RVA: 0x0003481C File Offset: 0x00032A1C
	public static bool DNV6T8ihER1VcDiXXwY3S4BTY(string label, Color32 color, int width = -1, bool checkEnum = true)
	{
		Rect rect = GUILayoutUtility.GetRect((float)width, 24f);
		float num;
		bool flag = !DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.TryGetValue(label, out num);
		bool flag2 = flag;
		if (flag2)
		{
			num = 0f;
			DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.Add(label, 0f);
		}
		bool flag3 = Event.current.type != EventType.Repaint;
		bool flag4 = !flag3;
		if (flag4)
		{
			byte b = (byte)(25f + 35f * num);
			Color32 color2 = new Color32(b, b, (byte)((float)b + 5f * num), byte.MaxValue);
			Color32 color3 = ((num > 0f) ? DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor((byte)(100f + 155f * num)) : new Color32(50, 50, 52, byte.MaxValue));
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 1f, rect.y + 1f, rect.width - 2f, rect.height - 2f), color2, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, rect.width, 1f), color3, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + rect.height - 1f, rect.width, 1f), color3, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, 1f, rect.height), color3, true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 1f, rect.y, 1f, rect.height), color3, true, ScaleMode.StretchToFill);
			GUI.Label(new Rect(rect.x + 20f, rect.y + 2f, rect.width - 60f, rect.height), label, DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2);
			bool flag5 = rect.Contains(Event.current.mousePosition) && num <= 0.5f;
			bool flag6 = flag5;
			if (flag6)
			{
				num += Time.deltaTime * 3.8f;
			}
			else
			{
				num -= Time.deltaTime * 4.5f;
			}
			num = Mathf.Clamp(num, 0f, (num > 0.5f) ? 1f : 0.5f);
		}
		Vector2 vector = GUIUtility.GUIToScreenPoint(new Vector2(rect.x, rect.y));
		bool flag7 = rect.Contains(Event.current.mousePosition) && Input.GetMouseButtonDown(0) && Event.current.type == EventType.MouseDown && (!checkEnum || DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj == null || !DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.Contains(new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y)));
		bool flag8 = flag7 && DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + 140f < vector.x && DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + 80f < (float)Screen.height - vector.y;
		bool flag9 = flag8;
		if (flag9)
		{
			DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = null;
			num = 1f;
		}
		DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr[label] = num;
		Rect rect2 = new Rect(rect.x + rect.width - 32f, rect.y + 4f, 16f, 16f);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x - 1f, rect2.y - 1f, rect2.width + 2f, rect2.height + 2f), new Color32(40, 40, 40, byte.MaxValue), true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect2, color, true, ScaleMode.StretchToFill);
		Color32 color4 = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, (byte)(80f + num * 100f));
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, rect2.width, 1f), color4, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, 1f, rect2.height), color4, true, ScaleMode.StretchToFill);
		Color32 color5 = new Color32(0, 0, 0, (byte)(100f + num * 50f));
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y + rect2.height - 1f, rect2.width, 1f), color5, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x + rect2.width - 1f, rect2.y, 1f, rect2.height), color5, true, ScaleMode.StretchToFill);
		return flag7;
	}

	// Token: 0x06000377 RID: 887 RVA: 0x00034D0C File Offset: 0x00032F0C
	public static void DLBdImqWGORG4TqIutTr7sLBd<T>(string name, DoBBXnQ70t7Pdvzomc3O1yC2C<T> storage, int width = -1, string valueFormat = "")
	{
		Rect rect = GUILayoutUtility.GetRect((float)width, 40f);
		width = ((width == -1) ? ((int)DrysTRTjdLdFqu5GJBDif6AoV.Dtib43oq6yhDjtGzggdWk0MwM.width) : width);
		GUI.Label(rect, name);
		Color32 color = ((DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb == storage || rect.Contains(Event.current.mousePosition)) ? DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue) : new Color32(50, 50, 52, byte.MaxValue));
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 1f, rect.y + 15f, rect.width - 2f, 22f), new Color32((byte)(28f + 14f * storage.holdTime), (byte)(28f + 14f * storage.holdTime), (byte)(28f + 14f * storage.holdTime), byte.MaxValue), true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 1f, rect.y + 14f, rect.width - 2f, 1f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 1f, rect.y + 37f, rect.width - 2f, 1f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + 15f, 1f, 22f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 1f, rect.y + 15f, 1f, 22f), color, true, ScaleMode.StretchToFill);
		GUI.Label(new Rect(rect.x + 20f, rect.y + 15f, rect.width - 20f, 22f), string.IsNullOrEmpty(valueFormat) ? storage._enum.ToString() : valueFormat, DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2);
		bool flag = Event.current.type == EventType.Repaint;
		bool flag2 = flag;
		if (flag2)
		{
			bool flag3 = DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb == storage;
			bool flag4 = flag3;
			if (flag4)
			{
				storage.holdTime = 1f;
			}
			else
			{
				bool flag5 = rect.Contains(Event.current.mousePosition);
				bool flag6 = flag5;
				if (flag6)
				{
					storage.holdTime += Time.deltaTime * 4f;
				}
				else
				{
					storage.holdTime -= Time.deltaTime * 5.2f;
				}
			}
			storage.holdTime = Mathf.Clamp01(storage.holdTime);
			Vector2 vector = GUIUtility.GUIToScreenPoint(new Vector2(rect.x, rect.y));
			bool flag7 = Input.GetMouseButtonDown(0) && rect.Contains(Event.current.mousePosition) && (DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj == null || !DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.Contains(new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y)));
			bool flag8 = flag7;
			if (flag8)
			{
				bool flag9 = DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb == storage;
				bool flag10 = flag9;
				if (flag10)
				{
					DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = null;
					DL3tNdrQzY7o8FV1oIOKODOLQ.De30FqjVHC03X81IY6Y3eTNN8 = true;
				}
				else
				{
					DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = storage;
				}
			}
		}
		bool flag11 = DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb == storage;
		bool flag12 = flag11;
		if (flag12)
		{
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 24f, rect.y + 27f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 23f, rect.y + 26f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 22f, rect.y + 25f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 21f, rect.y + 24f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 20f, rect.y + 23f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 19f, rect.y + 24f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 18f, rect.y + 25f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 17f, rect.y + 26f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 16f, rect.y + 27f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DcjNGFQPtrDz0AIE1G6X5PWCC = storage.enumValues.Length * 20;
			bool flag13 = Event.current.type == EventType.Repaint;
			bool flag14 = flag13;
			if (flag14)
			{
				DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P = new Rect(GUIUtility.GUIToScreenPoint(new Vector2(rect.x, rect.y)).x, GUIUtility.GUIToScreenPoint(new Vector2(rect.x, rect.y)).y + 40f, (float)width, (float)DrysTRTjdLdFqu5GJBDif6AoV.DcjNGFQPtrDz0AIE1G6X5PWCC);
			}
			DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj = delegate
			{
				Rect rect2 = new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.x + 2f, DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.y + 2f, DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.width - 4f, DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.height - 4f);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect2, new Color32(20, 20, 22, byte.MaxValue), true, ScaleMode.StretchToFill);
				Color32 accentColor = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, rect2.width, 1f), accentColor, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y + rect2.height - 1f, rect2.width, 1f), accentColor, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, 1f, rect2.height), accentColor, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x + rect2.width - 1f, rect2.y, 1f, rect2.height), accentColor, true, ScaleMode.StretchToFill);
				int num = 0;
				foreach (object obj in storage.enumValues)
				{
					bool flag15 = DrysTRTjdLdFqu5GJBDif6AoV.D2UPBO4RKVK2FGU73V1EA74Z1(new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.x + 2f, DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.y + 2f + (float)(num * 20), DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.width - 4f, 20f), obj.ToString(), -1, false);
					bool flag16 = flag15;
					if (flag16)
					{
						storage._enum = (T)((object)obj);
						DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = null;
					}
					num++;
				}
			};
		}
		else
		{
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 24f, rect.y + 23f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 23f, rect.y + 24f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 22f, rect.y + 25f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 21f, rect.y + 26f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 20f, rect.y + 27f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 19f, rect.y + 26f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 18f, rect.y + 25f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 17f, rect.y + 24f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 16f, rect.y + 23f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
		}
	}

	// Token: 0x06000378 RID: 888 RVA: 0x00035694 File Offset: 0x00033894
	public static void DGp1eZv16qTIxmz4NvgI0zitc(string name, D4WIZXAOkc83nheh8yO4dQDGh storage, int width = -1, string valueFormat = "")
	{
		Rect rect = GUILayoutUtility.GetRect((float)width, 40f);
		width = ((width == -1) ? ((int)DrysTRTjdLdFqu5GJBDif6AoV.Dtib43oq6yhDjtGzggdWk0MwM.width) : width);
		GUI.Label(rect, name);
		Color32 color = ((DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb == storage || rect.Contains(Event.current.mousePosition)) ? DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue) : new Color32(50, 50, 52, byte.MaxValue));
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 1f, rect.y + 15f, rect.width - 2f, 22f), new Color32((byte)(28f + 14f * storage.DxIpEfedfxbxnHukfU2u3hfFX), (byte)(28f + 14f * storage.DxIpEfedfxbxnHukfU2u3hfFX), (byte)(28f + 14f * storage.DxIpEfedfxbxnHukfU2u3hfFX), byte.MaxValue), true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + 14f, rect.width, 1f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + 37f, rect.width, 1f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + 15f, 1f, 22f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 1f, rect.y + 15f, 1f, 22f), color, true, ScaleMode.StretchToFill);
		GUI.Label(new Rect(rect.x + 20f, rect.y + 15f, rect.width - 20f, 22f), string.IsNullOrEmpty(valueFormat) ? storage.DrFUpxbK1PdxnzRXQmVj0C6Kt.ToString() : valueFormat, DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2);
		bool flag = Event.current.type == EventType.Repaint;
		bool flag2 = flag;
		if (flag2)
		{
			bool flag3 = DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb == storage;
			bool flag4 = flag3;
			if (flag4)
			{
				storage.DxIpEfedfxbxnHukfU2u3hfFX = 1f;
			}
			else
			{
				bool flag5 = rect.Contains(Event.current.mousePosition);
				bool flag6 = flag5;
				if (flag6)
				{
					storage.DxIpEfedfxbxnHukfU2u3hfFX += Time.deltaTime * 4f;
				}
				else
				{
					storage.DxIpEfedfxbxnHukfU2u3hfFX -= Time.deltaTime * 5.2f;
				}
			}
			storage.DxIpEfedfxbxnHukfU2u3hfFX = Mathf.Clamp01(storage.DxIpEfedfxbxnHukfU2u3hfFX);
			Vector2 vector = GUIUtility.GUIToScreenPoint(new Vector2(rect.x, rect.y));
			bool flag7 = Input.GetMouseButtonDown(0) && rect.Contains(Event.current.mousePosition);
			bool flag8 = flag7;
			if (flag8)
			{
				bool flag9 = DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb == storage;
				bool flag10 = flag9;
				if (flag10)
				{
					DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = null;
					DL3tNdrQzY7o8FV1oIOKODOLQ.De30FqjVHC03X81IY6Y3eTNN8 = true;
				}
				else
				{
					DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = storage;
				}
			}
		}
		bool flag11 = DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb == storage;
		bool flag12 = flag11;
		if (flag12)
		{
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 24f, rect.y + 27f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 23f, rect.y + 26f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 22f, rect.y + 25f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 21f, rect.y + 24f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 20f, rect.y + 23f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 19f, rect.y + 24f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 18f, rect.y + 25f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 17f, rect.y + 26f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 16f, rect.y + 27f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DcjNGFQPtrDz0AIE1G6X5PWCC = storage.DCNlJn4jn9Smpgcg1kJ9hM842.Length * 20;
			bool flag13 = Event.current.type == EventType.Repaint;
			bool flag14 = flag13;
			if (flag14)
			{
				DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P = new Rect(GUIUtility.GUIToScreenPoint(new Vector2(rect.x, rect.y)).x, GUIUtility.GUIToScreenPoint(new Vector2(rect.x, rect.y)).y + 40f, (float)width, (float)DrysTRTjdLdFqu5GJBDif6AoV.DcjNGFQPtrDz0AIE1G6X5PWCC);
			}
			DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj = delegate
			{
				Rect rect2 = new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.x + 2f, DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.y + 2f, DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.width - 4f, DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.height - 4f);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect2, new Color32(20, 20, 22, byte.MaxValue), true, ScaleMode.StretchToFill);
				Color32 accentColor = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, rect2.width, 1f), accentColor, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y + rect2.height - 1f, rect2.width, 1f), accentColor, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, 1f, rect2.height), accentColor, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x + rect2.width - 1f, rect2.y, 1f, rect2.height), accentColor, true, ScaleMode.StretchToFill);
				int num = 0;
				foreach (object obj in storage.DCNlJn4jn9Smpgcg1kJ9hM842)
				{
					bool flag15 = DrysTRTjdLdFqu5GJBDif6AoV.D2UPBO4RKVK2FGU73V1EA74Z1(new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.x + 2f, DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.y + 2f + (float)(num * 20), DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.width - 4f, 20f), obj.ToString(), -1, false);
					bool flag16 = flag15;
					if (flag16)
					{
						storage.DrFUpxbK1PdxnzRXQmVj0C6Kt = obj;
						DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = null;
					}
					num++;
				}
			};
		}
		else
		{
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 24f, rect.y + 23f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 23f, rect.y + 24f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 22f, rect.y + 25f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 21f, rect.y + 26f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 20f, rect.y + 27f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 19f, rect.y + 26f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 18f, rect.y + 25f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 17f, rect.y + 24f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 16f, rect.y + 23f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
		}
	}

	// Token: 0x06000379 RID: 889 RVA: 0x00035FC8 File Offset: 0x000341C8
	public static void DmqgtfHnAl6f6pBDjswVYDqXB(string name, DyPObwbd4zggJ8n8ALWx6A5Dn storage, int width = -1, string valueFormat = "")
	{
		Rect rect = GUILayoutUtility.GetRect((float)width, 40f);
		width = ((width == -1) ? ((int)DrysTRTjdLdFqu5GJBDif6AoV.Dtib43oq6yhDjtGzggdWk0MwM.width) : width);
		GUI.Label(rect, name);
		Color32 color = ((DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb == storage || rect.Contains(Event.current.mousePosition)) ? DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue) : new Color32(50, 50, 52, byte.MaxValue));
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + 1f, rect.y + 15f, rect.width - 2f, 22f), new Color32((byte)(28f + 14f * storage.DkAl7Zp66bMdIOxeWW79aY5G5), (byte)(28f + 14f * storage.DkAl7Zp66bMdIOxeWW79aY5G5), (byte)(28f + 14f * storage.DkAl7Zp66bMdIOxeWW79aY5G5), byte.MaxValue), true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + 14f, rect.width, 1f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + 37f, rect.width, 1f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + 15f, 1f, 22f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 1f, rect.y + 15f, 1f, 22f), color, true, ScaleMode.StretchToFill);
		GUI.Label(new Rect(rect.x + 20f, rect.y + 15f, rect.width - 20f, 22f), string.IsNullOrEmpty(valueFormat) ? storage.ToString() : valueFormat, DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2);
		bool flag = Event.current.type == EventType.Repaint;
		bool flag2 = flag;
		if (flag2)
		{
			bool flag3 = DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb == storage;
			bool flag4 = flag3;
			if (flag4)
			{
				storage.DkAl7Zp66bMdIOxeWW79aY5G5 = 1f;
			}
			else
			{
				bool flag5 = rect.Contains(Event.current.mousePosition);
				bool flag6 = flag5;
				if (flag6)
				{
					storage.DkAl7Zp66bMdIOxeWW79aY5G5 += Time.deltaTime * 4f;
				}
				else
				{
					storage.DkAl7Zp66bMdIOxeWW79aY5G5 -= Time.deltaTime * 5.2f;
				}
			}
			storage.DkAl7Zp66bMdIOxeWW79aY5G5 = Mathf.Clamp01(storage.DkAl7Zp66bMdIOxeWW79aY5G5);
			bool flag7 = Input.GetMouseButtonDown(0) && rect.Contains(Event.current.mousePosition) && (DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj == null || !DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.Contains(new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y)));
			bool flag8 = flag7;
			if (flag8)
			{
				bool flag9 = DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb == storage;
				bool flag10 = flag9;
				if (flag10)
				{
					DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = null;
				}
				else
				{
					DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = storage;
				}
			}
		}
		bool flag11 = DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb == storage;
		bool flag12 = flag11;
		if (flag12)
		{
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 24f, rect.y + 27f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 23f, rect.y + 26f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 22f, rect.y + 25f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 21f, rect.y + 24f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 20f, rect.y + 23f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 19f, rect.y + 24f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 18f, rect.y + 25f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 17f, rect.y + 26f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 16f, rect.y + 27f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DcjNGFQPtrDz0AIE1G6X5PWCC = storage.DP2ftY5lfPrZHzQcVaAIkgxQS.Length * 20;
			bool flag13 = Event.current.type == EventType.Repaint;
			bool flag14 = flag13;
			if (flag14)
			{
				DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P = new Rect(GUIUtility.GUIToScreenPoint(new Vector2(rect.x, rect.y)).x, GUIUtility.GUIToScreenPoint(new Vector2(rect.x, rect.y)).y + 40f, (float)width, (float)DrysTRTjdLdFqu5GJBDif6AoV.DcjNGFQPtrDz0AIE1G6X5PWCC);
			}
			DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj = delegate
			{
				Rect rect2 = new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.x + 2f, DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.y + 2f, DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.width - 4f, DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.height - 4f);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect2, new Color32(20, 20, 22, byte.MaxValue), true, ScaleMode.StretchToFill);
				Color32 accentColor = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, rect2.width, 1f), accentColor, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y + rect2.height - 1f, rect2.width, 1f), accentColor, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, 1f, rect2.height), accentColor, true, ScaleMode.StretchToFill);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x + rect2.width - 1f, rect2.y, 1f, rect2.height), accentColor, true, ScaleMode.StretchToFill);
				int num = 0;
				foreach (string text in storage.DP2ftY5lfPrZHzQcVaAIkgxQS)
				{
					bool flag15 = DrysTRTjdLdFqu5GJBDif6AoV.D2UPBO4RKVK2FGU73V1EA74Z1(new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.x + 2f, DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.y + 2f + (float)(num * 20), DL3tNdrQzY7o8FV1oIOKODOLQ.D8wZcf2MYCSUsH86wjtXOE64P.width - 4f, 20f), text.ToString(), -1, false);
					bool flag16 = flag15;
					if (flag16)
					{
						storage.DvZuyjYgPRxEKoiET9bNBFdF0 = text;
						DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = null;
					}
					num++;
				}
			};
		}
		else
		{
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 24f, rect.y + 23f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 23f, rect.y + 24f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 22f, rect.y + 25f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 21f, rect.y + 26f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 20f, rect.y + 27f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 19f, rect.y + 26f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 18f, rect.y + 25f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 17f, rect.y + 24f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 16f, rect.y + 23f, 1f, 1f), new Color32(91, 91, 91, byte.MaxValue), true, ScaleMode.StretchToFill);
		}
	}

	// Token: 0x0600037A RID: 890 RVA: 0x0003690C File Offset: 0x00034B0C
	public static float Df5jhq5GIflV7BcEcXSpROI9c(float val)
	{
		bool flag = val % 1f != 0f;
		float num;
		try
		{
			num = float.Parse(GUILayout.TextField(val.ToString() + (flag ? "" : ",0"), Array.Empty<GUILayoutOption>()));
		}
		catch
		{
			num = 0f;
		}
		return num;
	}

	// Token: 0x0600037B RID: 891 RVA: 0x0003697C File Offset: 0x00034B7C
	public static int DowY0MgMwWhJmIR03EMAPzWvW(int val)
	{
		int num;
		try
		{
			num = int.Parse(GUILayout.TextField(val.ToString(), Array.Empty<GUILayoutOption>()));
		}
		catch
		{
			num = 0;
		}
		return num;
	}

	// Token: 0x0600037C RID: 892 RVA: 0x000369C4 File Offset: 0x00034BC4
	public static void DHrCGEPCcmccCepLXAl8eiVYb(Rect rect, Color32 color, int radius)
	{
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect, color, true, ScaleMode.StretchToFill);
	}

	// Token: 0x0600037D RID: 893 RVA: 0x000369D4 File Offset: 0x00034BD4
	public static void DY0N847JZ67cERKs2aQ4DAkwT(Rect rect, Color32 color, Color32 solidColor, int radius)
	{
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect, solidColor, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, rect.width, 1f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + rect.height - 1f, rect.width, 1f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, 1f, rect.height), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 1f, rect.y, 1f, rect.height), color, true, ScaleMode.StretchToFill);
	}

	// Token: 0x0600037E RID: 894 RVA: 0x00036AA8 File Offset: 0x00034CA8
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "ClearUIEffects")]
	public static void Dc5G5b2tFddCQj0OX40sUl3g0()
	{
		GameObjectPoolDictionary gameObjectPoolDictionary = D08iy2XFQpUQteL0XRzAbg2IE.D6WfOu184mT2tP3LWMqZEzUjd<GameObjectPoolDictionary>(typeof(EffectManager), "pool", null);
		EffectManager effectManager = D08iy2XFQpUQteL0XRzAbg2IE.D6WfOu184mT2tP3LWMqZEzUjd<EffectManager>(typeof(EffectManager), "manager", null);
		gameObjectPoolDictionary.DestroyAll();
		D08iy2XFQpUQteL0XRzAbg2IE.DJRjdxfvw98Ox0FYU1cSOKdGb(typeof(EffectManager), "destroyAllDebris", effectManager, Array.Empty<object>());
		D08iy2XFQpUQteL0XRzAbg2IE.DJRjdxfvw98Ox0FYU1cSOKdGb(typeof(EffectManager), "destroyAllUI", effectManager, Array.Empty<object>());
	}

	// Token: 0x0600037F RID: 895 RVA: 0x00036B20 File Offset: 0x00034D20
	public static void DrawLine(Vector2 start, Vector2 end, Color color, float width)
	{
		Vector2 vector = end - start;
		float magnitude = vector.magnitude;
		bool flag = magnitude < 0.001f;
		if (!flag)
		{
			vector.Normalize();
			Vector2 vector2 = new Vector2(-vector.y, vector.x) * width * 0.5f;
			Vector3[] array = new Vector3[]
			{
				start + vector2,
				end + vector2,
				end - vector2,
				start - vector2
			};
			Color32 color2 = new Color32((byte)(color.r * 255f), (byte)(color.g * 255f), (byte)(color.b * 255f), (byte)(color.a * 255f));
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(array[0].x, array[0].y, array[1].x - array[0].x, array[1].y - array[0].y), color2, false, ScaleMode.StretchToFill);
		}
	}

	// Token: 0x040003C8 RID: 968
	public static string featureSearchText = "";

	// Token: 0x040003C9 RID: 969
	private static Texture2D m_AnimatedBgTexture;

	// Token: 0x040003CA RID: 970
	private static Texture2D m_WatermarkBgTexture;

	// Token: 0x040003CB RID: 971
	public static Rect Dtib43oq6yhDjtGzggdWk0MwM = Rect.zero;

	// Token: 0x040003CC RID: 972
	public static Dictionary<string, float> DHpJyu9sUAYqubcV6OABfIgMr = new Dictionary<string, float>();

	// Token: 0x040003CD RID: 973
	public static Dictionary<Type, D4WIZXAOkc83nheh8yO4dQDGh> DY94NDz4ZnJCIslCITVEIsblJ = new Dictionary<Type, D4WIZXAOkc83nheh8yO4dQDGh>();

	// Token: 0x040003CE RID: 974
	private static int DQZ3CYBYJ8ebKUT3PfcxTJ3oX = 0;

	// Token: 0x040003CF RID: 975
	private static int DcjNGFQPtrDz0AIE1G6X5PWCC = 0;
}
