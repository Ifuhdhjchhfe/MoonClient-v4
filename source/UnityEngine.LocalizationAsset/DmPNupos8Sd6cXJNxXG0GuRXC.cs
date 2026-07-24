using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200008A RID: 138
public class DmPNupos8Sd6cXJNxXG0GuRXC
{
	// Token: 0x06000292 RID: 658 RVA: 0x00026188 File Offset: 0x00024388
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DZa3SAofS1zfHDoX4V4OAgi5q()
	{
		DI4RfMJ7ziJuscMZZoy2MIzrV.De2hBwLmnyYClZ9fwAmbPOhqc = (DIDzNgrvnOa5xIZrJtz5ZO48o)Delegate.Combine(DI4RfMJ7ziJuscMZZoy2MIzrV.De2hBwLmnyYClZ9fwAmbPOhqc, new DIDzNgrvnOa5xIZrJtz5ZO48o(delegate
		{
			DmPNupos8Sd6cXJNxXG0GuRXC.DRwQ9E4NCXRS2etcVzJAcLO5o(false);
		}));
		DI4RfMJ7ziJuscMZZoy2MIzrV.DU6EO20XNycI0rg03jSyQr0k6 = (DIDzNgrvnOa5xIZrJtz5ZO48o)Delegate.Combine(DI4RfMJ7ziJuscMZZoy2MIzrV.DU6EO20XNycI0rg03jSyQr0k6, new DIDzNgrvnOa5xIZrJtz5ZO48o(delegate
		{
			DmPNupos8Sd6cXJNxXG0GuRXC.DRwQ9E4NCXRS2etcVzJAcLO5o(true);
		}));
		Provider.onClientDisconnected = (Provider.ClientDisconnected)Delegate.Combine(Provider.onClientDisconnected, new Provider.ClientDisconnected(delegate
		{
			foreach (DvokU5hcv2P63Imn0f6sStWTw dvokU5hcv2P63Imn0f6sStWTw in DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7)
			{
				bool flag = dvokU5hcv2P63Imn0f6sStWTw.DML2XiQQOgEOKuqQfAY7BHG2d != null;
				bool flag2 = flag;
				if (flag2)
				{
					global::UnityEngine.Object.Destroy(dvokU5hcv2P63Imn0f6sStWTw.DML2XiQQOgEOKuqQfAY7BHG2d);
				}
			}
			foreach (DCJW8k4jS5tnCUQXemffRym03 dcjw8k4jS5tnCUQXemffRym in DmPNupos8Sd6cXJNxXG0GuRXC.DHbwodoJDwUy096ggjhFLne0k)
			{
				bool flag3 = dcjw8k4jS5tnCUQXemffRym.Dt5M4m3QoFvnQkn3VZzhTSHVU != null;
				bool flag4 = flag3;
				if (flag4)
				{
					global::UnityEngine.Object.Destroy(dcjw8k4jS5tnCUQXemffRym.Dt5M4m3QoFvnQkn3VZzhTSHVU);
				}
			}
		}));
	}

	// Token: 0x06000293 RID: 659 RVA: 0x00026230 File Offset: 0x00024430
	private static void DRwQ9E4NCXRS2etcVzJAcLO5o(bool state)
	{
		foreach (DvokU5hcv2P63Imn0f6sStWTw dvokU5hcv2P63Imn0f6sStWTw in DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7)
		{
			dvokU5hcv2P63Imn0f6sStWTw.DML2XiQQOgEOKuqQfAY7BHG2d.SetActive(state);
		}
		foreach (DCJW8k4jS5tnCUQXemffRym03 dcjw8k4jS5tnCUQXemffRym in DmPNupos8Sd6cXJNxXG0GuRXC.DHbwodoJDwUy096ggjhFLne0k)
		{
			dcjw8k4jS5tnCUQXemffRym.Dt5M4m3QoFvnQkn3VZzhTSHVU.SetActive(state);
		}
	}

