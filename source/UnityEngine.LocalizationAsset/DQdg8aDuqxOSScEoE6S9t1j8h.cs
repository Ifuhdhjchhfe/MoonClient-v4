using System;
using System.Reflection;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

// Token: 0x020000A1 RID: 161
public class DQdg8aDuqxOSScEoE6S9t1j8h : PlayerEquipment
{
	// Token: 0x06000313 RID: 787 RVA: 0x0002DD60 File Offset: 0x0002BF60
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerEquipment), "punch", new Type[] { })]
	private void DuwkQCpVjKcI4gLfg1To6lnWW(EPlayerPunch mode)
	{
		CSteamID csteamID = default(CSteamID);
		bool isLocalPlayer = base.channel.IsLocalPlayer;
		bool flag = isLocalPlayer;
		if (flag)
		{
			bool enableAimbot = DCS4Jf0LRzsehKFc5QOLL06qw.enableAimbot;
			bool flag2 = enableAimbot;
			if (flag2)
			{
				try
				{
					Ddagemt6Wc3UeyV4EYXNrXcFf.DTBS9x0Wqj5VvkJcr5w7pj60m(true);
				}
				catch
				{
				}
			}
			DQdg8aDuqxOSScEoE6S9t1j8h.D32nCQ2xJC8NLYgGZnwMtIZHa.DGHrF0Ht2QRxL0NBgNHj6ZpZX(this, Array.Empty<object>());
			RaycastInfo raycastInfo = Ddagemt6Wc3UeyV4EYXNrXcFf.DirOiKWUP3gPFUY6wI0yja3CG(new Ray(base.player.look.aim.position, base.player.look.aim.forward), D5l46jlssr4TRAzUSXzLj0uqu.extendMeleeRange ? 6f : 1.75f, RayMasks.DAMAGE_CLIENT, base.player);
			bool replaceHitLimbToCustom = D5l46jlssr4TRAzUSXzLj0uqu.replaceHitLimbToCustom;
			bool flag3 = replaceHitLimbToCustom;
			if (flag3)
			{
				raycastInfo.limb = D5l46jlssr4TRAzUSXzLj0uqu.replacedHitLimb.DG8Vk5LC0j20si9xsv3no34VC();
			}
			bool flag4 = raycastInfo.player != null && DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_PLAYER_MULTIPLIER.damage > 1f && DamageTool.isPlayerAllowedToDamagePlayer(base.player, raycastInfo.player);
			bool flag5 = flag4;
			if (flag5)
			{
				PlayerUI.hitmark(raycastInfo.point, false, (raycastInfo.limb == ELimb.SKULL) ? EPlayerHit.CRITICAL : EPlayerHit.ENTITIY);
			}
			else
			{
				bool flag6 = (raycastInfo.zombie != null && DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_ZOMBIE_MULTIPLIER.damage > 1f) || (raycastInfo.animal != null && DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_ANIMAL_MULTIPLIER.damage > 1f);
				bool flag7 = flag6;
				if (flag7)
				{
					PlayerUI.hitmark(raycastInfo.point, false, (raycastInfo.limb == ELimb.SKULL) ? EPlayerHit.CRITICAL : EPlayerHit.ENTITIY);
				}
				else
				{
					bool flag8 = raycastInfo.transform != null && raycastInfo.transform.CompareTag("Barricade") && DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_BARRICADE > 1f;
					bool flag9 = flag8;
					if (flag9)
					{
						BarricadeDrop barricadeDrop = DQdg8aDuqxOSScEoE6S9t1j8h.DXR6f53WbjK0IF3cyafL3uu0T.Invoke(new object[] { raycastInfo.transform });
						bool flag10 = barricadeDrop != null;
						bool flag11 = flag10;
						if (flag11)
						{
							ItemBarricadeAsset asset = barricadeDrop.asset;
							bool flag12 = asset != null && asset.canBeDamaged && asset.isVulnerable;
							bool flag13 = flag12;
							if (flag13)
							{
								PlayerUI.hitmark(raycastInfo.point, false, EPlayerHit.BUILD);
							}
						}
					}
					else
					{
						bool flag14 = raycastInfo.transform != null && raycastInfo.transform.CompareTag("Structure") && DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_STRUCTURE > 1f;
						bool flag15 = flag14;
						if (flag15)
						{
							StructureDrop structureDrop = DQdg8aDuqxOSScEoE6S9t1j8h.Dik5UBIAGX9JGQ0eTNUQ68sGT.Invoke(new object[] { raycastInfo.transform });
							bool flag16 = structureDrop != null;
							bool flag17 = flag16;
							if (flag17)
							{
								ItemStructureAsset asset2 = structureDrop.asset;
								bool flag18 = asset2 != null && asset2.canBeDamaged && asset2.isVulnerable;
								bool flag19 = flag18;
								if (flag19)
								{
									PlayerUI.hitmark(raycastInfo.point, false, EPlayerHit.BUILD);
								}
							}
						}
						else
						{
							bool flag20 = raycastInfo.vehicle != null && !raycastInfo.vehicle.isDead && DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_VEHICLE > 1f;
							bool flag21 = flag20;
							if (flag21)
							{
								bool flag22 = raycastInfo.vehicle.asset != null && raycastInfo.vehicle.canBeDamaged && raycastInfo.vehicle.asset.isVulnerable;
								bool flag23 = flag22;
								if (flag23)
								{
									PlayerUI.hitmark(raycastInfo.point, false, EPlayerHit.BUILD);
								}
							}
							else
							{
								bool flag24 = raycastInfo.transform != null && raycastInfo.transform.CompareTag("Resource") && DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_RESOURCE > 1f;
								bool flag25 = flag24;
								if (flag25)
								{
									byte b = 0;
									byte b2 = 0;
									ushort num = 0;
									bool flag26 = ResourceManager.tryGetRegion(raycastInfo.transform, out b, out b2, out num);
									bool flag27 = flag26;
									if (flag27)
									{
										ResourceSpawnpoint resourceSpawnpoint = ResourceManager.getResourceSpawnpoint(b, b2, num);
										bool flag28 = resourceSpawnpoint != null && !resourceSpawnpoint.isDead && resourceSpawnpoint.asset.vulnerableToFists;
										bool flag29 = flag28;
										if (flag29)
										{
											PlayerUI.hitmark(raycastInfo.point, false, EPlayerHit.BUILD);
										}
									}
								}
								else
								{
									bool flag30 = raycastInfo.transform != null && DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_OBJECT > 1f;
									bool flag31 = flag30;
									if (flag31)
									{
										InteractableObjectRubble componentInParent = raycastInfo.transform.GetComponentInParent<InteractableObjectRubble>();
										bool flag32 = componentInParent != null;
										bool flag33 = flag32;
										if (flag33)
										{
											raycastInfo.transform = componentInParent.transform;
											raycastInfo.section = componentInParent.getSection(raycastInfo.collider.transform);
											bool flag34 = componentInParent.IsSectionIndexValid(raycastInfo.section) && !componentInParent.isSectionDead(raycastInfo.section) && componentInParent.asset.rubbleBladeID == 0 && componentInParent.asset.rubbleIsVulnerable;
											bool flag35 = flag34;
											if (flag35)
											{
												PlayerUI.hitmark(raycastInfo.point, false, EPlayerHit.BUILD);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			bool flag36 = raycastInfo.player != null;
			bool flag37 = flag36;
			if (flag37)
			{
				ushort num2 = (ushort)(DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_PLAYER_MULTIPLIER.damage * DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_PLAYER_MULTIPLIER.skull * DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(raycastInfo.limb, raycastInfo.player));
				DmPNupos8Sd6cXJNxXG0GuRXC.DbGurvE8qaYmJsWattQsbJdJB(raycastInfo.point, num2);
				bool hitSound = D5l46jlssr4TRAzUSXzLj0uqu.hitSound;
				bool flag38 = hitSound;
				if (flag38)
				{
					bool flag39 = D5l46jlssr4TRAzUSXzLj0uqu.hitAudioName == "Random";
					bool flag40 = flag39;
					AudioClip audioClip;
					if (flag40)
					{
						audioClip = DHTB5RKsHUihFrfj9ewuLh1f9.D8s0GJ48pUxIBk0rnoKdNCabn[DHTB5RKsHUihFrfj9ewuLh1f9.D50CQJe2EthMU30M7FeGyJFY1[global::UnityEngine.Random.Range(0, DHTB5RKsHUihFrfj9ewuLh1f9.D50CQJe2EthMU30M7FeGyJFY1.Length - 1)]].DwlC9au41qTutPh1QajC5WDNW as AudioClip;
					}
					else
					{
						audioClip = DHTB5RKsHUihFrfj9ewuLh1f9.D8s0GJ48pUxIBk0rnoKdNCabn[D5l46jlssr4TRAzUSXzLj0uqu.hitAudioName].DwlC9au41qTutPh1QajC5WDNW as AudioClip;
					}
					OneShotAudioParameters oneShotAudioParameters = new OneShotAudioParameters(base.player.transform.position, audioClip);
					oneShotAudioParameters.minDistance = 0f;
					oneShotAudioParameters.maxDistance = 15f;
					oneShotAudioParameters.Play();
				}
				DovA0560C5xwc06yYBWmht6vA.D2XDJbj97cXeWm21NhElh6XXL(string.Format("[+] Hit limb {0} with {1} damage", raycastInfo.limb, num2));
			}
			DmPNupos8Sd6cXJNxXG0GuRXC.Dpw12PRHvXQP0KXBj1Eibzva2(Player.player.look.aim.position, raycastInfo.point, 0U);
			base.player.input.sendRaycast(raycastInfo, ERaycastInfoUsage.Punch);
		}
		bool flag41 = mode == EPlayerPunch.LEFT;
		bool flag42 = flag41;
		if (flag42)
		{
			base.player.animator.play("Punch_Left", false);
			bool isServer = Provider.isServer;
			bool flag43 = isServer;
			if (flag43)
			{
				base.player.animator.sendGesture(EPlayerGesture.PUNCH_LEFT, false);
			}
		}
		else
		{
			bool flag44 = mode == EPlayerPunch.RIGHT;
			bool flag45 = flag44;
			if (flag45)
			{
				base.player.animator.play("Punch_Right", false);
				bool isServer2 = Provider.isServer;
				bool flag46 = isServer2;
				if (flag46)
				{
					base.player.animator.sendGesture(EPlayerGesture.PUNCH_RIGHT, false);
				}
			}
		}
		PlayerEquipment.OnPunch_Global.TryInvoke("OnPunch_Global", this, mode);
		bool isServer3 = Provider.isServer;
		bool flag47 = isServer3;
		if (flag47)
		{
			bool flag48 = !base.player.input.hasInputs();
			bool flag49 = !flag48;
			if (flag49)
			{
				InputInfo input = base.player.input.getInput(true, ERaycastInfoUsage.Punch);
				bool flag50 = input == null;
				bool flag51 = !flag50;
				if (flag51)
				{
					bool flag52 = (input.point - base.player.look.aim.position).sqrMagnitude > 36f;
					bool flag53 = !flag52;
					if (flag53)
					{
						DQdg8aDuqxOSScEoE6S9t1j8h.Dt4Zars9PM7Bx3EPB8TvNgCv1.Instance(this);
						bool flag54 = !string.IsNullOrEmpty(input.materialName);
						bool flag55 = flag54;
						if (flag55)
						{
							DQdg8aDuqxOSScEoE6S9t1j8h.DoRtUmtiGEsgtRG6YeBPsJc0X.D8bo6z6P4C0fkdfFioOF82Ftk(new object[]
							{
								input.point,
								input.normal,
								input.materialName,
								input.colliderTransform,
								base.channel.GatherOwnerAndClientConnectionsWithinSphere(input.point, EffectManager.SMALL)
							});
						}
						EPlayerKill eplayerKill = EPlayerKill.NONE;
						uint num3 = 0U;
						float num4 = 1f;
						num4 *= 1f + base.channel.owner.player.skills.mastery(0, 0) * 0.5f;
						bool flag56 = input.type == ERaycastInfoType.PLAYER;
						bool flag57 = flag56;
						if (flag57)
						{
							DQdg8aDuqxOSScEoE6S9t1j8h.Dt4Zars9PM7Bx3EPB8TvNgCv1.Set(Time.realtimeSinceStartup);
							bool flag58 = input.player != null && DamageTool.isPlayerAllowedToDamagePlayer(base.player, input.player);
							bool flag59 = flag58;
							if (flag59)
							{
								DamagePlayerParameters damagePlayerParameters = DamagePlayerParameters.make(input.player, EDeathCause.PUNCH, input.direction, DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_PLAYER_MULTIPLIER, input.limb);
								damagePlayerParameters.killer = csteamID;
								damagePlayerParameters.times = num4;
								damagePlayerParameters.respectArmor = true;
								damagePlayerParameters.trackKill = true;
								bool isUnderFakeLagPenalty = base.player.input.IsUnderFakeLagPenalty;
								bool flag60 = isUnderFakeLagPenalty;
								if (flag60)
								{
									damagePlayerParameters.times *= Provider.configData.Server.Fake_Lag_Damage_Penalty_Multiplier;
								}
								DamageTool.damagePlayer(damagePlayerParameters, out eplayerKill);
							}
						}
						else
						{
							bool flag61 = input.type == ERaycastInfoType.ZOMBIE;
							bool flag62 = flag61;
							if (flag62)
							{
								bool flag63 = input.zombie != null;
								bool flag64 = flag63;
								if (flag64)
								{
									IDamageMultiplier damage_ZOMBIE_MULTIPLIER = DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_ZOMBIE_MULTIPLIER;
									DamageZombieParameters damageZombieParameters = DamageZombieParameters.make(input.zombie, input.direction, damage_ZOMBIE_MULTIPLIER, input.limb);
									damageZombieParameters.times = num4;
									damageZombieParameters.allowBackstab = true;
									damageZombieParameters.respectArmor = true;
									damageZombieParameters.instigator = base.player;
									bool flag65 = base.player.movement.nav != byte.MaxValue;
									bool flag66 = flag65;
									if (flag66)
									{
										damageZombieParameters.AlertPosition = new Vector3?(base.transform.position);
									}
									DamageTool.damageZombie(damageZombieParameters, out eplayerKill, out num3);
								}
							}
							else
							{
								bool flag67 = input.type == ERaycastInfoType.ANIMAL;
								bool flag68 = flag67;
								if (flag68)
								{
									DQdg8aDuqxOSScEoE6S9t1j8h.Dt4Zars9PM7Bx3EPB8TvNgCv1.Set(Time.realtimeSinceStartup);
									bool flag69 = input.animal != null;
									bool flag70 = flag69;
									if (flag70)
									{
										IDamageMultiplier damage_ANIMAL_MULTIPLIER = DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_ANIMAL_MULTIPLIER;
										DamageAnimalParameters damageAnimalParameters = DamageAnimalParameters.make(input.animal, input.direction, damage_ANIMAL_MULTIPLIER, input.limb);
										damageAnimalParameters.times = num4;
										damageAnimalParameters.instigator = base.player;
										damageAnimalParameters.AlertPosition = new Vector3?(base.transform.position);
										DamageTool.damageAnimal(damageAnimalParameters, out eplayerKill, out num3);
									}
								}
								else
								{
									bool flag71 = input.type == ERaycastInfoType.VEHICLE;
									bool flag72 = flag71;
									if (flag72)
									{
										DQdg8aDuqxOSScEoE6S9t1j8h.Dt4Zars9PM7Bx3EPB8TvNgCv1.Set(Time.realtimeSinceStartup);
										bool flag73 = input.vehicle != null && input.vehicle.asset != null && input.vehicle.canBeDamaged && input.vehicle.asset.isVulnerable;
										bool flag74 = flag73;
										if (flag74)
										{
											DamageTool.damage(input.vehicle, false, Vector3.zero, false, DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_VEHICLE, num4 * Provider.modeConfigData.Vehicles.Melee_Damage_Multiplier, true, out eplayerKill, csteamID, EDamageOrigin.Punch);
										}
									}
									else
									{
										bool flag75 = input.type == ERaycastInfoType.BARRICADE;
										bool flag76 = flag75;
										if (flag76)
										{
											DQdg8aDuqxOSScEoE6S9t1j8h.Dt4Zars9PM7Bx3EPB8TvNgCv1.Set(Time.realtimeSinceStartup);
											bool flag77 = input.transform != null && input.transform.CompareTag("Barricade");
											bool flag78 = flag77;
											if (flag78)
											{
												BarricadeDrop barricadeDrop2 = DQdg8aDuqxOSScEoE6S9t1j8h.DXR6f53WbjK0IF3cyafL3uu0T.Invoke(new object[] { input.transform });
												bool flag79 = barricadeDrop2 != null;
												bool flag80 = flag79;
												if (flag80)
												{
													ItemBarricadeAsset asset3 = barricadeDrop2.asset;
													bool flag81 = asset3 != null && asset3.canBeDamaged && asset3.isVulnerable;
													bool flag82 = flag81;
													if (flag82)
													{
														DamageTool.damage(input.transform, false, DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_BARRICADE, num4 * Provider.modeConfigData.Barricades.Melee_Damage_Multiplier, out eplayerKill, csteamID, EDamageOrigin.Punch);
													}
												}
											}
										}
										else
										{
											bool flag83 = input.type == ERaycastInfoType.STRUCTURE;
											bool flag84 = flag83;
											if (flag84)
											{
												DQdg8aDuqxOSScEoE6S9t1j8h.Dt4Zars9PM7Bx3EPB8TvNgCv1.Set(Time.realtimeSinceStartup);
												bool flag85 = input.transform != null && input.transform.CompareTag("Structure");
												bool flag86 = flag85;
												if (flag86)
												{
													StructureDrop structureDrop2 = DQdg8aDuqxOSScEoE6S9t1j8h.Dik5UBIAGX9JGQ0eTNUQ68sGT.Invoke(new object[] { input.transform });
													bool flag87 = structureDrop2 != null;
													bool flag88 = flag87;
													if (flag88)
													{
														ItemStructureAsset asset4 = structureDrop2.asset;
														bool flag89 = asset4 != null && asset4.canBeDamaged && asset4.isVulnerable;
														bool flag90 = flag89;
														if (flag90)
														{
															DamageTool.damage(input.transform, false, input.direction, DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_STRUCTURE, num4 * Provider.modeConfigData.Structures.Melee_Damage_Multiplier, out eplayerKill, csteamID, EDamageOrigin.Punch);
														}
													}
												}
											}
											else
											{
												bool flag91 = input.type == ERaycastInfoType.RESOURCE;
												bool flag92 = flag91;
												if (flag92)
												{
													DQdg8aDuqxOSScEoE6S9t1j8h.Dt4Zars9PM7Bx3EPB8TvNgCv1.Set(Time.realtimeSinceStartup);
													byte b3 = 0;
													byte b4 = 0;
													ushort num5 = 0;
													bool flag93 = input.transform != null && input.transform.CompareTag("Resource") && ResourceManager.tryGetRegion(input.transform, out b3, out b4, out num5);
													bool flag94 = flag93;
													if (flag94)
													{
														ResourceSpawnpoint resourceSpawnpoint2 = ResourceManager.getResourceSpawnpoint(b3, b4, num5);
														bool flag95 = resourceSpawnpoint2 != null && !resourceSpawnpoint2.isDead && resourceSpawnpoint2.asset.vulnerableToFists;
														bool flag96 = flag95;
														if (flag96)
														{
															DamageTool.damage(input.transform, input.direction, DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_RESOURCE, num4, 1f, out eplayerKill, out num3, csteamID, EDamageOrigin.Punch);
														}
													}
												}
												else
												{
													bool flag97 = input.type == ERaycastInfoType.OBJECT && input.transform != null && input.section < byte.MaxValue;
													bool flag98 = flag97;
													if (flag98)
													{
														InteractableObjectRubble componentInParent2 = input.transform.GetComponentInParent<InteractableObjectRubble>();
														bool flag99 = componentInParent2 != null && componentInParent2.IsSectionIndexValid(input.section) && !componentInParent2.isSectionDead(input.section) && componentInParent2.asset.rubbleBladeID == 0 && componentInParent2.asset.rubbleIsVulnerable;
														bool flag100 = flag99;
														if (flag100)
														{
															DamageTool.damage(componentInParent2.transform, input.direction, input.section, DQdg8aDuqxOSScEoE6S9t1j8h.DAMAGE_OBJECT, num4, out eplayerKill, out num3, csteamID, EDamageOrigin.Punch);
														}
													}
												}
											}
										}
									}
								}
							}
						}
						bool flag101 = input.type != ERaycastInfoType.PLAYER && input.type != ERaycastInfoType.ZOMBIE && input.type != ERaycastInfoType.ANIMAL && !base.player.life.isAggressor;
						bool flag102 = flag101;
						if (flag102)
						{
							float num6 = 2f + Provider.modeConfigData.Players.Ray_Aggressor_Distance;
							num6 *= num6;
							float num7 = Provider.modeConfigData.Players.Ray_Aggressor_Distance;
							num7 *= num7;
							Vector3 forward = base.player.look.aim.forward;
							for (int i = 0; i < Provider.clients.Count; i++)
							{
								bool flag103 = Provider.clients[i] != base.channel.owner;
								bool flag104 = flag103;
								if (flag104)
								{
									Player player = Provider.clients[i].player;
									bool flag105 = !(player == null);
									bool flag106 = flag105;
									if (flag106)
									{
										Vector3 vector = player.look.aim.position - base.player.look.aim.position;
										Vector3 vector2 = Vector3.Project(vector, forward);
										bool flag107 = vector2.sqrMagnitude < num6 && (vector2 - vector).sqrMagnitude < num7;
										bool flag108 = flag107;
										if (flag108)
										{
											base.player.life.markAggressive(false, true);
										}
									}
								}
							}
						}
						bool flag109 = Level.info.type == ELevelType.HORDE;
						bool flag110 = flag109;
						if (flag110)
						{
							bool flag111 = input.zombie != null;
							bool flag112 = flag111;
							if (flag112)
							{
								bool flag113 = input.limb == ELimb.SKULL;
								bool flag114 = flag113;
								if (flag114)
								{
									base.player.skills.askPay(10U);
								}
								else
								{
									base.player.skills.askPay(5U);
								}
							}
							bool flag115 = eplayerKill == EPlayerKill.ZOMBIE;
							bool flag116 = flag115;
							if (flag116)
							{
								bool flag117 = input.limb == ELimb.SKULL;
								bool flag118 = flag117;
								if (flag118)
								{
									base.player.skills.askPay(50U);
								}
								else
								{
									base.player.skills.askPay(25U);
								}
							}
						}
						else
						{
							bool flag119 = eplayerKill == EPlayerKill.PLAYER && Level.info.type == ELevelType.ARENA;
							bool flag120 = flag119;
							if (flag120)
							{
								base.player.skills.askPay(100U);
							}
							base.player.sendStat(eplayerKill);
							bool flag121 = num3 > 0U;
							bool flag122 = flag121;
							if (flag122)
							{
								base.player.skills.askPay(num3);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000314 RID: 788 RVA: 0x0002EF44 File Offset: 0x0002D144
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerEquipment), "updateSlot", new Type[] { })]
	private void DYYoOUK08g3F1CHoJIYi7DGoj(byte slot, ushort id, byte[] state)
	{
		bool flag = slot == 0;
		bool flag2 = flag;
		if (flag2)
		{
			bool flag3 = D7ElSFH0pY0XmMbO1Ij5Yf3Tp.DaicsnJorHulnampu0JgsPlC0.ContainsKey(base.player.GetNetId().id);
			bool flag4 = flag3;
			if (flag4)
			{
				D7ElSFH0pY0XmMbO1Ij5Yf3Tp.DaicsnJorHulnampu0JgsPlC0[base.player.GetNetId().id] = id;
			}
			else
			{
				D7ElSFH0pY0XmMbO1Ij5Yf3Tp.DaicsnJorHulnampu0JgsPlC0.Add(base.player.GetNetId().id, id);
			}
		}
		else
		{
			bool flag5 = slot == 1;
			bool flag6 = flag5;
			if (flag6)
			{
				bool flag7 = D7ElSFH0pY0XmMbO1Ij5Yf3Tp.DohYvCb2o7W6QvQ0VgkYyEHx9.ContainsKey(base.player.GetNetId().id);
				bool flag8 = flag7;
				if (flag8)
				{
					D7ElSFH0pY0XmMbO1Ij5Yf3Tp.DohYvCb2o7W6QvQ0VgkYyEHx9[base.player.GetNetId().id] = id;
				}
				else
				{
					D7ElSFH0pY0XmMbO1Ij5Yf3Tp.DohYvCb2o7W6QvQ0VgkYyEHx9.Add(base.player.GetNetId().id, id);
				}
			}
		}
		DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, new object[] { slot, id, state });
	}

	// Token: 0x06000315 RID: 789 RVA: 0x0002F058 File Offset: 0x0002D258
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerEquipment), "updateVision", new Type[] { })]
	internal void DflCQzVx7wxpTLHCTELwwqI7Y()
	{
		DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, Array.Empty<object>());
		bool flag = base.channel.IsLocalPlayer && D5l46jlssr4TRAzUSXzLj0uqu.imitNightvision && !DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6;
		bool flag2 = flag;
		if (flag2)
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
	}

	// Token: 0x04000372 RID: 882
	private static readonly PlayerDamageMultiplier DAMAGE_PLAYER_MULTIPLIER = new PlayerDamageMultiplier(15f, 0.6f, 0.6f, 0.8f, 1.1f);

	// Token: 0x04000373 RID: 883
	private static readonly ZombieDamageMultiplier DAMAGE_ZOMBIE_MULTIPLIER = new ZombieDamageMultiplier(15f, 0.3f, 0.3f, 0.6f, 1.1f);

	// Token: 0x04000374 RID: 884
	private static readonly AnimalDamageMultiplier DAMAGE_ANIMAL_MULTIPLIER = new AnimalDamageMultiplier(15f, 0.3f, 0.6f, 1.1f);

	// Token: 0x04000375 RID: 885
	private static readonly float DAMAGE_BARRICADE = 2f;

	// Token: 0x04000376 RID: 886
	private static readonly float DAMAGE_STRUCTURE = 2f;

	// Token: 0x04000377 RID: 887
	private static readonly float DAMAGE_VEHICLE = 0f;

	// Token: 0x04000378 RID: 888
	private static readonly float DAMAGE_RESOURCE = 20f;

	// Token: 0x04000379 RID: 889
	private static readonly float DAMAGE_OBJECT = 5f;

	// Token: 0x0400037A RID: 890
	public static D0k7NGgNe0fThEj7aIiBuxVnW<float> Dt4Zars9PM7Bx3EPB8TvNgCv1 = new D0k7NGgNe0fThEj7aIiBuxVnW<float>(typeof(PlayerEquipment), "lastPunching", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400037B RID: 891
	public static DQyA1nzDa0rZuYtgcLmIWOUf8 DoRtUmtiGEsgtRG6YeBPsJc0X = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(DamageTool), "ServerSpawnLegacyImpact", BindingFlags.Static | BindingFlags.NonPublic);

	// Token: 0x0400037C RID: 892
	public static DQyA1nzDa0rZuYtgcLmIWOUf8 D32nCQ2xJC8NLYgGZnwMtIZHa = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(PlayerEquipment), "PlayPunchAudioClip", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400037D RID: 893
	public static DfHljpul4p88ytp3JZtoSRq7w<BarricadeDrop> DXR6f53WbjK0IF3cyafL3uu0T = new DfHljpul4p88ytp3JZtoSRq7w<BarricadeDrop>(typeof(BarricadeDrop), "FindByRootFast", BindingFlags.Static | BindingFlags.NonPublic);

	// Token: 0x0400037E RID: 894
	public static DfHljpul4p88ytp3JZtoSRq7w<StructureDrop> Dik5UBIAGX9JGQ0eTNUQ68sGT = new DfHljpul4p88ytp3JZtoSRq7w<StructureDrop>(typeof(StructureDrop), "FindByRootFast", BindingFlags.Static | BindingFlags.NonPublic);
}
