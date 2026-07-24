using System;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

// Token: 0x02000067 RID: 103
public class DHCJd1410SEtkp3nvdCzixhi9 : MonoBehaviour
{
	// Token: 0x060001EB RID: 491 RVA: 0x00018EB4 File Offset: 0x000170B4
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DcbMT1U7u3koLdKZ2gqoc2zIJ()
	{
		Provider.onClientConnected = (Provider.ClientConnected)Delegate.Combine(Provider.onClientConnected, new Provider.ClientConnected(DHCJd1410SEtkp3nvdCzixhi9.DsOmrEAeiCj2g0xyHcGbdMzm3));
		Provider.onServerConnected = (Provider.ServerConnected)Delegate.Combine(Provider.onServerConnected, new Provider.ServerConnected(delegate(CSteamID steamid)
		{
			DHCJd1410SEtkp3nvdCzixhi9.DsOmrEAeiCj2g0xyHcGbdMzm3();
		}));
		Provider.onClientDisconnected = (Provider.ClientDisconnected)Delegate.Combine(Provider.onClientDisconnected, new Provider.ClientDisconnected(DHCJd1410SEtkp3nvdCzixhi9.Dcit2rPPnXUPmumJzPGZcSTRQ));
		bool flag = D0Kr0NqRHBD41IMsgv7ajeW8M.DxcVo94CW4Y8vQkyhpKozFmcW && Provider.isConnected;
		bool flag2 = flag;
		if (flag2)
		{
			DHCJd1410SEtkp3nvdCzixhi9.DsOmrEAeiCj2g0xyHcGbdMzm3();
		}
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00018F52 File Offset: 0x00017152
	private static void DsOmrEAeiCj2g0xyHcGbdMzm3()
	{
		DHCJd1410SEtkp3nvdCzixhi9.DCBtqbJWH81kUotPHJwyy2sVf = D0Kr0NqRHBD41IMsgv7ajeW8M.D1tYt6KxEmATG67AhmCiQjAGN.AddComponent<DHCJd1410SEtkp3nvdCzixhi9>();
	}

	// Token: 0x060001ED RID: 493 RVA: 0x00018F64 File Offset: 0x00017164
	private static void Dcit2rPPnXUPmumJzPGZcSTRQ()
	{
		global::UnityEngine.Object.Destroy(DHCJd1410SEtkp3nvdCzixhi9.DCBtqbJWH81kUotPHJwyy2sVf);
	}

	// Token: 0x060001EE RID: 494 RVA: 0x00018F74 File Offset: 0x00017174
	private void Update()
	{
		bool mouseButtonDown = Input.GetMouseButtonDown(2);
		bool flag = mouseButtonDown;
		if (flag)
		{
			RaycastInfo raycastInfo = DamageTool.raycast(new Ray(Player.player.look.aim.position, Player.player.look.aim.forward), 15.5f, RayMasks.DAMAGE_CLIENT, Player.player);
			bool flag2 = raycastInfo.player != null && DbdjYbf8enAuqurN70Ytu4YPj.DsWqgMtj8lZbiMEqyexGc2Vcn(raycastInfo.player);
			bool flag3 = flag2;
			if (flag3)
			{
				DbdjYbf8enAuqurN70Ytu4YPj.DqyW5tNjbOTN7i18ZGStyi066(raycastInfo.player, DBCfkWLnn9d8dtQQBa0x7Cya0.Default);
			}
			else
			{
				bool flag4 = raycastInfo.player != null && !DbdjYbf8enAuqurN70Ytu4YPj.DsWqgMtj8lZbiMEqyexGc2Vcn(raycastInfo.player);
				bool flag5 = flag4;
				if (flag5)
				{
					DbdjYbf8enAuqurN70Ytu4YPj.DqyW5tNjbOTN7i18ZGStyi066(raycastInfo.player, DBCfkWLnn9d8dtQQBa0x7Cya0.Friend);
				}
			}
		}
		bool randomSwapingFace = D5l46jlssr4TRAzUSXzLj0uqu.randomSwapingFace;
		bool flag6 = randomSwapingFace;
		if (flag6)
		{
			DHCJd1410SEtkp3nvdCzixhi9.DANPLsb6bByjc4DuzrvPpeA7t += Time.deltaTime;
			bool flag7 = DHCJd1410SEtkp3nvdCzixhi9.DANPLsb6bByjc4DuzrvPpeA7t > D5l46jlssr4TRAzUSXzLj0uqu.faceSwapDelay;
			bool flag8 = flag7;
			if (flag8)
			{
				DHCJd1410SEtkp3nvdCzixhi9.DANPLsb6bByjc4DuzrvPpeA7t = 0f;
				Player.player.clothing.sendSwapFace((byte)global::UnityEngine.Random.Range(0, (int)(Customization.FACES_FREE + 1)));
			}
		}
		Player.player.animator.scopeSway = Player.player.animator.scopeSway * D5l46jlssr4TRAzUSXzLj0uqu.swayMultiplier;
	}

	// Token: 0x04000275 RID: 629
	private static DHCJd1410SEtkp3nvdCzixhi9 DCBtqbJWH81kUotPHJwyy2sVf;

	// Token: 0x04000276 RID: 630
	private static bool DSL0RjAC9ViPd0X4sESX0CsEi;

	// Token: 0x04000277 RID: 631
	private static float DANPLsb6bByjc4DuzrvPpeA7t;
}
