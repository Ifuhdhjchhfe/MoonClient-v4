using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

// Token: 0x02000098 RID: 152
public class DovA0560C5xwc06yYBWmht6vA
{
	// Token: 0x060002E5 RID: 741 RVA: 0x0002A25C File Offset: 0x0002845C
	public static string DwmN6yoLnoGKelNANk6J2UoTv()
	{
		DateTime now = DateTime.Now;
		string text = ((now.Second < 10) ? ("0" + now.Second.ToString()) : now.Second.ToString());
		string text2 = ((now.Hour < 10) ? ("0" + now.Hour.ToString()) : now.Hour.ToString());
		string text3 = ((now.Minute < 10) ? ("0" + now.Minute.ToString()) : now.Minute.ToString());
		return string.Concat(new string[] { text2, ":", text3, ":", text });
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x0002A348 File Offset: 0x00028548
	public static void DJLSiCuX3YMDESkxQAbGyyrgD()
	{
		bool flag = DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.Count > 3000;
		if (flag)
		{
			DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.Remove(DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.First<string>());
		}
		bool flag2 = DovA0560C5xwc06yYBWmht6vA.DIMZq0moQ9Z4aIeIwVnQ7EjDq.Count > 3000;
		if (flag2)
		{
			DovA0560C5xwc06yYBWmht6vA.DIMZq0moQ9Z4aIeIwVnQ7EjDq.Remove(DovA0560C5xwc06yYBWmht6vA.DIMZq0moQ9Z4aIeIwVnQ7EjDq.First<string>());
		}
		bool flag3 = DovA0560C5xwc06yYBWmht6vA.DQomy0cNRnzM0Q09KIWr8hyKI.Count > 3000;
		if (flag3)
		{
			DovA0560C5xwc06yYBWmht6vA.DQomy0cNRnzM0Q09KIWr8hyKI.Remove(DovA0560C5xwc06yYBWmht6vA.DQomy0cNRnzM0Q09KIWr8hyKI.First<string>());
		}
		bool flag4 = DovA0560C5xwc06yYBWmht6vA.DCgg0qYxFHUhHRZX5T00i6ujT.Count > 3000;
		if (flag4)
		{
			DovA0560C5xwc06yYBWmht6vA.DCgg0qYxFHUhHRZX5T00i6ujT.Remove(DovA0560C5xwc06yYBWmht6vA.DCgg0qYxFHUhHRZX5T00i6ujT.First<string>());
		}
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x0002A408 File Offset: 0x00028608
	public static void D2XDJbj97cXeWm21NhElh6XXL(string s)
	{
		bool enableUserLogger = DfU4wrswBK5kLyiyV6mHZwOg8.enableUserLogger;
		if (enableUserLogger)
		{
			DovA0560C5xwc06yYBWmht6vA.DbOpq1Dx26hu5wu29FfQKwlzi.Add(new ValueTuple<string, float>(s, 0f));
		}
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x0002A438 File Offset: 0x00028638
	public static void D60HHVRdFy0n03MPDLSIsY9W9()
	{
		bool enableUserLogger = DfU4wrswBK5kLyiyV6mHZwOg8.enableUserLogger;
		if (enableUserLogger)
		{
			for (int i = 0; i < DovA0560C5xwc06yYBWmht6vA.DbOpq1Dx26hu5wu29FfQKwlzi.Count; i++)
			{
				DovA0560C5xwc06yYBWmht6vA.DbOpq1Dx26hu5wu29FfQKwlzi[i] = new ValueTuple<string, float>(DovA0560C5xwc06yYBWmht6vA.DbOpq1Dx26hu5wu29FfQKwlzi[i].Item1, DovA0560C5xwc06yYBWmht6vA.DbOpq1Dx26hu5wu29FfQKwlzi[i].Item2 + Time.deltaTime);
				bool flag = DovA0560C5xwc06yYBWmht6vA.DbOpq1Dx26hu5wu29FfQKwlzi[i].Item2 > 5f;
				if (flag)
				{
					DovA0560C5xwc06yYBWmht6vA.DbOpq1Dx26hu5wu29FfQKwlzi.RemoveAt(i);
				}
			}
		}
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x0002A4CC File Offset: 0x000286CC
	public static void D7albBMQESa0fbdFJ1bbTI6zK(string s)
	{
		try
		{
			DovA0560C5xwc06yYBWmht6vA.DCgg0qYxFHUhHRZX5T00i6ujT.Add("[" + DovA0560C5xwc06yYBWmht6vA.DwmN6yoLnoGKelNANk6J2UoTv() + "] [Unturned] " + s);
			DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.Add("[" + DovA0560C5xwc06yYBWmht6vA.DwmN6yoLnoGKelNANk6J2UoTv() + "] [Unturned] " + s);
			DovA0560C5xwc06yYBWmht6vA.DJLSiCuX3YMDESkxQAbGyyrgD();
			bool dtfo7I1kbT4SC4NokdAQjG17G = DovA0560C5xwc06yYBWmht6vA.DTFo7I1kbT4SC4NokdAQjG17G;
			if (dtfo7I1kbT4SC4NokdAQjG17G)
			{
				try
				{
					File.AppendAllText(Application.dataPath + "/logs.txt", DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.ElementAt<string>(DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.Count - 1) + Environment.NewLine);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x060002EA RID: 746 RVA: 0x0002A590 File Offset: 0x00028790
	public static void D0pbibQ1BPsa4ML03M0UEiJXf(string text, string stack, LogType type)
	{
		try
		{
			DovA0560C5xwc06yYBWmht6vA.DIMZq0moQ9Z4aIeIwVnQ7EjDq.Add("[" + DovA0560C5xwc06yYBWmht6vA.DwmN6yoLnoGKelNANk6J2UoTv() + "] [Unity] " + text);
			DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.Add("[" + DovA0560C5xwc06yYBWmht6vA.DwmN6yoLnoGKelNANk6J2UoTv() + "] [Unity] " + text);
			DovA0560C5xwc06yYBWmht6vA.DJLSiCuX3YMDESkxQAbGyyrgD();
			bool dtfo7I1kbT4SC4NokdAQjG17G = DovA0560C5xwc06yYBWmht6vA.DTFo7I1kbT4SC4NokdAQjG17G;
			if (dtfo7I1kbT4SC4NokdAQjG17G)
			{
				try
				{
					File.AppendAllText(Application.dataPath + "/logs.txt", DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.ElementAt<string>(DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.Count - 1) + Environment.NewLine);
				}
				catch
				{
				}
			}
			bool flag = type <= LogType.Warning || type == LogType.Exception;
			if (flag)
			{
				DovA0560C5xwc06yYBWmht6vA.DIMZq0moQ9Z4aIeIwVnQ7EjDq.Add("[" + DovA0560C5xwc06yYBWmht6vA.DwmN6yoLnoGKelNANk6J2UoTv() + "] [Unity] Stack: " + stack);
				DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.Add("[" + DovA0560C5xwc06yYBWmht6vA.DwmN6yoLnoGKelNANk6J2UoTv() + "] [Unity] Stack: " + stack);
				DovA0560C5xwc06yYBWmht6vA.DJLSiCuX3YMDESkxQAbGyyrgD();
				bool dtfo7I1kbT4SC4NokdAQjG17G2 = DovA0560C5xwc06yYBWmht6vA.DTFo7I1kbT4SC4NokdAQjG17G;
				if (dtfo7I1kbT4SC4NokdAQjG17G2)
				{
					try
					{
						File.AppendAllText(Application.dataPath + "/logs.txt", DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.ElementAt<string>(DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.Count - 1) + Environment.NewLine);
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x060002EB RID: 747 RVA: 0x0002A728 File Offset: 0x00028928
	public static void DC7YaTDHyZQRGosJeT1YY4oti(string s)
	{
		try
		{
			DovA0560C5xwc06yYBWmht6vA.DQomy0cNRnzM0Q09KIWr8hyKI.Add("[" + DovA0560C5xwc06yYBWmht6vA.DwmN6yoLnoGKelNANk6J2UoTv() + "] [Client] " + s);
			DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.Add("[" + DovA0560C5xwc06yYBWmht6vA.DwmN6yoLnoGKelNANk6J2UoTv() + "] [Client] " + s);
			DovA0560C5xwc06yYBWmht6vA.DJLSiCuX3YMDESkxQAbGyyrgD();
			bool dtfo7I1kbT4SC4NokdAQjG17G = DovA0560C5xwc06yYBWmht6vA.DTFo7I1kbT4SC4NokdAQjG17G;
			if (dtfo7I1kbT4SC4NokdAQjG17G)
			{
				try
				{
					File.AppendAllText(Application.dataPath + "/logs.txt", DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.ElementAt<string>(DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6.Count - 1) + Environment.NewLine);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x060002EC RID: 748 RVA: 0x0002A7EC File Offset: 0x000289EC
	public static void DCONWCbCXpSVJfS7p56RPY2Mn()
	{
		bool dtfo7I1kbT4SC4NokdAQjG17G = DovA0560C5xwc06yYBWmht6vA.DTFo7I1kbT4SC4NokdAQjG17G;
		if (dtfo7I1kbT4SC4NokdAQjG17G)
		{
			File.WriteAllText(Application.dataPath + "/logs.txt", "");
		}
		Application.logMessageReceived += DovA0560C5xwc06yYBWmht6vA.D0pbibQ1BPsa4ML03M0UEiJXf;
		Application.quitting += delegate
		{
			string text = "";
			foreach (string text2 in DovA0560C5xwc06yYBWmht6vA.DZW0gfKex1WeNog2rSxEi36q6)
			{
				text = text + text2 + Environment.NewLine;
			}
			try
			{
				File.WriteAllText(Application.dataPath + "/logs.txt", text);
			}
			catch
			{
			}
		};
	}

	// Token: 0x04000343 RID: 835
	public static HashSet<string> DZW0gfKex1WeNog2rSxEi36q6 = new HashSet<string>();

	// Token: 0x04000344 RID: 836
	public static HashSet<string> DIMZq0moQ9Z4aIeIwVnQ7EjDq = new HashSet<string>();

	// Token: 0x04000345 RID: 837
	public static HashSet<string> DQomy0cNRnzM0Q09KIWr8hyKI = new HashSet<string>();

	// Token: 0x04000346 RID: 838
	public static HashSet<string> DCgg0qYxFHUhHRZX5T00i6ujT = new HashSet<string>();

	// Token: 0x04000347 RID: 839
	public static List<ValueTuple<string, float>> DbOpq1Dx26hu5wu29FfQKwlzi = new List<ValueTuple<string, float>>();

	// Token: 0x04000348 RID: 840
	private static bool DTFo7I1kbT4SC4NokdAQjG17G = true;
}
