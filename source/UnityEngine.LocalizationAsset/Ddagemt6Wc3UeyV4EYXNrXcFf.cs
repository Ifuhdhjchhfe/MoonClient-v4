using System;
using System.Collections.Generic;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000044 RID: 68
public static class Ddagemt6Wc3UeyV4EYXNrXcFf
{
	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000122 RID: 290 RVA: 0x0000D7BC File Offset: 0x0000B9BC
	public static Du4XicP1hVrJzXjQ70aniDyvk aimObjective
	{
		get
		{
			bool flag = !DCS4Jf0LRzsehKFc5QOLL06qw.enableAim;
			bool flag2 = flag;
			if (flag2)
			{
				Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC = Ddagemt6Wc3UeyV4EYXNrXcFf.DR3dYlKvgleSINx0Y4IhZHumW();
			}
			return Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC;
		}
	}

	// Token: 0x06000123 RID: 291 RVA: 0x0000D7ED File Offset: 0x0000B9ED
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DoQaBXKPi0xjRGUZtsuiEUs3P()
	{
		Provider.onClientDisconnected = delegate
		{
			Ddagemt6Wc3UeyV4EYXNrXcFf.D6CSCOdxWhfs06Bz8veydqeB0.Clear();
		};
	}

	// Token: 0x06000124 RID: 292 RVA: 0x0000D814 File Offset: 0x0000BA14
	public static void DlajGRkTiYeNVG1q0zkkpQJw9()
	{
		bool flag = !DCS4Jf0LRzsehKFc5QOLL06qw.enableAim;
		bool flag2 = flag;
		if (flag2)
		{
			Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC = Ddagemt6Wc3UeyV4EYXNrXcFf.DR3dYlKvgleSINx0Y4IhZHumW();
		}
	}

	// Token: 0x06000125 RID: 293 RVA: 0x0000D83C File Offset: 0x0000BA3C
	public static void Update()
	{
		bool enableAim = DCS4Jf0LRzsehKFc5QOLL06qw.enableAim;
		bool flag = enableAim;
		if (flag)
		{
			Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC = Ddagemt6Wc3UeyV4EYXNrXcFf.DR3dYlKvgleSINx0Y4IhZHumW();
		}
	}

	// Token: 0x06000126 RID: 294 RVA: 0x0000D864 File Offset: 0x0000BA64
	public static void DTBS9x0Wqj5VvkJcr5w7pj60m(bool research = false)
	{
		bool flag = Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC == null;
		bool flag2 = !flag;
		if (flag2)
		{
			if (research)
			{
				bool flag3 = Ddagemt6Wc3UeyV4EYXNrXcFf.aimObjective.DKr6XbLZDMiJmmxABXHlfTTLz == Dr5qliNNQh3jZolh9fn7SFNyi.Player;
				bool flag4 = flag3;
				if (flag4)
				{
					Ddagemt6Wc3UeyV4EYXNrXcFf.DcvDYLzSjToXqR9kGNZIFXbmF((Ddagemt6Wc3UeyV4EYXNrXcFf.aimObjective.DnuBpXW8r7IgW3DCiPdbWlBGC as Player).DqpvkRCCm2sxv8fMSwLej7Wt3());
				}
				else
				{
					Transform transform = Ddagemt6Wc3UeyV4EYXNrXcFf.DaDfS7pW7z2hwpjq5z9bGs138(Ddagemt6Wc3UeyV4EYXNrXcFf.aimObjective.DKr6XbLZDMiJmmxABXHlfTTLz, Ddagemt6Wc3UeyV4EYXNrXcFf.aimObjective.DnuBpXW8r7IgW3DCiPdbWlBGC);
					bool flag5 = transform != null;
					bool flag6 = flag5;
					if (flag6)
					{
						Ddagemt6Wc3UeyV4EYXNrXcFf.DcvDYLzSjToXqR9kGNZIFXbmF(transform.position);
					}
				}
			}
			else
			{
				bool flag7 = Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DKr6XbLZDMiJmmxABXHlfTTLz == Dr5qliNNQh3jZolh9fn7SFNyi.Player;
				bool flag8 = flag7;
				if (flag8)
				{
					Ddagemt6Wc3UeyV4EYXNrXcFf.DcvDYLzSjToXqR9kGNZIFXbmF((Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC as Player).DqpvkRCCm2sxv8fMSwLej7Wt3());
				}
				else
				{
					Transform transform2 = Ddagemt6Wc3UeyV4EYXNrXcFf.DaDfS7pW7z2hwpjq5z9bGs138(Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DKr6XbLZDMiJmmxABXHlfTTLz, Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC);
					bool flag9 = transform2 != null;
					bool flag10 = flag9;
					if (flag10)
					{
						Ddagemt6Wc3UeyV4EYXNrXcFf.DcvDYLzSjToXqR9kGNZIFXbmF(transform2.position);
					}
				}
			}
		}
	}

