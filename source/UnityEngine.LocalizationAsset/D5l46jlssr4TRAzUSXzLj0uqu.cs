using System;
using System.Collections.Generic;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200001B RID: 27
public static class D5l46jlssr4TRAzUSXzLj0uqu
{
	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000070 RID: 112 RVA: 0x000060E0 File Offset: 0x000042E0
	// (set) Token: 0x06000071 RID: 113 RVA: 0x000060F8 File Offset: 0x000042F8
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Modify player perspective")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool modifyPlayerPerspective
	{
		get
		{
			return D5l46jlssr4TRAzUSXzLj0uqu.DAg96DuTTiw8zzMFikpL3jNl0;
		}
		set
		{
			bool flag = value != D5l46jlssr4TRAzUSXzLj0uqu.DAg96DuTTiw8zzMFikpL3jNl0 && !value && Player.player != null;
			if (flag)
			{
				bool flag2;
				if (Player.player.look.perspective == EPlayerPerspective.THIRD)
				{
					ECameraMode d66xkrBp6Z1GTuSAAF2uDhRmK = D5l46jlssr4TRAzUSXzLj0uqu.D66xkrBp6Z1GTuSAAF2uDhRmK;
					flag2 = D5l46jlssr4TRAzUSXzLj0uqu.D66xkrBp6Z1GTuSAAF2uDhRmK == ECameraMode.VEHICLE && Player.player.movement.getVehicle() == null;
				}
				else
				{
					flag2 = false;
				}
				bool flag3 = flag2;
				if (flag3)
				{
					D5l46jlssr4TRAzUSXzLj0uqu.DxxYDukO6YYmib8AHaMY1hich.DGHrF0Ht2QRxL0NBgNHj6ZpZX(Player.player.look, new object[] { 0 });
				}
				else
				{
					EPlayerPerspective perspective = Player.player.look.perspective;
					bool flag4 = false;
					if (flag4)
					{
						D5l46jlssr4TRAzUSXzLj0uqu.DxxYDukO6YYmib8AHaMY1hich.DGHrF0Ht2QRxL0NBgNHj6ZpZX(Player.player.look, new object[] { 1 });
					}
				}
				Provider.cameraMode = D5l46jlssr4TRAzUSXzLj0uqu.D66xkrBp6Z1GTuSAAF2uDhRmK;
			}
			else
			{
				bool flag5 = value != D5l46jlssr4TRAzUSXzLj0uqu.DAg96DuTTiw8zzMFikpL3jNl0 && value && Provider.isConnected;
				if (flag5)
				{
					Provider.cameraMode = D5l46jlssr4TRAzUSXzLj0uqu.playerPerspective;
				}
			}
			D5l46jlssr4TRAzUSXzLj0uqu.DAg96DuTTiw8zzMFikpL3jNl0 = value;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000072 RID: 114 RVA: 0x00006208 File Offset: 0x00004408
	// (set) Token: 0x06000073 RID: 115 RVA: 0x00006220 File Offset: 0x00004420
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Freecamera")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool freeCamera
	{
		get
		{
			return D5l46jlssr4TRAzUSXzLj0uqu.DCXziB0kIOezVeYnpla5czLXA;
		}
		set
		{
			bool flag = D5l46jlssr4TRAzUSXzLj0uqu.DCXziB0kIOezVeYnpla5czLXA != value;
			if (flag)
			{
				if (value)
				{
					DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr = new GameObject("RTSCamera").AddComponent<DZW7dpbH5Qs7H7R6KJHZs0PUu>();
				}
				else
				{
					bool flag2 = DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr != null;
					if (flag2)
					{
						global::UnityEngine.Object.Destroy(DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.gameObject);
					}
				}
			}
			D5l46jlssr4TRAzUSXzLj0uqu.DCXziB0kIOezVeYnpla5czLXA = value;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000074 RID: 116 RVA: 0x00006284 File Offset: 0x00004484
	// (set) Token: 0x06000075 RID: 117 RVA: 0x0000629C File Offset: 0x0000449C
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Custom vehicle behaviour")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool customVehicleBehaviour
	{
		get
		{
			return D5l46jlssr4TRAzUSXzLj0uqu.D0DlzyHYujfZZ6obqTbnUo6xa;
		}
		set
		{
			bool flag = value != D5l46jlssr4TRAzUSXzLj0uqu.D0DlzyHYujfZZ6obqTbnUo6xa && !value && DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51 != null && DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.DBbFWh5f0i7R4pZC3PhoeVZn9 != null;
			if (flag)
			{
				DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.DBbFWh5f0i7R4pZC3PhoeVZn9.useGravity = true;
				DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.DBbFWh5f0i7R4pZC3PhoeVZn9.isKinematic = false;
			}
			D5l46jlssr4TRAzUSXzLj0uqu.D0DlzyHYujfZZ6obqTbnUo6xa = value;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000076 RID: 118 RVA: 0x00006304 File Offset: 0x00004504
	// (set) Token: 0x06000077 RID: 119 RVA: 0x0000631C File Offset: 0x0000451C
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Imit nightvision")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool imitNightvision
	{
		get
		{
			return D5l46jlssr4TRAzUSXzLj0uqu.DkdMeU2vgt5vFB6EUG1eZEFJE;
		}
		set
		{
			bool flag = D5l46jlssr4TRAzUSXzLj0uqu.DkdMeU2vgt5vFB6EUG1eZEFJE != value && !DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6;
			if (flag)
			{
				try
				{
					if (value)
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
						D5l46jlssr4TRAzUSXzLj0uqu.D0lIKBLGl32vj29YP9iicvtqI = LevelLighting.vision;
						LevelLighting.vision = D5l46jlssr4TRAzUSXzLj0uqu.nightVisionType.D6HbJZ2NUXUKMVsndz6x1ZFtz();
					}
					else
					{
						LevelLighting.vision = D5l46jlssr4TRAzUSXzLj0uqu.D0lIKBLGl32vj29YP9iicvtqI;
					}
					LevelLighting.updateLighting();
					try
					{
						LevelLighting.updateLocal();
					}
					catch
					{
					}
					try
					{
						D9sqUkDmUbz7uUc5edvQF8hDl.D2hcRGy0VyZxVqJMX9bijVbJx();
					}
					catch
					{
					}
				}
				catch
				{
				}
			}
			D5l46jlssr4TRAzUSXzLj0uqu.DkdMeU2vgt5vFB6EUG1eZEFJE = value;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000078 RID: 120 RVA: 0x000064A0 File Offset: 0x000046A0
	// (set) Token: 0x06000079 RID: 121 RVA: 0x000064B8 File Offset: 0x000046B8
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Use custom FOV")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool useCustomFOV
	{
		get
		{
			return D5l46jlssr4TRAzUSXzLj0uqu.Dl713lutQQxz2SDNFraK3YthA;
		}
		set
		{
			bool flag = D5l46jlssr4TRAzUSXzLj0uqu.Dl713lutQQxz2SDNFraK3YthA != value;
			if (flag)
			{
				if (value)
				{
					D5l46jlssr4TRAzUSXzLj0uqu.DqjmB5UrJT0TLbde9RLH7wCwH = OptionsSettings.fov;
				}
				else
				{
					OptionsSettings.fov = D5l46jlssr4TRAzUSXzLj0uqu.DqjmB5UrJT0TLbde9RLH7wCwH;
				}
			}
			D5l46jlssr4TRAzUSXzLj0uqu.Dl713lutQQxz2SDNFraK3YthA = value;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600007A RID: 122 RVA: 0x00006500 File Offset: 0x00004700
	// (set) Token: 0x0600007B RID: 123 RVA: 0x00006518 File Offset: 0x00004718
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Vehicle noclip")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool vehicleNoclip
	{
		get
		{
			return D5l46jlssr4TRAzUSXzLj0uqu.DSPZ1k8DewM60xEN7D556FfkK;
		}
		set
		{
			bool flag = D5l46jlssr4TRAzUSXzLj0uqu.DSPZ1k8DewM60xEN7D556FfkK != value && !value && Player.player != null && Player.player.movement.getVehicle() != null && DyeZ3VGPOIURoB79RzeiyEoDq.Dh4w9Tga1SdtxToA5FlSMGQKx != null;
			if (flag)
			{
				DyeZ3VGPOIURoB79RzeiyEoDq.Dh4w9Tga1SdtxToA5FlSMGQKx.applyTo(Player.player.movement.getVehicle());
				bool flag2 = DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51 != null;
				if (flag2)
				{
					DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.DBbFWh5f0i7R4pZC3PhoeVZn9.useGravity = true;
					DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.DBbFWh5f0i7R4pZC3PhoeVZn9.isKinematic = false;
				}
			}
			D5l46jlssr4TRAzUSXzLj0uqu.DSPZ1k8DewM60xEN7D556FfkK = value;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600007C RID: 124 RVA: 0x000065BC File Offset: 0x000047BC
	// (set) Token: 0x0600007D RID: 125 RVA: 0x000065D4 File Offset: 0x000047D4
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Chat spamming")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool chatSpamming
	{
		get
		{
			return D5l46jlssr4TRAzUSXzLj0uqu.m_chatSpamming;
		}
		set
		{
			bool flag = D5l46jlssr4TRAzUSXzLj0uqu.m_chatSpamming != value;
			if (flag)
			{
				DoyDTSdie5T1FGAHQouqRkoMJ.DC3MLEkwgi2UAEOLDoCp7lyYI(value);
			}
			D5l46jlssr4TRAzUSXzLj0uqu.m_chatSpamming = value;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600007E RID: 126 RVA: 0x00006600 File Offset: 0x00004800
	// (set) Token: 0x0600007F RID: 127 RVA: 0x00006617 File Offset: 0x00004817
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Custom FOV")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float customFOV
	{
		get
		{
			return D5l46jlssr4TRAzUSXzLj0uqu.D7w3sc2eRGQGDdM95mCvkVgwn;
		}
		set
		{
			OptionsSettings.fov = value;
			D5l46jlssr4TRAzUSXzLj0uqu.D7w3sc2eRGQGDdM95mCvkVgwn = value;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000080 RID: 128 RVA: 0x00006628 File Offset: 0x00004828
	// (set) Token: 0x06000081 RID: 129 RVA: 0x00006640 File Offset: 0x00004840
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Night vision type")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static DvbEzC20KPBbYRjl1eW9ilgCU nightVisionType
	{
		get
		{
			return D5l46jlssr4TRAzUSXzLj0uqu.D1ILvtpfq5tYjPHNXWTHZiVPh;
		}
		set
		{
			bool flag = D5l46jlssr4TRAzUSXzLj0uqu.D1ILvtpfq5tYjPHNXWTHZiVPh != value && D5l46jlssr4TRAzUSXzLj0uqu.imitNightvision && !DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6;
			if (flag)
			{
				switch (value)
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
				LevelLighting.vision = value.D6HbJZ2NUXUKMVsndz6x1ZFtz();
				LevelLighting.updateLighting();
				LevelLighting.updateLocal();
				D9sqUkDmUbz7uUc5edvQF8hDl.D2hcRGy0VyZxVqJMX9bijVbJx();
			}
			D5l46jlssr4TRAzUSXzLj0uqu.D1ILvtpfq5tYjPHNXWTHZiVPh = value;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000082 RID: 130 RVA: 0x00006734 File Offset: 0x00004934
	// (set) Token: 0x06000083 RID: 131 RVA: 0x0000674C File Offset: 0x0000494C
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Modified player perspective")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static ECameraMode playerPerspective
	{
		get
		{
			return D5l46jlssr4TRAzUSXzLj0uqu.DwOj9TSoSGMb18cY0XY0VV37C;
		}
		set
		{
			bool flag = D5l46jlssr4TRAzUSXzLj0uqu.DwOj9TSoSGMb18cY0XY0VV37C != value;
			if (flag)
			{
				bool isConnected = Provider.isConnected;
				if (isConnected)
				{
					Provider.cameraMode = value;
				}
				bool flag2 = Player.player != null && !DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6;
				if (flag2)
				{
					bool flag3 = value == ECameraMode.THIRD && Player.player.look.perspective == EPlayerPerspective.FIRST;
					if (flag3)
					{
						D5l46jlssr4TRAzUSXzLj0uqu.DxxYDukO6YYmib8AHaMY1hich.DGHrF0Ht2QRxL0NBgNHj6ZpZX(Player.player.look, new object[] { 1 });
					}
					else
					{
						bool flag4 = value == ECameraMode.VEHICLE && Player.player.look.perspective == EPlayerPerspective.THIRD && Player.player.movement.getVehicle() == null;
						if (flag4)
						{
							D5l46jlssr4TRAzUSXzLj0uqu.DxxYDukO6YYmib8AHaMY1hich.DGHrF0Ht2QRxL0NBgNHj6ZpZX(Player.player.look, new object[] { 0 });
						}
					}
				}
			}
			D5l46jlssr4TRAzUSXzLj0uqu.DwOj9TSoSGMb18cY0XY0VV37C = value;
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000084 RID: 132 RVA: 0x0000684C File Offset: 0x00004A4C
	// (set) Token: 0x06000085 RID: 133 RVA: 0x00006864 File Offset: 0x00004A64
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Use custom aspect ratio")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool useCustomAspectRatio
	{
		get
		{
			return D5l46jlssr4TRAzUSXzLj0uqu.D5hK8jL2mN4pQ7rS9tV1wX3yZ;
		}
		set
		{
			bool flag = D5l46jlssr4TRAzUSXzLj0uqu.D5hK8jL2mN4pQ7rS9tV1wX3yZ != value;
			if (flag)
			{
				if (value)
				{
					Camera main = Camera.main;
					bool flag2 = main != null;
					if (flag2)
					{
						D5l46jlssr4TRAzUSXzLj0uqu.D7kL9mN3oQ8rS0tU2vW4xY5z = main.aspect;
					}
					bool flag3 = MainCamera.instance != null;
					if (flag3)
					{
						D5l46jlssr4TRAzUSXzLj0uqu.D7kL9mN3oQ8rS0tU2vW4xY5z = MainCamera.instance.aspect;
					}
					bool flag4 = D5l46jlssr4TRAzUSXzLj0uqu.D8lM0nO4pR9sT1uV3wX5yZ6a > 0f;
					if (flag4)
					{
						Camera main2 = Camera.main;
						bool flag5 = main2 != null;
						if (flag5)
						{
							main2.aspect = D5l46jlssr4TRAzUSXzLj0uqu.D8lM0nO4pR9sT1uV3wX5yZ6a;
						}
						bool flag6 = MainCamera.instance != null;
						if (flag6)
						{
							MainCamera.instance.aspect = D5l46jlssr4TRAzUSXzLj0uqu.D8lM0nO4pR9sT1uV3wX5yZ6a;
						}
					}
				}
				else
				{
					Camera main3 = Camera.main;
					bool flag7 = main3 != null;
					if (flag7)
					{
						main3.aspect = D5l46jlssr4TRAzUSXzLj0uqu.D7kL9mN3oQ8rS0tU2vW4xY5z;
					}
					bool flag8 = MainCamera.instance != null;
					if (flag8)
					{
						MainCamera.instance.aspect = D5l46jlssr4TRAzUSXzLj0uqu.D7kL9mN3oQ8rS0tU2vW4xY5z;
					}
				}
			}
			D5l46jlssr4TRAzUSXzLj0uqu.D5hK8jL2mN4pQ7rS9tV1wX3yZ = value;
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000086 RID: 134 RVA: 0x0000697C File Offset: 0x00004B7C
	// (set) Token: 0x06000087 RID: 135 RVA: 0x00006994 File Offset: 0x00004B94
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Custom aspect ratio")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float customAspectRatio
	{
		get
		{
			return D5l46jlssr4TRAzUSXzLj0uqu.D8lM0nO4pR9sT1uV3wX5yZ6a;
		}
		set
		{
			D5l46jlssr4TRAzUSXzLj0uqu.D8lM0nO4pR9sT1uV3wX5yZ6a = value;
			bool useCustomAspectRatio = D5l46jlssr4TRAzUSXzLj0uqu.useCustomAspectRatio;
			if (useCustomAspectRatio)
			{
				bool flag = value > 0f;
				if (flag)
				{
					Camera main = Camera.main;
					bool flag2 = main != null;
					if (flag2)
					{
						main.aspect = value;
					}
					bool flag3 = MainCamera.instance != null;
					if (flag3)
					{
						MainCamera.instance.aspect = value;
					}
				}
				else
				{
					Camera main2 = Camera.main;
					bool flag4 = main2 != null;
					if (flag4)
					{
						main2.aspect = D5l46jlssr4TRAzUSXzLj0uqu.D7kL9mN3oQ8rS0tU2vW4xY5z;
					}
					bool flag5 = MainCamera.instance != null;
					if (flag5)
					{
						MainCamera.instance.aspect = D5l46jlssr4TRAzUSXzLj0uqu.D7kL9mN3oQ8rS0tU2vW4xY5z;
					}
				}
			}
		}
	}

	// Token: 0x04000047 RID: 71
	private static DQyA1nzDa0rZuYtgcLmIWOUf8 DxxYDukO6YYmib8AHaMY1hich = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(PlayerLook), "setActivePerspective", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000048 RID: 72
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Correct firerate to work")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool correctFirerateToWork = true;

	// Token: 0x04000049 RID: 73
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "No flash")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool noFlash = false;

	// Token: 0x0400004A RID: 74
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "No grayscale")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool noGrayscale = false;

	// Token: 0x0400004B RID: 75
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "No pain")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool noPain = false;

	// Token: 0x0400004C RID: 76
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "No blur")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool noBlur = false;

	// Token: 0x0400004D RID: 77
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "No hallucinations")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool noHallucinations = false;

	// Token: 0x0400004E RID: 78
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Local leans")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool localLeans = false;

	// Token: 0x0400004F RID: 79
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Free leans")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool freeLeans = false;

	// Token: 0x04000050 RID: 80
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Skip asset verifying")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool skipAssetVerifying = false;

	// Token: 0x04000051 RID: 81
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Fake lag")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool fakeLag = false;

	// Token: 0x04000052 RID: 82
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Ignore barricade placement errors")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool ignoreBarricadePlacementErrors = false;

	// Token: 0x04000053 RID: 83
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Ignore structure placement errors")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool ignoreStructurePlacementErrors = false;

	// Token: 0x04000054 RID: 84
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Imit compass in inventory")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool imitCompassInInventory = false;

	// Token: 0x04000055 RID: 85
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Imit map in inventory")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool imitMapInInventory = false;

	// Token: 0x04000056 RID: 86
	public static bool DAg96DuTTiw8zzMFikpL3jNl0 = false;

	// Token: 0x04000057 RID: 87
	public static bool DCXziB0kIOezVeYnpla5czLXA = false;

	// Token: 0x04000058 RID: 88
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Instant aiming")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool instantAiming = false;

	// Token: 0x04000059 RID: 89
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Custom day time")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool customDayTime = false;

	// Token: 0x0400005A RID: 90
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Display all player marks on map")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool displayAllPlayerMarksOnMap = false;

	// Token: 0x0400005B RID: 91
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Display all players on map")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool displayAllPlayersOnMap = false;

	// Token: 0x0400005C RID: 92
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Disable scope overlay")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool disableScopeOverlayH = false;

	// Token: 0x0400005D RID: 93
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Disable binocularus overlay")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool disableBinocularOverlay = false;

	// Token: 0x0400005E RID: 94
	public static bool D0DlzyHYujfZZ6obqTbnUo6xa = false;

	// Token: 0x0400005F RID: 95
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Chat on kill")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool chatOnKill = false;

	// Token: 0x04000060 RID: 96
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Ignore leave timer")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool ignoreLeaveTimer = false;

	// Token: 0x04000061 RID: 97
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "No ballistics")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool noBallistics = false;

	// Token: 0x04000062 RID: 98
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Pickup items through walls")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool pickupItemsThroughWalls = false;

	// Token: 0x04000063 RID: 99
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Extended melee range")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool extendMeleeRange = false;

	// Token: 0x04000064 RID: 100
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Modify move behaviour")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool modifyMoveBehaviour = false;

	// Token: 0x04000065 RID: 101
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Show move modifying")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool showMoveModifying = false;

	// Token: 0x04000066 RID: 102
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Replace hit limb to custom")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool replaceHitLimbToCustom = false;

	// Token: 0x04000067 RID: 103
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Show weapon info")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool showWeaponInfo = false;

	// Token: 0x04000068 RID: 104
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Use static rect for weapon info")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool useStaticRectForWeaponInfo = false;

	// Token: 0x04000069 RID: 105
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Extend player region")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool extendPlayerRegion = false;

	// Token: 0x0400006A RID: 106
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Extend region interact through walls")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool extendRegionInteractThroughWalls = false;

	// Token: 0x0400006B RID: 107
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Change vehicle leave velocity")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool changeVehicleLeaveVelocity = false;

	// Token: 0x0400006C RID: 108
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Use forward velocity")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool useForwardVelocity = false;

	// Token: 0x0400006D RID: 109
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Random swap face")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool randomSwapingFace = false;

	// Token: 0x0400006E RID: 110
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Notify on admin join")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool notifyOnAdminJoin = false;

	// Token: 0x0400006F RID: 111
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Independent player info targeting")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool independentPlayerInfoTargeting = false;

	// Token: 0x04000070 RID: 112
	public static bool DkdMeU2vgt5vFB6EUG1eZEFJE = false;

	// Token: 0x04000071 RID: 113
	public static bool Dl713lutQQxz2SDNFraK3YthA = false;

	// Token: 0x04000072 RID: 114
	public static bool DSPZ1k8DewM60xEN7D556FfkK = false;

	// Token: 0x04000073 RID: 115
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Automatic semi-bust")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool automaticSemiBurst = false;

	// Token: 0x04000074 RID: 116
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Use vehicle physics")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool useVehiclePhysics = true;

	// Token: 0x04000075 RID: 117
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Auto item pickup")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool autoItemPickup = false;

	// Token: 0x04000076 RID: 118
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Chat spamming")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool m_chatSpamming = false;

	// Token: 0x04000077 RID: 119
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Kill sound")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool killSound = false;

	// Token: 0x04000078 RID: 120
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Hit sound")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool hitSound = false;

	// Token: 0x04000079 RID: 121
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Randomize nickname by server players")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool randomizeNicknameByServerPlayers = false;

	// Token: 0x0400007A RID: 122
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Spam chat zone")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static EChatMode spamChatZone = EChatMode.GLOBAL;

	// Token: 0x0400007B RID: 123
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Change move rotation")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool changeMoveRotation = true;

	// Token: 0x0400007C RID: 124
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Display player info")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool displayPlayerInfo = false;

	// Token: 0x0400007D RID: 125
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Display player group members")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool displayPlayerGroupMembers = true;

	// Token: 0x0400007E RID: 126
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Display player info always")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool displayPlayerInfoAlways = false;

	// Token: 0x0400007F RID: 127
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Notify about spy")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool notifyAboutSpy = false;

	// Token: 0x04000080 RID: 128
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Send random steam ID")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool sendRandomSteamID = false;

	// Token: 0x04000081 RID: 129
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Third camera ignore obstacles")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool thirdCameraIgnoreObstacles = false;

	// Token: 0x04000082 RID: 130
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Extend ballistic range")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool extendBallisticRange = false;

	// Token: 0x04000083 RID: 131
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Unclamp camera rotation")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool unclampCameraRotation = false;

	// Token: 0x04000084 RID: 132
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Custom build offset")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool customBuildOffset = false;

	// Token: 0x04000085 RID: 133
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Override sun color")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool overrideSunColor = false;

	// Token: 0x04000086 RID: 134
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Override sky color")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool overrideSkyColor = false;

	// Token: 0x04000087 RID: 135
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Override clouds color")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool overrideCloudsColor = false;

	// Token: 0x04000088 RID: 136
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Override clouds rim color")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool overrideCloudsRimColor = false;

	// Token: 0x04000089 RID: 137
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Display vanish players window")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool displayVanishPlayersWindow = false;

	// Token: 0x0400008A RID: 138
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Raw walk")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static bool rawWalk = false;

	// Token: 0x0400008B RID: 139
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Third camera distance")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float thirdCameraDistance = 0f;

	// Token: 0x0400008C RID: 140
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Spy delay timer")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float spyDelayTimer = 0.6f;

	// Token: 0x0400008D RID: 141
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Face swap delay")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float faceSwapDelay = 1f;

	// Token: 0x0400008E RID: 142
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Chat spam delay")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float chatSpamDelay = 1f;

	// Token: 0x0400008F RID: 143
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Vehicle speed")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float vehicleSpeed = 1f;

	// Token: 0x04000090 RID: 144
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Sway multiplier")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float swayMultiplier = 1f;

	// Token: 0x04000091 RID: 145
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Spread multiplier")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float spreadMultiplier = 1f;

	// Token: 0x04000092 RID: 146
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Recoil multiplier")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float recoilMultiplier = 1f;

	// Token: 0x04000093 RID: 147
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Recoil impact multiplier")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float recoilImpactMultiplier = 1f;

	// Token: 0x04000094 RID: 148
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Damage punch multiplier")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float damagePunchMultiplier = 1f;

	// Token: 0x04000095 RID: 149
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Salvage time multiplier")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float salvageTimeMultiplier = 1f;

	// Token: 0x04000096 RID: 150
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Build forward offset")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float buildForwardOffset = 2f;

	// Token: 0x04000097 RID: 151
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Build Y offset")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float buildYOffset = 1f;

	// Token: 0x04000098 RID: 152
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Custom time")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static float customTime = 0.5f;

	// Token: 0x04000099 RID: 153
	public static float D7w3sc2eRGQGDdM95mCvkVgwn = 1f;

	// Token: 0x0400009A RID: 154
	public static float DqjmB5UrJT0TLbde9RLH7wCwH = 1f;

	// Token: 0x0400009B RID: 155
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Firerate decrease")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int firerateDecrease = 0;

	// Token: 0x0400009C RID: 156
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Additional ballistic steps")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int additionalBallisticSteps = 4;

	// Token: 0x0400009D RID: 157
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Spy window size")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int spyWindowSize = 200;

	// Token: 0x0400009E RID: 158
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Player info window size")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int playerInfoWindowSize = 50;

	// Token: 0x0400009F RID: 159
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Extend region range")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int extendRegionRange = 20;

	// Token: 0x040000A0 RID: 160
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Auto item pickup distance")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int autoItemPickupDistance = 20;

	// Token: 0x040000A1 RID: 161
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Pickup items through walls distance")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int pickupItemsThroughWallsDistance = 20;

	// Token: 0x040000A2 RID: 162
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Independet player info targeting distance")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int independetPlayerInfoTargetingDistance = 600;

	// Token: 0x040000A3 RID: 163
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Vehicle velocity X")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int vehilceVelocityX = 15;

	// Token: 0x040000A4 RID: 164
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Vehicle velocity Y")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int vehilceVelocityY = 15;

	// Token: 0x040000A5 RID: 165
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Vehicle velocity Z")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int vehilceVelocityZ = 15;

	// Token: 0x040000A6 RID: 166
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Vehicle velocity forward")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int vehilceVelocityForward = 15;

	// Token: 0x040000A7 RID: 167
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Freecamera speed")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static int freeCameraSpeed = 5;

	// Token: 0x040000A8 RID: 168
	public static int DOxbpk1e4e01yWRp7uht8MYxD = 4;

	// Token: 0x040000A9 RID: 169
	public static int DRwWITQLrOvB0fW0OZA46vz2N = 1;

	// Token: 0x040000AA RID: 170
	[Dy6M3joVi08gNRZyTkEnTy5qj("customSteamID")]
	public static ulong customSteamID = 5UL;

	// Token: 0x040000AB RID: 171
	public static byte[] DRywCzlrtImzxkGhDOTGcBASd = new byte[0];

	// Token: 0x040000AC RID: 172
	public static byte[] DTJpui0sqNkukyZlpsiFS5Vbv = new byte[0];

	// Token: 0x040000AD RID: 173
	public static byte[] DHuZ6stX7WaYQtYnBbmwbMew0 = new byte[0];

	// Token: 0x040000AE RID: 174
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Replaced hit limb")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static Drvin9V0cgPlOe7ofbFCim7y0 replacedHitLimb = Drvin9V0cgPlOe7ofbFCim7y0.Head;

	// Token: 0x040000AF RID: 175
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Spy type")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static DEaNNGRxJag20zwKVRmcuyQsU spyType = DEaNNGRxJag20zwKVRmcuyQsU.SpyInFourFrames;

	// Token: 0x040000B0 RID: 176
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "HWID send type")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static DyZOPUgVlLGDIfwra38xGmDBF hwidType = DyZOPUgVlLGDIfwra38xGmDBF.SendRandomHWID;

	// Token: 0x040000B1 RID: 177
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Move type")]
	[Dy6M3joVi08gNRZyTkEnTy5qj]
	public static DjTmlwWXHjmuTJsdebq9LFq0y moveType = DjTmlwWXHjmuTJsdebq9LFq0y.FourTactSpin;

	// Token: 0x040000B2 RID: 178
	public static ELightingVision D0lIKBLGl32vj29YP9iicvtqI = ELightingVision.NONE;

	// Token: 0x040000B3 RID: 179
	public static DvbEzC20KPBbYRjl1eW9ilgCU D1ILvtpfq5tYjPHNXWTHZiVPh = DvbEzC20KPBbYRjl1eW9ilgCU.Military;

	// Token: 0x040000B4 RID: 180
	public static ECameraMode D66xkrBp6Z1GTuSAAF2uDhRmK;

	// Token: 0x040000B5 RID: 181
	public static ECameraMode DwOj9TSoSGMb18cY0XY0VV37C = ECameraMode.BOTH;

	// Token: 0x040000B6 RID: 182
	[Dy6M3joVi08gNRZyTkEnTy5qj("spamText")]
	public static string spamText = "discord.gg/moonclient";

	// Token: 0x040000B7 RID: 183
	[Dy6M3joVi08gNRZyTkEnTy5qj("adminNotifyText")]
	public static string adminNotifyText = "{1} ({0}) admin joined on the server!";

	// Token: 0x040000B8 RID: 184
	[Dy6M3joVi08gNRZyTkEnTy5qj("killText")]
	public static string killText = "ez";

	// Token: 0x040000B9 RID: 185
	[Dy6M3joVi08gNRZyTkEnTy5qj("killAudioName")]
	public static string killAudioName = "Cheat hit";

	// Token: 0x040000BA RID: 186
	[Dy6M3joVi08gNRZyTkEnTy5qj("hitAudioName")]
	public static string hitAudioName = "Cheat hit";

	// Token: 0x040000BB RID: 187
	public static Dictionary<ushort, DDB8pIlWKKbHkw2jCuyAPcvL7> DzksjAWr7fP6HlkBNdY20fpHC = new Dictionary<ushort, DDB8pIlWKKbHkw2jCuyAPcvL7>();

	// Token: 0x040000BC RID: 188
	public static bool D5hK8jL2mN4pQ7rS9tV1wX3yZ = false;

	// Token: 0x040000BD RID: 189
	public static float D7kL9mN3oQ8rS0tU2vW4xY5z = 0f;

	// Token: 0x040000BE RID: 190
	public static float D8lM0nO4pR9sT1uV3wX5yZ6a = 0f;
}
