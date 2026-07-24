using System;
using System.Collections.Generic;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200009C RID: 156
public class Dp86EPUU0qiRCgpoTgjzXqsq4 : UseableGun
{
	// Token: 0x17000021 RID: 33
	// (get) Token: 0x060002F6 RID: 758 RVA: 0x0002AAD4 File Offset: 0x00028CD4
	public static UseableGun gun
	{
		get
		{
			return Player.player.equipment.useable as UseableGun;
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x060002F7 RID: 759 RVA: 0x0002AAFC File Offset: 0x00028CFC
	public static bool shouldEnableTacticalStats
	{
		get
		{
			ItemTacticalAsset tacticalAsset = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.Get(Dp86EPUU0qiRCgpoTgjzXqsq4.gun).tacticalAsset;
			return tacticalAsset != null && ((!tacticalAsset.isLaser && !tacticalAsset.isLight && !tacticalAsset.isRangefinder) || Dp86EPUU0qiRCgpoTgjzXqsq4.DzSSPqSltJQFD6sMZK9Jc2CZ0.Get(Dp86EPUU0qiRCgpoTgjzXqsq4.gun));
		}
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x0002AB54 File Offset: 0x00028D54
	public static float DMGzyINd9semIrmvPZmwlgcjZ()
	{
		float num = (float)Player.player.equipment.quality / 100f;
		float num2 = Dp86EPUU0qiRCgpoTgjzXqsq4.DnXVGtKMTwMpBVK0RW4ZAcnXP.InvokeI(Dp86EPUU0qiRCgpoTgjzXqsq4.gun, Array.Empty<object>());
		return Dp86EPUU0qiRCgpoTgjzXqsq4.Di4PPH1jj6EaD4GKAcSZ28OU5(num, num2);
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x0002AB9C File Offset: 0x00028D9C
	public static float Di4PPH1jj6EaD4GKAcSZ28OU5(float quality, float aimAlpha)
	{
		float num = Dp86EPUU0qiRCgpoTgjzXqsq4.gun.equippedGunAsset.baseSpreadAngleRadians;
		num *= ((quality < 0.5f) ? (1f + (1f - quality * 2f)) : 1f);
		num *= Mathf.Lerp(1f, Dp86EPUU0qiRCgpoTgjzXqsq4.gun.equippedGunAsset.spreadAim, aimAlpha);
		num *= 1f - Player.player.skills.mastery(0, 1) * 0.5f;
		Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.RefereshFieldValue(Dp86EPUU0qiRCgpoTgjzXqsq4.gun);
		bool flag = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.sightAsset != null && (!Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.sightAsset.ShouldOnlyAffectAimWhileProne || Player.player.stance.stance == EPlayerStance.PRONE);
		if (flag)
		{
			num *= Mathf.Lerp(1f, Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.sightAsset.spread, aimAlpha);
		}
		bool flag2 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.tacticalAsset != null && Dp86EPUU0qiRCgpoTgjzXqsq4.shouldEnableTacticalStats && (!Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.tacticalAsset.ShouldOnlyAffectAimWhileProne || Player.player.stance.stance == EPlayerStance.PRONE);
		if (flag2)
		{
			num *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.tacticalAsset.spread;
		}
		bool flag3 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.gripAsset != null && (!Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.gripAsset.ShouldOnlyAffectAimWhileProne || Player.player.stance.stance == EPlayerStance.PRONE);
		if (flag3)
		{
			num *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.gripAsset.spread;
		}
		bool flag4 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.barrelAsset != null && (!Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.barrelAsset.ShouldOnlyAffectAimWhileProne || Player.player.stance.stance == EPlayerStance.PRONE);
		if (flag4)
		{
			num *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.barrelAsset.spread;
		}
		bool flag5 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.magazineAsset != null && (!Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.magazineAsset.ShouldOnlyAffectAimWhileProne || Player.player.stance.stance == EPlayerStance.PRONE);
		if (flag5)
		{
			num *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.magazineAsset.spread;
		}
		bool flag6 = Player.player.stance.stance == EPlayerStance.SPRINT;
		if (flag6)
		{
			num *= Dp86EPUU0qiRCgpoTgjzXqsq4.gun.equippedGunAsset.spreadSprint;
		}
		else
		{
			bool flag7 = Player.player.stance.stance == EPlayerStance.CROUCH;
			if (flag7)
			{
				num *= Dp86EPUU0qiRCgpoTgjzXqsq4.gun.equippedGunAsset.spreadCrouch;
			}
			else
			{
				bool flag8 = Player.player.stance.stance == EPlayerStance.PRONE;
				if (flag8)
				{
					num *= Dp86EPUU0qiRCgpoTgjzXqsq4.gun.equippedGunAsset.spreadProne;
				}
			}
		}
		bool flag9 = Player.player.look.perspective == EPlayerPerspective.THIRD;
		if (flag9)
		{
			num *= Provider.modeConfigData.Gameplay.ThirdPerson_SpreadMultiplier;
		}
		bool flag10 = !Player.player.movement.isGrounded;
		if (flag10)
		{
			num *= 1.5f;
		}
		return num;
	}

	// Token: 0x060002FA RID: 762 RVA: 0x0002AEEC File Offset: 0x000290EC
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(UseableGun), "equip", BindingFlags.Instance | BindingFlags.Public, new Type[] { })]
	public static void DwM5DrfCg9Mn7Pd3uKw2skPeW(UseableGun ug)
	{
		DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(ug, Array.Empty<object>());
		bool flag = (ug.channel.IsLocalPlayer || Provider.isServer) && ug.equippedGunAsset.projectile == null;
		if (flag)
		{
			Dp86EPUU0qiRCgpoTgjzXqsq4.D36biafXtT7ax1xV7NehAjDcv = new List<DRxteGz0evnNDVy6poswGHA5b>();
		}
	}

	// Token: 0x060002FB RID: 763 RVA: 0x0002AF40 File Offset: 0x00029140
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(UseableGun), "ballistics", new Type[] { })]
	private void D3Ii9K5dJ5cxz9FvgBYz7GaiA()
	{
		bool flag = !base.channel.IsLocalPlayer || Provider.isServer;
		if (flag)
		{
			DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, Array.Empty<object>());
		}
		else
		{
			bool flag2 = base.equippedGunAsset.projectile == null && Dp86EPUU0qiRCgpoTgjzXqsq4.D36biafXtT7ax1xV7NehAjDcv != null;
			if (flag2)
			{
				int i = 0;
				while (i < Dp86EPUU0qiRCgpoTgjzXqsq4.D36biafXtT7ax1xV7NehAjDcv.Count)
				{
					DRxteGz0evnNDVy6poswGHA5b drxteGz0evnNDVy6poswGHA5b = Dp86EPUU0qiRCgpoTgjzXqsq4.D36biafXtT7ax1xV7NehAjDcv[i];
					Ray ray = new Ray(drxteGz0evnNDVy6poswGHA5b.DlPLxBhsLDGaLNNc4SxCdwdsU, drxteGz0evnNDVy6poswGHA5b.DtXuNVaLY13FvGOCTsQVpJfvx);
					float num = 4f;
					bool flag3 = Provider.modeConfigData.Gameplay.Ballistics && drxteGz0evnNDVy6poswGHA5b.DTW6zDZRuBKOUBbHU8Vmgx0aD + 1 >= base.equippedGunAsset.ballisticSteps;
					if (flag3)
					{
						num += base.equippedGunAsset.ballisticTravel * (float)D5l46jlssr4TRAzUSXzLj0uqu.additionalBallisticSteps;
					}
					float num2 = (Provider.modeConfigData.Gameplay.Ballistics ? base.equippedGunAsset.ballisticTravel : base.equippedGunAsset.range) + (D5l46jlssr4TRAzUSXzLj0uqu.extendBallisticRange ? num : 0f);
					RaycastInfo raycastInfo = Ddagemt6Wc3UeyV4EYXNrXcFf.DekCZGHuDOeWrqaF1G4zTvsjw(ray, num2, RayMasks.DAMAGE_CLIENT, base.player, ref drxteGz0evnNDVy6poswGHA5b);
					try
					{
						bool flag4 = Provider.modeConfigData.Gameplay.Ballistics && DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelaying && raycastInfo.player != null && Ddagemt6Wc3UeyV4EYXNrXcFf.D6CSCOdxWhfs06Bz8veydqeB0.ContainsKey(raycastInfo.player.channel.owner.playerID.steamID.m_SteamID);
						if (flag4)
						{
							bool flag5 = true;
							bool flag6 = DCS4Jf0LRzsehKFc5QOLL06qw.unholdDelayByMouse;
							List<DRxteGz0evnNDVy6poswGHA5b> list = Ddagemt6Wc3UeyV4EYXNrXcFf.D6CSCOdxWhfs06Bz8veydqeB0[raycastInfo.player.channel.owner.playerID.steamID.m_SteamID];
							bool flag7 = DCS4Jf0LRzsehKFc5QOLL06qw.unholdDelayByMouse && DCS4Jf0LRzsehKFc5QOLL06qw.momentalyUnhold && !Input.GetMouseButton(0);
							if (flag7)
							{
								list.Clear();
							}
							else
							{
								bool flag8 = list != null && list.Count != 0;
								if (flag8)
								{
									foreach (DRxteGz0evnNDVy6poswGHA5b drxteGz0evnNDVy6poswGHA5b2 in list)
									{
										bool flag9 = drxteGz0evnNDVy6poswGHA5b2.DTW6zDZRuBKOUBbHU8Vmgx0aD + 2 >= base.equippedGunAsset.ballisticSteps;
										if (flag9)
										{
											flag5 = false;
										}
										bool flag10 = DCS4Jf0LRzsehKFc5QOLL06qw.unholdDelayByMouse && Vector3.Distance(drxteGz0evnNDVy6poswGHA5b2.DlPLxBhsLDGaLNNc4SxCdwdsU, ((Player)drxteGz0evnNDVy6poswGHA5b2.DxXccHaM347WXA3xnOnqbjen9).transform.position + drxteGz0evnNDVy6poswGHA5b2.DhGh12svrQ8q4fj9Ha3JKwjPU) > num2;
										if (flag10)
										{
											flag6 = false;
										}
									}
									bool flag11 = list.Count >= DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelayAmount;
									if (flag11)
									{
										flag5 = false;
										flag6 = false;
									}
									bool key = Input.GetKey(DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelayKeybind);
									if (key)
									{
										flag5 = false;
										flag6 = false;
									}
									bool flag12 = DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelaySeconds > 0f && (flag5 || flag6);
									if (flag12)
									{
										bool flag13 = false;
										foreach (DRxteGz0evnNDVy6poswGHA5b drxteGz0evnNDVy6poswGHA5b3 in list)
										{
											bool flag14 = Time.time - drxteGz0evnNDVy6poswGHA5b3.fireTime < DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelaySeconds;
											if (flag14)
											{
												flag13 = true;
												break;
											}
										}
										bool flag15 = flag13;
										if (flag15)
										{
											goto IL_0CD0;
										}
										flag5 = false;
										flag6 = false;
									}
									bool flag16 = flag5 || flag6;
									if (flag16)
									{
										goto IL_0CD0;
									}
									list.Clear();
								}
							}
						}
					}
					catch
					{
					}
					goto IL_0377;
					IL_0CD0:
					i++;
					i++;
					continue;
					IL_0377:
					bool flag17 = DfU4wrswBK5kLyiyV6mHZwOg8.tracerType == D5VsESizw2NoAi19PtCEVYVgW.BallisticProceed;
					if (flag17)
					{
						DmPNupos8Sd6cXJNxXG0GuRXC.Dpw12PRHvXQP0KXBj1Eibzva2(ray.origin, (raycastInfo.point != Vector3.zero) ? raycastInfo.point : (ray.origin + ray.direction * num2), 0U);
					}
					else
					{
						bool flag18 = drxteGz0evnNDVy6poswGHA5b.DYLaohVXxOaOwWzjUW36IXfDw > 0U;
						if (flag18)
						{
							DmPNupos8Sd6cXJNxXG0GuRXC.DIrqpd5m91qPA2zBgj06qVM7O(ray.origin, (raycastInfo.point != Vector3.zero) ? raycastInfo.point : (ray.origin + ray.direction * num2), drxteGz0evnNDVy6poswGHA5b.DYLaohVXxOaOwWzjUW36IXfDw);
						}
					}
					bool replaceHitLimbToCustom = D5l46jlssr4TRAzUSXzLj0uqu.replaceHitLimbToCustom;
					if (replaceHitLimbToCustom)
					{
						raycastInfo.limb = D5l46jlssr4TRAzUSXzLj0uqu.replacedHitLimb.DG8Vk5LC0j20si9xsv3no34VC();
					}
					EPlayerHit eplayerHit = EPlayerHit.NONE;
					bool flag19 = raycastInfo.player != null && base.equippedGunAsset.playerDamageMultiplier.damage > 1f && (DamageTool.isPlayerAllowedToDamagePlayer(base.player, raycastInfo.player) || base.equippedGunAsset.bypassAllowedToDamagePlayer);
					if (flag19)
					{
						bool flag20 = eplayerHit != EPlayerHit.CRITICAL;
						if (flag20)
						{
							eplayerHit = ((raycastInfo.limb == ELimb.SKULL) ? EPlayerHit.CRITICAL : EPlayerHit.ENTITIY);
						}
						PlayerUI.hitmark(raycastInfo.point, drxteGz0evnNDVy6poswGHA5b.DtXSP8qrVkh0Y0OrHNvtFfxbp.pellets > 1, (raycastInfo.limb == ELimb.SKULL) ? EPlayerHit.CRITICAL : EPlayerHit.ENTITIY);
					}
					else
					{
						bool flag21 = raycastInfo.zombie != null && base.equippedGunAsset.zombieDamageMultiplier.damage > 1f;
						if (flag21)
						{
							EPlayerHit eplayerHit2 = ((raycastInfo.limb == ELimb.SKULL) ? EPlayerHit.CRITICAL : EPlayerHit.ENTITIY);
							bool flag22 = raycastInfo.zombie.getBulletResistance() < 0.2f;
							if (flag22)
							{
								eplayerHit2 = EPlayerHit.GHOST;
							}
							bool flag23 = eplayerHit != EPlayerHit.CRITICAL;
							if (flag23)
							{
								eplayerHit = eplayerHit2;
							}
							PlayerUI.hitmark(raycastInfo.point, drxteGz0evnNDVy6poswGHA5b.DtXSP8qrVkh0Y0OrHNvtFfxbp.pellets > 1, eplayerHit2);
						}
						else
						{
							bool flag24 = raycastInfo.animal != null && base.equippedGunAsset.animalDamageMultiplier.damage > 1f;
							if (flag24)
							{
								bool flag25 = eplayerHit != EPlayerHit.CRITICAL;
								if (flag25)
								{
									eplayerHit = ((raycastInfo.limb == ELimb.SKULL) ? EPlayerHit.CRITICAL : EPlayerHit.ENTITIY);
								}
								PlayerUI.hitmark(raycastInfo.point, drxteGz0evnNDVy6poswGHA5b.DtXSP8qrVkh0Y0OrHNvtFfxbp.pellets > 1, (raycastInfo.limb == ELimb.SKULL) ? EPlayerHit.CRITICAL : EPlayerHit.ENTITIY);
							}
							else
							{
								bool flag26 = raycastInfo.transform != null && raycastInfo.transform.CompareTag("Barricade") && base.equippedGunAsset.barricadeDamage > 1f;
								if (flag26)
								{
									BarricadeDrop barricadeDrop = Dp86EPUU0qiRCgpoTgjzXqsq4.DIoPPqjYZ0uyxggA08QI3k5MK.Invoke(new object[] { raycastInfo.transform });
									bool flag27 = barricadeDrop != null;
									if (flag27)
									{
										ItemBarricadeAsset asset = barricadeDrop.asset;
										bool flag28 = asset != null && asset.canBeDamaged && (asset.isVulnerable || ((ItemWeaponAsset)base.player.equipment.asset).isInvulnerable);
										if (flag28)
										{
											bool flag29 = eplayerHit == EPlayerHit.NONE;
											if (flag29)
											{
												eplayerHit = EPlayerHit.BUILD;
											}
											PlayerUI.hitmark(raycastInfo.point, drxteGz0evnNDVy6poswGHA5b.DtXSP8qrVkh0Y0OrHNvtFfxbp.pellets > 1, EPlayerHit.BUILD);
										}
									}
								}
								else
								{
									bool flag30 = raycastInfo.transform != null && raycastInfo.transform.CompareTag("Structure") && base.equippedGunAsset.structureDamage > 1f;
									if (flag30)
									{
										StructureDrop structureDrop = Dp86EPUU0qiRCgpoTgjzXqsq4.DIb6fTGJsD8aWNShqj5jNHqNl.Invoke(new object[] { raycastInfo.transform });
										bool flag31 = structureDrop != null;
										if (flag31)
										{
											ItemStructureAsset asset2 = structureDrop.asset;
											bool flag32 = asset2 != null && asset2.canBeDamaged && (asset2.isVulnerable || ((ItemWeaponAsset)base.player.equipment.asset).isInvulnerable);
											if (flag32)
											{
												bool flag33 = eplayerHit == EPlayerHit.NONE;
												if (flag33)
												{
													eplayerHit = EPlayerHit.BUILD;
												}
												PlayerUI.hitmark(raycastInfo.point, drxteGz0evnNDVy6poswGHA5b.DtXSP8qrVkh0Y0OrHNvtFfxbp.pellets > 1, EPlayerHit.BUILD);
											}
										}
									}
									else
									{
										bool flag34 = raycastInfo.vehicle != null && !raycastInfo.vehicle.isDead && base.equippedGunAsset.vehicleDamage > 1f;
										if (flag34)
										{
											bool flag35 = raycastInfo.vehicle.asset != null && raycastInfo.vehicle.canBeDamaged && (raycastInfo.vehicle.asset.isVulnerable || ((ItemWeaponAsset)base.player.equipment.asset).isInvulnerable);
											if (flag35)
											{
												bool flag36 = eplayerHit == EPlayerHit.NONE;
												if (flag36)
												{
													eplayerHit = EPlayerHit.BUILD;
												}
												PlayerUI.hitmark(raycastInfo.point, drxteGz0evnNDVy6poswGHA5b.DtXSP8qrVkh0Y0OrHNvtFfxbp.pellets > 1, EPlayerHit.BUILD);
											}
										}
										else
										{
											bool flag37 = raycastInfo.transform != null && raycastInfo.transform.CompareTag("Resource") && base.equippedGunAsset.resourceDamage > 1f;
											if (flag37)
											{
												byte b = 0;
												byte b2 = 0;
												ushort num3 = 0;
												bool flag38 = ResourceManager.tryGetRegion(raycastInfo.transform, out b, out b2, out num3);
												if (flag38)
												{
													ResourceSpawnpoint resourceSpawnpoint = ResourceManager.getResourceSpawnpoint(b, b2, num3);
													bool flag39 = resourceSpawnpoint != null && !resourceSpawnpoint.isDead && base.equippedGunAsset.hasBladeID(resourceSpawnpoint.asset.bladeID);
													if (flag39)
													{
														bool flag40 = eplayerHit == EPlayerHit.NONE;
														if (flag40)
														{
															eplayerHit = EPlayerHit.BUILD;
														}
														PlayerUI.hitmark(raycastInfo.point, drxteGz0evnNDVy6poswGHA5b.DtXSP8qrVkh0Y0OrHNvtFfxbp.pellets > 1, EPlayerHit.BUILD);
													}
												}
											}
											else
											{
												bool flag41 = raycastInfo.transform != null && base.equippedGunAsset.objectDamage > 1f;
												if (flag41)
												{
													InteractableObjectRubble componentInParent = raycastInfo.transform.GetComponentInParent<InteractableObjectRubble>();
													bool flag42 = componentInParent != null;
													if (flag42)
													{
														raycastInfo.transform = componentInParent.transform;
														raycastInfo.section = componentInParent.getSection(raycastInfo.collider.transform);
														bool flag43 = componentInParent.IsSectionIndexValid(raycastInfo.section) && !componentInParent.isSectionDead(raycastInfo.section) && base.equippedGunAsset.hasBladeID(componentInParent.asset.rubbleBladeID) && (componentInParent.asset.rubbleIsVulnerable || ((ItemWeaponAsset)base.player.equipment.asset).isInvulnerable);
														if (flag43)
														{
															bool flag44 = eplayerHit == EPlayerHit.NONE;
															if (flag44)
															{
																eplayerHit = EPlayerHit.BUILD;
															}
															PlayerUI.hitmark(raycastInfo.point, drxteGz0evnNDVy6poswGHA5b.DtXSP8qrVkh0Y0OrHNvtFfxbp.pellets > 1, EPlayerHit.BUILD);
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					bool flag45 = !base.player.input.isRaycastInvalid(raycastInfo);
					if (flag45)
					{
						bool flag46 = eplayerHit > EPlayerHit.NONE;
						if (flag46)
						{
							int num4 = 0;
							bool statistic = Provider.provider.statisticsService.userStatisticsService.getStatistic("Accuracy_Hit", out num4);
							if (statistic)
							{
								Provider.provider.statisticsService.userStatisticsService.setStatistic("Accuracy_Hit", num4 + 1);
							}
							bool flag47 = eplayerHit == EPlayerHit.CRITICAL && Provider.provider.statisticsService.userStatisticsService.getStatistic("Headshots", out num4);
							if (flag47)
							{
								Provider.provider.statisticsService.userStatisticsService.setStatistic("Headshots", num4 + 1);
							}
						}
						try
						{
							ushort num5 = (ushort)(base.equippedGunAsset.playerDamageMultiplier.damage * base.equippedGunAsset.playerDamageMultiplier.skull * DJvM8cpTusqfNUI7GEd3qUz9g.DBOgmdNTrVnAM9tRCMJZUxSK4(raycastInfo.limb, raycastInfo.player));
							DovA0560C5xwc06yYBWmht6vA.D2XDJbj97cXeWm21NhElh6XXL(string.Format("[+] Hit limb {0} with {1} damage", raycastInfo.limb, num5));
							bool flag48 = raycastInfo.player != null;
							if (flag48)
							{
								DmPNupos8Sd6cXJNxXG0GuRXC.DbGurvE8qaYmJsWattQsbJdJB(raycastInfo.point, num5);
							}
							bool flag49 = DfU4wrswBK5kLyiyV6mHZwOg8.tracerType == D5VsESizw2NoAi19PtCEVYVgW.Straight || (DfU4wrswBK5kLyiyV6mHZwOg8.tracerType == D5VsESizw2NoAi19PtCEVYVgW.BallisticMoved && !Provider.modeConfigData.Gameplay.Ballistics);
							if (flag49)
							{
								DmPNupos8Sd6cXJNxXG0GuRXC.Dpw12PRHvXQP0KXBj1Eibzva2(Player.player.look.aim.position, raycastInfo.point, 0U);
							}
						}
						catch
						{
						}
						base.player.input.sendRaycast(raycastInfo, ERaycastInfoUsage.Gun);
						drxteGz0evnNDVy6poswGHA5b.DTW6zDZRuBKOUBbHU8Vmgx0aD = 254;
						goto IL_0CD0;
					}
					float num6 = Physics.gravity.y;
					bool flag50 = drxteGz0evnNDVy6poswGHA5b.D9lgLSEkIwu6WeWBm1t6jaXfu != null;
					if (flag50)
					{
						num6 *= drxteGz0evnNDVy6poswGHA5b.D9lgLSEkIwu6WeWBm1t6jaXfu.ballisticDrop;
					}
					num6 *= base.equippedGunAsset.bulletGravityMultiplier;
					drxteGz0evnNDVy6poswGHA5b.DlPLxBhsLDGaLNNc4SxCdwdsU += drxteGz0evnNDVy6poswGHA5b.DtXuNVaLY13FvGOCTsQVpJfvx * 0.02f;
					bool flag51 = !D5l46jlssr4TRAzUSXzLj0uqu.noBallistics;
					if (flag51)
					{
						drxteGz0evnNDVy6poswGHA5b.DtXuNVaLY13FvGOCTsQVpJfvx = new Vector3(drxteGz0evnNDVy6poswGHA5b.DtXuNVaLY13FvGOCTsQVpJfvx.x, drxteGz0evnNDVy6poswGHA5b.DtXuNVaLY13FvGOCTsQVpJfvx.y + num6 * 0.02f, drxteGz0evnNDVy6poswGHA5b.DtXuNVaLY13FvGOCTsQVpJfvx.z);
						goto IL_0CD0;
					}
					goto IL_0CD0;
				}
				for (int j = Dp86EPUU0qiRCgpoTgjzXqsq4.D36biafXtT7ax1xV7NehAjDcv.Count - 1; j >= 0; j--)
				{
					DRxteGz0evnNDVy6poswGHA5b drxteGz0evnNDVy6poswGHA5b4 = Dp86EPUU0qiRCgpoTgjzXqsq4.D36biafXtT7ax1xV7NehAjDcv[j];
					DRxteGz0evnNDVy6poswGHA5b drxteGz0evnNDVy6poswGHA5b5 = drxteGz0evnNDVy6poswGHA5b4;
					drxteGz0evnNDVy6poswGHA5b5.DTW6zDZRuBKOUBbHU8Vmgx0aD += 1;
					bool flag52 = drxteGz0evnNDVy6poswGHA5b4.DTW6zDZRuBKOUBbHU8Vmgx0aD >= base.equippedGunAsset.ballisticSteps;
					if (flag52)
					{
						Dp86EPUU0qiRCgpoTgjzXqsq4.D36biafXtT7ax1xV7NehAjDcv.RemoveAt(j);
					}
				}
			}
		}
	}

	// Token: 0x060002FC RID: 764 RVA: 0x0002BD14 File Offset: 0x00029F14
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(UseableGun), "tockShoot", new Type[] { })]
	private void DtsuBOziZCh51rrrQhn06ibpa(uint clock)
	{
		Dp86EPUU0qiRCgpoTgjzXqsq4.D1Chserkrj0YhLyvWmXejsmIr.instance = this;
		Dp86EPUU0qiRCgpoTgjzXqsq4.D0q1snckt4JIqnWOsgIYenPuC.instance = this;
		Dp86EPUU0qiRCgpoTgjzXqsq4.DZgjn4fACX06frDKJ8wGhw5Gh.instance = this;
		Dp86EPUU0qiRCgpoTgjzXqsq4.DHlvyNPSCxytfY3IOmjda12Gy.instance = this;
		Dp86EPUU0qiRCgpoTgjzXqsq4.DYxnQOGWUUrXaHcRcUrdQVG3z.instance = this;
		bool flag = (Dp86EPUU0qiRCgpoTgjzXqsq4.D1Chserkrj0YhLyvWmXejsmIr.value == EFiremode.SAFETY) | Dp86EPUU0qiRCgpoTgjzXqsq4.DyWglFMIiUr70JRLF7E2drcqV.Get(this) | Dp86EPUU0qiRCgpoTgjzXqsq4.DA0oK9mLL6Oa2XoVTeJK9B5Nt.Get(this) | Dp86EPUU0qiRCgpoTgjzXqsq4.DB0yqVHclovmhHjQH3zKTuJju.Get(this) | Dp86EPUU0qiRCgpoTgjzXqsq4.DiEQRvqGxQ4QIFrKW7QkJiqqC.Get(this) | (!base.player.equipment.asset.canUseUnderwater && (base.player.stance.isSubmerged || base.player.stance.stance == EPlayerStance.SWIM));
		if (flag)
		{
			Dp86EPUU0qiRCgpoTgjzXqsq4.DZgjn4fACX06frDKJ8wGhw5Gh.value = 0;
			Dp86EPUU0qiRCgpoTgjzXqsq4.DHlvyNPSCxytfY3IOmjda12Gy.value = 0;
			Dp86EPUU0qiRCgpoTgjzXqsq4.D0q1snckt4JIqnWOsgIYenPuC.Set(false);
			Dp86EPUU0qiRCgpoTgjzXqsq4.DYxnQOGWUUrXaHcRcUrdQVG3z.value = false;
		}
		else
		{
			bool flag2 = Dp86EPUU0qiRCgpoTgjzXqsq4.D0q1snckt4JIqnWOsgIYenPuC.Get() || Dp86EPUU0qiRCgpoTgjzXqsq4.DYxnQOGWUUrXaHcRcUrdQVG3z.Get();
			Dp86EPUU0qiRCgpoTgjzXqsq4.DYxnQOGWUUrXaHcRcUrdQVG3z.value = false;
			bool flag3 = Dp86EPUU0qiRCgpoTgjzXqsq4.DHlvyNPSCxytfY3IOmjda12Gy.Get() > 1;
			if (flag3)
			{
				DGZv08vQyz81zrHxUqhmYuCdY<int> dhlvyNPSCxytfY3IOmjda12Gy = Dp86EPUU0qiRCgpoTgjzXqsq4.DHlvyNPSCxytfY3IOmjda12Gy;
				int value = dhlvyNPSCxytfY3IOmjda12Gy.value;
				dhlvyNPSCxytfY3IOmjda12Gy.value = value - 1;
			}
			else
			{
				bool flag4 = Dp86EPUU0qiRCgpoTgjzXqsq4.DHlvyNPSCxytfY3IOmjda12Gy.Get() > 0;
				if (flag4)
				{
					Dp86EPUU0qiRCgpoTgjzXqsq4.DHlvyNPSCxytfY3IOmjda12Gy.value = 0;
					flag2 = true;
				}
				bool flag5 = Dp86EPUU0qiRCgpoTgjzXqsq4.D1Chserkrj0YhLyvWmXejsmIr.value == EFiremode.SEMI;
				if (flag5)
				{
					Dp86EPUU0qiRCgpoTgjzXqsq4.D0q1snckt4JIqnWOsgIYenPuC.Set(false);
				}
				bool flag6 = Dp86EPUU0qiRCgpoTgjzXqsq4.D1Chserkrj0YhLyvWmXejsmIr.value == EFiremode.BURST;
				if (flag6)
				{
					Dp86EPUU0qiRCgpoTgjzXqsq4.D0q1snckt4JIqnWOsgIYenPuC.Set(false);
					bool flag7 = flag2;
					if (flag7)
					{
						Dp86EPUU0qiRCgpoTgjzXqsq4.DZgjn4fACX06frDKJ8wGhw5Gh.value += base.equippedGunAsset.bursts;
					}
				}
				bool correctFirerateToWork = D5l46jlssr4TRAzUSXzLj0uqu.correctFirerateToWork;
				int num;
				if (correctFirerateToWork)
				{
					num = (int)base.equippedGunAsset.firerate - Mathf.Min(D5l46jlssr4TRAzUSXzLj0uqu.firerateDecrease, (int)((base.equippedGunAsset.firerate + 1) % 4));
				}
				else
				{
					num = (int)base.equippedGunAsset.firerate - D5l46jlssr4TRAzUSXzLj0uqu.firerateDecrease;
				}
				bool flag8 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.Get(this).sightAsset != null;
				if (flag8)
				{
					num -= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.Get(this).sightAsset.FirerateOffset;
				}
				bool flag9 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.Get(this).tacticalAsset != null && Dp86EPUU0qiRCgpoTgjzXqsq4.shouldEnableTacticalStats;
				if (flag9)
				{
					num -= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.Get(this).tacticalAsset.FirerateOffset;
				}
				bool flag10 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.Get(this).gripAsset != null;
				if (flag10)
				{
					num -= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.Get(this).gripAsset.FirerateOffset;
				}
				bool flag11 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.Get(this).barrelAsset != null;
				if (flag11)
				{
					num -= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.Get(this).barrelAsset.FirerateOffset;
				}
				bool flag12 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.Get(this).magazineAsset != null;
				if (flag12)
				{
					num -= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.Get(this).magazineAsset.FirerateOffset;
				}
				num = Mathf.Max(num, 0);
				bool flag13 = (ulong)(clock - Dp86EPUU0qiRCgpoTgjzXqsq4.D48vIzlJTtGrz3izFt4xYc9jw.Get(this)) > (ulong)((long)num);
				if (flag13)
				{
					bool flag14 = Dp86EPUU0qiRCgpoTgjzXqsq4.DZgjn4fACX06frDKJ8wGhw5Gh.Get() > 0;
					if (flag14)
					{
						DGZv08vQyz81zrHxUqhmYuCdY<int> dzgjn4fACX06frDKJ8wGhw5Gh = Dp86EPUU0qiRCgpoTgjzXqsq4.DZgjn4fACX06frDKJ8wGhw5Gh;
						int value2 = dzgjn4fACX06frDKJ8wGhw5Gh.value;
						dzgjn4fACX06frDKJ8wGhw5Gh.value = value2 - 1;
					}
					bool flag15 = Dp86EPUU0qiRCgpoTgjzXqsq4.D0wfKQeI1PTkJOuEzSANt42Wo.Get(this) >= base.equippedGunAsset.ammoPerShot;
					if (flag15)
					{
						Dp86EPUU0qiRCgpoTgjzXqsq4.Dh3JXfPi3w0xIxNjxVbGOqk9A.Set(this, true);
						Dp86EPUU0qiRCgpoTgjzXqsq4.D48vIzlJTtGrz3izFt4xYc9jw.Set(this, clock);
						base.player.equipment.isBusy = true;
						this.DQIfDjln1ZmCYrEPnCbUc9au8();
					}
					else
					{
						bool isServer = Provider.isServer;
						if (isServer)
						{
							Dp86EPUU0qiRCgpoTgjzXqsq4.Dw4jNdmhAPd0QBXIh0VnNlIEL.D8bo6z6P4C0fkdfFioOF82Ftk(new object[] { base.transform.position });
						}
						Dp86EPUU0qiRCgpoTgjzXqsq4.DZgjn4fACX06frDKJ8wGhw5Gh.value = 0;
						Dp86EPUU0qiRCgpoTgjzXqsq4.D0q1snckt4JIqnWOsgIYenPuC.Set(false);
					}
				}
			}
		}
	}

	// Token: 0x060002FD RID: 765 RVA: 0x0002C15C File Offset: 0x0002A35C
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(UseableGun), "fire", new Type[] { })]
	private void DQIfDjln1ZmCYrEPnCbUc9au8()
	{
		try
		{
			bool flag = !base.channel.IsLocalPlayer || Provider.isServer;
			if (flag)
			{
				DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, Array.Empty<object>());
			}
			else
			{
				bool flag2 = Ddagemt6Wc3UeyV4EYXNrXcFf.D7Zl9UZ09KSFYqnGFRb0oyhA1();
				bool flag3 = DCS4Jf0LRzsehKFc5QOLL06qw.enableAim && flag2;
				if (flag3)
				{
					Ddagemt6Wc3UeyV4EYXNrXcFf.DlajGRkTiYeNVG1q0zkkpQJw9();
				}
				float num = (float)base.player.equipment.quality / 100f;
				Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.RefereshFieldValue(Dp86EPUU0qiRCgpoTgjzXqsq4.gun);
				bool flag4 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.magazineAsset != null;
				if (flag4)
				{
					Dp86EPUU0qiRCgpoTgjzXqsq4.D0wfKQeI1PTkJOuEzSANt42Wo.instance = this;
					bool enableAimbot = DCS4Jf0LRzsehKFc5QOLL06qw.enableAimbot;
					if (enableAimbot)
					{
						Ddagemt6Wc3UeyV4EYXNrXcFf.DTBS9x0Wqj5VvkJcr5w7pj60m(false);
					}
					bool flag5 = !base.equippedGunAsset.infiniteAmmo;
					if (flag5)
					{
						bool flag6 = Dp86EPUU0qiRCgpoTgjzXqsq4.D0wfKQeI1PTkJOuEzSANt42Wo.Get() < base.equippedGunAsset.ammoPerShot;
						if (flag6)
						{
							throw new Exception("Insufficient ammo");
						}
						DGZv08vQyz81zrHxUqhmYuCdY<byte> d0wfKQeI1PTkJOuEzSANt42Wo = Dp86EPUU0qiRCgpoTgjzXqsq4.D0wfKQeI1PTkJOuEzSANt42Wo;
						DGZv08vQyz81zrHxUqhmYuCdY<byte> dgzv08vQyz81zrHxUqhmYuCdY = d0wfKQeI1PTkJOuEzSANt42Wo;
						dgzv08vQyz81zrHxUqhmYuCdY.value -= base.equippedGunAsset.ammoPerShot;
						bool flag7 = base.equippedGunAsset.action != EAction.String;
						if (flag7)
						{
							base.player.equipment.state[10] = Dp86EPUU0qiRCgpoTgjzXqsq4.D0wfKQeI1PTkJOuEzSANt42Wo.Get();
							base.player.equipment.updateState();
						}
					}
					bool flag8 = base.channel.IsLocalPlayer && Dp86EPUU0qiRCgpoTgjzXqsq4.D0wfKQeI1PTkJOuEzSANt42Wo.Get() < base.equippedGunAsset.ammoPerShot;
					if (flag8)
					{
						PlayerUI.message(EPlayerMessage.RELOAD, "", 2f);
					}
					bool flag9 = !base.isAiming;
					if (flag9)
					{
						base.player.equipment.uninspect();
					}
					bool flag10 = !base.player.look.isCam && base.player.look.perspective == EPlayerPerspective.THIRD;
					if (flag10)
					{
						RaycastHit raycastHit = default(RaycastHit);
						Physics.Raycast(new Ray(MainCamera.instance.transform.position, MainCamera.instance.transform.forward), out raycastHit, 512f, RayMasks.DAMAGE_CLIENT);
						bool flag11 = raycastHit.transform != null;
						if (flag11)
						{
							bool flag12 = Vector3.Dot(raycastHit.point - base.player.look.aim.position, MainCamera.instance.transform.forward) > 0f;
							if (flag12)
							{
								base.player.look.aim.rotation = Quaternion.LookRotation(raycastHit.point - base.player.look.aim.position);
							}
						}
						else
						{
							base.player.look.aim.rotation = Quaternion.LookRotation(MainCamera.instance.transform.position + MainCamera.instance.transform.forward * 512f - base.player.look.aim.position);
						}
					}
					object obj = ((DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim && flag2) ? Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC : null);
					Transform transform = ((obj != null) ? Ddagemt6Wc3UeyV4EYXNrXcFf.DaDfS7pW7z2hwpjq5z9bGs138(obj.Ddqyz74I7QJMuE9u85cwfj76F(), obj) : null);
					bool flag13 = base.equippedGunAsset.projectile == null;
					if (flag13)
					{
						bool flag14 = obj != null;
						Quaternion quaternion;
						if (flag14)
						{
							switch (DCS4Jf0LRzsehKFc5QOLL06qw.silentAimType)
							{
							case DokdtlMHqRTX0KbeCtveFDTNT.Aim:
								quaternion = DmErKmxWRjHNSG8p8mCUQIUbM.DMyVJrZKISQhUzJ303OEX5wMT(base.player.look.aim.position, transform.position);
								break;
							case DokdtlMHqRTX0KbeCtveFDTNT.Distance:
								quaternion = DmErKmxWRjHNSG8p8mCUQIUbM.DMyVJrZKISQhUzJ303OEX5wMT(base.player.look.aim.position, transform.position);
								break;
							case DokdtlMHqRTX0KbeCtveFDTNT.Sphere:
							{
								Vector3 vector;
								transform.position.D7jI6EoRIlVgppmv8T7nYuaAV(Player.player.look.getEyesPosition(), out vector, true);
								quaternion = DmErKmxWRjHNSG8p8mCUQIUbM.DMyVJrZKISQhUzJ303OEX5wMT(base.player.look.aim.position, (vector != Vector3.zero) ? vector : transform.position);
								break;
							}
							default:
								quaternion = Quaternion.identity;
								break;
							}
						}
						else
						{
							quaternion = base.player.look.aim.rotation;
						}
						EPlayerPerspective perspective = base.player.look.perspective;
						bool flag15 = false;
						if (flag15)
						{
							Quaternion quaternion2 = Quaternion.Euler(base.player.animator.recoilViewmodelCameraRotation.currentPosition);
							quaternion *= quaternion2;
						}
						float num2 = Dp86EPUU0qiRCgpoTgjzXqsq4.Di4PPH1jj6EaD4GKAcSZ28OU5(num, Dp86EPUU0qiRCgpoTgjzXqsq4.DKuTGEMdACdDqpeKiNdJ9f6ym.InvokeI(this, Array.Empty<object>()));
						byte pellets = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.magazineAsset.pellets;
						for (byte b = 0; b < pellets; b += 1)
						{
							DRxteGz0evnNDVy6poswGHA5b drxteGz0evnNDVy6poswGHA5b = new DRxteGz0evnNDVy6poswGHA5b();
							bool flag16 = DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim && flag2;
							if (flag16)
							{
								drxteGz0evnNDVy6poswGHA5b.DxXccHaM347WXA3xnOnqbjen9 = Ddagemt6Wc3UeyV4EYXNrXcFf.aimObjective.DnuBpXW8r7IgW3DCiPdbWlBGC;
								drxteGz0evnNDVy6poswGHA5b.DT12cPk3APSOLJFMrpMNCexox = Ddagemt6Wc3UeyV4EYXNrXcFf.aimObjective.DKr6XbLZDMiJmmxABXHlfTTLz;
								try
								{
									bool flag17 = drxteGz0evnNDVy6poswGHA5b != null && drxteGz0evnNDVy6poswGHA5b.DT12cPk3APSOLJFMrpMNCexox == Dr5qliNNQh3jZolh9fn7SFNyi.Player && DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelaying;
									if (flag17)
									{
										List<DRxteGz0evnNDVy6poswGHA5b> list;
										bool flag18 = !Ddagemt6Wc3UeyV4EYXNrXcFf.D6CSCOdxWhfs06Bz8veydqeB0.TryGetValue(((Player)drxteGz0evnNDVy6poswGHA5b.DxXccHaM347WXA3xnOnqbjen9).channel.owner.playerID.steamID.m_SteamID, out list);
										if (flag18)
										{
											Ddagemt6Wc3UeyV4EYXNrXcFf.D6CSCOdxWhfs06Bz8veydqeB0.Add(((Player)drxteGz0evnNDVy6poswGHA5b.DxXccHaM347WXA3xnOnqbjen9).channel.owner.playerID.steamID.m_SteamID, list = new List<DRxteGz0evnNDVy6poswGHA5b>());
										}
										else
										{
											bool flag19 = list == null;
											if (flag19)
											{
												Ddagemt6Wc3UeyV4EYXNrXcFf.D6CSCOdxWhfs06Bz8veydqeB0[((Player)drxteGz0evnNDVy6poswGHA5b.DxXccHaM347WXA3xnOnqbjen9).channel.owner.playerID.steamID.m_SteamID] = new List<DRxteGz0evnNDVy6poswGHA5b>();
											}
										}
										drxteGz0evnNDVy6poswGHA5b.fireTime = Time.time;
										list.Add(drxteGz0evnNDVy6poswGHA5b);
									}
								}
								catch
								{
								}
							}
							drxteGz0evnNDVy6poswGHA5b.DUVyxU3C2UsHIsOAf3eJXzNXX = base.player.look.aim.position;
							bool flag20 = DfU4wrswBK5kLyiyV6mHZwOg8.tracerType == D5VsESizw2NoAi19PtCEVYVgW.BallisticMoved;
							if (flag20)
							{
								drxteGz0evnNDVy6poswGHA5b.DYLaohVXxOaOwWzjUW36IXfDw = DmPNupos8Sd6cXJNxXG0GuRXC.Dpw12PRHvXQP0KXBj1Eibzva2(drxteGz0evnNDVy6poswGHA5b.DUVyxU3C2UsHIsOAf3eJXzNXX, drxteGz0evnNDVy6poswGHA5b.DUVyxU3C2UsHIsOAf3eJXzNXX, 0U).DTaN0Zd5kEDhBTrt2ZZtoSHLR;
							}
							drxteGz0evnNDVy6poswGHA5b.DlPLxBhsLDGaLNNc4SxCdwdsU = drxteGz0evnNDVy6poswGHA5b.DUVyxU3C2UsHIsOAf3eJXzNXX;
							Vector3 vector2 = quaternion * DNoGuLU1kj4bSLgMxtYMC6ec2.DM04jC5Ob7xBV8mkIjo7bHLy2(num2);
							drxteGz0evnNDVy6poswGHA5b.DtXuNVaLY13FvGOCTsQVpJfvx = vector2 * base.equippedGunAsset.muzzleVelocity;
							drxteGz0evnNDVy6poswGHA5b.DYW5cKdP9QqQqXjvCwXMLRO1p = b;
							drxteGz0evnNDVy6poswGHA5b.D9lgLSEkIwu6WeWBm1t6jaXfu = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.barrelAsset;
							drxteGz0evnNDVy6poswGHA5b.DtXSP8qrVkh0Y0OrHNvtFfxbp = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.magazineAsset;
							Dp86EPUU0qiRCgpoTgjzXqsq4.D36biafXtT7ax1xV7NehAjDcv.Add(drxteGz0evnNDVy6poswGHA5b);
							int num3 = 0;
							bool statistic = Provider.provider.statisticsService.userStatisticsService.getStatistic("Accuracy_Shot", out num3);
							if (statistic)
							{
								Provider.provider.statisticsService.userStatisticsService.setStatistic("Accuracy_Shot", num3 + 1);
							}
							bool isAiming = base.isAiming;
							if (isAiming)
							{
								base.equippedGunAsset.recoilMin_x *= base.equippedGunAsset.aimingRecoilMultiplier;
								base.equippedGunAsset.recoilMax_x *= base.equippedGunAsset.aimingRecoilMultiplier;
							}
							bool flag21 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.sightAsset != null;
							if (flag21)
							{
								base.equippedGunAsset.shakeMin_x *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.sightAsset.shake;
								base.equippedGunAsset.shakeMin_y *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.sightAsset.shake;
								base.equippedGunAsset.shakeMin_z *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.sightAsset.shake;
							}
							bool flag22 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.tacticalAsset != null && Dp86EPUU0qiRCgpoTgjzXqsq4.shouldEnableTacticalStats;
							if (flag22)
							{
								base.equippedGunAsset.shakeMin_x *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.tacticalAsset.shake;
								base.equippedGunAsset.shakeMin_y *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.tacticalAsset.shake;
								base.equippedGunAsset.shakeMin_z *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.tacticalAsset.shake;
							}
							bool flag23 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.gripAsset != null && (!Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.gripAsset.ShouldOnlyAffectAimWhileProne || base.player.stance.stance == EPlayerStance.PRONE);
							if (flag23)
							{
								base.equippedGunAsset.shakeMin_x *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.gripAsset.shake;
								base.equippedGunAsset.shakeMin_y *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.gripAsset.shake;
								base.equippedGunAsset.shakeMin_z *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.gripAsset.shake;
							}
							bool flag24 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.barrelAsset != null;
							if (flag24)
							{
								base.equippedGunAsset.shakeMin_x *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.barrelAsset.shake;
								base.equippedGunAsset.shakeMin_y *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.barrelAsset.shake;
								base.equippedGunAsset.shakeMin_z *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.barrelAsset.shake;
							}
							bool flag25 = Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.magazineAsset != null;
							if (flag25)
							{
								base.equippedGunAsset.shakeMin_x *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.magazineAsset.shake;
								base.equippedGunAsset.shakeMin_y *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.magazineAsset.shake;
								base.equippedGunAsset.shakeMin_z *= Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.magazineAsset.shake;
							}
							bool flag26 = base.player.stance.stance == EPlayerStance.CROUCH;
							if (flag26)
							{
								base.equippedGunAsset.shakeMin_x *= Dp86EPUU0qiRCgpoTgjzXqsq4.SHAKE_CROUCH;
								base.equippedGunAsset.shakeMin_y *= Dp86EPUU0qiRCgpoTgjzXqsq4.SHAKE_CROUCH;
								base.equippedGunAsset.shakeMin_z *= Dp86EPUU0qiRCgpoTgjzXqsq4.SHAKE_CROUCH;
							}
							else
							{
								bool flag27 = base.player.stance.stance == EPlayerStance.PRONE;
								if (flag27)
								{
									base.equippedGunAsset.shakeMin_x *= Dp86EPUU0qiRCgpoTgjzXqsq4.SHAKE_PRONE;
									base.equippedGunAsset.shakeMin_y *= Dp86EPUU0qiRCgpoTgjzXqsq4.SHAKE_PRONE;
									base.equippedGunAsset.shakeMin_z *= Dp86EPUU0qiRCgpoTgjzXqsq4.SHAKE_PRONE;
								}
							}
							base.player.look.recoil(D5l46jlssr4TRAzUSXzLj0uqu.recoilMultiplier, D5l46jlssr4TRAzUSXzLj0uqu.recoilMultiplier, base.equippedGunAsset.recover_x, base.equippedGunAsset.recover_y);
						}
					}
					else
					{
						Vector3 vector3 = ((DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim && Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC != null) ? DmErKmxWRjHNSG8p8mCUQIUbM.DWTJZMUdPCnE0MBXkaJ5OA6m0(base.player.transform.position, Ddagemt6Wc3UeyV4EYXNrXcFf.DaDfS7pW7z2hwpjq5z9bGs138(Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DKr6XbLZDMiJmmxABXHlfTTLz, Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC).position) : base.player.look.aim.forward);
						RaycastInfo raycastInfo = DamageTool.raycast(new Ray(base.player.look.aim.position, vector3), 512f, RayMasks.DAMAGE_CLIENT, base.player);
						bool flag28 = raycastInfo.transform != null;
						if (flag28)
						{
							base.player.input.sendRaycast(raycastInfo, ERaycastInfoUsage.Gun);
						}
						Vector3 vector4 = base.player.look.aim.position;
						RaycastHit raycastHit2 = default(RaycastHit);
						bool flag29 = !Physics.Raycast(new Ray(vector4, vector3), out raycastHit2, 1f, RayMasks.DAMAGE_SERVER);
						if (flag29)
						{
							vector4 += vector3;
						}
						Dp86EPUU0qiRCgpoTgjzXqsq4.D0N7l2XHHMKWijfqBKyg6ZakB.DGHrF0Ht2QRxL0NBgNHj6ZpZX(this, new object[]
						{
							vector4,
							vector3,
							Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.barrelAsset,
							Dp86EPUU0qiRCgpoTgjzXqsq4.D2ivYMEk9e5zv9HXed3lhoZDf.fldValue.magazineAsset
						});
						int num4 = 0;
						bool statistic2 = Provider.provider.statisticsService.userStatisticsService.getStatistic("Accuracy_Shot", out num4);
						if (statistic2)
						{
							Provider.provider.statisticsService.userStatisticsService.setStatistic("Accuracy_Shot", num4 + 1);
						}
					}
					Dp86EPUU0qiRCgpoTgjzXqsq4.DFvefbnizKSkKJDvQKyuavu33.DGHrF0Ht2QRxL0NBgNHj6ZpZX(this, Array.Empty<object>());
					bool flag30 = base.equippedGunAsset.projectile == null;
					if (flag30)
					{
						Dp86EPUU0qiRCgpoTgjzXqsq4.DMlNYl105CtG1k0jKrVgnHDVq.DGHrF0Ht2QRxL0NBgNHj6ZpZX(this, Array.Empty<object>());
					}
				}
			}
		}
		catch (Exception ex)
		{
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.Message);
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.StackTrace);
		}
	}

	// Token: 0x060002FE RID: 766 RVA: 0x0002CF00 File Offset: 0x0002B100
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(UseableGun), "GetInterpolatedAimAlpha", new Type[] { })]
	private static float DOAxO9jVbD2eS8mBKEzPjzvGx(UseableGun instance)
	{
		bool flag = !D5l46jlssr4TRAzUSXzLj0uqu.instantAiming || !instance.isAiming;
		float num;
		if (flag)
		{
			num = DA1dZHkBmPouE1WuakM2TW4QH.DV5fBuuwwtgOKLKyiAmdzlRoa<float>(instance, Array.Empty<object>());
		}
		else
		{
			num = 1f;
		}
		return num;
	}

