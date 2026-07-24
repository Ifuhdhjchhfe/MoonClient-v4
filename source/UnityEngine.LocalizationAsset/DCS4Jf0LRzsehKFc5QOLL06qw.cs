using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000040 RID: 64
public static class DCS4Jf0LRzsehKFc5QOLL06qw
{
	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600010E RID: 270 RVA: 0x0000BAAC File Offset: 0x00009CAC
	public static bool enableAim
	{
		get
		{
			return DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim || DCS4Jf0LRzsehKFc5QOLL06qw.enableMeleeSilentAim || DCS4Jf0LRzsehKFc5QOLL06qw.enableAimbot;
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x0600010F RID: 271 RVA: 0x0000BAD4 File Offset: 0x00009CD4
	public static bool expandRangeBySphere
	{
		get
		{
			return DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim && DCS4Jf0LRzsehKFc5QOLL06qw.silentAimType == DokdtlMHqRTX0KbeCtveFDTNT.Sphere && DCS4Jf0LRzsehKFc5QOLL06qw.additiveRangeBySphereSize;
		}
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0000BAFD File Offset: 0x00009CFD
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Toggle Memory Aimbot")]
	public static void ToggleMemoryAimbot()
	{
		DCS4Jf0LRzsehKFc5QOLL06qw.enableAimbot = !DCS4Jf0LRzsehKFc5QOLL06qw.enableAimbot;
	}

	// Token: 0x06000111 RID: 273 RVA: 0x0000BB0D File Offset: 0x00009D0D
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Toggle Silent Aimbot")]
	public static void ToggleSilentAim()
	{
		DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim = !DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim;
	}

	// Token: 0x0400013D RID: 317
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Enable aimbot")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool enableAimbot = false;

	// Token: 0x0400013E RID: 318
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Enable silent aim")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool enableSilentAim = false;

	// Token: 0x0400013F RID: 319
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Enable melee silent aim")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool enableMeleeSilentAim = false;

	// Token: 0x04000140 RID: 320
	public static List<DaqXfD9Fjc9IG7oF0OAH4hEOR> DktrbPy2H7CKo1hvmcfRd62lY = new List<DaqXfD9Fjc9IG7oF0OAH4hEOR>
	{
		new DaqXfD9Fjc9IG7oF0OAH4hEOR(1f, 8)
	};

	// Token: 0x04000141 RID: 321
	public static float Db55lznlFok53zZBv0jDuw4gi = 1f;

	// Token: 0x04000142 RID: 322
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Distance to hit")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int distanceToHit = 15;

	// Token: 0x04000143 RID: 323
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Aim target distance")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int aimTargetDistance = 200;

	// Token: 0x04000144 RID: 324
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Aiming chance")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int aimingChance = 100;

	// Token: 0x04000145 RID: 325
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Hit mark size")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int hitMarkSize = 10;

	// Token: 0x04000146 RID: 326
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Preview hit point")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool previewHitPoint = true;

	// Token: 0x04000147 RID: 327
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Draw line from hit point")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool drawLineFromHitPoint = false;

	// Token: 0x04000148 RID: 328
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Draw line from player head")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool drawLineFromPlayerHead = false;

	// Token: 0x04000149 RID: 329
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Smooth aimbot")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool smoothAimbot = true;

	// Token: 0x0400014A RID: 330
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Smooth aimbot speed")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float smoothAimbotSpeed = 3f;

	// Token: 0x0400014B RID: 331
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Restrict aim by fov")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool restrictAimByFov = true;

	// Token: 0x0400014C RID: 332
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Check aim with linecast")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool checkWithLinecast = true;

	// Token: 0x0400014D RID: 333
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Always aim")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool alwaysAim = false;

	// Token: 0x0400014E RID: 334
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Draw target")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool drawTarget = true;

	// Token: 0x0400014F RID: 335
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Set distance by gun range")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool setDistanceByGunRange = true;

	// Token: 0x04000150 RID: 336
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Straight raycasting")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool straightRaycasting = true;

	// Token: 0x04000151 RID: 337
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Trace from hit")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool traceFromOrigin = false;

	// Token: 0x04000152 RID: 338
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Verify forward hit point aviablity")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool verifyForwardHitPointAviablity = true;

	// Token: 0x04000153 RID: 339
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Verify trace by linecast")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool verifyTraceByLinecast = false;

	// Token: 0x04000154 RID: 340
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Verify sphere to player point by linecast")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool verifySphereToPlayerPointByLinecast = false;

	// Token: 0x04000155 RID: 341
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Set hit point to transform")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool hitPointToTransform = true;

	// Token: 0x04000156 RID: 342
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Manually calculate ballistic distance")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool manuallyCalculateBallisticDistance = true;

	// Token: 0x04000157 RID: 343
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Hook sphere point to bullet")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool hookSpherePointToBullet = true;

	// Token: 0x04000158 RID: 344
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Don't shoot players on safezone")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool dontShootPlayersOnSafezone = true;

	// Token: 0x04000159 RID: 345
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Additive range by sphere size")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool additiveRangeBySphereSize = true;

	// Token: 0x0400015A RID: 346
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Set hit point to camera if aviable")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool setHitPointToCameraIfAviable = true;

	// Token: 0x0400015B RID: 347
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Debug sphere points")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool debugSpherePoints = false;

	// Token: 0x0400015C RID: 348
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Best silent aim part preselective")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool bestSilentAimPartPreselective = true;

	// Token: 0x0400015D RID: 349
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Best aimbot part preselective")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool bestAimbotPartPreselective = true;

	// Token: 0x0400015E RID: 350
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Preview hit limb")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool previewHitLimb = true;

	// Token: 0x0400015F RID: 351
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Bullet delaying")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool bulletDelaying = false;

	// Token: 0x04000160 RID: 352
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Show bullet delaying timer")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool showBulletDelayingTimer = true;

	// Token: 0x04000161 RID: 353
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Unhold delay by mouse")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool unholdDelayByMouse = true;

	// Token: 0x04000162 RID: 354
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Momentaly unhold")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool momentalyUnhold = false;

	// Token: 0x04000163 RID: 355
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Bullet delay amount")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int bulletDelayAmount = 15;

	// Token: 0x04000164 RID: 356
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Bullet delay seconds")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float bulletDelaySeconds = 0f;

	// Token: 0x04000165 RID: 357
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Bullet delay keybind")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static KeyCode bulletDelayKeybind = KeyCode.F;

	// Token: 0x04000166 RID: 358
	public static bool waitingForDelayKey = false;

	// Token: 0x04000167 RID: 359
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Target line start X")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float targetLineStartX = 0.5f;

	// Token: 0x04000168 RID: 360
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Target line start Y")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float targetLineStartY = 0.5f;

	// Token: 0x04000169 RID: 361
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Aim sorting")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static DK27IZ62oGywnytdkDio7Gbp0 aimSorting = DK27IZ62oGywnytdkDio7Gbp0.FOV;

	// Token: 0x0400016A RID: 362
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Silent aim type")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static DokdtlMHqRTX0KbeCtveFDTNT silentAimType = DokdtlMHqRTX0KbeCtveFDTNT.Sphere;

	// Token: 0x0400016B RID: 363
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Aimbot limb")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static Drvin9V0cgPlOe7ofbFCim7y0 aimbotLimb = Drvin9V0cgPlOe7ofbFCim7y0.Head;

	// Token: 0x0400016C RID: 364
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Silent aim limb")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static Drvin9V0cgPlOe7ofbFCim7y0 silentAimLimb = Drvin9V0cgPlOe7ofbFCim7y0.Head;

	// Token: 0x0400016D RID: 365
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Silent aim hit point limb")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static Drvin9V0cgPlOe7ofbFCim7y0 silentAimHitPointLimb = Drvin9V0cgPlOe7ofbFCim7y0.Head;

	// Token: 0x0400016E RID: 366
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Aim options", "Random limb head hit chance")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int randomLimbHeadHitChance = 50;

	// Token: 0x0400016F RID: 367
	public static List<Dr5qliNNQh3jZolh9fn7SFNyi> DULiu9lLWSHNenYxzlK8xT984 = new List<Dr5qliNNQh3jZolh9fn7SFNyi> { Dr5qliNNQh3jZolh9fn7SFNyi.Player };

	// Token: 0x04000170 RID: 368
	public static bool De9sIv7zuXMINtQoDKkRkZvjg = false;
}
