using System;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000A2 RID: 162
public class DQft7Ah68ki8Ta3kg2pC16qNB
{
	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000318 RID: 792 RVA: 0x0002F298 File Offset: 0x0002D498
	private bool canOpenMenus
	{
		get
		{
			return (!(Player.player != null) || !Player.player.equipment.isUseableShowingMenu) && !PlayerUI.window.showCursor && !PlayerLifeUI.chatting;
		}
	}

	// Token: 0x06000319 RID: 793 RVA: 0x0002F2E0 File Offset: 0x0002D4E0
	[DyRHDWg89xeNs0wA42v5OHmTi]
	public static void DINC9XTvgQ0wxjiPZoA6ukJDO()
	{
		DQft7Ah68ki8Ta3kg2pC16qNB.DOU5A91GNZTS5s1b0Sz29Cv3L = typeof(PlayerUI).GetMethod("UpdateWindowEnabled", BindingFlags.Static | BindingFlags.NonPublic);
		DQft7Ah68ki8Ta3kg2pC16qNB.DCfam5fqm8oVhDH24Bmb9rrbU = typeof(PlayerUI).GetField("usingCustomModal", BindingFlags.Static | BindingFlags.NonPublic);
		DQft7Ah68ki8Ta3kg2pC16qNB.DptMTgm3ZZroZNEcHucdYuXNQ = typeof(PlayerUI).GetField("instance", BindingFlags.Static | BindingFlags.NonPublic);
	}

	// Token: 0x0600031A RID: 794 RVA: 0x0002F33F File Offset: 0x0002D53F
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerUI), "updateScope", new Type[] { })]
	public static void DXUgQEocN4CEojjcDJWuXv1fR(bool isScoped)
	{
		isScoped = !D5l46jlssr4TRAzUSXzLj0uqu.disableScopeOverlayH && isScoped;
		PlayerLifeUI.scopeOverlay.IsVisible = isScoped;
		PlayerUI.container.IsVisible = !isScoped;
		DQft7Ah68ki8Ta3kg2pC16qNB.DOU5A91GNZTS5s1b0Sz29Cv3L.Invoke(null, new object[0]);
	}

	// Token: 0x0600031B RID: 795 RVA: 0x0002F37B File Offset: 0x0002D57B
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerUI), "updateBinoculars", new Type[] { })]
	public static void DEOmwpO7ZSLK9Eo34hRq25CMo(bool isBinoculars)
	{
		isBinoculars = !D5l46jlssr4TRAzUSXzLj0uqu.disableBinocularOverlay && isBinoculars;
		PlayerLifeUI.binocularsOverlay.IsVisible = isBinoculars;
		PlayerUI.container.IsVisible = !isBinoculars;
		DQft7Ah68ki8Ta3kg2pC16qNB.DOU5A91GNZTS5s1b0Sz29Cv3L.Invoke(null, new object[0]);
	}

	// Token: 0x0600031C RID: 796 RVA: 0x0002F3B8 File Offset: 0x0002D5B8
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerUI), "stun", new Type[] { })]
	public static void DQmIPxTpREHwp5T5UAq3lwDN6(Color color, float amount)
	{
		bool flag = !D5l46jlssr4TRAzUSXzLj0uqu.noFlash;
		if (flag)
		{
			DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(null, new object[] { color, amount });
		}
	}

	// Token: 0x0400037F RID: 895
	public static MethodInfo DOU5A91GNZTS5s1b0Sz29Cv3L;

	// Token: 0x04000380 RID: 896
	public static FieldInfo DCfam5fqm8oVhDH24Bmb9rrbU;

	// Token: 0x04000381 RID: 897
	public static FieldInfo DptMTgm3ZZroZNEcHucdYuXNQ;
}
