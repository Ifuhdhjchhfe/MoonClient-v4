using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200006B RID: 107
public static class DhNbDL0xpxhG1wADC5uXvFshQ
{
	// Token: 0x06000205 RID: 517 RVA: 0x0001AA38 File Offset: 0x00018C38
	public static void DGvQBjAmV269LL7PI5RfSNmW9()
	{
		DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc = (D5l46jlssr4TRAzUSXzLj0uqu.DCXziB0kIOezVeYnpla5czLXA ? DZW7dpbH5Qs7H7R6KJHZs0PUu.DSnFwyDSJiRcayfNoTM5EALne : ((MainCamera.instance != null) ? MainCamera.instance : Camera.current));
		bool flag = DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc != null;
		bool flag2 = flag;
		if (flag2)
		{
			DhNbDL0xpxhG1wADC5uXvFshQ.Dvnc7NMv3T5T0nPfgcO28KXhC = DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.worldToCameraMatrix;
			DhNbDL0xpxhG1wADC5uXvFshQ.D0dFeYUac5o0ycmUFaeSj1J46 = DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.projectionMatrix;
		}
	}

	// Token: 0x06000206 RID: 518 RVA: 0x0001AAA4 File Offset: 0x00018CA4
	public static bool D3WhXWT4aHQw3gPglMy00NwQA(DwIoOmLGoIyIvOm9z0SHgcarr category, GameObject gameObject)
	{
		return DhNbDL0xpxhG1wADC5uXvFshQ.DwpJxne4GhmPMzm9SCkFlnzUj(category, gameObject.transform.position) && gameObject.transform.position.DGxZdvjodtrVw5BNkkaZ9SGFr();
	}

	// Token: 0x06000207 RID: 519 RVA: 0x0001AADC File Offset: 0x00018CDC
	public static bool DLq2Tujd0yJ0PMbCLZjzQX6TK(DwIoOmLGoIyIvOm9z0SHgcarr category, GameObject gameObject)
	{
		return DhNbDL0xpxhG1wADC5uXvFshQ.DwpJxne4GhmPMzm9SCkFlnzUj(category, gameObject.transform.position);
	}

	// Token: 0x06000208 RID: 520 RVA: 0x0001AB00 File Offset: 0x00018D00
	public static bool DwpJxne4GhmPMzm9SCkFlnzUj(DwIoOmLGoIyIvOm9z0SHgcarr category, Vector3 position)
	{
		return !category.DAvrKLDCvmAu7NRTbchmgnI2B || (Player.player.transform.position - position).sqrMagnitude <= (float)(category.DJBq8HET3vb5Y6umbwtysjB5v * category.DJBq8HET3vb5Y6umbwtysjB5v);
	}

	// Token: 0x06000209 RID: 521 RVA: 0x0001AB50 File Offset: 0x00018D50
	public static void DF7Zy7a96hJm30pZcSYFymNVa(Vector3 worldPoint, string text, Color cl, int fontSize = 12)
	{
		text = string.Format(text, (int)DmErKmxWRjHNSG8p8mCUQIUbM.DJt3hAqh4ZXULdGluWyDLh2hJ(Player.player.transform.position, worldPoint));
		Vector3 vector = worldPoint.DEfdLut9iGJvTAJNGrXHRFglR();
		Rect rect = new Rect(vector.x - 160f, vector.y - 40f, 320f, 80f);
		DHTB5RKsHUihFrfj9ewuLh1f9.DSqLh3shLXYAnX4d0AcIljoVC.fontSize = fontSize;
		DHTB5RKsHUihFrfj9ewuLh1f9.DSqLh3shLXYAnX4d0AcIljoVC.normal.textColor = cl;
		GUI.Label(rect, text, DHTB5RKsHUihFrfj9ewuLh1f9.DSqLh3shLXYAnX4d0AcIljoVC);
	}

