using System;
using System.Collections.Generic;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

// Token: 0x0200004B RID: 75
public class DdU7Jp9Xf5YPxJnLsj0hqogp1 : DOEkZ1zoBEuvfUmOs9QSpfX0X
{
	// Token: 0x0600016B RID: 363 RVA: 0x00013EB4 File Offset: 0x000120B4
	public override string GetName()
	{
		return "Players";
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00013ECC File Offset: 0x000120CC
	public override void DoTab(DYIPJORHeVCfbpocFHvJty4OE tc)
	{
		bool flag = tc == DYIPJORHeVCfbpocFHvJty4OE.One;
		bool flag2 = flag;
		if (flag2)
		{
			GUILayout.Label("<b>Search Player:</b>", Array.Empty<GUILayoutOption>());
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			this.DBUxvFuRgmuLen7pZ0eD4dy7V = GUILayout.TextField(this.DBUxvFuRgmuLen7pZ0eD4dy7V, new GUILayoutOption[] { GUILayout.Height(22f) });
			GUILayout.EndHorizontal();
			GUILayout.Space(8f);
			GUILayout.Label("<b>Players Online:</b>", Array.Empty<GUILayoutOption>());
			GUILayout.Space(4f);
			this.DJsDT0RFHU8cOmLzrx2QoqvZQ = GUILayout.BeginScrollView(this.DJsDT0RFHU8cOmLzrx2QoqvZQ, Array.Empty<GUILayoutOption>());
			for (int i = 0; i < Provider.clients.Count; i++)
			{
				SteamPlayer steamPlayer = Provider.clients[i];
				bool flag3 = steamPlayer == null || steamPlayer.player == null || steamPlayer.player.channel.IsLocalPlayer;
				if (!flag3)
				{
					bool flag4 = string.IsNullOrEmpty(this.DBUxvFuRgmuLen7pZ0eD4dy7V) || steamPlayer.playerID.characterName.ToLower().Contains(this.DBUxvFuRgmuLen7pZ0eD4dy7V.ToLower()) || steamPlayer.playerID.nickName.ToLower().Contains(this.DBUxvFuRgmuLen7pZ0eD4dy7V.ToLower());
					bool flag5 = !flag4;
					if (!flag5)
					{
						string characterName = steamPlayer.playerID.characterName;
						string text = ((steamPlayer.player.equipment.asset != null) ? steamPlayer.player.equipment.asset.itemName : "None");
						float num = 0f;
						bool flag6 = Player.player != null && steamPlayer.player != null;
						if (flag6)
						{
							num = Vector3.Distance(Player.player.transform.position, steamPlayer.player.transform.position);
						}
						GUILayout.BeginHorizontal(new GUILayoutOption[] { GUILayout.Height(36f) });
						Texture2D texture2D = DHTB5RKsHUihFrfj9ewuLh1f9.DQdqAKDPElShRsYiPvNwY1WVe(steamPlayer.playerID.steamID);
						bool flag7 = texture2D != null;
						if (flag7)
						{
							GUILayout.Label(new GUIContent(texture2D), new GUILayoutOption[]
							{
								GUILayout.Width(32f),
								GUILayout.Height(32f)
							});
						}
						else
						{
							GUILayout.Box("", new GUILayoutOption[]
							{
								GUILayout.Width(32f),
								GUILayout.Height(32f)
							});
						}
						GUILayout.Space(6f);
						string text2 = string.Format("{0} | {1}m | {2}", characterName, num.ToString("F0"), text);
						bool flag8 = text2.Length > 40;
						if (flag8)
						{
							text2 = text2.Substring(0, 37) + "...";
						}
						bool flag9 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv(text2, -1, true, null);
						if (flag9)
						{
							DdU7Jp9Xf5YPxJnLsj0hqogp1.DflpDEkaH7eqItbTyjf5Ao5wi = i;
						}
						GUILayout.EndHorizontal();
						GUILayout.Space(2f);
					}
				}
			}
			GUILayout.EndScrollView();
		}
		else
		{
			bool flag10 = !Provider.isConnected;
			bool flag11 = flag10;
			if (flag11)
			{
				GUILayout.Label("You are not connected to server", Array.Empty<GUILayoutOption>());
			}
			else
			{
				bool flag12 = Provider.clients.Count <= DdU7Jp9Xf5YPxJnLsj0hqogp1.DflpDEkaH7eqItbTyjf5Ao5wi;
				bool flag13 = flag12;
				if (flag13)
				{
					DdU7Jp9Xf5YPxJnLsj0hqogp1.DflpDEkaH7eqItbTyjf5Ao5wi = -1;
				}
				else
				{
					bool flag14 = DdU7Jp9Xf5YPxJnLsj0hqogp1.DflpDEkaH7eqItbTyjf5Ao5wi == -1;
					bool flag15 = flag14;
					if (flag15)
					{
						GUILayout.Label("Select a player", Array.Empty<GUILayoutOption>());
					}
					else
					{
						SteamPlayer steamPlayer2 = Provider.clients[DdU7Jp9Xf5YPxJnLsj0hqogp1.DflpDEkaH7eqItbTyjf5Ao5wi];
						Player player = steamPlayer2.player;
						GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
						Texture2D texture2D2 = DHTB5RKsHUihFrfj9ewuLh1f9.DQdqAKDPElShRsYiPvNwY1WVe(steamPlayer2.playerID.steamID);
						bool flag16 = texture2D2 != null;
						if (flag16)
						{
							GUILayout.Label(new GUIContent(texture2D2), new GUILayoutOption[]
							{
								GUILayout.Width(64f),
								GUILayout.Height(64f)
							});
						}
						else
						{
							GUILayout.Box("No Pic", new GUILayoutOption[]
							{
								GUILayout.Width(64f),
								GUILayout.Height(64f)
							});
						}
						GUILayout.Space(10f);
						GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
						GUILayout.Label("<b>" + steamPlayer2.playerID.playerName + "</b>", Array.Empty<GUILayoutOption>());
						string text3 = "Steam ID: ";
						CSteamID csteamID = steamPlayer2.playerID.steamID;
						GUILayout.Label(text3 + csteamID.m_SteamID.ToString(), Array.Empty<GUILayoutOption>());
						bool flag17 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Open Profile", -1, true, null);
						if (flag17)
						{
							string text4 = "https://steamcommunity.com/profiles/";
							csteamID = steamPlayer2.playerID.steamID;
							SteamFriends.ActivateGameOverlayToWebPage(text4 + csteamID.m_SteamID.ToString(), EActivateGameOverlayToWebPageMode.k_EActivateGameOverlayToWebPageMode_Default);
						}
						GUILayout.EndVertical();
						GUILayout.EndHorizontal();
						GUILayout.Space(12f);
						GUILayout.Label("<b>Names:</b>", Array.Empty<GUILayoutOption>());
						GUILayout.Label("  Steam: " + steamPlayer2.playerID.playerName, Array.Empty<GUILayoutOption>());
						GUILayout.Label("  Character: " + steamPlayer2.playerID.characterName, Array.Empty<GUILayoutOption>());
						GUILayout.Label("  Nickname: " + steamPlayer2.playerID.nickName, Array.Empty<GUILayoutOption>());
						GUILayout.Space(8f);
						bool flag18 = Player.player != null && player != null;
						if (flag18)
						{
							GUILayout.Label("<b>Distance:</b> " + Vector3.Distance(Player.player.transform.position, player.transform.position).ToString("F1") + "m", Array.Empty<GUILayoutOption>());
						}
						GUILayout.Space(8f);
						GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
						string text5 = "<b>Steam ID:</b> ";
						csteamID = steamPlayer2.playerID.steamID;
						GUILayout.Label(text5 + csteamID.m_SteamID.ToString(), new GUILayoutOption[] { GUILayout.ExpandWidth(true) });
						bool flag19 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Copy", -1, true, null);
						if (flag19)
						{
							csteamID = steamPlayer2.playerID.steamID;
							GUIUtility.systemCopyBuffer = csteamID.m_SteamID.ToString();
						}
						GUILayout.EndHorizontal();
						GUILayout.Space(8f);
						GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
						GUILayout.Label("<b>Weapon:</b>", new GUILayoutOption[] { GUILayout.Width(55f) });
						string text6 = ((player.equipment.asset != null) ? player.equipment.asset.itemName : "None");
						GUILayout.Label(text6, new GUILayoutOption[] { GUILayout.ExpandWidth(true) });
						bool flag20 = player.equipment.asset != null;
						if (flag20)
						{
							Texture2D texture2D3 = DHTB5RKsHUihFrfj9ewuLh1f9.DPF1WELNU4huo63e3q4cLtYAP(player);
							bool flag21 = texture2D3 != null;
							if (flag21)
							{
								GUILayout.Label(new GUIContent(texture2D3), new GUILayoutOption[]
								{
									GUILayout.Width(32f),
									GUILayout.Height(32f)
								});
							}
						}
						GUILayout.EndHorizontal();
						GUILayout.Space(8f);
						GUILayout.Label("<b>Group:</b>", Array.Empty<GUILayoutOption>());
						string text7 = "";
						List<string> list = new List<string>();
						foreach (SteamPlayer steamPlayer3 in Provider.clients)
						{
							bool flag22 = player.quests.isMemberOfSameGroupAs(steamPlayer3.player);
							bool flag23 = flag22;
							if (flag23)
							{
								bool flag24 = steamPlayer3.playerID.playerName != steamPlayer2.playerID.playerName;
								if (flag24)
								{
									list.Add(steamPlayer3.playerID.playerName);
									text7 = text7 + steamPlayer3.playerID.playerName + ", ";
								}
							}
						}
						bool flag25 = !string.IsNullOrEmpty(text7);
						bool flag26 = flag25;
						if (flag26)
						{
							text7 = text7.Substring(0, text7.Length - 2);
							GUILayout.Label("  " + text7, Array.Empty<GUILayoutOption>());
						}
						else
						{
							GUILayout.Label("  Not in a group", Array.Empty<GUILayoutOption>());
						}
						GUILayout.Space(8f);
						GUILayout.Label("<b>Equipment:</b>", Array.Empty<GUILayoutOption>());
						bool flag27 = player.clothing != null;
						if (flag27)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							GUILayout.BeginVertical(new GUILayoutOption[] { GUILayout.Width(120f) });
							bool flag28 = player.clothing.hatAsset != null;
							if (flag28)
							{
								GUILayout.Label("Hat: " + player.clothing.hatAsset.itemName, Array.Empty<GUILayoutOption>());
							}
							bool flag29 = player.clothing.maskAsset != null;
							if (flag29)
							{
								GUILayout.Label("Mask: " + player.clothing.maskAsset.itemName, Array.Empty<GUILayoutOption>());
							}
							bool flag30 = player.clothing.glassesAsset != null;
							if (flag30)
							{
								GUILayout.Label("Glasses: " + player.clothing.glassesAsset.itemName, Array.Empty<GUILayoutOption>());
							}
							GUILayout.EndVertical();
							GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
							bool flag31 = player.clothing.shirtAsset != null;
							if (flag31)
							{
								GUILayout.Label("Shirt: " + player.clothing.shirtAsset.itemName, Array.Empty<GUILayoutOption>());
							}
							bool flag32 = player.clothing.pantsAsset != null;
							if (flag32)
							{
								GUILayout.Label("Pants: " + player.clothing.pantsAsset.itemName, Array.Empty<GUILayoutOption>());
							}
							bool flag33 = player.clothing.vestAsset != null;
							if (flag33)
							{
								GUILayout.Label("Vest: " + player.clothing.vestAsset.itemName, Array.Empty<GUILayoutOption>());
							}
							bool flag34 = player.clothing.backpackAsset != null;
							if (flag34)
							{
								GUILayout.Label("Backpack: " + player.clothing.backpackAsset.itemName, Array.Empty<GUILayoutOption>());
							}
							GUILayout.EndVertical();
							GUILayout.EndHorizontal();
						}
						else
						{
							GUILayout.Label("  No clothing data", Array.Empty<GUILayoutOption>());
						}
						GUILayout.Space(12f);
						GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
						GUILayout.Label("<b>Priority:</b>", new GUILayoutOption[] { GUILayout.Width(55f) });
						bool flag35 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv(DbdjYbf8enAuqurN70Ytu4YPj.DtoaffC6NTYqPooRi7x5gsNvk(steamPlayer2).ToString(), -1, true, null);
						bool flag36 = flag35;
						if (flag36)
						{
							DbdjYbf8enAuqurN70Ytu4YPj.DKz05SCT0Y6PerwFKpcp14g2o(steamPlayer2, DbdjYbf8enAuqurN70Ytu4YPj.DtoaffC6NTYqPooRi7x5gsNvk(steamPlayer2).D5GDf6NDOOXtOKVhMfOJBmfW5<DBCfkWLnn9d8dtQQBa0x7Cya0>());
							bool flag37 = DbdjYbf8enAuqurN70Ytu4YPj.DtoaffC6NTYqPooRi7x5gsNvk(steamPlayer2) == DBCfkWLnn9d8dtQQBa0x7Cya0.GroupMate;
							bool flag38 = flag37;
							if (flag38)
							{
								DbdjYbf8enAuqurN70Ytu4YPj.DKz05SCT0Y6PerwFKpcp14g2o(steamPlayer2, DBCfkWLnn9d8dtQQBa0x7Cya0.Default);
							}
						}
						GUILayout.EndHorizontal();
					}
				}
			}
		}
	}

	// Token: 0x040001C9 RID: 457
	public static int DflpDEkaH7eqItbTyjf5Ao5wi = -1;

	// Token: 0x040001CA RID: 458
	public Vector2 DJsDT0RFHU8cOmLzrx2QoqvZQ = Vector2.zero;

	// Token: 0x040001CB RID: 459
	public string DBUxvFuRgmuLen7pZ0eD4dy7V = "";
}
