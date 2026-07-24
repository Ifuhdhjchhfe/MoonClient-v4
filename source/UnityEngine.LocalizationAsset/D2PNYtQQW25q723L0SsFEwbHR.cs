using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000010 RID: 16
public class D2PNYtQQW25q723L0SsFEwbHR : DSvAEyoSitLrXzsZSSRwWfJ5T
{
	// Token: 0x06000049 RID: 73 RVA: 0x0000472C File Offset: 0x0000292C
	public override bool GetAviablity()
	{
		return D5l46jlssr4TRAzUSXzLj0uqu.showWeaponInfo && Provider.isConnected && Player.player != null && Player.player.equipment.asset != null && (Player.player.equipment.asset is ItemGunAsset || Player.player.equipment.asset is ItemMeleeAsset);
	}

	// Token: 0x0600004A RID: 74 RVA: 0x000047A0 File Offset: 0x000029A0
	public override bool UseStaticRect()
	{
		return D5l46jlssr4TRAzUSXzLj0uqu.useStaticRectForWeaponInfo;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x000047B8 File Offset: 0x000029B8
	public override Rect GetStaticRect()
	{
		return new Rect((float)(Screen.width - 175), (float)(Screen.height / 2 - 85), 175f, 170f);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x000047F0 File Offset: 0x000029F0
	public override Vector2 GetSize()
	{
		return new Vector2(175f, 170f);
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00004814 File Offset: 0x00002A14
	public override void DrawWindow()
	{
		base.DZxuXSmWDxed28SbJ8XfD3yXH("Weapon Information");
		bool flag = Ddagemt6Wc3UeyV4EYXNrXcFf.aimObjective.DKr6XbLZDMiJmmxABXHlfTTLz == Dr5qliNNQh3jZolh9fn7SFNyi.Player;
		Player player = ((flag && Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC != null) ? ((Player)Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC) : null);
		bool flag2 = Player.player.equipment.asset is ItemGunAsset;
		bool flag3 = flag2;
		if (flag3)
		{
			ItemGunAsset itemGunAsset = Player.player.equipment.asset as ItemGunAsset;
			this.DUtlHcYmZm4fu6X0zsiUggaqU(string.Format("{0} - {1}", itemGunAsset.itemName, itemGunAsset.id));
			this.DUtlHcYmZm4fu6X0zsiUggaqU(string.Format("Range: {0}", DmErKmxWRjHNSG8p8mCUQIUbM.D3lA05pX4HfBlOQWdxeK6L6B8()));
			string text = ((flag && player != null) ? string.Format(" * {0} = {1}", DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.SKULL, player), itemGunAsset.playerDamageMultiplier.damage * itemGunAsset.playerDamageMultiplier.skull * DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.SKULL, player)) : "");
			string text2 = ((flag && player != null) ? string.Format(" * {0} = {1}", DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.SPINE, player), itemGunAsset.playerDamageMultiplier.damage * itemGunAsset.playerDamageMultiplier.spine * DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.SPINE, player)) : "");
			string text3 = ((flag && player != null) ? string.Format(" * {0} = {1}", DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.LEFT_ARM, player), itemGunAsset.playerDamageMultiplier.damage * itemGunAsset.playerDamageMultiplier.arm * DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.LEFT_ARM, player)) : "");
			string text4 = ((flag && player != null) ? string.Format(" * {0} = {1}", DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.LEFT_LEG, player), itemGunAsset.playerDamageMultiplier.damage * itemGunAsset.playerDamageMultiplier.leg * DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.LEFT_LEG, player)) : "");
			this.DUtlHcYmZm4fu6X0zsiUggaqU(string.Format("Skull: {0}{1}", itemGunAsset.playerDamageMultiplier.damage * itemGunAsset.playerDamageMultiplier.skull, text));
			this.DUtlHcYmZm4fu6X0zsiUggaqU(string.Format("Body: {0}{1}", itemGunAsset.playerDamageMultiplier.damage * itemGunAsset.playerDamageMultiplier.spine, text2));
			this.DUtlHcYmZm4fu6X0zsiUggaqU(string.Format("Arms: {0}{1}", itemGunAsset.playerDamageMultiplier.damage * itemGunAsset.playerDamageMultiplier.arm, text3));
			this.DUtlHcYmZm4fu6X0zsiUggaqU(string.Format("Legs: {0}{1}", itemGunAsset.playerDamageMultiplier.damage * itemGunAsset.playerDamageMultiplier.leg, text4));
			DqNh7bzS0xEILWgxFJA4tpJpp.DQXFOnbg0GOMla0jegOsR2odk(DHTB5RKsHUihFrfj9ewuLh1f9.DPF1WELNU4huo63e3q4cLtYAP(Player.player), 171, 60);
		}
		else
		{
			ItemMeleeAsset itemMeleeAsset = Player.player.equipment.asset as ItemMeleeAsset;
			this.DUtlHcYmZm4fu6X0zsiUggaqU(string.Format("{0} - {1}", itemMeleeAsset.itemName, itemMeleeAsset.id));
			this.DUtlHcYmZm4fu6X0zsiUggaqU(string.Format("Range: {0}", DmErKmxWRjHNSG8p8mCUQIUbM.D3lA05pX4HfBlOQWdxeK6L6B8()));
			string text5 = ((flag && player != null) ? string.Format(" * {0} = {1}", DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.SKULL, player), itemMeleeAsset.playerDamageMultiplier.damage * itemMeleeAsset.playerDamageMultiplier.skull * DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.SKULL, player)) : "");
			string text6 = ((flag && player != null) ? string.Format(" * {0} = {1}", DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.SPINE, player), itemMeleeAsset.playerDamageMultiplier.damage * itemMeleeAsset.playerDamageMultiplier.spine * DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.SPINE, player)) : "");
			string text7 = ((flag && player != null) ? string.Format(" * {0} = {1}", DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.LEFT_ARM, player), itemMeleeAsset.playerDamageMultiplier.damage * itemMeleeAsset.playerDamageMultiplier.arm * DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.LEFT_ARM, player)) : "");
			string text8 = ((flag && player != null) ? string.Format(" * {0} = {1}", DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.LEFT_LEG, player), itemMeleeAsset.playerDamageMultiplier.damage * itemMeleeAsset.playerDamageMultiplier.leg * DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(ELimb.LEFT_LEG, player)) : "");
			this.DUtlHcYmZm4fu6X0zsiUggaqU(string.Format("Skull: {0}{1}", itemMeleeAsset.playerDamageMultiplier.damage * itemMeleeAsset.playerDamageMultiplier.skull, text5));
			this.DUtlHcYmZm4fu6X0zsiUggaqU(string.Format("Body: {0}{1}", itemMeleeAsset.playerDamageMultiplier.damage * itemMeleeAsset.playerDamageMultiplier.spine, text6));
			this.DUtlHcYmZm4fu6X0zsiUggaqU(string.Format("Arms: {0}{1}", itemMeleeAsset.playerDamageMultiplier.damage * itemMeleeAsset.playerDamageMultiplier.arm, text7));
			this.DUtlHcYmZm4fu6X0zsiUggaqU(string.Format("Legs: {0}{1}", itemMeleeAsset.playerDamageMultiplier.damage * itemMeleeAsset.playerDamageMultiplier.leg, text8));
			DqNh7bzS0xEILWgxFJA4tpJpp.DQXFOnbg0GOMla0jegOsR2odk(DHTB5RKsHUihFrfj9ewuLh1f9.DPF1WELNU4huo63e3q4cLtYAP(Player.player), 171, 60);
		}
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00004D77 File Offset: 0x00002F77
	public void DUtlHcYmZm4fu6X0zsiUggaqU(string text)
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF(text);
		DqNh7bzS0xEILWgxFJA4tpJpp.DdPz7R4rqMVxYUu02MjIYP9QM(-4);
	}
}
