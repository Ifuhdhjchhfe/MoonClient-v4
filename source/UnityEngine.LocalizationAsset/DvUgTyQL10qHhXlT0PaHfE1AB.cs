using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000C9 RID: 201
public class DvUgTyQL10qHhXlT0PaHfE1AB : DOEkZ1zoBEuvfUmOs9QSpfX0X
{
	// Token: 0x060003DF RID: 991 RVA: 0x000393C0 File Offset: 0x000375C0
	public override string GetName()
	{
		return "Misc";
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x000393D8 File Offset: 0x000375D8
	public override int SortId()
	{
		return 2;
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x000393EC File Offset: 0x000375EC
	public override void DoTab(DYIPJORHeVCfbpocFHvJty4OE tc)
	{
		bool flag = tc == DYIPJORHeVCfbpocFHvJty4OE.One;
		if (flag)
		{
			base.DGLNJE6Ld056OViYFjOM7IeMS("Misc");
			this.D5HK925z7udI4FYDC7e7C03QS = GUILayout.BeginScrollView(this.D5HK925z7udI4FYDC7e7C03QS, Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.noFlash = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.noFlash, "No flash", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.noGrayscale = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.noGrayscale, "No grayscale", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.noPain = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.noPain, "No pain", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.noBlur = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.noBlur, "No blur", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.noHallucinations = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.noHallucinations, "No hallucinations", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.rawWalk = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.rawWalk, "Raw walk", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.instantAiming = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.instantAiming, "Instant aiming", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.imitCompassInInventory = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.imitCompassInInventory, "Imit compass in inventory", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.imitMapInInventory = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.imitMapInInventory, "Imit map in inventory", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.displayAllPlayersOnMap = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.displayAllPlayersOnMap, "Display all players on map", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.displayAllPlayerMarksOnMap = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.displayAllPlayerMarksOnMap, "Display all player marks on map", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.disableBinocularOverlay = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.disableBinocularOverlay, "Disable binocular overlay blackout", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.disableScopeOverlayH = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.disableScopeOverlayH, "Disable scope overlay blackout", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.ignoreBarricadePlacementErrors = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.ignoreBarricadePlacementErrors, "Ignore barricade placement errors", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.ignoreStructurePlacementErrors = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.ignoreStructurePlacementErrors, "Ignore structure placement errors", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.ignoreLeaveTimer = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.ignoreLeaveTimer, "Ignore leave timer", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.extendMeleeRange = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.extendMeleeRange, "Extended melee range", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.noBallistics = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.noBallistics, "Remove ballistics", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.thirdCameraIgnoreObstacles = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.thirdCameraIgnoreObstacles, "Ignore obstacles in third person", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.overrideSkyColor = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.overrideSkyColor, "Override sky color", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.overrideSunColor = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.overrideSunColor, "Override sun color", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.overrideCloudsColor = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.overrideCloudsColor, "Override clouds color", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.overrideCloudsRimColor = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.overrideCloudsRimColor, "Override clouds rim color", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.unclampCameraRotation = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.unclampCameraRotation, "Unclamp camera rotation", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.displayVanishPlayersWindow = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.displayVanishPlayersWindow, "Display player vanish window", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.skipAssetVerifying = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.skipAssetVerifying, "Skip asset verifying", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.automaticSemiBurst = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.automaticSemiBurst, "Automatic semi-burst", Array.Empty<GUILayoutOption>());
			GUILayout.EndScrollView();
		}
		else
		{
			base.DGLNJE6Ld056OViYFjOM7IeMS("Optionable Misc");
			this.DW3xwFgQ13mzkr4zyrBQnAl0i = GUILayout.BeginScrollView(this.DW3xwFgQ13mzkr4zyrBQnAl0i, Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.freeCamera = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.freeCamera, "Freecamera", Array.Empty<GUILayoutOption>());
			bool freeCamera = D5l46jlssr4TRAzUSXzLj0uqu.freeCamera;
			if (freeCamera)
			{
				GUILayout.Label("Camera Speed: " + D5l46jlssr4TRAzUSXzLj0uqu.freeCameraSpeed.ToString(), Array.Empty<GUILayoutOption>());
				D5l46jlssr4TRAzUSXzLj0uqu.freeCameraSpeed = (int)DrysTRTjdLdFqu5GJBDif6AoV.DiIzr0IyRE8047lHIEzXzzFRJ((float)D5l46jlssr4TRAzUSXzLj0uqu.freeCameraSpeed, 3f, 99f, -1);
			}
			D5l46jlssr4TRAzUSXzLj0uqu.spreadMultiplier = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Gun Spread: ", D5l46jlssr4TRAzUSXzLj0uqu.spreadMultiplier, 0f, 1f, -1);
			D5l46jlssr4TRAzUSXzLj0uqu.recoilMultiplier = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Gun Recoil: ", D5l46jlssr4TRAzUSXzLj0uqu.recoilMultiplier, 0f, 1f, -1);
			D5l46jlssr4TRAzUSXzLj0uqu.recoilImpactMultiplier = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Gun Recoil Impact: ", D5l46jlssr4TRAzUSXzLj0uqu.recoilImpactMultiplier, 0f, 1f, -1);
			D5l46jlssr4TRAzUSXzLj0uqu.swayMultiplier = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Gun Sway: ", D5l46jlssr4TRAzUSXzLj0uqu.swayMultiplier, 0f, 1f, -1);
			D5l46jlssr4TRAzUSXzLj0uqu.damagePunchMultiplier = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Punch Damage: ", D5l46jlssr4TRAzUSXzLj0uqu.damagePunchMultiplier, 0f, 1f, -1);
			D5l46jlssr4TRAzUSXzLj0uqu.salvageTimeMultiplier = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Salvage Time: ", D5l46jlssr4TRAzUSXzLj0uqu.salvageTimeMultiplier, 0.05f, 1f, -1);
			D5l46jlssr4TRAzUSXzLj0uqu.thirdCameraDistance = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Third camera distance: ", D5l46jlssr4TRAzUSXzLj0uqu.thirdCameraDistance, 0f, 10f, -1);
			D5l46jlssr4TRAzUSXzLj0uqu.firerateDecrease = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Firerate Multiplier: ", D5l46jlssr4TRAzUSXzLj0uqu.firerateDecrease, 0, 3, -1);
			D5l46jlssr4TRAzUSXzLj0uqu.correctFirerateToWork = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.correctFirerateToWork, "Correct firerate to work", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.useCustomFOV = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.useCustomFOV, "Change Player FOV", Array.Empty<GUILayoutOption>());
			bool useCustomFOV = D5l46jlssr4TRAzUSXzLj0uqu.useCustomFOV;
			if (useCustomFOV)
			{
				int num = (int)(D5l46jlssr4TRAzUSXzLj0uqu.customFOV * 120f);
				num = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("FOV: ", num, 120, 240, -1);
				D5l46jlssr4TRAzUSXzLj0uqu.customFOV = (float)num / 120f;
			}
			D5l46jlssr4TRAzUSXzLj0uqu.useCustomAspectRatio = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.useCustomAspectRatio, "Use custom aspect ratio", Array.Empty<GUILayoutOption>());
			bool useCustomAspectRatio = D5l46jlssr4TRAzUSXzLj0uqu.useCustomAspectRatio;
			if (useCustomAspectRatio)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.customAspectRatio = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Aspect ratio: ", D5l46jlssr4TRAzUSXzLj0uqu.customAspectRatio, 0f, 3f, -1);
			}
			D5l46jlssr4TRAzUSXzLj0uqu.replaceHitLimbToCustom = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.replaceHitLimbToCustom, "Force Hitbox", Array.Empty<GUILayoutOption>());
			bool replaceHitLimbToCustom = D5l46jlssr4TRAzUSXzLj0uqu.replaceHitLimbToCustom;
			if (replaceHitLimbToCustom)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.replacedHitLimb = D5l46jlssr4TRAzUSXzLj0uqu.replacedHitLimb.DdoC7WUc7IFAmnWoLcSWPOXFw("Current Hitbox: ", D5l46jlssr4TRAzUSXzLj0uqu.replacedHitLimb.Dq6eNqgaZn6PYh50FMK07NzNt());
			}
			D5l46jlssr4TRAzUSXzLj0uqu.modifyPlayerPerspective = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.modifyPlayerPerspective, "Modify player perspective", Array.Empty<GUILayoutOption>());
			bool flag2 = D5l46jlssr4TRAzUSXzLj0uqu.modifyPlayerPerspective && DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Current perspective: " + D5l46jlssr4TRAzUSXzLj0uqu.playerPerspective.ToString(), -1, true, null);
			if (flag2)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.playerPerspective = D5l46jlssr4TRAzUSXzLj0uqu.playerPerspective.D5GDf6NDOOXtOKVhMfOJBmfW5<ECameraMode>();
				bool flag3 = D5l46jlssr4TRAzUSXzLj0uqu.playerPerspective == ECameraMode.ANY;
				if (flag3)
				{
					D5l46jlssr4TRAzUSXzLj0uqu.playerPerspective = ECameraMode.FIRST;
				}
			}
			D5l46jlssr4TRAzUSXzLj0uqu.displayPlayerInfo = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.displayPlayerInfo, "Display target information", Array.Empty<GUILayoutOption>());
			bool displayPlayerInfo = D5l46jlssr4TRAzUSXzLj0uqu.displayPlayerInfo;
			if (displayPlayerInfo)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.displayPlayerInfoAlways = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.displayPlayerInfoAlways, "Always Display player info", Array.Empty<GUILayoutOption>());
				D5l46jlssr4TRAzUSXzLj0uqu.displayPlayerGroupMembers = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.displayPlayerGroupMembers, "Display player group members", Array.Empty<GUILayoutOption>());
				D5l46jlssr4TRAzUSXzLj0uqu.playerInfoWindowSize = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Player info size: ", D5l46jlssr4TRAzUSXzLj0uqu.playerInfoWindowSize, 10, 100, -1);
				D5l46jlssr4TRAzUSXzLj0uqu.independentPlayerInfoTargeting = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.independentPlayerInfoTargeting, "Indepented player info targeting", Array.Empty<GUILayoutOption>());
				bool independentPlayerInfoTargeting = D5l46jlssr4TRAzUSXzLj0uqu.independentPlayerInfoTargeting;
				if (independentPlayerInfoTargeting)
				{
					D5l46jlssr4TRAzUSXzLj0uqu.independetPlayerInfoTargetingDistance = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Indepented player info targeting distance: ", D5l46jlssr4TRAzUSXzLj0uqu.independetPlayerInfoTargetingDistance, 0, 2000, -1);
				}
			}
			D5l46jlssr4TRAzUSXzLj0uqu.extendBallisticRange = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.extendBallisticRange, "Extend ballistic range", Array.Empty<GUILayoutOption>());
			bool extendBallisticRange = D5l46jlssr4TRAzUSXzLj0uqu.extendBallisticRange;
			if (extendBallisticRange)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.additionalBallisticSteps = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Extended ballistic steps: ", D5l46jlssr4TRAzUSXzLj0uqu.additionalBallisticSteps, 1, 4, -1);
			}
			D5l46jlssr4TRAzUSXzLj0uqu.extendPlayerRegion = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.extendPlayerRegion, "Extended pickup region", Array.Empty<GUILayoutOption>());
			bool extendPlayerRegion = D5l46jlssr4TRAzUSXzLj0uqu.extendPlayerRegion;
			if (extendPlayerRegion)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.extendRegionRange = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Extend region distance: ", D5l46jlssr4TRAzUSXzLj0uqu.extendRegionRange, 2, 20, -1);
				D5l46jlssr4TRAzUSXzLj0uqu.extendRegionInteractThroughWalls = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.extendRegionInteractThroughWalls, "Extended pickup region through walls", Array.Empty<GUILayoutOption>());
			}
			D5l46jlssr4TRAzUSXzLj0uqu.pickupItemsThroughWalls = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.pickupItemsThroughWalls, "Pickup items through walls", Array.Empty<GUILayoutOption>());
			bool pickupItemsThroughWalls = D5l46jlssr4TRAzUSXzLj0uqu.pickupItemsThroughWalls;
			if (pickupItemsThroughWalls)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.pickupItemsThroughWallsDistance = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Pickup items through walls distance: ", D5l46jlssr4TRAzUSXzLj0uqu.pickupItemsThroughWallsDistance, 3, 20, -1);
			}
			D5l46jlssr4TRAzUSXzLj0uqu.autoItemPickup = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.autoItemPickup, "Auto item pickup", Array.Empty<GUILayoutOption>());
			bool autoItemPickup = D5l46jlssr4TRAzUSXzLj0uqu.autoItemPickup;
			if (autoItemPickup)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.autoItemPickupDistance = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Auto item pickup distance: ", D5l46jlssr4TRAzUSXzLj0uqu.autoItemPickupDistance, 2, 20, -1);
				this.autoPickupScroll = GUILayout.BeginScrollView(this.autoPickupScroll, new GUILayoutOption[] { GUILayout.Height(150f) });
				foreach (DDB8pIlWKKbHkw2jCuyAPcvL7 ddb8pIlWKKbHkw2jCuyAPcvL in D5l46jlssr4TRAzUSXzLj0uqu.DzksjAWr7fP6HlkBNdY20fpHC.Values)
				{
					bool flag4 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv(ddb8pIlWKKbHkw2jCuyAPcvL.DjHtc6kil0ZuGKFFgQKYQvYK2, -1, true, null);
					if (flag4)
					{
						D5l46jlssr4TRAzUSXzLj0uqu.DzksjAWr7fP6HlkBNdY20fpHC.Remove(ddb8pIlWKKbHkw2jCuyAPcvL.Dn06Kjd8jxL0Tj2Vfupj8Skcq);
					}
				}
				GUILayout.EndScrollView();
				bool flag5 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Configure auto pickup items", -1, true, null);
				if (flag5)
				{
					DOFx241sQSz07GkAdUwghFS1G.isActive = !DOFx241sQSz07GkAdUwghFS1G.isActive;
				}
			}
			D5l46jlssr4TRAzUSXzLj0uqu.showWeaponInfo = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.showWeaponInfo, "Show weapon information", Array.Empty<GUILayoutOption>());
			bool showWeaponInfo = D5l46jlssr4TRAzUSXzLj0uqu.showWeaponInfo;
			if (showWeaponInfo)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.useStaticRectForWeaponInfo = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.useStaticRectForWeaponInfo, "Static Target Information Window", Array.Empty<GUILayoutOption>());
			}
			D5l46jlssr4TRAzUSXzLj0uqu.imitNightvision = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.imitNightvision, "Force Nightvision", Array.Empty<GUILayoutOption>());
			bool flag6 = D5l46jlssr4TRAzUSXzLj0uqu.imitNightvision && DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv(string.Format("Nightvision type: {0}", D5l46jlssr4TRAzUSXzLj0uqu.nightVisionType), -1, true, null);
			if (flag6)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.nightVisionType = D5l46jlssr4TRAzUSXzLj0uqu.nightVisionType.D5GDf6NDOOXtOKVhMfOJBmfW5<DvbEzC20KPBbYRjl1eW9ilgCU>();
			}
			D5l46jlssr4TRAzUSXzLj0uqu.customVehicleBehaviour = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.customVehicleBehaviour, "Custom vehicle behaviour", Array.Empty<GUILayoutOption>());
			bool customVehicleBehaviour = D5l46jlssr4TRAzUSXzLj0uqu.customVehicleBehaviour;
			if (customVehicleBehaviour)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.vehicleNoclip = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.vehicleNoclip, "Vehicle Flight", Array.Empty<GUILayoutOption>());
				bool flag7 = !D5l46jlssr4TRAzUSXzLj0uqu.vehicleNoclip;
				if (flag7)
				{
					try
					{
						bool flag8 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Reset values to default", -1, true, null);
						if (flag8)
						{
							DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx = DyeZ3VGPOIURoB79RzeiyEoDq.D10ynXjYOXWz82CyXFMTjTxcK(DyeZ3VGPOIURoB79RzeiyEoDq.Dh4w9Tga1SdtxToA5FlSMGQKx);
							DyeZ3VGPOIURoB79RzeiyEoDq.DDhNxYvtf1DcoxjUKjAeBs0hB = DyeZ3VGPOIURoB79RzeiyEoDq.DdpWFHwmEs62wdkdOEHdvRl4l;
							DyeZ3VGPOIURoB79RzeiyEoDq.DZYz0Xr7W62jYmI0jRen8PvE2 = DyeZ3VGPOIURoB79RzeiyEoDq.DqLTES02MdvCkFRqeSMmLJpXV;
							D08iy2XFQpUQteL0XRzAbg2IE.Dr06TnUlTEh4Mt9XdzQtoz0Lb(typeof(VehicleAsset), "_steerMax", DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.D0ELnekK0qU385gCnZRB3HOHG.asset, DyeZ3VGPOIURoB79RzeiyEoDq.DDhNxYvtf1DcoxjUKjAeBs0hB);
							D08iy2XFQpUQteL0XRzAbg2IE.Dr06TnUlTEh4Mt9XdzQtoz0Lb(typeof(VehicleAsset), "_steerMin", DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.D0ELnekK0qU385gCnZRB3HOHG.asset, DyeZ3VGPOIURoB79RzeiyEoDq.DZYz0Xr7W62jYmI0jRen8PvE2);
						}
						ValueTuple<string, float>[] array = new ValueTuple<string, float>[]
						{
							new ValueTuple<string, float>("rootMassOverride", 10f),
							new ValueTuple<string, float>("rootMassMultiplier", 5f),
							new ValueTuple<string, float>("rootDragMultiplier", 10f),
							new ValueTuple<string, float>("rootAngularDragMultiplier", 6f),
							new ValueTuple<string, float>("wheelStiffnessTractionMultiplier", 4f),
							new ValueTuple<string, float>("wheelDampingRate", 4f),
							new ValueTuple<string, float>("wheelSuspensionForce", 100f),
							new ValueTuple<string, float>("wheelSuspensionDamper", 10f),
							new ValueTuple<string, float>("wheelMassOverride", 15f),
							new ValueTuple<string, float>("wheelMassMultiplier", 5f),
							new ValueTuple<string, float>("motorTorqueMultiplier", 10f),
							new ValueTuple<string, float>("motorTorqueClampMultiplier", 8f),
							new ValueTuple<string, float>("brakeTorqueMultiplier", 10f),
							new ValueTuple<string, float>("brakeTorqueTractionMultiplier", 8f),
							new ValueTuple<string, float>("carjackForceMultiplier", 10f)
						};
						string[] array2 = new string[] { "forwardFriction", "sidewaysFriction" };
						Type typeFromHandle = typeof(VehiclePhysicsProfileAsset);
						DyeZ3VGPOIURoB79RzeiyEoDq.DZYz0Xr7W62jYmI0jRen8PvE2 = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Steer min", DyeZ3VGPOIURoB79RzeiyEoDq.DZYz0Xr7W62jYmI0jRen8PvE2, 5f, 90f, -1);
						DyeZ3VGPOIURoB79RzeiyEoDq.DDhNxYvtf1DcoxjUKjAeBs0hB = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Steer max", DyeZ3VGPOIURoB79RzeiyEoDq.DDhNxYvtf1DcoxjUKjAeBs0hB, 5f, 90f, -1);
						foreach (ValueTuple<string, float> valueTuple in array)
						{
							string item = valueTuple.Item1;
							float item2 = valueTuple.Item2;
							bool flag9 = typeFromHandle.GetProperty(item).GetValue(DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx) != null;
							if (flag9)
							{
								typeFromHandle.GetProperty(item).GetValue(DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx).ToString();
							}
							bool flag10 = typeFromHandle.GetProperty(item).GetValue(DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx) == null;
							if (flag10)
							{
								bool flag11 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Create value", -1, true, null);
								if (flag11)
								{
									typeFromHandle.GetProperty(item).SetValue(DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx, 0f);
								}
							}
							else
							{
								typeFromHandle.GetProperty(item).SetValue(DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx, DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV(item + ": ", (float)typeFromHandle.GetProperty(item).GetValue(DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx), 0f, item2, -1));
							}
						}
						foreach (string text in array2)
						{
							GUILayout.Label(text, Array.Empty<GUILayoutOption>());
							bool flag12 = typeFromHandle.GetProperty(text).GetValue(DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx) == null;
							if (flag12)
							{
								bool flag13 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Create value", -1, true, null);
								if (flag13)
								{
									typeFromHandle.GetProperty(text).SetValue(DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx, default(VehiclePhysicsProfileAsset.Friction));
								}
							}
							else
							{
								VehiclePhysicsProfileAsset.Friction friction = (VehiclePhysicsProfileAsset.Friction)typeFromHandle.GetProperty(text).GetValue(DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx);
								friction.stiffness = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Stiffnes: ", friction.stiffness, 0f, 20f, -1);
								friction.extremumValue = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Extremum value: ", friction.extremumValue, 0f, 10f, -1);
								friction.extremumSlip = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Extremum slip: ", friction.extremumSlip, 0f, 10f, -1);
								friction.asymptoteValue = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Asymptote value: ", friction.asymptoteValue, 0f, 10f, -1);
								friction.asymptoteSlip = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Asymptote slip: ", friction.asymptoteSlip, 0f, 10f, -1);
								typeFromHandle.GetProperty(text).SetValue(DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx, friction);
							}
						}
						bool flag14 = DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51 != null;
						if (flag14)
						{
							DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx.applyTo(DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.D0ELnekK0qU385gCnZRB3HOHG);
							D08iy2XFQpUQteL0XRzAbg2IE.Dr06TnUlTEh4Mt9XdzQtoz0Lb(typeof(VehicleAsset), "_steerMax", DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.D0ELnekK0qU385gCnZRB3HOHG.asset, DyeZ3VGPOIURoB79RzeiyEoDq.DDhNxYvtf1DcoxjUKjAeBs0hB);
							D08iy2XFQpUQteL0XRzAbg2IE.Dr06TnUlTEh4Mt9XdzQtoz0Lb(typeof(VehicleAsset), "_steerMin", DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.D0ELnekK0qU385gCnZRB3HOHG.asset, DyeZ3VGPOIURoB79RzeiyEoDq.DZYz0Xr7W62jYmI0jRen8PvE2);
						}
						goto IL_0ED3;
					}
					catch (Exception ex)
					{
						GUILayout.Label(ex.Message, Array.Empty<GUILayoutOption>());
						goto IL_0ED3;
					}
				}
				D5l46jlssr4TRAzUSXzLj0uqu.useVehiclePhysics = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.useVehiclePhysics, "Use vehicle physics", Array.Empty<GUILayoutOption>());
				D5l46jlssr4TRAzUSXzLj0uqu.vehicleSpeed = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Vehicle speed: ", D5l46jlssr4TRAzUSXzLj0uqu.vehicleSpeed, 0f, 10f, -1);
			}
			IL_0ED3:
			D5l46jlssr4TRAzUSXzLj0uqu.changeVehicleLeaveVelocity = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.changeVehicleLeaveVelocity, "Change vehicle leave velocity", Array.Empty<GUILayoutOption>());
			bool changeVehicleLeaveVelocity = D5l46jlssr4TRAzUSXzLj0uqu.changeVehicleLeaveVelocity;
			if (changeVehicleLeaveVelocity)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.useForwardVelocity = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.useForwardVelocity, "Use forward velocity", Array.Empty<GUILayoutOption>());
				bool useForwardVelocity = D5l46jlssr4TRAzUSXzLj0uqu.useForwardVelocity;
				if (useForwardVelocity)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					GUILayout.Label("Forward multiplier:", Array.Empty<GUILayoutOption>());
					try
					{
						D5l46jlssr4TRAzUSXzLj0uqu.vehilceVelocityForward = DrysTRTjdLdFqu5GJBDif6AoV.DowY0MgMwWhJmIR03EMAPzWvW(D5l46jlssr4TRAzUSXzLj0uqu.vehilceVelocityForward);
					}
					catch
					{
					}
					GUILayout.EndHorizontal();
				}
				else
				{
					try
					{
						GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
						GUILayout.Label("X:", Array.Empty<GUILayoutOption>());
						D5l46jlssr4TRAzUSXzLj0uqu.vehilceVelocityX = DrysTRTjdLdFqu5GJBDif6AoV.DowY0MgMwWhJmIR03EMAPzWvW(D5l46jlssr4TRAzUSXzLj0uqu.vehilceVelocityX);
						GUILayout.Label("Y:", Array.Empty<GUILayoutOption>());
						D5l46jlssr4TRAzUSXzLj0uqu.vehilceVelocityY = DrysTRTjdLdFqu5GJBDif6AoV.DowY0MgMwWhJmIR03EMAPzWvW(D5l46jlssr4TRAzUSXzLj0uqu.vehilceVelocityY);
						GUILayout.Label("Z:", Array.Empty<GUILayoutOption>());
						D5l46jlssr4TRAzUSXzLj0uqu.vehilceVelocityZ = DrysTRTjdLdFqu5GJBDif6AoV.DowY0MgMwWhJmIR03EMAPzWvW(D5l46jlssr4TRAzUSXzLj0uqu.vehilceVelocityZ);
						GUILayout.EndHorizontal();
					}
					catch
					{
					}
				}
			}
			D5l46jlssr4TRAzUSXzLj0uqu.notifyOnAdminJoin = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.notifyOnAdminJoin, "Notify on admin join", Array.Empty<GUILayoutOption>());
			bool notifyOnAdminJoin = D5l46jlssr4TRAzUSXzLj0uqu.notifyOnAdminJoin;
			if (notifyOnAdminJoin)
			{
				GUILayout.Label("Notify text:", Array.Empty<GUILayoutOption>());
				D5l46jlssr4TRAzUSXzLj0uqu.adminNotifyText = GUILayout.TextField(D5l46jlssr4TRAzUSXzLj0uqu.adminNotifyText, Array.Empty<GUILayoutOption>());
			}
			D5l46jlssr4TRAzUSXzLj0uqu.chatSpamming = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.chatSpamming, "Spam in chat", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.chatSpamDelay = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Spam delay: ", D5l46jlssr4TRAzUSXzLj0uqu.chatSpamDelay, 0.05f, 2f, -1);
			GUILayout.Label("Spam text:", Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.spamText = GUILayout.TextField(D5l46jlssr4TRAzUSXzLj0uqu.spamText, Array.Empty<GUILayoutOption>());
			D5l46jlssr4TRAzUSXzLj0uqu.spamChatZone = D5l46jlssr4TRAzUSXzLj0uqu.spamChatZone.DdoC7WUc7IFAmnWoLcSWPOXFw("Spam chat zone: ", "");
			D5l46jlssr4TRAzUSXzLj0uqu.chatOnKill = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.chatOnKill, "Chat on kill", Array.Empty<GUILayoutOption>());
			bool chatOnKill = D5l46jlssr4TRAzUSXzLj0uqu.chatOnKill;
			if (chatOnKill)
			{
				GUILayout.Label("Kill text:", Array.Empty<GUILayoutOption>());
				D5l46jlssr4TRAzUSXzLj0uqu.killText = GUILayout.TextField(D5l46jlssr4TRAzUSXzLj0uqu.killText, Array.Empty<GUILayoutOption>());
			}
			D5l46jlssr4TRAzUSXzLj0uqu.customBuildOffset = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.customBuildOffset, "Custom build offset", Array.Empty<GUILayoutOption>());
			bool customBuildOffset = D5l46jlssr4TRAzUSXzLj0uqu.customBuildOffset;
			if (customBuildOffset)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.buildForwardOffset = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Offset: ", D5l46jlssr4TRAzUSXzLj0uqu.buildForwardOffset, 0f, 8f, -1);
				D5l46jlssr4TRAzUSXzLj0uqu.buildYOffset = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Offset Y: ", D5l46jlssr4TRAzUSXzLj0uqu.buildYOffset, -4f, 4f, -1);
			}
			D5l46jlssr4TRAzUSXzLj0uqu.customDayTime = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.customDayTime, "Custom day time", Array.Empty<GUILayoutOption>());
			bool customDayTime = D5l46jlssr4TRAzUSXzLj0uqu.customDayTime;
			if (customDayTime)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.customTime = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Time: ", D5l46jlssr4TRAzUSXzLj0uqu.customTime, 0f, 1f, -1);
			}
			D5l46jlssr4TRAzUSXzLj0uqu.randomSwapingFace = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.randomSwapingFace, "Random face swapping", Array.Empty<GUILayoutOption>());
			bool randomSwapingFace = D5l46jlssr4TRAzUSXzLj0uqu.randomSwapingFace;
			if (randomSwapingFace)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.faceSwapDelay = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Face swap delay: ", D5l46jlssr4TRAzUSXzLj0uqu.faceSwapDelay, 0.1f, 3f, -1);
			}
			D5l46jlssr4TRAzUSXzLj0uqu.modifyMoveBehaviour = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.modifyMoveBehaviour, "Enable Player Spinbot", Array.Empty<GUILayoutOption>());
			bool modifyMoveBehaviour = D5l46jlssr4TRAzUSXzLj0uqu.modifyMoveBehaviour;
			if (modifyMoveBehaviour)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.moveType = D5l46jlssr4TRAzUSXzLj0uqu.moveType.DdoC7WUc7IFAmnWoLcSWPOXFw("Move rotation type: ", D5l46jlssr4TRAzUSXzLj0uqu.moveType.D2uLy2Wbnd3dl3UpzAGrd6DCL());
				D5l46jlssr4TRAzUSXzLj0uqu.showMoveModifying = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.showMoveModifying, "Show spinbot rotation", Array.Empty<GUILayoutOption>());
			}
			bool flag15 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Open nearby items window", -1, true, null);
			if (flag15)
			{
				D0MkIyl7CS81FHd522P7IXmir.opened = true;
			}
			D5l46jlssr4TRAzUSXzLj0uqu.spyType = D5l46jlssr4TRAzUSXzLj0uqu.spyType.DdoC7WUc7IFAmnWoLcSWPOXFw("AntiSpy Type: ", D5l46jlssr4TRAzUSXzLj0uqu.spyType.DjQEl00wkokoQvcg4zoynePAI());
			D5l46jlssr4TRAzUSXzLj0uqu.notifyAboutSpy = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.notifyAboutSpy, "Notify about spy", Array.Empty<GUILayoutOption>());
			bool flag16 = D5l46jlssr4TRAzUSXzLj0uqu.spyType == DEaNNGRxJag20zwKVRmcuyQsU.SpyWithDelay;
			if (flag16)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.spyDelayTimer = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Spy delay: ", D5l46jlssr4TRAzUSXzLj0uqu.spyDelayTimer, 0.15f, 2f, -1);
			}
			else
			{
				bool flag17 = D5l46jlssr4TRAzUSXzLj0uqu.spyType == DEaNNGRxJag20zwKVRmcuyQsU.SendCustomImage;
				if (flag17)
				{
					GUILayout.Label("Custom image sends from path " + Application.dataPath + "/spyimage.png, if image doesn't exist spy declines", Array.Empty<GUILayoutOption>());
				}
			}
			bool notifyAboutSpy = D5l46jlssr4TRAzUSXzLj0uqu.notifyAboutSpy;
			if (notifyAboutSpy)
			{
				D5l46jlssr4TRAzUSXzLj0uqu.spyWindowSize = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Window size: ", D5l46jlssr4TRAzUSXzLj0uqu.spyWindowSize, 25, 200, -1);
			}
			D5l46jlssr4TRAzUSXzLj0uqu.hwidType = D5l46jlssr4TRAzUSXzLj0uqu.hwidType.DdoC7WUc7IFAmnWoLcSWPOXFw("HWID type: ", D5l46jlssr4TRAzUSXzLj0uqu.hwidType.DuubTBloaQZGfJumICGlMLU54());
			bool flag18 = D5l46jlssr4TRAzUSXzLj0uqu.hwidType == DyZOPUgVlLGDIfwra38xGmDBF.SendRealHWID;
			if (flag18)
			{
				bool flag19 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Change real HWID", -1, true, null);
				if (flag19)
				{
					DubwRZDNcKTA0S1bUvkpiAdy4.DSae8LpHiiREqS3pu7fL1kRLr();
				}
			}
			else
			{
				bool flag20 = D5l46jlssr4TRAzUSXzLj0uqu.hwidType == DyZOPUgVlLGDIfwra38xGmDBF.UsePseudoHWID || D5l46jlssr4TRAzUSXzLj0uqu.hwidType == DyZOPUgVlLGDIfwra38xGmDBF.SendLinuxPseudoHWID;
				if (flag20)
				{
					ushort num2 = 0;
					ushort num3 = 0;
					ushort num4 = 0;
					foreach (byte b in D5l46jlssr4TRAzUSXzLj0uqu.DRywCzlrtImzxkGhDOTGcBASd)
					{
						num2 += (ushort)b;
					}
					foreach (byte b2 in D5l46jlssr4TRAzUSXzLj0uqu.DTJpui0sqNkukyZlpsiFS5Vbv)
					{
						num3 += (ushort)b2;
					}
					foreach (byte b3 in D5l46jlssr4TRAzUSXzLj0uqu.DHuZ6stX7WaYQtYnBbmwbMew0)
					{
						num4 += (ushort)b3;
					}
					GUILayout.Label("Pseudo player prefs HWID hash: " + num2.ToString(), Array.Empty<GUILayoutOption>());
					GUILayout.Label("Pseudo convient savedata HWID hash: " + num3.ToString(), Array.Empty<GUILayoutOption>());
					bool flag21 = D5l46jlssr4TRAzUSXzLj0uqu.hwidType == DyZOPUgVlLGDIfwra38xGmDBF.UsePseudoHWID;
					if (flag21)
					{
						GUILayout.Label("Pseudo Windows HWID hash: " + num4.ToString(), Array.Empty<GUILayoutOption>());
					}
					bool flag22 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Change pseudo HWID", -1, true, null);
					if (flag22)
					{
						DubwRZDNcKTA0S1bUvkpiAdy4.D3oogpAfEzKKlsLUnPd5YLmKA();
					}
					GUILayout.Label("Information about HWIDS: the game has 3 types of hashes and gets it from different sources, you can change  all 3 HWIDS and save them", Array.Empty<GUILayoutOption>());
				}
			}
			D5l46jlssr4TRAzUSXzLj0uqu.sendRandomSteamID = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(D5l46jlssr4TRAzUSXzLj0uqu.sendRandomSteamID, "Custom steam ID", Array.Empty<GUILayoutOption>());
			bool sendRandomSteamID = D5l46jlssr4TRAzUSXzLj0uqu.sendRandomSteamID;
			if (sendRandomSteamID)
			{
				GUILayout.Label("Custom steam ID:", Array.Empty<GUILayoutOption>());
				try
				{
					D5l46jlssr4TRAzUSXzLj0uqu.customSteamID = ulong.Parse(GUILayout.TextField(D5l46jlssr4TRAzUSXzLj0uqu.customSteamID.ToString(), Array.Empty<GUILayoutOption>()));
				}
				catch
				{
				}
			}
			bool flag23 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Unlock all achievments", -1, true, null);
			if (flag23)
			{
				D6H4vx51Upp3wVWFHU03x0ZDN.DResvQWS2VNStYlarlYk5IVVp();
			}
			GUILayout.EndScrollView();
		}
	}

	// Token: 0x04000408 RID: 1032
	public Vector2 D5HK925z7udI4FYDC7e7C03QS = Vector2.zero;

	// Token: 0x04000409 RID: 1033
	public Vector2 DW3xwFgQ13mzkr4zyrBQnAl0i = Vector2.zero;

	// Token: 0x0400040A RID: 1034
	public Vector2 autoPickupScroll = Vector2.zero;
}
