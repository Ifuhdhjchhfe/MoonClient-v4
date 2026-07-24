using System;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000027 RID: 39
public class D9sqUkDmUbz7uUc5edvQF8hDl
{
	// Token: 0x060000AE RID: 174 RVA: 0x000088D0 File Offset: 0x00006AD0
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerLifeUI), "hasCompassInInventory", new Type[] { })]
	protected static bool Dbxlp1cyhOcav3CtJ5A0Zs2ZV()
	{
		return D5l46jlssr4TRAzUSXzLj0uqu.imitCompassInInventory || DA1dZHkBmPouE1WuakM2TW4QH.DbnCove2eID4Rs6wqrevxPwBP<bool>();
	}

	// Token: 0x060000AF RID: 175 RVA: 0x000088F4 File Offset: 0x00006AF4
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerLifeUI), "updateGrayscale", new Type[] { })]
	public static void D2hcRGy0VyZxVqJMX9bijVbJx()
	{
		bool flag = !Provider.isConnected;
		bool flag2 = !flag;
		if (flag2)
		{
			bool noGrayscale = D5l46jlssr4TRAzUSXzLj0uqu.noGrayscale;
			bool flag3 = noGrayscale;
			if (flag3)
			{
				Component component = Player.player.animator.viewmodelCameraTransform.GetComponent("GrayscaleEffect");
				Component component2 = MainCamera.instance.GetComponent("GrayscaleEffect");
				Component component3 = Player.player.look.characterCamera.GetComponent("GrayscaleEffect");
				bool flag4 = component != null;
				if (flag4)
				{
					FieldInfo field = component.GetType().GetField("blend");
					if (field != null)
					{
						field.SetValue(component, 0f);
					}
				}
				bool flag5 = component2 != null;
				bool flag6 = flag5;
				if (flag6)
				{
					FieldInfo field2 = component2.GetType().GetField("blend");
					if (field2 != null)
					{
						field2.SetValue(component2, 0f);
					}
				}
				bool flag7 = component3 != null;
				if (flag7)
				{
					FieldInfo field3 = component3.GetType().GetField("blend");
					if (field3 != null)
					{
						field3.SetValue(component3, 0f);
					}
				}
			}
			else
			{
				try
				{
					DA1dZHkBmPouE1WuakM2TW4QH.DElQjEDm4573wecG7fo2S4dus();
				}
				catch
				{
				}
			}
		}
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00008A40 File Offset: 0x00006C40
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerLifeUI), "onDamaged", new Type[] { })]
	private static void D4RwDHVuQyCV8Boju9Be3Uuck(byte damage)
	{
		bool flag = damage > 5 && !D5l46jlssr4TRAzUSXzLj0uqu.noPain;
		bool flag2 = flag;
		if (flag2)
		{
			PlayerUI.pain(Mathf.Clamp((float)damage / 40f, 0f, 1f));
		}
	}
}
