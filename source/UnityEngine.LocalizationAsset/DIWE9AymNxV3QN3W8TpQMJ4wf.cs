using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000074 RID: 116
public class DIWE9AymNxV3QN3W8TpQMJ4wf : DSvAEyoSitLrXzsZSSRwWfJ5T
{
	// Token: 0x06000245 RID: 581 RVA: 0x00020990 File Offset: 0x0001EB90
	public override bool GetAviablity()
	{
		return D5l46jlssr4TRAzUSXzLj0uqu.displayVanishPlayersWindow && Provider.isConnected && Player.player != null;
	}

	// Token: 0x06000246 RID: 582 RVA: 0x000209C0 File Offset: 0x0001EBC0
	public override bool IsShowOnMenu()
	{
		return false;
	}

	// Token: 0x06000247 RID: 583 RVA: 0x000209D4 File Offset: 0x0001EBD4
	public override bool UseStaticRect()
	{
		return false;
	}

	// Token: 0x06000248 RID: 584 RVA: 0x000209E8 File Offset: 0x0001EBE8
	public override Vector2 GetSize()
	{
		return new Vector2(175f, (float)(22 + DIWE9AymNxV3QN3W8TpQMJ4wf.DkQtCNVNIySCh0NEuCD02Sj99() * 30));
	}

	// Token: 0x06000249 RID: 585 RVA: 0x00020A10 File Offset: 0x0001EC10
	public static int DkQtCNVNIySCh0NEuCD02Sj99()
	{
		bool flag = Time.realtimeSinceStartup - DIWE9AymNxV3QN3W8TpQMJ4wf.DIE3gcvCNvtIICDHXqoRgjuCx > 5f;
		if (flag)
		{
			DIWE9AymNxV3QN3W8TpQMJ4wf.DIE3gcvCNvtIICDHXqoRgjuCx = Time.realtimeSinceStartup;
			DIWE9AymNxV3QN3W8TpQMJ4wf.DGAdrb1my08r3gtyyw5BYZNNB.Clear();
			foreach (SteamPlayer steamPlayer in Provider.clients)
			{
				bool flag2 = Vector3.Distance(steamPlayer.player.transform.position, Vector3.zero) < 10f || !UndergroundAllowlist.IsPositionWithinValidHeight(steamPlayer.player.transform.position, 0.1f);
				if (flag2)
				{
					DIWE9AymNxV3QN3W8TpQMJ4wf.DGAdrb1my08r3gtyyw5BYZNNB.Add(new ValueTuple<string, Texture2D>(steamPlayer.playerID.characterName, DHTB5RKsHUihFrfj9ewuLh1f9.DQdqAKDPElShRsYiPvNwY1WVe(steamPlayer.playerID.steamID)));
				}
			}
		}
		return DIWE9AymNxV3QN3W8TpQMJ4wf.DGAdrb1my08r3gtyyw5BYZNNB.Count;
	}

	// Token: 0x0600024A RID: 586 RVA: 0x00020B18 File Offset: 0x0001ED18
	public override void DrawWindow()
	{
		base.DZxuXSmWDxed28SbJ8XfD3yXH("Vanished Players");
		GUI.skin.label.alignment = TextAnchor.MiddleLeft;
		foreach (ValueTuple<string, Texture2D> valueTuple in DIWE9AymNxV3QN3W8TpQMJ4wf.DGAdrb1my08r3gtyyw5BYZNNB)
		{
			string item = valueTuple.Item1;
			DqNh7bzS0xEILWgxFJA4tpJpp.DQXFOnbg0GOMla0jegOsR2odk(valueTuple.Item2, 30, 30);
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset -= 34;
			DqNh7bzS0xEILWgxFJA4tpJpp.DeYh3ocHoNm17vIFopPOwsXZf(34);
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += 7;
			DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF(item);
			DqNh7bzS0xEILWgxFJA4tpJpp.currentArea.offset += 13;
			DqNh7bzS0xEILWgxFJA4tpJpp.DeYh3ocHoNm17vIFopPOwsXZf(-34);
		}
		GUI.skin.label.alignment = TextAnchor.UpperLeft;
	}

	// Token: 0x040002D3 RID: 723
	public static List<ValueTuple<string, Texture2D>> DGAdrb1my08r3gtyyw5BYZNNB = new List<ValueTuple<string, Texture2D>>();

	// Token: 0x040002D4 RID: 724
	public static float DIE3gcvCNvtIICDHXqoRgjuCx = 0f;
}