	// Token: 0x06000294 RID: 660 RVA: 0x000262D8 File Offset: 0x000244D8
	public static void DIrqpd5m91qPA2zBgj06qVM7O(Vector3 startPoint, Vector3 endPoint, uint index)
	{
		for (int i = 0; i < DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7.Count; i++)
		{
			bool flag = DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7[i].DTaN0Zd5kEDhBTrt2ZZtoSHLR == index;
			bool flag2 = flag;
			if (flag2)
			{
				global::UnityEngine.Object.Destroy(DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7[i].DML2XiQQOgEOKuqQfAY7BHG2d);
				DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7.RemoveAt(i);
				DmPNupos8Sd6cXJNxXG0GuRXC.Dpw12PRHvXQP0KXBj1Eibzva2(startPoint, endPoint, index);
				break;
			}
		}
	}

	// Token: 0x06000295 RID: 661 RVA: 0x00026348 File Offset: 0x00024548
	public static DvokU5hcv2P63Imn0f6sStWTw Dpw12PRHvXQP0KXBj1Eibzva2(Vector3 startPoint, Vector3 endPoint, uint index = 0U)
	{
		bool flag = !DfU4wrswBK5kLyiyV6mHZwOg8.drawTracers || startPoint == Vector3.zero || endPoint == Vector3.zero;
		bool flag2 = flag;
		DvokU5hcv2P63Imn0f6sStWTw dvokU5hcv2P63Imn0f6sStWTw;
		if (flag2)
		{
			dvokU5hcv2P63Imn0f6sStWTw = new DvokU5hcv2P63Imn0f6sStWTw(Vector3.zero, Vector3.zero, 0f, uint.MaxValue);
		}
		else
		{
			DvokU5hcv2P63Imn0f6sStWTw dvokU5hcv2P63Imn0f6sStWTw2 = new DvokU5hcv2P63Imn0f6sStWTw(startPoint, endPoint, 0f, (index == 0U) ? DmPNupos8Sd6cXJNxXG0GuRXC.DYDyiwRoVFTmp08vDopCrKYwD : index);
			DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7.Add(dvokU5hcv2P63Imn0f6sStWTw2);
			DmPNupos8Sd6cXJNxXG0GuRXC.DYDyiwRoVFTmp08vDopCrKYwD += 1U;
			dvokU5hcv2P63Imn0f6sStWTw = dvokU5hcv2P63Imn0f6sStWTw2;
		}
		return dvokU5hcv2P63Imn0f6sStWTw;
	}

