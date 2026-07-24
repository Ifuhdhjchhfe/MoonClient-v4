using System;
using System.Collections.Generic;
using System.Threading;
using SDG.Unturned;

// Token: 0x02000038 RID: 56
public static class DbdjYbf8enAuqurN70Ytu4YPj
{
	// Token: 0x060000E6 RID: 230 RVA: 0x0000A4A0 File Offset: 0x000086A0
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DfK9dHwymwbo0A230MDNwY3Zf()
	{
		new Thread(new ThreadStart(delegate
		{
			for (;;)
			{
				bool flag = Provider.isConnected && (bool)Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[0].DTyDRC9cdG8IGn9zMpTt5eaiL[1].DInHPFtxebvVx7sh7DNy96Mrp;
				bool flag2 = flag;
				if (flag2)
				{
					try
					{
						foreach (SteamPlayer steamPlayer in Provider.clients)
						{
							bool flag3 = steamPlayer.player.quests.isMemberOfSameGroupAs(Player.player) && DbdjYbf8enAuqurN70Ytu4YPj.DtoaffC6NTYqPooRi7x5gsNvk(steamPlayer) == DBCfkWLnn9d8dtQQBa0x7Cya0.Default;
							bool flag4 = flag3;
							if (flag4)
							{
								DbdjYbf8enAuqurN70Ytu4YPj.DKz05SCT0Y6PerwFKpcp14g2o(steamPlayer, DBCfkWLnn9d8dtQQBa0x7Cya0.GroupMate);
							}
							else
							{
								bool flag5 = !steamPlayer.player.quests.isMemberOfSameGroupAs(Player.player) && DbdjYbf8enAuqurN70Ytu4YPj.DtoaffC6NTYqPooRi7x5gsNvk(steamPlayer) == DBCfkWLnn9d8dtQQBa0x7Cya0.GroupMate;
								bool flag6 = flag5;
								if (flag6)
								{
									DbdjYbf8enAuqurN70Ytu4YPj.DKz05SCT0Y6PerwFKpcp14g2o(steamPlayer, DBCfkWLnn9d8dtQQBa0x7Cya0.Default);
								}
							}
						}
					}
					catch
					{
					}
				}
				Thread.Sleep(3000);
			}
		})).Start();
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x0000A4D0 File Offset: 0x000086D0
	public static bool DsWqgMtj8lZbiMEqyexGc2Vcn(Player p)
	{
		return DbdjYbf8enAuqurN70Ytu4YPj.DbwCzsPPDoPdwOutLL77NYox1(p.channel.owner.playerID.steamID.m_SteamID) == DBCfkWLnn9d8dtQQBa0x7Cya0.Friend || DbdjYbf8enAuqurN70Ytu4YPj.DbwCzsPPDoPdwOutLL77NYox1(p.channel.owner.playerID.steamID.m_SteamID) == DBCfkWLnn9d8dtQQBa0x7Cya0.GroupMate;
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x0000A52C File Offset: 0x0000872C
	public static bool DUm5Cdfmw0jQhXvw0M59ozPv7(SteamPlayer sp)
	{
		return DbdjYbf8enAuqurN70Ytu4YPj.DbwCzsPPDoPdwOutLL77NYox1(sp.playerID.steamID.m_SteamID) == DBCfkWLnn9d8dtQQBa0x7Cya0.Friend || DbdjYbf8enAuqurN70Ytu4YPj.DbwCzsPPDoPdwOutLL77NYox1(sp.playerID.steamID.m_SteamID) == DBCfkWLnn9d8dtQQBa0x7Cya0.GroupMate;
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x0000A574 File Offset: 0x00008774
	public static bool Dt8SZyrkb6GMEOWHXscvXNno0(Player p)
	{
		return DbdjYbf8enAuqurN70Ytu4YPj.DbwCzsPPDoPdwOutLL77NYox1(p.channel.owner.playerID.steamID.m_SteamID) == DBCfkWLnn9d8dtQQBa0x7Cya0.Enemy;
	}

	// Token: 0x060000EA RID: 234 RVA: 0x0000A5A8 File Offset: 0x000087A8
	public static bool DGTv0EtfnhuKNt8iSoZmDLDXr(SteamPlayer sp)
	{
		return DbdjYbf8enAuqurN70Ytu4YPj.DbwCzsPPDoPdwOutLL77NYox1(sp.playerID.steamID.m_SteamID) == DBCfkWLnn9d8dtQQBa0x7Cya0.Enemy;
	}

	// Token: 0x060000EB RID: 235 RVA: 0x0000A5D4 File Offset: 0x000087D4
	public static DBCfkWLnn9d8dtQQBa0x7Cya0 DSoLHppGmtaAh0NhZICgMBlP5(Player p)
	{
		return DbdjYbf8enAuqurN70Ytu4YPj.DbwCzsPPDoPdwOutLL77NYox1(p.channel.owner.playerID.steamID.m_SteamID);
	}

	// Token: 0x060000EC RID: 236 RVA: 0x0000A608 File Offset: 0x00008808
	public static DBCfkWLnn9d8dtQQBa0x7Cya0 DtoaffC6NTYqPooRi7x5gsNvk(SteamPlayer sp)
	{
		return DbdjYbf8enAuqurN70Ytu4YPj.DbwCzsPPDoPdwOutLL77NYox1(sp.playerID.steamID.m_SteamID);
	}

	// Token: 0x060000ED RID: 237 RVA: 0x0000A630 File Offset: 0x00008830
	public static DBCfkWLnn9d8dtQQBa0x7Cya0 DbwCzsPPDoPdwOutLL77NYox1(ulong steamId)
	{
		DBCfkWLnn9d8dtQQBa0x7Cya0 dbcfkWLnn9d8dtQQBa0x7Cya;
		bool flag = DbdjYbf8enAuqurN70Ytu4YPj.DY1FDD6RaL8Rb2HRhdDX65o4w.TryGetValue(steamId, out dbcfkWLnn9d8dtQQBa0x7Cya);
		bool flag2 = flag;
		DBCfkWLnn9d8dtQQBa0x7Cya0 dbcfkWLnn9d8dtQQBa0x7Cya2;
		if (flag2)
		{
			dbcfkWLnn9d8dtQQBa0x7Cya2 = dbcfkWLnn9d8dtQQBa0x7Cya;
		}
		else
		{
			DbdjYbf8enAuqurN70Ytu4YPj.DY1FDD6RaL8Rb2HRhdDX65o4w.Add(steamId, DBCfkWLnn9d8dtQQBa0x7Cya0.Default);
			dbcfkWLnn9d8dtQQBa0x7Cya2 = DBCfkWLnn9d8dtQQBa0x7Cya0.Default;
		}
		return dbcfkWLnn9d8dtQQBa0x7Cya2;
	}

	// Token: 0x060000EE RID: 238 RVA: 0x0000A66F File Offset: 0x0000886F
	public static void DqyW5tNjbOTN7i18ZGStyi066(Player p, DBCfkWLnn9d8dtQQBa0x7Cya0 priority)
	{
		DbdjYbf8enAuqurN70Ytu4YPj.DCF44jA4nXnrpIb0VZDyK2yGF(p.channel.owner.playerID.steamID.m_SteamID, priority);
	}

	// Token: 0x060000EF RID: 239 RVA: 0x0000A693 File Offset: 0x00008893
	public static void DKz05SCT0Y6PerwFKpcp14g2o(SteamPlayer sp, DBCfkWLnn9d8dtQQBa0x7Cya0 priority)
	{
		DbdjYbf8enAuqurN70Ytu4YPj.DCF44jA4nXnrpIb0VZDyK2yGF(sp.playerID.steamID.m_SteamID, priority);
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x0000A6B0 File Offset: 0x000088B0
	public static void DCF44jA4nXnrpIb0VZDyK2yGF(ulong steamId, DBCfkWLnn9d8dtQQBa0x7Cya0 priority)
	{
		bool flag = DbdjYbf8enAuqurN70Ytu4YPj.DY1FDD6RaL8Rb2HRhdDX65o4w.ContainsKey(steamId);
		bool flag2 = flag;
		if (flag2)
		{
			DbdjYbf8enAuqurN70Ytu4YPj.DY1FDD6RaL8Rb2HRhdDX65o4w[steamId] = priority;
		}
		else
		{
			DbdjYbf8enAuqurN70Ytu4YPj.DY1FDD6RaL8Rb2HRhdDX65o4w.Add(steamId, priority);
		}
	}

	// Token: 0x0400012D RID: 301
	public static Dictionary<ulong, DBCfkWLnn9d8dtQQBa0x7Cya0> DY1FDD6RaL8Rb2HRhdDX65o4w = new Dictionary<ulong, DBCfkWLnn9d8dtQQBa0x7Cya0>();
}