	// Token: 0x0600020A RID: 522 RVA: 0x0001ABE0 File Offset: 0x00018DE0
	public static void D9OeOuZLd0xdik23NP8Gg1AMl(DwIoOmLGoIyIvOm9z0SHgcarr category, Vector3 worldPoint, DEdXmxw1kVJg8vJ4vGc2Ebkqm ftd, Color c, Color oc)
	{
		foreach (DRTZ0MPdBhZh1V5PmbtgwG0pX drtz0MPdBhZh1V5PmbtgwG0pX in category.DFCShSexFkCl8bbf0IH0bNRLZ)
		{
			bool flag = !drtz0MPdBhZh1V5PmbtgwG0pX.Dipo7alXhWGyUN5HTO5CUfNnm;
			bool flag2 = !flag;
			if (flag2)
			{
				string text = drtz0MPdBhZh1V5PmbtgwG0pX.DCxCJp6yyGw68XtIKAu2wuoEn;
				bool flag3 = ftd != null;
				bool flag4 = flag3;
				if (flag4)
				{
					try
					{
						ftd(ref text);
					}
					catch
					{
					}
				}
				int num = (int)DmErKmxWRjHNSG8p8mCUQIUbM.DJt3hAqh4ZXULdGluWyDLh2hJ(Player.player.transform.position, worldPoint);
				text = string.Format(text, num);
				bool d9N2d7gO9JnbsDwXr0pIcoOOf = drtz0MPdBhZh1V5PmbtgwG0pX.D9N2d7gO9JnbsDwXr0pIcoOOf;
				bool flag5 = d9N2d7gO9JnbsDwXr0pIcoOOf;
				if (flag5)
				{
					text = text.Replace("\\n", Environment.NewLine);
				}
				bool flag6 = drtz0MPdBhZh1V5PmbtgwG0pX.Dq0ZCE1cqn96fzZ7FklAyN1jq == DVeWYqH4HEAYXL5Vu3HrmvSnF.UpperCase;
				bool flag7 = flag6;
				if (flag7)
				{
					text = text.ToUpper();
				}
				else
				{
					bool flag8 = drtz0MPdBhZh1V5PmbtgwG0pX.Dq0ZCE1cqn96fzZ7FklAyN1jq == DVeWYqH4HEAYXL5Vu3HrmvSnF.LowerCase;
					bool flag9 = flag8;
					if (flag9)
					{
						text = text.ToLower();
					}
				}
				worldPoint += drtz0MPdBhZh1V5PmbtgwG0pX.D6ubYZcOfRdbBHTQPmKwewPMs;
				Vector3 vector = worldPoint.DEfdLut9iGJvTAJNGrXHRFglR();
				worldPoint -= drtz0MPdBhZh1V5PmbtgwG0pX.D6ubYZcOfRdbBHTQPmKwewPMs;
				bool flag10 = !drtz0MPdBhZh1V5PmbtgwG0pX.D2Dz7Uaa1ngijd9u4MUUh6Ewj;
				bool flag11 = flag10;
				if (flag11)
				{
					category.D0x2CpNPv5G0vo17K1zILyhFc.fontSize = drtz0MPdBhZh1V5PmbtgwG0pX.Dx7ud2LZjVAh5oMukhPNbVcbP;
				}
				else
				{
					category.D0x2CpNPv5G0vo17K1zILyhFc.fontSize = drtz0MPdBhZh1V5PmbtgwG0pX.D1I0p7yzFiMIXRGqBXSuLvKlV - (int)((float)(drtz0MPdBhZh1V5PmbtgwG0pX.D1I0p7yzFiMIXRGqBXSuLvKlV - drtz0MPdBhZh1V5PmbtgwG0pX.DswdRfsVN0euTerbxOJL1tw48) * Mathf.Clamp((float)(num - drtz0MPdBhZh1V5PmbtgwG0pX.DSJ0X51xLXKKUUKYvhr16s5IG) / (float)drtz0MPdBhZh1V5PmbtgwG0pX.DZK5LlgvCYoXx5YJxGq2R4UIC, 0f, 1f));
				}
				category.Dxn8NngmWnv3B0QlK16ladv8o.fontSize = category.D0x2CpNPv5G0vo17K1zILyhFc.fontSize;
				category.Dxn8NngmWnv3B0QlK16ladv8o.normal.textColor = oc;
				category.D0x2CpNPv5G0vo17K1zILyhFc.normal.textColor = (drtz0MPdBhZh1V5PmbtgwG0pX.DuK00g4qH3jQKRmilg39vTfHi ? c : (drtz0MPdBhZh1V5PmbtgwG0pX.Da5g52fxWsEDiZwsDNgSXZYVf.isGradient ? c : (Color)drtz0MPdBhZh1V5PmbtgwG0pX.Da5g52fxWsEDiZwsDNgSXZYVf.DkJGdJpvFP4j4uWN4CyFixyQ3));
				Rect rect = new Rect(vector.x - 160f, vector.y - 40f, 320f, 80f);
				rect.x += drtz0MPdBhZh1V5PmbtgwG0pX.DJxQE7ww0bdFY31yVKuBrFMXO.x;
				rect.y -= drtz0MPdBhZh1V5PmbtgwG0pX.DJxQE7ww0bdFY31yVKuBrFMXO.y;
				DHTB5RKsHUihFrfj9ewuLh1f9.DcCtNCaSVWm57cNorggPJBWVH.fontSize = drtz0MPdBhZh1V5PmbtgwG0pX.Dx7ud2LZjVAh5oMukhPNbVcbP;
				bool flag12 = drtz0MPdBhZh1V5PmbtgwG0pX.DmohNcisfE9XlQBxYIbs4iR1c > DcyOGWtOfXF1Fhr1GWr4wf6Ww.None;
				bool flag13 = flag12;
				if (flag13)
				{
					DhNbDL0xpxhG1wADC5uXvFshQ.D8fixfJEOQDWjgtsvRfrY3xsG(rect, text, drtz0MPdBhZh1V5PmbtgwG0pX.DmohNcisfE9XlQBxYIbs4iR1c, category.Dxn8NngmWnv3B0QlK16ladv8o, drtz0MPdBhZh1V5PmbtgwG0pX.DGpmNFnsk8OWC3s0A9mZGdzff);
				}
				GUI.Label(rect, text, category.D0x2CpNPv5G0vo17K1zILyhFc);
			}
		}
	}