	// Token: 0x06000296 RID: 662 RVA: 0x000263D8 File Offset: 0x000245D8
	public static void DbGurvE8qaYmJsWattQsbJdJB(Vector3 point, ushort damage)
	{
		bool drawDamageHitmark = DfU4wrswBK5kLyiyV6mHZwOg8.drawDamageHitmark;
		bool flag = drawDamageHitmark;
		if (flag)
		{
			bool flag2 = DfU4wrswBK5kLyiyV6mHZwOg8.isDamageHitmarkersCombined && DmPNupos8Sd6cXJNxXG0GuRXC.DTYTtzEyiXaPpKFONcUM7arVa.Count != 0;
			bool flag3 = flag2;
			if (flag3)
			{
				for (int i = 0; i < DmPNupos8Sd6cXJNxXG0GuRXC.DTYTtzEyiXaPpKFONcUM7arVa.Count; i++)
				{
					bool flag4 = Vector3.Distance(DmPNupos8Sd6cXJNxXG0GuRXC.DTYTtzEyiXaPpKFONcUM7arVa[i].DqfAlQGHzYLVVxGL7lTHUGmZQ, point) <= DfU4wrswBK5kLyiyV6mHZwOg8.damageHitmarksCombineDistance;
					bool flag5 = flag4;
					if (flag5)
					{
						DZ3Itlkf53ILNBmHkkOKBK3gF dz3Itlkf53ILNBmHkkOKBK3gF = DmPNupos8Sd6cXJNxXG0GuRXC.DTYTtzEyiXaPpKFONcUM7arVa[i];
						dz3Itlkf53ILNBmHkkOKBK3gF.DNOrRMVnqdnYgutIXoSUuuel4 += damage;
						dz3Itlkf53ILNBmHkkOKBK3gF.DqfAlQGHzYLVVxGL7lTHUGmZQ = point;
						dz3Itlkf53ILNBmHkkOKBK3gF.DZkiRsxdbVRtHcmX5h917TLJT = point;
						dz3Itlkf53ILNBmHkkOKBK3gF.Ds4ihRKvo5CFudeO7GkISZtB4 = 0f;
						bool scaleCombinedHitmarkers = DfU4wrswBK5kLyiyV6mHZwOg8.scaleCombinedHitmarkers;
						bool flag6 = scaleCombinedHitmarkers;
						if (flag6)
						{
							dz3Itlkf53ILNBmHkkOKBK3gF.DArZIamcBkgHRM2CvgStt50ng += 1;
						}
						DmPNupos8Sd6cXJNxXG0GuRXC.DTYTtzEyiXaPpKFONcUM7arVa[i] = dz3Itlkf53ILNBmHkkOKBK3gF;
						return;
					}
				}
			}
			DmPNupos8Sd6cXJNxXG0GuRXC.DTYTtzEyiXaPpKFONcUM7arVa.Add(new DZ3Itlkf53ILNBmHkkOKBK3gF(point, damage));
		}
	}

	// Token: 0x06000297 RID: 663 RVA: 0x000264E4 File Offset: 0x000246E4
	public static void DK8CcwvxKW0XeoKUzC0AcaVPv(PlayerMovement movement, bool isLand = false)
	{
		bool flag = Vector3.Distance(movement.transform.position, MainCamera.instance.transform.position) < (float)DfU4wrswBK5kLyiyV6mHZwOg8.stepsDrawDistance;
		bool flag2 = flag;
		if (flag2)
		{
			DmPNupos8Sd6cXJNxXG0GuRXC.DHbwodoJDwUy096ggjhFLne0k.Add(new DCJW8k4jS5tnCUQXemffRym03(movement, isLand, movement.player.stance.stance == EPlayerStance.SPRINT));
		}
	}

