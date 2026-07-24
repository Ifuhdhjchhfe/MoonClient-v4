using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000DB RID: 219
public class DYH5lEgzTU4uNZBEH0s7V35Vt
{
	// Token: 0x06000422 RID: 1058 RVA: 0x0003E648 File Offset: 0x0003C848
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerAnimator), "isLeanSpaceEmpty", new Type[] { })]
	private bool DO2XDsYk56uEkUsZqgg0Ll3GK(Vector3 direction)
	{
		bool freeLeans = D5l46jlssr4TRAzUSXzLj0uqu.freeLeans;
		bool flag = freeLeans;
		bool flag2;
		if (flag)
		{
			flag2 = true;
		}
		else
		{
			Vector3 vector = Player.player.transform.position + Player.player.transform.up * Player.player.look.heightLook;
			float radius = PlayerStance.RADIUS;
			float num = 1.2f - radius;
			Vector3 vector2 = vector + direction * num;
			flag2 = Physics.OverlapCapsuleNonAlloc(vector, vector2, radius, DYH5lEgzTU4uNZBEH0s7V35Vt.DK5se16QA8L8AWVk30NR55J0I, RayMasks.BLOCK_LEAN) == 0;
		}
		return flag2;
	}

	// Token: 0x04000465 RID: 1125
	private static Collider[] DK5se16QA8L8AWVk30NR55J0I = new Collider[1];
}