	// Token: 0x0600020B RID: 523 RVA: 0x0001AEEC File Offset: 0x000190EC
	public static void Dp0paFUHkHaH4V1Pg9ZHsZmiQ(DwIoOmLGoIyIvOm9z0SHgcarr category, DRTZ0MPdBhZh1V5PmbtgwG0pX txto, string formattedText, Vector3 worldPoint, Color c, Color oc)
	{
		bool flag = !txto.Dipo7alXhWGyUN5HTO5CUfNnm;
		bool flag2 = !flag;
		if (flag2)
		{
			int num = (int)DmErKmxWRjHNSG8p8mCUQIUbM.DJt3hAqh4ZXULdGluWyDLh2hJ(Player.player.transform.position, worldPoint);
			string text = string.Format(formattedText, num);
			bool d9N2d7gO9JnbsDwXr0pIcoOOf = txto.D9N2d7gO9JnbsDwXr0pIcoOOf;
			bool flag3 = d9N2d7gO9JnbsDwXr0pIcoOOf;
			if (flag3)
			{
				text = text.Replace("\\n", Environment.NewLine);
			}
			bool flag4 = txto.Dq0ZCE1cqn96fzZ7FklAyN1jq == DVeWYqH4HEAYXL5Vu3HrmvSnF.UpperCase;
			bool flag5 = flag4;
			if (flag5)
			{
				text = text.ToUpper();
			}
			else
			{
				bool flag6 = txto.Dq0ZCE1cqn96fzZ7FklAyN1jq == DVeWYqH4HEAYXL5Vu3HrmvSnF.LowerCase;
				bool flag7 = flag6;
				if (flag7)
				{
					text = text.ToLower();
				}
			}
			worldPoint += txto.D6ubYZcOfRdbBHTQPmKwewPMs;
			Vector3 vector = worldPoint.DEfdLut9iGJvTAJNGrXHRFglR();
			worldPoint -= txto.D6ubYZcOfRdbBHTQPmKwewPMs;
			bool flag8 = !txto.D2Dz7Uaa1ngijd9u4MUUh6Ewj;
			bool flag9 = flag8;
			if (flag9)
			{
				category.D0x2CpNPv5G0vo17K1zILyhFc.fontSize = txto.Dx7ud2LZjVAh5oMukhPNbVcbP;
			}
			else
			{
				category.D0x2CpNPv5G0vo17K1zILyhFc.fontSize = txto.D1I0p7yzFiMIXRGqBXSuLvKlV - (int)((float)(txto.D1I0p7yzFiMIXRGqBXSuLvKlV - txto.DswdRfsVN0euTerbxOJL1tw48) * Mathf.Clamp((float)(num - txto.DSJ0X51xLXKKUUKYvhr16s5IG) / (float)txto.DZK5LlgvCYoXx5YJxGq2R4UIC, 0f, 1f));
			}
			category.Dxn8NngmWnv3B0QlK16ladv8o.fontSize = category.D0x2CpNPv5G0vo17K1zILyhFc.fontSize;
			category.Dxn8NngmWnv3B0QlK16ladv8o.normal.textColor = oc;
			category.D0x2CpNPv5G0vo17K1zILyhFc.normal.textColor = (txto.DuK00g4qH3jQKRmilg39vTfHi ? c : (txto.Da5g52fxWsEDiZwsDNgSXZYVf.isGradient ? c : (Color)txto.Da5g52fxWsEDiZwsDNgSXZYVf.DkJGdJpvFP4j4uWN4CyFixyQ3));
			Rect rect = new Rect(vector.x - 160f, vector.y - 40f, 320f, 80f);
			rect.x += txto.DJxQE7ww0bdFY31yVKuBrFMXO.x;
			rect.y -= txto.DJxQE7ww0bdFY31yVKuBrFMXO.y;
			DHTB5RKsHUihFrfj9ewuLh1f9.DcCtNCaSVWm57cNorggPJBWVH.fontSize = txto.Dx7ud2LZjVAh5oMukhPNbVcbP;
			bool flag10 = txto.DmohNcisfE9XlQBxYIbs4iR1c > DcyOGWtOfXF1Fhr1GWr4wf6Ww.None;
			bool flag11 = flag10;
			if (flag11)
			{
				DhNbDL0xpxhG1wADC5uXvFshQ.D8fixfJEOQDWjgtsvRfrY3xsG(rect, text, txto.DmohNcisfE9XlQBxYIbs4iR1c, category.Dxn8NngmWnv3B0QlK16ladv8o, txto.DGpmNFnsk8OWC3s0A9mZGdzff);
			}
			GUI.Label(rect, text, category.D0x2CpNPv5G0vo17K1zILyhFc);
		}
	}