	// Token: 0x06000127 RID: 295 RVA: 0x0000D97C File Offset: 0x0000BB7C
	public static void DcvDYLzSjToXqR9kGNZIFXbmF(Vector3 pos)
	{
		bool flag = Player.player.movement.getVehicle() != null;
		bool flag2 = flag;
		if (flag2)
		{
			Player.player.movement.getVehicle().transform.eulerAngles = DmErKmxWRjHNSG8p8mCUQIUbM.Dp0TyaMelufYHIv2RuI1cjCTN(MainCamera.instance.transform.position, pos);
		}
		else
		{
			bool smoothAimbot = DCS4Jf0LRzsehKFc5QOLL06qw.smoothAimbot;
			bool flag3 = smoothAimbot;
			if (flag3)
			{
				Player.player.transform.rotation = Quaternion.Slerp(Player.player.transform.rotation, Quaternion.LookRotation(pos - Player.player.transform.position), Time.deltaTime * DCS4Jf0LRzsehKFc5QOLL06qw.smoothAimbotSpeed);
				Player.player.transform.eulerAngles = new Vector3(0f, Player.player.transform.rotation.eulerAngles.y, 0f);
				MainCamera.instance.transform.localRotation = Quaternion.Slerp(MainCamera.instance.transform.localRotation, Quaternion.LookRotation(pos - MainCamera.instance.transform.position), Time.deltaTime * DCS4Jf0LRzsehKFc5QOLL06qw.smoothAimbotSpeed);
				float num = MainCamera.instance.transform.localRotation.eulerAngles.x;
				bool flag4 = num <= 90f && num <= 270f;
				bool flag5 = flag4;
				if (flag5)
				{
					num = MainCamera.instance.transform.localRotation.eulerAngles.x + 90f;
				}
				else
				{
					bool flag6 = num >= 270f && num <= 360f;
					bool flag7 = flag6;
					if (flag7)
					{
						num = MainCamera.instance.transform.localRotation.eulerAngles.x - 270f;
					}
				}
				Ddagemt6Wc3UeyV4EYXNrXcFf.Dd0KuLwyvc6fwwJM1JPteX0mL.Set(Player.player.look, num);
				Ddagemt6Wc3UeyV4EYXNrXcFf.DCmzMVXAqJ2O6KXsQiAL8WlyE.Set(Player.player.look, Player.player.transform.rotation.eulerAngles.y);
			}
			else
			{
				Player.player.transform.LookAt(pos);
				Player.player.transform.eulerAngles = new Vector3(0f, Player.player.transform.rotation.eulerAngles.y, 0f);
				MainCamera.instance.transform.LookAt(pos);
				float num2 = MainCamera.instance.transform.localRotation.eulerAngles.x;
				bool flag8 = num2 <= 90f && num2 <= 270f;
				bool flag9 = flag8;
				if (flag9)
				{
					num2 = MainCamera.instance.transform.localRotation.eulerAngles.x + 90f;
				}
				else
				{
					bool flag10 = num2 >= 270f && num2 <= 360f;
					bool flag11 = flag10;
					if (flag11)
					{
						num2 = MainCamera.instance.transform.localRotation.eulerAngles.x - 270f;
					}
				}
				Ddagemt6Wc3UeyV4EYXNrXcFf.Dd0KuLwyvc6fwwJM1JPteX0mL.Set(Player.player.look, num2);
				Ddagemt6Wc3UeyV4EYXNrXcFf.DCmzMVXAqJ2O6KXsQiAL8WlyE.Set(Player.player.look, Player.player.transform.rotation.eulerAngles.y);
			}
		}
	}

	// Token: 0x06000128 RID: 296 RVA: 0x0000DD30 File Offset: 0x0000BF30
	public static Du4XicP1hVrJzXjQ70aniDyvk DR3dYlKvgleSINx0Y4IhZHumW()
	{
		int num = DI8jSvGQa3grzg5wlLxwkRj27.DzGDOq0dZL2sIXJTdcfSy2A4v("Aimbot FOV");
		foreach (Dr5qliNNQh3jZolh9fn7SFNyi dr5qliNNQh3jZolh9fn7SFNyi in DCS4Jf0LRzsehKFc5QOLL06qw.DULiu9lLWSHNenYxzlK8xT984)
		{
			try
			{
				bool flag = DCS4Jf0LRzsehKFc5QOLL06qw.checkWithLinecast && !DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim;
				Du4XicP1hVrJzXjQ70aniDyvk du4XicP1hVrJzXjQ70aniDyvk = Ddagemt6Wc3UeyV4EYXNrXcFf.D6Dq2Nelof0vcFzyPbrogq9hS(DmErKmxWRjHNSG8p8mCUQIUbM.D3lA05pX4HfBlOQWdxeK6L6B8(), num, dr5qliNNQh3jZolh9fn7SFNyi, DCS4Jf0LRzsehKFc5QOLL06qw.aimSorting, flag, DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim, false);
				bool flag2 = du4XicP1hVrJzXjQ70aniDyvk.DnuBpXW8r7IgW3DCiPdbWlBGC != null;
				bool flag3 = flag2;
				if (flag3)
				{
					return du4XicP1hVrJzXjQ70aniDyvk;
				}
			}
			catch
			{
				return new Du4XicP1hVrJzXjQ70aniDyvk(Dr5qliNNQh3jZolh9fn7SFNyi.Player, null, Vector3.zero);
			}
		}
		return new Du4XicP1hVrJzXjQ70aniDyvk(Dr5qliNNQh3jZolh9fn7SFNyi.Player, null, Vector3.zero);
	}

