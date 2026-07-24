using System;
using System.IO;
using System.Text;
using Microsoft.Win32;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000BC RID: 188
public static class DubwRZDNcKTA0S1bUvkpiAdy4
{
	// Token: 0x060003B7 RID: 951 RVA: 0x000377A4 File Offset: 0x000359A4
	public static byte[] D85pAemfYEMKdHewxt6x3hkN8()
	{
		return Hash.SHA1("Zpsz+h>nJ!?4h2&nVPVw=DmG" + Guid.NewGuid().ToString("N"));
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x000377D8 File Offset: 0x000359D8
	public static byte[] DpzV5wZqVlu0VITJXp0TYntHe()
	{
		string text = Guid.NewGuid().ToString();
		StringBuilder stringBuilder = new StringBuilder("Zpsz+h>nJ!?4h2&nVPVw=DmG".Length + text.Length + 48);
		stringBuilder.Append("Zpsz+h>nJ!?4h2&nVPVw=DmG");
		stringBuilder.Append(text);
		stringBuilder.Append(DubwRZDNcKTA0S1bUvkpiAdy4.Df1DDv0rQF6wdq2zkxrxBKB3B());
		stringBuilder.Append("00000000000000E0");
		return Hash.SHA1(stringBuilder.ToString());
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00037850 File Offset: 0x00035A50
	public static string Df1DDv0rQF6wdq2zkxrxBKB3B()
	{
		string text = "";
		text += global::UnityEngine.Random.Range(0, 10).ToString();
		text += global::UnityEngine.Random.Range(0, 10).ToString();
		text += global::UnityEngine.Random.Range(0, 10).ToString();
		text += DubwRZDNcKTA0S1bUvkpiAdy4.DsU8CbQO75POMUxpv2BtDu6ed[global::UnityEngine.Random.Range(0, DubwRZDNcKTA0S1bUvkpiAdy4.DsU8CbQO75POMUxpv2BtDu6ed.Length)].ToString();
		text += global::UnityEngine.Random.Range(0, 10).ToString();
		text += DubwRZDNcKTA0S1bUvkpiAdy4.DsU8CbQO75POMUxpv2BtDu6ed[global::UnityEngine.Random.Range(0, DubwRZDNcKTA0S1bUvkpiAdy4.DsU8CbQO75POMUxpv2BtDu6ed.Length)].ToString();
		text += global::UnityEngine.Random.Range(0, 10).ToString();
		text += global::UnityEngine.Random.Range(0, 10).ToString();
		text += DubwRZDNcKTA0S1bUvkpiAdy4.DsU8CbQO75POMUxpv2BtDu6ed[global::UnityEngine.Random.Range(0, DubwRZDNcKTA0S1bUvkpiAdy4.DsU8CbQO75POMUxpv2BtDu6ed.Length)].ToString();
		text += global::UnityEngine.Random.Range(0, 10).ToString();
		text += ((global::UnityEngine.Random.Range(0, 2) == 1) ? DubwRZDNcKTA0S1bUvkpiAdy4.DsU8CbQO75POMUxpv2BtDu6ed[global::UnityEngine.Random.Range(0, DubwRZDNcKTA0S1bUvkpiAdy4.DsU8CbQO75POMUxpv2BtDu6ed.Length)].ToString() : global::UnityEngine.Random.Range(0, 10).ToString());
		return text + DubwRZDNcKTA0S1bUvkpiAdy4.DsU8CbQO75POMUxpv2BtDu6ed[global::UnityEngine.Random.Range(0, DubwRZDNcKTA0S1bUvkpiAdy4.DsU8CbQO75POMUxpv2BtDu6ed.Length)].ToString();
	}

	// Token: 0x060003BA RID: 954 RVA: 0x000379D4 File Offset: 0x00035BD4
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "ChangePseudoHWID")]
	public static void D3oogpAfEzKKlsLUnPd5YLmKA()
	{
		D5l46jlssr4TRAzUSXzLj0uqu.DRywCzlrtImzxkGhDOTGcBASd = DubwRZDNcKTA0S1bUvkpiAdy4.D85pAemfYEMKdHewxt6x3hkN8();
		D5l46jlssr4TRAzUSXzLj0uqu.DTJpui0sqNkukyZlpsiFS5Vbv = DubwRZDNcKTA0S1bUvkpiAdy4.D85pAemfYEMKdHewxt6x3hkN8();
		D5l46jlssr4TRAzUSXzLj0uqu.DHuZ6stX7WaYQtYnBbmwbMew0 = DubwRZDNcKTA0S1bUvkpiAdy4.DpzV5wZqVlu0VITJXp0TYntHe();
		DTQTgBvjhehJ9nKOGQCJPsaGO dtqtgBvjhehJ9nKOGQCJPsaGO = new DTQTgBvjhehJ9nKOGQCJPsaGO();
		dtqtgBvjhehJ9nKOGQCJPsaGO.DWoug57y0MCZVj5PIjkNVZncd(D5l46jlssr4TRAzUSXzLj0uqu.DRywCzlrtImzxkGhDOTGcBASd);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DWoug57y0MCZVj5PIjkNVZncd(D5l46jlssr4TRAzUSXzLj0uqu.DTJpui0sqNkukyZlpsiFS5Vbv);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DWoug57y0MCZVj5PIjkNVZncd(D5l46jlssr4TRAzUSXzLj0uqu.DHuZ6stX7WaYQtYnBbmwbMew0);
		File.WriteAllBytes(Application.dataPath + "/pseudohwids", dtqtgBvjhehJ9nKOGQCJPsaGO.DJ96PmsXBUavL0r6hhy1pJM6N.ToArray());
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00037A4C File Offset: 0x00035C4C
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "ChangeRealHWID")]
	public static void DSae8LpHiiREqS3pu7fL1kRLr()
	{
		byte[] array = new byte[]
		{
			104, 115, 97, 72, 101, 103, 97, 114, 111, 116,
			83, 100, 117, 111, 108, 67
		};
		Array.Reverse(array);
		string text = Encoding.UTF8.GetString(array);
		PlayerPrefs.SetString(text, Guid.NewGuid().ToString("N"));
		array = new byte[]
		{
			101, 104, 99, 97, 67, 101, 114, 111, 116, 83,
			109, 101, 116, 73
		};
		Array.Reverse(array);
		text = Encoding.UTF8.GetString(array);
		ConvenientSavedata.get().write(text, Guid.NewGuid().ToString("N"));
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", Guid.NewGuid().ToString());
	}

	// Token: 0x040003E3 RID: 995
	public static char[] Dh4PRHvr2YeRBkqL4kaVSNgJL = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

	// Token: 0x040003E4 RID: 996
	public static char[] DsU8CbQO75POMUxpv2BtDu6ed = new char[] { 'A', 'B', 'E', 'D' };
}