	// Token: 0x0600020C RID: 524 RVA: 0x0001B158 File Offset: 0x00019358
	public static void D286UV0i4TGpJWWPG02XMBzZH(Vector2 pointA, Vector2 pointB, Color color, float width = 1f)
	{
		bool flag = float.IsNaN(pointA.x) || float.IsNaN(pointA.y) || float.IsNaN(pointB.x) || float.IsNaN(pointB.y);
		if (!flag)
		{
			Matrix4x4 matrix = GUI.matrix;
			try
			{
				DhNbDL0xpxhG1wADC5uXvFshQ.DcCQZ5D6XDtu91bpzFjL5A01I = matrix;
				DhNbDL0xpxhG1wADC5uXvFshQ.Dn0JRmsEy5nsc094RoarwKigc = Vector3.Angle(pointB - pointA, Vector2.right);
				bool flag2 = pointA.y > pointB.y;
				bool flag3 = flag2;
				if (flag3)
				{
					DhNbDL0xpxhG1wADC5uXvFshQ.Dn0JRmsEy5nsc094RoarwKigc = -DhNbDL0xpxhG1wADC5uXvFshQ.Dn0JRmsEy5nsc094RoarwKigc;
				}
				GUIUtility.ScaleAroundPivot(new Vector2((pointB - pointA).magnitude, width), new Vector2(pointA.x, pointA.y + 0.5f));
				GUIUtility.RotateAroundPivot(DhNbDL0xpxhG1wADC5uXvFshQ.Dn0JRmsEy5nsc094RoarwKigc, pointA);
				GUI.DrawTexture(new Rect(pointA.x, pointA.y, 1f, 1f), DHTB5RKsHUihFrfj9ewuLh1f9.DazBzygjoFMvkTR5WZh79oJmJ, ScaleMode.StretchToFill, false, 0f, color, 0f, 0f);
			}
			finally
			{
				GUI.matrix = matrix;
			}
		}
	}

	// Token: 0x0600020D RID: 525 RVA: 0x0001B288 File Offset: 0x00019488
	public static Rect GetBoundsScreenRect(Bounds bounds)
	{
		Vector3[] array = new Vector3[]
		{
			new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y + bounds.extents.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR(),
			new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y + bounds.extents.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR(),
			new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR(),
			new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR(),
			new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y + bounds.extents.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR(),
			new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y + bounds.extents.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR(),
			new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR(),
			new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR()
		};
		bool flag = false;
		Vector3 vector = Vector3.zero;
		Vector3 vector2 = Vector3.zero;
		for (int i = 0; i < array.Length; i++)
		{
			bool flag2 = float.IsNaN(array[i].x) || float.IsNaN(array[i].y);
			if (!flag2)
			{
				bool flag3 = !flag;
				if (flag3)
				{
					vector = array[i];
					vector2 = array[i];
					flag = true;
				}
				else
				{
					vector = Vector3.Min(vector, array[i]);
					vector2 = Vector3.Max(vector2, array[i]);
				}
			}
		}
		bool flag4 = !flag;
		Rect rect;
		if (flag4)
		{
			rect = new Rect(0f, 0f, 0f, 0f);
		}
		else
		{
			float num = vector2.x - vector.x;
			float num2 = vector2.y - vector.y;
			bool flag5 = num < 10f;
			if (flag5)
			{
				float num3 = (vector2.x + vector.x) / 2f;
				vector.x = num3 - 5f;
				vector2.x = num3 + 5f;
			}
			bool flag6 = num2 < 5f;
			if (flag6)
			{
				float num4 = (vector2.y + vector.y) / 2f;
				vector.y = num4 - 2.5f;
				vector2.y = num4 + 2.5f;
			}
			rect = new Rect(vector.x, vector.y, vector2.x - vector.x, vector2.y - vector.y);
		}
		return rect;
	}