	// Token: 0x06000298 RID: 664 RVA: 0x00026548 File Offset: 0x00024748
	private static void DpS7tZ9l6DWCH8pQK9xWIkKk6()
	{
		bool useGLTracers = DfU4wrswBK5kLyiyV6mHZwOg8.useGLTracers;
		bool flag = useGLTracers;
		if (flag)
		{
			DDddnUl0gHJ8ZiQTaRLEUBUS2.DRU76pLEmpRdoUUcrMxfLqXNx.SetPass(0);
			GL.PushMatrix();
			GL.LoadProjectionMatrix(DhNbDL0xpxhG1wADC5uXvFshQ.D0dFeYUac5o0ycmUFaeSj1J46);
			GL.modelview = DhNbDL0xpxhG1wADC5uXvFshQ.Dvnc7NMv3T5T0nPfgcO28KXhC;
			GL.Begin(1);
		}
		Color color = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Tracers color");
		float a = color.a;
		List<int> list = new List<int>();
		for (int i = 0; i < DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7.Count; i++)
		{
			DvokU5hcv2P63Imn0f6sStWTw dvokU5hcv2P63Imn0f6sStWTw = DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7[i];
			dvokU5hcv2P63Imn0f6sStWTw.DI6mpVC2oCcVZrqNVI7hBJO2n += Time.deltaTime / DfU4wrswBK5kLyiyV6mHZwOg8.tracersLifetime;
			bool flag2 = dvokU5hcv2P63Imn0f6sStWTw.DI6mpVC2oCcVZrqNVI7hBJO2n > 1f;
			bool flag3 = flag2;
			if (flag3)
			{
				list.Add(i);
			}
			else
			{
				bool useGLTracers2 = DfU4wrswBK5kLyiyV6mHZwOg8.useGLTracers;
				bool flag4 = useGLTracers2;
				if (flag4)
				{
					GL.Color(new Color(color.r, color.g, color.b, a * (1f - dvokU5hcv2P63Imn0f6sStWTw.DI6mpVC2oCcVZrqNVI7hBJO2n)));
					GL.Vertex(dvokU5hcv2P63Imn0f6sStWTw.DbzYNqzkiPiXKfymPXn5wgL6w);
					GL.Vertex(dvokU5hcv2P63Imn0f6sStWTw.DjzgyyDW7duyS17YJw456Ndsi);
				}
				else
				{
					bool flag5 = DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7[i].DZlSSu8C6ahV1sSnPFWXAOKD5 != null;
					bool flag6 = flag5;
					if (flag6)
					{
						DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7[i].DZlSSu8C6ahV1sSnPFWXAOKD5.color = new Color(color.r, color.g, color.b, a * (1f - dvokU5hcv2P63Imn0f6sStWTw.DI6mpVC2oCcVZrqNVI7hBJO2n));
					}
				}
			}
			DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7[i] = dvokU5hcv2P63Imn0f6sStWTw;
		}
		bool useGLTracers3 = DfU4wrswBK5kLyiyV6mHZwOg8.useGLTracers;
		bool flag7 = useGLTracers3;
		if (flag7)
		{
			GL.End();
			GL.PopMatrix();
		}
		bool flag8 = list.Count > 0;
		bool flag9 = flag8;
		if (flag9)
		{
			list.Reverse();
			foreach (int num in list)
			{
				bool flag10 = !DfU4wrswBK5kLyiyV6mHZwOg8.useGLTracers && DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7[num].DML2XiQQOgEOKuqQfAY7BHG2d != null;
				bool flag11 = flag10;
				if (flag11)
				{
					global::UnityEngine.Object.Destroy(DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7[num].DML2XiQQOgEOKuqQfAY7BHG2d);
				}
				DmPNupos8Sd6cXJNxXG0GuRXC.Dol7gU5azkPPN1UIRnFPi3md7.RemoveAt(num);
			}
		}
	}

	// Token: 0x06000299 RID: 665 RVA: 0x000267B8 File Offset: 0x000249B8
	private static void DDE6kFw80d2om41ZBj5K3e28j()
	{
		Color color = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Player step color");
		float a = color.a;
		int num = -1;
		for (int i = 0; i < DmPNupos8Sd6cXJNxXG0GuRXC.DHbwodoJDwUy096ggjhFLne0k.Count; i++)
		{
			DCJW8k4jS5tnCUQXemffRym03 dcjw8k4jS5tnCUQXemffRym = DmPNupos8Sd6cXJNxXG0GuRXC.DHbwodoJDwUy096ggjhFLne0k[i];
			dcjw8k4jS5tnCUQXemffRym.D87mvhEC6atad8piZhPzdF71E += Time.deltaTime / DfU4wrswBK5kLyiyV6mHZwOg8.stepsLifetime;
			bool flag = dcjw8k4jS5tnCUQXemffRym.D87mvhEC6atad8piZhPzdF71E > 1f || DmPNupos8Sd6cXJNxXG0GuRXC.DHbwodoJDwUy096ggjhFLne0k[i].Dt5M4m3QoFvnQkn3VZzhTSHVU == null;
			bool flag2 = flag;
			if (flag2)
			{
				num = i;
			}
			else
			{
				DmPNupos8Sd6cXJNxXG0GuRXC.DHbwodoJDwUy096ggjhFLne0k[i].DwRw5XKeCbb0aL1lTzgFwBIb0.color = new Color(color.r, color.g, color.b, a * (1f - dcjw8k4jS5tnCUQXemffRym.D87mvhEC6atad8piZhPzdF71E));
				DmPNupos8Sd6cXJNxXG0GuRXC.DHbwodoJDwUy096ggjhFLne0k[i].Dt5M4m3QoFvnQkn3VZzhTSHVU.transform.localScale = Vector3.one * (dcjw8k4jS5tnCUQXemffRym.D87mvhEC6atad8piZhPzdF71E * DfU4wrswBK5kLyiyV6mHZwOg8.stepsSpreadingDistance * DmPNupos8Sd6cXJNxXG0GuRXC.DHbwodoJDwUy096ggjhFLne0k[i].DwHtMROXjYUxWOIrRjUZbeHsI);
			}
			DmPNupos8Sd6cXJNxXG0GuRXC.DHbwodoJDwUy096ggjhFLne0k[i] = dcjw8k4jS5tnCUQXemffRym;
		}
		bool flag3 = num != -1;
		bool flag4 = flag3;
		if (flag4)
		{
			global::UnityEngine.Object.Destroy(DmPNupos8Sd6cXJNxXG0GuRXC.DHbwodoJDwUy096ggjhFLne0k[num].Dt5M4m3QoFvnQkn3VZzhTSHVU);
			DmPNupos8Sd6cXJNxXG0GuRXC.DHbwodoJDwUy096ggjhFLne0k.RemoveAt(num);
		}
	}

