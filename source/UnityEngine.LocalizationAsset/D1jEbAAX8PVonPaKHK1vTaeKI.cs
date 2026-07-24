using System;
using UnityEngine;

// Token: 0x0200000E RID: 14
public class D1jEbAAX8PVonPaKHK1vTaeKI : DOEkZ1zoBEuvfUmOs9QSpfX0X
{
	// Token: 0x06000041 RID: 65 RVA: 0x00003EE0 File Offset: 0x000020E0
	public override string GetName()
	{
		return "World";
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00003EF8 File Offset: 0x000020F8
	public override DYIPJORHeVCfbpocFHvJty4OE GetTabCounts()
	{
		return DYIPJORHeVCfbpocFHvJty4OE.Three;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00003F0C File Offset: 0x0000210C
	public override void DoTab(DYIPJORHeVCfbpocFHvJty4OE tc)
	{
		bool flag = tc == DYIPJORHeVCfbpocFHvJty4OE.One;
		if (flag)
		{
			base.DGLNJE6Ld056OViYFjOM7IeMS("Optimization");
			DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Master texture limit: " + QualitySettings.masterTextureLimit.ToString(), -1, true, null);
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			for (int i = 0; i < 6; i++)
			{
				bool flag2 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv(i.ToString(), -1, true, null);
				if (flag2)
				{
					QualitySettings.masterTextureLimit = i;
				}
			}
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			for (int j = 6; j < 11; j++)
			{
				bool flag3 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv(j.ToString(), -1, true, null);
				if (flag3)
				{
					QualitySettings.masterTextureLimit = j;
				}
			}
			GUILayout.EndHorizontal();
			QualitySettings.lodBias = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("LOD scaling: ", QualitySettings.lodBias, 0.05f, 20f, -1);
			DfU4wrswBK5kLyiyV6mHZwOg8.disallowParticles = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.disallowParticles, "Remove Game Particles", Array.Empty<GUILayoutOption>());
			DfU4wrswBK5kLyiyV6mHZwOg8.disallowWeaponTraces = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.disallowWeaponTraces, "Remove Weapon Traces", Array.Empty<GUILayoutOption>());
			bool flag4 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Remove Game Skybox", -1, true, null);
			if (flag4)
			{
				RenderSettings.skybox = null;
			}
			bool flag5 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Remove All Game UIs", -1, true, null);
			if (flag5)
			{
				DrysTRTjdLdFqu5GJBDif6AoV.Dc5G5b2tFddCQj0OX40sUl3g0();
			}
			bool flag6 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Remove Game Camera Scripts", -1, true, null);
			if (flag6)
			{
				DWvadVuZjKj0DS21tCR9H9ssW.DK4LtFEbXnNhqVrnftTBVphWa();
			}
		}
		else
		{
			bool flag7 = tc == DYIPJORHeVCfbpocFHvJty4OE.Two;
			if (flag7)
			{
				D1jEbAAX8PVonPaKHK1vTaeKI.DYNMhiRbcAEcmHpkY0UFxVU9D = GUILayout.BeginScrollView(D1jEbAAX8PVonPaKHK1vTaeKI.DYNMhiRbcAEcmHpkY0UFxVU9D, Array.Empty<GUILayoutOption>());
				base.DGLNJE6Ld056OViYFjOM7IeMS("Preferences");
				DfU4wrswBK5kLyiyV6mHZwOg8.drawTracers = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.drawTracers, "Draw Weapon Tracers", Array.Empty<GUILayoutOption>());
				bool drawTracers = DfU4wrswBK5kLyiyV6mHZwOg8.drawTracers;
				if (drawTracers)
				{
					DfU4wrswBK5kLyiyV6mHZwOg8.useGLTracers = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.useGLTracers, "Use GL tracers", Array.Empty<GUILayoutOption>());
					DfU4wrswBK5kLyiyV6mHZwOg8.tracerType = DfU4wrswBK5kLyiyV6mHZwOg8.tracerType.DdoC7WUc7IFAmnWoLcSWPOXFw("Tracer type: ", DfU4wrswBK5kLyiyV6mHZwOg8.tracerType.DSddEPkLiOTPfTgVxiX4VviQ0());
					DfU4wrswBK5kLyiyV6mHZwOg8.tracersLifetime = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Tracer lifetime: ", DfU4wrswBK5kLyiyV6mHZwOg8.tracersLifetime, 0f, 6f, -1);
					DfU4wrswBK5kLyiyV6mHZwOg8.tracersWidth = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Tracer width: ", DfU4wrswBK5kLyiyV6mHZwOg8.tracersWidth, 0f, 1f, -1);
				}
				DfU4wrswBK5kLyiyV6mHZwOg8.drawDamageHitmark = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.drawDamageHitmark, "Draw damage hitmark", Array.Empty<GUILayoutOption>());
				bool drawDamageHitmark = DfU4wrswBK5kLyiyV6mHZwOg8.drawDamageHitmark;
				if (drawDamageHitmark)
				{
					DfU4wrswBK5kLyiyV6mHZwOg8.damageHitmarksLifetime = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Damage hitmarks: ", DfU4wrswBK5kLyiyV6mHZwOg8.damageHitmarksLifetime, 0f, 10f, -1);
					DfU4wrswBK5kLyiyV6mHZwOg8.isDamageHitmarkersCombined = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.isDamageHitmarkersCombined, "Use combined damage hitmarkers", Array.Empty<GUILayoutOption>());
					bool isDamageHitmarkersCombined = DfU4wrswBK5kLyiyV6mHZwOg8.isDamageHitmarkersCombined;
					if (isDamageHitmarkersCombined)
					{
						DfU4wrswBK5kLyiyV6mHZwOg8.damageHitmarksCombineDistance = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Damage hitmarkers combine distance: ", DfU4wrswBK5kLyiyV6mHZwOg8.damageHitmarksCombineDistance, 0f, 5f, -1);
					}
				}
				DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracers = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracers, "Walking tracers", Array.Empty<GUILayoutOption>());
				bool walkingTracers = DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracers;
				if (walkingTracers)
				{
					DfU4wrswBK5kLyiyV6mHZwOg8.seeOwnWalkingTracers = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.seeOwnWalkingTracers, "See own walking tracers", Array.Empty<GUILayoutOption>());
					DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracersWidth = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Walking tracers width: ", DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracersWidth, 0.01f, 1f, -1);
					DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracersLifetime = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Walking tracers lifetime: ", DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracersLifetime, 0f, 6f, -1);
					DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracersDrawDistance = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Walking tracers draw distnace: ", DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracersDrawDistance, 10, 250, -1);
				}
				DfU4wrswBK5kLyiyV6mHZwOg8.useCustomCrosshair = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.useCustomCrosshair, "Use custom crosshair", Array.Empty<GUILayoutOption>());
				bool useCustomCrosshair = DfU4wrswBK5kLyiyV6mHZwOg8.useCustomCrosshair;
				if (useCustomCrosshair)
				{
					DfU4wrswBK5kLyiyV6mHZwOg8.forceDisableDefaultCrosshair = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.forceDisableDefaultCrosshair, "Force disable default crosshair", Array.Empty<GUILayoutOption>());
					DfU4wrswBK5kLyiyV6mHZwOg8.crosshairWidth = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Crosshair width: ", DfU4wrswBK5kLyiyV6mHZwOg8.crosshairWidth, 1, 15, -1);
					DfU4wrswBK5kLyiyV6mHZwOg8.crosshairHeight = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Crosshair height: ", DfU4wrswBK5kLyiyV6mHZwOg8.crosshairHeight, 2, 40, -1);
					bool flag8 = DfU4wrswBK5kLyiyV6mHZwOg8.crosshairType == DdAT8d84ifnXbB75Ww07uS98r.Gap;
					if (flag8)
					{
						DfU4wrswBK5kLyiyV6mHZwOg8.crosshairGap = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Crosshair gap: ", DfU4wrswBK5kLyiyV6mHZwOg8.crosshairGap, 0, 20, -1);
					}
					DfU4wrswBK5kLyiyV6mHZwOg8.crosshairType = DfU4wrswBK5kLyiyV6mHZwOg8.crosshairType.DdoC7WUc7IFAmnWoLcSWPOXFw("Crosshair type: ", DfU4wrswBK5kLyiyV6mHZwOg8.crosshairType.ToString());
				}
				DfU4wrswBK5kLyiyV6mHZwOg8.drawHorizontalInfoPanel = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.drawHorizontalInfoPanel, "Draw horizontal info-panel", Array.Empty<GUILayoutOption>());
				bool drawHorizontalInfoPanel = DfU4wrswBK5kLyiyV6mHZwOg8.drawHorizontalInfoPanel;
				if (drawHorizontalInfoPanel)
				{
					DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelPaddingFromScreen = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Info-panel padding from screen: ", DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelPaddingFromScreen, 0, 50, -1);
					DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelSize = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Info-panel size: ", DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelSize, 6, 35, -1);
					DfU4wrswBK5kLyiyV6mHZwOg8.drawInfoPanelPadding = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.drawInfoPanelPadding, "Draw info-panel padding", Array.Empty<GUILayoutOption>());
					bool drawInfoPanelPadding = DfU4wrswBK5kLyiyV6mHZwOg8.drawInfoPanelPadding;
					if (drawInfoPanelPadding)
					{
						DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelPadding = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Info-panel padding: ", DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelPadding, 0, 5, -1);
						DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelPaddingPlacement = DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelPaddingPlacement.DdoC7WUc7IFAmnWoLcSWPOXFw("Padding placement: ", DfU4wrswBK5kLyiyV6mHZwOg8.infoPanelPaddingPlacement.ToString());
					}
				}
				DfU4wrswBK5kLyiyV6mHZwOg8.drawInfo = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.drawInfo, "Draw info", Array.Empty<GUILayoutOption>());
				DfU4wrswBK5kLyiyV6mHZwOg8.drawBackgroundBlackout = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.drawBackgroundBlackout, "Draw background blackout", Array.Empty<GUILayoutOption>());
				DfU4wrswBK5kLyiyV6mHZwOg8.smoothMenuOpen = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.smoothMenuOpen, "Smooth menu open", Array.Empty<GUILayoutOption>());
				bool smoothMenuOpen = DfU4wrswBK5kLyiyV6mHZwOg8.smoothMenuOpen;
				if (smoothMenuOpen)
				{
					DfU4wrswBK5kLyiyV6mHZwOg8.smoothOpenTime = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Smooth open time: ", DfU4wrswBK5kLyiyV6mHZwOg8.smoothOpenTime, 0.05f, 0.5f, -1);
				}
				DfU4wrswBK5kLyiyV6mHZwOg8.menuCirclingRadius = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Menu circling: ", DfU4wrswBK5kLyiyV6mHZwOg8.menuCirclingRadius, 0, 20, -1);
				DfU4wrswBK5kLyiyV6mHZwOg8.enableUserLogger = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.enableUserLogger, "Use user logger", Array.Empty<GUILayoutOption>());
				bool enableUserLogger = DfU4wrswBK5kLyiyV6mHZwOg8.enableUserLogger;
				if (enableUserLogger)
				{
					DfU4wrswBK5kLyiyV6mHZwOg8.loggerTextOutline = DfU4wrswBK5kLyiyV6mHZwOg8.loggerTextOutline.DdoC7WUc7IFAmnWoLcSWPOXFw("Logger text outline: ", DfU4wrswBK5kLyiyV6mHZwOg8.loggerTextOutline.DZFMFmrqCczLVGAHUj4B9oP5G());
					DfU4wrswBK5kLyiyV6mHZwOg8.loggerTextCase = DfU4wrswBK5kLyiyV6mHZwOg8.loggerTextCase.DdoC7WUc7IFAmnWoLcSWPOXFw("Logger text case: ", DfU4wrswBK5kLyiyV6mHZwOg8.loggerTextCase.DhxxszNNT65SPllEv6XuYmIEa());
				}
				DfU4wrswBK5kLyiyV6mHZwOg8.playerStepsCircle = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.playerStepsCircle, "Circle player steps", Array.Empty<GUILayoutOption>());
				bool playerStepsCircle = DfU4wrswBK5kLyiyV6mHZwOg8.playerStepsCircle;
				if (playerStepsCircle)
				{
					DfU4wrswBK5kLyiyV6mHZwOg8.seeOwnSteps = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.seeOwnSteps, "See own steps", Array.Empty<GUILayoutOption>());
					DfU4wrswBK5kLyiyV6mHZwOg8.stepsDrawDistance = DrysTRTjdLdFqu5GJBDif6AoV.DhaoW4JmdlGy7n9uEK8N06dTr("Steps draw distance: ", DfU4wrswBK5kLyiyV6mHZwOg8.stepsDrawDistance, 5, 500, -1);
					DfU4wrswBK5kLyiyV6mHZwOg8.stepsLifetime = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Steps lifetime: ", DfU4wrswBK5kLyiyV6mHZwOg8.stepsLifetime, 0.25f, 5f, -1);
					DfU4wrswBK5kLyiyV6mHZwOg8.stepsSpreadingDistance = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Steps spreading distance: ", DfU4wrswBK5kLyiyV6mHZwOg8.stepsSpreadingDistance, 0f, 5f, -1);
					DfU4wrswBK5kLyiyV6mHZwOg8.stepsRunDistanceMultiplier = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Steps run distance multiplier: ", DfU4wrswBK5kLyiyV6mHZwOg8.stepsRunDistanceMultiplier, 1f, 4f, -1);
					DfU4wrswBK5kLyiyV6mHZwOg8.stepsDropDistanceMultiplier = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Steps drop distance multiplier: ", DfU4wrswBK5kLyiyV6mHZwOg8.stepsDropDistanceMultiplier, 1f, 4f, -1);
				}
				DfU4wrswBK5kLyiyV6mHZwOg8.chamsedRepaintOwnSkin = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(DfU4wrswBK5kLyiyV6mHZwOg8.chamsedRepaintOwnSkin, "Enable Self Chams", Array.Empty<GUILayoutOption>());
				GUILayout.EndScrollView();
			}
			else
			{
				base.DGLNJE6Ld056OViYFjOM7IeMS("Viewmodel");
				D1jEbAAX8PVonPaKHK1vTaeKI.fovAim = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("FOV aim: ", D1jEbAAX8PVonPaKHK1vTaeKI.fovAim, 15f, 180f, -1);
				D1jEbAAX8PVonPaKHK1vTaeKI.fovHip = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("FOV hip: ", D1jEbAAX8PVonPaKHK1vTaeKI.fovHip, 15f, 180f, -1);
				D1jEbAAX8PVonPaKHK1vTaeKI.offsetDepth = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Offset depth: ", D1jEbAAX8PVonPaKHK1vTaeKI.offsetDepth, -5f, 5f, -1);
				D1jEbAAX8PVonPaKHK1vTaeKI.offsetHorizontal = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Offset horizontal: ", D1jEbAAX8PVonPaKHK1vTaeKI.offsetHorizontal, -5f, 5f, -1);
				D1jEbAAX8PVonPaKHK1vTaeKI.offsetVertical = DrysTRTjdLdFqu5GJBDif6AoV.DthVWrAR0a2RmWEgiCZM30SCV("Offset vertical: ", D1jEbAAX8PVonPaKHK1vTaeKI.offsetVertical, -5f, 5f, -1);
			}
		}
	}

	// Token: 0x0400001D RID: 29
	public static Vector2 DYNMhiRbcAEcmHpkY0UFxVU9D = Vector2.zero;

	// Token: 0x0400001E RID: 30
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Viewmodel", "FOV aim")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float fovAim = 90f;

	// Token: 0x0400001F RID: 31
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Viewmodel", "FOV hip")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float fovHip = 90f;

	// Token: 0x04000020 RID: 32
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Viewmodel", "Offset depth")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float offsetDepth = 0f;

	// Token: 0x04000021 RID: 33
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Viewmodel", "Offset horizontal")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float offsetHorizontal = 0f;

	// Token: 0x04000022 RID: 34
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Viewmodel", "Offset vertical")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float offsetVertical = 0f;
}
