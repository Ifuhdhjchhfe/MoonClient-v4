using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200007E RID: 126
public class DL3tNdrQzY7o8FV1oIOKODOLQ : MonoBehaviour
{
	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000257 RID: 599 RVA: 0x00021620 File Offset: 0x0001F820
	// (set) Token: 0x06000258 RID: 600 RVA: 0x00021638 File Offset: 0x0001F838
	[DvBeyuawbq3X9NsoJgcUZmAIZ("Misc options", "Open menu")]
	public static bool menuOpened
	{
		get
		{
			return DL3tNdrQzY7o8FV1oIOKODOLQ.DtKlbZSZSYlN9ldxLbDo4VuvI;
		}
		set
		{
			bool flag = DL3tNdrQzY7o8FV1oIOKODOLQ.DtKlbZSZSYlN9ldxLbDo4VuvI != value && value;
			if (flag)
			{
				Cursor.lockState = CursorLockMode.None;
				bool flag2 = PlayerUI.window != null;
				if (flag2)
				{
					PlayerUI.window.showCursor = true;
				}
				Dxg2tDZdImJqrX71UMTW47xIk.DxeJlNfhwsirSRyR3yNds5r6J();
				DHL4u9JW55KHn4yqahAsAca0g.D2g4NA8rhz0woPO9q8PE9WzJz();
				DL3tNdrQzY7o8FV1oIOKODOLQ.DcVR4j0M6LKa29MPLEDDsSrwV(true);
				bool flag3 = !DfU4wrswBK5kLyiyV6mHZwOg8.smoothMenuOpen;
				if (flag3)
				{
					DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS = DfU4wrswBK5kLyiyV6mHZwOg8.smoothOpenTime;
				}
			}
			else
			{
				bool flag4 = DL3tNdrQzY7o8FV1oIOKODOLQ.DtKlbZSZSYlN9ldxLbDo4VuvI != value && !value;
				if (flag4)
				{
					DL3tNdrQzY7o8FV1oIOKODOLQ.DcVR4j0M6LKa29MPLEDDsSrwV(false);
					bool flag5 = !DfU4wrswBK5kLyiyV6mHZwOg8.smoothMenuOpen;
					if (flag5)
					{
						DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS = 0f;
					}
					DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = null;
				}
			}
			DL3tNdrQzY7o8FV1oIOKODOLQ.DtKlbZSZSYlN9ldxLbDo4VuvI = value;
		}
	}

