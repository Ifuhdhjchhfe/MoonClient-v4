using System;

// Token: 0x0200005A RID: 90
public static class DfU4wrswBK5kLyiyV6mHZwOg8
{
	// Token: 0x1700001B RID: 27
	// (get) Token: 0x060001A9 RID: 425 RVA: 0x000169E8 File Offset: 0x00014BE8
	// (set) Token: 0x060001AA RID: 426 RVA: 0x00016A00 File Offset: 0x00014C00
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Smooth open time")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float smoothOpenTime
	{
		get
		{
			return DfU4wrswBK5kLyiyV6mHZwOg8.D1PXsaqNEUlObvKdq09Vo87qu;
		}
		set
		{
			bool flag = DfU4wrswBK5kLyiyV6mHZwOg8.D1PXsaqNEUlObvKdq09Vo87qu != value;
			if (flag)
			{
				bool menuOpened = DL3tNdrQzY7o8FV1oIOKODOLQ.menuOpened;
				if (menuOpened)
				{
					DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS = value;
				}
			}
			DfU4wrswBK5kLyiyV6mHZwOg8.D1PXsaqNEUlObvKdq09Vo87qu = value;
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x060001AB RID: 427 RVA: 0x00016A38 File Offset: 0x00014C38
	// (set) Token: 0x060001AC RID: 428 RVA: 0x00016A50 File Offset: 0x00014C50
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Chamsed repaint own skin")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool chamsedRepaintOwnSkin
	{
		get
		{
			return DfU4wrswBK5kLyiyV6mHZwOg8.DRDKFbFnlLqNBmElpylZxkTWI;
		}
		set
		{
			bool flag = false;
			bool flag2 = value != DfU4wrswBK5kLyiyV6mHZwOg8.DRDKFbFnlLqNBmElpylZxkTWI;
			if (flag2)
			{
				flag = true;
			}
			DfU4wrswBK5kLyiyV6mHZwOg8.DRDKFbFnlLqNBmElpylZxkTWI = value;
			bool flag3 = flag;
			if (flag3)
			{
				try
				{
					DVWbzlF8EMqi1xEQwNWSt4Ft9.DKELnmSyoyan090PSySBhxojk();
				}
				catch
				{
				}
			}
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x060001AD RID: 429 RVA: 0x00016AA0 File Offset: 0x00014CA0
	// (set) Token: 0x060001AE RID: 430 RVA: 0x00016AB7 File Offset: 0x00014CB7
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Blur on menu")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool blurOnMenu
	{
		get
		{
			return DfU4wrswBK5kLyiyV6mHZwOg8.DTFVirkxHz8LyaVDlju6clw33;
		}
		set
		{
		}
	}

	// Token: 0x040001EC RID: 492
	public static bool D1AQ46eyZ4en8O9lvEaM2XsRP = false;

	// Token: 0x040001ED RID: 493
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Menu width")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int menuWidth = 640;

	// Token: 0x040001EE RID: 494
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Menu height")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int menuHeight = 480;

	// Token: 0x040001EF RID: 495
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Draw tracers")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool drawTracers = false;

	// Token: 0x040001F0 RID: 496
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Use GL tracers")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool useGLTracers = false;

	// Token: 0x040001F1 RID: 497
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Tracer type")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static D5VsESizw2NoAi19PtCEVYVgW tracerType = D5VsESizw2NoAi19PtCEVYVgW.BallisticMoved;

	// Token: 0x040001F2 RID: 498
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Tracers width")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float tracersWidth = 0.15f;

	// Token: 0x040001F3 RID: 499
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Tracers lifetime")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float tracersLifetime = 3f;

	// Token: 0x040001F4 RID: 500
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Waling tracers")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool walkingTracers;

	// Token: 0x040001F5 RID: 501
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "See own walking tracers")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool seeOwnWalkingTracers = true;

	// Token: 0x040001F6 RID: 502
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Walking tracers width")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float walkingTracersWidth = 0.3f;

	// Token: 0x040001F7 RID: 503
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Walking tracers lifetime")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float walkingTracersLifetime = 2f;

	// Token: 0x040001F8 RID: 504
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Walking tracers draw distance")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int walkingTracersDrawDistance = 75;

	// Token: 0x040001F9 RID: 505
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Draw horizontal info-panel")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool drawHorizontalInfoPanel = false;

	// Token: 0x040001FA RID: 506
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Info-panel padding from screen")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int infoPanelPaddingFromScreen = 15;

	// Token: 0x040001FB RID: 507
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Info-panel size")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int infoPanelSize = 15;

	// Token: 0x040001FC RID: 508
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Draw info-panel padding")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool drawInfoPanelPadding = true;

	// Token: 0x040001FD RID: 509
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Info-panel padding")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int infoPanelPadding = 3;

	// Token: 0x040001FE RID: 510
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Info-panel padding placement")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static DuS8uf732VHhCWZLtWsVr3zfy infoPanelPaddingPlacement = DuS8uf732VHhCWZLtWsVr3zfy.Bottom;

	// Token: 0x040001FF RID: 511
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Use custom crosshair")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool useCustomCrosshair = false;

	// Token: 0x04000200 RID: 512
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Force disable default crosshair")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool forceDisableDefaultCrosshair = true;

	// Token: 0x04000201 RID: 513
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Crosshair type")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static DdAT8d84ifnXbB75Ww07uS98r crosshairType = DdAT8d84ifnXbB75Ww07uS98r.Solid;

	// Token: 0x04000202 RID: 514
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Crosshair height")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int crosshairHeight = 6;

	// Token: 0x04000203 RID: 515
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Crosshair width")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int crosshairWidth = 2;

	// Token: 0x04000204 RID: 516
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Crosshair gap")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int crosshairGap = 2;

	// Token: 0x04000205 RID: 517
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Player tracers working distance")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int playerTracersWorkingDistance = 100;

	// Token: 0x04000206 RID: 518
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Max player tracer points")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int maxPlayerTracerPoints = 60;

	// Token: 0x04000207 RID: 519
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Draw damage hitmarks")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool drawDamageHitmark = false;

	// Token: 0x04000208 RID: 520
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Damage hitmarks lifetime")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float damageHitmarksLifetime = 5f;

	// Token: 0x04000209 RID: 521
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Is damage hitmarkers combined")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool isDamageHitmarkersCombined = false;

	// Token: 0x0400020A RID: 522
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Scale combined hitmarkers")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool scaleCombinedHitmarkers = true;

	// Token: 0x0400020B RID: 523
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Damage hitmarks combine distance")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float damageHitmarksCombineDistance = 1.5f;

	// Token: 0x0400020C RID: 524
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Disallow particles")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool disallowParticles = false;

	// Token: 0x0400020D RID: 525
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Disallow weapon traces")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool disallowWeaponTraces = false;

	// Token: 0x0400020E RID: 526
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Draw info")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool drawInfo = true;

	// Token: 0x0400020F RID: 527
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Draw background blackout")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool drawBackgroundBlackout = true;

	// Token: 0x04000210 RID: 528
	public static bool DTFVirkxHz8LyaVDlju6clw33 = true;

	// Token: 0x04000211 RID: 529
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Menu circling radius")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int menuCirclingRadius = 5;

	// Token: 0x04000212 RID: 530
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Smooth menu open")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool smoothMenuOpen = true;

	// Token: 0x04000213 RID: 531
	public static float D1PXsaqNEUlObvKdq09Vo87qu = 0.25f;

	// Token: 0x04000214 RID: 532
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Use legacy sliders")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool useLegacySliders = false;

	// Token: 0x04000215 RID: 533
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Rainbow fading on menu header")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool rainbowFadingOnMenuHeader = false;

	// Token: 0x04000216 RID: 534
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Enable user logger")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool enableUserLogger = false;

	// Token: 0x04000217 RID: 535
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Logger text outline")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static DcyOGWtOfXF1Fhr1GWr4wf6Ww loggerTextOutline = DcyOGWtOfXF1Fhr1GWr4wf6Ww.None;

	// Token: 0x04000218 RID: 536
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Logger text case")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static DVeWYqH4HEAYXL5Vu3HrmvSnF loggerTextCase = DVeWYqH4HEAYXL5Vu3HrmvSnF.Default;

	// Token: 0x04000219 RID: 537
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Player steps circle")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool playerStepsCircle = false;

	// Token: 0x0400021A RID: 538
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "See own steps")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool seeOwnSteps = false;

	// Token: 0x0400021B RID: 539
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Steps draw distance")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int stepsDrawDistance = 100;

	// Token: 0x0400021C RID: 540
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Steps spreading distance")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float stepsSpreadingDistance = 1f;

	// Token: 0x0400021D RID: 541
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Steps run distance multiplier")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float stepsRunDistanceMultiplier = 1.5f;

	// Token: 0x0400021E RID: 542
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Steps drop distance multiplier")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float stepsDropDistanceMultiplier = 1.8f;

	// Token: 0x0400021F RID: 543
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Visual options", "Steps lifetime")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float stepsLifetime = 1f;

	// Token: 0x04000220 RID: 544
	public static bool DRDKFbFnlLqNBmElpylZxkTWI = false;
}
