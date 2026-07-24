using System;
using System.Reflection;
using SDG.NetPak;
using SDG.NetTransport;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000060 RID: 96
public class DGTc3PdFVRhF1bLD0n9uRGjso : PlayerInput
{
	// Token: 0x060001C5 RID: 453 RVA: 0x00017524 File Offset: 0x00015724
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerInput), "InitializePlayer", new Type[] { })]
	private static void DF8KsZy0COc39Z2s4SEAX4nsD(PlayerInput instance)
	{
		bool isLocalPlayer = instance.channel.IsLocalPlayer;
		if (isLocalPlayer)
		{
			DGTc3PdFVRhF1bLD0n9uRGjso.DA4bRmjnj7S25EfhqDLF9GEuA = 0U;
			DGTc3PdFVRhF1bLD0n9uRGjso.D7TjATzx0yO0pr8fFkqXnOnXV = 0U;
			DGTc3PdFVRhF1bLD0n9uRGjso.DvrQlyuESbujKjrXpWqcxTQjA = 0U;
		}
		DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(instance, Array.Empty<object>());
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00017564 File Offset: 0x00015764
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerInput), "FixedUpdate", BindingFlags.Instance | BindingFlags.NonPublic, new Type[] { })]
	public void D195HSKZ9jQ7v7MjMwUuVt0D2()
	{
		bool flag = !D5l46jlssr4TRAzUSXzLj0uqu.freeCamera && !D5l46jlssr4TRAzUSXzLj0uqu.modifyMoveBehaviour && !D5l46jlssr4TRAzUSXzLj0uqu.rawWalk;
		if (flag)
		{
			bool isLocalPlayer = base.channel.IsLocalPlayer;
			if (isLocalPlayer)
			{
				DGTc3PdFVRhF1bLD0n9uRGjso.D0NSkiD0QOaRjOey970qXo0Th.Get(Player.player.animator).transform.localEulerAngles = new Vector3(90f, 0f, 0f);
			}
			DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, Array.Empty<object>());
		}
		else
		{
			bool flag2 = Provider.isServer && D5l46jlssr4TRAzUSXzLj0uqu.freeCamera;
			if (flag2)
			{
				bool isAlive = base.player.life.IsAlive;
				if (isAlive)
				{
					EAttackInputFlags eattackInputFlags = DGTc3PdFVRhF1bLD0n9uRGjso.D5KkRTrfMFWv7d4ROPSuyXut0.Get(this);
					EAttackInputFlags eattackInputFlags2 = DGTc3PdFVRhF1bLD0n9uRGjso.D3EpnUUCXzS0NmCFecLFXZKiZ.Get(this);
					this.D4YCMxO0jPhLHiysdw5RVKn2Z(out eattackInputFlags, out eattackInputFlags2);
					DGTc3PdFVRhF1bLD0n9uRGjso.D5KkRTrfMFWv7d4ROPSuyXut0.Set(this, eattackInputFlags);
					DGTc3PdFVRhF1bLD0n9uRGjso.D3EpnUUCXzS0NmCFecLFXZKiZ.Set(this, eattackInputFlags2);
					base.player.equipment.simulate(base.simulation, DGTc3PdFVRhF1bLD0n9uRGjso.D5KkRTrfMFWv7d4ROPSuyXut0.Get(this), DGTc3PdFVRhF1bLD0n9uRGjso.D3EpnUUCXzS0NmCFecLFXZKiZ.Get(this), base.keys[9]);
					DGTc3PdFVRhF1bLD0n9uRGjso.DR0jsZ9n4vCMHMJBPxd3Caepe.Set(this, base.simulation + 1U);
				}
			}
			else
			{
				bool flag3 = Provider.isServer || !base.channel.IsLocalPlayer;
				if (flag3)
				{
					DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, Array.Empty<object>());
				}
				else
				{
					DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.instance = this;
					bool flag4 = DGTc3PdFVRhF1bLD0n9uRGjso.D7TjATzx0yO0pr8fFkqXnOnXV % PlayerInput.SAMPLES == 0U;
					if (flag4)
					{
						bool flag5 = !D5l46jlssr4TRAzUSXzLj0uqu.rawWalk;
						if (flag5)
						{
							DGTc3PdFVRhF1bLD0n9uRGjso.DaGLdBiP6lr0Sfn2llm6voFiy.Set(this, Time.realtimeSinceStartup);
						}
						bool flag6 = DGTc3PdFVRhF1bLD0n9uRGjso.DU0o7Ae5W5nUUXc2RCOH35HIT.Get(this);
						if (flag6)
						{
							DGTc3PdFVRhF1bLD0n9uRGjso.DU0o7Ae5W5nUUXc2RCOH35HIT.Set(this, false);
							DGTc3PdFVRhF1bLD0n9uRGjso.D00jXR83V8CaBrVZ4t9NdcmHb.DGHrF0Ht2QRxL0NBgNHj6ZpZX(this, Array.Empty<object>());
						}
						base.keys[0] = base.player.movement.jump;
						base.keys[1] = false;
						base.keys[2] = false;
						base.keys[3] = base.player.stance.crouch;
						base.keys[4] = base.player.stance.prone;
						base.keys[5] = base.player.stance.sprint;
						base.keys[6] = !D5l46jlssr4TRAzUSXzLj0uqu.localLeans && base.player.animator.leanLeft;
						base.keys[7] = !D5l46jlssr4TRAzUSXzLj0uqu.localLeans && base.player.animator.leanRight;
						base.keys[8] = false;
						base.keys[9] = DGTc3PdFVRhF1bLD0n9uRGjso.DUzMDwjsmFKs0e29QN51kf3bL.Get(base.player.stance);
						bool freeCamera = D5l46jlssr4TRAzUSXzLj0uqu.freeCamera;
						if (freeCamera)
						{
							base.keys[0] = false;
							base.keys[2] = false;
							base.keys[6] = false;
							base.keys[7] = false;
						}
						bool flag7 = MenuConfigurationControlsUI.binding == byte.MaxValue;
						for (int i = 0; i < (int)ControlsSettings.NUM_PLUGIN_KEYS; i++)
						{
							int num = base.keys.Length - (int)ControlsSettings.NUM_PLUGIN_KEYS + i;
							base.keys[num] = flag7 && InputEx.GetKey(ControlsSettings.getPluginKeyCode(i));
						}
						EAttackInputFlags eattackInputFlags3 = DGTc3PdFVRhF1bLD0n9uRGjso.D5KkRTrfMFWv7d4ROPSuyXut0.Get(this);
						EAttackInputFlags eattackInputFlags4 = DGTc3PdFVRhF1bLD0n9uRGjso.D3EpnUUCXzS0NmCFecLFXZKiZ.Get(this);
						this.D4YCMxO0jPhLHiysdw5RVKn2Z(out eattackInputFlags3, out eattackInputFlags4);
						bool flag8 = D5l46jlssr4TRAzUSXzLj0uqu.automaticSemiBurst && !DL3tNdrQzY7o8FV1oIOKODOLQ.DtKlbZSZSYlN9ldxLbDo4VuvI && base.player.equipment.useable is UseableGun && InputEx.GetKey(ControlsSettings.primary) && DGTc3PdFVRhF1bLD0n9uRGjso.D3pBDSmRQrcmcpesC5j4OU0Np.Get(base.player.equipment.useable) != EFiremode.AUTO;
						if (flag8)
						{
							switch (DGTc3PdFVRhF1bLD0n9uRGjso.D5KkRTrfMFWv7d4ROPSuyXut0.Get(this))
							{
							case EAttackInputFlags.None:
								eattackInputFlags3 = EAttackInputFlags.Start;
								break;
							case EAttackInputFlags.Start:
								eattackInputFlags3 = EAttackInputFlags.Stop;
								break;
							case EAttackInputFlags.Stop:
								eattackInputFlags3 = EAttackInputFlags.Start;
								break;
							}
						}
						DGTc3PdFVRhF1bLD0n9uRGjso.D5KkRTrfMFWv7d4ROPSuyXut0.Set(this, eattackInputFlags3);
						DGTc3PdFVRhF1bLD0n9uRGjso.D3EpnUUCXzS0NmCFecLFXZKiZ.Set(this, eattackInputFlags4);
						base.player.life.simulate(base.simulation);
						bool crouch = base.player.stance.crouch;
						bool prone = base.player.stance.prone;
						bool sprint = base.player.stance.sprint;
						bool flag9 = !D5l46jlssr4TRAzUSXzLj0uqu.freeCamera;
						if (flag9)
						{
							base.player.stance.simulate(base.simulation, crouch, prone, sprint);
						}
						int num2 = (int)(base.player.movement.horizontal - 1);
						int num3 = (int)(base.player.movement.vertical - 1);
						bool flag10 = base.player.movement.jump;
						bool freeCamera2 = D5l46jlssr4TRAzUSXzLj0uqu.freeCamera;
						if (freeCamera2)
						{
							num2 = 0;
							num3 = 0;
							flag10 = false;
						}
						base.player.movement.simulate(base.simulation, 0, num2, num3, base.player.look.look_x, base.player.look.look_y, flag10, sprint, PlayerInput.RATE);
						bool flag11 = base.player.stance.stance == EPlayerStance.DRIVING;
						if (flag11)
						{
							DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.value = new DrivingPlayerInputPacket(base.player.movement.getVehicle());
						}
						else
						{
							bool freeCamera3 = D5l46jlssr4TRAzUSXzLj0uqu.freeCamera;
							if (freeCamera3)
							{
								DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.value = new WalkingPlayerInputPacket
								{
									analog = 17,
									clientPosition = base.transform.position,
									pitch = base.player.look.pitch,
									yaw = base.player.look.yaw
								};
							}
							else
							{
								bool modifyMoveBehaviour = D5l46jlssr4TRAzUSXzLj0uqu.modifyMoveBehaviour;
								if (modifyMoveBehaviour)
								{
									float num4;
									int num5;
									byte b;
									byte b2;
									this.D6EHPAmxSgUZ0C4qpFFrvwEhu(out num4, out num5, out b, out b2);
									DGTc3PdFVRhF1bLD0n9uRGjso.D0NSkiD0QOaRjOey970qXo0Th.Get(Player.player.animator).transform.localEulerAngles = ((DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6 || !D5l46jlssr4TRAzUSXzLj0uqu.showMoveModifying) ? new Vector3(90f, 0f, 0f) : new Vector3(90f, num4 - base.player.look.yaw, 0f));
									DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.value = new WalkingPlayerInputPacket
									{
										analog = (byte)(((int)b << 4) | (int)b2),
										clientPosition = base.transform.position,
										pitch = (float)num5,
										yaw = num4
									};
								}
								else
								{
									DGTc3PdFVRhF1bLD0n9uRGjso.D0NSkiD0QOaRjOey970qXo0Th.Get(Player.player.animator).transform.localEulerAngles = new Vector3(90f, 0f, 0f);
									DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.value = new WalkingPlayerInputPacket
									{
										analog = (byte)(((int)base.player.movement.horizontal << 4) | (int)base.player.movement.vertical),
										clientPosition = base.transform.position,
										pitch = base.player.look.pitch,
										yaw = base.player.look.yaw
									};
								}
							}
							object obj = Activator.CreateInstance(DGTc3PdFVRhF1bLD0n9uRGjso.DnJHkwCnwvonKC8ZLCS9X0ZMV);
							DGTc3PdFVRhF1bLD0n9uRGjso.DM0gOZvX9hmUbRBjhldoaOsSO.Set(obj, base.simulation);
							DGTc3PdFVRhF1bLD0n9uRGjso.DYnVmctzjAM5x4amTr0rFjTrt.Set(obj, crouch);
							DGTc3PdFVRhF1bLD0n9uRGjso.DTFlx4cOum1ES4iF5NH6kBrUp.Set(obj, prone);
							DGTc3PdFVRhF1bLD0n9uRGjso.DvQEDesyd5kGUca2XVpOLPgjp.Set(obj, num2);
							DGTc3PdFVRhF1bLD0n9uRGjso.DdwMGDmolSpL2vNDUsF5co4Ib.Set(obj, num3);
							DGTc3PdFVRhF1bLD0n9uRGjso.DMInSuEVSh73RWw9wo0QqmJVI.Set(obj, flag10);
							DGTc3PdFVRhF1bLD0n9uRGjso.D3AmZBBRdnn5M1NDuEKRTD0XK.Set(obj, sprint);
							DGTc3PdFVRhF1bLD0n9uRGjso.Don290xyaDFJZlJZBR6JLCvEr.Set(obj, base.transform.rotation);
							DGTc3PdFVRhF1bLD0n9uRGjso.DXv3MzDWIK3dPWNqTuUZYK8LP.Set(obj, base.player.look.aim.rotation);
							DGTc3PdFVRhF1bLD0n9uRGjso.DTTGlDyvwu9C5zjbkzGJAfbRu.DGHrF0Ht2QRxL0NBgNHj6ZpZX(DGTc3PdFVRhF1bLD0n9uRGjso.DIHOGQ0HDEqv9pnJ1py0tIZ7P.DvBB927EW3YHmvzUSmk5x5kfr(this), new object[] { obj });
						}
						DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.value.clientSimulationFrameNumber = base.simulation;
						DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.value.recov = this.recov;
						base.player.equipment.simulate(base.simulation, DGTc3PdFVRhF1bLD0n9uRGjso.D5KkRTrfMFWv7d4ROPSuyXut0.Get(this), DGTc3PdFVRhF1bLD0n9uRGjso.D3EpnUUCXzS0NmCFecLFXZKiZ.Get(this), DGTc3PdFVRhF1bLD0n9uRGjso.DUzMDwjsmFKs0e29QN51kf3bL.Get(base.player.stance));
						bool freeCamera4 = D5l46jlssr4TRAzUSXzLj0uqu.freeCamera;
						if (freeCamera4)
						{
							base.player.animator.simulate(base.simulation, false, false);
						}
						else
						{
							base.player.animator.simulate(base.simulation, base.player.animator.leanLeft, base.player.animator.leanRight);
						}
						DGTc3PdFVRhF1bLD0n9uRGjso.DA4bRmjnj7S25EfhqDLF9GEuA += PlayerInput.SAMPLES;
						DGTc3PdFVRhF1bLD0n9uRGjso.DR0jsZ9n4vCMHMJBPxd3Caepe.Set(this, base.simulation + 1U);
					}
					bool flag12 = DGTc3PdFVRhF1bLD0n9uRGjso.DvrQlyuESbujKjrXpWqcxTQjA < DGTc3PdFVRhF1bLD0n9uRGjso.DA4bRmjnj7S25EfhqDLF9GEuA;
					if (flag12)
					{
						DGTc3PdFVRhF1bLD0n9uRGjso.DvrQlyuESbujKjrXpWqcxTQjA += 1U;
						base.player.equipment.tock(base.clock);
						DGTc3PdFVRhF1bLD0n9uRGjso.DHOyqApEyfa4j3vR4y6ErAxhk.Set(this, DGTc3PdFVRhF1bLD0n9uRGjso.DHOyqApEyfa4j3vR4y6ErAxhk.Get(this) + 1U);
					}
					bool flag13 = DGTc3PdFVRhF1bLD0n9uRGjso.DvrQlyuESbujKjrXpWqcxTQjA == DGTc3PdFVRhF1bLD0n9uRGjso.DA4bRmjnj7S25EfhqDLF9GEuA && DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.Get(this) != null && !Provider.isServer;
					if (flag13)
					{
						ushort num6 = 0;
						byte b3 = 0;
						DGTc3PdFVRhF1bLD0n9uRGjso.DkEAhLFWAz60aCfcC8TUiewS0.instance = this;
						DGTc3PdFVRhF1bLD0n9uRGjso.DkEAhLFWAz60aCfcC8TUiewS0.RefereshFieldValue();
						while ((int)b3 < base.keys.Length)
						{
							bool flag14 = base.keys[(int)b3];
							if (flag14)
							{
								num6 |= DGTc3PdFVRhF1bLD0n9uRGjso.DkEAhLFWAz60aCfcC8TUiewS0.fldValue[(int)b3];
							}
							b3 += 1;
						}
						DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.value.keys = num6;
						DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.value.primaryAttack = DGTc3PdFVRhF1bLD0n9uRGjso.D5KkRTrfMFWv7d4ROPSuyXut0.Get(this);
						DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.value.secondaryAttack = DGTc3PdFVRhF1bLD0n9uRGjso.D3EpnUUCXzS0NmCFecLFXZKiZ.Get(this);
						bool flag15 = DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.value is DrivingPlayerInputPacket;
						if (flag15)
						{
							DrivingPlayerInputPacket drivingPlayerInputPacket = DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.value as DrivingPlayerInputPacket;
							InteractableVehicle vehicle = base.player.movement.getVehicle();
							bool flag16 = vehicle != null;
							if (flag16)
							{
								Transform transform = vehicle.transform;
								bool flag17 = vehicle.asset.engine == EEngine.TRAIN;
								if (flag17)
								{
									drivingPlayerInputPacket.position = DGTc3PdFVRhF1bLD0n9uRGjso.DQraX8y5rgp0mOhRum993TDkX(vehicle.roadPosition);
								}
								else
								{
									drivingPlayerInputPacket.position = transform.position;
								}
								drivingPlayerInputPacket.rotation = transform.rotation;
								drivingPlayerInputPacket.speed = vehicle.ReplicatedSpeed;
								drivingPlayerInputPacket.forwardVelocity = vehicle.ReplicatedForwardVelocity;
								drivingPlayerInputPacket.steeringInput = vehicle.ReplicatedSteeringInput;
								drivingPlayerInputPacket.velocityInput = vehicle.ReplicatedVelocityInput;
							}
						}
						bool isConnected = Provider.isConnected;
						if (isConnected)
						{
							DGTc3PdFVRhF1bLD0n9uRGjso.SendInputs.Invoke(base.GetNetId(), ENetReliability.Reliable, delegate(NetPakWriter writer)
							{
								bool flag18 = DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.value is DrivingPlayerInputPacket;
								if (flag18)
								{
									writer.WriteBit(true);
								}
								else
								{
									writer.WriteBit(false);
								}
								DGTc3PdFVRhF1bLD0n9uRGjso.D8BBPn8KkqdzUAjuuKjCwXO6c.value.write(writer);
							});
						}
					}
					DGTc3PdFVRhF1bLD0n9uRGjso.D7TjATzx0yO0pr8fFkqXnOnXV += 1U;
				}
			}
		}
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00018120 File Offset: 0x00016320
	public void D6EHPAmxSgUZ0C4qpFFrvwEhu(out float yaw, out int pitch, out byte horizontal, out byte vertical)
	{
		switch (D5l46jlssr4TRAzUSXzLj0uqu.moveType)
		{
		case DjTmlwWXHjmuTJsdebq9LFq0y.WalkLeft:
			yaw = base.player.look.yaw - 90f;
			pitch = (int)base.player.look.pitch;
			horizontal = base.player.movement.vertical;
			vertical = DGTc3PdFVRhF1bLD0n9uRGjso.D9Y6E0XnRL7k1UUKiImVtgjZO(base.player.movement.horizontal);
			break;
		case DjTmlwWXHjmuTJsdebq9LFq0y.WalkRight:
			yaw = base.player.look.yaw - 270f;
			pitch = (int)base.player.look.pitch;
			horizontal = DGTc3PdFVRhF1bLD0n9uRGjso.D9Y6E0XnRL7k1UUKiImVtgjZO(base.player.movement.vertical);
			vertical = base.player.movement.horizontal;
			break;
		case DjTmlwWXHjmuTJsdebq9LFq0y.WalkBack:
			yaw = base.player.look.yaw - 180f;
			pitch = (int)base.player.look.pitch;
			horizontal = DGTc3PdFVRhF1bLD0n9uRGjso.D9Y6E0XnRL7k1UUKiImVtgjZO(base.player.movement.horizontal);
			vertical = DGTc3PdFVRhF1bLD0n9uRGjso.D9Y6E0XnRL7k1UUKiImVtgjZO(base.player.movement.vertical);
			break;
		case DjTmlwWXHjmuTJsdebq9LFq0y.TwoTactSpin:
		{
			yaw = ((DGTc3PdFVRhF1bLD0n9uRGjso.DEWPUnvCzGazF9tfiTq5hFG1v == 0) ? base.player.look.yaw : (base.player.look.yaw - 180f));
			pitch = ((DGTc3PdFVRhF1bLD0n9uRGjso.DEWPUnvCzGazF9tfiTq5hFG1v == 0) ? global::UnityEngine.Random.Range(0, 90) : global::UnityEngine.Random.Range(90, 180));
			horizontal = ((DGTc3PdFVRhF1bLD0n9uRGjso.DEWPUnvCzGazF9tfiTq5hFG1v == 0) ? base.player.movement.horizontal : DGTc3PdFVRhF1bLD0n9uRGjso.D9Y6E0XnRL7k1UUKiImVtgjZO(base.player.movement.horizontal));
			vertical = ((DGTc3PdFVRhF1bLD0n9uRGjso.DEWPUnvCzGazF9tfiTq5hFG1v == 0) ? base.player.movement.vertical : DGTc3PdFVRhF1bLD0n9uRGjso.D9Y6E0XnRL7k1UUKiImVtgjZO(base.player.movement.vertical));
			DGTc3PdFVRhF1bLD0n9uRGjso.DEWPUnvCzGazF9tfiTq5hFG1v += 1;
			bool flag = DGTc3PdFVRhF1bLD0n9uRGjso.DEWPUnvCzGazF9tfiTq5hFG1v >= 2;
			if (flag)
			{
				DGTc3PdFVRhF1bLD0n9uRGjso.DEWPUnvCzGazF9tfiTq5hFG1v = 0;
			}
			break;
		}
		case DjTmlwWXHjmuTJsdebq9LFq0y.FourTactSpin:
		{
			DGTc3PdFVRhF1bLD0n9uRGjso.DEWPUnvCzGazF9tfiTq5hFG1v += 1;
			bool flag2 = DGTc3PdFVRhF1bLD0n9uRGjso.DEWPUnvCzGazF9tfiTq5hFG1v == 5 || DGTc3PdFVRhF1bLD0n9uRGjso.DEWPUnvCzGazF9tfiTq5hFG1v == 0;
			if (flag2)
			{
				DGTc3PdFVRhF1bLD0n9uRGjso.DEWPUnvCzGazF9tfiTq5hFG1v = 1;
			}
			switch (DGTc3PdFVRhF1bLD0n9uRGjso.DEWPUnvCzGazF9tfiTq5hFG1v)
			{
			case 1:
				yaw = base.player.look.yaw;
				pitch = 0;
				horizontal = base.player.movement.horizontal;
				vertical = base.player.movement.vertical;
				break;
			case 2:
				yaw = base.player.look.yaw - 90f;
				pitch = 0;
				horizontal = base.player.movement.vertical;
				vertical = DGTc3PdFVRhF1bLD0n9uRGjso.D9Y6E0XnRL7k1UUKiImVtgjZO(base.player.movement.horizontal);
				break;
			case 3:
				yaw = base.player.look.yaw - 180f;
				pitch = 180;
				horizontal = DGTc3PdFVRhF1bLD0n9uRGjso.D9Y6E0XnRL7k1UUKiImVtgjZO(base.player.movement.horizontal);
				vertical = DGTc3PdFVRhF1bLD0n9uRGjso.D9Y6E0XnRL7k1UUKiImVtgjZO(base.player.movement.vertical);
				break;
			default:
				yaw = base.player.look.yaw - 270f;
				pitch = 180;
				horizontal = DGTc3PdFVRhF1bLD0n9uRGjso.D9Y6E0XnRL7k1UUKiImVtgjZO(base.player.movement.vertical);
				vertical = base.player.movement.horizontal;
				break;
			}
			break;
		}
		default:
			pitch = (int)base.player.look.pitch;
			yaw = base.player.look.yaw;
			horizontal = base.player.movement.vertical;
			vertical = base.player.movement.horizontal;
			break;
		}
		bool flag3;
		if (Player.player.stance.stance != EPlayerStance.SWIM)
		{
			EPlayerStance stance = Player.player.stance.stance;
			flag3 = false;
		}
		else
		{
			flag3 = true;
		}
		bool flag4 = flag3;
		if (flag4)
		{
			pitch = (int)base.player.look.pitch;
		}
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00018548 File Offset: 0x00016748
	public static byte D9Y6E0XnRL7k1UUKiImVtgjZO(byte input)
	{
		bool flag = input == 2;
		byte b;
		if (flag)
		{
			b = 0;
		}
		else
		{
			bool flag2 = input == 0;
			if (flag2)
			{
				b = 2;
			}
			else
			{
				b = 1;
			}
		}
		return b;
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x0001857C File Offset: 0x0001677C
	internal void D4YCMxO0jPhLHiysdw5RVKn2Z(out EAttackInputFlags primaryAttack, out EAttackInputFlags secondaryAttack)
	{
		primaryAttack = EAttackInputFlags.None;
		secondaryAttack = EAttackInputFlags.None;
		bool flag = DGTc3PdFVRhF1bLD0n9uRGjso.Dvk34vIoYxBOoNFKAU790wrBM.Get(Player.player.equipment) || DGTc3PdFVRhF1bLD0n9uRGjso.DofpoA6AgeGfOVra0I1mRThkM.Get(Player.player.equipment);
		if (flag)
		{
			primaryAttack |= EAttackInputFlags.Start;
		}
		bool flag2 = DGTc3PdFVRhF1bLD0n9uRGjso.DuM1Ij9NMx5HAMvQNxqhE3ABO.Get(Player.player.equipment);
		if (flag2)
		{
			primaryAttack |= EAttackInputFlags.Stop;
		}
		bool flag3 = DGTc3PdFVRhF1bLD0n9uRGjso.DwQojyKAARekzn6DumAcv5WQB.Get(Player.player.equipment) || DGTc3PdFVRhF1bLD0n9uRGjso.DXCL0uvxhGhep4yPK0gGlFv6Q.Get(Player.player.equipment);
		if (flag3)
		{
			secondaryAttack |= EAttackInputFlags.Start;
		}
		bool flag4 = DGTc3PdFVRhF1bLD0n9uRGjso.DGQxYifJ7q7g4pMNvOr3pnO6t.Get(Player.player.equipment);
		if (flag4)
		{
			secondaryAttack |= EAttackInputFlags.Stop;
		}
		DGTc3PdFVRhF1bLD0n9uRGjso.Dvk34vIoYxBOoNFKAU790wrBM.Set(Player.player.equipment, false);
		DGTc3PdFVRhF1bLD0n9uRGjso.DuM1Ij9NMx5HAMvQNxqhE3ABO.Set(Player.player.equipment, false);
		DGTc3PdFVRhF1bLD0n9uRGjso.DwQojyKAARekzn6DumAcv5WQB.Set(Player.player.equipment, false);
		DGTc3PdFVRhF1bLD0n9uRGjso.DGQxYifJ7q7g4pMNvOr3pnO6t.Set(Player.player.equipment, false);
	}

	// Token: 0x060001CA RID: 458 RVA: 0x000186B0 File Offset: 0x000168B0
	internal static Vector3 DQraX8y5rgp0mOhRum993TDkX(float roadPosition)
	{
		bool flag = roadPosition >= 16384f;
		Vector3 vector;
		if (flag)
		{
			vector = new Vector3(4096f, 4096f, roadPosition - 20480f);
		}
		else
		{
			bool flag2 = roadPosition >= 8192f;
			if (flag2)
			{
				vector = new Vector3(4096f, roadPosition - 12288f, -4096f);
			}
			else
			{
				vector = new Vector3(roadPosition - 4096f, -4096f, -4096f);
			}
		}
		return vector;
	}

	// Token: 0x0400023D RID: 573
	private static readonly ServerInstanceMethod SendInputs = ServerInstanceMethod.Get(typeof(PlayerInput), "ReceiveInputs");

	// Token: 0x0400023E RID: 574
	private static Type DnJHkwCnwvonKC8ZLCS9X0ZMV = D08iy2XFQpUQteL0XRzAbg2IE.D690dQkfd9Ye1iupKYZFiSJkW("ClientMovementInput");

	// Token: 0x0400023F RID: 575
	private static DGZv08vQyz81zrHxUqhmYuCdY<uint> DM0gOZvX9hmUbRBjhldoaOsSO = new DGZv08vQyz81zrHxUqhmYuCdY<uint>(DGTc3PdFVRhF1bLD0n9uRGjso.DnJHkwCnwvonKC8ZLCS9X0ZMV, "frameNumber", BindingFlags.Instance | BindingFlags.Public);

	// Token: 0x04000240 RID: 576
	private static DGZv08vQyz81zrHxUqhmYuCdY<bool> DYnVmctzjAM5x4amTr0rFjTrt = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(DGTc3PdFVRhF1bLD0n9uRGjso.DnJHkwCnwvonKC8ZLCS9X0ZMV, "crouch", BindingFlags.Instance | BindingFlags.Public);

	// Token: 0x04000241 RID: 577
	private static DGZv08vQyz81zrHxUqhmYuCdY<bool> DTFlx4cOum1ES4iF5NH6kBrUp = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(DGTc3PdFVRhF1bLD0n9uRGjso.DnJHkwCnwvonKC8ZLCS9X0ZMV, "prone", BindingFlags.Instance | BindingFlags.Public);

	// Token: 0x04000242 RID: 578
	private static DGZv08vQyz81zrHxUqhmYuCdY<int> DvQEDesyd5kGUca2XVpOLPgjp = new DGZv08vQyz81zrHxUqhmYuCdY<int>(DGTc3PdFVRhF1bLD0n9uRGjso.DnJHkwCnwvonKC8ZLCS9X0ZMV, "input_x", BindingFlags.Instance | BindingFlags.Public);

	// Token: 0x04000243 RID: 579
	private static DGZv08vQyz81zrHxUqhmYuCdY<int> DdwMGDmolSpL2vNDUsF5co4Ib = new DGZv08vQyz81zrHxUqhmYuCdY<int>(DGTc3PdFVRhF1bLD0n9uRGjso.DnJHkwCnwvonKC8ZLCS9X0ZMV, "input_y", BindingFlags.Instance | BindingFlags.Public);

	// Token: 0x04000244 RID: 580
	private static DGZv08vQyz81zrHxUqhmYuCdY<bool> DMInSuEVSh73RWw9wo0QqmJVI = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(DGTc3PdFVRhF1bLD0n9uRGjso.DnJHkwCnwvonKC8ZLCS9X0ZMV, "jump", BindingFlags.Instance | BindingFlags.Public);

	// Token: 0x04000245 RID: 581
	private static DGZv08vQyz81zrHxUqhmYuCdY<bool> D3AmZBBRdnn5M1NDuEKRTD0XK = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(DGTc3PdFVRhF1bLD0n9uRGjso.DnJHkwCnwvonKC8ZLCS9X0ZMV, "sprint", BindingFlags.Instance | BindingFlags.Public);

	// Token: 0x04000246 RID: 582
	private static DGZv08vQyz81zrHxUqhmYuCdY<Quaternion> Don290xyaDFJZlJZBR6JLCvEr = new DGZv08vQyz81zrHxUqhmYuCdY<Quaternion>(DGTc3PdFVRhF1bLD0n9uRGjso.DnJHkwCnwvonKC8ZLCS9X0ZMV, "rotation", BindingFlags.Instance | BindingFlags.Public);

	// Token: 0x04000247 RID: 583
	private static DGZv08vQyz81zrHxUqhmYuCdY<Quaternion> DXv3MzDWIK3dPWNqTuUZYK8LP = new DGZv08vQyz81zrHxUqhmYuCdY<Quaternion>(DGTc3PdFVRhF1bLD0n9uRGjso.DnJHkwCnwvonKC8ZLCS9X0ZMV, "aimRotation", BindingFlags.Instance | BindingFlags.Public);

	// Token: 0x04000248 RID: 584
	private static DGZv08vQyz81zrHxUqhmYuCdY<bool> Dvk34vIoYxBOoNFKAU790wrBM = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(PlayerEquipment), "localWasPrimaryPressedBetweenSimulationFrames", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000249 RID: 585
	private static DGZv08vQyz81zrHxUqhmYuCdY<bool> DofpoA6AgeGfOVra0I1mRThkM = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(PlayerEquipment), "localWasPrimaryHeldLastFrame", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400024A RID: 586
	private static DGZv08vQyz81zrHxUqhmYuCdY<bool> DuM1Ij9NMx5HAMvQNxqhE3ABO = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(PlayerEquipment), "localWasPrimaryReleasedBetweenSimulationFrames", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400024B RID: 587
	private static DGZv08vQyz81zrHxUqhmYuCdY<bool> DwQojyKAARekzn6DumAcv5WQB = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(PlayerEquipment), "localWasSecondaryPressedBetweenSimulationFrames", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400024C RID: 588
	private static DGZv08vQyz81zrHxUqhmYuCdY<bool> DXCL0uvxhGhep4yPK0gGlFv6Q = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(PlayerEquipment), "localWasSecondaryHeldLastFrame", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400024D RID: 589
	private static DGZv08vQyz81zrHxUqhmYuCdY<bool> DGQxYifJ7q7g4pMNvOr3pnO6t = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(PlayerEquipment), "localWasSecondaryReleasedBetweenSimulationFrames", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400024E RID: 590
	private static DGZv08vQyz81zrHxUqhmYuCdY<uint> DHOyqApEyfa4j3vR4y6ErAxhk = new DGZv08vQyz81zrHxUqhmYuCdY<uint>(typeof(PlayerInput), "_clock", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400024F RID: 591
	private static DGZv08vQyz81zrHxUqhmYuCdY<uint> DR0jsZ9n4vCMHMJBPxd3Caepe = new DGZv08vQyz81zrHxUqhmYuCdY<uint>(typeof(PlayerInput), "_simulation", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000250 RID: 592
	private static DGZv08vQyz81zrHxUqhmYuCdY<float> DaGLdBiP6lr0Sfn2llm6voFiy = new DGZv08vQyz81zrHxUqhmYuCdY<float>(typeof(PlayerInput), "_tick", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000251 RID: 593
	private static DGZv08vQyz81zrHxUqhmYuCdY<ushort[]> DkEAhLFWAz60aCfcC8TUiewS0 = new DGZv08vQyz81zrHxUqhmYuCdY<ushort[]>(typeof(PlayerInput), "flags", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000252 RID: 594
	private static DGZv08vQyz81zrHxUqhmYuCdY<bool> DucUKk81ksf4qjcwPKjcCx0j4 = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(PlayerInput), "isDismissed", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000253 RID: 595
	private static DGZv08vQyz81zrHxUqhmYuCdY<bool> DU0o7Ae5W5nUUXc2RCOH35HIT = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(PlayerInput), "clientHasPendingResimulation", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000254 RID: 596
	private static DGZv08vQyz81zrHxUqhmYuCdY<bool> DUzMDwjsmFKs0e29QN51kf3bL = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(PlayerStance), "localWantsToSteadyAim", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000255 RID: 597
	private static DGZv08vQyz81zrHxUqhmYuCdY<EFiremode> D3pBDSmRQrcmcpesC5j4OU0Np = new DGZv08vQyz81zrHxUqhmYuCdY<EFiremode>(typeof(UseableGun), "firemode", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000256 RID: 598
	private static DGZv08vQyz81zrHxUqhmYuCdY<CharacterAnimator> D0NSkiD0QOaRjOey970qXo0Th = new DGZv08vQyz81zrHxUqhmYuCdY<CharacterAnimator>(typeof(PlayerAnimator), "thirdAnimator", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000257 RID: 599
	private static DGZv08vQyz81zrHxUqhmYuCdY<PlayerInputPacket> D8BBPn8KkqdzUAjuuKjCwXO6c = new DGZv08vQyz81zrHxUqhmYuCdY<PlayerInputPacket>(typeof(PlayerInput), "clientPendingInput", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000258 RID: 600
	private static DGZv08vQyz81zrHxUqhmYuCdY<EAttackInputFlags> D5KkRTrfMFWv7d4ROPSuyXut0 = new DGZv08vQyz81zrHxUqhmYuCdY<EAttackInputFlags>(typeof(PlayerInput), "pendingPrimaryAttackInput", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000259 RID: 601
	private static DGZv08vQyz81zrHxUqhmYuCdY<EAttackInputFlags> D3EpnUUCXzS0NmCFecLFXZKiZ = new DGZv08vQyz81zrHxUqhmYuCdY<EAttackInputFlags>(typeof(PlayerInput), "pendingSecondaryAttackInput", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400025A RID: 602
	private static D0yGEmS3ymlCn0sF3jX0KkKE3 DIHOGQ0HDEqv9pnJ1py0tIZ7P = new D0yGEmS3ymlCn0sF3jX0KkKE3(typeof(PlayerInput), "clientInputHistory", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400025B RID: 603
	private static DQyA1nzDa0rZuYtgcLmIWOUf8 DTTGlDyvwu9C5zjbkzGJAfbRu = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(PlayerInput).GetField("clientInputHistory", BindingFlags.Instance | BindingFlags.NonPublic).FieldType, "Add", BindingFlags.Instance | BindingFlags.Public);

	// Token: 0x0400025C RID: 604
	private static DQyA1nzDa0rZuYtgcLmIWOUf8 D00jXR83V8CaBrVZ4t9NdcmHb = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(PlayerInput), "ClientResimulate", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400025D RID: 605
	private static uint DA4bRmjnj7S25EfhqDLF9GEuA = 0U;

	// Token: 0x0400025E RID: 606
	private static uint D7TjATzx0yO0pr8fFkqXnOnXV = 0U;

	// Token: 0x0400025F RID: 607
	private static uint DvrQlyuESbujKjrXpWqcxTQjA = 0U;

	// Token: 0x04000260 RID: 608
	public static int DweqBf7mXSUOdLvafnRTHQIu0 = 0;

	// Token: 0x04000261 RID: 609
	public static byte DEWPUnvCzGazF9tfiTq5hFG1v;
}
