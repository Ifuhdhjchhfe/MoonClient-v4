using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000D1 RID: 209
public class Dxg2tDZdImJqrX71UMTW47xIk
{
	// Token: 0x060003F3 RID: 1011 RVA: 0x0003BA3C File Offset: 0x00039C3C
	public static void DCKhbeqgYmum8GcjvdFoYBZNI()
	{
		bool flag = !Directory.Exists(Application.dataPath + "/configs/");
		if (flag)
		{
			Directory.CreateDirectory(Application.dataPath + "/configs/");
		}
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x0003BA7C File Offset: 0x00039C7C
	public static void DxeJlNfhwsirSRyR3yNds5r6J()
	{
		Dxg2tDZdImJqrX71UMTW47xIk.DwPb3hnqDGXSpUs1xbcavAY4i.Clear();
		foreach (FileInfo fileInfo in new DirectoryInfo(Application.dataPath + "/configs/").GetFiles())
		{
			bool flag = fileInfo.Name.EndsWith(".conf");
			if (flag)
			{
				Dxg2tDZdImJqrX71UMTW47xIk.DwPb3hnqDGXSpUs1xbcavAY4i.Add(fileInfo.Name);
			}
		}
		Dxg2tDZdImJqrX71UMTW47xIk.DDQ5PCzTYw7CDj44DlEnnfNBM.DP2ftY5lfPrZHzQcVaAIkgxQS = (from s in Dxg2tDZdImJqrX71UMTW47xIk.DwPb3hnqDGXSpUs1xbcavAY4i.ToArray()
			select s.Replace(".conf", "")).ToArray<string>();
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x0003BB28 File Offset: 0x00039D28
	public static void DrTvkWcwJ8jJGDW9YWF7SBkmo()
	{
		Dxg2tDZdImJqrX71UMTW47xIk.DCKhbeqgYmum8GcjvdFoYBZNI();
		Dxg2tDZdImJqrX71UMTW47xIk.DxeJlNfhwsirSRyR3yNds5r6J();
		foreach (FieldInfo fieldInfo in DHGBgVGlvxZ0K3LOA9TG3GHJ9.DSEjpJhvtXKwo2Oo6bJw1QIJR[typeof(Dy6M3joVi08gNRZyTkEnTy5qj)])
		{
			string text = ((Dy6M3joVi08gNRZyTkEnTy5qj)fieldInfo.GetCustomAttribute(typeof(Dy6M3joVi08gNRZyTkEnTy5qj))).DVDfcNSpZKH0L1ZSus8jQ8PgJ;
			bool flag = string.IsNullOrEmpty(text);
			if (flag)
			{
				bool flag2 = fieldInfo.IsDefined(typeof(DvBeyuawbq3X9NsoJgcUZmAIZ));
				if (flag2)
				{
					text = ((DvBeyuawbq3X9NsoJgcUZmAIZ)fieldInfo.GetCustomAttribute(typeof(DvBeyuawbq3X9NsoJgcUZmAIZ))).DaVgpJhFjnKcHDNaIMK0WzFxr;
				}
				else
				{
					text = fieldInfo.Name;
				}
			}
			bool flag3 = !Dxg2tDZdImJqrX71UMTW47xIk.DRzy2e8GEyVSO08fR0uyzK02D.ContainsKey(text);
			if (flag3)
			{
				Dxg2tDZdImJqrX71UMTW47xIk.DRzy2e8GEyVSO08fR0uyzK02D.Add(text, new DC0nl3r18TU0Q6PA1kJbeydPJ(Dxg2tDZdImJqrX71UMTW47xIk.DxNwfoplX7A15CIexJbpuN07c(fieldInfo.FieldType), fieldInfo.DeclaringType, fieldInfo.Name, text, false));
			}
			else
			{
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("Saveable with name " + text + " have a several saves atributes");
			}
		}
		foreach (PropertyInfo propertyInfo in DHGBgVGlvxZ0K3LOA9TG3GHJ9.DU76d4d2f3byxUKf35J1drJ5m[typeof(Dy6M3joVi08gNRZyTkEnTy5qj)])
		{
			string text2 = ((Dy6M3joVi08gNRZyTkEnTy5qj)propertyInfo.GetCustomAttribute(typeof(Dy6M3joVi08gNRZyTkEnTy5qj))).DVDfcNSpZKH0L1ZSus8jQ8PgJ;
			bool flag4 = string.IsNullOrEmpty(text2);
			if (flag4)
			{
				bool flag5 = propertyInfo.IsDefined(typeof(DvBeyuawbq3X9NsoJgcUZmAIZ));
				if (flag5)
				{
					text2 = ((DvBeyuawbq3X9NsoJgcUZmAIZ)propertyInfo.GetCustomAttribute(typeof(DvBeyuawbq3X9NsoJgcUZmAIZ))).DaVgpJhFjnKcHDNaIMK0WzFxr;
				}
				else
				{
					text2 = propertyInfo.Name;
				}
			}
			bool flag6 = !Dxg2tDZdImJqrX71UMTW47xIk.DRzy2e8GEyVSO08fR0uyzK02D.ContainsKey(text2);
			if (flag6)
			{
				Dxg2tDZdImJqrX71UMTW47xIk.DRzy2e8GEyVSO08fR0uyzK02D.Add(text2, new DC0nl3r18TU0Q6PA1kJbeydPJ(Dxg2tDZdImJqrX71UMTW47xIk.DxNwfoplX7A15CIexJbpuN07c(propertyInfo.PropertyType), propertyInfo.DeclaringType, propertyInfo.Name, text2, true));
			}
			else
			{
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("Saveable with name " + text2 + " have a several saves atributes");
			}
		}
		bool flag7 = File.Exists(Application.dataPath + "/pseudohwids");
		if (flag7)
		{
			DUt0a6FCClF9uncpHt4baoWwu dut0a6FCClF9uncpHt4baoWwu = new DUt0a6FCClF9uncpHt4baoWwu(File.ReadAllBytes(Application.dataPath + "/pseudohwids"));
			D5l46jlssr4TRAzUSXzLj0uqu.DRywCzlrtImzxkGhDOTGcBASd = dut0a6FCClF9uncpHt4baoWwu.DeSXvmRE6cQJRqrdxy42mpU54();
			D5l46jlssr4TRAzUSXzLj0uqu.DTJpui0sqNkukyZlpsiFS5Vbv = dut0a6FCClF9uncpHt4baoWwu.DeSXvmRE6cQJRqrdxy42mpU54();
			D5l46jlssr4TRAzUSXzLj0uqu.DHuZ6stX7WaYQtYnBbmwbMew0 = dut0a6FCClF9uncpHt4baoWwu.DeSXvmRE6cQJRqrdxy42mpU54();
		}
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x0003BDD8 File Offset: 0x00039FD8
	public static void DcXCWIlY0AW5fJv1MNaTYg6ok(string fileName)
	{
		Dxg2tDZdImJqrX71UMTW47xIk.DCKhbeqgYmum8GcjvdFoYBZNI();
		try
		{
			DUt0a6FCClF9uncpHt4baoWwu dut0a6FCClF9uncpHt4baoWwu = new DUt0a6FCClF9uncpHt4baoWwu(File.ReadAllBytes(Application.dataPath + "/configs/" + fileName));
			byte b = dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			bool flag = b >= 5;
			int num;
			if (flag)
			{
				num = (int)dut0a6FCClF9uncpHt4baoWwu.DmAu4cEiGWLGp7NLhkOyVsRbx();
			}
			else
			{
				bool flag2 = b > 190;
				if (flag2)
				{
					num = (int)b;
					b = 0;
				}
				else
				{
					num = (int)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
				}
			}
			int i = 0;
			while (i < num)
			{
				DA7EjeELhPnQjMBiXW309VJV4 da7EjeELhPnQjMBiXW309VJV = (DA7EjeELhPnQjMBiXW309VJV4)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
				string text = dut0a6FCClF9uncpHt4baoWwu.DwZMJgiflLxDLkLNV8ljFfb8p();
				object obj = null;
				switch (da7EjeELhPnQjMBiXW309VJV)
				{
				case DA7EjeELhPnQjMBiXW309VJV4.Bool:
					obj = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.String:
					obj = dut0a6FCClF9uncpHt4baoWwu.DwZMJgiflLxDLkLNV8ljFfb8p();
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.Int:
					obj = dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx();
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.Float:
					obj = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.Enum:
				{
					bool flag3 = Dxg2tDZdImJqrX71UMTW47xIk.DRzy2e8GEyVSO08fR0uyzK02D.ContainsKey(text);
					if (flag3)
					{
						try
						{
							int num2 = ((b >= 6) ? dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx() : ((int)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU()));
							obj = Dxg2tDZdImJqrX71UMTW47xIk.DSCEqW8RknYx8L5dbCx2YZXLB(Dxg2tDZdImJqrX71UMTW47xIk.DRzy2e8GEyVSO08fR0uyzK02D[text].Dz6tW57BxFns2BxXLi0S2TXiF(), num2);
							break;
						}
						catch
						{
							break;
						}
					}
					dut0a6FCClF9uncpHt4baoWwu.DgTrevnMqiGTEn0P1JdH0dHcY += ((b >= 6) ? 4 : 1);
					break;
				}
				case DA7EjeELhPnQjMBiXW309VJV4.Byte:
					obj = dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.ByteArray:
					obj = dut0a6FCClF9uncpHt4baoWwu.DeSXvmRE6cQJRqrdxy42mpU54();
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.Rect:
					obj = dut0a6FCClF9uncpHt4baoWwu.DWEsi1RqSBsA0p3ExpLWIEDGu();
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.Vector2:
					obj = dut0a6FCClF9uncpHt4baoWwu.DpC96gxaM3lOPP0gXfzEgISl5();
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.Unknown:
					goto IL_01C1;
				case DA7EjeELhPnQjMBiXW309VJV4.ULong:
					obj = dut0a6FCClF9uncpHt4baoWwu.DP82wJ7A5EJPwaDAXcpynsH0k();
					break;
				default:
					goto IL_01C1;
				}
				IL_02F4:
				bool flag4 = Dxg2tDZdImJqrX71UMTW47xIk.DRzy2e8GEyVSO08fR0uyzK02D.ContainsKey(text);
				if (flag4)
				{
					Dxg2tDZdImJqrX71UMTW47xIk.DRzy2e8GEyVSO08fR0uyzK02D[text].DQUVdiEFDb2ugi6tiKPbDRuQV(obj);
				}
				i++;
				continue;
				IL_01C1:
				bool flag5 = Dxg2tDZdImJqrX71UMTW47xIk.DRzy2e8GEyVSO08fR0uyzK02D.ContainsKey(text);
				if (flag5)
				{
					switch (Dxg2tDZdImJqrX71UMTW47xIk.DRzy2e8GEyVSO08fR0uyzK02D[text].DJlJTMsR8q8RN0RCA0fyq7LLD)
					{
					case DA7EjeELhPnQjMBiXW309VJV4.Bool:
						obj = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
						break;
					case DA7EjeELhPnQjMBiXW309VJV4.String:
						obj = dut0a6FCClF9uncpHt4baoWwu.DwZMJgiflLxDLkLNV8ljFfb8p();
						break;
					case DA7EjeELhPnQjMBiXW309VJV4.Int:
						obj = dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx();
						break;
					case DA7EjeELhPnQjMBiXW309VJV4.Float:
						obj = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
						break;
					case DA7EjeELhPnQjMBiXW309VJV4.Enum:
						try
						{
							int num3 = ((b >= 6) ? dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx() : ((int)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU()));
							obj = Dxg2tDZdImJqrX71UMTW47xIk.DSCEqW8RknYx8L5dbCx2YZXLB(Dxg2tDZdImJqrX71UMTW47xIk.DRzy2e8GEyVSO08fR0uyzK02D[text].Dz6tW57BxFns2BxXLi0S2TXiF(), num3);
						}
						catch
						{
						}
						break;
					case DA7EjeELhPnQjMBiXW309VJV4.Byte:
						obj = dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
						break;
					case DA7EjeELhPnQjMBiXW309VJV4.ByteArray:
						obj = dut0a6FCClF9uncpHt4baoWwu.DeSXvmRE6cQJRqrdxy42mpU54();
						break;
					case DA7EjeELhPnQjMBiXW309VJV4.Rect:
						obj = dut0a6FCClF9uncpHt4baoWwu.DWEsi1RqSBsA0p3ExpLWIEDGu();
						break;
					case DA7EjeELhPnQjMBiXW309VJV4.Vector2:
						obj = dut0a6FCClF9uncpHt4baoWwu.DpC96gxaM3lOPP0gXfzEgISl5();
						break;
					case DA7EjeELhPnQjMBiXW309VJV4.ULong:
						obj = dut0a6FCClF9uncpHt4baoWwu.DP82wJ7A5EJPwaDAXcpynsH0k();
						break;
					}
				}
				goto IL_02F4;
			}
			byte b2 = dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			for (int j = ((b == 0) ? 5 : 0); j < (int)(b2 + ((b == 0) ? 6 : 0)); j++)
			{
				DNbYBVifu73t6Hq5vgTtgKwS7.DQLIruDkU2ZNtLDoc98U3NKNd[j].isGradient = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
				DNbYBVifu73t6Hq5vgTtgKwS7.DQLIruDkU2ZNtLDoc98U3NKNd[j].settedColor = dut0a6FCClF9uncpHt4baoWwu.DnCcnTnPw5ZJ82mTIu9h2oX06();
			}
			byte b3 = dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			for (int k = 0; k < (int)b3; k++)
			{
				Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[k].DzWDkDyS4l90nNUmR0KW0x152(dut0a6FCClF9uncpHt4baoWwu);
			}
			byte b4 = dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			for (int l = 0; l < (int)b4; l++)
			{
				string text2 = dut0a6FCClF9uncpHt4baoWwu.DwZMJgiflLxDLkLNV8ljFfb8p();
				KeyCode keyCode = (KeyCode)dut0a6FCClF9uncpHt4baoWwu.DmAu4cEiGWLGp7NLhkOyVsRbx();
				bool flag6 = b >= 3;
				if (flag6)
				{
					D78avTg9KcyX9xog2Gp420bvj.D23bG90mDbVryo0wxzEX0qmVN(keyCode, (DKTrjQa1HNIdKaR8WkdJ1SrM6)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU(), text2);
				}
			}
			byte b5 = dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			for (int m = 0; m < (int)b5; m++)
			{
				DnFbkaUD6mnA1BajCnfh8ztdO dnFbkaUD6mnA1BajCnfh8ztdO = (DnFbkaUD6mnA1BajCnfh8ztdO)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
				DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0.Add(dnFbkaUD6mnA1BajCnfh8ztdO, DNvjrDV53gpGJEJwnNwmyFRZw.DoajP7ueXvymRNGGeLfOkip4Q(dnFbkaUD6mnA1BajCnfh8ztdO, dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx()));
			}
			for (int n = 0; n < DNm0WKPfJZZwrccrWCLx3AlaY.DJnkBPDuULCwKtfSzrqOluiCY.Length; n++)
			{
				DNm0WKPfJZZwrccrWCLx3AlaY.DJnkBPDuULCwKtfSzrqOluiCY[n].DkPiBrZfDuyssgVsFrnhxjO4v = dut0a6FCClF9uncpHt4baoWwu.DpC96gxaM3lOPP0gXfzEgISl5();
			}
			DHKOlhPS98QOeYArRzpLwTeId.itemsToESP.Clear();
			ushort num4 = dut0a6FCClF9uncpHt4baoWwu.DmAu4cEiGWLGp7NLhkOyVsRbx();
			for (int num5 = 0; num5 < (int)num4; num5++)
			{
				ushort num6 = dut0a6FCClF9uncpHt4baoWwu.DmAu4cEiGWLGp7NLhkOyVsRbx();
				Asset asset = Assets.find(EAssetType.ITEM, num6);
				bool flag7 = asset != null && asset is ItemAsset && (asset as ItemAsset).itemName.ToLower() != "name";
				if (flag7)
				{
					DHKOlhPS98QOeYArRzpLwTeId.itemsToESP.Add(num6, new DDB8pIlWKKbHkw2jCuyAPcvL7(num6, asset.name));
				}
			}
			D5l46jlssr4TRAzUSXzLj0uqu.DzksjAWr7fP6HlkBNdY20fpHC.Clear();
			ushort num7 = dut0a6FCClF9uncpHt4baoWwu.DmAu4cEiGWLGp7NLhkOyVsRbx();
			for (int num8 = 0; num8 < (int)num7; num8++)
			{
				ushort num9 = dut0a6FCClF9uncpHt4baoWwu.DmAu4cEiGWLGp7NLhkOyVsRbx();
				Asset asset2 = Assets.find(EAssetType.ITEM, num9);
				bool flag8 = asset2 != null && asset2 is ItemAsset && (asset2 as ItemAsset).itemName.ToLower() != "name";
				if (flag8)
				{
					D5l46jlssr4TRAzUSXzLj0uqu.DzksjAWr7fP6HlkBNdY20fpHC.Add(num9, new DDB8pIlWKKbHkw2jCuyAPcvL7(num9, asset2.name));
				}
			}
			byte b6 = dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			for (byte b7 = 0; b7 < b6; b7 += 1)
			{
				bool flag9 = DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx.Length > (int)b7;
				if (flag9)
				{
					DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx[(int)b7] = DxMhfufThyuW1UdZ5MxaTXe5X.DwVXCuZWBJ0vFlGn2l499cfmz(DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx[(int)b7], dut0a6FCClF9uncpHt4baoWwu);
				}
			}
			bool flag10 = b >= 1;
			if (flag10)
			{
				DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY.Clear();
				byte b8 = dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
				for (byte b9 = 0; b9 < b8; b9 += 1)
				{
					int num10 = (int)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
					bool flag11 = b >= 4;
					float num11;
					if (flag11)
					{
						num11 = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
					}
					else
					{
						num11 = (float)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
					}
					DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY.Add(new DaqXfD9Fjc9IG7oF0OAH4hEOR(num11, num10));
				}
				DoLw5vYd2Gq0BYuUfcIXuj4Vo.DJCB8nFq4AlMkcvaCk3iazVNC();
			}
			bool flag12 = b >= 2;
			if (flag12)
			{
				DNm0WKPfJZZwrccrWCLx3AlaY.DaJe53J7NyMGaLCgE4QZ7wbOI = new Rect(dut0a6FCClF9uncpHt4baoWwu.DpC96gxaM3lOPP0gXfzEgISl5(), new Vector2(DNm0WKPfJZZwrccrWCLx3AlaY.DaJe53J7NyMGaLCgE4QZ7wbOI.width, DNm0WKPfJZZwrccrWCLx3AlaY.DaJe53J7NyMGaLCgE4QZ7wbOI.height));
			}
			Dxg2tDZdImJqrX71UMTW47xIk.D6EN6hoxrJeDXTonZlJ4PnKig = fileName.Substring(0, fileName.Length - ".conf".Length);
			Dxg2tDZdImJqrX71UMTW47xIk.DDQ5PCzTYw7CDj44DlEnnfNBM.DvZuyjYgPRxEKoiET9bNBFdF0 = Dxg2tDZdImJqrX71UMTW47xIk.D6EN6hoxrJeDXTonZlJ4PnKig;
			DovA0560C5xwc06yYBWmht6vA.D2XDJbj97cXeWm21NhElh6XXL("[+] Loaded configuration " + Dxg2tDZdImJqrX71UMTW47xIk.D6EN6hoxrJeDXTonZlJ4PnKig);
		}
		catch (Exception ex)
		{
			File.WriteAllText("C:\\Users\\PC\\Desktop\\MoonV4Dumpz\\load_error.log", ex.ToString());
			DovA0560C5xwc06yYBWmht6vA.D2XDJbj97cXeWm21NhElh6XXL("[-] Unable to load configuration " + fileName.Substring(0, fileName.Length - ".conf".Length));
			Debug.Log(ex.Message);
			Debug.Log(ex.StackTrace);
		}
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x0003C578 File Offset: 0x0003A778
	public static Enum DSCEqW8RknYx8L5dbCx2YZXLB(Type type, int value)
	{
		return (Enum)Enum.ToObject(type, value);
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x0003C598 File Offset: 0x0003A798
	public static void DFAyL8wNHbluCMKtorDynB4MC(string name)
	{
		try
		{
			Dxg2tDZdImJqrX71UMTW47xIk.DCKhbeqgYmum8GcjvdFoYBZNI();
			DTQTgBvjhehJ9nKOGQCJPsaGO dtqtgBvjhehJ9nKOGQCJPsaGO = new DTQTgBvjhehJ9nKOGQCJPsaGO();
			dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR(6);
			dtqtgBvjhehJ9nKOGQCJPsaGO.DqHK2AOqBv0WgvxpmWqM30pSD((ushort)Dxg2tDZdImJqrX71UMTW47xIk.DRzy2e8GEyVSO08fR0uyzK02D.Values.Count);
			foreach (DC0nl3r18TU0Q6PA1kJbeydPJ dc0nl3r18TU0Q6PA1kJbeydPJ in Dxg2tDZdImJqrX71UMTW47xIk.DRzy2e8GEyVSO08fR0uyzK02D.Values)
			{
				dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)dc0nl3r18TU0Q6PA1kJbeydPJ.DJlJTMsR8q8RN0RCA0fyq7LLD);
				dtqtgBvjhehJ9nKOGQCJPsaGO.DGDUglHFhs4KI2tPvrxsuSjzz(dc0nl3r18TU0Q6PA1kJbeydPJ.DY023HqubRJHq5VeFVgWZNqT7);
				switch (dc0nl3r18TU0Q6PA1kJbeydPJ.DJlJTMsR8q8RN0RCA0fyq7LLD)
				{
				case DA7EjeELhPnQjMBiXW309VJV4.Bool:
					dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(dc0nl3r18TU0Q6PA1kJbeydPJ.DBCMP09X3dhTzG7ltpdUYMITv<bool>());
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.String:
					dtqtgBvjhehJ9nKOGQCJPsaGO.DGDUglHFhs4KI2tPvrxsuSjzz(dc0nl3r18TU0Q6PA1kJbeydPJ.DBCMP09X3dhTzG7ltpdUYMITv<string>());
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.Int:
					dtqtgBvjhehJ9nKOGQCJPsaGO.DwTWdG1zkzaGlxDGRH2ahyh0C(dc0nl3r18TU0Q6PA1kJbeydPJ.DBCMP09X3dhTzG7ltpdUYMITv<int>());
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.Float:
					dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(dc0nl3r18TU0Q6PA1kJbeydPJ.DBCMP09X3dhTzG7ltpdUYMITv<float>());
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.Enum:
					dtqtgBvjhehJ9nKOGQCJPsaGO.DwTWdG1zkzaGlxDGRH2ahyh0C(Convert.ToInt32(dc0nl3r18TU0Q6PA1kJbeydPJ.Dzty2JTTfrqCDWb8RtFsz2QeF()));
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.Byte:
					dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR(dc0nl3r18TU0Q6PA1kJbeydPJ.DBCMP09X3dhTzG7ltpdUYMITv<byte>());
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.ByteArray:
					dtqtgBvjhehJ9nKOGQCJPsaGO.DWoug57y0MCZVj5PIjkNVZncd(dc0nl3r18TU0Q6PA1kJbeydPJ.DBCMP09X3dhTzG7ltpdUYMITv<byte[]>());
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.Rect:
					dtqtgBvjhehJ9nKOGQCJPsaGO.DGrtj2oC2MzoTkSY62PlM3c3B(dc0nl3r18TU0Q6PA1kJbeydPJ.DBCMP09X3dhTzG7ltpdUYMITv<Rect>());
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.Vector2:
					dtqtgBvjhehJ9nKOGQCJPsaGO.DAnd9k0eKEJkMQRg0Qgw4jBGq(dc0nl3r18TU0Q6PA1kJbeydPJ.DBCMP09X3dhTzG7ltpdUYMITv<Vector2>());
					break;
				case DA7EjeELhPnQjMBiXW309VJV4.Unknown:
					goto IL_0159;
				case DA7EjeELhPnQjMBiXW309VJV4.ULong:
					dtqtgBvjhehJ9nKOGQCJPsaGO.DjHnHRFKGsun0Ya05clZVAQfO(dc0nl3r18TU0Q6PA1kJbeydPJ.DBCMP09X3dhTzG7ltpdUYMITv<ulong>());
					break;
				default:
					goto IL_0159;
				}
				continue;
				IL_0159:
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("Couldn't write unexcepted value");
			}
			dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)DNbYBVifu73t6Hq5vgTtgKwS7.DQLIruDkU2ZNtLDoc98U3NKNd.Length);
			for (int i = 0; i < DNbYBVifu73t6Hq5vgTtgKwS7.DQLIruDkU2ZNtLDoc98U3NKNd.Length; i++)
			{
				dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(DNbYBVifu73t6Hq5vgTtgKwS7.DQLIruDkU2ZNtLDoc98U3NKNd[i].isGradient);
				dtqtgBvjhehJ9nKOGQCJPsaGO.Drus0Za74WiC3LqWecY3tibut(DNbYBVifu73t6Hq5vgTtgKwS7.DQLIruDkU2ZNtLDoc98U3NKNd[i].settedColor);
			}
			dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G.Length);
			for (int j = 0; j < Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G.Length; j++)
			{
				Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[j].D2SEMg8l3dYQ7jgNctsqltz77(dtqtgBvjhehJ9nKOGQCJPsaGO);
			}
			dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)D78avTg9KcyX9xog2Gp420bvj.D8ZjqswnJ6Qd5Y9cj1DN6e0Om.Count);
			foreach (Dr3ZjnRxP0iAQVvAkuCp9m5Mb dr3ZjnRxP0iAQVvAkuCp9m5Mb in D78avTg9KcyX9xog2Gp420bvj.D8ZjqswnJ6Qd5Y9cj1DN6e0Om)
			{
				dtqtgBvjhehJ9nKOGQCJPsaGO.DGDUglHFhs4KI2tPvrxsuSjzz(dr3ZjnRxP0iAQVvAkuCp9m5Mb.D00PVeHLDw7ARnIOpGcUNHUOG);
				dtqtgBvjhehJ9nKOGQCJPsaGO.DqHK2AOqBv0WgvxpmWqM30pSD((ushort)dr3ZjnRxP0iAQVvAkuCp9m5Mb.DU2mPiOIQ9Bcy6xHJlZal0eNJ);
				dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)dr3ZjnRxP0iAQVvAkuCp9m5Mb.D3eAlPfDoZwNnDAcknyn7stsA);
			}
			dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0.Count);
			foreach (DnFbkaUD6mnA1BajCnfh8ztdO dnFbkaUD6mnA1BajCnfh8ztdO in DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0.Keys)
			{
				dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)dnFbkaUD6mnA1BajCnfh8ztdO);
				dtqtgBvjhehJ9nKOGQCJPsaGO.DwTWdG1zkzaGlxDGRH2ahyh0C(DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[dnFbkaUD6mnA1BajCnfh8ztdO].skinID);
			}
			for (int k = 0; k < DNm0WKPfJZZwrccrWCLx3AlaY.DJnkBPDuULCwKtfSzrqOluiCY.Length; k++)
			{
				dtqtgBvjhehJ9nKOGQCJPsaGO.DAnd9k0eKEJkMQRg0Qgw4jBGq(DNm0WKPfJZZwrccrWCLx3AlaY.DJnkBPDuULCwKtfSzrqOluiCY[k].DkPiBrZfDuyssgVsFrnhxjO4v);
			}
			dtqtgBvjhehJ9nKOGQCJPsaGO.DhFfoVD28pOeX4IcZN9Vcl5NR(DHKOlhPS98QOeYArRzpLwTeId.itemsToESP.Count);
			foreach (DDB8pIlWKKbHkw2jCuyAPcvL7 ddb8pIlWKKbHkw2jCuyAPcvL in DHKOlhPS98QOeYArRzpLwTeId.itemsToESP.Values)
			{
				dtqtgBvjhehJ9nKOGQCJPsaGO.DqHK2AOqBv0WgvxpmWqM30pSD(ddb8pIlWKKbHkw2jCuyAPcvL.Dn06Kjd8jxL0Tj2Vfupj8Skcq);
			}
			dtqtgBvjhehJ9nKOGQCJPsaGO.DhFfoVD28pOeX4IcZN9Vcl5NR(D5l46jlssr4TRAzUSXzLj0uqu.DzksjAWr7fP6HlkBNdY20fpHC.Count);
			foreach (DDB8pIlWKKbHkw2jCuyAPcvL7 ddb8pIlWKKbHkw2jCuyAPcvL2 in D5l46jlssr4TRAzUSXzLj0uqu.DzksjAWr7fP6HlkBNdY20fpHC.Values)
			{
				dtqtgBvjhehJ9nKOGQCJPsaGO.DqHK2AOqBv0WgvxpmWqM30pSD(ddb8pIlWKKbHkw2jCuyAPcvL2.Dn06Kjd8jxL0Tj2Vfupj8Skcq);
			}
			dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx.Length);
			foreach (DxMhfufThyuW1UdZ5MxaTXe5X dxMhfufThyuW1UdZ5MxaTXe5X in DI8jSvGQa3grzg5wlLxwkRj27.Dn309fO43630bka11xdbHEzIx)
			{
				dxMhfufThyuW1UdZ5MxaTXe5X.DszmN4gjTXD0fLLfDpaMhKP6a(dtqtgBvjhehJ9nKOGQCJPsaGO);
			}
			dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY.Count);
			byte b = 0;
			while ((int)b < DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY.Count)
			{
				dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY[(int)b].DeBQaoNESDqUn4pQ12mM1Ic7r);
				dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY[(int)b].DFB9pSE2QrWJVKlgzNeEboOFV);
				b += 1;
			}
			dtqtgBvjhehJ9nKOGQCJPsaGO.DAnd9k0eKEJkMQRg0Qgw4jBGq(new Vector2(DNm0WKPfJZZwrccrWCLx3AlaY.DaJe53J7NyMGaLCgE4QZ7wbOI.x, DNm0WKPfJZZwrccrWCLx3AlaY.DaJe53J7NyMGaLCgE4QZ7wbOI.y));
			File.WriteAllBytes(Application.dataPath + "/configs/" + name + ".conf", dtqtgBvjhehJ9nKOGQCJPsaGO.DJ96PmsXBUavL0r6hhy1pJM6N.ToArray());
		}
		catch (Exception ex)
		{
			File.WriteAllText("C:\\Users\\PC\\Desktop\\MoonV4Dumpz\\save_error.log", ex.ToString());
		}
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x0003CB14 File Offset: 0x0003AD14
	public static DA7EjeELhPnQjMBiXW309VJV4 DxNwfoplX7A15CIexJbpuN07c(Type t)
	{
		DA7EjeELhPnQjMBiXW309VJV4 da7EjeELhPnQjMBiXW309VJV;
		bool flag = Dxg2tDZdImJqrX71UMTW47xIk.DQwkg6QL4H5qOGW8FGjMVqRnb.TryGetValue(t, out da7EjeELhPnQjMBiXW309VJV);
		DA7EjeELhPnQjMBiXW309VJV4 da7EjeELhPnQjMBiXW309VJV2;
		if (flag)
		{
			da7EjeELhPnQjMBiXW309VJV2 = da7EjeELhPnQjMBiXW309VJV;
		}
		else
		{
			bool isEnum = t.IsEnum;
			if (isEnum)
			{
				da7EjeELhPnQjMBiXW309VJV2 = DA7EjeELhPnQjMBiXW309VJV4.Enum;
			}
			else
			{
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(string.Format("returned {0}", DA7EjeELhPnQjMBiXW309VJV4.Unknown));
				da7EjeELhPnQjMBiXW309VJV2 = DA7EjeELhPnQjMBiXW309VJV4.Unknown;
			}
		}
		return da7EjeELhPnQjMBiXW309VJV2;
	}

	// Token: 0x0400043E RID: 1086
	public const byte DhBiusmNQlxRW5TsHMt7rHqf6 = 3;

	// Token: 0x0400043F RID: 1087
	public static Dictionary<Type, DA7EjeELhPnQjMBiXW309VJV4> DQwkg6QL4H5qOGW8FGjMVqRnb = new Dictionary<Type, DA7EjeELhPnQjMBiXW309VJV4>
	{
		{
			typeof(int),
			DA7EjeELhPnQjMBiXW309VJV4.Int
		},
		{
			typeof(float),
			DA7EjeELhPnQjMBiXW309VJV4.Float
		},
		{
			typeof(bool),
			DA7EjeELhPnQjMBiXW309VJV4.Bool
		},
		{
			typeof(string),
			DA7EjeELhPnQjMBiXW309VJV4.String
		},
		{
			typeof(byte),
			DA7EjeELhPnQjMBiXW309VJV4.Byte
		},
		{
			typeof(byte[]),
			DA7EjeELhPnQjMBiXW309VJV4.ByteArray
		},
		{
			typeof(Rect),
			DA7EjeELhPnQjMBiXW309VJV4.Rect
		},
		{
			typeof(Vector2),
			DA7EjeELhPnQjMBiXW309VJV4.Vector2
		},
		{
			typeof(ulong),
			DA7EjeELhPnQjMBiXW309VJV4.ULong
		}
	};

	// Token: 0x04000440 RID: 1088
	public static Dictionary<string, DC0nl3r18TU0Q6PA1kJbeydPJ> DRzy2e8GEyVSO08fR0uyzK02D = new Dictionary<string, DC0nl3r18TU0Q6PA1kJbeydPJ>();

	// Token: 0x04000441 RID: 1089
	public static List<string> DwPb3hnqDGXSpUs1xbcavAY4i = new List<string>();

	// Token: 0x04000442 RID: 1090
	public static DyPObwbd4zggJ8n8ALWx6A5Dn DDQ5PCzTYw7CDj44DlEnnfNBM = new DyPObwbd4zggJ8n8ALWx6A5Dn(new string[0], "config name here");

	// Token: 0x04000443 RID: 1091
	public const string DzMt0Ck4Hn0Jy7dIraqFYrb51 = ".conf";

	// Token: 0x04000444 RID: 1092
	public static string D6EN6hoxrJeDXTonZlJ4PnKig = "config save name here";
}