	// Token: 0x060002FF RID: 767 RVA: 0x0002CF40 File Offset: 0x0002B140
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(UseableGun), "trace", BindingFlags.Instance | BindingFlags.NonPublic, new Type[] { })]
	public static void Dvyzv60l8v7l68sPDoOC80p9s(UseableGun instance, Vector3 pos, Vector3 dir)
	{
		bool flag = !DfU4wrswBK5kLyiyV6mHZwOg8.disallowWeaponTraces;
		if (flag)
		{
			DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(instance, new object[] { pos, dir });
		}
	}

	// Token: 0x06000300 RID: 768 RVA: 0x0002CF7C File Offset: 0x0002B17C
	[D7n4xFAr5Ww2MTmhOgCA0J2i8(typeof(UseableGun), "applyRecoilMagnitudeModifiers", new Type[] { })]
	private void DhrpXUQPRRPOnB8Qhnq4h8R0E(ref float value)
	{
		bool flag = Player.player.stance.stance == EPlayerStance.SPRINT;
		if (flag)
		{
			value *= base.equippedGunAsset.recoilSprint;
		}
		else
		{
			bool flag2 = Player.player.stance.stance == EPlayerStance.CROUCH;
			if (flag2)
			{
				value *= base.equippedGunAsset.recoilCrouch;
			}
			else
			{
				bool flag3 = Player.player.stance.stance == EPlayerStance.PRONE;
				if (flag3)
				{
					value *= base.equippedGunAsset.recoilProne;
				}
				else
				{
					bool flag4 = Player.player.stance.stance == EPlayerStance.SWIM;
					if (flag4)
					{
						value *= base.equippedGunAsset.recoilSwimming;
					}
				}
			}
		}
		bool flag5 = !Player.player.movement.isGrounded;
		if (flag5)
		{
			value *= base.equippedGunAsset.recoilMidair;
		}
		value *= D5l46jlssr4TRAzUSXzLj0uqu.recoilMultiplier;
	}

	// Token: 0x06000301 RID: 769 RVA: 0x0002D064 File Offset: 0x0002B264
	private void DzLwbDQfDHjJIWPAcI0S3sfj3(ref float value)
	{
		bool flag = Player.player.stance.stance == EPlayerStance.SPRINT;
		if (flag)
		{
			value *= base.equippedGunAsset.recoilSprint;
		}
		else
		{
			bool flag2 = Player.player.stance.stance == EPlayerStance.CROUCH;
			if (flag2)
			{
				value *= base.equippedGunAsset.recoilCrouch;
			}
			else
			{
				bool flag3 = Player.player.stance.stance == EPlayerStance.PRONE;
				if (flag3)
				{
					value *= base.equippedGunAsset.recoilProne;
				}
				else
				{
					bool flag4 = Player.player.stance.stance == EPlayerStance.SWIM;
					if (flag4)
					{
						value *= base.equippedGunAsset.recoilSwimming;
					}
				}
			}
		}
		bool flag5 = !Player.player.movement.isGrounded;
		if (flag5)
		{
			value *= base.equippedGunAsset.recoilMidair;
		}
	}

	// Token: 0x0400034D RID: 845
	public static DfHljpul4p88ytp3JZtoSRq7w<float> DnXVGtKMTwMpBVK0RW4ZAcnXP = new DfHljpul4p88ytp3JZtoSRq7w<float>(typeof(UseableGun), "GetInterpolatedAimAlpha", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400034E RID: 846
	public static DfHljpul4p88ytp3JZtoSRq7w<float> DKuTGEMdACdDqpeKiNdJ9f6ym = new DfHljpul4p88ytp3JZtoSRq7w<float>(typeof(UseableGun), "GetSimulationAimAlpha", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400034F RID: 847
	public static DfHljpul4p88ytp3JZtoSRq7w<BarricadeDrop> DIoPPqjYZ0uyxggA08QI3k5MK = new DfHljpul4p88ytp3JZtoSRq7w<BarricadeDrop>(typeof(BarricadeDrop), "FindByRootFast", BindingFlags.Static | BindingFlags.NonPublic);

	// Token: 0x04000350 RID: 848
	public static DfHljpul4p88ytp3JZtoSRq7w<StructureDrop> DIb6fTGJsD8aWNShqj5jNHqNl = new DfHljpul4p88ytp3JZtoSRq7w<StructureDrop>(typeof(StructureDrop), "FindByRootFast", BindingFlags.Static | BindingFlags.NonPublic);

	// Token: 0x04000351 RID: 849
	public static DQyA1nzDa0rZuYtgcLmIWOUf8 DFvefbnizKSkKJDvQKyuavu33 = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(UseableGun), "updateInfo", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000352 RID: 850
	public static DQyA1nzDa0rZuYtgcLmIWOUf8 DMlNYl105CtG1k0jKrVgnHDVq = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(UseableGun), "shoot", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000353 RID: 851
	public static DQyA1nzDa0rZuYtgcLmIWOUf8 D0N7l2XHHMKWijfqBKyg6ZakB = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(UseableGun), "project", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000354 RID: 852
	public static DQyA1nzDa0rZuYtgcLmIWOUf8 DVg9tH4zZwtMx0A4dr4exMVDE = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(UseableGun), "trace", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000355 RID: 853
	public static DQyA1nzDa0rZuYtgcLmIWOUf8 DurqQ0Ykxv8CXBaGcxmqFqfp5 = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(UseableGun), "PlayFlybyAudio", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000356 RID: 854
	public static DQyA1nzDa0rZuYtgcLmIWOUf8 Dw4jNdmhAPd0QBXIh0VnNlIEL = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(EffectManager), "TriggerFiremodeEffect", BindingFlags.Static | BindingFlags.NonPublic);

	// Token: 0x04000357 RID: 855
	public static DGZv08vQyz81zrHxUqhmYuCdY<Attachments> D2ivYMEk9e5zv9HXed3lhoZDf = new DGZv08vQyz81zrHxUqhmYuCdY<Attachments>(typeof(UseableGun), "thirdAttachments", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000358 RID: 856
	public static DGZv08vQyz81zrHxUqhmYuCdY<bool> DzSSPqSltJQFD6sMZK9Jc2CZ0 = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(UseableGun), "interact", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000359 RID: 857
	public static DGZv08vQyz81zrHxUqhmYuCdY<byte> D0wfKQeI1PTkJOuEzSANt42Wo = new DGZv08vQyz81zrHxUqhmYuCdY<byte>(typeof(UseableGun), "ammo", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400035A RID: 858
	public static DGZv08vQyz81zrHxUqhmYuCdY<EFiremode> D1Chserkrj0YhLyvWmXejsmIr = new DGZv08vQyz81zrHxUqhmYuCdY<EFiremode>(typeof(UseableGun), "firemode", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400035B RID: 859
	public static DGZv08vQyz81zrHxUqhmYuCdY<bool> D0q1snckt4JIqnWOsgIYenPuC = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(UseableGun), "isShooting", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400035C RID: 860
	public static DGZv08vQyz81zrHxUqhmYuCdY<bool> DyWglFMIiUr70JRLF7E2drcqV = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(UseableGun), "isReloading", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400035D RID: 861
	public static DGZv08vQyz81zrHxUqhmYuCdY<bool> DA0oK9mLL6Oa2XoVTeJK9B5Nt = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(UseableGun), "isHammering", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400035E RID: 862
	public static DGZv08vQyz81zrHxUqhmYuCdY<bool> DB0yqVHclovmhHjQH3zKTuJju = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(UseableGun), "isUnjamming", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400035F RID: 863
	public static DGZv08vQyz81zrHxUqhmYuCdY<bool> DiEQRvqGxQ4QIFrKW7QkJiqqC = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(UseableGun), "isAttaching", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000360 RID: 864
	public static DGZv08vQyz81zrHxUqhmYuCdY<bool> DYxnQOGWUUrXaHcRcUrdQVG3z = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(UseableGun), "wasTriggerJustPulled", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000361 RID: 865
	public static DGZv08vQyz81zrHxUqhmYuCdY<bool> Dh3JXfPi3w0xIxNjxVbGOqk9A = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(UseableGun), "isFired", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000362 RID: 866
	public static DGZv08vQyz81zrHxUqhmYuCdY<int> DZgjn4fACX06frDKJ8wGhw5Gh = new DGZv08vQyz81zrHxUqhmYuCdY<int>(typeof(UseableGun), "bursts", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000363 RID: 867
	public static DGZv08vQyz81zrHxUqhmYuCdY<int> DHlvyNPSCxytfY3IOmjda12Gy = new DGZv08vQyz81zrHxUqhmYuCdY<int>(typeof(UseableGun), "fireDelayCounter", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000364 RID: 868
	public static DGZv08vQyz81zrHxUqhmYuCdY<uint> D48vIzlJTtGrz3izFt4xYc9jw = new DGZv08vQyz81zrHxUqhmYuCdY<uint>(typeof(UseableGun), "lastFire", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000365 RID: 869
	private static readonly float SHAKE_CROUCH = 0.85f;

	// Token: 0x04000366 RID: 870
	private static readonly float SHAKE_PRONE = 0.7f;

	// Token: 0x04000367 RID: 871
	public static List<DRxteGz0evnNDVy6poswGHA5b> D36biafXtT7ax1xV7NehAjDcv = new List<DRxteGz0evnNDVy6poswGHA5b>();
}
