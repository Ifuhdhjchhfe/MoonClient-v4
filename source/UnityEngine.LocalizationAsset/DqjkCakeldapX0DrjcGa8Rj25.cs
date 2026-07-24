using System;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000A3 RID: 163
public class DqjkCakeldapX0DrjcGa8Rj25
{
	// Token: 0x0600031E RID: 798 RVA: 0x0002F3F4 File Offset: 0x0002D5F4
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(Crosshair), "SetDirectionalArrowsVisible", BindingFlags.Instance | BindingFlags.Public, new Type[] { })]
	public static void DKgOAJPjpAzA6SrXDyZ3PyK5f(Crosshair c, bool isVisible)
	{
		DqjkCakeldapX0DrjcGa8Rj25.DwFSlSzg5owff6Gg73cJhssL6.Set(c, isVisible);
		bool flag = DfU4wrswBK5kLyiyV6mHZwOg8.useCustomCrosshair && DfU4wrswBK5kLyiyV6mHZwOg8.forceDisableDefaultCrosshair;
		bool flag2 = flag;
		if (flag2)
		{
			DqjkCakeldapX0DrjcGa8Rj25.De4dCzBWhMOHK9126FB30nQuX.Get(c).IsVisible = false;
			DqjkCakeldapX0DrjcGa8Rj25.DwMLZbEFmETkAgQFgV91RiV0f.Get(c).IsVisible = false;
			DqjkCakeldapX0DrjcGa8Rj25.DiTShEGRzbr61C07QSMN93Eos.Get(c).IsVisible = false;
			DqjkCakeldapX0DrjcGa8Rj25.D7I7fr8UAOwr0FwbFQZSWluVK.Get(c).IsVisible = false;
		}
		else
		{
			DqjkCakeldapX0DrjcGa8Rj25.De4dCzBWhMOHK9126FB30nQuX.Get(c).IsVisible = isVisible;
			DqjkCakeldapX0DrjcGa8Rj25.DwMLZbEFmETkAgQFgV91RiV0f.Get(c).IsVisible = isVisible;
			DqjkCakeldapX0DrjcGa8Rj25.DiTShEGRzbr61C07QSMN93Eos.Get(c).IsVisible = isVisible;
			DqjkCakeldapX0DrjcGa8Rj25.D7I7fr8UAOwr0FwbFQZSWluVK.Get(c).IsVisible = isVisible;
			DqjkCakeldapX0DrjcGa8Rj25.D124YRpk3odFaMznIAPL7vB0n.Set(c, DqjkCakeldapX0DrjcGa8Rj25.D124YRpk3odFaMznIAPL7vB0n.Get(c) && isVisible);
		}
	}

	// Token: 0x0600031F RID: 799 RVA: 0x0002F4E0 File Offset: 0x0002D6E0
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(Crosshair), "SetGameWantsCenterDotVisible", BindingFlags.Instance | BindingFlags.Public, new Type[] { })]
	public static void DDELEDPNXbfjC3pUgciPhgP5i(Crosshair c, bool isVisible)
	{
		DqjkCakeldapX0DrjcGa8Rj25.D99oJlLeJwsQQbVkWvqtObRNP.Set(c, isVisible);
		bool flag = !DfU4wrswBK5kLyiyV6mHZwOg8.forceDisableDefaultCrosshair || !DfU4wrswBK5kLyiyV6mHZwOg8.useCustomCrosshair;
		bool flag2 = flag;
		if (flag2)
		{
			DqjkCakeldapX0DrjcGa8Rj25.D0M0Wnm34MCHipH8G4TXsi7IV.Get(c).IsVisible = isVisible && DqjkCakeldapX0DrjcGa8Rj25.DQnh00rbjqEOOsOJMRxm986o5.Get(c);
		}
	}

	// Token: 0x06000320 RID: 800 RVA: 0x0002F53C File Offset: 0x0002D73C
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(Crosshair), "SetPluginAllowsCenterDotVisible", BindingFlags.Instance | BindingFlags.Public, new Type[] { })]
	public static void DulOmmicKI8G8qvJlI0O1qoL0(Crosshair c, bool isVisible)
	{
		DqjkCakeldapX0DrjcGa8Rj25.DQnh00rbjqEOOsOJMRxm986o5.Set(c, isVisible);
		bool flag = !DfU4wrswBK5kLyiyV6mHZwOg8.forceDisableDefaultCrosshair || !DfU4wrswBK5kLyiyV6mHZwOg8.useCustomCrosshair;
		bool flag2 = flag;
		if (flag2)
		{
			DqjkCakeldapX0DrjcGa8Rj25.D0M0Wnm34MCHipH8G4TXsi7IV.Get(c).IsVisible = DqjkCakeldapX0DrjcGa8Rj25.D99oJlLeJwsQQbVkWvqtObRNP.Get(c) && isVisible;
		}
		else
		{
			DqjkCakeldapX0DrjcGa8Rj25.D0M0Wnm34MCHipH8G4TXsi7IV.Get(c).IsVisible = false;
		}
	}

	// Token: 0x06000321 RID: 801 RVA: 0x0002F5AC File Offset: 0x0002D7AC
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(Crosshair), "OnUpdate", BindingFlags.Instance | BindingFlags.Public, new Type[] { })]
	public static void DITpg3hgkjvmqGrf0U7BczmVO(Crosshair c)
	{
		bool flag = DfU4wrswBK5kLyiyV6mHZwOg8.useCustomCrosshair && DfU4wrswBK5kLyiyV6mHZwOg8.forceDisableDefaultCrosshair;
		bool flag2 = flag;
		if (flag2)
		{
			bool flag3 = !DqjkCakeldapX0DrjcGa8Rj25.DJ6UwgIxf0ux0Y9o6IQrsJobg;
			bool flag4 = flag3;
			if (flag4)
			{
				bool flag5 = DqjkCakeldapX0DrjcGa8Rj25.DwFSlSzg5owff6Gg73cJhssL6.Get(c);
				bool flag6 = flag5;
				if (flag6)
				{
					DqjkCakeldapX0DrjcGa8Rj25.De4dCzBWhMOHK9126FB30nQuX.Get(c).IsVisible = false;
					DqjkCakeldapX0DrjcGa8Rj25.DwMLZbEFmETkAgQFgV91RiV0f.Get(c).IsVisible = false;
					DqjkCakeldapX0DrjcGa8Rj25.DiTShEGRzbr61C07QSMN93Eos.Get(c).IsVisible = false;
					DqjkCakeldapX0DrjcGa8Rj25.D7I7fr8UAOwr0FwbFQZSWluVK.Get(c).IsVisible = false;
				}
				DqjkCakeldapX0DrjcGa8Rj25.D0M0Wnm34MCHipH8G4TXsi7IV.Get(c).IsVisible = false;
				DqjkCakeldapX0DrjcGa8Rj25.DJ6UwgIxf0ux0Y9o6IQrsJobg = true;
			}
		}
		else
		{
			bool flag7 = !DfU4wrswBK5kLyiyV6mHZwOg8.forceDisableDefaultCrosshair && DqjkCakeldapX0DrjcGa8Rj25.DJ6UwgIxf0ux0Y9o6IQrsJobg;
			bool flag8 = flag7;
			if (flag8)
			{
				bool flag9 = DqjkCakeldapX0DrjcGa8Rj25.DwFSlSzg5owff6Gg73cJhssL6.Get(c);
				bool flag10 = flag9;
				if (flag10)
				{
					DqjkCakeldapX0DrjcGa8Rj25.De4dCzBWhMOHK9126FB30nQuX.Get(c).IsVisible = true;
					DqjkCakeldapX0DrjcGa8Rj25.DwMLZbEFmETkAgQFgV91RiV0f.Get(c).IsVisible = true;
					DqjkCakeldapX0DrjcGa8Rj25.DiTShEGRzbr61C07QSMN93Eos.Get(c).IsVisible = true;
					DqjkCakeldapX0DrjcGa8Rj25.D7I7fr8UAOwr0FwbFQZSWluVK.Get(c).IsVisible = true;
				}
				DqjkCakeldapX0DrjcGa8Rj25.D0M0Wnm34MCHipH8G4TXsi7IV.Get(c).IsVisible = DqjkCakeldapX0DrjcGa8Rj25.D99oJlLeJwsQQbVkWvqtObRNP.Get(c) && DqjkCakeldapX0DrjcGa8Rj25.DQnh00rbjqEOOsOJMRxm986o5.Get(c);
				DqjkCakeldapX0DrjcGa8Rj25.DJ6UwgIxf0ux0Y9o6IQrsJobg = false;
			}
			bool flag11 = !DqjkCakeldapX0DrjcGa8Rj25.DwFSlSzg5owff6Gg73cJhssL6.Get(c);
			bool flag12 = flag11;
			if (flag12)
			{
				DqjkCakeldapX0DrjcGa8Rj25.D124YRpk3odFaMznIAPL7vB0n.Set(c, false);
			}
			else
			{
				UseableGun useableGun = Player.player.equipment.useable as UseableGun;
				bool flag13 = useableGun == null;
				bool flag14 = flag13;
				if (flag14)
				{
					DqjkCakeldapX0DrjcGa8Rj25.D124YRpk3odFaMznIAPL7vB0n.Set(c, false);
				}
				else
				{
					Camera instance = MainCamera.instance;
					bool flag15 = instance == null;
					bool flag16 = flag15;
					if (flag16)
					{
						DqjkCakeldapX0DrjcGa8Rj25.D124YRpk3odFaMznIAPL7vB0n.Set(c, false);
					}
					else
					{
						float fieldOfView = instance.fieldOfView;
						float num = 0.017453292f * fieldOfView * 0.5f;
						bool flag17 = num < 0.001f;
						bool flag18 = flag17;
						if (flag18)
						{
							DqjkCakeldapX0DrjcGa8Rj25.D124YRpk3odFaMznIAPL7vB0n.Set(c, false);
						}
						else
						{
							bool flag19 = Player.player.look.perspective == EPlayerPerspective.FIRST;
							bool flag20 = flag19;
							Vector2 vector3;
							if (flag20)
							{
								Quaternion rotation = Player.player.look.aim.rotation;
								Quaternion quaternion = Quaternion.Euler(Player.player.animator.recoilViewmodelCameraRotation.currentPosition);
								Vector3 vector = rotation * quaternion * Vector3.forward;
								Vector2 vector2 = instance.WorldToViewportPoint(instance.transform.position + vector);
								vector3 = c.ViewportToNormalizedPosition(vector2);
								vector3.x += c.Parent.PositionScale_X;
								vector3.y += c.Parent.PositionScale_Y;
							}
							else
							{
								vector3 = new Vector2(0.5f, 0.5f);
							}
							float num2 = Dp86EPUU0qiRCgpoTgjzXqsq4.DMGzyINd9semIrmvPZmwlgcjZ() * (DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6 ? 1f : D5l46jlssr4TRAzUSXzLj0uqu.spreadMultiplier);
							DqjkCakeldapX0DrjcGa8Rj25.DSB0HoFRNzhLwcGCDFi6OMXYR.instance = c;
							bool flag21 = DqjkCakeldapX0DrjcGa8Rj25.D124YRpk3odFaMznIAPL7vB0n.Get(c) && !DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6;
							bool flag22 = flag21;
							if (flag22)
							{
								DqjkCakeldapX0DrjcGa8Rj25.DSB0HoFRNzhLwcGCDFi6OMXYR.value = Mathf.Lerp(DqjkCakeldapX0DrjcGa8Rj25.DSB0HoFRNzhLwcGCDFi6OMXYR.Get(), num2, Time.deltaTime * 16f);
							}
							else
							{
								DqjkCakeldapX0DrjcGa8Rj25.DSB0HoFRNzhLwcGCDFi6OMXYR.value = num2;
								DqjkCakeldapX0DrjcGa8Rj25.D124YRpk3odFaMznIAPL7vB0n.Set(c, true);
							}
							float num3 = Mathf.Tan(num);
							float num4 = num3 * instance.aspect;
							float num5 = Mathf.Tan(DqjkCakeldapX0DrjcGa8Rj25.DSB0HoFRNzhLwcGCDFi6OMXYR.Get());
							float num6 = num5 / num4 * 0.5f;
							float num7 = num5 / num3 * 0.5f;
							bool useStaticCrosshair = OptionsSettings.useStaticCrosshair;
							bool flag23 = useStaticCrosshair;
							if (flag23)
							{
								num6 = Mathf.Lerp(0.0025f, 0.05f, OptionsSettings.staticCrosshairSize);
								num7 = num6 * instance.aspect;
							}
							DqjkCakeldapX0DrjcGa8Rj25.De4dCzBWhMOHK9126FB30nQuX.instance = c;
							DqjkCakeldapX0DrjcGa8Rj25.DwMLZbEFmETkAgQFgV91RiV0f.instance = c;
							DqjkCakeldapX0DrjcGa8Rj25.DiTShEGRzbr61C07QSMN93Eos.instance = c;
							DqjkCakeldapX0DrjcGa8Rj25.D7I7fr8UAOwr0FwbFQZSWluVK.instance = c;
							DqjkCakeldapX0DrjcGa8Rj25.De4dCzBWhMOHK9126FB30nQuX.value.PositionScale_X = vector3.x - num6;
							DqjkCakeldapX0DrjcGa8Rj25.De4dCzBWhMOHK9126FB30nQuX.value.PositionScale_Y = vector3.y;
							DqjkCakeldapX0DrjcGa8Rj25.DwMLZbEFmETkAgQFgV91RiV0f.value.PositionScale_X = vector3.x + num6;
							DqjkCakeldapX0DrjcGa8Rj25.DwMLZbEFmETkAgQFgV91RiV0f.value.PositionScale_Y = vector3.y;
							DqjkCakeldapX0DrjcGa8Rj25.DiTShEGRzbr61C07QSMN93Eos.value.PositionScale_X = vector3.x;
							DqjkCakeldapX0DrjcGa8Rj25.DiTShEGRzbr61C07QSMN93Eos.value.PositionScale_Y = vector3.y - num7;
							DqjkCakeldapX0DrjcGa8Rj25.D7I7fr8UAOwr0FwbFQZSWluVK.value.PositionScale_X = vector3.x;
							DqjkCakeldapX0DrjcGa8Rj25.D7I7fr8UAOwr0FwbFQZSWluVK.value.PositionScale_Y = vector3.y + num7;
						}
					}
				}
			}
		}
	}

	// Token: 0x04000382 RID: 898
	public static DGZv08vQyz81zrHxUqhmYuCdY<bool> D99oJlLeJwsQQbVkWvqtObRNP = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(Crosshair), "gameWantsCenterDotVisible", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000383 RID: 899
	public static DGZv08vQyz81zrHxUqhmYuCdY<bool> DQnh00rbjqEOOsOJMRxm986o5 = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(Crosshair), "pluginAllowsCenterDotVisible", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000384 RID: 900
	public static DGZv08vQyz81zrHxUqhmYuCdY<bool> DwFSlSzg5owff6Gg73cJhssL6 = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(Crosshair), "isGunCrosshairVisible", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000385 RID: 901
	public static DGZv08vQyz81zrHxUqhmYuCdY<bool> D124YRpk3odFaMznIAPL7vB0n = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(Crosshair), "isInterpolatedSpreadValid", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000386 RID: 902
	public static DGZv08vQyz81zrHxUqhmYuCdY<float> DSB0HoFRNzhLwcGCDFi6OMXYR = new DGZv08vQyz81zrHxUqhmYuCdY<float>(typeof(Crosshair), "interpolatedSpread", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000387 RID: 903
	public static DGZv08vQyz81zrHxUqhmYuCdY<ISleekImage> D0M0Wnm34MCHipH8G4TXsi7IV = new DGZv08vQyz81zrHxUqhmYuCdY<ISleekImage>(typeof(Crosshair), "centerDotImage", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000388 RID: 904
	public static DGZv08vQyz81zrHxUqhmYuCdY<ISleekImage> De4dCzBWhMOHK9126FB30nQuX = new DGZv08vQyz81zrHxUqhmYuCdY<ISleekImage>(typeof(Crosshair), "crosshairLeftImage", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x04000389 RID: 905
	public static DGZv08vQyz81zrHxUqhmYuCdY<ISleekImage> DwMLZbEFmETkAgQFgV91RiV0f = new DGZv08vQyz81zrHxUqhmYuCdY<ISleekImage>(typeof(Crosshair), "crosshairRightImage", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400038A RID: 906
	public static DGZv08vQyz81zrHxUqhmYuCdY<ISleekImage> DiTShEGRzbr61C07QSMN93Eos = new DGZv08vQyz81zrHxUqhmYuCdY<ISleekImage>(typeof(Crosshair), "crosshairUpImage", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400038B RID: 907
	public static DGZv08vQyz81zrHxUqhmYuCdY<ISleekImage> D7I7fr8UAOwr0FwbFQZSWluVK = new DGZv08vQyz81zrHxUqhmYuCdY<ISleekImage>(typeof(Crosshair), "crosshairDownImage", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x0400038C RID: 908
	public static bool DJ6UwgIxf0ux0Y9o6IQrsJobg = false;
}
