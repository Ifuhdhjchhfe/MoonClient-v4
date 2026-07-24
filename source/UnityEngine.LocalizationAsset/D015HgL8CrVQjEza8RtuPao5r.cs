using System;
using UnityEngine;

// Token: 0x02000002 RID: 2
public class D015HgL8CrVQjEza8RtuPao5r : DOEkZ1zoBEuvfUmOs9QSpfX0X
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	public override int SortId()
	{
		return 1;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002064 File Offset: 0x00000264
	public override string GetName()
	{
		return "Aimbot";
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000207C File Offset: 0x0000027C
	public override DYIPJORHeVCfbpocFHvJty4OE GetTabCounts()
	{
		return DYIPJORHeVCfbpocFHvJty4OE.Three;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002090 File Offset: 0x00000290
	public override void DoTab(DYIPJORHeVCfbpocFHvJty4OE tc)
	{
		bool flag = tc == DYIPJORHeVCfbpocFHvJty4OE.One;
		if (flag)
		{
			base.DGLNJE6Ld056OViYFjOM7IeMS("Slient Aimbot");
			this.DpfGDBlHnK5h0gSJLdn3JseV7 = GUILayout.BeginScrollView(this.DpfGDBlHnK5h0gSJLdn3JseV7, Array.Empty<GUILayoutOption>());
			DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim, "Enable Silent Aimbot", Array.Empty<GUILayoutOption>());
			bool enableSilentAim = DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim;
			if (enableSilentAim)
			{
				DCS4Jf0LRzsehKFc5QOLL06qw.straightRaycasting = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.straightRaycasting, "Enable Aimbot Raycasting", Array.Empty<GUILayoutOption>());
			}
			DCS4Jf0LRzsehKFc5QOLL06qw.enableMeleeSilentAim = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.enableMeleeSilentAim, "Enable Melee Silent Aimbot", Array.Empty<GUILayoutOption>());
			bool flag2 = DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim || DCS4Jf0LRzsehKFc5QOLL06qw.enableMeleeSilentAim;
			if (flag2)
			{
				DCS4Jf0LRzsehKFc5QOLL06qw.hitPointToTransform = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.hitPointToTransform, "Set target hitbox to root bone", Array.Empty<GUILayoutOption>());
				bool flag3 = !DCS4Jf0LRzsehKFc5QOLL06qw.hitPointToTransform;
				if (flag3)
				{
					DCS4Jf0LRzsehKFc5QOLL06qw.bestSilentAimPartPreselective = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.bestSilentAimPartPreselective, "Target Best Hitbox", Array.Empty<GUILayoutOption>());
				}
				bool flag4 = !DCS4Jf0LRzsehKFc5QOLL06qw.hitPointToTransform && !DCS4Jf0LRzsehKFc5QOLL06qw.bestSilentAimPartPreselective && DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Aimbot Aimpoints: " + DCS4Jf0LRzsehKFc5QOLL06qw.silentAimHitPointLimb.Dq6eNqgaZn6PYh50FMK07NzNt(), -1, true, null);
				if (flag4)
				{
					DCS4Jf0LRzsehKFc5QOLL06qw.silentAimHitPointLimb = DCS4Jf0LRzsehKFc5QOLL06qw.silentAimHitPointLimb.D5GDf6NDOOXtOKVhMfOJBmfW5<Drvin9V0cgPlOe7ofbFCim7y0>();
				}
				DCS4Jf0LRzsehKFc5QOLL06qw.silentAimLimb = DCS4Jf0LRzsehKFc5QOLL06qw.silentAimLimb.DdoC7WUc7IFAmnWoLcSWPOXFw("Silent Aimbot Hitbox: ", DCS4Jf0LRzsehKFc5QOLL06qw.silentAimLimb.Dq6eNqgaZn6PYh50FMK07NzNt());
				bool flag5 = DCS4Jf0LRzsehKFc5QOLL06qw.silentAimLimb == Drvin9V0cgPlOe7ofbFCim7y0.Random;
				if (flag5)
				{
					DCS4Jf0LRzsehKFc5QOLL06qw.randomLimbHeadHitChance = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Random limb head hit chance: ", DCS4Jf0LRzsehKFc5QOLL06qw.randomLimbHeadHitChance, 0, 100, -1);
				}
				DCS4Jf0LRzsehKFc5QOLL06qw.silentAimType = DCS4Jf0LRzsehKFc5QOLL06qw.silentAimType.DdoC7WUc7IFAmnWoLcSWPOXFw("Silent Aimbot Method: ", DCS4Jf0LRzsehKFc5QOLL06qw.silentAimType.DfTb0KIxut8BiYm5E7g8noDnd());
				DCS4Jf0LRzsehKFc5QOLL06qw.aimingChance = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Silent Aimbot Hitchance: ", DCS4Jf0LRzsehKFc5QOLL06qw.aimingChance, 0, 100, -1);
				DokdtlMHqRTX0KbeCtveFDTNT silentAimType = DCS4Jf0LRzsehKFc5QOLL06qw.silentAimType;
				bool flag6 = silentAimType != DokdtlMHqRTX0KbeCtveFDTNT.Distance;
				if (flag6)
				{
					bool flag7 = silentAimType == DokdtlMHqRTX0KbeCtveFDTNT.Sphere;
					if (flag7)
					{
						DCS4Jf0LRzsehKFc5QOLL06qw.hookSpherePointToBullet = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.hookSpherePointToBullet, "Hook sphere point to bullet", Array.Empty<GUILayoutOption>());
						GUILayout.Label("Spheres: ", Array.Empty<GUILayoutOption>());
						GUILayout.Space(4f);
						for (int i = 0; i < DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY.Count; i++)
						{
							DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY[i].sphereSize = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Sphere Size: ", DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY[i].sphereSize, 1f, 2f, -1);
							DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY[i].sphereSegments = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Sphere Segments: ", DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY[i].sphereSegments, 2, 32, -1);
							bool flag8 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Remove Sphere", -1, true, null);
							if (flag8)
							{
								DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY.RemoveAt(i);
								DoLw5vYd2Gq0BYuUfcIXuj4Vo.DJCB8nFq4AlMkcvaCk3iazVNC();
							}
						}
						bool flag9 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Sort & Optimize", -1, true, null);
						if (flag9)
						{
							DoLw5vYd2Gq0BYuUfcIXuj4Vo.DyG23mGej0mSGFU2U84sGnFdR();
						}
						bool flag10 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Add Sphere", -1, true, null);
						if (flag10)
						{
							DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY.Add(new DaqXfD9Fjc9IG7oF0OAH4hEOR(1f, 8));
							DCS4Jf0LRzsehKFc5QOLL06qw.Db55lznlFok53zZBv0jDuw4gi = Mathf.Max(DCS4Jf0LRzsehKFc5QOLL06qw.Db55lznlFok53zZBv0jDuw4gi, 1f);
						}
						DCS4Jf0LRzsehKFc5QOLL06qw.debugSpherePoints = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.debugSpherePoints, "Debug sphere points", Array.Empty<GUILayoutOption>());
						DCS4Jf0LRzsehKFc5QOLL06qw.setHitPointToCameraIfAviable = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.setHitPointToCameraIfAviable, "Set hit point to camera if aviable", Array.Empty<GUILayoutOption>());
						DCS4Jf0LRzsehKFc5QOLL06qw.additiveRangeBySphereSize = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.additiveRangeBySphereSize, "Extend range by sphere size", Array.Empty<GUILayoutOption>());
						DCS4Jf0LRzsehKFc5QOLL06qw.previewHitPoint = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.previewHitPoint, "Preview sphere point", Array.Empty<GUILayoutOption>());
						bool previewHitPoint = DCS4Jf0LRzsehKFc5QOLL06qw.previewHitPoint;
						if (previewHitPoint)
						{
							DCS4Jf0LRzsehKFc5QOLL06qw.drawLineFromHitPoint = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.drawLineFromHitPoint, "Draw line from sphere point", Array.Empty<GUILayoutOption>());
							DCS4Jf0LRzsehKFc5QOLL06qw.drawLineFromPlayerHead = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.drawLineFromPlayerHead, "Draw line from player head", Array.Empty<GUILayoutOption>());
						}
						DCS4Jf0LRzsehKFc5QOLL06qw.verifySphereToPlayerPointByLinecast = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.verifySphereToPlayerPointByLinecast, "Verify sphere to player point by linecast", Array.Empty<GUILayoutOption>());
					}
				}
				else
				{
					DCS4Jf0LRzsehKFc5QOLL06qw.distanceToHit = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Distance to hit: ", DCS4Jf0LRzsehKFc5QOLL06qw.distanceToHit, 1, 15, -1);
					DCS4Jf0LRzsehKFc5QOLL06qw.verifyForwardHitPointAviablity = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.verifyForwardHitPointAviablity, "Verify forward hit point possibility", Array.Empty<GUILayoutOption>());
					DCS4Jf0LRzsehKFc5QOLL06qw.traceFromOrigin = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.traceFromOrigin, "Trace from origin", Array.Empty<GUILayoutOption>());
					bool traceFromOrigin = DCS4Jf0LRzsehKFc5QOLL06qw.traceFromOrigin;
					if (traceFromOrigin)
					{
						DCS4Jf0LRzsehKFc5QOLL06qw.verifyTraceByLinecast = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.verifyTraceByLinecast, "Verify trace by linecast", Array.Empty<GUILayoutOption>());
					}
				}
				GUILayout.Space(10f);
				string text = "";
				foreach (Dr5qliNNQh3jZolh9fn7SFNyi dr5qliNNQh3jZolh9fn7SFNyi in DCS4Jf0LRzsehKFc5QOLL06qw.DULiu9lLWSHNenYxzlK8xT984)
				{
					bool flag11 = !string.IsNullOrEmpty(text);
					if (flag11)
					{
						text += string.Format("->{0}", dr5qliNNQh3jZolh9fn7SFNyi);
					}
					else
					{
						text += dr5qliNNQh3jZolh9fn7SFNyi.ToString();
					}
				}
				bool flag12 = !string.IsNullOrEmpty(text);
				if (flag12)
				{
					GUILayout.Label("Sorting type: " + text, Array.Empty<GUILayoutOption>());
				}
				else
				{
					GUILayout.Label("Sorting type: None", Array.Empty<GUILayoutOption>());
				}
				byte b = 0;
				while ((int)b < Enum.GetValues(typeof(Dr5qliNNQh3jZolh9fn7SFNyi)).Length)
				{
					Dr5qliNNQh3jZolh9fn7SFNyi dr5qliNNQh3jZolh9fn7SFNyi2 = (Dr5qliNNQh3jZolh9fn7SFNyi)b;
					bool flag13 = DCS4Jf0LRzsehKFc5QOLL06qw.DULiu9lLWSHNenYxzlK8xT984.Contains(dr5qliNNQh3jZolh9fn7SFNyi2);
					flag13 = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(flag13, "Target " + dr5qliNNQh3jZolh9fn7SFNyi2.ToString(), Array.Empty<GUILayoutOption>());
					bool flag14 = !DCS4Jf0LRzsehKFc5QOLL06qw.DULiu9lLWSHNenYxzlK8xT984.Contains(dr5qliNNQh3jZolh9fn7SFNyi2) && flag13;
					if (flag14)
					{
						DCS4Jf0LRzsehKFc5QOLL06qw.DULiu9lLWSHNenYxzlK8xT984.Add(dr5qliNNQh3jZolh9fn7SFNyi2);
					}
					else
					{
						bool flag15 = DCS4Jf0LRzsehKFc5QOLL06qw.DULiu9lLWSHNenYxzlK8xT984.Contains(dr5qliNNQh3jZolh9fn7SFNyi2) && !flag13;
						if (flag15)
						{
							DCS4Jf0LRzsehKFc5QOLL06qw.DULiu9lLWSHNenYxzlK8xT984.Remove(dr5qliNNQh3jZolh9fn7SFNyi2);
						}
					}
					b += 1;
				}
			}
			GUILayout.EndScrollView();
		}
		else
		{
			bool flag16 = tc == DYIPJORHeVCfbpocFHvJty4OE.Two;
			if (flag16)
			{
				base.DGLNJE6Ld056OViYFjOM7IeMS("Memory Aimbot");
				DCS4Jf0LRzsehKFc5QOLL06qw.enableAimbot = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.enableAimbot, "Enable Memory Aimbot", Array.Empty<GUILayoutOption>());
				bool enableAimbot = DCS4Jf0LRzsehKFc5QOLL06qw.enableAimbot;
				if (enableAimbot)
				{
					DCS4Jf0LRzsehKFc5QOLL06qw.bestAimbotPartPreselective = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.bestAimbotPartPreselective, "Target best aimbot hitbox", Array.Empty<GUILayoutOption>());
					bool flag17 = !DCS4Jf0LRzsehKFc5QOLL06qw.bestAimbotPartPreselective && DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Aimbot Hitbox: " + DCS4Jf0LRzsehKFc5QOLL06qw.aimbotLimb.Dq6eNqgaZn6PYh50FMK07NzNt(), -1, true, null);
					if (flag17)
					{
						DCS4Jf0LRzsehKFc5QOLL06qw.aimbotLimb = DCS4Jf0LRzsehKFc5QOLL06qw.aimbotLimb.D5GDf6NDOOXtOKVhMfOJBmfW5<Drvin9V0cgPlOe7ofbFCim7y0>();
					}
					bool flag18 = DCS4Jf0LRzsehKFc5QOLL06qw.aimbotLimb == Drvin9V0cgPlOe7ofbFCim7y0.Random;
					if (flag18)
					{
						DCS4Jf0LRzsehKFc5QOLL06qw.randomLimbHeadHitChance = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Random limb head hit chance: ", DCS4Jf0LRzsehKFc5QOLL06qw.randomLimbHeadHitChance, 0, 100, -1);
					}
					DCS4Jf0LRzsehKFc5QOLL06qw.smoothAimbot = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.smoothAimbot, "Enable Aimbot Smoothing", Array.Empty<GUILayoutOption>());
					bool smoothAimbot = DCS4Jf0LRzsehKFc5QOLL06qw.smoothAimbot;
					if (smoothAimbot)
					{
						DCS4Jf0LRzsehKFc5QOLL06qw.smoothAimbotSpeed = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Smoothing: ", DCS4Jf0LRzsehKFc5QOLL06qw.smoothAimbotSpeed, 1f, 25f, -1);
					}
					DCS4Jf0LRzsehKFc5QOLL06qw.alwaysAim = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.alwaysAim, "Always Aimbot", Array.Empty<GUILayoutOption>());
				}
			}
			else
			{
				base.DGLNJE6Ld056OViYFjOM7IeMS("Shared options");
				this.DsuTjVW6TMSwHH0AKG1r009fI = GUILayout.BeginScrollView(this.DsuTjVW6TMSwHH0AKG1r009fI, Array.Empty<GUILayoutOption>());
				DCS4Jf0LRzsehKFc5QOLL06qw.setDistanceByGunRange = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.setDistanceByGunRange, "Set distance by gun range", Array.Empty<GUILayoutOption>());
				bool flag19 = !DCS4Jf0LRzsehKFc5QOLL06qw.setDistanceByGunRange;
				if (flag19)
				{
					DCS4Jf0LRzsehKFc5QOLL06qw.aimTargetDistance = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Aim distance: ", DCS4Jf0LRzsehKFc5QOLL06qw.aimTargetDistance, 0, 500, -1);
				}
				DCS4Jf0LRzsehKFc5QOLL06qw.restrictAimByFov = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.restrictAimByFov, "Restrict aim by FOV", Array.Empty<GUILayoutOption>());
				DCS4Jf0LRzsehKFc5QOLL06qw.drawTarget = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.drawTarget, "Draw aim target", Array.Empty<GUILayoutOption>());
				DCS4Jf0LRzsehKFc5QOLL06qw.checkWithLinecast = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.checkWithLinecast, "Check target with linecast", Array.Empty<GUILayoutOption>());
				DCS4Jf0LRzsehKFc5QOLL06qw.dontShootPlayersOnSafezone = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.dontShootPlayersOnSafezone, "Skip players in safezone", Array.Empty<GUILayoutOption>());
				DCS4Jf0LRzsehKFc5QOLL06qw.manuallyCalculateBallisticDistance = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.manuallyCalculateBallisticDistance, "Manually calculate ballistic distance", Array.Empty<GUILayoutOption>());
				DCS4Jf0LRzsehKFc5QOLL06qw.aimSorting = DCS4Jf0LRzsehKFc5QOLL06qw.aimSorting.DdoC7WUc7IFAmnWoLcSWPOXFw("Player sorting: ", "");
				bool flag20 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Player sorting: " + DCS4Jf0LRzsehKFc5QOLL06qw.aimSorting.ToString(), -1, true, null);
				if (flag20)
				{
					DCS4Jf0LRzsehKFc5QOLL06qw.aimSorting = DCS4Jf0LRzsehKFc5QOLL06qw.aimSorting.D5GDf6NDOOXtOKVhMfOJBmfW5<DK27IZ62oGywnytdkDio7Gbp0>();
				}
				DCS4Jf0LRzsehKFc5QOLL06qw.previewHitLimb = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.previewHitLimb, "Preview hit limb", Array.Empty<GUILayoutOption>());
				bool previewHitLimb = DCS4Jf0LRzsehKFc5QOLL06qw.previewHitLimb;
				if (previewHitLimb)
				{
					DCS4Jf0LRzsehKFc5QOLL06qw.hitMarkSize = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Hitmark size: ", DCS4Jf0LRzsehKFc5QOLL06qw.hitMarkSize, 4, 20, -1);
				}
				GUILayout.Label("Aim target line position: ", Array.Empty<GUILayoutOption>());
				GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
				GUILayout.Label("X:", Array.Empty<GUILayoutOption>());
				DCS4Jf0LRzsehKFc5QOLL06qw.targetLineStartX = DrysTRTjdLdFqu5GJBDif6AoV.Df5jhq5GIflV7BcEcXSpROI9c(DCS4Jf0LRzsehKFc5QOLL06qw.targetLineStartX);
				GUILayout.Label("Y:", Array.Empty<GUILayoutOption>());
				DCS4Jf0LRzsehKFc5QOLL06qw.targetLineStartY = DrysTRTjdLdFqu5GJBDif6AoV.Df5jhq5GIflV7BcEcXSpROI9c(DCS4Jf0LRzsehKFc5QOLL06qw.targetLineStartY);
				GUILayout.EndHorizontal();
				DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelaying = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelaying, "Delay bullets from being sent to server", Array.Empty<GUILayoutOption>());
				bool bulletDelaying = DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelaying;
				if (bulletDelaying)
				{
					DCS4Jf0LRzsehKFc5QOLL06qw.showBulletDelayingTimer = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.showBulletDelayingTimer, "Show bullet delaying timer", Array.Empty<GUILayoutOption>());
					DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelayAmount = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Delay limit amount: ", DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelayAmount, 1, 100, -1);
					DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelaySeconds = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Delay seconds: ", DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelaySeconds, 0f, 10f, -1);
					bool flag21 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Release key: " + (DCS4Jf0LRzsehKFc5QOLL06qw.waitingForDelayKey ? "Press any key..." : DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelayKeybind.ToString()), -1, true, null);
					if (flag21)
					{
						DCS4Jf0LRzsehKFc5QOLL06qw.waitingForDelayKey = !DCS4Jf0LRzsehKFc5QOLL06qw.waitingForDelayKey;
					}
					else
					{
						bool waitingForDelayKey = DCS4Jf0LRzsehKFc5QOLL06qw.waitingForDelayKey;
						if (waitingForDelayKey)
						{
							bool flag22 = Event.current.isKey && Event.current.keyCode > KeyCode.None;
							if (flag22)
							{
								bool flag23 = Event.current.keyCode == KeyCode.Escape;
								if (flag23)
								{
									DCS4Jf0LRzsehKFc5QOLL06qw.waitingForDelayKey = false;
								}
								else
								{
									DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelayKeybind = Event.current.keyCode;
									DCS4Jf0LRzsehKFc5QOLL06qw.waitingForDelayKey = false;
								}
							}
							else
							{
								bool flag24 = Event.current.type == EventType.MouseDown;
								if (flag24)
								{
									DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelayKeybind = KeyCode.Mouse0 + Event.current.button;
									DCS4Jf0LRzsehKFc5QOLL06qw.waitingForDelayKey = false;
								}
							}
						}
					}
					DCS4Jf0LRzsehKFc5QOLL06qw.unholdDelayByMouse = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.unholdDelayByMouse, "Unhold delay by mouse", Array.Empty<GUILayoutOption>());
					bool unholdDelayByMouse = DCS4Jf0LRzsehKFc5QOLL06qw.unholdDelayByMouse;
					if (unholdDelayByMouse)
					{
						DCS4Jf0LRzsehKFc5QOLL06qw.momentalyUnhold = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DCS4Jf0LRzsehKFc5QOLL06qw.momentalyUnhold, "Momentaly unhold", Array.Empty<GUILayoutOption>());
					}
				}
				GUILayout.EndScrollView();
			}
		}
	}

	// Token: 0x04000001 RID: 1
	public Vector2 DsuTjVW6TMSwHH0AKG1r009fI = Vector2.zero;

	// Token: 0x04000002 RID: 2
	public Vector2 DpfGDBlHnK5h0gSJLdn3JseV7 = Vector2.zero;
}
