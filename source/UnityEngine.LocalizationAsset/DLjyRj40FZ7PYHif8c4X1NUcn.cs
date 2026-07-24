using System;
using System.Collections.Generic;
using System.Reflection;
using SDG.Unturned;

// Token: 0x02000082 RID: 130
public class DLjyRj40FZ7PYHif8c4X1NUcn
{
	// Token: 0x0600026F RID: 623 RVA: 0x00025357 File Offset: 0x00023557
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DTtl3Nzle0gieCUoIwHRUHvR9()
	{
		Provider.onClientDisconnected = (Provider.ClientDisconnected)Delegate.Combine(Provider.onClientDisconnected, new Provider.ClientDisconnected(DLjyRj40FZ7PYHif8c4X1NUcn.DDvPJM4WveNpDGmXavrc9q2qm));
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0002537A File Offset: 0x0002357A
	public static void DDvPJM4WveNpDGmXavrc9q2qm()
	{
		DLjyRj40FZ7PYHif8c4X1NUcn.DD30C4J2BCAh7gXdMzJpEedQk.Clear();
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00025388 File Offset: 0x00023588
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(Zombie), "init", BindingFlags.Instance | BindingFlags.Public, new Type[] { })]
	public static void DSTfegMSo9gfZ1At1SLsCUMWU(Zombie instance)
	{
		DLjyRj40FZ7PYHif8c4X1NUcn.DD30C4J2BCAh7gXdMzJpEedQk.Add(instance);
		DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(instance, Array.Empty<object>());
	}

	// Token: 0x0400030A RID: 778
	public static List<Zombie> DD30C4J2BCAh7gXdMzJpEedQk = new List<Zombie>();
}
