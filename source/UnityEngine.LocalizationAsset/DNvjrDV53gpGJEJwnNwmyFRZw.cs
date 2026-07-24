using System;
using System.Collections.Generic;
using System.Reflection;
using SDG.Provider;
using SDG.Unturned;
using Steamworks;

// Token: 0x02000091 RID: 145
public static class DNvjrDV53gpGJEJwnNwmyFRZw
{
	// Token: 0x060002BC RID: 700 RVA: 0x00028D58 File Offset: 0x00026F58
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DJfFZSXqBSkE06fhj0eGuAoEu()
	{
		bool dxcVo94CW4Y8vQkyhpKozFmcW = D0Kr0NqRHBD41IMsgv7ajeW8M.DxcVo94CW4Y8vQkyhpKozFmcW;
		if (dxcVo94CW4Y8vQkyhpKozFmcW)
		{
			DNvjrDV53gpGJEJwnNwmyFRZw.DHiIrr2YEci0nxWrzSBI7cgvW();
		}
	}

	// Token: 0x060002BD RID: 701 RVA: 0x00028D78 File Offset: 0x00026F78
	public static void DHiIrr2YEci0nxWrzSBI7cgvW()
	{
		DI4RfMJ7ziJuscMZZoy2MIzrV.De2hBwLmnyYClZ9fwAmbPOhqc = (DIDzNgrvnOa5xIZrJtz5ZO48o)Delegate.Combine(DI4RfMJ7ziJuscMZZoy2MIzrV.De2hBwLmnyYClZ9fwAmbPOhqc, new DIDzNgrvnOa5xIZrJtz5ZO48o(DNvjrDV53gpGJEJwnNwmyFRZw.DOOIDA7LHmpUj2PRTvkR0GoRh));
		DI4RfMJ7ziJuscMZZoy2MIzrV.DU6EO20XNycI0rg03jSyQr0k6 = (DIDzNgrvnOa5xIZrJtz5ZO48o)Delegate.Combine(DI4RfMJ7ziJuscMZZoy2MIzrV.DU6EO20XNycI0rg03jSyQr0k6, new DIDzNgrvnOa5xIZrJtz5ZO48o(DNvjrDV53gpGJEJwnNwmyFRZw.Dtk9l1zyHaLkaunLkWVc9bWlb));
		Provider.onClientConnected = (Provider.ClientConnected)Delegate.Combine(Provider.onClientConnected, new Provider.ClientConnected(DNvjrDV53gpGJEJwnNwmyFRZw.DV6JAhrX47jDYQpW6IwJL93AM));
		Provider.onServerConnected = (Provider.ServerConnected)Delegate.Combine(Provider.onServerConnected, new Provider.ServerConnected(delegate(CSteamID steamid)
		{
			DNvjrDV53gpGJEJwnNwmyFRZw.DV6JAhrX47jDYQpW6IwJL93AM();
		}));
		bool flag = D0Kr0NqRHBD41IMsgv7ajeW8M.DxcVo94CW4Y8vQkyhpKozFmcW && Provider.isConnected;
		if (flag)
		{
			DNvjrDV53gpGJEJwnNwmyFRZw.DV6JAhrX47jDYQpW6IwJL93AM();
		}
		Dictionary<DnFbkaUD6mnA1BajCnfh8ztdO, List<D20i1Qc1Q96crSRmQYn2qE39Z>> dictionary = new Dictionary<DnFbkaUD6mnA1BajCnfh8ztdO, List<D20i1Qc1Q96crSRmQYn2qE39Z>>();
		foreach (UnturnedEconInfo unturnedEconInfo in DNvjrDV53gpGJEJwnNwmyFRZw.DWrFY0uMtQAaOHrugrYc9rSWJ.Get().Values)
		{
			DnFbkaUD6mnA1BajCnfh8ztdO dnFbkaUD6mnA1BajCnfh8ztdO;
			bool flag2 = DNvjrDV53gpGJEJwnNwmyFRZw.DhKdr8t2LQea56PSmUgNqLGpa(unturnedEconInfo.display_type, out dnFbkaUD6mnA1BajCnfh8ztdO);
			if (flag2)
			{
				List<D20i1Qc1Q96crSRmQYn2qE39Z> list;
				bool flag3 = dictionary.TryGetValue(dnFbkaUD6mnA1BajCnfh8ztdO, out list);
				if (flag3)
				{
					list.Add(new D20i1Qc1Q96crSRmQYn2qE39Z(unturnedEconInfo, dnFbkaUD6mnA1BajCnfh8ztdO));
				}
				else
				{
					dictionary.Add(dnFbkaUD6mnA1BajCnfh8ztdO, new List<D20i1Qc1Q96crSRmQYn2qE39Z>
					{
						new D20i1Qc1Q96crSRmQYn2qE39Z(unturnedEconInfo, dnFbkaUD6mnA1BajCnfh8ztdO)
					});
				}
			}
		}
		foreach (DnFbkaUD6mnA1BajCnfh8ztdO dnFbkaUD6mnA1BajCnfh8ztdO2 in dictionary.Keys)
		{
			DNvjrDV53gpGJEJwnNwmyFRZw.DfvD7oGtLv9eVTgp0vv7bK8Az.Add(dnFbkaUD6mnA1BajCnfh8ztdO2, dictionary[dnFbkaUD6mnA1BajCnfh8ztdO2].ToArray());
		}
	}

