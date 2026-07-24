using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x020000E7 RID: 231
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	// Token: 0x06000444 RID: 1092 RVA: 0x0003F81B File Offset: 0x0003DA1B
	internal Resources()
	{
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06000445 RID: 1093 RVA: 0x0003F828 File Offset: 0x0003DA28
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			bool flag = Resources.resourceMan == null;
			if (flag)
			{
				Resources.resourceMan = new ResourceManager("UnityEngine.Properties.Resources", typeof(Resources).Assembly);
			}
			return Resources.resourceMan;
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06000446 RID: 1094 RVA: 0x0003F86C File Offset: 0x0003DA6C
	// (set) Token: 0x06000447 RID: 1095 RVA: 0x0003F883 File Offset: 0x0003DA83
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return Resources.resourceCulture;
		}
		set
		{
			Resources.resourceCulture = value;
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06000448 RID: 1096 RVA: 0x0003F88C File Offset: 0x0003DA8C
	internal static string BuildDate
	{
		get
		{
			return Resources.ResourceManager.GetString("BuildDate", Resources.resourceCulture);
		}
	}

	// Token: 0x04000499 RID: 1177
	private static ResourceManager resourceMan;

	// Token: 0x0400049A RID: 1178
	private static CultureInfo resourceCulture;
}
