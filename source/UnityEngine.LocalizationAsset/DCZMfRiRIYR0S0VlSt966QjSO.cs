using System;
using System.Globalization;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000043 RID: 67
public class DCZMfRiRIYR0S0VlSt966QjSO : DOEkZ1zoBEuvfUmOs9QSpfX0X
{
	// Token: 0x0600011B RID: 283 RVA: 0x0000C108 File Offset: 0x0000A308
	public override string GetName()
	{
		return "Settings";
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0000C120 File Offset: 0x0000A320
	public override DYIPJORHeVCfbpocFHvJty4OE GetTabCounts()
	{
		return DYIPJORHeVCfbpocFHvJty4OE.Three;
	}

	// Token: 0x0600011D RID: 285 RVA: 0x0000C134 File Offset: 0x0000A334
	public override void DoTab(DYIPJORHeVCfbpocFHvJty4OE tc)
	{
		bool flag = tc == DYIPJORHeVCfbpocFHvJty4OE.One;
		if (flag)
		{
			base.DGLNJE6Ld056OViYFjOM7IeMS("Customizing colors");
			GUILayout.Label("Search colors:", Array.Empty<GUILayoutOption>());
			this.DFjKvyNcuuXAMwZchK5R4vX0R = GUILayout.TextField(this.DFjKvyNcuuXAMwZchK5R4vX0R, Array.Empty<GUILayoutOption>());
			this.De5wxdLO1l3rDDj0TP95x5DCz = GUILayout.BeginScrollView(this.De5wxdLO1l3rDDj0TP95x5DCz, Array.Empty<GUILayoutOption>());
			for (int i = 0; i < Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G.Length; i++)
			{
				for (int j = 0; j < Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[i].DytdRk0oVzSXoI44WWs8r2oSt.Length; j++)
				{
					bool flag2 = string.IsNullOrEmpty(this.DFjKvyNcuuXAMwZchK5R4vX0R) || Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[i].DytdRk0oVzSXoI44WWs8r2oSt[j].DyuiZVHlez37wZyzRLw1Q85BY.IndexOf(this.DFjKvyNcuuXAMwZchK5R4vX0R, StringComparison.OrdinalIgnoreCase) >= 0;
					if (flag2)
					{
						bool flag3 = DrysTRTjdLdFqu5GJBDif6AoV.DNV6T8ihER1VcDiXXwY3S4BTY(Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[i].DytdRk0oVzSXoI44WWs8r2oSt[j].DyuiZVHlez37wZyzRLw1Q85BY, Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[i].DytdRk0oVzSXoI44WWs8r2oSt[j].DkJGdJpvFP4j4uWN4CyFixyQ3, -1, true);
						if (flag3)
						{
							this.D3K4rzUWBCl5cYJpxNv9aqlcg = true;
							this.DUEWCZx7x53tmAYpkPWtVyvVT = i;
							this.Dq0bJtLxiTlLMaOs1k9uP0W42 = j;
						}
					}
				}
			}
			for (int k = 0; k < DNbYBVifu73t6Hq5vgTtgKwS7.DQLIruDkU2ZNtLDoc98U3NKNd.Length; k++)
			{
				bool flag4 = string.IsNullOrEmpty(this.DFjKvyNcuuXAMwZchK5R4vX0R) || DNbYBVifu73t6Hq5vgTtgKwS7.DQLIruDkU2ZNtLDoc98U3NKNd[k].DyuiZVHlez37wZyzRLw1Q85BY.IndexOf(this.DFjKvyNcuuXAMwZchK5R4vX0R, StringComparison.OrdinalIgnoreCase) >= 0;
				if (flag4)
				{
					bool flag5 = DrysTRTjdLdFqu5GJBDif6AoV.DNV6T8ihER1VcDiXXwY3S4BTY(DNbYBVifu73t6Hq5vgTtgKwS7.DQLIruDkU2ZNtLDoc98U3NKNd[k].DyuiZVHlez37wZyzRLw1Q85BY, DNbYBVifu73t6Hq5vgTtgKwS7.DQLIruDkU2ZNtLDoc98U3NKNd[k].settedColor, -1, true);
					if (flag5)
					{
						this.D3K4rzUWBCl5cYJpxNv9aqlcg = false;
						this.DUEWCZx7x53tmAYpkPWtVyvVT = k;
					}
				}
			}
			GUILayout.EndScrollView();
		}
		else
		{
			bool flag6 = tc != DYIPJORHeVCfbpocFHvJty4OE.Two;
			if (flag6)
			{
				Dxg2tDZdImJqrX71UMTW47xIk.D6EN6hoxrJeDXTonZlJ4PnKig = GUILayout.TextField(Dxg2tDZdImJqrX71UMTW47xIk.D6EN6hoxrJeDXTonZlJ4PnKig, Array.Empty<GUILayoutOption>());
				bool flag7 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv("Save config", -1, true, "Save configuration");
				if (flag7)
				{
					Dxg2tDZdImJqrX71UMTW47xIk.DFAyL8wNHbluCMKtorDynB4MC(Dxg2tDZdImJqrX71UMTW47xIk.D6EN6hoxrJeDXTonZlJ4PnKig);
					Dxg2tDZdImJqrX71UMTW47xIk.DxeJlNfhwsirSRyR3yNds5r6J();
				}
				GUILayout.Space(15f);
				this.DwQHiTzEnXq2YbVolVgCMBukE = GUILayout.BeginScrollView(this.DwQHiTzEnXq2YbVolVgCMBukE, Array.Empty<GUILayoutOption>());
				foreach (string text in Dxg2tDZdImJqrX71UMTW47xIk.DwPb3hnqDGXSpUs1xbcavAY4i)
				{
					bool flag8 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv(text, -1, true, "Load configuration");
					if (flag8)
					{
						Dxg2tDZdImJqrX71UMTW47xIk.DcXCWIlY0AW5fJv1MNaTYg6ok(text);
					}
				}
				GUILayout.EndScrollView();
				GUILayout.Space(5f);
				try
				{
					bool flag9 = Characters.active != null;
					if (flag9)
					{
						GUILayout.Label(("Set nickname: " + Characters.active.nick == Characters.active.name) ? Characters.active.nick : (Characters.active.nick + ":" + Characters.active.name), Array.Empty<GUILayoutOption>());
					}
				}
				catch
				{
				}
				bool flag10 = DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv(Provider.isConnected ? "Fast reconnect with nickname change" : "Change nickname", -1, true, null);
				if (flag10)
				{
					string[] array = new string[]
					{
						"Shadow", "Nova", "Blaze", "Ghost", "Viper", "Sniper", "Rogue", "Venom", "Frost", "Zero",
						"Reaper", "Drift", "Phantom", "Raze", "Knight", "Clutch", "Zynx", "Glitch", "Nexus", "Crypt"
					};
					string[] array2 = new string[]
					{
						"", "", "", "", "YT", "HD", "LOL", "420", "xX", "Xx",
						"_x", "_tv", "_pro", "Z", "1", "69", "_exe", "_bot"
					};
					string text2 = array[global::UnityEngine.Random.Range(0, array.Length)];
					string text3 = array2[global::UnityEngine.Random.Range(0, array2.Length)];
					string text4 = ((global::UnityEngine.Random.value < 0.3f) ? global::UnityEngine.Random.Range(1, 999).ToString() : "");
					string text5 = text2 + text3 + text4;
					text5 = text5.Substring(0, Mathf.Clamp(text5.Length, 0, 16));
					Characters.rename(text5);
					Characters.renick(text5);
					DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("Set nickname: " + text5);
					DovA0560C5xwc06yYBWmht6vA.D2XDJbj97cXeWm21NhElh6XXL(string.Format("[+] New username {0}", text5));
					bool isConnected = Provider.isConnected;
					if (isConnected)
					{
						Provider.disconnect();
					}
				}
			}
			else
			{
				base.DGLNJE6Ld056OViYFjOM7IeMS("Change colors");
				bool d3K4rzUWBCl5cYJpxNv9aqlcg = this.D3K4rzUWBCl5cYJpxNv9aqlcg;
				if (d3K4rzUWBCl5cYJpxNv9aqlcg)
				{
					DCZMfRiRIYR0S0VlSt966QjSO.Dl7iQC33drS0UULOQ67zYevCa(ref Dvtdh0bRL5i9duanOvOedNrxe.DIcxkMzzpgtfD2pa61dQQ9M1G[this.DUEWCZx7x53tmAYpkPWtVyvVT].DytdRk0oVzSXoI44WWs8r2oSt[this.Dq0bJtLxiTlLMaOs1k9uP0W42]);
				}
				else
				{
					DCZMfRiRIYR0S0VlSt966QjSO.Dl7iQC33drS0UULOQ67zYevCa(ref DNbYBVifu73t6Hq5vgTtgKwS7.DQLIruDkU2ZNtLDoc98U3NKNd[this.DUEWCZx7x53tmAYpkPWtVyvVT]);
				}
			}
		}
	}

	// Token: 0x0600011E RID: 286 RVA: 0x0000C6E4 File Offset: 0x0000A8E4
	public static void Dl7iQC33drS0UULOQ67zYevCa(ref DSuKLIF35AtXmFdSPtbkEXBdM cheatColor)
	{
		Color32 color = cheatColor.settedColor;
		bool flag = !cheatColor.isGradient;
		if (flag)
		{
			Rect rect = GUILayoutUtility.GetRect(-1f, 30f);
			Rect rect2 = new Rect(rect.x + 1f, rect.y + 1f, rect.width - 2f, rect.height - 2f);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect, new Color32(50, 50, 55, byte.MaxValue), true, ScaleMode.StretchToFill);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect2, color, true, ScaleMode.StretchToFill);
			Rect rect3 = new Rect(rect.x + rect.width - 90f, rect.y + (rect.height - 14f) / 2f, 60f, 14f);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect3, new Color32(20, 20, 22, 200), true, ScaleMode.StretchToFill);
			GUIStyle guistyle = new GUIStyle(GUI.skin.label);
			guistyle.fontSize = 9;
			guistyle.alignment = TextAnchor.MiddleCenter;
			guistyle.normal.textColor = new Color32(200, 200, 200, byte.MaxValue);
			string text = string.Format("#{0:X2}{1:X2}{2:X2}{3:X2}", new object[] { color.r, color.g, color.b, color.a });
			GUI.Label(rect3, text, guistyle);
			GUIStyle guistyle2 = new GUIStyle(GUI.skin.label);
			guistyle2.fontSize = 8;
			guistyle2.alignment = TextAnchor.MiddleCenter;
			guistyle2.normal.textColor = new Color32(180, 180, 180, byte.MaxValue);
			Rect rect4 = new Rect(rect.x + rect.width - 25f, rect.y + (rect.height - 14f) / 2f, 20f, 14f);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect4, new Color32(30, 30, 35, byte.MaxValue), true, ScaleMode.StretchToFill);
			GUI.Label(rect4, "C", guistyle2);
			bool flag2 = Event.current.type == EventType.MouseDown && Event.current.button == 0 && rect4.Contains(Event.current.mousePosition);
			if (flag2)
			{
				GUIUtility.systemCopyBuffer = text;
				Event.current.Use();
			}
			Rect rect5 = new Rect(rect.x + rect.width - 48f, rect.y + (rect.height - 14f) / 2f, 20f, 14f);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect5, new Color32(30, 30, 35, byte.MaxValue), true, ScaleMode.StretchToFill);
			GUI.Label(rect5, "P", guistyle2);
			bool flag3 = Event.current.type == EventType.MouseDown && Event.current.button == 0 && rect5.Contains(Event.current.mousePosition);
			if (flag3)
			{
				string text2 = GUIUtility.systemCopyBuffer;
				bool flag4 = !string.IsNullOrEmpty(text2);
				if (flag4)
				{
					text2 = text2.Trim();
					bool flag5 = text2.StartsWith("#");
					if (flag5)
					{
						text2 = text2.Substring(1);
					}
					bool flag6 = text2.StartsWith("0x", StringComparison.OrdinalIgnoreCase);
					if (flag6)
					{
						text2 = text2.Substring(2);
					}
					uint num;
					bool flag7 = uint.TryParse(text2, NumberStyles.HexNumber, null, out num);
					if (flag7)
					{
						bool flag8 = text2.Length >= 8;
						if (flag8)
						{
							color.r = (byte)((num >> 24) & 255U);
							color.g = (byte)((num >> 16) & 255U);
							color.b = (byte)((num >> 8) & 255U);
							color.a = (byte)(num & 255U);
						}
						else
						{
							bool flag9 = text2.Length >= 6;
							if (flag9)
							{
								color.r = (byte)((num >> 16) & 255U);
								color.g = (byte)((num >> 8) & 255U);
								color.b = (byte)(num & 255U);
							}
						}
					}
				}
				Event.current.Use();
			}
			Texture2D texture2D;
			bool flag10 = DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.TryGetValue("colorpicker", out texture2D) && texture2D != null;
			if (flag10)
			{
				Rect rect6 = GUILayoutUtility.GetRect(200f, 80f);
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect6.x - 1f, rect6.y - 1f, rect6.width + 2f, rect6.height + 2f), new Color32(50, 50, 55, byte.MaxValue), true, ScaleMode.StretchToFill);
				GUI.DrawTexture(rect6, texture2D, ScaleMode.StretchToFill, true, 0f, Color.white, 0f, 0f);
				bool flag11 = Event.current.type == EventType.MouseDown && Event.current.button == 0 && rect6.Contains(Event.current.mousePosition);
				if (flag11)
				{
					Vector2 vector = Event.current.mousePosition - rect6.position;
					float num2 = vector.x / rect6.width;
					float num3 = 1f;
					float num4 = 1f;
					float num5 = vector.y / rect6.height;
					bool flag12 = num5 > 0.75f;
					if (flag12)
					{
						float num6 = (num5 - 0.75f) / 0.25f;
						Color color2 = Color.HSVToRGB(num2, num3, num4);
						color = Color32.Lerp(color2, Color.white, num6);
					}
					else
					{
						bool flag13 = num5 < 0.25f;
						if (flag13)
						{
							float num7 = (0.25f - num5) / 0.25f;
							Color color3 = Color.HSVToRGB(num2, num3, num4);
							color = Color32.Lerp(color3, Color.black, num7);
						}
						else
						{
							color = Color.HSVToRGB(num2, num3, num4);
						}
					}
					Event.current.Use();
				}
			}
			Rect rect7 = GUILayoutUtility.GetRect(-1f, 16f);
			GUI.Label(new Rect(rect7.x, rect7.y, 35f, 16f), "R", new GUIStyle(GUI.skin.label)
			{
				fontSize = 10,
				normal = 
				{
					textColor = new Color32(byte.MaxValue, 100, 100, byte.MaxValue)
				}
			});
			color.r = (byte)DCZMfRiRIYR0S0VlSt966QjSO.DqSj2t1zG7WX2JTWDZOhvbfxt("", (float)color.r, 0f, 255f, new Rect(rect7.x + 20f, rect7.y, rect7.width - 20f, 16f));
			Rect rect8 = GUILayoutUtility.GetRect(-1f, 16f);
			GUI.Label(new Rect(rect8.x, rect8.y, 35f, 16f), "G", new GUIStyle(GUI.skin.label)
			{
				fontSize = 10,
				normal = 
				{
					textColor = new Color32(100, byte.MaxValue, 100, byte.MaxValue)
				}
			});
			color.g = (byte)DCZMfRiRIYR0S0VlSt966QjSO.DqSj2t1zG7WX2JTWDZOhvbfxt("", (float)color.g, 0f, 255f, new Rect(rect8.x + 20f, rect8.y, rect8.width - 20f, 16f));
			Rect rect9 = GUILayoutUtility.GetRect(-1f, 16f);
			GUI.Label(new Rect(rect9.x, rect9.y, 35f, 16f), "B", new GUIStyle(GUI.skin.label)
			{
				fontSize = 10,
				normal = 
				{
					textColor = new Color32(100, 150, byte.MaxValue, byte.MaxValue)
				}
			});
			color.b = (byte)DCZMfRiRIYR0S0VlSt966QjSO.DqSj2t1zG7WX2JTWDZOhvbfxt("", (float)color.b, 0f, 255f, new Rect(rect9.x + 20f, rect9.y, rect9.width - 20f, 16f));
			Rect rect10 = GUILayoutUtility.GetRect(-1f, 16f);
			GUI.Label(new Rect(rect10.x, rect10.y, 35f, 16f), "A", new GUIStyle(GUI.skin.label)
			{
				fontSize = 10,
				normal = 
				{
					textColor = Color.white
				}
			});
			color.a = (byte)DCZMfRiRIYR0S0VlSt966QjSO.DqSj2t1zG7WX2JTWDZOhvbfxt("", (float)color.a, 0f, 255f, new Rect(rect10.x + 20f, rect10.y, rect10.width - 20f, 16f));
		}
		else
		{
			Rect rect11 = GUILayoutUtility.GetRect(-1f, 20f);
			DCZMfRiRIYR0S0VlSt966QjSO.DrawRainbowGradient(rect11);
		}
		cheatColor.isGradient = DrysTRTjdLdFqu5GJBDif6AoV.DrawCheckbox(cheatColor.isGradient, "Rainbow Mode", Array.Empty<GUILayoutOption>());
		bool isGradient = cheatColor.isGradient;
		if (isGradient)
		{
			GUILayout.Space(4f);
			Rect rect12 = GUILayoutUtility.GetRect(-1f, 16f);
			GUI.Label(new Rect(rect12.x, rect12.y, 70f, 16f), "Speed:", new GUIStyle(GUI.skin.label)
			{
				fontSize = 10,
				normal = 
				{
					textColor = new Color32(180, 180, 180, byte.MaxValue)
				}
			});
			cheatColor.DpvkqvtTMG2lpoFl08AKmUDtD = DCZMfRiRIYR0S0VlSt966QjSO.DqSj2t1zG7WX2JTWDZOhvbfxt("", cheatColor.DpvkqvtTMG2lpoFl08AKmUDtD, 0.05f, 1f, new Rect(rect12.x + 50f, rect12.y, rect12.width - 50f, 16f));
		}
		cheatColor.settedColor = color;
	}

	// Token: 0x0600011F RID: 287 RVA: 0x0000D148 File Offset: 0x0000B348
	private static void DrawRainbowGradient(Rect rect)
	{
		for (int i = 0; i < (int)rect.width; i++)
		{
			float num = (float)i / rect.width;
			Color color = Color.HSVToRGB(num, 1f, 1f);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + (float)i, rect.y, 1f, rect.height), color, true, ScaleMode.StretchToFill);
		}
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x - 1f, rect.y - 1f, rect.width + 2f, 1f), new Color32(50, 50, 55, byte.MaxValue), true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x - 1f, rect.y + rect.height, rect.width + 2f, 1f), new Color32(50, 50, 55, byte.MaxValue), true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x - 1f, rect.y, 1f, rect.height), new Color32(50, 50, 55, byte.MaxValue), true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x + rect.width, rect.y, 1f, rect.height), new Color32(50, 50, 55, byte.MaxValue), true, ScaleMode.StretchToFill);
	}

	// Token: 0x06000120 RID: 288 RVA: 0x0000D2CC File Offset: 0x0000B4CC
	private static float DqSj2t1zG7WX2JTWDZOhvbfxt(string userText, float value, float min, float max, Rect rect)
	{
		int controlID = GUIUtility.GetControlID(FocusType.Passive);
		bool flag = DL3tNdrQzY7o8FV1oIOKODOLQ.Dlb00JzD6ydbflXaN4OoBvLdj == null;
		if (flag)
		{
			switch (Event.current.GetTypeForControl(controlID))
			{
			case EventType.MouseDown:
			{
				bool flag2 = rect.Contains(Event.current.mousePosition) && Event.current.button == 0;
				if (flag2)
				{
					GUIUtility.hotControl = controlID;
					float num = (Event.current.mousePosition.x - rect.x) / rect.width;
					value = min + num * (max - min);
					value = Mathf.Clamp(value, min, max);
					Event.current.Use();
				}
				break;
			}
			case EventType.MouseUp:
			{
				bool flag3 = GUIUtility.hotControl == controlID && Event.current.button == 0;
				if (flag3)
				{
					GUIUtility.hotControl = 0;
					Event.current.Use();
				}
				break;
			}
			case EventType.MouseDrag:
			{
				bool flag4 = GUIUtility.hotControl == controlID;
				if (flag4)
				{
					float num2 = (Event.current.mousePosition.x - rect.x) / rect.width;
					value = min + num2 * (max - min);
					value = Mathf.Clamp(value, min, max);
					Event.current.Use();
				}
				break;
			}
			}
		}
		string text = "cp_sld_" + controlID.ToString();
		float num3;
		bool flag5 = !DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.TryGetValue(text, out num3);
		if (flag5)
		{
			num3 = 0f;
			DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr.Add(text, 0f);
		}
		bool flag6 = rect.Contains(Event.current.mousePosition);
		bool flag7 = Event.current.type == EventType.Repaint;
		if (flag7)
		{
			bool flag8 = flag6 || GUIUtility.hotControl == controlID;
			if (flag8)
			{
				num3 += Time.deltaTime * 5f;
			}
			else
			{
				num3 -= Time.deltaTime * 5f;
			}
			num3 = Mathf.Clamp01(num3);
			DrysTRTjdLdFqu5GJBDif6AoV.DHpJyu9sUAYqubcV6OABfIgMr[text] = num3;
		}
		Rect rect2 = new Rect(rect.x, rect.y + 5f, rect.width, 6f);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect2, new Color32(20, 20, 22, byte.MaxValue), true, ScaleMode.StretchToFill);
		bool flag9 = GUIUtility.hotControl == controlID;
		Color32 color;
		if (flag9)
		{
			color = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
		}
		else
		{
			bool flag10 = num3 > 0f;
			if (flag10)
			{
				color = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor((byte)(num3 * 150f));
			}
			else
			{
				color = new Color32(65, 65, 70, byte.MaxValue);
			}
		}
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, rect2.width, 1f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y + rect2.height - 1f, rect2.width, 1f), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x, rect2.y, 1f, rect2.height), color, true, ScaleMode.StretchToFill);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect2.x + rect2.width - 1f, rect2.y, 1f, rect2.height), color, true, ScaleMode.StretchToFill);
		float num4 = (value - min) / (max - min);
		float num5 = num4 * (rect2.width - 2f);
		bool flag11 = num5 > 0f;
		if (flag11)
		{
			Rect rect3 = new Rect(rect2.x + 1f, rect2.y + 1f, num5, rect2.height - 2f);
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect3, DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue), true, ScaleMode.StretchToFill);
		}
		float num6 = rect2.x + num4 * rect2.width;
		Rect rect4 = new Rect(num6 - 3f, rect2.y - 2f, 6f, 10f);
		DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect4, new Color32(230, 230, 230, byte.MaxValue), true, ScaleMode.StretchToFill);
		GUIStyle guistyle = new GUIStyle(GUI.skin.label);
		guistyle.fontSize = 9;
		guistyle.alignment = TextAnchor.MiddleRight;
		guistyle.normal.textColor = new Color32(180, 180, 180, byte.MaxValue);
		GUI.Label(new Rect(rect.x + rect.width - 35f, rect.y - 2f, 30f, 14f), ((int)value).ToString(), guistyle);
		return value;
	}

	// Token: 0x04000183 RID: 387
	public Vector2 De5wxdLO1l3rDDj0TP95x5DCz = Vector2.zero;

	// Token: 0x04000184 RID: 388
	public Vector2 DwQHiTzEnXq2YbVolVgCMBukE = Vector2.zero;

	// Token: 0x04000185 RID: 389
	public bool D3K4rzUWBCl5cYJpxNv9aqlcg = true;

	// Token: 0x04000186 RID: 390
	public int DUEWCZx7x53tmAYpkPWtVyvVT;

	// Token: 0x04000187 RID: 391
	public int Dq0bJtLxiTlLMaOs1k9uP0W42;

	// Token: 0x04000188 RID: 392
	public string DFjKvyNcuuXAMwZchK5R4vX0R = "";
}