	// Token: 0x0600029A RID: 666 RVA: 0x00026928 File Offset: 0x00024B28
	private static void D0SRakLbPk5jLX4ByGtGlaRvV()
	{
		Color color = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Damage hitmarkers color");
		float a = color.a;
		int num = -1;
		for (int i = 0; i < DmPNupos8Sd6cXJNxXG0GuRXC.DTYTtzEyiXaPpKFONcUM7arVa.Count; i++)
		{
			DZ3Itlkf53ILNBmHkkOKBK3gF dz3Itlkf53ILNBmHkkOKBK3gF = DmPNupos8Sd6cXJNxXG0GuRXC.DTYTtzEyiXaPpKFONcUM7arVa[i];
			dz3Itlkf53ILNBmHkkOKBK3gF.Ds4ihRKvo5CFudeO7GkISZtB4 += Time.deltaTime / DfU4wrswBK5kLyiyV6mHZwOg8.damageHitmarksLifetime;
			bool flag = dz3Itlkf53ILNBmHkkOKBK3gF.Ds4ihRKvo5CFudeO7GkISZtB4 > 1f;
			bool flag2 = flag;
			if (flag2)
			{
				num = i;
			}
			else
			{
				dz3Itlkf53ILNBmHkkOKBK3gF.DZkiRsxdbVRtHcmX5h917TLJT += Vector3.up * Time.deltaTime * 5f;
				bool flag3 = dz3Itlkf53ILNBmHkkOKBK3gF.DZkiRsxdbVRtHcmX5h917TLJT.DGxZdvjodtrVw5BNkkaZ9SGFr();
				bool flag4 = flag3;
				if (flag4)
				{
					DhNbDL0xpxhG1wADC5uXvFshQ.DF7Zy7a96hJm30pZcSYFymNVa(dz3Itlkf53ILNBmHkkOKBK3gF.DZkiRsxdbVRtHcmX5h917TLJT, dz3Itlkf53ILNBmHkkOKBK3gF.DNOrRMVnqdnYgutIXoSUuuel4.ToString(), new Color(color.r, color.g, color.b, a * (1f - dz3Itlkf53ILNBmHkkOKBK3gF.Ds4ihRKvo5CFudeO7GkISZtB4)), (int)(12 + dz3Itlkf53ILNBmHkkOKBK3gF.DArZIamcBkgHRM2CvgStt50ng * 6));
				}
			}
			DmPNupos8Sd6cXJNxXG0GuRXC.DTYTtzEyiXaPpKFONcUM7arVa[i] = dz3Itlkf53ILNBmHkkOKBK3gF;
		}
		bool flag5 = num != -1;
		bool flag6 = flag5;
		if (flag6)
		{
			DmPNupos8Sd6cXJNxXG0GuRXC.DTYTtzEyiXaPpKFONcUM7arVa.RemoveAt(num);
		}
	}

