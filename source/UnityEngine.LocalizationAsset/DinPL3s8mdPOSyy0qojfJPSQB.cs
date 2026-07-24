using System;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000073 RID: 115
public class DinPL3s8mdPOSyy0qojfJPSQB
{
	// Token: 0x0600023A RID: 570 RVA: 0x000203B4 File Offset: 0x0001E5B4
	[DyRHDWg89xeNs0wA42v5OHmTi]
	public static void Dr5jc0X6WXGK0r0VnmipwmKBe()
	{
		DinPL3s8mdPOSyy0qojfJPSQB.DkRmvtRiJxb3sQDFi5yoqhYgl = typeof(PlayerLook).GetField("sweepHits", BindingFlags.Static | BindingFlags.NonPublic);
		DinPL3s8mdPOSyy0qojfJPSQB.DJv8o94SksWk1DEoZ8ZvnOtQH = typeof(PlayerLook).GetField("flinchLocalRotation", BindingFlags.Instance | BindingFlags.NonPublic);
		DinPL3s8mdPOSyy0qojfJPSQB.Dm3zb2C6uM0h0YHYkaBtIY3pW = typeof(PlayerAnimator).GetMethod("FlinchFromExplosion", BindingFlags.Instance | BindingFlags.NonPublic);
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00020414 File Offset: 0x0001E614
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerLook), "get_isCam", new Type[] { })]
	public bool D5f9WQ3j4OiYTqa2o82QxrLZR()
	{
		return D5l46jlssr4TRAzUSXzLj0uqu.freeCamera || DA1dZHkBmPouE1WuakM2TW4QH.DV5fBuuwwtgOKLKyiAmdzlRoa<bool>(this, Array.Empty<object>());
	}

	// Token: 0x0600023C RID: 572 RVA: 0x0002043C File Offset: 0x0001E63C
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerLook), "FlinchFromDamage", new Type[] { })]
	internal void DiPM6ZmKxhCicWaNpjdgmV5AS(byte damageAmount, Vector3 worldDirection)
	{
		Camera instance = MainCamera.instance;
		bool flag = instance == null;
		bool flag2 = !flag;
		if (flag2)
		{
			Vector3 normalized = Vector3.Cross(Vector3.up, worldDirection).normalized;
			Vector3 vector = instance.transform.InverseTransformDirection(normalized);
			float num = (float)Mathf.Min((int)damageAmount, 25) * 0.5f;
			float num2 = 1f - Player.player.skills.mastery(1, 3) * 0.75f;
			Quaternion quaternion = Quaternion.AngleAxis(num * num2 * D5l46jlssr4TRAzUSXzLj0uqu.damagePunchMultiplier, vector);
			DinPL3s8mdPOSyy0qojfJPSQB.DJv8o94SksWk1DEoZ8ZvnOtQH.SetValue(Player.player.look, (Quaternion)DinPL3s8mdPOSyy0qojfJPSQB.DJv8o94SksWk1DEoZ8ZvnOtQH.GetValue(Player.player.look) * quaternion);
		}
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00020508 File Offset: 0x0001E708
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerLook), "clampPitch", new Type[] { })]
	private void D8LthqITjgiNs0nTWH7Jeg7Tm()
	{
		bool flag = DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6 || !D5l46jlssr4TRAzUSXzLj0uqu.unclampCameraRotation;
		bool flag2 = flag;
		if (flag2)
		{
			DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, Array.Empty<object>());
		}
	}

	// Token: 0x0600023E RID: 574 RVA: 0x0002053C File Offset: 0x0001E73C
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerLook), "clampYaw", new Type[] { })]
	private void Dep4d0d33vTZZwoelWgdTHyBo()
	{
		bool flag = DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6 || !D5l46jlssr4TRAzUSXzLj0uqu.unclampCameraRotation;
		bool flag2 = flag;
		if (flag2)
		{
			DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, Array.Empty<object>());
		}
	}

	// Token: 0x0600023F RID: 575 RVA: 0x00020570 File Offset: 0x0001E770
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerLook), "Update", BindingFlags.Instance | BindingFlags.NonPublic, new Type[] { })]
	public static void DVYOT64PMMFLE36xG24fAKvGn(PlayerLook instance)
	{
		bool flag = !instance.channel.IsLocalPlayer || !D5l46jlssr4TRAzUSXzLj0uqu.freeCamera;
		bool flag2 = flag;
		if (flag2)
		{
			DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(instance, Array.Empty<object>());
		}
	}

	// Token: 0x06000240 RID: 576 RVA: 0x000205AC File Offset: 0x0001E7AC
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerLook), "sphereCastCamera", new Type[] { })]
	private Vector3 D2oG00IQ1Je6Bli5Gqiw0JdaJ(Vector3 origin, Vector3 direction, float length, int layerMask)
	{
		bool dbjv74arVJtUMAqsSN0cWr9w = DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6;
		bool flag = dbjv74arVJtUMAqsSN0cWr9w;
		Vector3 vector;
		if (flag)
		{
			vector = DA1dZHkBmPouE1WuakM2TW4QH.DV5fBuuwwtgOKLKyiAmdzlRoa<Vector3>(this, new object[] { origin, direction, length, layerMask });
		}
		else
		{
			int num = Physics.SphereCastNonAlloc(new Ray(origin, direction), 0.39f, DinPL3s8mdPOSyy0qojfJPSQB.DkRmvtRiJxb3sQDFi5yoqhYgl.GetValue(null) as RaycastHit[], length, D5l46jlssr4TRAzUSXzLj0uqu.thirdCameraIgnoreObstacles ? 1 : layerMask, QueryTriggerInteraction.Ignore);
			float num2 = length + D5l46jlssr4TRAzUSXzLj0uqu.thirdCameraDistance;
			for (int i = 0; i < num; i++)
			{
				num2 = Mathf.Min(num2, (DinPL3s8mdPOSyy0qojfJPSQB.DkRmvtRiJxb3sQDFi5yoqhYgl.GetValue(null) as RaycastHit[])[i].distance);
			}
			vector = origin + direction * num2;
		}
		return vector;
	}

	// Token: 0x06000241 RID: 577 RVA: 0x0002068C File Offset: 0x0001E88C
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerLook), "setActivePerspective", new Type[] { })]
	private void DlT62LZJ7KjTCDTChEAoBc0Q7(EPlayerPerspective newPerspective)
	{
		bool dbjv74arVJtUMAqsSN0cWr9w = DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6;
		bool flag = dbjv74arVJtUMAqsSN0cWr9w;
		if (flag)
		{
			bool flag2;
			if (newPerspective == EPlayerPerspective.THIRD)
			{
				ECameraMode d66xkrBp6Z1GTuSAAF2uDhRmK = D5l46jlssr4TRAzUSXzLj0uqu.D66xkrBp6Z1GTuSAAF2uDhRmK;
				flag2 = D5l46jlssr4TRAzUSXzLj0uqu.D66xkrBp6Z1GTuSAAF2uDhRmK == ECameraMode.VEHICLE && Player.player.movement.getVehicle() == null;
			}
			else
			{
				flag2 = false;
			}
			bool flag3 = flag2;
			bool flag4 = flag3;
			if (flag4)
			{
				DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, new object[] { 0 });
				return;
			}
			bool flag5 = false;
			bool flag6 = flag5;
			if (flag6)
			{
				DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, new object[] { 1 });
				return;
			}
		}
		DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, new object[] { newPerspective });
	}

	// Token: 0x06000242 RID: 578 RVA: 0x00020730 File Offset: 0x0001E930
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerLook), "InitializePlayer", BindingFlags.Instance | BindingFlags.NonPublic, new Type[] { })]
	public static void Dgk24Rr8i5fvlsCofKtrHc1OS(Player player)
	{
		DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(player, Array.Empty<object>());
		try
		{
			bool flag = player.channel.IsLocalPlayer && D5l46jlssr4TRAzUSXzLj0uqu.imitNightvision && !DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6;
			bool flag2 = flag;
			if (flag2)
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
				LevelLighting.vision = D5l46jlssr4TRAzUSXzLj0uqu.nightVisionType.D6HbJZ2NUXUKMVsndz6x1ZFtz();
				LevelLighting.updateLighting();
				LevelLighting.updateLocal();
				D9sqUkDmUbz7uUc5edvQF8hDl.D2hcRGy0VyZxVqJMX9bijVbJx();
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00020854 File Offset: 0x0001EA54
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerLook), "FlinchFromExplosion", new Type[] { })]
	internal void DZ3YN3gJ5wsoAdBFNvxCQjnog(Vector3 position, float radius, float magnitudeDegrees)
	{
		Camera instance = MainCamera.instance;
		bool flag = instance == null;
		bool flag2 = !flag;
		if (flag2)
		{
			Vector3 vector = instance.transform.position - position;
			float magnitude = vector.magnitude;
			bool flag3 = magnitude <= 0f || magnitude >= radius;
			bool flag4 = !flag3;
			if (flag4)
			{
				Vector3 vector2 = vector / magnitude;
				Vector3 normalized = Vector3.Cross(Vector3.up, vector2).normalized;
				Vector3 vector3 = instance.transform.InverseTransformDirection(normalized);
				float num = 1f - Player.player.skills.mastery(1, 3) * 0.5f;
				float num2 = 1f - MathfEx.Square(magnitude / radius);
				magnitudeDegrees *= num * num2 * D5l46jlssr4TRAzUSXzLj0uqu.damagePunchMultiplier;
				Player.player.look.targetExplosionLocalRotation.currentRotation = Player.player.look.targetExplosionLocalRotation.currentRotation * Quaternion.AngleAxis(magnitudeDegrees, vector3);
				DinPL3s8mdPOSyy0qojfJPSQB.Dm3zb2C6uM0h0YHYkaBtIY3pW.Invoke(Player.player.animator, new object[] { vector2, magnitudeDegrees });
			}
		}
	}

	// Token: 0x040002D0 RID: 720
	private static FieldInfo DkRmvtRiJxb3sQDFi5yoqhYgl;

	// Token: 0x040002D1 RID: 721
	private static FieldInfo DJv8o94SksWk1DEoZ8ZvnOtQH;

	// Token: 0x040002D2 RID: 722
	private static MethodInfo Dm3zb2C6uM0h0YHYkaBtIY3pW;
}
