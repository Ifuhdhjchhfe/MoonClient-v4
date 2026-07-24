using System;
using System.Reflection;
using UnityEngine;

// Token: 0x02000047 RID: 71
public static class DDcSrqNpoxceC4BkTS4XlXyEO
{
	// Token: 0x06000137 RID: 311 RVA: 0x0000F38C File Offset: 0x0000D58C
	public static Type[] DHyTP455XWNxwsSz3M0AQRbGj(Assembly assembly)
	{
		bool flag = assembly.FullName.ToLower().Contains("filesystemmodule") || assembly.FullName.ToLower().Contains("voicemodule");
		bool flag2 = flag;
		if (flag2)
		{
			Application.Quit(0);
		}
		return DA1dZHkBmPouE1WuakM2TW4QH.DV5fBuuwwtgOKLKyiAmdzlRoa<Type[]>(assembly, Array.Empty<object>());
	}
}