	// Token: 0x0600020E RID: 526 RVA: 0x0001B748 File Offset: 0x00019948
	public static void DpW3s0mTQvPzsflmSjWcF4Gyk(DwIoOmLGoIyIvOm9z0SHgcarr category, Bounds bounds, Color32 color, Color32 outlineColor, Color32 fillBoxColor)
	{
		bool dmk5zVuQk0jGUFJWxk9EnD7G = category.Dmk5zVuQk0jGUFJWxk9EnD7G9;
		bool flag = dmk5zVuQk0jGUFJWxk9EnD7G;
		if (flag)
		{
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[0] = new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y + bounds.extents.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[1] = new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y + bounds.extents.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[2] = new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[3] = new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[4] = new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y + bounds.extents.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[5] = new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y + bounds.extents.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[6] = new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[7] = new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			bool flag2 = false;
			DhNbDL0xpxhG1wADC5uXvFshQ.D1qQPK2p0OZlwAU6cd14ap13T = Vector3.zero;
			DhNbDL0xpxhG1wADC5uXvFshQ.DKAxdRgHiyzyjbrvNKohUCCn9 = Vector3.zero;
			for (int i = 0; i < DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH.Length; i++)
			{
				bool flag3 = float.IsNaN(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[i].x) || float.IsNaN(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[i].y);
				if (!flag3)
				{
					bool flag4 = !flag2;
					if (flag4)
					{
						DhNbDL0xpxhG1wADC5uXvFshQ.D1qQPK2p0OZlwAU6cd14ap13T = DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[i];
						DhNbDL0xpxhG1wADC5uXvFshQ.DKAxdRgHiyzyjbrvNKohUCCn9 = DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[i];
						flag2 = true;
					}
					else
					{
						DhNbDL0xpxhG1wADC5uXvFshQ.D1qQPK2p0OZlwAU6cd14ap13T = Vector3.Min(DhNbDL0xpxhG1wADC5uXvFshQ.D1qQPK2p0OZlwAU6cd14ap13T, DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[i]);
						DhNbDL0xpxhG1wADC5uXvFshQ.DKAxdRgHiyzyjbrvNKohUCCn9 = Vector3.Max(DhNbDL0xpxhG1wADC5uXvFshQ.DKAxdRgHiyzyjbrvNKohUCCn9, DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[i]);
					}
				}
			}
			bool flag5 = !flag2;
			if (flag5)
			{
				return;
			}
			float num = DhNbDL0xpxhG1wADC5uXvFshQ.DKAxdRgHiyzyjbrvNKohUCCn9.x - DhNbDL0xpxhG1wADC5uXvFshQ.D1qQPK2p0OZlwAU6cd14ap13T.x;
			float num2 = DhNbDL0xpxhG1wADC5uXvFshQ.DKAxdRgHiyzyjbrvNKohUCCn9.y - DhNbDL0xpxhG1wADC5uXvFshQ.D1qQPK2p0OZlwAU6cd14ap13T.y;
			bool flag6 = num < 10f;
			if (flag6)
			{
				float num3 = (DhNbDL0xpxhG1wADC5uXvFshQ.DKAxdRgHiyzyjbrvNKohUCCn9.x + DhNbDL0xpxhG1wADC5uXvFshQ.D1qQPK2p0OZlwAU6cd14ap13T.x) / 2f;
				DhNbDL0xpxhG1wADC5uXvFshQ.D1qQPK2p0OZlwAU6cd14ap13T.x = num3 - 5f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DKAxdRgHiyzyjbrvNKohUCCn9.x = num3 + 5f;
			}
			bool flag7 = num2 < 5f;
			if (flag7)
			{
				float num4 = (DhNbDL0xpxhG1wADC5uXvFshQ.DKAxdRgHiyzyjbrvNKohUCCn9.y + DhNbDL0xpxhG1wADC5uXvFshQ.D1qQPK2p0OZlwAU6cd14ap13T.y) / 2f;
				DhNbDL0xpxhG1wADC5uXvFshQ.D1qQPK2p0OZlwAU6cd14ap13T.y = num4 - 2.5f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DKAxdRgHiyzyjbrvNKohUCCn9.y = num4 + 2.5f;
			}
			DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v = new Vector2(DhNbDL0xpxhG1wADC5uXvFshQ.D1qQPK2p0OZlwAU6cd14ap13T.x, DhNbDL0xpxhG1wADC5uXvFshQ.D1qQPK2p0OZlwAU6cd14ap13T.y);
			DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4 = new Vector2(DhNbDL0xpxhG1wADC5uXvFshQ.DKAxdRgHiyzyjbrvNKohUCCn9.x, DhNbDL0xpxhG1wADC5uXvFshQ.DKAxdRgHiyzyjbrvNKohUCCn9.y);
			DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm = new Vector2(DhNbDL0xpxhG1wADC5uXvFshQ.D1qQPK2p0OZlwAU6cd14ap13T.x, DhNbDL0xpxhG1wADC5uXvFshQ.DKAxdRgHiyzyjbrvNKohUCCn9.y);
			DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg = new Vector2(DhNbDL0xpxhG1wADC5uXvFshQ.DKAxdRgHiyzyjbrvNKohUCCn9.x, DhNbDL0xpxhG1wADC5uXvFshQ.D1qQPK2p0OZlwAU6cd14ap13T.y);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v, DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm, color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg, DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4, color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v, DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg, color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm, DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4, color, 1f);
			bool d0VJlj2dXjM6lM16rhlHPeVsM = category.D0VJlj2dXjM6lM16rhlHPeVsM;
			bool flag8 = d0VJlj2dXjM6lM16rhlHPeVsM;
			if (flag8)
			{
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.x = DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.x + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.y = DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.y - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.x = DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.x + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.y = DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.y + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v, DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm, outlineColor, 1f);
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg, DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4, outlineColor, 1f);
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v, DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg, outlineColor, 1f);
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm, DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4, outlineColor, 1f);
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.x = DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.y = DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.y + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.x = DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.y = DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.y - 1f;
			}
			bool dizjSZiKvyMuCh4R3JSe5Gs7x = category.DIzjSZiKvyMuCh4R3JSe5Gs7x;
			bool flag9 = dizjSZiKvyMuCh4R3JSe5Gs7x;
			if (flag9)
			{
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y - 1f;
				GUI.DrawTexture(new Rect(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x, DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y, Mathf.Abs(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x - DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x), Mathf.Abs(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y - DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y)), DHTB5RKsHUihFrfj9ewuLh1f9.DazBzygjoFMvkTR5WZh79oJmJ, ScaleMode.StretchToFill, true, 0f, fillBoxColor, 0f, 0f);
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y + 1f;
			}
			bool dajq3CYTvDIFQrH3BffYoksFp = category.DAJq3CYTvDIFQrH3BffYoksFp;
			bool flag10 = dajq3CYTvDIFQrH3BffYoksFp;
			if (flag10)
			{
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.x = DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.y = DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.y + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.x = DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.x + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.y = DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.y - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v, DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm, outlineColor, 1f);
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg, DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4, outlineColor, 1f);
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v, DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg, outlineColor, 1f);
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm, DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4, outlineColor, 1f);
			}
		}
		bool d30iUXR8sxNNzAAzBtRq0xi0n = category.D30iUXR8sxNNzAAzBtRq0xi0n;
		bool flag11 = d30iUXR8sxNNzAAzBtRq0xi0n;
		if (flag11)
		{
			bool flag12 = Vector2.Distance(new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y, bounds.center.z).DEfdLut9iGJvTAJNGrXHRFglR(), new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y, bounds.center.z).DEfdLut9iGJvTAJNGrXHRFglR()) > Vector2.Distance(new Vector3(bounds.center.x, bounds.center.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR(), new Vector3(bounds.center.x, bounds.center.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR());
			bool flag13 = flag12;
			if (flag13)
			{
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v = new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y + bounds.extents.y, bounds.center.z).DEfdLut9iGJvTAJNGrXHRFglR();
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4 = new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.center.z).DEfdLut9iGJvTAJNGrXHRFglR();
				DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm = new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.center.z).DEfdLut9iGJvTAJNGrXHRFglR();
				DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg = new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y + bounds.extents.y, bounds.center.z).DEfdLut9iGJvTAJNGrXHRFglR();
			}
			else
			{
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v = new Vector3(bounds.center.x, bounds.center.y + bounds.extents.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4 = new Vector3(bounds.center.x, bounds.center.y - bounds.extents.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
				DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm = new Vector3(bounds.center.x, bounds.center.y - bounds.extents.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
				DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg = new Vector3(bounds.center.x, bounds.center.y + bounds.extents.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			}
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v, DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm, color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg, DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4, color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v, DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg, color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm, DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4, color, 1f);
			bool daL9kFSE3cYbY6LHeOtuNQDbi = category.DaL9kFSE3cYbY6LHeOtuNQDbi;
			bool flag14 = daL9kFSE3cYbY6LHeOtuNQDbi;
			if (flag14)
			{
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.x = DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.x + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.y = DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.y - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.x = DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.x + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.y = DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.y + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v, DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm, outlineColor, 1f);
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg, DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4, outlineColor, 1f);
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v, DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg, outlineColor, 1f);
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm, DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4, outlineColor, 1f);
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.x = DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.y = DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.y + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.x = DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.y = DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.y - 1f;
			}
			bool dr1UbOEjagrEGWBLZB7U0v8b = category.DR1UbOEjagrEGWBLZB7U0v8b2;
			bool flag15 = dr1UbOEjagrEGWBLZB7U0v8b;
			if (flag15)
			{
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y = DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v.y - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.x = DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.y = DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm.y + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y = DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4.y + 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.x = DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.x - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.y = DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg.y - 1f;
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v, DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm, outlineColor, 1f);
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg, DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4, outlineColor, 1f);
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DMme0FADBrgliHxzeVPtwAQ7v, DhNbDL0xpxhG1wADC5uXvFshQ.DNXcb1bWAbaXOcvL30DO5dWpg, outlineColor, 1f);
				DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DCXtGObLCzgobUIVGClystYwm, DhNbDL0xpxhG1wADC5uXvFshQ.DDJPx0CfPEbFr1Z7ZqFVNthQ4, outlineColor, 1f);
			}
		}
		bool dctnEhAURtzTQjQG5HovyX10f = category.DctnEhAURtzTQjQG5HovyX10f;
		bool flag16 = dctnEhAURtzTQjQG5HovyX10f;
		if (flag16)
		{
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[0] = new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y + bounds.extents.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[1] = new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[2] = new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y + bounds.extents.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[3] = new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[4] = new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[5] = new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y + bounds.extents.y, bounds.center.z + bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[6] = new Vector3(bounds.center.x + bounds.extents.x, bounds.center.y - bounds.extents.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[7] = new Vector3(bounds.center.x - bounds.extents.x, bounds.center.y + bounds.extents.y, bounds.center.z - bounds.extents.z).DEfdLut9iGJvTAJNGrXHRFglR();
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[0], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[4], color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[1], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[5], color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[0], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[5], color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[4], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[1], color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[2], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[6], color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[3], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[7], color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[2], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[7], color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[6], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[3], color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[0], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[2], color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[1], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[3], color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[4], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[6], color, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[5], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[7], color, 1f);
		}
	}

	// Token: 0x0600020F RID: 527 RVA: 0x0001CEEC File Offset: 0x0001B0EC
	public static void D2nJmjgFCpzaMzel3nEY30fIw(Vector2 center, Vector3 position, Color32 lineColor, Color32 outlineColor, bool outline)
	{
		DhNbDL0xpxhG1wADC5uXvFshQ.DzZy42tKlhVDLjEm27XLuB3Gq = position.DEfdLut9iGJvTAJNGrXHRFglR();
		DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(center, DhNbDL0xpxhG1wADC5uXvFshQ.DzZy42tKlhVDLjEm27XLuB3Gq, lineColor, 1f);
		if (outline)
		{
			DhNbDL0xpxhG1wADC5uXvFshQ.DzZy42tKlhVDLjEm27XLuB3Gq.x = DhNbDL0xpxhG1wADC5uXvFshQ.DzZy42tKlhVDLjEm27XLuB3Gq.x + 1f;
			center.x += 1f;
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(center, DhNbDL0xpxhG1wADC5uXvFshQ.DzZy42tKlhVDLjEm27XLuB3Gq, outlineColor, 1f);
			DhNbDL0xpxhG1wADC5uXvFshQ.DzZy42tKlhVDLjEm27XLuB3Gq.x = DhNbDL0xpxhG1wADC5uXvFshQ.DzZy42tKlhVDLjEm27XLuB3Gq.x - 2f;
			center.x -= 2f;
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(center, DhNbDL0xpxhG1wADC5uXvFshQ.DzZy42tKlhVDLjEm27XLuB3Gq, outlineColor, 1f);
		}
	}

	// Token: 0x06000210 RID: 528 RVA: 0x0001CFAC File Offset: 0x0001B1AC
	public static void D8fixfJEOQDWjgtsvRfrY3xsG(Rect rect, string text, DcyOGWtOfXF1Fhr1GWr4wf6Ww outline, GUIStyle outlineText, int thickness)
	{
		switch (outline)
		{
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.RightDownSided:
		{
			for (int i = 0; i < thickness; i++)
			{
				GUI.Label(new Rect(rect.x + (float)i, rect.y, rect.width, rect.height), text, outlineText);
				GUI.Label(new Rect(rect.x, rect.y + (float)i, rect.width, rect.height), text, outlineText);
			}
			break;
		}
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.RightTopSided:
		{
			for (int j = 0; j < thickness; j++)
			{
				GUI.Label(new Rect(rect.x + (float)j, rect.y, rect.width, rect.height), text, outlineText);
				GUI.Label(new Rect(rect.x, rect.y - (float)j, rect.width, rect.height), text, outlineText);
			}
			break;
		}
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.LeftTopSided:
		{
			for (int k = 0; k < thickness; k++)
			{
				GUI.Label(new Rect(rect.x - (float)k, rect.y, rect.width, rect.height), text, outlineText);
				GUI.Label(new Rect(rect.x, rect.y - (float)k, rect.width, rect.height), text, outlineText);
			}
			break;
		}
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.LeftDownSided:
		{
			for (int l = 0; l < thickness; l++)
			{
				GUI.Label(new Rect(rect.x - (float)l, rect.y, rect.width, rect.height), text, outlineText);
				GUI.Label(new Rect(rect.x, rect.y + (float)l, rect.width, rect.height), text, outlineText);
			}
			break;
		}
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.FourSided:
		{
			for (int m = 0; m < thickness; m++)
			{
				GUI.Label(new Rect(rect.x + (float)m, rect.y, rect.width, rect.height), text, outlineText);
				GUI.Label(new Rect(rect.x, rect.y - (float)m, rect.width, rect.height), text, outlineText);
				GUI.Label(new Rect(rect.x - (float)m, rect.y, rect.width, rect.height), text, outlineText);
				GUI.Label(new Rect(rect.x, rect.y + (float)m, rect.width, rect.height), text, outlineText);
			}
			break;
		}
		}
	}

	// Token: 0x06000211 RID: 529 RVA: 0x0001D28C File Offset: 0x0001B48C
	public static void DDrawFilledTriangle(Vector2 p1, Vector2 p2, Vector2 p3, Color color)
	{
		DhNbDL0xpxhG1wADC5uXvFshQ.DcCQZ5D6XDtu91bpzFjL5A01I = GUI.matrix;
		Vector2 vector = Vector2.Min(Vector2.Min(p1, p2), p3);
		Vector2 vector2 = Vector2.Max(Vector2.Max(p1, p2), p3);
		Rect rect = new Rect(vector.x, vector.y, vector2.x - vector.x, vector2.y - vector.y);
		for (float num = rect.x; num < rect.x + rect.width; num += 1f)
		{
			for (float num2 = rect.y; num2 < rect.y + rect.height; num2 += 1f)
			{
				Vector2 vector3 = new Vector2(num, num2);
				bool flag = DhNbDL0xpxhG1wADC5uXvFshQ.DPointInTriangle(vector3, p1, p2, p3);
				if (flag)
				{
					GUI.DrawTexture(new Rect(num, num2, 1f, 1f), DHTB5RKsHUihFrfj9ewuLh1f9.DazBzygjoFMvkTR5WZh79oJmJ, ScaleMode.StretchToFill, false, 0f, color, 0f, 0f);
				}
			}
		}
		GUI.matrix = DhNbDL0xpxhG1wADC5uXvFshQ.DcCQZ5D6XDtu91bpzFjL5A01I;
	}

	// Token: 0x06000212 RID: 530 RVA: 0x0001D3A8 File Offset: 0x0001B5A8
	private static bool DPointInTriangle(Vector2 pt, Vector2 p1, Vector2 p2, Vector2 p3)
	{
		float num = DhNbDL0xpxhG1wADC5uXvFshQ.DSign(pt, p1, p2);
		float num2 = DhNbDL0xpxhG1wADC5uXvFshQ.DSign(pt, p2, p3);
		float num3 = DhNbDL0xpxhG1wADC5uXvFshQ.DSign(pt, p3, p1);
		bool flag = num < 0f || num2 < 0f || num3 < 0f;
		bool flag2 = num > 0f || num2 > 0f || num3 > 0f;
		return !flag || !flag2;
	}

	// Token: 0x06000213 RID: 531 RVA: 0x0001D418 File Offset: 0x0001B618
	private static float DSign(Vector2 p1, Vector2 p2, Vector2 p3)
	{
		return (p1.x - p3.x) * (p2.y - p3.y) - (p2.x - p3.x) * (p1.y - p3.y);
	}

	// Token: 0x04000289 RID: 649
	public static Matrix4x4 Dvnc7NMv3T5T0nPfgcO28KXhC;

	// Token: 0x0400028A RID: 650
	public static Matrix4x4 D0dFeYUac5o0ycmUFaeSj1J46;

	// Token: 0x0400028B RID: 651
	public static Vector3[] DKiMO3NaucExIbgyGlg41oDzH = new Vector3[8];

	// Token: 0x0400028C RID: 652
	private static Vector2 DMme0FADBrgliHxzeVPtwAQ7v;

	// Token: 0x0400028D RID: 653
	private static Vector2 DDJPx0CfPEbFr1Z7ZqFVNthQ4;

	// Token: 0x0400028E RID: 654
	private static Vector2 DCXtGObLCzgobUIVGClystYwm;

	// Token: 0x0400028F RID: 655
	private static Vector2 DNXcb1bWAbaXOcvL30DO5dWpg;

	// Token: 0x04000290 RID: 656
	private static Vector2 DzZy42tKlhVDLjEm27XLuB3Gq;

	// Token: 0x04000291 RID: 657
	public static Vector3 D1qQPK2p0OZlwAU6cd14ap13T;

	// Token: 0x04000292 RID: 658
	public static Vector3 DKAxdRgHiyzyjbrvNKohUCCn9;

	// Token: 0x04000293 RID: 659
	private static float Dn0JRmsEy5nsc094RoarwKigc;

	// Token: 0x04000294 RID: 660
	private static Matrix4x4 DcCQZ5D6XDtu91bpzFjL5A01I;

	// Token: 0x04000295 RID: 661
	public static Camera Dr38GGKdBZ2EXiNCUdvVjgmhc;
}
