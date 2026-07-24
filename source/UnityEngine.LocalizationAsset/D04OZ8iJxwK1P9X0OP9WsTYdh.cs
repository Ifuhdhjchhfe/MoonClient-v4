using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000003 RID: 3
public static class D04OZ8iJxwK1P9X0OP9WsTYdh
{
	// Token: 0x06000006 RID: 6 RVA: 0x00002B40 File Offset: 0x00000D40
	private static void DKGT3DXnnb4tDwFyf2wAeEGAG(UseableGun gun)
	{
		float num = 1f;
		num += gun.player.skills.mastery(0, 2) * 0.5f;
		bool flag = D04OZ8iJxwK1P9X0OP9WsTYdh.D06kbDQYSkfQLxj3y0KcJKA7H.Get(gun).magazineAsset != null;
		if (flag)
		{
			num *= D04OZ8iJxwK1P9X0OP9WsTYdh.D06kbDQYSkfQLxj3y0KcJKA7H.Get(gun).magazineAsset.speed;
		}
		float num2 = gun.equippedGunAsset.reload.length * num;
		D04OZ8iJxwK1P9X0OP9WsTYdh.DxePiLpMvJuEDYifR2j0IxWOP.Add(gun.player.channel.owner.playerID.steamID.m_SteamID, new ValueTuple<float, float>(Time.realtimeSinceStartup, num2));
		DTm52FQgIZyHlgsIe52RDqzcZ.Dsl47nk11Gy8UerLdkoyZgICJ(D04OZ8iJxwK1P9X0OP9WsTYdh.DOZcQBYlTBfUYnRtVsmsQGsPF(num2, gun.player.channel.owner.playerID.steamID.m_SteamID));
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002C13 File Offset: 0x00000E13
	private static IEnumerator DOZcQBYlTBfUYnRtVsmsQGsPF(float length, ulong steamID)
	{
		yield return new WaitForSeconds(length);
		D04OZ8iJxwK1P9X0OP9WsTYdh.DxePiLpMvJuEDYifR2j0IxWOP.Remove(steamID);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002C2C File Offset: 0x00000E2C
	private static void D5DcEUEYIDVuACFtsOMD5iOQu()
	{
		bool flag = D5l46jlssr4TRAzUSXzLj0uqu.modifyMoveBehaviour && D5l46jlssr4TRAzUSXzLj0uqu.showMoveModifying;
		if (flag)
		{
			D08iy2XFQpUQteL0XRzAbg2IE.D6WfOu184mT2tP3LWMqZEzUjd<CharacterAnimator>(typeof(PlayerAnimator), "thirdAnimator", Player.player.animator).transform.localEulerAngles = new Vector3(90f, 0f, 0f);
		}
		bool flag2 = Player.player != null;
		if (flag2)
		{
			D04OZ8iJxwK1P9X0OP9WsTYdh.DjTSjYtAiAx9SR0uXvJEpxJak = Player.player.look.perspective;
			bool flag3;
			if (D04OZ8iJxwK1P9X0OP9WsTYdh.DjTSjYtAiAx9SR0uXvJEpxJak == EPlayerPerspective.THIRD)
			{
				ECameraMode d66xkrBp6Z1GTuSAAF2uDhRmK = D5l46jlssr4TRAzUSXzLj0uqu.D66xkrBp6Z1GTuSAAF2uDhRmK;
				flag3 = D5l46jlssr4TRAzUSXzLj0uqu.D66xkrBp6Z1GTuSAAF2uDhRmK == ECameraMode.VEHICLE && Player.player.movement.getVehicle() == null;
			}
			else
			{
				flag3 = false;
			}
			bool flag4 = flag3;
			if (flag4)
			{
				D04OZ8iJxwK1P9X0OP9WsTYdh.DI9eu3et7rReZZx6BXy8Ef5Ai.DGHrF0Ht2QRxL0NBgNHj6ZpZX(Player.player.look, new object[] { 0 });
			}
			else
			{
				EPlayerPerspective djTSjYtAiAx9SR0uXvJEpxJak = D04OZ8iJxwK1P9X0OP9WsTYdh.DjTSjYtAiAx9SR0uXvJEpxJak;
				bool flag5 = false;
				if (flag5)
				{
					D04OZ8iJxwK1P9X0OP9WsTYdh.DI9eu3et7rReZZx6BXy8Ef5Ai.DGHrF0Ht2QRxL0NBgNHj6ZpZX(Player.player.look, new object[] { 1 });
				}
			}
		}
		bool imitNightvision = D5l46jlssr4TRAzUSXzLj0uqu.imitNightvision;
		if (imitNightvision)
		{
			LevelLighting.vision = D5l46jlssr4TRAzUSXzLj0uqu.D0lIKBLGl32vj29YP9iicvtqI;
			D9sqUkDmUbz7uUc5edvQF8hDl.D2hcRGy0VyZxVqJMX9bijVbJx();
		}
		bool flag6 = D5l46jlssr4TRAzUSXzLj0uqu.imitNightvision || D5l46jlssr4TRAzUSXzLj0uqu.customDayTime;
		if (flag6)
		{
			LevelLighting.updateLighting();
			LevelLighting.updateLocal();
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002D88 File Offset: 0x00000F88
	private static void D326idqiqZMgYgEEqbUzbEshE()
	{
		bool imitNightvision = D5l46jlssr4TRAzUSXzLj0uqu.imitNightvision;
		if (imitNightvision)
		{
			switch (D5l46jlssr4TRAzUSXzLj0uqu.nightVisionType)
			{
			case DvbEzC20KPBbYRjl1eW9ilgCU.Military:
				LevelLighting.nightvisionColor = new Color32(20, 120, 80, 0);
				LevelLighting.nightvisionFogIntensity = 0.2f;
				break;
			case DvbEzC20KPBbYRjl1eW9ilgCU.Civilian:
				LevelLighting.nightvisionColor = new Color(0.4f, 0.4f, 0.4f, 0f);
				LevelLighting.nightvisionFogIntensity = 0.2f;
				break;
			case DvbEzC20KPBbYRjl1eW9ilgCU.Custom:
			{
				Color color = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Custom nightvision color");
				LevelLighting.nightvisionColor = new Color(color.r, color.g, color.b);
				LevelLighting.nightvisionFogIntensity = color.a;
				break;
			}
			}
			LevelLighting.vision = D5l46jlssr4TRAzUSXzLj0uqu.nightVisionType.D6HbJZ2NUXUKMVsndz6x1ZFtz();
			LevelLighting.updateLighting();
			LevelLighting.updateLocal();
			D9sqUkDmUbz7uUc5edvQF8hDl.D2hcRGy0VyZxVqJMX9bijVbJx();
		}
		bool flag = Player.player != null && Player.player.look.perspective != D04OZ8iJxwK1P9X0OP9WsTYdh.DjTSjYtAiAx9SR0uXvJEpxJak;
		if (flag)
		{
			D04OZ8iJxwK1P9X0OP9WsTYdh.DI9eu3et7rReZZx6BXy8Ef5Ai.DGHrF0Ht2QRxL0NBgNHj6ZpZX(Player.player.look, new object[] { D04OZ8iJxwK1P9X0OP9WsTYdh.DjTSjYtAiAx9SR0uXvJEpxJak });
		}
	}

	// Token: 0x04000003 RID: 3
	private static EPlayerPerspective DjTSjYtAiAx9SR0uXvJEpxJak;

	// Token: 0x04000004 RID: 4
	private static DQyA1nzDa0rZuYtgcLmIWOUf8 DI9eu3et7rReZZx6BXy8Ef5Ai = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(PlayerLook), "setActivePerspective", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000005 RID: 5
	private static DGZv08vQyz81zrHxUqhmYuCdY<Attachments> D06kbDQYSkfQLxj3y0KcJKA7H = new DGZv08vQyz81zrHxUqhmYuCdY<Attachments>(typeof(UseableGun), "thirdAttachments", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000006 RID: 6
	public static Dictionary<ulong, ValueTuple<float, float>> DxePiLpMvJuEDYifR2j0IxWOP = new Dictionary<ulong, ValueTuple<float, float>>();
}
