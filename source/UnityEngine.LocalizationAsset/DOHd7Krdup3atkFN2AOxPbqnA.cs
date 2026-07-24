using System;
using System.Collections.Generic;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000095 RID: 149
public class DOHd7Krdup3atkFN2AOxPbqnA
{
	// Token: 0x060002D9 RID: 729 RVA: 0x00029DE0 File Offset: 0x00027FE0
	[DyRHDWg89xeNs0wA42v5OHmTi]
	public static void DlJ3oCEic0W971EkT9BIEMMGo()
	{
		DOHd7Krdup3atkFN2AOxPbqnA.DxvUCGCSgxYV8Ry9n1bmA7d77 = typeof(InteractableItem).GetField("wasReset", BindingFlags.Instance | BindingFlags.NonPublic);
		Provider.onClientDisconnected = (Provider.ClientDisconnected)Delegate.Combine(Provider.onClientDisconnected, new Provider.ClientDisconnected(DOHd7Krdup3atkFN2AOxPbqnA.DYqTh4DLl8VDpMxnOjBPXM6fA));
	}

	// Token: 0x060002DA RID: 730 RVA: 0x00029E1E File Offset: 0x0002801E
	public static void DYqTh4DLl8VDpMxnOjBPXM6fA()
	{
		DOHd7Krdup3atkFN2AOxPbqnA.DWSHDsX20pj51yeYJq0WnerH0.Clear();
	}

	// Token: 0x060002DB RID: 731 RVA: 0x00029E2C File Offset: 0x0002802C
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(InteractableItem), "OnEnable", BindingFlags.Instance | BindingFlags.NonPublic, new Type[] { })]
	public static void DHbBJGnJIPx0sIV14eufeiIF0(InteractableItem instance)
	{
		ItemManager.clampedItems.Add(instance);
		DOHd7Krdup3atkFN2AOxPbqnA.DWSHDsX20pj51yeYJq0WnerH0.Add(instance);
	}

	// Token: 0x060002DC RID: 732 RVA: 0x00029E48 File Offset: 0x00028048
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(InteractableItem), "OnDisable", BindingFlags.Instance | BindingFlags.NonPublic, new Type[] { })]
	public static void DmQJiXqKXAurlagsIF7kvwxuF(InteractableItem instance)
	{
		bool flag = Time.realtimeSinceStartup - DOHd7Krdup3atkFN2AOxPbqnA.D0dSr932iay5E0Oa1anwV6Apy > 2.5f;
		if (flag)
		{
			DOHd7Krdup3atkFN2AOxPbqnA.D0dSr932iay5E0Oa1anwV6Apy = Time.realtimeSinceStartup;
			for (int i = 0; i < DOHd7Krdup3atkFN2AOxPbqnA.DWSHDsX20pj51yeYJq0WnerH0.Count; i++)
			{
				bool flag2 = DOHd7Krdup3atkFN2AOxPbqnA.DWSHDsX20pj51yeYJq0WnerH0[i] == null;
				if (flag2)
				{
					DOHd7Krdup3atkFN2AOxPbqnA.DWSHDsX20pj51yeYJq0WnerH0.RemoveAt(i);
				}
			}
		}
		bool flag3 = (bool)DOHd7Krdup3atkFN2AOxPbqnA.DxvUCGCSgxYV8Ry9n1bmA7d77.GetValue(instance);
		if (flag3)
		{
			ItemManager.clampedItems.RemoveFast(instance);
		}
	}

	// Token: 0x060002DD RID: 733 RVA: 0x00029EDC File Offset: 0x000280DC
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(InteractableItem), "use", new Type[] { })]
	private static void D1DWdDEVyqqH0RGvHWs0h690j(InteractableItem instance)
	{
		DovA0560C5xwc06yYBWmht6vA.D2XDJbj97cXeWm21NhElh6XXL(string.Concat(new object[]
		{
			"[+] Picked up ",
			instance.asset.name,
			" ID ",
			instance.asset.id
		}));
		ItemManager.takeItem(instance.transform.parent, byte.MaxValue, byte.MaxValue, 0, byte.MaxValue);
	}

	// Token: 0x0400033A RID: 826
	public static FieldInfo DxvUCGCSgxYV8Ry9n1bmA7d77;

	// Token: 0x0400033B RID: 827
	public static List<InteractableItem> DWSHDsX20pj51yeYJq0WnerH0 = new List<InteractableItem>();

	// Token: 0x0400033C RID: 828
	[SerializeField]
	private static MonoBehaviour monoBehaviour;

	// Token: 0x0400033D RID: 829
	public static float D0dSr932iay5E0Oa1anwV6Apy = 0f;
}