	// Token: 0x06000129 RID: 297 RVA: 0x0000DE08 File Offset: 0x0000C008
	public static Du4XicP1hVrJzXjQ70aniDyvk D6Dq2Nelof0vcFzyPbrogq9hS(int distance, int fov, Dr5qliNNQh3jZolh9fn7SFNyi goal, DK27IZ62oGywnytdkDio7Gbp0 sorting, bool checkWalls = true, bool checkBySilent = true, bool tryExpandSphere = false)
	{
		int num;
		switch (goal)
		{
		case Dr5qliNNQh3jZolh9fn7SFNyi.Player:
		{
			num = Provider.clients.Count;
			bool flag = num == 1;
			bool flag2 = flag;
			if (flag2)
			{
				return new Du4XicP1hVrJzXjQ70aniDyvk(goal, null, Vector3.zero);
			}
			break;
		}
		case Dr5qliNNQh3jZolh9fn7SFNyi.ClaimFlags:
			num = DMkRmB9x1tCMUY9gJrDDfwiTu.DEzWsw5jvnnLHadQ7NpSnAjub.Count;
			break;
		case Dr5qliNNQh3jZolh9fn7SFNyi.Beds:
			num = DMkRmB9x1tCMUY9gJrDDfwiTu.DEHEaA2OjZzMvn4LKaA2DVfhb.Count;
			break;
		case Dr5qliNNQh3jZolh9fn7SFNyi.Storages:
			num = DMkRmB9x1tCMUY9gJrDDfwiTu.DciNRxefGPpxmVxfJNEEiDCqN.Count;
			break;
		case Dr5qliNNQh3jZolh9fn7SFNyi.Zombies:
			num = DLjyRj40FZ7PYHif8c4X1NUcn.DD30C4J2BCAh7gXdMzJpEedQk.Count;
			break;
		case Dr5qliNNQh3jZolh9fn7SFNyi.Animals:
			num = AnimalManager.animals.Count;
			break;
		case Dr5qliNNQh3jZolh9fn7SFNyi.Vehicles:
			num = VehicleManager.vehicles.Count;
			break;
		default:
			return new Du4XicP1hVrJzXjQ70aniDyvk(goal, null, Vector3.zero);
		}
		int num2 = distance + 1;
		int num3 = fov + 1;
		int num4 = -1;
		int num5 = -1;
		Vector3 vector = Vector3.zero;
		Vector3 vector2 = Vector3.zero;
		Vector3 vector3 = Vector3.zero;
		Transform transform = ((Player.player.look.aim.transform != null) ? Player.player.look.aim.transform : ((MainCamera.instance != null) ? MainCamera.instance.transform : Camera.current.transform));
		int i = 0;
		while (i < num)
		{
			Vector3 vector4;
			switch (goal)
			{
			case Dr5qliNNQh3jZolh9fn7SFNyi.Player:
			{
				bool flag3 = Provider.clients[i] == null || Provider.clients[i].player == null;
				bool flag4 = !flag3;
				if (flag4)
				{
					bool flag5 = Provider.clients[i].player.channel.IsLocalPlayer || Provider.clients[i].player.life.isDead;
					bool flag6 = !flag5;
					if (flag6)
					{
						bool flag7 = DbdjYbf8enAuqurN70Ytu4YPj.DUm5Cdfmw0jQhXvw0M59ozPv7(Provider.clients[i]);
						bool flag8 = !flag7;
						if (flag8)
						{
							bool flag9 = DCS4Jf0LRzsehKFc5QOLL06qw.dontShootPlayersOnSafezone && LevelNodes.isPointInsideSafezone(Provider.clients[i].player.transform.position, out Provider.clients[i].player.movement.isSafeInfo);
							bool flag10 = !flag9;
							if (flag10)
							{
								vector4 = Provider.clients[i].player.DqpvkRCCm2sxv8fMSwLej7Wt3();
								goto IL_0469;
							}
						}
					}
				}
				break;
			}
			case Dr5qliNNQh3jZolh9fn7SFNyi.ClaimFlags:
			{
				bool flag11 = DMkRmB9x1tCMUY9gJrDDfwiTu.DEzWsw5jvnnLHadQ7NpSnAjub[i] == null;
				bool flag12 = !flag11;
				if (flag12)
				{
					vector4 = DMkRmB9x1tCMUY9gJrDDfwiTu.DEzWsw5jvnnLHadQ7NpSnAjub[i].transform.position;
					goto IL_0469;
				}
				break;
			}
			case Dr5qliNNQh3jZolh9fn7SFNyi.Beds:
			{
				bool flag13 = DMkRmB9x1tCMUY9gJrDDfwiTu.DEHEaA2OjZzMvn4LKaA2DVfhb[i] == null;
				bool flag14 = !flag13;
				if (flag14)
				{
					vector4 = DMkRmB9x1tCMUY9gJrDDfwiTu.DEHEaA2OjZzMvn4LKaA2DVfhb[i].transform.position;
					goto IL_0469;
				}
				break;
			}
			case Dr5qliNNQh3jZolh9fn7SFNyi.Storages:
			{
				bool flag15 = DMkRmB9x1tCMUY9gJrDDfwiTu.DciNRxefGPpxmVxfJNEEiDCqN[i] == null;
				bool flag16 = !flag15;
				if (flag16)
				{
					vector4 = DMkRmB9x1tCMUY9gJrDDfwiTu.DciNRxefGPpxmVxfJNEEiDCqN[i].transform.position;
					goto IL_0469;
				}
				break;
			}
			case Dr5qliNNQh3jZolh9fn7SFNyi.Zombies:
			{
				bool flag17 = DLjyRj40FZ7PYHif8c4X1NUcn.DD30C4J2BCAh7gXdMzJpEedQk[i] == null || DLjyRj40FZ7PYHif8c4X1NUcn.DD30C4J2BCAh7gXdMzJpEedQk[i].isDead;
				bool flag18 = !flag17;
				if (flag18)
				{
					vector4 = DLjyRj40FZ7PYHif8c4X1NUcn.DD30C4J2BCAh7gXdMzJpEedQk[i].transform.position;
					goto IL_0469;
				}
				break;
			}
			case Dr5qliNNQh3jZolh9fn7SFNyi.Animals:
			{
				bool flag19 = AnimalManager.animals[i] == null || AnimalManager.animals[i].isDead;
				bool flag20 = !flag19;
				if (flag20)
				{
					vector4 = AnimalManager.animals[i].transform.position;
					goto IL_0469;
				}
				break;
			}
			case Dr5qliNNQh3jZolh9fn7SFNyi.Vehicles:
			{
				bool flag21 = VehicleManager.vehicles[i] == null || VehicleManager.vehicles[i].isDead;
				bool flag22 = !flag21;
				if (flag22)
				{
					vector4 = VehicleManager.vehicles[i].transform.position;
					goto IL_0469;
				}
				break;
			}
			default:
				vector4 = Vector3.zero;
				goto IL_0469;
			}
			IL_045D:
			i++;
			continue;
			IL_0469:
			bool flag23 = vector4 == Vector3.zero;
			bool flag24 = flag23;
			if (flag24)
			{
				goto IL_045D;
			}
			bool flag25 = Vector3.Distance(vector4, Player.player.transform.position) > (float)distance;
			bool flag26 = flag25;
			if (flag26)
			{
				goto IL_045D;
			}
			bool flag27 = !vector4.DGxZdvjodtrVw5BNkkaZ9SGFr();
			bool flag28 = flag27;
			if (flag28)
			{
				goto IL_045D;
			}
			Vector3 vector5 = vector4.DEfdLut9iGJvTAJNGrXHRFglR();
			bool flag29 = DCS4Jf0LRzsehKFc5QOLL06qw.restrictAimByFov && Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector5.x, vector5.y)) > (float)fov;
			bool flag30 = flag29;
			if (flag30)
			{
				goto IL_045D;
			}
			bool flag31 = checkWalls && Physics.Linecast(transform.position, vector4, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
			bool flag32 = flag31;
			if (flag32)
			{
				goto IL_045D;
			}
			if (checkBySilent)
			{
				bool flag33 = DCS4Jf0LRzsehKFc5QOLL06qw.silentAimType == DokdtlMHqRTX0KbeCtveFDTNT.Distance && DCS4Jf0LRzsehKFc5QOLL06qw.verifyForwardHitPointAviablity && Physics.Linecast(transform.position, vector4 + DmErKmxWRjHNSG8p8mCUQIUbM.DWTJZMUdPCnE0MBXkaJ5OA6m0(vector4, transform.position) * Mathf.Clamp(Vector3.Distance(vector4, transform.position), 0f, (float)DCS4Jf0LRzsehKFc5QOLL06qw.distanceToHit), RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
				bool flag34 = flag33;
				if (flag34)
				{
					goto IL_045D;
				}
				bool flag35 = DCS4Jf0LRzsehKFc5QOLL06qw.silentAimType == DokdtlMHqRTX0KbeCtveFDTNT.Sphere && !checkWalls && !vector4.DJfKIDGo7o78PGeoQlUplDvpS(out vector3, Player.player.equipment.asset != null && !(Player.player.equipment.asset is ItemMeleeAsset));
				bool flag36 = flag35;
				if (flag36)
				{
					goto IL_045D;
				}
			}
			bool flag37 = sorting == DK27IZ62oGywnytdkDio7Gbp0.Unmanaged;
			bool flag38 = flag37;
			if (flag38)
			{
				return Ddagemt6Wc3UeyV4EYXNrXcFf.Dsf0Sskkn48i40RijL7k6f0ib(goal, i, vector3);
			}
			bool flag39 = Vector3.Distance(vector4, Player.player.transform.position) < (float)num2;
			bool flag40 = flag39;
			if (flag40)
			{
				bool flag41 = !checkBySilent || DCS4Jf0LRzsehKFc5QOLL06qw.silentAimType == DokdtlMHqRTX0KbeCtveFDTNT.Aim;
				bool flag42 = flag41;
				if (flag42)
				{
					vector3 = vector4;
				}
				vector = vector3;
				num4 = i;
				num2 = (int)Vector3.Distance(vector4, Player.player.transform.position);
			}
			bool flag43 = Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector5.x, vector5.y)) < (float)num3;
			bool flag44 = flag43;
			if (flag44)
			{
				bool flag45 = !checkBySilent || DCS4Jf0LRzsehKFc5QOLL06qw.silentAimType == DokdtlMHqRTX0KbeCtveFDTNT.Aim;
				bool flag46 = flag45;
				if (flag46)
				{
					vector3 = vector4;
				}
				vector2 = vector3;
				num5 = i;
				num3 = (int)Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector5.x, vector5.y));
			}
			goto IL_045D;
		}
		bool flag47 = num4 == -1;
		bool flag48 = flag47;
		Du4XicP1hVrJzXjQ70aniDyvk du4XicP1hVrJzXjQ70aniDyvk;
		if (flag48)
		{
			du4XicP1hVrJzXjQ70aniDyvk = new Du4XicP1hVrJzXjQ70aniDyvk(goal, null, Vector3.zero);
		}
		else
		{
			bool flag49 = sorting == DK27IZ62oGywnytdkDio7Gbp0.Distance;
			bool flag50 = flag49;
			if (flag50)
			{
				du4XicP1hVrJzXjQ70aniDyvk = Ddagemt6Wc3UeyV4EYXNrXcFf.Dsf0Sskkn48i40RijL7k6f0ib(goal, num4, vector);
			}
			else
			{
				bool flag51 = sorting == DK27IZ62oGywnytdkDio7Gbp0.FOV;
				bool flag52 = flag51;
				if (flag52)
				{
					du4XicP1hVrJzXjQ70aniDyvk = Ddagemt6Wc3UeyV4EYXNrXcFf.Dsf0Sskkn48i40RijL7k6f0ib(goal, num5, vector2);
				}
				else
				{
					du4XicP1hVrJzXjQ70aniDyvk = new Du4XicP1hVrJzXjQ70aniDyvk(goal, null, Vector3.zero);
				}
			}
		}
		return du4XicP1hVrJzXjQ70aniDyvk;
	}

	// Token: 0x0600012A RID: 298 RVA: 0x0000E5D0 File Offset: 0x0000C7D0
	public static Transform DaDfS7pW7z2hwpjq5z9bGs138(Dr5qliNNQh3jZolh9fn7SFNyi ag, object o)
	{
		bool flag = o == null;
		bool flag2 = flag;
		Transform transform;
		if (flag2)
		{
			transform = null;
		}
		else
		{
			switch (ag)
			{
			case Dr5qliNNQh3jZolh9fn7SFNyi.Player:
				transform = ((Player)o).transform;
				break;
			case Dr5qliNNQh3jZolh9fn7SFNyi.ClaimFlags:
				transform = ((InteractableClaim)o).transform;
				break;
			case Dr5qliNNQh3jZolh9fn7SFNyi.Beds:
				transform = ((InteractableBed)o).transform;
				break;
			case Dr5qliNNQh3jZolh9fn7SFNyi.Storages:
				transform = ((InteractableStorage)o).transform;
				break;
			case Dr5qliNNQh3jZolh9fn7SFNyi.Zombies:
				transform = ((Zombie)o).transform;
				break;
			case Dr5qliNNQh3jZolh9fn7SFNyi.Animals:
				transform = ((Animal)o).transform;
				break;
			case Dr5qliNNQh3jZolh9fn7SFNyi.Vehicles:
				transform = ((InteractableVehicle)o).transform;
				break;
			default:
				transform = null;
				break;
			}
		}
		return transform;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x0000E68C File Offset: 0x0000C88C
	public static Transform DL0250m6MAXHl6JdAreUGuchB(object o)
	{
		bool flag = o is Player;
		bool flag2 = flag;
		Transform transform;
		if (flag2)
		{
			transform = ((Player)o).DZ1neBHBeQuVqC6Wm1V5KB69h();
		}
		else
		{
			bool flag3 = o is InteractableBed;
			bool flag4 = flag3;
			if (flag4)
			{
				transform = ((InteractableBed)o).transform;
			}
			else
			{
				bool flag5 = o is InteractableClaim;
				bool flag6 = flag5;
				if (flag6)
				{
					transform = ((InteractableClaim)o).transform;
				}
				else
				{
					bool flag7 = o is InteractableStorage;
					bool flag8 = flag7;
					if (flag8)
					{
						transform = ((InteractableStorage)o).transform;
					}
					else
					{
						bool flag9 = o is InteractableVehicle;
						bool flag10 = flag9;
						if (flag10)
						{
							transform = ((InteractableVehicle)o).transform;
						}
						else
						{
							bool flag11 = o is Zombie;
							bool flag12 = flag11;
							if (flag12)
							{
								transform = ((Zombie)o).transform;
							}
							else
							{
								bool flag13 = o is Animal;
								bool flag14 = flag13;
								if (flag14)
								{
									transform = ((Animal)o).transform;
								}
								else
								{
									transform = null;
								}
							}
						}
					}
				}
			}
		}
		return transform;
	}

	// Token: 0x0600012C RID: 300 RVA: 0x0000E7AC File Offset: 0x0000C9AC
	public static bool D7Zl9UZ09KSFYqnGFRb0oyhA1()
	{
		bool flag = DCS4Jf0LRzsehKFc5QOLL06qw.aimingChance == 100;
		bool flag2 = flag;
		bool flag3;
		if (flag2)
		{
			flag3 = true;
		}
		else
		{
			bool flag4 = DCS4Jf0LRzsehKFc5QOLL06qw.aimingChance != Ddagemt6Wc3UeyV4EYXNrXcFf.DKKoACMwRNz4vCJpfORisgZxz;
			bool flag5 = flag4;
			if (flag5)
			{
				Ddagemt6Wc3UeyV4EYXNrXcFf.DnvvBcIJCBXZ09Y0YLrV4wvvP = 0;
				Ddagemt6Wc3UeyV4EYXNrXcFf.DKKoACMwRNz4vCJpfORisgZxz = DCS4Jf0LRzsehKFc5QOLL06qw.aimingChance;
				flag3 = true;
			}
			else
			{
				Ddagemt6Wc3UeyV4EYXNrXcFf.DnvvBcIJCBXZ09Y0YLrV4wvvP += Ddagemt6Wc3UeyV4EYXNrXcFf.DKKoACMwRNz4vCJpfORisgZxz;
				bool flag6 = Ddagemt6Wc3UeyV4EYXNrXcFf.DnvvBcIJCBXZ09Y0YLrV4wvvP >= 100;
				bool flag7 = flag6;
				if (flag7)
				{
					Ddagemt6Wc3UeyV4EYXNrXcFf.DnvvBcIJCBXZ09Y0YLrV4wvvP -= 100;
					flag3 = true;
				}
				else
				{
					flag3 = false;
				}
			}
		}
		return flag3;
	}

	// Token: 0x0600012D RID: 301 RVA: 0x0000E844 File Offset: 0x0000CA44
	private static Du4XicP1hVrJzXjQ70aniDyvk Dsf0Sskkn48i40RijL7k6f0ib(Dr5qliNNQh3jZolh9fn7SFNyi ag, int index, Vector3 point)
	{
		Du4XicP1hVrJzXjQ70aniDyvk du4XicP1hVrJzXjQ70aniDyvk;
		switch (ag)
		{
		case Dr5qliNNQh3jZolh9fn7SFNyi.Player:
			du4XicP1hVrJzXjQ70aniDyvk = new Du4XicP1hVrJzXjQ70aniDyvk(ag, Provider.clients[index].player, point);
			break;
		case Dr5qliNNQh3jZolh9fn7SFNyi.ClaimFlags:
			du4XicP1hVrJzXjQ70aniDyvk = new Du4XicP1hVrJzXjQ70aniDyvk(ag, DMkRmB9x1tCMUY9gJrDDfwiTu.DEzWsw5jvnnLHadQ7NpSnAjub[index], point);
			break;
		case Dr5qliNNQh3jZolh9fn7SFNyi.Beds:
			du4XicP1hVrJzXjQ70aniDyvk = new Du4XicP1hVrJzXjQ70aniDyvk(ag, DMkRmB9x1tCMUY9gJrDDfwiTu.DEHEaA2OjZzMvn4LKaA2DVfhb[index], point);
			break;
		case Dr5qliNNQh3jZolh9fn7SFNyi.Storages:
			du4XicP1hVrJzXjQ70aniDyvk = new Du4XicP1hVrJzXjQ70aniDyvk(ag, DMkRmB9x1tCMUY9gJrDDfwiTu.DciNRxefGPpxmVxfJNEEiDCqN[index], point);
			break;
		case Dr5qliNNQh3jZolh9fn7SFNyi.Zombies:
			du4XicP1hVrJzXjQ70aniDyvk = new Du4XicP1hVrJzXjQ70aniDyvk(ag, DLjyRj40FZ7PYHif8c4X1NUcn.DD30C4J2BCAh7gXdMzJpEedQk[index], point);
			break;
		case Dr5qliNNQh3jZolh9fn7SFNyi.Animals:
			du4XicP1hVrJzXjQ70aniDyvk = new Du4XicP1hVrJzXjQ70aniDyvk(ag, AnimalManager.animals[index], point);
			break;
		case Dr5qliNNQh3jZolh9fn7SFNyi.Vehicles:
			du4XicP1hVrJzXjQ70aniDyvk = new Du4XicP1hVrJzXjQ70aniDyvk(ag, VehicleManager.vehicles[index], point);
			break;
		default:
			du4XicP1hVrJzXjQ70aniDyvk = new Du4XicP1hVrJzXjQ70aniDyvk(ag, null, point);
			break;
		}
		return du4XicP1hVrJzXjQ70aniDyvk;
	}

	// Token: 0x0600012E RID: 302 RVA: 0x0000E930 File Offset: 0x0000CB30
	public static void DSX7avr6KhIFJ0akNPOH6PCth(GameObject obj, object targetObject, Vector3 point, ref RaycastInfo info)
	{
		bool flag = targetObject is InteractableClaim || targetObject is InteractableBed || targetObject is InteractableStorage;
		info.point = point;
		info.collider = obj.GetComponent<BoxCollider>();
		info.transform = (flag ? DamageTool.getBarricadeRootTransform(obj.transform) : obj.transform);
		info.limb = DCS4Jf0LRzsehKFc5QOLL06qw.silentAimLimb.DG8Vk5LC0j20si9xsv3no34VC();
		Ddagemt6Wc3UeyV4EYXNrXcFf.DKyAi4PDSVciCMaEjciiGp3uy(ref info, targetObject);
		bool flag2 = flag;
		bool flag3 = flag2;
		if (flag3)
		{
			info.materialName = PhysicsTool.GetMaterialName(info.point, info.transform, info.collider);
			info.material = PhysicsTool.GetLegacyMaterialByName(info.materialName);
		}
		else
		{
			info.material = EPhysicsMaterial.NONE;
		}
	}

	// Token: 0x0600012F RID: 303 RVA: 0x0000E9F0 File Offset: 0x0000CBF0
	public static RaycastInfo DekCZGHuDOeWrqaF1G4zTvsjw(Ray ray, float range, int mask, Player ignorePlayer, ref DRxteGz0evnNDVy6poswGHA5b ebi)
	{
		RaycastInfo raycastInfo = null;
		bool flag = DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim && Ddagemt6Wc3UeyV4EYXNrXcFf.Djz3PegCj2WVim2cKUSYrShH1(ray, range, mask, ignorePlayer, ref ebi, out raycastInfo);
		bool flag2 = flag;
		RaycastInfo raycastInfo2;
		if (flag2)
		{
			raycastInfo2 = raycastInfo;
		}
		else
		{
			raycastInfo2 = DamageTool.raycast(ray, range, mask, ignorePlayer);
		}
		return raycastInfo2;
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0000EA38 File Offset: 0x0000CC38
	public static RaycastInfo DirOiKWUP3gPFUY6wI0yja3CG(Ray ray, float range, int mask, Player ignorePlayer)
	{
		RaycastInfo raycastInfo = null;
		bool flag = DCS4Jf0LRzsehKFc5QOLL06qw.enableMeleeSilentAim && Ddagemt6Wc3UeyV4EYXNrXcFf.Df0d9LGcXHa0iCK3p4btIz1uR(ray, range, mask, ignorePlayer, Ddagemt6Wc3UeyV4EYXNrXcFf.aimObjective.DnuBpXW8r7IgW3DCiPdbWlBGC, out raycastInfo);
		bool flag2 = flag;
		RaycastInfo raycastInfo2;
		if (flag2)
		{
			raycastInfo2 = raycastInfo;
		}
		else
		{
			bool extendMeleeRange = D5l46jlssr4TRAzUSXzLj0uqu.extendMeleeRange;
			bool flag3 = extendMeleeRange;
			if (flag3)
			{
				RaycastInfo raycastInfo3 = DamageTool.raycast(ray, 21f, mask, ignorePlayer);
				bool flag4 = raycastInfo3.collider != null;
				bool flag5 = flag4;
				if (flag5)
				{
					raycastInfo3.point += DmErKmxWRjHNSG8p8mCUQIUbM.DWTJZMUdPCnE0MBXkaJ5OA6m0(raycastInfo3.point, Player.player.look.aim.position) * Mathf.Max(0f, Vector3.Distance(raycastInfo3.collider.transform.position, Player.player.look.aim.position) - 6f);
				}
				raycastInfo2 = raycastInfo3;
			}
			else
			{
				raycastInfo2 = DamageTool.raycast(ray, range, mask, ignorePlayer);
			}
		}
		return raycastInfo2;
	}

	// Token: 0x06000131 RID: 305 RVA: 0x0000EB40 File Offset: 0x0000CD40
	private static void DKyAi4PDSVciCMaEjciiGp3uy(ref RaycastInfo info, object targetObject)
	{
		bool flag = targetObject is Player;
		bool flag2 = flag;
		if (flag2)
		{
			info.player = (Player)targetObject;
		}
		else
		{
			bool flag3 = targetObject is Zombie;
			bool flag4 = flag3;
			if (flag4)
			{
				info.zombie = (Zombie)targetObject;
			}
			else
			{
				bool flag5 = targetObject is Animal;
				bool flag6 = flag5;
				if (flag6)
				{
					info.animal = (Animal)targetObject;
				}
				else
				{
					bool flag7 = targetObject is InteractableVehicle;
					bool flag8 = flag7;
					if (flag8)
					{
						info.vehicle = (InteractableVehicle)targetObject;
					}
				}
			}
		}
	}

	// Token: 0x06000132 RID: 306 RVA: 0x0000EBDC File Offset: 0x0000CDDC
	private static bool Df0d9LGcXHa0iCK3p4btIz1uR(Ray ray, float range, int mask, Player ignorePlayer, object targetObject, out RaycastInfo info)
	{
		info = null;
		Transform transform = Ddagemt6Wc3UeyV4EYXNrXcFf.DL0250m6MAXHl6JdAreUGuchB(targetObject);
		bool flag = transform == null;
		bool flag2 = flag;
		bool flag3;
		if (flag2)
		{
			flag3 = false;
		}
		else
		{
			bool checkWithLinecast = DCS4Jf0LRzsehKFc5QOLL06qw.checkWithLinecast;
			bool flag4 = checkWithLinecast;
			if (flag4)
			{
				info = DamageTool.raycast(new Ray(ray.origin, DmErKmxWRjHNSG8p8mCUQIUbM.DWTJZMUdPCnE0MBXkaJ5OA6m0(ray.origin, transform.position)), range, mask, ignorePlayer);
			}
			else
			{
				bool flag5 = targetObject is InteractableClaim || targetObject is InteractableBed || targetObject is InteractableStorage;
				info = DamageTool.raycast(new Ray(ray.origin, DmErKmxWRjHNSG8p8mCUQIUbM.DWTJZMUdPCnE0MBXkaJ5OA6m0(ray.origin, transform.position)), range, mask, ignorePlayer);
				Vector3 point = info.point;
				info.point = transform.position - DmErKmxWRjHNSG8p8mCUQIUbM.DWTJZMUdPCnE0MBXkaJ5OA6m0(ray.origin, transform.position) * (15f * (Vector3.Distance(transform.position, ray.origin) / 21f));
				bool flag6 = Physics.Linecast(info.point, Player.player.look.aim.transform.position, RayMasks.DAMAGE_CLIENT);
				bool flag7 = flag6;
				if (flag7)
				{
					info.point = point;
					bool flag8 = Vector3.Distance(transform.position, ray.origin) > 15f;
					bool flag9 = flag8;
					if (flag9)
					{
						info.point = transform.position - ray.direction * 15f;
					}
					else
					{
						info.point = transform.position - ray.direction * Vector3.Distance(transform.position, ray.origin);
					}
				}
				info.collider = transform.GetComponent<BoxCollider>();
				info.transform = (flag5 ? DamageTool.getBarricadeRootTransform(transform.transform) : transform.transform);
				Ddagemt6Wc3UeyV4EYXNrXcFf.DKyAi4PDSVciCMaEjciiGp3uy(ref info, targetObject);
				bool flag10 = flag5;
				bool flag11 = flag10;
				if (flag11)
				{
					info.materialName = PhysicsTool.GetMaterialName(info.point, info.transform, info.collider);
					info.material = PhysicsTool.GetLegacyMaterialByName(info.materialName);
				}
				else
				{
					info.material = EPhysicsMaterial.NONE;
				}
			}
			flag3 = true;
		}
		return flag3;
	}

	// Token: 0x06000133 RID: 307 RVA: 0x0000EE44 File Offset: 0x0000D044
	private static bool Djz3PegCj2WVim2cKUSYrShH1(Ray ray, float range, int mask, Player ignorePlayer, ref DRxteGz0evnNDVy6poswGHA5b ebi, out RaycastInfo info)
	{
		info = null;
		bool flag = ebi.DxXccHaM347WXA3xnOnqbjen9 == null;
		bool flag2 = flag;
		bool flag3;
		if (flag2)
		{
			flag3 = false;
		}
		else
		{
			Transform transform = Ddagemt6Wc3UeyV4EYXNrXcFf.DL0250m6MAXHl6JdAreUGuchB(ebi.DxXccHaM347WXA3xnOnqbjen9);
			bool flag4 = transform == null;
			bool flag5 = flag4;
			if (flag5)
			{
				flag3 = false;
			}
			else
			{
				switch (DCS4Jf0LRzsehKFc5QOLL06qw.silentAimType)
				{
				case DokdtlMHqRTX0KbeCtveFDTNT.Aim:
				{
					bool flag6 = !DCS4Jf0LRzsehKFc5QOLL06qw.straightRaycasting;
					bool flag7 = flag6;
					if (flag7)
					{
						info = DamageTool.raycast(new Ray(ray.origin, DmErKmxWRjHNSG8p8mCUQIUbM.DWTJZMUdPCnE0MBXkaJ5OA6m0(ray.origin, transform.position)), range, mask, ignorePlayer);
						flag3 = info != null && info.transform != null;
					}
					else
					{
						flag3 = false;
					}
					break;
				}
				case DokdtlMHqRTX0KbeCtveFDTNT.Distance:
				{
					info = (DCS4Jf0LRzsehKFc5QOLL06qw.straightRaycasting ? DamageTool.raycast(new Ray(ray.origin, ray.direction), range, mask, ignorePlayer) : DamageTool.raycast(new Ray(ray.origin, DmErKmxWRjHNSG8p8mCUQIUbM.DWTJZMUdPCnE0MBXkaJ5OA6m0(ray.origin, transform.position)), range, mask, ignorePlayer));
					bool flag8 = DCS4Jf0LRzsehKFc5QOLL06qw.traceFromOrigin && Vector3.Distance(transform.position, ray.origin) <= (float)DCS4Jf0LRzsehKFc5QOLL06qw.distanceToHit + range && (!DCS4Jf0LRzsehKFc5QOLL06qw.verifyTraceByLinecast || !Physics.Linecast(ray.origin, DmErKmxWRjHNSG8p8mCUQIUbM.DWTJZMUdPCnE0MBXkaJ5OA6m0(transform.position, ray.origin) * Mathf.Clamp(Vector3.Distance(transform.position, ray.origin), 0f, (float)DCS4Jf0LRzsehKFc5QOLL06qw.distanceToHit), RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore));
					bool flag9 = Vector3.Distance(transform.position, (info.point != Vector3.zero) ? info.point : ray.origin) <= (float)DCS4Jf0LRzsehKFc5QOLL06qw.distanceToHit;
					bool flag10 = flag8;
					if (flag10)
					{
						Ddagemt6Wc3UeyV4EYXNrXcFf.DSX7avr6KhIFJ0akNPOH6PCth(transform.gameObject, ebi.DxXccHaM347WXA3xnOnqbjen9, transform.position + DmErKmxWRjHNSG8p8mCUQIUbM.DWTJZMUdPCnE0MBXkaJ5OA6m0(transform.position, ray.origin) * Mathf.Clamp(Vector3.Distance(transform.position, ray.origin), 0f, (float)DCS4Jf0LRzsehKFc5QOLL06qw.distanceToHit), ref info);
						flag3 = true;
					}
					else
					{
						bool flag11 = flag9;
						if (flag11)
						{
							Ddagemt6Wc3UeyV4EYXNrXcFf.DSX7avr6KhIFJ0akNPOH6PCth(transform.gameObject, ebi.DxXccHaM347WXA3xnOnqbjen9, (info.point != Vector3.zero) ? info.point : ray.origin, ref info);
							flag3 = true;
						}
						else
						{
							flag3 = false;
						}
					}
					break;
				}
				case DokdtlMHqRTX0KbeCtveFDTNT.Sphere:
				{
					Vector3 vector = Vector3.zero;
					bool flag12 = ebi.DhGh12svrQ8q4fj9Ha3JKwjPU != Vector3.zero && Vector3.Distance(ray.origin, transform.position + ebi.DhGh12svrQ8q4fj9Ha3JKwjPU) < range && !Physics.Linecast(ray.origin, transform.position + ebi.DhGh12svrQ8q4fj9Ha3JKwjPU, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
					bool flag13 = flag12;
					bool flag14;
					if (flag13)
					{
						vector = transform.position + ebi.DhGh12svrQ8q4fj9Ha3JKwjPU;
						flag14 = true;
					}
					else
					{
						Vector3 vector2;
						bool flag15 = transform.position.D7jI6EoRIlVgppmv8T7nYuaAV(ray.origin, out vector2, true) && Vector3.Distance(ray.origin, vector2) < range;
						bool flag16 = flag15;
						if (flag16)
						{
							ebi.DhGh12svrQ8q4fj9Ha3JKwjPU = vector2 - transform.position;
							vector = vector2;
							flag14 = true;
						}
						else
						{
							vector = transform.position;
							flag14 = Vector3.Distance(ray.origin, vector) < range;
						}
					}
					bool flag17 = flag14;
					if (flag17)
					{
						Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC = vector;
						info = (DCS4Jf0LRzsehKFc5QOLL06qw.straightRaycasting ? DamageTool.raycast(new Ray(ray.origin, ray.direction), range, mask, ignorePlayer) : DamageTool.raycast(new Ray(ray.origin, DmErKmxWRjHNSG8p8mCUQIUbM.DWTJZMUdPCnE0MBXkaJ5OA6m0(ray.origin, vector)), range, mask, ignorePlayer));
						bool flag18 = Vector3.Distance(ray.origin, vector) < range;
						if (flag18)
						{
							Ddagemt6Wc3UeyV4EYXNrXcFf.DSX7avr6KhIFJ0akNPOH6PCth(transform.gameObject, ebi.DxXccHaM347WXA3xnOnqbjen9, vector, ref info);
							flag3 = true;
						}
						else
						{
							flag3 = false;
						}
					}
					else
					{
						flag3 = false;
					}
					break;
				}
				default:
					flag3 = false;
					break;
				}
			}
		}
		return flag3;
	}

	// Token: 0x06000134 RID: 308 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
	public static Vector3 GetBezierPoint(float t, List<Vector3> points)
	{
		List<Vector3> list = new List<Vector3>(points);
		while (list.Count > 1)
		{
			List<Vector3> list2 = new List<Vector3>();
			for (int i = 0; i < list.Count - 1; i++)
			{
				list2.Add(Vector3.Lerp(list[i], list[i + 1], t));
			}
			list = list2;
		}
		return list[0];
	}

	// Token: 0x04000189 RID: 393
	public static Du4XicP1hVrJzXjQ70aniDyvk DASEuOZmKRI1v3DQRcsmyTKsC = default(Du4XicP1hVrJzXjQ70aniDyvk);

	// Token: 0x0400018A RID: 394
	private static int DKKoACMwRNz4vCJpfORisgZxz = 100;

	// Token: 0x0400018B RID: 395
	private static int DnvvBcIJCBXZ09Y0YLrV4wvvP = 0;

	// Token: 0x0400018C RID: 396
	private static DGZv08vQyz81zrHxUqhmYuCdY<float> Dd0KuLwyvc6fwwJM1JPteX0mL = new DGZv08vQyz81zrHxUqhmYuCdY<float>(typeof(PlayerLook), "_pitch", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400018D RID: 397
	private static DGZv08vQyz81zrHxUqhmYuCdY<float> DCmzMVXAqJ2O6KXsQiAL8WlyE = new DGZv08vQyz81zrHxUqhmYuCdY<float>(typeof(PlayerLook), "_yaw", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400018E RID: 398
	public static Dictionary<ulong, List<DRxteGz0evnNDVy6poswGHA5b>> D6CSCOdxWhfs06Bz8veydqeB0 = new Dictionary<ulong, List<DRxteGz0evnNDVy6poswGHA5b>>();
}
