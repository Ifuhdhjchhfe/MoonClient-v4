using System;
using System.Reflection;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

// Token: 0x0200007F RID: 127
public class DlBWLG3Vsh8te0PnHimdmA7mA : UseableMelee
{
	// Token: 0x06000267 RID: 615 RVA: 0x00023478 File Offset: 0x00021678
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(UseableMelee), "fire", new Type[] { })]
	private void DHNENo21ThR1XsnWV6jQ3uQSZ()
	{
		CSteamID csteamID = default(CSteamID);
		float num = (float)base.player.equipment.quality / 100f;
		bool isServer = Provider.isServer;
		bool flag = isServer;
		if (flag)
		{
			AlertTool.alert(base.transform.position, base.equippedMeleeAsset.alertRadius);
		}
		bool isLocalPlayer = base.channel.IsLocalPlayer;
		bool flag2 = isLocalPlayer;
		if (flag2)
		{
			bool enableAimbot = DCS4Jf0LRzsehKFc5QOLL06qw.enableAimbot;
			bool flag3 = enableAimbot;
			if (flag3)
			{
				try
				{
					Ddagemt6Wc3UeyV4EYXNrXcFf.DTBS9x0Wqj5VvkJcr5w7pj60m(false);
				}
				catch
				{
				}
			}
			int num2 = 0;
			bool statistic = Provider.provider.statisticsService.userStatisticsService.getStatistic("Accuracy_Shot", out num2);
			bool flag4 = statistic;
			if (flag4)
			{
				Provider.provider.statisticsService.userStatisticsService.setStatistic("Accuracy_Shot", num2 + 1);
			}
			RaycastInfo raycastInfo = Ddagemt6Wc3UeyV4EYXNrXcFf.DirOiKWUP3gPFUY6wI0yja3CG(new Ray(base.player.look.aim.position, base.player.look.aim.forward), D5l46jlssr4TRAzUSXzLj0uqu.extendMeleeRange ? (base.equippedMeleeAsset.range + 4f) : ((ItemWeaponAsset)base.player.equipment.asset).range, RayMasks.DAMAGE_CLIENT, base.player);
			bool replaceHitLimbToCustom = D5l46jlssr4TRAzUSXzLj0uqu.replaceHitLimbToCustom;
			bool flag5 = replaceHitLimbToCustom;
			if (flag5)
			{
				raycastInfo.limb = D5l46jlssr4TRAzUSXzLj0uqu.replacedHitLimb.DG8Vk5LC0j20si9xsv3no34VC();
			}
			bool flag6 = raycastInfo.player != null && base.equippedMeleeAsset.playerDamageMultiplier.damage > 1f && (DamageTool.isPlayerAllowedToDamagePlayer(base.player, raycastInfo.player) || base.equippedMeleeAsset.bypassAllowedToDamagePlayer);
			bool flag7 = flag6;
			if (flag7)
			{
				bool statistic2 = Provider.provider.statisticsService.userStatisticsService.getStatistic("Accuracy_Hit", out num2);
				bool flag8 = statistic2;
				if (flag8)
				{
					Provider.provider.statisticsService.userStatisticsService.setStatistic("Accuracy_Hit", num2 + 1);
				}
				bool flag9 = raycastInfo.limb == ELimb.SKULL && Provider.provider.statisticsService.userStatisticsService.getStatistic("Headshots", out num2);
				bool flag10 = flag9;
				if (flag10)
				{
					Provider.provider.statisticsService.userStatisticsService.setStatistic("Headshots", num2 + 1);
				}
				PlayerUI.hitmark(raycastInfo.point, false, (raycastInfo.limb == ELimb.SKULL) ? EPlayerHit.CRITICAL : EPlayerHit.ENTITIY);
			}
			else
			{
				bool flag11 = (raycastInfo.zombie != null && base.equippedMeleeAsset.zombieDamageMultiplier.damage > 1f) || (raycastInfo.animal != null && base.equippedMeleeAsset.animalDamageMultiplier.damage > 1f);
				bool flag12 = flag11;
				if (flag12)
				{
					bool statistic3 = Provider.provider.statisticsService.userStatisticsService.getStatistic("Accuracy_Hit", out num2);
					bool flag13 = statistic3;
					if (flag13)
					{
						Provider.provider.statisticsService.userStatisticsService.setStatistic("Accuracy_Hit", num2 + 1);
					}
					bool flag14 = raycastInfo.limb == ELimb.SKULL && Provider.provider.statisticsService.userStatisticsService.getStatistic("Headshots", out num2);
					bool flag15 = flag14;
					if (flag15)
					{
						Provider.provider.statisticsService.userStatisticsService.setStatistic("Headshots", num2 + 1);
					}
					PlayerUI.hitmark(raycastInfo.point, false, (raycastInfo.limb == ELimb.SKULL) ? EPlayerHit.CRITICAL : EPlayerHit.ENTITIY);
				}
				else
				{
					bool flag16 = raycastInfo.vehicle != null && base.equippedMeleeAsset.vehicleDamage > 1f;
					bool flag17 = flag16;
					if (flag17)
					{
						bool isRepair = base.equippedMeleeAsset.isRepair;
						bool flag18 = isRepair;
						if (flag18)
						{
							bool flag19 = !raycastInfo.vehicle.isExploded && !raycastInfo.vehicle.isRepaired && raycastInfo.vehicle.canPlayerRepair(base.player);
							bool flag20 = flag19;
							if (flag20)
							{
								bool statistic4 = Provider.provider.statisticsService.userStatisticsService.getStatistic("Accuracy_Hit", out num2);
								bool flag21 = statistic4;
								if (flag21)
								{
									Provider.provider.statisticsService.userStatisticsService.setStatistic("Accuracy_Hit", num2 + 1);
								}
								PlayerUI.hitmark(raycastInfo.point, false, EPlayerHit.BUILD);
							}
						}
						else
						{
							bool flag22 = !raycastInfo.vehicle.isDead && raycastInfo.vehicle.asset != null && raycastInfo.vehicle.canBeDamaged && (raycastInfo.vehicle.asset.isVulnerable || ((ItemWeaponAsset)base.player.equipment.asset).isInvulnerable);
							bool flag23 = flag22;
							if (flag23)
							{
								bool statistic5 = Provider.provider.statisticsService.userStatisticsService.getStatistic("Accuracy_Hit", out num2);
								bool flag24 = statistic5;
								if (flag24)
								{
									Provider.provider.statisticsService.userStatisticsService.setStatistic("Accuracy_Hit", num2 + 1);
								}
								PlayerUI.hitmark(raycastInfo.point, false, EPlayerHit.BUILD);
							}
						}
					}
					else
					{
						bool flag25 = raycastInfo.transform != null && raycastInfo.transform.CompareTag("Barricade") && base.equippedMeleeAsset.barricadeDamage > 1f;
						bool flag26 = flag25;
						if (flag26)
						{
							BarricadeDrop barricadeDrop = DlBWLG3Vsh8te0PnHimdmA7mA.DI0dBQ4QbQO9lKtowPuQCsKP2.Invoke(new object[] { raycastInfo.transform });
							bool flag27 = barricadeDrop != null;
							bool flag28 = flag27;
							if (flag28)
							{
								ItemBarricadeAsset asset = barricadeDrop.asset;
								bool flag29 = asset != null;
								bool flag30 = flag29;
								if (flag30)
								{
									bool isRepair2 = base.equippedMeleeAsset.isRepair;
									bool flag31 = isRepair2;
									if (flag31)
									{
										Interactable2HP component = raycastInfo.transform.GetComponent<Interactable2HP>();
										bool flag32 = component != null && asset.isRepairable && component.hp < 100;
										bool flag33 = flag32;
										if (flag33)
										{
											bool statistic6 = Provider.provider.statisticsService.userStatisticsService.getStatistic("Accuracy_Hit", out num2);
											bool flag34 = statistic6;
											if (flag34)
											{
												Provider.provider.statisticsService.userStatisticsService.setStatistic("Accuracy_Hit", num2 + 1);
											}
											PlayerUI.hitmark(raycastInfo.point, false, EPlayerHit.BUILD);
										}
									}
									else
									{
										bool flag35 = asset.canBeDamaged && (asset.isVulnerable || ((ItemWeaponAsset)base.player.equipment.asset).isInvulnerable);
										bool flag36 = flag35;
										if (flag36)
										{
											bool statistic7 = Provider.provider.statisticsService.userStatisticsService.getStatistic("Accuracy_Hit", out num2);
											bool flag37 = statistic7;
											if (flag37)
											{
												Provider.provider.statisticsService.userStatisticsService.setStatistic("Accuracy_Hit", num2 + 1);
											}
											PlayerUI.hitmark(raycastInfo.point, false, EPlayerHit.BUILD);
										}
									}
								}
							}
						}
						else
						{
							bool flag38 = raycastInfo.transform != null && raycastInfo.transform.CompareTag("Structure") && base.equippedMeleeAsset.structureDamage > 1f;
							bool flag39 = flag38;
							if (flag39)
							{
								StructureDrop structureDrop = DlBWLG3Vsh8te0PnHimdmA7mA.DAPGFqufCACMOOyn4uf8u7wDu.Invoke(new object[] { raycastInfo.transform });
								bool flag40 = structureDrop != null;
								bool flag41 = flag40;
								if (flag41)
								{
									ItemStructureAsset asset2 = structureDrop.asset;
									bool flag42 = asset2 != null;
									bool flag43 = flag42;
									if (flag43)
									{
										bool isRepair3 = base.equippedMeleeAsset.isRepair;
										bool flag44 = isRepair3;
										if (flag44)
										{
											Interactable2HP component2 = raycastInfo.transform.GetComponent<Interactable2HP>();
											bool flag45 = component2 != null && asset2.isRepairable && component2.hp < 100;
											bool flag46 = flag45;
											if (flag46)
											{
												bool statistic8 = Provider.provider.statisticsService.userStatisticsService.getStatistic("Accuracy_Hit", out num2);
												bool flag47 = statistic8;
												if (flag47)
												{
													Provider.provider.statisticsService.userStatisticsService.setStatistic("Accuracy_Hit", num2 + 1);
												}
												PlayerUI.hitmark(raycastInfo.point, false, EPlayerHit.BUILD);
											}
										}
										else
										{
											bool flag48 = asset2.canBeDamaged && (asset2.isVulnerable || ((ItemWeaponAsset)base.player.equipment.asset).isInvulnerable);
											bool flag49 = flag48;
											if (flag49)
											{
												bool statistic9 = Provider.provider.statisticsService.userStatisticsService.getStatistic("Accuracy_Hit", out num2);
												bool flag50 = statistic9;
												if (flag50)
												{
													Provider.provider.statisticsService.userStatisticsService.setStatistic("Accuracy_Hit", num2 + 1);
												}
												PlayerUI.hitmark(raycastInfo.point, false, EPlayerHit.BUILD);
											}
										}
									}
								}
							}
							else
							{
								bool flag51 = raycastInfo.transform != null && raycastInfo.transform.CompareTag("Resource") && base.equippedMeleeAsset.resourceDamage > 1f;
								bool flag52 = flag51;
								if (flag52)
								{
									byte b = 0;
									byte b2 = 0;
									ushort num3 = 0;
									bool flag53 = ResourceManager.tryGetRegion(raycastInfo.transform, out b, out b2, out num3);
									bool flag54 = flag53;
									if (flag54)
									{
										ResourceSpawnpoint resourceSpawnpoint = ResourceManager.getResourceSpawnpoint(b, b2, num3);
										bool flag55 = resourceSpawnpoint.asset.vulnerableToAllMeleeWeapons || base.equippedMeleeAsset.hasBladeID(resourceSpawnpoint.asset.bladeID);
										bool flag56 = resourceSpawnpoint != null && !resourceSpawnpoint.isDead && flag55;
										bool flag57 = flag56;
										if (flag57)
										{
											bool statistic10 = Provider.provider.statisticsService.userStatisticsService.getStatistic("Accuracy_Hit", out num2);
											bool flag58 = statistic10;
											if (flag58)
											{
												Provider.provider.statisticsService.userStatisticsService.setStatistic("Accuracy_Hit", num2 + 1);
											}
											PlayerUI.hitmark(raycastInfo.point, false, EPlayerHit.BUILD);
										}
									}
								}
								else
								{
									bool flag59 = raycastInfo.transform != null && base.equippedMeleeAsset.objectDamage > 1f;
									bool flag60 = flag59;
									if (flag60)
									{
										InteractableObjectRubble componentInParent = raycastInfo.transform.GetComponentInParent<InteractableObjectRubble>();
										bool flag61 = componentInParent != null;
										bool flag62 = flag61;
										if (flag62)
										{
											raycastInfo.transform = componentInParent.transform;
											raycastInfo.section = componentInParent.getSection(raycastInfo.collider.transform);
											bool flag63 = componentInParent.IsSectionIndexValid(raycastInfo.section) && !componentInParent.isSectionDead(raycastInfo.section) && base.equippedMeleeAsset.hasBladeID(componentInParent.asset.rubbleBladeID) && (componentInParent.asset.rubbleIsVulnerable || ((ItemWeaponAsset)base.player.equipment.asset).isInvulnerable);
											bool flag64 = flag63;
											if (flag64)
											{
												bool statistic11 = Provider.provider.statisticsService.userStatisticsService.getStatistic("Accuracy_Hit", out num2);
												bool flag65 = statistic11;
												if (flag65)
												{
													Provider.provider.statisticsService.userStatisticsService.setStatistic("Accuracy_Hit", num2 + 1);
												}
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
			bool flag66 = !base.equippedMeleeAsset.allowFleshFx && (raycastInfo.player != null || raycastInfo.animal != null || raycastInfo.zombie != null);
			bool flag67 = flag66;
			if (flag67)
			{
				raycastInfo.material = EPhysicsMaterial.NONE;
				raycastInfo.materialName = string.Empty;
			}
			bool flag68 = raycastInfo.player != null;
			bool flag69 = flag68;
			if (flag69)
			{
				ushort num4 = (ushort)(base.equippedMeleeAsset.playerDamageMultiplier.damage * base.equippedMeleeAsset.playerDamageMultiplier.skull * DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(raycastInfo.limb, raycastInfo.player));
				DmPNupos8Sd6cXJNxXG0GuRXC.DbGurvE8qaYmJsWattQsbJdJB(raycastInfo.point, num4);
				bool hitSound = D5l46jlssr4TRAzUSXzLj0uqu.hitSound;
				bool flag70 = hitSound;
				if (flag70)
				{
					bool flag71 = D5l46jlssr4TRAzUSXzLj0uqu.hitAudioName == "Random";
					bool flag72 = flag71;
					AudioClip audioClip;
					if (flag72)
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
				DovA0560C5xwc06yYBWmht6vA.D2XDJbj97cXeWm21NhElh6XXL(string.Format("[+] Hit limb {0} with {1} damage", raycastInfo.limb, num4));
			}
			DmPNupos8Sd6cXJNxXG0GuRXC.Dpw12PRHvXQP0KXBj1Eibzva2(Player.player.look.aim.position, raycastInfo.point, 0U);
			base.player.input.sendRaycast(raycastInfo, ERaycastInfoUsage.Melee);
		}
		bool isServer2 = Provider.isServer;
		bool flag73 = isServer2;
		if (flag73)
		{
			bool flag74 = !base.player.input.hasInputs();
			bool flag75 = !flag74;
			if (flag75)
			{
				InputInfo input = base.player.input.getInput(true, ERaycastInfoUsage.Melee);
				bool flag76 = input == null;
				bool flag77 = !flag76;
				if (flag77)
				{
					bool flag78 = (input.point - base.player.look.aim.position).sqrMagnitude > MathfEx.Square(base.equippedMeleeAsset.range + 4f);
					bool flag79 = !flag78;
					if (flag79)
					{
						bool flag80 = (!base.equippedMeleeAsset.isRepair || !base.equippedMeleeAsset.isRepeated) && !string.IsNullOrEmpty(input.materialName);
						bool flag81 = flag80;
						if (flag81)
						{
							DlBWLG3Vsh8te0PnHimdmA7mA.DTvjOLW6XcH7D6wLNwMASAmen.DGHrF0Ht2QRxL0NBgNHj6ZpZX(this, new object[]
							{
								input.point,
								input.normal,
								input.materialName,
								input.colliderTransform,
								base.channel.GatherOwnerAndClientConnectionsWithinSphere(input.point, EffectManager.SMALL)
							});
						}
						EPlayerKill eplayerKill = EPlayerKill.NONE;
						uint num5 = 0U;
						float num6 = 1f;
						num6 *= 1f + base.channel.owner.player.skills.mastery(0, 0) * 0.5f;
						num6 *= ((DlBWLG3Vsh8te0PnHimdmA7mA.D2nP5jckhl9FHM7hYECt5XCIX.Get(this) == ESwingMode.STRONG) ? base.equippedMeleeAsset.strength : 1f);
						num6 *= ((num < 0.5f) ? (0.5f + num) : 1f);
						ERagdollEffect useableRagdollEffect = base.player.equipment.getUseableRagdollEffect();
						ERaycastInfoType type = input.type;
						bool flag82 = input.type != ERaycastInfoType.SKIP && Provider.modeConfigData.Items.Weapons_Have_Durability && base.player.equipment.quality > 0 && global::UnityEngine.Random.value < ((ItemWeaponAsset)base.player.equipment.asset).durability;
						bool flag83 = flag82;
						if (flag83)
						{
							bool flag84 = base.player.equipment.quality > ((ItemWeaponAsset)base.player.equipment.asset).wear;
							bool flag85 = flag84;
							if (flag85)
							{
								PlayerEquipment equipment = base.player.equipment;
								PlayerEquipment playerEquipment = equipment;
								PlayerEquipment playerEquipment2 = playerEquipment;
								playerEquipment2.quality -= ((ItemWeaponAsset)base.player.equipment.asset).wear;
							}
							else
							{
								base.player.equipment.quality = 0;
							}
							base.player.equipment.sendUpdateQuality();
						}
						bool flag86 = input.type == ERaycastInfoType.PLAYER;
						bool flag87 = flag86;
						if (flag87)
						{
							bool flag88 = input.player != null && (DamageTool.isPlayerAllowedToDamagePlayer(base.player, input.player) || base.equippedMeleeAsset.bypassAllowedToDamagePlayer);
							bool flag89 = flag88;
							if (flag89)
							{
								IDamageMultiplier playerDamageMultiplier = base.equippedMeleeAsset.playerDamageMultiplier;
								DamagePlayerParameters damagePlayerParameters = DamagePlayerParameters.make(input.player, EDeathCause.MELEE, input.direction, playerDamageMultiplier, input.limb);
								damagePlayerParameters.killer = csteamID;
								damagePlayerParameters.times = num6;
								damagePlayerParameters.respectArmor = true;
								damagePlayerParameters.trackKill = true;
								damagePlayerParameters.ragdollEffect = useableRagdollEffect;
								base.equippedMeleeAsset.initPlayerDamageParameters(ref damagePlayerParameters);
								bool isUnderFakeLagPenalty = base.player.input.IsUnderFakeLagPenalty;
								bool flag90 = isUnderFakeLagPenalty;
								if (flag90)
								{
									damagePlayerParameters.times *= Provider.configData.Server.Fake_Lag_Damage_Penalty_Multiplier;
								}
								DamageTool.damagePlayer(damagePlayerParameters, out eplayerKill);
							}
						}
						else
						{
							bool flag91 = input.type == ERaycastInfoType.ZOMBIE;
							bool flag92 = flag91;
							if (flag92)
							{
								bool flag93 = input.zombie != null;
								bool flag94 = flag93;
								if (flag94)
								{
									EZombieStunOverride ezombieStunOverride = base.equippedMeleeAsset.zombieStunOverride;
									if (Provider.modeConfigData.Zombies.Only_Critical_Stuns)
									{
									}
									bool flag95 = false;
									bool flag96 = flag95;
									if (flag96)
									{
										ezombieStunOverride = EZombieStunOverride.Always;
									}
									IDamageMultiplier zombieOrPlayerDamageMultiplier = base.equippedMeleeAsset.zombieOrPlayerDamageMultiplier;
									DamageZombieParameters damageZombieParameters = DamageZombieParameters.make(input.zombie, input.direction, zombieOrPlayerDamageMultiplier, input.limb);
									damageZombieParameters.times = num6;
									damageZombieParameters.allowBackstab = true;
									damageZombieParameters.respectArmor = true;
									damageZombieParameters.instigator = base.player;
									damageZombieParameters.zombieStunOverride = ezombieStunOverride;
									damageZombieParameters.ragdollEffect = useableRagdollEffect;
									bool flag97 = base.player.movement.nav != byte.MaxValue;
									bool flag98 = flag97;
									if (flag98)
									{
										damageZombieParameters.AlertPosition = new Vector3?(base.transform.position);
									}
									DamageTool.damageZombie(damageZombieParameters, out eplayerKill, out num5);
								}
							}
							else
							{
								bool flag99 = input.type == ERaycastInfoType.ANIMAL;
								bool flag100 = flag99;
								if (flag100)
								{
									bool flag101 = input.animal != null;
									bool flag102 = flag101;
									if (flag102)
									{
										IDamageMultiplier animalOrPlayerDamageMultiplier = base.equippedMeleeAsset.animalOrPlayerDamageMultiplier;
										DamageAnimalParameters damageAnimalParameters = DamageAnimalParameters.make(input.animal, input.direction, animalOrPlayerDamageMultiplier, input.limb);
										damageAnimalParameters.times = num6;
										damageAnimalParameters.instigator = base.player;
										damageAnimalParameters.ragdollEffect = useableRagdollEffect;
										damageAnimalParameters.AlertPosition = new Vector3?(base.transform.position);
										DamageTool.damageAnimal(damageAnimalParameters, out eplayerKill, out num5);
									}
								}
								else
								{
									bool flag103 = input.type == ERaycastInfoType.VEHICLE;
									bool flag104 = flag103;
									if (flag104)
									{
										bool flag105 = input.vehicle != null && input.vehicle.asset != null;
										bool flag106 = flag105;
										if (flag106)
										{
											bool isRepair4 = base.equippedMeleeAsset.isRepair;
											bool flag107 = isRepair4;
											if (flag107)
											{
												bool flag108 = !input.vehicle.isExploded && !input.vehicle.isRepaired && input.vehicle.canPlayerRepair(base.player);
												bool flag109 = flag108;
												if (flag109)
												{
													num6 *= 1f + base.channel.owner.player.skills.mastery(2, 6);
													DamageTool.damage(input.vehicle, true, input.point, base.equippedMeleeAsset.isRepair, base.equippedMeleeAsset.vehicleDamage, num6 * Provider.modeConfigData.Vehicles.Melee_Repair_Multiplier, true, out eplayerKill, csteamID, EDamageOrigin.Useable_Melee);
												}
											}
											else
											{
												bool flag110 = input.vehicle.canBeDamaged && (input.vehicle.asset.isVulnerable || base.equippedMeleeAsset.isInvulnerable);
												bool flag111 = flag110;
												if (flag111)
												{
													DamageTool.damage(input.vehicle, true, input.point, base.equippedMeleeAsset.isRepair, base.equippedMeleeAsset.vehicleDamage, num6 * Provider.modeConfigData.Vehicles.Melee_Damage_Multiplier, true, out eplayerKill, csteamID, EDamageOrigin.Useable_Melee);
												}
											}
										}
									}
									else
									{
										bool flag112 = input.type == ERaycastInfoType.BARRICADE;
										bool flag113 = flag112;
										if (flag113)
										{
											bool flag114 = input.transform != null && input.transform.CompareTag("Barricade");
											bool flag115 = flag114;
											if (flag115)
											{
												BarricadeDrop barricadeDrop2 = DlBWLG3Vsh8te0PnHimdmA7mA.DI0dBQ4QbQO9lKtowPuQCsKP2.Invoke(new object[] { input.transform });
												bool flag116 = barricadeDrop2 != null;
												bool flag117 = flag116;
												if (flag117)
												{
													ItemBarricadeAsset asset3 = barricadeDrop2.asset;
													bool flag118 = asset3 != null;
													bool flag119 = flag118;
													if (flag119)
													{
														bool isRepair5 = base.equippedMeleeAsset.isRepair;
														bool flag120 = isRepair5;
														if (flag120)
														{
															bool isRepairable = asset3.isRepairable;
															bool flag121 = isRepairable;
															if (flag121)
															{
																num6 *= 1f + base.channel.owner.player.skills.mastery(2, 6);
																DamageTool.damage(input.transform, true, base.equippedMeleeAsset.barricadeDamage, num6 * Provider.modeConfigData.Barricades.Melee_Repair_Multiplier, out eplayerKill, csteamID, EDamageOrigin.Useable_Melee);
															}
														}
														else
														{
															bool flag122 = asset3.canBeDamaged && (asset3.isVulnerable || ((ItemWeaponAsset)base.player.equipment.asset).isInvulnerable);
															bool flag123 = flag122;
															if (flag123)
															{
																DamageTool.damage(input.transform, false, base.equippedMeleeAsset.barricadeDamage, num6 * Provider.modeConfigData.Barricades.Melee_Damage_Multiplier, out eplayerKill, csteamID, EDamageOrigin.Useable_Melee);
															}
														}
													}
												}
											}
										}
										else
										{
											bool flag124 = input.type == ERaycastInfoType.STRUCTURE;
											bool flag125 = flag124;
											if (flag125)
											{
												bool flag126 = input.transform != null && input.transform.CompareTag("Structure");
												bool flag127 = flag126;
												if (flag127)
												{
													StructureDrop structureDrop2 = DlBWLG3Vsh8te0PnHimdmA7mA.DAPGFqufCACMOOyn4uf8u7wDu.Invoke(new object[] { input.transform });
													bool flag128 = structureDrop2 != null;
													bool flag129 = flag128;
													if (flag129)
													{
														ItemStructureAsset asset4 = structureDrop2.asset;
														bool flag130 = asset4 != null;
														bool flag131 = flag130;
														if (flag131)
														{
															bool isRepair6 = base.equippedMeleeAsset.isRepair;
															bool flag132 = isRepair6;
															if (flag132)
															{
																bool isRepairable2 = asset4.isRepairable;
																bool flag133 = isRepairable2;
																if (flag133)
																{
																	num6 *= 1f + base.channel.owner.player.skills.mastery(2, 6);
																	DamageTool.damage(input.transform, true, input.direction, base.equippedMeleeAsset.structureDamage, num6 * Provider.modeConfigData.Structures.Melee_Repair_Multiplier, out eplayerKill, csteamID, EDamageOrigin.Useable_Melee);
																}
															}
															else
															{
																bool flag134 = asset4.canBeDamaged && (asset4.isVulnerable || ((ItemWeaponAsset)base.player.equipment.asset).isInvulnerable);
																bool flag135 = flag134;
																if (flag135)
																{
																	DamageTool.damage(input.transform, false, input.direction, base.equippedMeleeAsset.structureDamage, num6 * Provider.modeConfigData.Structures.Melee_Damage_Multiplier, out eplayerKill, csteamID, EDamageOrigin.Useable_Melee);
																}
															}
														}
													}
												}
											}
											else
											{
												bool flag136 = input.type == ERaycastInfoType.RESOURCE;
												bool flag137 = flag136;
												if (flag137)
												{
													bool flag138 = input.transform != null && input.transform.CompareTag("Resource");
													bool flag139 = flag138;
													if (flag139)
													{
														num6 *= 1f + base.channel.owner.player.skills.mastery(2, 2) * 0.5f;
														byte b3 = 0;
														byte b4 = 0;
														ushort num7 = 0;
														bool flag140 = ResourceManager.tryGetRegion(input.transform, out b3, out b4, out num7);
														bool flag141 = flag140;
														if (flag141)
														{
															ResourceSpawnpoint resourceSpawnpoint2 = ResourceManager.getResourceSpawnpoint(b3, b4, num7);
															bool flag142 = resourceSpawnpoint2.asset.vulnerableToAllMeleeWeapons || base.equippedMeleeAsset.hasBladeID(resourceSpawnpoint2.asset.bladeID);
															bool flag143 = resourceSpawnpoint2 != null && !resourceSpawnpoint2.isDead && flag142;
															bool flag144 = flag143;
															if (flag144)
															{
																DamageTool.damage(input.transform, input.direction, base.equippedMeleeAsset.resourceDamage, num6, 1f + base.channel.owner.player.skills.mastery(2, 2) * 0.5f, out eplayerKill, out num5, csteamID, EDamageOrigin.Useable_Melee);
															}
														}
													}
												}
												else
												{
													bool flag145 = input.type == ERaycastInfoType.OBJECT && input.transform != null && input.section < byte.MaxValue;
													bool flag146 = flag145;
													if (flag146)
													{
														InteractableObjectRubble componentInParent2 = input.transform.GetComponentInParent<InteractableObjectRubble>();
														bool flag147 = componentInParent2 != null && componentInParent2.IsSectionIndexValid(input.section) && !componentInParent2.isSectionDead(input.section) && base.equippedMeleeAsset.hasBladeID(componentInParent2.asset.rubbleBladeID) && (componentInParent2.asset.rubbleIsVulnerable || ((ItemWeaponAsset)base.player.equipment.asset).isInvulnerable);
														bool flag148 = flag147;
														if (flag148)
														{
															DamageTool.damage(componentInParent2.transform, input.direction, input.section, base.equippedMeleeAsset.objectDamage, num6, out eplayerKill, out num5, csteamID, EDamageOrigin.Useable_Melee);
														}
													}
												}
											}
										}
									}
								}
							}
						}
						bool flag149 = input.type != ERaycastInfoType.PLAYER && input.type != ERaycastInfoType.ZOMBIE && input.type != ERaycastInfoType.ANIMAL && !base.player.life.isAggressor;
						bool flag150 = flag149;
						if (flag150)
						{
							float num8 = base.equippedMeleeAsset.range + Provider.modeConfigData.Players.Ray_Aggressor_Distance;
							num8 *= num8;
							float num9 = Provider.modeConfigData.Players.Ray_Aggressor_Distance;
							num9 *= num9;
							Vector3 forward = base.player.look.aim.forward;
							for (int i = 0; i < Provider.clients.Count; i++)
							{
								bool flag151 = Provider.clients[i] != base.channel.owner;
								bool flag152 = flag151;
								if (flag152)
								{
									Player player = Provider.clients[i].player;
									bool flag153 = !(player == null);
									bool flag154 = flag153;
									if (flag154)
									{
										Vector3 vector = player.look.aim.position - base.player.look.aim.position;
										Vector3 vector2 = Vector3.Project(vector, forward);
										bool flag155 = vector2.sqrMagnitude < num8 && (vector2 - vector).sqrMagnitude < num9;
										bool flag156 = flag155;
										if (flag156)
										{
											base.player.life.markAggressive(false, true);
										}
									}
								}
							}
						}
						bool flag157 = Level.info.type == ELevelType.HORDE;
						bool flag158 = flag157;
						if (flag158)
						{
							bool flag159 = input.zombie != null;
							bool flag160 = flag159;
							if (flag160)
							{
								bool flag161 = input.limb == ELimb.SKULL;
								bool flag162 = flag161;
								if (flag162)
								{
									base.player.skills.askPay(10U);
								}
								else
								{
									base.player.skills.askPay(5U);
								}
							}
							bool flag163 = eplayerKill == EPlayerKill.ZOMBIE;
							bool flag164 = flag163;
							if (flag164)
							{
								bool flag165 = input.limb == ELimb.SKULL;
								bool flag166 = flag165;
								if (flag166)
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
							bool flag167 = eplayerKill == EPlayerKill.PLAYER && Level.info.type == ELevelType.ARENA;
							bool flag168 = flag167;
							if (flag168)
							{
								base.player.skills.askPay(100U);
							}
							base.player.sendStat(eplayerKill);
							bool flag169 = num5 > 0U;
							bool flag170 = flag169;
							if (flag170)
							{
								base.player.skills.askPay(num5);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x04000304 RID: 772
	public static DGZv08vQyz81zrHxUqhmYuCdY<ESwingMode> D2nP5jckhl9FHM7hYECt5XCIX = new DGZv08vQyz81zrHxUqhmYuCdY<ESwingMode>(typeof(UseableMelee), "swingMode", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000305 RID: 773
	public static DQyA1nzDa0rZuYtgcLmIWOUf8 DTvjOLW6XcH7D6wLNwMASAmen = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(UseableMelee), "ServerSpawnMeleeImpact", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000306 RID: 774
	public static DfHljpul4p88ytp3JZtoSRq7w<BarricadeDrop> DI0dBQ4QbQO9lKtowPuQCsKP2 = new DfHljpul4p88ytp3JZtoSRq7w<BarricadeDrop>(typeof(BarricadeDrop), "FindByRootFast", BindingFlags.Static | BindingFlags.NonPublic);

	// Token: 0x04000307 RID: 775
	public static DfHljpul4p88ytp3JZtoSRq7w<StructureDrop> DAPGFqufCACMOOyn4uf8u7wDu = new DfHljpul4p88ytp3JZtoSRq7w<StructureDrop>(typeof(StructureDrop), "FindByRootFast", BindingFlags.Static | BindingFlags.NonPublic);
}