	// Token: 0x06000259 RID: 601 RVA: 0x000216E8 File Offset: 0x0001F8E8
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DHs95odcJqiLe5djkmTWfuFHP()
	{
		List<DOEkZ1zoBEuvfUmOs9QSpfX0X> list = new List<DOEkZ1zoBEuvfUmOs9QSpfX0X>();
		foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
		{
			bool flag = type.BaseType == typeof(DOEkZ1zoBEuvfUmOs9QSpfX0X);
			if (flag)
			{
				list.Add((DOEkZ1zoBEuvfUmOs9QSpfX0X)Activator.CreateInstance(type));
			}
		}
		DL3tNdrQzY7o8FV1oIOKODOLQ.DVIZ0JsvRm3b0AvGc4wKbcX5t = new DOEkZ1zoBEuvfUmOs9QSpfX0X[list.Count];
		int num = 0;
		foreach (DOEkZ1zoBEuvfUmOs9QSpfX0X doekZ1zoBEuvfUmOs9QSpfX0X in list)
		{
			bool flag2 = doekZ1zoBEuvfUmOs9QSpfX0X.SortId() != -1;
			if (flag2)
			{
				DL3tNdrQzY7o8FV1oIOKODOLQ.DVIZ0JsvRm3b0AvGc4wKbcX5t[doekZ1zoBEuvfUmOs9QSpfX0X.SortId()] = doekZ1zoBEuvfUmOs9QSpfX0X;
				num++;
			}
		}
		foreach (DOEkZ1zoBEuvfUmOs9QSpfX0X doekZ1zoBEuvfUmOs9QSpfX0X2 in list)
		{
			bool flag3 = doekZ1zoBEuvfUmOs9QSpfX0X2.SortId() == -1;
			if (flag3)
			{
				DL3tNdrQzY7o8FV1oIOKODOLQ.DVIZ0JsvRm3b0AvGc4wKbcX5t[num] = doekZ1zoBEuvfUmOs9QSpfX0X2;
				num++;
			}
		}
		DL3tNdrQzY7o8FV1oIOKODOLQ.D8EsnZ92xDhkmKXiK5lZ7f83l = D45oCja1emRGTf1Vx97hiw7OW.DVJhSOHQ72kWtxWQSVe40C5cc();
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00021830 File Offset: 0x0001FA30
	public static void DcVR4j0M6LKa29MPLEDDsSrwV(bool activity)
	{
		bool flag = !activity;
		if (flag)
		{
			foreach (object obj in DL3tNdrQzY7o8FV1oIOKODOLQ.DFfl9bFFFhJhkRgRt7HdXq4DI)
			{
				bool flag2 = obj != null && obj.GetType() == D08iy2XFQpUQteL0XRzAbg2IE.D690dQkfd9Ye1iupKYZFiSJkW("ScrollRectEx");
				if (flag2)
				{
					obj.GetType().GetProperty("scrollSensitivity").SetValue(obj, 40);
				}
			}
			DL3tNdrQzY7o8FV1oIOKODOLQ.DFfl9bFFFhJhkRgRt7HdXq4DI = new object[0];
		}
		else
		{
			DL3tNdrQzY7o8FV1oIOKODOLQ.DFfl9bFFFhJhkRgRt7HdXq4DI = (from scroll in global::UnityEngine.Object.FindObjectsOfType(D08iy2XFQpUQteL0XRzAbg2IE.D690dQkfd9Ye1iupKYZFiSJkW("ScrollRectEx"))
				select (scroll)).ToArray<object>();
			foreach (object obj2 in DL3tNdrQzY7o8FV1oIOKODOLQ.DFfl9bFFFhJhkRgRt7HdXq4DI)
			{
				obj2.GetType().GetProperty("scrollSensitivity").SetValue(obj2, 0);
			}
		}
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00021934 File Offset: 0x0001FB34
	public static Color DhTK8vExKCigxPaJEUNom8G8Y()
	{
		return new Color(1f, 1f, 1f, (DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS == 0f) ? 0f : (DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS / DfU4wrswBK5kLyiyV6mHZwOg8.smoothOpenTime));
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00021978 File Offset: 0x0001FB78
	public static Color DWZMLhXYOrreM11KKl2Yrzbdr()
	{
		return new Color(1f, 1f, 1f, (DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS == 0f) ? 1f : (1f - DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS / DfU4wrswBK5kLyiyV6mHZwOg8.smoothOpenTime));
	}

	// Token: 0x0600025D RID: 605 RVA: 0x000219C4 File Offset: 0x0001FBC4
	public static float DdgGXFGERdBMTnaSP0ZaRaV5y()
	{
		bool flag = DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS != 0f;
		float num;
		if (flag)
		{
			num = 1f - DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS / DfU4wrswBK5kLyiyV6mHZwOg8.smoothOpenTime;
		}
		else
		{
			num = 1f;
		}
		return num;
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00021A04 File Offset: 0x0001FC04
	public static float DsVlNI7hwmvLykhj6f2v4gFgu()
	{
		bool flag = DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS != 0f;
		float num;
		if (flag)
		{
			num = DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS / DfU4wrswBK5kLyiyV6mHZwOg8.smoothOpenTime;
		}
		else
		{
			num = 0f;
		}
		return num;
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00021A40 File Offset: 0x0001FC40
	public void Update()
	{
		bool flag = Provider.preferenceData != null && Provider.preferenceData.Viewmodel != null;
		if (flag)
		{
			Provider.preferenceData.Viewmodel.Field_Of_View_Aim = D1jEbAAX8PVonPaKHK1vTaeKI.fovAim;
			Provider.preferenceData.Viewmodel.Field_Of_View_Hip = D1jEbAAX8PVonPaKHK1vTaeKI.fovHip;
			Provider.preferenceData.Viewmodel.Offset_Depth = D1jEbAAX8PVonPaKHK1vTaeKI.offsetDepth;
			Provider.preferenceData.Viewmodel.Offset_Horizontal = D1jEbAAX8PVonPaKHK1vTaeKI.offsetHorizontal;
			Provider.preferenceData.Viewmodel.Offset_Vertical = D1jEbAAX8PVonPaKHK1vTaeKI.offsetVertical;
		}
		bool flag2 = DL3tNdrQzY7o8FV1oIOKODOLQ.DwelcomeTimer > 0f;
		if (flag2)
		{
			DL3tNdrQzY7o8FV1oIOKODOLQ.DwelcomeTimer -= Time.unscaledDeltaTime;
		}
		bool flag3 = !DL3tNdrQzY7o8FV1oIOKODOLQ.DopenDelayedTriggered;
		if (flag3)
		{
			DL3tNdrQzY7o8FV1oIOKODOLQ.DopenDelayTimer -= Time.unscaledDeltaTime;
			bool flag4 = DL3tNdrQzY7o8FV1oIOKODOLQ.DopenDelayTimer <= 0f;
			if (flag4)
			{
				DL3tNdrQzY7o8FV1oIOKODOLQ.DopenDelayedTriggered = true;
				DL3tNdrQzY7o8FV1oIOKODOLQ.menuOpened = true;
			}
		}
		bool flag5 = DL3tNdrQzY7o8FV1oIOKODOLQ.menuOpened && DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS < DfU4wrswBK5kLyiyV6mHZwOg8.smoothOpenTime;
		if (flag5)
		{
			DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS += Time.unscaledDeltaTime;
			bool flag6 = DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS > DfU4wrswBK5kLyiyV6mHZwOg8.smoothOpenTime;
			if (flag6)
			{
				DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS = DfU4wrswBK5kLyiyV6mHZwOg8.smoothOpenTime;
			}
		}
		else
		{
			bool flag7 = !DL3tNdrQzY7o8FV1oIOKODOLQ.menuOpened && DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS != 0f;
			if (flag7)
			{
				DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS -= Time.unscaledDeltaTime;
				bool flag8 = DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS < 0f;
				if (flag8)
				{
					DL3tNdrQzY7o8FV1oIOKODOLQ.Dxra8TwGz4kouqfrUBZWmojmS = 0f;
				}
			}
		}
		bool dbjv74arVJtUMAqsSN0cWr9w = DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6;
		if (dbjv74arVJtUMAqsSN0cWr9w)
		{
			float num = 1.3333334f;
			Camera main = Camera.main;
			bool flag9 = main != null && main.aspect != num;
			if (flag9)
			{
				main.aspect = num;
			}
			bool flag10 = MainCamera.instance != null && MainCamera.instance.aspect != num;
			if (flag10)
			{
				MainCamera.instance.aspect = num;
			}
		}
		else
		{
			bool flag11 = D5l46jlssr4TRAzUSXzLj0uqu.useCustomAspectRatio && D5l46jlssr4TRAzUSXzLj0uqu.customAspectRatio > 0f;
			if (flag11)
			{
				Camera main2 = Camera.main;
				bool flag12 = main2 != null && main2.aspect != D5l46jlssr4TRAzUSXzLj0uqu.customAspectRatio;
				if (flag12)
				{
					main2.aspect = D5l46jlssr4TRAzUSXzLj0uqu.customAspectRatio;
				}
				bool flag13 = MainCamera.instance != null && MainCamera.instance.aspect != D5l46jlssr4TRAzUSXzLj0uqu.customAspectRatio;
				if (flag13)
				{
					MainCamera.instance.aspect = D5l46jlssr4TRAzUSXzLj0uqu.customAspectRatio;
				}
			}
			else
			{
				float num2 = (float)Screen.width / (float)Screen.height;
				Camera main3 = Camera.main;
				bool flag14 = main3 != null && main3.aspect != num2;
				if (flag14)
				{
					main3.aspect = num2;
				}
				bool flag15 = MainCamera.instance != null && MainCamera.instance.aspect != num2;
				if (flag15)
				{
					MainCamera.instance.aspect = num2;
				}
			}
		}
		bool de30FqjVHC03X81IY6Y3eTNN = DL3tNdrQzY7o8FV1oIOKODOLQ.De30FqjVHC03X81IY6Y3eTNN8;
		if (de30FqjVHC03X81IY6Y3eTNN)
		{
			DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj = null;
			DL3tNdrQzY7o8FV1oIOKODOLQ.De30FqjVHC03X81IY6Y3eTNN8 = false;
		}
		bool flag16 = DL3tNdrQzY7o8FV1oIOKODOLQ.DcLM0w9WaAvagqTbdgB0vfG8A != null;
		if (flag16)
		{
			DL3tNdrQzY7o8FV1oIOKODOLQ.D7CNlmL58D0jGJezjQxztg0NY = DL3tNdrQzY7o8FV1oIOKODOLQ.DcLM0w9WaAvagqTbdgB0vfG8A;
			DL3tNdrQzY7o8FV1oIOKODOLQ.DcLM0w9WaAvagqTbdgB0vfG8A = null;
		}
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00021D9C File Offset: 0x0001FF9C
	public static void DJghBtY9gfCnK6YVIpLeBmkkH()
	{
		DL3tNdrQzY7o8FV1oIOKODOLQ.DrawWelcomeNotification();
		Color color = GUI.color;
		GUI.color = DL3tNdrQzY7o8FV1oIOKODOLQ.DhTK8vExKCigxPaJEUNom8G8Y();
		bool flag = GUI.color.a != 0f;
		if (flag)
		{
			bool flag2 = PlayerUI.window != null;
			if (flag2)
			{
				PlayerUI.window.showCursor = true;
			}
			bool drawBackgroundBlackout = DfU4wrswBK5kLyiyV6mHZwOg8.drawBackgroundBlackout;
			if (drawBackgroundBlackout)
			{
				GUI.DrawTexture(new Rect(0f, 0f, (float)Screen.width, (float)Screen.height), DL3tNdrQzY7o8FV1oIOKODOLQ.D8EsnZ92xDhkmKXiK5lZ7f83l);
			}
			Rect rect = new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width, 15f);
			DgFTkE5PhwyrkOBGhzb7SByPr.DfdU0FmLG6qC1LMht1Y27juNW(ref rect);
			rect.height = DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height;
			DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4 = rect;
			Rect rect2 = new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width - 15f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height - 15f, 15f, 15f);
			DgFTkE5PhwyrkOBGhzb7SByPr.DfdU0FmLG6qC1LMht1Y27juNW(ref rect2);
			DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width = DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width - (DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width - 15f - rect2.x);
			DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height = DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height - (DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height - 15f - rect2.y);
			DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width = Mathf.Max(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width, 630f);
			DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height = Mathf.Max(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height, 470f);
			DL3tNdrQzY7o8FV1oIOKODOLQ.DrRBWxFPLv007kRWXRdxunnm0();
		}
		GUI.color = color;
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00021F84 File Offset: 0x00020184
	private static void DrRBWxFPLv007kRWXRdxunnm0()
	{
		DHTB5RKsHUihFrfj9ewuLh1f9.DcheckAccentUpdate();
		Color color = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Menu background color");
		Color32 color2 = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Menu line color");
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4, color, true, ScaleMode.StretchToFill);
		Texture2D animatedBgTexture = DrysTRTjdLdFqu5GJBDif6AoV.GetAnimatedBgTexture();
		float num = Time.time * 15f % 24f;
		float num2 = num / 24f;
		Color color3 = GUI.color;
		GUI.color = Color.white;
		GUI.DrawTextureWithTexCoords(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4, animatedBgTexture, new Rect(-num2, 0f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width / 24f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height / 24f), true);
		GUI.color = color3;
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width, 80f), new Color32(18, 18, 20, byte.MaxValue), true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + 80f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width, 1f), color2, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + 140f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + 80f, 1f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height - 80f), color2, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width, 1f), color2, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height - 1f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width, 1f), color2, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y, 1f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height), color2, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width - 1f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y, 1f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height), color2, true, ScaleMode.StretchToFill);
		new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + 10f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + 80f, 120f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height);
		int num3 = 0;
		foreach (DOEkZ1zoBEuvfUmOs9QSpfX0X doekZ1zoBEuvfUmOs9QSpfX0X in DL3tNdrQzY7o8FV1oIOKODOLQ.DVIZ0JsvRm3b0AvGc4wKbcX5t)
		{
			try
			{
				doekZ1zoBEuvfUmOs9QSpfX0X.DMo7BsXx7dZ72VKnI3P4NzkYZ(num3);
			}
			catch
			{
			}
			num3++;
		}
		Rect rect = new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + 140f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + 80f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width - 140f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.height - 80f);
		bool flag = DL3tNdrQzY7o8FV1oIOKODOLQ.D7CNlmL58D0jGJezjQxztg0NY != null;
		if (flag)
		{
			switch (DL3tNdrQzY7o8FV1oIOKODOLQ.D7CNlmL58D0jGJezjQxztg0NY.GetTabCounts())
			{
			case DYIPJORHeVCfbpocFHvJty4OE.One:
				try
				{
					DrysTRTjdLdFqu5GJBDif6AoV.DeLTQCvgBrZjuiqrrmd5Qwyhp(new Rect(rect.x + 15f, rect.y + 15f, rect.width - 30f, rect.height - 30f), delegate
					{
						DL3tNdrQzY7o8FV1oIOKODOLQ.D7CNlmL58D0jGJezjQxztg0NY.DoTab(DYIPJORHeVCfbpocFHvJty4OE.One);
					}, 15);
				}
				catch
				{
				}
				break;
			case DYIPJORHeVCfbpocFHvJty4OE.Two:
				try
				{
					DrysTRTjdLdFqu5GJBDif6AoV.DeLTQCvgBrZjuiqrrmd5Qwyhp(new Rect(rect.x + 15f, rect.y + 15f, rect.width / 2f - 45f, rect.height - 30f), delegate
					{
						DL3tNdrQzY7o8FV1oIOKODOLQ.D7CNlmL58D0jGJezjQxztg0NY.DoTab(DYIPJORHeVCfbpocFHvJty4OE.One);
					}, 15);
				}
				catch
				{
				}
				try
				{
					DrysTRTjdLdFqu5GJBDif6AoV.DeLTQCvgBrZjuiqrrmd5Qwyhp(new Rect(rect.x + rect.width / 2f - 13f, rect.y + 15f, rect.width / 2f - 15f, rect.height - 30f), delegate
					{
						DL3tNdrQzY7o8FV1oIOKODOLQ.D7CNlmL58D0jGJezjQxztg0NY.DoTab(DYIPJORHeVCfbpocFHvJty4OE.Two);
					}, 15);
				}
				catch
				{
				}
				break;
			case DYIPJORHeVCfbpocFHvJty4OE.Three:
				try
				{
					DrysTRTjdLdFqu5GJBDif6AoV.DeLTQCvgBrZjuiqrrmd5Qwyhp(new Rect(rect.x + 15f, rect.y + 15f, rect.width / 2f - 45f, rect.height - 30f), delegate
					{
						DL3tNdrQzY7o8FV1oIOKODOLQ.D7CNlmL58D0jGJezjQxztg0NY.DoTab(DYIPJORHeVCfbpocFHvJty4OE.One);
					}, 15);
				}
				catch
				{
				}
				try
				{
					DrysTRTjdLdFqu5GJBDif6AoV.DeLTQCvgBrZjuiqrrmd5Qwyhp(new Rect(rect.x + rect.width / 2f - 13f, rect.y + 15f, rect.width / 2f - 15f, rect.height / 2f - 30f), delegate
					{
						DL3tNdrQzY7o8FV1oIOKODOLQ.D7CNlmL58D0jGJezjQxztg0NY.DoTab(DYIPJORHeVCfbpocFHvJty4OE.Two);
					}, 15);
				}
				catch
				{
				}
				try
				{
					DrysTRTjdLdFqu5GJBDif6AoV.DeLTQCvgBrZjuiqrrmd5Qwyhp(new Rect(rect.x + rect.width / 2f - 13f, rect.y + rect.height / 2f, rect.width / 2f - 15f, rect.height / 2f - 15f), delegate
					{
						DL3tNdrQzY7o8FV1oIOKODOLQ.D7CNlmL58D0jGJezjQxztg0NY.DoTab(DYIPJORHeVCfbpocFHvJty4OE.Three);
					}, 15);
				}
				catch
				{
				}
				break;
			}
		}
		try
		{
			bool flag2 = DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj != null;
			if (flag2)
			{
				try
				{
					DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj();
				}
				catch
				{
				}
				DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj = null;
			}
		}
		catch
		{
		}
		try
		{
			DrysTRTjdLdFqu5GJBDif6AoV.Dtib43oq6yhDjtGzggdWk0MwM = new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + 160f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + 15f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.width - 170f, 60f);
			GUILayout.BeginArea(DrysTRTjdLdFqu5GJBDif6AoV.Dtib43oq6yhDjtGzggdWk0MwM);
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			GUILayout.FlexibleSpace();
			DrysTRTjdLdFqu5GJBDif6AoV.DmqgtfHnAl6f6pBDjswVYDqXB("Selected configuration: ", Dxg2tDZdImJqrX71UMTW47xIk.DDQ5PCzTYw7CDj44DlEnnfNBM, 200, "");
			GUILayout.Space(15f);
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			GUILayout.Space(15f);
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			bool flag3 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXvIcon("Save", 0, 30, true);
			if (flag3)
			{
				Dxg2tDZdImJqrX71UMTW47xIk.DFAyL8wNHbluCMKtorDynB4MC(Dxg2tDZdImJqrX71UMTW47xIk.DDQ5PCzTYw7CDj44DlEnnfNBM.DvZuyjYgPRxEKoiET9bNBFdF0);
				Dxg2tDZdImJqrX71UMTW47xIk.DxeJlNfhwsirSRyR3yNds5r6J();
			}
			GUILayout.Space(8f);
			bool flag4 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXvIcon("Load", 1, 30, true);
			if (flag4)
			{
				Dxg2tDZdImJqrX71UMTW47xIk.DcXCWIlY0AW5fJv1MNaTYg6ok(Dxg2tDZdImJqrX71UMTW47xIk.DDQ5PCzTYw7CDj44DlEnnfNBM.DvZuyjYgPRxEKoiET9bNBFdF0 + ".conf");
			}
			GUILayout.Space(8f);
			bool flag5 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXvIcon("CFGs", 2, 30, true);
			if (flag5)
			{
				string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Unturned_Data", "configs");
				Directory.CreateDirectory(text);
				Process.Start("explorer.exe", text);
			}
			GUILayout.EndHorizontal();
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
			GUILayout.EndArea();
		}
		catch
		{
		}
		GUI.Label(new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + 16f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + 5f, 210f, 60f), "<color=#141414>MoonClient V4</color>", DHTB5RKsHUihFrfj9ewuLh1f9.DWfZBauk02v1VFXlXoVXyBq2Q);
		GUI.Label(new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + 15f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + 6f, 210f, 60f), "<color=#141414>MoonClient V4</color>", DHTB5RKsHUihFrfj9ewuLh1f9.DWfZBauk02v1VFXlXoVXyBq2Q);
		GUI.Label(new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + 15f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + 5f, 210f, 60f), DL3tNdrQzY7o8FV1oIOKODOLQ.DGetMoonGradientText() + "<color=#ffffff>Client V4</color>", DHTB5RKsHUihFrfj9ewuLh1f9.DArq80YDH1VSXFAWC7hFLeX3A);
		GUI.DrawTexture(new Rect(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y, 20f * GraphicsSettings.userInterfaceScale, 20f * GraphicsSettings.userInterfaceScale), DHTB5RKsHUihFrfj9ewuLh1f9.DJ5ccrBkXzthVBZKvdtf0TbaS);
		DL3tNdrQzY7o8FV1oIOKODOLQ.DrawAimTargetESP();
	}

	// Token: 0x06000262 RID: 610 RVA: 0x0002296C File Offset: 0x00020B6C
	private static void DrawWelcomeNotification()
	{
		bool flag = DL3tNdrQzY7o8FV1oIOKODOLQ.DwelcomeTimer > 0f;
		if (flag)
		{
			float num = 1f;
			bool flag2 = DL3tNdrQzY7o8FV1oIOKODOLQ.DwelcomeTimer < 2f;
			if (flag2)
			{
				num = DL3tNdrQzY7o8FV1oIOKODOLQ.DwelcomeTimer / 2f;
			}
			Color color = GUI.color;
			GUI.color = new Color(1f, 1f, 1f, num);
			bool flag3 = DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationTitleStyle == null;
			if (flag3)
			{
				DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationTitleStyle = new GUIStyle(GUI.skin.label);
				DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationTitleStyle.alignment = TextAnchor.MiddleCenter;
				DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationTitleStyle.fontSize = 42;
				DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationTitleStyle.fontStyle = FontStyle.Bold;
				DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationTitleStyle.richText = true;
				GUIStyle dnotificationTitleStyle = DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationTitleStyle;
				Font font;
				if ((font = Font.CreateDynamicFontFromOSFont("Trebuchet MS", 42)) == null)
				{
					font = Font.CreateDynamicFontFromOSFont("Verdana", 42) ?? GUI.skin.font;
				}
				dnotificationTitleStyle.font = font;
			}
			bool flag4 = DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationSubtitleStyle == null;
			if (flag4)
			{
				DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationSubtitleStyle = new GUIStyle(GUI.skin.label);
				DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationSubtitleStyle.alignment = TextAnchor.MiddleCenter;
				DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationSubtitleStyle.fontSize = 18;
				DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationSubtitleStyle.richText = true;
				GUIStyle dnotificationSubtitleStyle = DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationSubtitleStyle;
				Font font2;
				if ((font2 = Font.CreateDynamicFontFromOSFont("Trebuchet MS", 18)) == null)
				{
					font2 = Font.CreateDynamicFontFromOSFont("Verdana", 18) ?? GUI.skin.font;
				}
				dnotificationSubtitleStyle.font = font2;
			}
			float num2 = 460f;
			float num3 = 140f;
			float num4 = (float)(Screen.width / 2) - num2 / 2f;
			float num5 = (float)(Screen.height / 2) - num3 / 2f - 50f;
			Rect rect = new Rect(num4, num5, num2, num3);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect, new Color32(20, 20, 22, 240), false, ScaleMode.StretchToFill);
			Color32 accentColor = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, rect.width, 2f), accentColor, false, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y + rect.height - 2f, rect.width, 2f), accentColor, false, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, 2f, rect.height), accentColor, false, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width - 2f, rect.y, 2f, rect.height), accentColor, false, ScaleMode.StretchToFill);
			Rect rect2 = new Rect(rect.x, rect.y + 25f, rect.width, 50f);
			string text = DL3tNdrQzY7o8FV1oIOKODOLQ.DGetMoonGradientText() + "<color=#ffffff>Client</color>";
			Color contentColor = GUI.contentColor;
			GUI.contentColor = new Color(0f, 0f, 0f, num * 0.6f);
			GUI.Label(new Rect(rect2.x + 2f, rect2.y + 2f, rect2.width, rect2.height), "MoonClient", DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationTitleStyle);
			GUI.contentColor = Color.white;
			GUI.Label(rect2, text, DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationTitleStyle);
			Rect rect3 = new Rect(rect.x, rect.y + 80f, rect.width, 35f);
			Color32 accentColor2 = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
			string text2 = string.Format("#{0:X2}{1:X2}{2:X2}", accentColor2.r, accentColor2.g, accentColor2.b);
			string text3 = string.Concat(new string[] { "<color=#888888>Successfully Loaded!</color>  <color=", text2, ">Press </color><color=#ffffff><b>F1</b></color><color=", text2, "> to open the menu</color>" });
			GUI.contentColor = new Color(0f, 0f, 0f, num * 0.6f);
			GUI.Label(new Rect(rect3.x + 1f, rect3.y + 1f, rect3.width, rect3.height), "Successfully Loaded!  Press F1 to open the menu", DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationSubtitleStyle);
			GUI.contentColor = Color.white;
			GUI.Label(rect3, text3, DL3tNdrQzY7o8FV1oIOKODOLQ.DnotificationSubtitleStyle);
			GUI.contentColor = contentColor;
			GUI.color = color;
		}
	}

	// Token: 0x06000263 RID: 611 RVA: 0x00022DDC File Offset: 0x00020FDC
	private static string DGetMoonGradientText()
	{
		Color32 accentColor = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
		Color32 color = new Color32((byte)Mathf.Min(255, (int)(accentColor.r + 80)), (byte)Mathf.Min(255, (int)(accentColor.g + 80)), (byte)Mathf.Min(255, (int)(accentColor.b + 80)), byte.MaxValue);
		Color32 color2 = new Color32((byte)Mathf.Max(0, (int)(accentColor.r - 40)), (byte)Mathf.Max(0, (int)(accentColor.g - 40)), (byte)Mathf.Max(0, (int)(accentColor.b - 40)), byte.MaxValue);
		Color32 color3 = accentColor;
		Color32[] array = new Color32[] { color, color3, color2, color3 };
		string text = "Moon";
		string text2 = "";
		float num = 1.5f;
		float num2 = Time.time * num % (float)array.Length;
		for (int i = 0; i < text.Length; i++)
		{
			float num3 = ((float)i + num2) % (float)array.Length;
			int num4 = Mathf.FloorToInt(num3) % array.Length;
			int num5 = (num4 + 1) % array.Length;
			float num6 = num3 - Mathf.Floor(num3);
			Color32 color4 = Color32.Lerp(array[num4], array[num5], num6);
			string text3 = string.Format("#{0:X2}{1:X2}{2:X2}", color4.r, color4.g, color4.b);
			text2 = string.Concat(new string[]
			{
				text2,
				"<color=",
				text3,
				">",
				text[i].ToString(),
				"</color>"
			});
		}
		return text2;
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00022FB8 File Offset: 0x000211B8
	private static void DrawAimTargetESP()
	{
		bool flag = Player.player == null || Player.player.look == null || Camera.main == null;
		if (!flag)
		{
			Color color = GUI.color;
			Color contentColor = GUI.contentColor;
			try
			{
				bool drawTarget = DCS4Jf0LRzsehKFc5QOLL06qw.drawTarget;
				if (drawTarget)
				{
					Du4XicP1hVrJzXjQ70aniDyvk daseuOZmKRI1v3DQRcsmyTKsC = Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC;
					bool flag2 = daseuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC != null;
					if (flag2)
					{
						Vector3 vector = (Vector3)daseuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC;
						Vector3 vector2 = Camera.main.WorldToScreenPoint(vector);
						bool flag3 = vector2.z > 0f && vector2.x > 0f && vector2.x < (float)Screen.width && vector2.y > 0f && vector2.y < (float)Screen.height;
						if (flag3)
						{
							float num = 20f;
							GUI.color = new Color(1f, 0f, 0f, 1f);
							Rect rect = new Rect(vector2.x - num / 2f, (float)Screen.height - vector2.y - num / 2f, num, num);
							DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect, new Color(1f, 0f, 0f, 0.5f), false, ScaleMode.StretchToFill);
							bool flag4 = DCS4Jf0LRzsehKFc5QOLL06qw.targetLineStartX != 0f || DCS4Jf0LRzsehKFc5QOLL06qw.targetLineStartY != 0f;
							if (flag4)
							{
								Vector2 vector3 = new Vector2(DCS4Jf0LRzsehKFc5QOLL06qw.targetLineStartX, DCS4Jf0LRzsehKFc5QOLL06qw.targetLineStartY);
								Vector2 vector4 = new Vector2(vector2.x, (float)Screen.height - vector2.y);
								DrysTRTjdLdFqu5GJBDif6AoV.DrawLine(vector3, vector4, new Color(1f, 0f, 0f, 0.8f), 2f);
							}
						}
					}
				}
				bool previewHitLimb = DCS4Jf0LRzsehKFc5QOLL06qw.previewHitLimb;
				if (previewHitLimb)
				{
					Du4XicP1hVrJzXjQ70aniDyvk daseuOZmKRI1v3DQRcsmyTKsC2 = Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC;
					bool flag5 = daseuOZmKRI1v3DQRcsmyTKsC2.DnuBpXW8r7IgW3DCiPdbWlBGC != null;
					if (flag5)
					{
						Vector3 vector5 = (Vector3)daseuOZmKRI1v3DQRcsmyTKsC2.DnuBpXW8r7IgW3DCiPdbWlBGC;
						bool replaceHitLimbToCustom = D5l46jlssr4TRAzUSXzLj0uqu.replaceHitLimbToCustom;
						if (replaceHitLimbToCustom)
						{
							Transform transform = Ddagemt6Wc3UeyV4EYXNrXcFf.DL0250m6MAXHl6JdAreUGuchB(daseuOZmKRI1v3DQRcsmyTKsC2.DnuBpXW8r7IgW3DCiPdbWlBGC);
							bool flag6 = transform != null;
							if (flag6)
							{
								D7ElSFH0pY0XmMbO1Ij5Yf3Tp d7ElSFH0pY0XmMbO1Ij5Yf3Tp;
								bool flag7 = D7ElSFH0pY0XmMbO1Ij5Yf3Tp.DI6hlaHSvDDrbtUXgu1QazZzt.TryGetValue(Player.player, out d7ElSFH0pY0XmMbO1Ij5Yf3Tp);
								if (flag7)
								{
									Drvin9V0cgPlOe7ofbFCim7y0 replacedHitLimb = D5l46jlssr4TRAzUSXzLj0uqu.replacedHitLimb;
									vector5 = d7ElSFH0pY0XmMbO1Ij5Yf3Tp.Dzo9lNH7U2XEdXM6IlStBGiUs(replacedHitLimb);
								}
							}
						}
						Vector3 vector6 = Camera.main.WorldToScreenPoint(vector5);
						bool flag8 = vector6.z > 0f && vector6.x > 0f && vector6.x < (float)Screen.width && vector6.y > 0f && vector6.y < (float)Screen.height;
						if (flag8)
						{
							float num2 = (float)DCS4Jf0LRzsehKFc5QOLL06qw.hitMarkSize;
							GUI.color = new Color(0f, 1f, 0f, 1f);
							Rect rect2 = new Rect(vector6.x - num2 / 2f, (float)Screen.height - vector6.y - num2 / 2f, num2, num2);
							DrysTRTjdLdFqu5GJBDif6AoV.DrawLine(new Vector2(rect2.x, rect2.y), new Vector2(rect2.x + rect2.width, rect2.y + rect2.height), new Color(0f, 1f, 0f, 0.9f), 2f);
							DrysTRTjdLdFqu5GJBDif6AoV.DrawLine(new Vector2(rect2.x + rect2.width, rect2.y), new Vector2(rect2.x, rect2.y + rect2.height), new Color(0f, 1f, 0f, 0.9f), 2f);
						}
					}
				}
			}
			catch
			{
			}
			GUI.color = color;
			GUI.contentColor = contentColor;
		}
	}

	// Token: 0x040002EE RID: 750
	public static float Dxra8TwGz4kouqfrUBZWmojmS = 0f;

	// Token: 0x040002EF RID: 751
	public static bool DtKlbZSZSYlN9ldxLbDo4VuvI = false;

	// Token: 0x040002F0 RID: 752
	public static object[] DFfl9bFFFhJhkRgRt7HdXq4DI = new object[0];

	// Token: 0x040002F1 RID: 753
	private static DOEkZ1zoBEuvfUmOs9QSpfX0X[] DVIZ0JsvRm3b0AvGc4wKbcX5t;

	// Token: 0x040002F2 RID: 754
	public static DOEkZ1zoBEuvfUmOs9QSpfX0X D7CNlmL58D0jGJezjQxztg0NY;

	// Token: 0x040002F3 RID: 755
	public static object DyuQWqXsYmbwkeFm6eDaas9Zb;

	// Token: 0x040002F4 RID: 756
	public static Rect D8wZcf2MYCSUsH86wjtXOE64P;

	// Token: 0x040002F5 RID: 757
	public static global::System.Action Dlb00JzD6ydbflXaN4OoBvLdj;

	// Token: 0x040002F6 RID: 758
	public static Rect DChWvgFM7dwLa4Qziaq5j4CZ4 = new Rect((float)(Screen.width / 2 - 320), (float)(Screen.height / 2 - 240), 840f, 570f);

	// Token: 0x040002F7 RID: 759
	public static Texture2D D8EsnZ92xDhkmKXiK5lZ7f83l;

	// Token: 0x040002F8 RID: 760
	private static int DEM5Iv8rUHtuS3ayqb8ydZF89 = 0;

	// Token: 0x040002F9 RID: 761
	private static float Dhr0DniONA0R5J2LeTiAGXl9M = 0f;

	// Token: 0x040002FA RID: 762
	private static float DbP44tT0pxrJzC05kpL9O07GH = 0f;

	// Token: 0x040002FB RID: 763
	public static bool De30FqjVHC03X81IY6Y3eTNN8 = false;

	// Token: 0x040002FC RID: 764
	public static DOEkZ1zoBEuvfUmOs9QSpfX0X DcLM0w9WaAvagqTbdgB0vfG8A;

	// Token: 0x040002FD RID: 765
	private static bool DxtMvc6SS7giNvWtGdo5qONBA = false;

	// Token: 0x040002FE RID: 766
	private static float DYq3Ryo5xtfqAL0urWEXivJZY = 0.4f;

	// Token: 0x040002FF RID: 767
	private static float DopenDelayTimer = 1.5f;

	// Token: 0x04000300 RID: 768
	private static bool DopenDelayedTriggered = false;

	// Token: 0x04000301 RID: 769
	private static float DwelcomeTimer = 5f;

	// Token: 0x04000302 RID: 770
	private static GUIStyle DnotificationTitleStyle;

	// Token: 0x04000303 RID: 771
	private static GUIStyle DnotificationSubtitleStyle;
}