	// Token: 0x0600029B RID: 667 RVA: 0x00026A78 File Offset: 0x00024C78
	private static void D9U6oOMfDn5AVEuBLW6ig8ymE()
	{
		bool flag = !DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracers || Provider.clients == null || MainCamera.instance == null;
		bool flag2 = !flag;
		if (flag2)
		{
			DDddnUl0gHJ8ZiQTaRLEUBUS2.DRU76pLEmpRdoUUcrMxfLqXNx.SetPass(0);
			GL.PushMatrix();
			GL.LoadProjectionMatrix(DhNbDL0xpxhG1wADC5uXvFshQ.D0dFeYUac5o0ycmUFaeSj1J46);
			GL.modelview = DhNbDL0xpxhG1wADC5uXvFshQ.Dvnc7NMv3T5T0nPfgcO28KXhC;
			GL.Begin(7);
			foreach (SteamPlayer steamPlayer in Provider.clients)
			{
				try
				{
					bool flag3 = steamPlayer == null || steamPlayer.player.life.isDead;
					bool flag4 = !flag3;
					if (flag4)
					{
						bool flag5 = steamPlayer.player.channel.IsLocalPlayer && !DfU4wrswBK5kLyiyV6mHZwOg8.seeOwnWalkingTracers;
						bool flag6 = !flag5;
						if (flag6)
						{
							bool flag7 = !DmPNupos8Sd6cXJNxXG0GuRXC.Dl0LsJ00Ixs838BMv0AGIkkTy.ContainsKey(steamPlayer.playerID.steamID.m_SteamID);
							bool flag8 = !flag7;
							if (flag8)
							{
								DwC8HjHCTqbh7Mqi1vZHJKcMF dwC8HjHCTqbh7Mqi1vZHJKcMF = DmPNupos8Sd6cXJNxXG0GuRXC.Dl0LsJ00Ixs838BMv0AGIkkTy[steamPlayer.playerID.steamID.m_SteamID];
								Color color = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Walking tracers color");
								float a = color.a;
								int num = -1;
								for (int i = 0; i < dwC8HjHCTqbh7Mqi1vZHJKcMF.DDeVrLyewJVSxUPcCUkqK5GhT.Count; i++)
								{
									DhVpCMii4tWhywCamQwr2E8m8 dhVpCMii4tWhywCamQwr2E8m = dwC8HjHCTqbh7Mqi1vZHJKcMF.DDeVrLyewJVSxUPcCUkqK5GhT[i];
									dhVpCMii4tWhywCamQwr2E8m.DVWEbrK16oHV1Fq1OeFuYaiJZ += Time.deltaTime / DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracersLifetime;
									bool flag9 = dhVpCMii4tWhywCamQwr2E8m.DVWEbrK16oHV1Fq1OeFuYaiJZ > 1f;
									bool flag10 = flag9;
									if (flag10)
									{
										num = i;
									}
									else
									{
										GL.Color(new Color(color.r, color.g, color.b, a * (1f - dhVpCMii4tWhywCamQwr2E8m.DVWEbrK16oHV1Fq1OeFuYaiJZ)));
										GL.Vertex(dhVpCMii4tWhywCamQwr2E8m.Df1gRuCGfobl9c9EqAZZemxRd);
										GL.Vertex(dhVpCMii4tWhywCamQwr2E8m.DVXQiqY4Oz2O5Ez4xm1PpufLh);
										GL.Vertex(dhVpCMii4tWhywCamQwr2E8m.Dxny2boP4hDgVGlcSKIBm7hTI);
										GL.Vertex(dhVpCMii4tWhywCamQwr2E8m.Dh5Q09e54R5ZlJG2CvK853qmM);
									}
									dwC8HjHCTqbh7Mqi1vZHJKcMF.DDeVrLyewJVSxUPcCUkqK5GhT[i] = dhVpCMii4tWhywCamQwr2E8m;
								}
								bool flag11 = num != -1;
								bool flag12 = flag11;
								if (flag12)
								{
									dwC8HjHCTqbh7Mqi1vZHJKcMF.DDeVrLyewJVSxUPcCUkqK5GhT.RemoveAt(num);
								}
							}
						}
					}
				}
				catch
				{
				}
			}
			GL.End();
			GL.PopMatrix();
		}
	}

