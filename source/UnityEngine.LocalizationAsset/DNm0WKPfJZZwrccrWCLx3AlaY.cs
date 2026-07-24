using System;
using System.Collections.Generic;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200008F RID: 143
public static class DNm0WKPfJZZwrccrWCLx3AlaY
{
	// Token: 0x060002AE RID: 686 RVA: 0x00027A78 File Offset: 0x00025C78
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DZN85t5yMWpWs9ZYCZM78vYk6()
	{
		List<DSvAEyoSitLrXzsZSSRwWfJ5T> list = new List<DSvAEyoSitLrXzsZSSRwWfJ5T>();
		foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
		{
			bool flag = type.BaseType == typeof(DSvAEyoSitLrXzsZSSRwWfJ5T);
			bool flag2 = flag;
			if (flag2)
			{
				list.Add((DSvAEyoSitLrXzsZSSRwWfJ5T)Activator.CreateInstance(type));
			}
		}
		DNm0WKPfJZZwrccrWCLx3AlaY.DJnkBPDuULCwKtfSzrqOluiCY = list.ToArray();
	}

	// Token: 0x060002AF RID: 687 RVA: 0x00027AEC File Offset: 0x00025CEC
	public static void D44F9llIdAajPxuHDjEqDMSHa()
	{
		bool flag = !(Player.player == null);
		if (flag)
		{
			bool flag2 = DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelaying && !DCS4Jf0LRzsehKFc5QOLL06qw.unholdDelayByMouse && Input.GetKey(DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelayKeybind);
			if (flag2)
			{
				Ddagemt6Wc3UeyV4EYXNrXcFf.D6CSCOdxWhfs06Bz8veydqeB0.Clear();
			}
			DI8jSvGQa3grzg5wlLxwkRj27.DHGIUKVUc0616fllctrAq5z3g();
			bool flag3 = DCS4Jf0LRzsehKFc5QOLL06qw.enableSilentAim && DCS4Jf0LRzsehKFc5QOLL06qw.silentAimType == DokdtlMHqRTX0KbeCtveFDTNT.Sphere && DCS4Jf0LRzsehKFc5QOLL06qw.debugSpherePoints && Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC != null;
			if (flag3)
			{
				DNm0WKPfJZZwrccrWCLx3AlaY.DrDIES0rvBrC5RLZrwzI70qh4();
			}
		}
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00027B74 File Offset: 0x00025D74
	public static void DJlHMgUTbJZmwvQkOhYYqIBWX()
	{
		GUI.skin = DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj;
		DNm0WKPfJZZwrccrWCLx3AlaY.D5g6vldq0uOxB4EhX60r7HhMb();
		bool enableUserLogger = DfU4wrswBK5kLyiyV6mHZwOg8.enableUserLogger;
		bool flag = enableUserLogger;
		if (flag)
		{
			DNm0WKPfJZZwrccrWCLx3AlaY.D1nMiTpOHBi1ZtMKHHj1zAo4B();
		}
		bool flag2 = Event.current.type != EventType.Repaint;
		bool flag3 = !flag2;
		if (flag3)
		{
			try
			{
				List<DRxteGz0evnNDVy6poswGHA5b> list = null;
				bool flag4 = DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelaying && DCS4Jf0LRzsehKFc5QOLL06qw.showBulletDelayingTimer && Provider.modeConfigData.Gameplay.Ballistics && Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC != null && Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DKr6XbLZDMiJmmxABXHlfTTLz == Dr5qliNNQh3jZolh9fn7SFNyi.Player && Ddagemt6Wc3UeyV4EYXNrXcFf.D6CSCOdxWhfs06Bz8veydqeB0.TryGetValue(((Player)Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC).channel.owner.playerID.steamID.m_SteamID, out list) && list != null && list.Count > 0;
				bool flag5 = flag4;
				if (flag5)
				{
					DNm0WKPfJZZwrccrWCLx3AlaY.D5TM2Y3G9GiAsJSusHBvfqKiH(list);
				}
			}
			catch
			{
			}
		}
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x00027C74 File Offset: 0x00025E74
	public static void D5TM2Y3G9GiAsJSusHBvfqKiH(List<DRxteGz0evnNDVy6poswGHA5b> cbis)
	{
		Rect rect = new Rect((float)(Screen.width / 2 - 15), (float)(Screen.height / 2 + 30), 30f, 10f);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect, new Color32(20, 20, 20, byte.MaxValue), false, ScaleMode.StretchToFill);
		rect.x += 2f;
		rect.y += 2f;
		rect.width -= 4f;
		rect.height -= 4f;
		try
		{
			GUIStyle guistyle = new GUIStyle();
			guistyle.normal.textColor = Color.white;
			guistyle.fontSize = 11;
			guistyle.alignment = TextAnchor.MiddleCenter;
			GUI.Label(new Rect(rect.x - 50f, rect.y + 15f, rect.width + 100f, 20f), "Delayed: " + cbis.Count.ToString() + " / " + DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelayAmount.ToString(), guistyle);
			bool flag = DCS4Jf0LRzsehKFc5QOLL06qw.unholdDelayByMouse && DCS4Jf0LRzsehKFc5QOLL06qw.momentalyUnhold;
			if (flag)
			{
				GUI.Label(new Rect(rect.x - 50f, rect.y + 30f, rect.width + 100f, 20f), "Unhold: Mouse", guistyle);
			}
			else
			{
				GUI.Label(new Rect(rect.x - 50f, rect.y + 30f, rect.width + 100f, 20f), "Release Key: " + DCS4Jf0LRzsehKFc5QOLL06qw.bulletDelayKeybind.ToString(), guistyle);
			}
			int num = 0;
			foreach (DRxteGz0evnNDVy6poswGHA5b drxteGz0evnNDVy6poswGHA5b in cbis)
			{
				num = Mathf.Max((int)drxteGz0evnNDVy6poswGHA5b.DTW6zDZRuBKOUBbHU8Vmgx0aD, num);
			}
			ItemGunAsset itemGunAsset = Player.player.equipment.asset as ItemGunAsset;
			bool flag2 = itemGunAsset != null && itemGunAsset.ballisticSteps > 0;
			if (flag2)
			{
				rect.width *= (float)num / (float)itemGunAsset.ballisticSteps;
			}
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect, new Color32(20, byte.MaxValue, 20, byte.MaxValue), false, ScaleMode.StretchToFill);
		}
		catch
		{
		}
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x00027F24 File Offset: 0x00026124
	public static void D1nMiTpOHBi1ZtMKHHj1zAo4B()
	{
		Rect rect = new Rect(DNm0WKPfJZZwrccrWCLx3AlaY.DaJe53J7NyMGaLCgE4QZ7wbOI.x, DNm0WKPfJZZwrccrWCLx3AlaY.DaJe53J7NyMGaLCgE4QZ7wbOI.y, 64f, 64f);
		DgFTkE5PhwyrkOBGhzb7SByPr.DfdU0FmLG6qC1LMht1Y27juNW(ref rect);
		DNm0WKPfJZZwrccrWCLx3AlaY.DaJe53J7NyMGaLCgE4QZ7wbOI = rect;
		GUILayout.BeginArea(new Rect(DNm0WKPfJZZwrccrWCLx3AlaY.DaJe53J7NyMGaLCgE4QZ7wbOI.x, DNm0WKPfJZZwrccrWCLx3AlaY.DaJe53J7NyMGaLCgE4QZ7wbOI.y, 600f, 400f));
		bool dtKlbZSZSYlN9ldxLbDo4VuvI = DL3tNdrQzY7o8FV1oIOKODOLQ.DtKlbZSZSYlN9ldxLbDo4VuvI;
		bool flag = dtKlbZSZSYlN9ldxLbDo4VuvI;
		if (flag)
		{
			DNm0WKPfJZZwrccrWCLx3AlaY.D0ZEr5nSdPXVISi4TPAj9O1li("In menu", 0f);
		}
		foreach (ValueTuple<string, float> valueTuple in DovA0560C5xwc06yYBWmht6vA.DbOpq1Dx26hu5wu29FfQKwlzi)
		{
			string item = valueTuple.Item1;
			float item2 = valueTuple.Item2;
			DNm0WKPfJZZwrccrWCLx3AlaY.D0ZEr5nSdPXVISi4TPAj9O1li(item, item2);
		}
		GUILayout.EndArea();
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00028010 File Offset: 0x00026210
	private static void D0ZEr5nSdPXVISi4TPAj9O1li(string s, float f)
	{
		bool flag = DfU4wrswBK5kLyiyV6mHZwOg8.loggerTextCase == DVeWYqH4HEAYXL5Vu3HrmvSnF.UpperCase;
		bool flag2 = flag;
		if (flag2)
		{
			s = s.ToUpper();
		}
		else
		{
			bool flag3 = DfU4wrswBK5kLyiyV6mHZwOg8.loggerTextCase == DVeWYqH4HEAYXL5Vu3HrmvSnF.LowerCase;
			bool flag4 = flag3;
			if (flag4)
			{
				s = s.ToLower();
			}
		}
		float num = 1f - Mathf.Clamp01(f / 5f - 0.75f) * 4f;
		Rect rect = GUILayoutUtility.GetRect(600f, 20f);
		DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd.normal.textColor = new Color(0f, 0f, 0f, num);
		switch (DfU4wrswBK5kLyiyV6mHZwOg8.loggerTextOutline)
		{
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.RightDownSided:
			GUI.Label(new Rect(rect.x + 1f, rect.y, rect.width, rect.height), s, DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd);
			GUI.Label(new Rect(rect.x, rect.y + 1f, rect.width, rect.height), s, DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd);
			break;
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.RightTopSided:
			GUI.Label(new Rect(rect.x + 1f, rect.y, rect.width, rect.height), s, DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd);
			GUI.Label(new Rect(rect.x, rect.y - 1f, rect.width, rect.height), s, DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd);
			break;
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.LeftTopSided:
			GUI.Label(new Rect(rect.x - 1f, rect.y, rect.width, rect.height), s, DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd);
			GUI.Label(new Rect(rect.x, rect.y - 1f, rect.width, rect.height), s, DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd);
			break;
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.LeftDownSided:
			GUI.Label(new Rect(rect.x - 1f, rect.y, rect.width, rect.height), s, DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd);
			GUI.Label(new Rect(rect.x, rect.y + 1f, rect.width, rect.height), s, DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd);
			break;
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.FourSided:
			GUI.Label(new Rect(rect.x + 1f, rect.y, rect.width, rect.height), s, DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd);
			GUI.Label(new Rect(rect.x, rect.y - 1f, rect.width, rect.height), s, DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd);
			GUI.Label(new Rect(rect.x - 1f, rect.y, rect.width, rect.height), s, DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd);
			GUI.Label(new Rect(rect.x, rect.y + 1f, rect.width, rect.height), s, DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd);
			break;
		}
		Color color = DNbYBVifu73t6Hq5vgTtgKwS7.DaXgkzF0n71hmkyAbipgooHRa("Logger color").DkJGdJpvFP4j4uWN4CyFixyQ3;
		DHTB5RKsHUihFrfj9ewuLh1f9.DiEJSsZXl9p0Vlp6M1APxSQZF.normal.textColor = new Color(color.r, color.g, color.b, num);
		GUI.Label(rect, s, DHTB5RKsHUihFrfj9ewuLh1f9.DiEJSsZXl9p0Vlp6M1APxSQZF);
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x000283A0 File Offset: 0x000265A0
	public static void D5TPvlKDpYpr7m5MY9C7pXGtO()
	{
		try
		{
			bool flag = DCS4Jf0LRzsehKFc5QOLL06qw.enableAim && DCS4Jf0LRzsehKFc5QOLL06qw.drawTarget && Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC != null && MainCamera.instance != null;
			bool flag2 = flag;
			if (flag2)
			{
				DNm0WKPfJZZwrccrWCLx3AlaY.DQUhKxDVewCNFkMEz2wnKsrRF();
			}
			bool flag3 = DCS4Jf0LRzsehKFc5QOLL06qw.enableAim && DCS4Jf0LRzsehKFc5QOLL06qw.drawTarget && DCS4Jf0LRzsehKFc5QOLL06qw.previewHitPoint && Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.D6nJYkVx4qchY4kCZfzkELhb9 != Vector3.zero && (Player.player.look.aim.transform.position - Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.D6nJYkVx4qchY4kCZfzkELhb9).magnitude > 2f;
			bool flag4 = flag3;
			if (flag4)
			{
				DNm0WKPfJZZwrccrWCLx3AlaY.Dxsu7SirzTGQLS5zyWX3bWziw(Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.D6nJYkVx4qchY4kCZfzkELhb9);
				bool drawLineFromHitPoint = DCS4Jf0LRzsehKFc5QOLL06qw.drawLineFromHitPoint;
				bool flag5 = drawLineFromHitPoint;
				if (flag5)
				{
					DNm0WKPfJZZwrccrWCLx3AlaY.DsjjKmMJDNAXjGWkiAXpEPZAs(Ddagemt6Wc3UeyV4EYXNrXcFf.DaDfS7pW7z2hwpjq5z9bGs138(Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DKr6XbLZDMiJmmxABXHlfTTLz, Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC).position, Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.D6nJYkVx4qchY4kCZfzkELhb9);
				}
				bool drawLineFromPlayerHead = DCS4Jf0LRzsehKFc5QOLL06qw.drawLineFromPlayerHead;
				bool flag6 = drawLineFromPlayerHead;
				if (flag6)
				{
					Transform transform = Ddagemt6Wc3UeyV4EYXNrXcFf.DL0250m6MAXHl6JdAreUGuchB(Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC);
					bool flag7 = transform != null;
					if (flag7)
					{
						DNm0WKPfJZZwrccrWCLx3AlaY.DsjjKmMJDNAXjGWkiAXpEPZAs(Player.player.look.aim.position, transform.position);
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x00028520 File Offset: 0x00026720
	public static void DrDIES0rvBrC5RLZrwzI70qh4()
	{
		Transform transform = Ddagemt6Wc3UeyV4EYXNrXcFf.DaDfS7pW7z2hwpjq5z9bGs138(Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DKr6XbLZDMiJmmxABXHlfTTLz, Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC);
		Vector3 vector2;
		foreach (Vector3 vector in DoLw5vYd2Gq0BYuUfcIXuj4Vo.DfCAnLXlM0BjQRdGSl6900LuF)
		{
			bool flag = !(transform.position + vector).DGxZdvjodtrVw5BNkkaZ9SGFr();
			bool flag2 = !flag;
			if (flag2)
			{
				vector2 = (transform.position + vector).DEfdLut9iGJvTAJNGrXHRFglR();
				DrysTRTjdLdFqu5GJBDif6AoV.DT33ynUfwLxankDwm7mXB7OK4(new Rect(vector2.x - 2f, vector2.y - 2f, 4f, 4f), DHTB5RKsHUihFrfj9ewuLh1f9.DazBzygjoFMvkTR5WZh79oJmJ, Physics.Linecast(Player.player.look.aim.position, transform.position + vector, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore) ? Color.red : Color.yellow, false, ScaleMode.StretchToFill);
			}
		}
		vector2 = Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.D6nJYkVx4qchY4kCZfzkELhb9.DEfdLut9iGJvTAJNGrXHRFglR();
		DrysTRTjdLdFqu5GJBDif6AoV.DT33ynUfwLxankDwm7mXB7OK4(new Rect(vector2.x - 2f, vector2.y - 2f, 4f, 4f), DHTB5RKsHUihFrfj9ewuLh1f9.DazBzygjoFMvkTR5WZh79oJmJ, Color.green, false, ScaleMode.StretchToFill);
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00028673 File Offset: 0x00026873
	private static void DsjjKmMJDNAXjGWkiAXpEPZAs(Vector3 start, Vector3 end)
	{
		DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(start.DEfdLut9iGJvTAJNGrXHRFglR(), end.DEfdLut9iGJvTAJNGrXHRFglR(), DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Sphere preview line color"), 1f);
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00028698 File Offset: 0x00026898
	private static void Dxsu7SirzTGQLS5zyWX3bWziw(Vector3 point)
	{
		DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[0] = new Vector3(point.x + 0.15f, point.y + 0.15f, point.z + 0.15f).DEfdLut9iGJvTAJNGrXHRFglR();
		DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[1] = new Vector3(point.x - 0.15f, point.y - 0.15f, point.z + 0.15f).DEfdLut9iGJvTAJNGrXHRFglR();
		DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[2] = new Vector3(point.x + 0.15f, point.y + 0.15f, point.z - 0.15f).DEfdLut9iGJvTAJNGrXHRFglR();
		DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[3] = new Vector3(point.x - 0.15f, point.y - 0.15f, point.z - 0.15f).DEfdLut9iGJvTAJNGrXHRFglR();
		DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[4] = new Vector3(point.x + 0.15f, point.y - 0.15f, point.z + 0.15f).DEfdLut9iGJvTAJNGrXHRFglR();
		DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[5] = new Vector3(point.x - 0.15f, point.y + 0.15f, point.z + 0.15f).DEfdLut9iGJvTAJNGrXHRFglR();
		DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[6] = new Vector3(point.x + 0.15f, point.y - 0.15f, point.z - 0.15f).DEfdLut9iGJvTAJNGrXHRFglR();
		DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[7] = new Vector3(point.x - 0.15f, point.y + 0.15f, point.z - 0.15f).DEfdLut9iGJvTAJNGrXHRFglR();
		Color32 color = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Sphere preview point color");
		DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[0], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[4], color, 1f);
		DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[1], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[5], color, 1f);
		DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[0], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[5], color, 1f);
		DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[4], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[1], color, 1f);
		DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[2], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[6], color, 1f);
		DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[3], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[7], color, 1f);
		DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[2], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[7], color, 1f);
		DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[6], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[3], color, 1f);
		DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[0], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[2], color, 1f);
		DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[1], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[3], color, 1f);
		DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[4], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[6], color, 1f);
		DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[5], DhNbDL0xpxhG1wADC5uXvFshQ.DKiMO3NaucExIbgyGlg41oDzH[7], color, 1f);
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00028AF4 File Offset: 0x00026CF4
	private static void DQUhKxDVewCNFkMEz2wnKsrRF()
	{
		Transform transform = Ddagemt6Wc3UeyV4EYXNrXcFf.DL0250m6MAXHl6JdAreUGuchB(Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC.DnuBpXW8r7IgW3DCiPdbWlBGC);
		bool flag = transform != null;
		bool flag2 = flag;
		if (flag2)
		{
			DhNbDL0xpxhG1wADC5uXvFshQ.D286UV0i4TGpJWWPG02XMBzZH(new Vector3(DCS4Jf0LRzsehKFc5QOLL06qw.targetLineStartX * (float)Screen.width, DCS4Jf0LRzsehKFc5QOLL06qw.targetLineStartY * (float)Screen.height, 0f), transform.position.DEfdLut9iGJvTAJNGrXHRFglR(), DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Aimhacks target line"), 1f);
		}
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x00028B68 File Offset: 0x00026D68
	private static void D5g6vldq0uOxB4EhX60r7HhMb()
	{
		for (int i = 0; i < DNm0WKPfJZZwrccrWCLx3AlaY.DJnkBPDuULCwKtfSzrqOluiCY.Length; i++)
		{
			bool aviablity = DNm0WKPfJZZwrccrWCLx3AlaY.DJnkBPDuULCwKtfSzrqOluiCY[i].GetAviablity();
			bool flag = aviablity;
			if (flag)
			{
				bool flag2 = DNm0WKPfJZZwrccrWCLx3AlaY.DJnkBPDuULCwKtfSzrqOluiCY[i].IsShowOnMenu();
				bool flag3 = flag2;
				if (flag3)
				{
					GUI.color = new Color(1f, 1f, 1f, DL3tNdrQzY7o8FV1oIOKODOLQ.DsVlNI7hwmvLykhj6f2v4gFgu());
				}
				else
				{
					GUI.color = new Color(1f, 1f, 1f, DL3tNdrQzY7o8FV1oIOKODOLQ.DdgGXFGERdBMTnaSP0ZaRaV5y());
				}
				bool flag4 = GUI.color.a > 0f;
				bool flag5 = flag4;
				if (flag5)
				{
					DNm0WKPfJZZwrccrWCLx3AlaY.DJnkBPDuULCwKtfSzrqOluiCY[i].DTmNRoF1ji0C0gfIHdFoVPeKs();
					bool flag6 = !DNm0WKPfJZZwrccrWCLx3AlaY.DJnkBPDuULCwKtfSzrqOluiCY[i].UseStaticRect();
					bool flag7 = flag6;
					if (flag7)
					{
						Rect rect = new Rect(DNm0WKPfJZZwrccrWCLx3AlaY.DJnkBPDuULCwKtfSzrqOluiCY[i].DkPiBrZfDuyssgVsFrnhxjO4v.x, DNm0WKPfJZZwrccrWCLx3AlaY.DJnkBPDuULCwKtfSzrqOluiCY[i].DkPiBrZfDuyssgVsFrnhxjO4v.y, DNm0WKPfJZZwrccrWCLx3AlaY.DJnkBPDuULCwKtfSzrqOluiCY[i].GetSize().x, 16f);
						DgFTkE5PhwyrkOBGhzb7SByPr.DfdU0FmLG6qC1LMht1Y27juNW(ref rect);
						DNm0WKPfJZZwrccrWCLx3AlaY.DJnkBPDuULCwKtfSzrqOluiCY[i].DkPiBrZfDuyssgVsFrnhxjO4v = new Vector2(rect.x, rect.y);
					}
				}
			}
		}
	}

	// Token: 0x0400032C RID: 812
	public static DSvAEyoSitLrXzsZSSRwWfJ5T[] DJnkBPDuULCwKtfSzrqOluiCY;

	// Token: 0x0400032D RID: 813
	public static Rect DaJe53J7NyMGaLCgE4QZ7wbOI = new Rect(100f, 100f, 600f, 400f);
}
