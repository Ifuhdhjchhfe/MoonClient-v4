using System;
using System.Collections.Generic;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200002D RID: 45
public class DaFUhiiXlp4JR7SSzirAkBhEP
{
	// Token: 0x17000012 RID: 18
	// (get) Token: 0x060000C8 RID: 200 RVA: 0x00009320 File Offset: 0x00007520
	public static Type targetType
	{
		get
		{
			return typeof(PlayerDashboardInformationUI);
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000933C File Offset: 0x0000753C
	public static List<ISleekImage> markerImages
	{
		get
		{
			return DaFUhiiXlp4JR7SSzirAkBhEP.DaCVp56E44KL2gs2hxtxk2QKL.GetValue(null) as List<ISleekImage>;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060000CA RID: 202 RVA: 0x00009360 File Offset: 0x00007560
	public static List<ISleekImage> remotePlayerImages
	{
		get
		{
			return DaFUhiiXlp4JR7SSzirAkBhEP.D1UhNlPFtkhsMhNIIZl9OnRNG.GetValue(null) as List<ISleekImage>;
		}
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00009384 File Offset: 0x00007584
	[DyRHDWg89xeNs0wA42v5OHmTi]
	public static void Dh0xVBIlY0KLHSIsenmXnkyJI()
	{
		DaFUhiiXlp4JR7SSzirAkBhEP.D1UhNlPFtkhsMhNIIZl9OnRNG = typeof(PlayerDashboardInformationUI).GetField("remotePlayerImages", BindingFlags.Static | BindingFlags.NonPublic);
		DaFUhiiXlp4JR7SSzirAkBhEP.DaCVp56E44KL2gs2hxtxk2QKL = typeof(PlayerDashboardInformationUI).GetField("markerImages", BindingFlags.Static | BindingFlags.NonPublic);
		DaFUhiiXlp4JR7SSzirAkBhEP.DriZH9sH9VwU9lnNjbpLkhNoX = typeof(PlayerDashboardInformationUI).GetField("mapMarkersContainer", BindingFlags.Static | BindingFlags.NonPublic);
		DaFUhiiXlp4JR7SSzirAkBhEP.DLBPt05GedlwiBJFl3EQdMpkh = typeof(PlayerDashboardInformationUI).GetField("mapRemotePlayersContainer", BindingFlags.Static | BindingFlags.NonPublic);
		DaFUhiiXlp4JR7SSzirAkBhEP.DqSx157zvYN0KkS4j5nst3sUH = typeof(PlayerDashboardInformationUI).GetField("showPlayerAvatarsToggle", BindingFlags.Static | BindingFlags.NonPublic);
		DaFUhiiXlp4JR7SSzirAkBhEP.DSxxMhUwAI1eM7YtZp3VlKW1s = typeof(PlayerDashboardInformationUI).GetField("showPlayerNamesToggle", BindingFlags.Static | BindingFlags.NonPublic);
		DaFUhiiXlp4JR7SSzirAkBhEP.DYTQLt4k5K3kArz7efLG0Jwch = typeof(PlayerDashboardInformationUI).GetMethod("ProjectWorldPositionToMap", BindingFlags.Static | BindingFlags.NonPublic);
		try
		{
			DaFUhiiXlp4JR7SSzirAkBhEP.Dk7mB8xLH3yG4jN9pQ2rS5tV6 = typeof(PlayerDashboardInformationUI).GetField("icons", BindingFlags.Static | BindingFlags.NonPublic);
		}
		catch
		{
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("PlayerDashboardInformationUI.icons field not found - marker icons will not be loaded");
		}
		DI4RfMJ7ziJuscMZZoy2MIzrV.De2hBwLmnyYClZ9fwAmbPOhqc = (DIDzNgrvnOa5xIZrJtz5ZO48o)Delegate.Combine(DI4RfMJ7ziJuscMZZoy2MIzrV.De2hBwLmnyYClZ9fwAmbPOhqc, new DIDzNgrvnOa5xIZrJtz5ZO48o(DaFUhiiXlp4JR7SSzirAkBhEP.DclN6pkqqt0u4dVKSuYrPRBwK));
	}

	// Token: 0x060000CC RID: 204 RVA: 0x000094B0 File Offset: 0x000076B0
	public static void DclN6pkqqt0u4dVKSuYrPRBwK()
	{
		for (int i = 0; i < DaFUhiiXlp4JR7SSzirAkBhEP.remotePlayerImages.Count; i++)
		{
			DaFUhiiXlp4JR7SSzirAkBhEP.remotePlayerImages[i].IsVisible = false;
		}
		for (int j = 0; j < DaFUhiiXlp4JR7SSzirAkBhEP.markerImages.Count; j++)
		{
			DaFUhiiXlp4JR7SSzirAkBhEP.markerImages[j].IsVisible = false;
		}
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00009518 File Offset: 0x00007718
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerDashboardInformationUI), "searchForMapsInInventory", new Type[] { })]
	protected static void DmnnA9M66ijzs0wInRotRH3Tv(ref bool enableChart, ref bool enableMap)
	{
		bool imitMapInInventory = D5l46jlssr4TRAzUSXzLj0uqu.imitMapInInventory;
		bool flag = imitMapInInventory;
		if (flag)
		{
			enableMap = true;
			enableChart = true;
		}
		else
		{
			bool flag2 = enableChart & enableMap;
			bool flag3 = !flag2;
			if (flag3)
			{
				for (byte b = 0; b < PlayerInventory.PAGES - 2; b += 1)
				{
					Items items = Player.player.inventory.items[(int)b];
					bool flag4 = items != null;
					bool flag5 = flag4;
					if (flag5)
					{
						foreach (ItemJar itemJar in items.items)
						{
							bool flag6 = itemJar != null;
							bool flag7 = flag6;
							if (flag7)
							{
								ItemMapAsset asset = itemJar.GetAsset<ItemMapAsset>();
								bool flag8 = asset != null;
								bool flag9 = flag8;
								if (flag9)
								{
									enableChart |= asset.enablesChart;
									enableMap |= asset.enablesMap;
								}
								bool flag10 = enableChart & enableMap;
								bool flag11 = flag10;
								if (flag11)
								{
									return;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060000CE RID: 206 RVA: 0x0000963C File Offset: 0x0000783C
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerDashboardInformationUI), "updateMarkers", new Type[] { })]
	private static void DqTY8iRxvx96h0UrH0MHoiEVT()
	{
		int num = 0;
		foreach (SteamPlayer steamPlayer in Provider.clients)
		{
			bool flag = !(steamPlayer.model == null);
			bool flag2 = flag;
			if (flag2)
			{
				PlayerQuests quests = steamPlayer.player.quests;
				bool flag3 = (!(steamPlayer.playerID.steamID != Provider.client) || quests.isMemberOfSameGroupAs(Player.player) || (D5l46jlssr4TRAzUSXzLj0uqu.displayAllPlayerMarksOnMap && !DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6)) && quests.isMarkerPlaced;
				bool flag4 = flag3;
				if (flag4)
				{
					bool flag5 = num < DaFUhiiXlp4JR7SSzirAkBhEP.markerImages.Count;
					bool flag6 = flag5;
					ISleekImage sleekImage;
					if (flag6)
					{
						sleekImage = DaFUhiiXlp4JR7SSzirAkBhEP.markerImages[num];
						sleekImage.IsVisible = true;
					}
					else
					{
						try
						{
							bool flag7 = DaFUhiiXlp4JR7SSzirAkBhEP.Dk7mB8xLH3yG4jN9pQ2rS5tV6 != null;
							if (flag7)
							{
								sleekImage = Glazier.Get().CreateImage((DaFUhiiXlp4JR7SSzirAkBhEP.Dk7mB8xLH3yG4jN9pQ2rS5tV6.GetValue(null) as Bundle).load<Texture2D>("Marker"));
							}
							else
							{
								sleekImage = Glazier.Get().CreateImage();
							}
						}
						catch
						{
							sleekImage = Glazier.Get().CreateImage();
						}
						sleekImage.PositionOffset_X = -10f;
						sleekImage.PositionOffset_Y = -10f;
						sleekImage.SizeOffset_X = 20f;
						sleekImage.SizeOffset_Y = 20f;
						sleekImage.AddLabel(string.Empty, ESleekSide.RIGHT);
						(DaFUhiiXlp4JR7SSzirAkBhEP.DriZH9sH9VwU9lnNjbpLkhNoX.GetValue(num) as ISleekElement).AddChild(sleekImage);
						DaFUhiiXlp4JR7SSzirAkBhEP.markerImages.Add(sleekImage);
					}
					num++;
					Vector2 vector = (Vector2)DaFUhiiXlp4JR7SSzirAkBhEP.DYTQLt4k5K3kArz7efLG0Jwch.Invoke(null, new object[] { quests.markerPosition });
					sleekImage.PositionScale_X = vector.x;
					sleekImage.PositionScale_Y = vector.y;
					sleekImage.TintColor = steamPlayer.markerColor;
					string text = quests.markerTextOverride;
					bool flag8 = string.IsNullOrEmpty(text);
					bool flag9 = flag8;
					if (flag9)
					{
						bool flag10 = string.IsNullOrEmpty(steamPlayer.playerID.nickName);
						bool flag11 = flag10;
						if (flag11)
						{
							text = steamPlayer.playerID.characterName;
						}
						else
						{
							text = steamPlayer.playerID.nickName;
						}
					}
					sleekImage.UpdateLabel(text);
				}
			}
		}
		for (int i = DaFUhiiXlp4JR7SSzirAkBhEP.markerImages.Count - 1; i >= num; i--)
		{
			DaFUhiiXlp4JR7SSzirAkBhEP.markerImages[i].IsVisible = false;
		}
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00009924 File Offset: 0x00007B24
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerDashboardInformationUI), "updateRemotePlayerAvatars", new Type[] { })]
	private static void DCF0YWrtnjKdc4bswX9J67tF7()
	{
		int num = 0;
		bool areSpecStatsVisible = Player.player.look.areSpecStatsVisible;
		foreach (SteamPlayer steamPlayer in Provider.clients)
		{
			bool flag = !(steamPlayer.model == null) && !(steamPlayer.playerID.steamID == Provider.client);
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = steamPlayer.player.quests.isMemberOfSameGroupAs(Player.player);
				bool flag4 = areSpecStatsVisible || flag3 || (D5l46jlssr4TRAzUSXzLj0uqu.displayAllPlayersOnMap && !DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6);
				bool flag5 = flag4;
				if (flag5)
				{
					bool flag6 = num < DaFUhiiXlp4JR7SSzirAkBhEP.remotePlayerImages.Count;
					bool flag7 = flag6;
					ISleekImage sleekImage;
					if (flag7)
					{
						sleekImage = DaFUhiiXlp4JR7SSzirAkBhEP.remotePlayerImages[num];
						sleekImage.IsVisible = true;
					}
					else
					{
						sleekImage = Glazier.Get().CreateImage();
						sleekImage.PositionOffset_X = -10f;
						sleekImage.PositionOffset_Y = -10f;
						sleekImage.SizeOffset_X = 20f;
						sleekImage.SizeOffset_Y = 20f;
						sleekImage.AddLabel(string.Empty, ESleekSide.RIGHT);
						(DaFUhiiXlp4JR7SSzirAkBhEP.DLBPt05GedlwiBJFl3EQdMpkh.GetValue(null) as ISleekElement).AddChild(sleekImage);
						DaFUhiiXlp4JR7SSzirAkBhEP.remotePlayerImages.Add(sleekImage);
					}
					num++;
					Vector2 vector = (Vector2)DaFUhiiXlp4JR7SSzirAkBhEP.DYTQLt4k5K3kArz7efLG0Jwch.Invoke(null, new object[] { steamPlayer.player.transform.position });
					sleekImage.PositionScale_X = vector.x;
					sleekImage.PositionScale_Y = vector.y;
					bool flag8 = OptionsSettings.streamer || !(DaFUhiiXlp4JR7SSzirAkBhEP.DqSx157zvYN0KkS4j5nst3sUH.GetValue(null) as ISleekToggle).Value;
					bool flag9 = flag8;
					if (flag9)
					{
						sleekImage.Texture = null;
					}
					else
					{
						sleekImage.Texture = Provider.provider.communityService.getIcon(steamPlayer.playerID.steamID, true);
					}
					bool value = (DaFUhiiXlp4JR7SSzirAkBhEP.DSxxMhUwAI1eM7YtZp3VlKW1s.GetValue(null) as ISleekToggle).Value;
					bool flag10 = value;
					if (flag10)
					{
						bool flag11 = flag3 && !string.IsNullOrEmpty(steamPlayer.playerID.nickName);
						bool flag12 = flag11;
						if (flag12)
						{
							sleekImage.UpdateLabel(steamPlayer.playerID.nickName);
						}
						else
						{
							sleekImage.UpdateLabel(steamPlayer.playerID.characterName);
						}
					}
					else
					{
						sleekImage.UpdateLabel(string.Empty);
					}
				}
			}
		}
		for (int i = DaFUhiiXlp4JR7SSzirAkBhEP.remotePlayerImages.Count - 1; i >= num; i--)
		{
			DaFUhiiXlp4JR7SSzirAkBhEP.remotePlayerImages[i].IsVisible = false;
		}
	}

	// Token: 0x040000F9 RID: 249
	public static FieldInfo D1UhNlPFtkhsMhNIIZl9OnRNG;

	// Token: 0x040000FA RID: 250
	public static FieldInfo DaCVp56E44KL2gs2hxtxk2QKL;

	// Token: 0x040000FB RID: 251
	public static FieldInfo DriZH9sH9VwU9lnNjbpLkhNoX;

	// Token: 0x040000FC RID: 252
	public static FieldInfo DLBPt05GedlwiBJFl3EQdMpkh;

	// Token: 0x040000FD RID: 253
	public static FieldInfo DqSx157zvYN0KkS4j5nst3sUH;

	// Token: 0x040000FE RID: 254
	public static FieldInfo DSxxMhUwAI1eM7YtZp3VlKW1s;

	// Token: 0x040000FF RID: 255
	public static MethodInfo DYTQLt4k5K3kArz7efLG0Jwch;

	// Token: 0x04000100 RID: 256
	public static FieldInfo Dk7mB8xLH3yG4jN9pQ2rS5tV6;
}