	// Token: 0x0600029C RID: 668 RVA: 0x00026D24 File Offset: 0x00024F24
	public static void DR6u3Bkxz9jIBqdxQ2KyGGqCy()
	{
		bool flag = !DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracers;
		bool flag2 = !flag;
		if (flag2)
		{
			foreach (SteamPlayer steamPlayer in Provider.clients)
			{
				bool flag3 = steamPlayer == null || steamPlayer.player.life.isDead;
				bool flag4 = !flag3;
				if (flag4)
				{
					bool flag5 = steamPlayer.player.channel.IsLocalPlayer && !DfU4wrswBK5kLyiyV6mHZwOg8.seeOwnWalkingTracers;
					bool flag6 = !flag5;
					if (flag6)
					{
						bool flag7 = Vector3.Distance(steamPlayer.player.transform.position, MainCamera.instance.transform.position) > (float)DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracersDrawDistance;
						bool flag8 = flag7;
						if (flag8)
						{
							bool flag9 = DmPNupos8Sd6cXJNxXG0GuRXC.Dl0LsJ00Ixs838BMv0AGIkkTy.ContainsKey(steamPlayer.playerID.steamID.m_SteamID);
							bool flag10 = flag9;
							if (flag10)
							{
								DmPNupos8Sd6cXJNxXG0GuRXC.Dl0LsJ00Ixs838BMv0AGIkkTy.Remove(steamPlayer.playerID.steamID.m_SteamID);
							}
						}
						else
						{
							Vector3 position = steamPlayer.player.transform.position;
							bool flag11 = !DmPNupos8Sd6cXJNxXG0GuRXC.Dl0LsJ00Ixs838BMv0AGIkkTy.ContainsKey(steamPlayer.playerID.steamID.m_SteamID);
							bool flag12 = flag11;
							if (flag12)
							{
								DmPNupos8Sd6cXJNxXG0GuRXC.Dl0LsJ00Ixs838BMv0AGIkkTy.Add(steamPlayer.playerID.steamID.m_SteamID, new DwC8HjHCTqbh7Mqi1vZHJKcMF(position));
							}
							DwC8HjHCTqbh7Mqi1vZHJKcMF dwC8HjHCTqbh7Mqi1vZHJKcMF = DmPNupos8Sd6cXJNxXG0GuRXC.Dl0LsJ00Ixs838BMv0AGIkkTy[steamPlayer.playerID.steamID.m_SteamID];
							Vector3 vector = (dwC8HjHCTqbh7Mqi1vZHJKcMF.Dlvds3n621jabwGhoo2yimk9X - position).normalized;
							bool flag13 = vector == Vector3.zero;
							bool flag14 = flag13;
							if (flag14)
							{
								vector = dwC8HjHCTqbh7Mqi1vZHJKcMF.DzTnZRokkxJJZHsgICycdnsB3;
							}
							else
							{
								dwC8HjHCTqbh7Mqi1vZHJKcMF.DzTnZRokkxJJZHsgICycdnsB3 = vector;
							}
							Vector3 vector2 = Vector3.Cross(vector, Vector3.up);
							Vector3 vector3 = -vector2;
							dwC8HjHCTqbh7Mqi1vZHJKcMF.DDeVrLyewJVSxUPcCUkqK5GhT.Add(new DhVpCMii4tWhywCamQwr2E8m8(position + vector2 * DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracersWidth, position + vector3 * DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracersWidth, new Vector3(dwC8HjHCTqbh7Mqi1vZHJKcMF.Dns4WYeV4wJMbAAb3b0Ok3VFn.x, dwC8HjHCTqbh7Mqi1vZHJKcMF.Dns4WYeV4wJMbAAb3b0Ok3VFn.y, dwC8HjHCTqbh7Mqi1vZHJKcMF.Dns4WYeV4wJMbAAb3b0Ok3VFn.z), new Vector3(dwC8HjHCTqbh7Mqi1vZHJKcMF.DuYLN7C0YJ2aF0DPPzCbX0AgU.x, dwC8HjHCTqbh7Mqi1vZHJKcMF.DuYLN7C0YJ2aF0DPPzCbX0AgU.y, dwC8HjHCTqbh7Mqi1vZHJKcMF.DuYLN7C0YJ2aF0DPPzCbX0AgU.z)));
							dwC8HjHCTqbh7Mqi1vZHJKcMF.Dns4WYeV4wJMbAAb3b0Ok3VFn = position + vector2 * DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracersWidth;
							dwC8HjHCTqbh7Mqi1vZHJKcMF.DuYLN7C0YJ2aF0DPPzCbX0AgU = position + vector3 * DfU4wrswBK5kLyiyV6mHZwOg8.walkingTracersWidth;
							dwC8HjHCTqbh7Mqi1vZHJKcMF.Dlvds3n621jabwGhoo2yimk9X = position;
							DmPNupos8Sd6cXJNxXG0GuRXC.Dl0LsJ00Ixs838BMv0AGIkkTy[steamPlayer.playerID.steamID.m_SteamID] = dwC8HjHCTqbh7Mqi1vZHJKcMF;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600029D RID: 669 RVA: 0x00027030 File Offset: 0x00025230
	public static void DqXrYOwxIKecZxRsH8jHRqPJ6()
	{
		DmPNupos8Sd6cXJNxXG0GuRXC.D9U6oOMfDn5AVEuBLW6ig8ymE();
		DmPNupos8Sd6cXJNxXG0GuRXC.DpS7tZ9l6DWCH8pQK9xWIkKk6();
		DmPNupos8Sd6cXJNxXG0GuRXC.D0SRakLbPk5jLX4ByGtGlaRvV();
		DmPNupos8Sd6cXJNxXG0GuRXC.DDE6kFw80d2om41ZBj5K3e28j();
	}

	// Token: 0x0400031A RID: 794
	private static List<DvokU5hcv2P63Imn0f6sStWTw> Dol7gU5azkPPN1UIRnFPi3md7 = new List<DvokU5hcv2P63Imn0f6sStWTw>();

	// Token: 0x0400031B RID: 795
	private static List<DZ3Itlkf53ILNBmHkkOKBK3gF> DTYTtzEyiXaPpKFONcUM7arVa = new List<DZ3Itlkf53ILNBmHkkOKBK3gF>();

	// Token: 0x0400031C RID: 796
	private static List<DCJW8k4jS5tnCUQXemffRym03> DHbwodoJDwUy096ggjhFLne0k = new List<DCJW8k4jS5tnCUQXemffRym03>();

	// Token: 0x0400031D RID: 797
	private static Dictionary<ulong, DwC8HjHCTqbh7Mqi1vZHJKcMF> Dl0LsJ00Ixs838BMv0AGIkkTy = new Dictionary<ulong, DwC8HjHCTqbh7Mqi1vZHJKcMF>();

	// Token: 0x0400031E RID: 798
	private static uint DYDyiwRoVFTmp08vDopCrKYwD = 1U;
}