	// Token: 0x060002BE RID: 702 RVA: 0x00028F3C File Offset: 0x0002713C
	public static D20i1Qc1Q96crSRmQYn2qE39Z DoajP7ueXvymRNGGeLfOkip4Q(DnFbkaUD6mnA1BajCnfh8ztdO st, int skinID)
	{
		foreach (D20i1Qc1Q96crSRmQYn2qE39Z d20i1Qc1Q96crSRmQYn2qE39Z in DNvjrDV53gpGJEJwnNwmyFRZw.DfvD7oGtLv9eVTgp0vv7bK8Az[st])
		{
			bool flag = d20i1Qc1Q96crSRmQYn2qE39Z.skinID == skinID;
			if (flag)
			{
				return d20i1Qc1Q96crSRmQYn2qE39Z;
			}
		}
		throw new NotImplementedException();
	}

	// Token: 0x060002BF RID: 703 RVA: 0x00028F8C File Offset: 0x0002718C
	public static bool DhKdr8t2LQea56PSmUgNqLGpa(string skinName, out DnFbkaUD6mnA1BajCnfh8ztdO sk)
	{
		DnFbkaUD6mnA1BajCnfh8ztdO dnFbkaUD6mnA1BajCnfh8ztdO = DnFbkaUD6mnA1BajCnfh8ztdO.Unknown;
		bool flag = skinName.Contains("Shirt");
		if (flag)
		{
			dnFbkaUD6mnA1BajCnfh8ztdO = DnFbkaUD6mnA1BajCnfh8ztdO.Shirt;
		}
		bool flag2 = skinName.Contains("Pants");
		if (flag2)
		{
			dnFbkaUD6mnA1BajCnfh8ztdO = DnFbkaUD6mnA1BajCnfh8ztdO.Pants;
		}
		bool flag3 = skinName.Contains("Backpack");
		if (flag3)
		{
			dnFbkaUD6mnA1BajCnfh8ztdO = DnFbkaUD6mnA1BajCnfh8ztdO.Backpack;
		}
		bool flag4 = skinName.Contains("Vest");
		if (flag4)
		{
			dnFbkaUD6mnA1BajCnfh8ztdO = DnFbkaUD6mnA1BajCnfh8ztdO.Vest;
		}
		bool flag5 = skinName.Contains("Hat");
		if (flag5)
		{
			dnFbkaUD6mnA1BajCnfh8ztdO = DnFbkaUD6mnA1BajCnfh8ztdO.Hat;
		}
		bool flag6 = skinName.Contains("Mask");
		if (flag6)
		{
			dnFbkaUD6mnA1BajCnfh8ztdO = DnFbkaUD6mnA1BajCnfh8ztdO.Mask;
		}
		bool flag7 = skinName.Contains("Glass");
		if (flag7)
		{
			dnFbkaUD6mnA1BajCnfh8ztdO = DnFbkaUD6mnA1BajCnfh8ztdO.Glass;
		}
		sk = dnFbkaUD6mnA1BajCnfh8ztdO;
		return dnFbkaUD6mnA1BajCnfh8ztdO > DnFbkaUD6mnA1BajCnfh8ztdO.Unknown;
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00029038 File Offset: 0x00027238
	public static void DBiu5zgu2TPYXgMbjOLO2p6cf(D20i1Qc1Q96crSRmQYn2qE39Z ss)
	{
		bool flag = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0.ContainsKey(ss.DqpdBkONuiEvgR84GTacyAE1n);
		if (flag)
		{
			DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[ss.DqpdBkONuiEvgR84GTacyAE1n] = ss;
		}
		else
		{
			DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0.Add(ss.DqpdBkONuiEvgR84GTacyAE1n, ss);
		}
		bool flag2 = Player.player != null;
		if (flag2)
		{
			DNvjrDV53gpGJEJwnNwmyFRZw.DG3qAw79jLhdYnH9ACA3HBEyQ(ss.DqpdBkONuiEvgR84GTacyAE1n, Player.player, true);
		}
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x000290A8 File Offset: 0x000272A8
	public static void DG3qAw79jLhdYnH9ACA3HBEyQ(DnFbkaUD6mnA1BajCnfh8ztdO st, Player p, bool applySkins = true)
	{
		switch (st)
		{
		case DnFbkaUD6mnA1BajCnfh8ztdO.Hat:
			p.clothing.firstClothes.visualHat = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			p.clothing.thirdClothes.visualHat = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			p.clothing.characterClothes.visualHat = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			break;
		case DnFbkaUD6mnA1BajCnfh8ztdO.Mask:
			p.clothing.firstClothes.visualMask = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			p.clothing.thirdClothes.visualMask = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			p.clothing.characterClothes.visualMask = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			break;
		case DnFbkaUD6mnA1BajCnfh8ztdO.Glass:
			p.clothing.firstClothes.visualGlasses = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			p.clothing.thirdClothes.visualGlasses = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			p.clothing.characterClothes.visualGlasses = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			break;
		case DnFbkaUD6mnA1BajCnfh8ztdO.Vest:
			p.clothing.firstClothes.visualVest = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			p.clothing.thirdClothes.visualVest = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			p.clothing.characterClothes.visualVest = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			break;
		case DnFbkaUD6mnA1BajCnfh8ztdO.Backpack:
			p.clothing.firstClothes.visualBackpack = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			p.clothing.thirdClothes.visualBackpack = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			p.clothing.characterClothes.visualBackpack = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			break;
		case DnFbkaUD6mnA1BajCnfh8ztdO.Shirt:
			p.clothing.firstClothes.visualShirt = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			p.clothing.thirdClothes.visualShirt = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			p.clothing.characterClothes.visualShirt = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			break;
		case DnFbkaUD6mnA1BajCnfh8ztdO.Pants:
			p.clothing.firstClothes.visualPants = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			p.clothing.thirdClothes.visualPants = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			p.clothing.characterClothes.visualPants = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0[st].skinID;
			break;
		}
		if (applySkins)
		{
			p.clothing.firstClothes.apply();
			p.clothing.thirdClothes.apply();
			p.clothing.characterClothes.apply();
		}
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00029430 File Offset: 0x00027630
	public static void DOOIDA7LHmpUj2PRTvkR0GoRh()
	{
		bool flag = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0.Count > 0;
		if (flag)
		{
			foreach (DnFbkaUD6mnA1BajCnfh8ztdO dnFbkaUD6mnA1BajCnfh8ztdO in DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0.Keys)
			{
				DNvjrDV53gpGJEJwnNwmyFRZw.DG3qAw79jLhdYnH9ACA3HBEyQ(dnFbkaUD6mnA1BajCnfh8ztdO, Player.player, false);
			}
			Player.player.clothing.firstClothes.apply();
			Player.player.clothing.thirdClothes.apply();
			Player.player.clothing.characterClothes.apply();
		}
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x000294E8 File Offset: 0x000276E8
	public static void Dtk9l1zyHaLkaunLkWVc9bWlb()
	{
		bool flag = DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0.Count > 0;
		if (flag)
		{
			foreach (DnFbkaUD6mnA1BajCnfh8ztdO dnFbkaUD6mnA1BajCnfh8ztdO in DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0.Keys)
			{
				DNvjrDV53gpGJEJwnNwmyFRZw.DG3qAw79jLhdYnH9ACA3HBEyQ(dnFbkaUD6mnA1BajCnfh8ztdO, Player.player, false);
			}
			Player.player.clothing.firstClothes.apply();
			Player.player.clothing.thirdClothes.apply();
			Player.player.clothing.characterClothes.apply();
		}
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x000295A0 File Offset: 0x000277A0
	public static void DV6JAhrX47jDYQpW6IwJL93AM()
	{
		foreach (DnFbkaUD6mnA1BajCnfh8ztdO dnFbkaUD6mnA1BajCnfh8ztdO in DNvjrDV53gpGJEJwnNwmyFRZw.DSW50pIhFgwjpFujT5dOUTLE0.Keys)
		{
			DNvjrDV53gpGJEJwnNwmyFRZw.DG3qAw79jLhdYnH9ACA3HBEyQ(dnFbkaUD6mnA1BajCnfh8ztdO, Player.player, false);
		}
		Player.player.clothing.firstClothes.apply();
		Player.player.clothing.thirdClothes.apply();
		Player.player.clothing.characterClothes.apply();
	}

	// Token: 0x0400032E RID: 814
	public static Dictionary<DnFbkaUD6mnA1BajCnfh8ztdO, D20i1Qc1Q96crSRmQYn2qE39Z> DSW50pIhFgwjpFujT5dOUTLE0 = new Dictionary<DnFbkaUD6mnA1BajCnfh8ztdO, D20i1Qc1Q96crSRmQYn2qE39Z>();

	// Token: 0x0400032F RID: 815
	public static Dictionary<DnFbkaUD6mnA1BajCnfh8ztdO, D20i1Qc1Q96crSRmQYn2qE39Z[]> DfvD7oGtLv9eVTgp0vv7bK8Az = new Dictionary<DnFbkaUD6mnA1BajCnfh8ztdO, D20i1Qc1Q96crSRmQYn2qE39Z[]>();

	// Token: 0x04000330 RID: 816
	public static bool D7f9YJIuMuntGE3zv28C0LAkQ = false;

	// Token: 0x04000331 RID: 817
	private static D0k7NGgNe0fThEj7aIiBuxVnW<Dictionary<int, UnturnedEconInfo>> DWrFY0uMtQAaOHrugrYc9rSWJ = new D0k7NGgNe0fThEj7aIiBuxVnW<Dictionary<int, UnturnedEconInfo>>(typeof(TempSteamworksEconomy), "econInfo", BindingFlags.Static | BindingFlags.NonPublic);
}
