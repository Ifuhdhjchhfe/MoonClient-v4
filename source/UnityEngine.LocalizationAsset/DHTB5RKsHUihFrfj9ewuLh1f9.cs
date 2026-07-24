using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

// Token: 0x0200006D RID: 109
public static class DHTB5RKsHUihFrfj9ewuLh1f9
{
	// Token: 0x0600021A RID: 538 RVA: 0x0001DA3C File Offset: 0x0001BC3C
	public static void Dv9BsDgHAnyYwdk6Cl3uqWZk7()
	{
		DHTB5RKsHUihFrfj9ewuLh1f9.DzcdNE09MmyJxge0D2v9fsUNF();
		DHTB5RKsHUihFrfj9ewuLh1f9.DadjTKiX0E1Mn7rl8IGo9jnVk();
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("colorpicker", D45oCja1emRGTf1Vx97hiw7OW.D3dyN0sUG4MZEahOSpObvi27e(200, 80));
		DHTB5RKsHUihFrfj9ewuLh1f9.DI1FounRN1RfV6XgzRhk3fZMv = typeof(UseableGun).GetField("thirdAttachments", BindingFlags.Instance | BindingFlags.NonPublic);
		DHTB5RKsHUihFrfj9ewuLh1f9.DazBzygjoFMvkTR5WZh79oJmJ = D45oCja1emRGTf1Vx97hiw7OW.DN0jqdSPVYa0UfF3KaVnSw4hS(Color.white);
		DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj = D45oCja1emRGTf1Vx97hiw7OW.DN0jqdSPVYa0UfF3KaVnSw4hS(new Color(0f, 0f, 0f, 0f));
		bool flag = DHTB5RKsHUihFrfj9ewuLh1f9.DcMsFq9dEczuCVCtMOhgvyOqi == null;
		if (flag)
		{
			DHTB5RKsHUihFrfj9ewuLh1f9.DcMsFq9dEczuCVCtMOhgvyOqi = D45oCja1emRGTf1Vx97hiw7OW.DN0jqdSPVYa0UfF3KaVnSw4hS(new Color(0f, 0f, 0f, 0f));
		}
		DTm52FQgIZyHlgsIe52RDqzcZ.Dsl47nk11Gy8UerLdkoyZgICJ(DHTB5RKsHUihFrfj9ewuLh1f9.D48Ozevr3FDGnIQax68V1HnRg());
		new Thread(new ThreadStart(DHTB5RKsHUihFrfj9ewuLh1f9.DsRSWoC406piDCTbf9aeFi2uP)).Start();
	}

	// Token: 0x0600021B RID: 539 RVA: 0x0001DB15 File Offset: 0x0001BD15
	private static IEnumerator D48Ozevr3FDGnIQax68V1HnRg()
	{
		yield return null;
	}

	// Token: 0x0600021C RID: 540 RVA: 0x0001DB20 File Offset: 0x0001BD20
	public static void DsRSWoC406piDCTbf9aeFi2uP()
	{
		try
		{
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("Getting assets");
			bool flag = File.Exists(Application.dataPath + "\\Resources\\unity_builtin_postprocess");
			if (flag)
			{
				DHTB5RKsHUihFrfj9ewuLh1f9.DM8oJgbgaJTK7ZXdMzDDfeZV4 = File.ReadAllBytes(Application.dataPath + "\\Resources\\unity_builtin_postprocess");
			}
		}
		catch (Exception ex)
		{
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("Assets get exception");
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.Message);
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.StackTrace);
		}
	}

	// Token: 0x0600021D RID: 541 RVA: 0x0001DBA8 File Offset: 0x0001BDA8
	public static void DRdKF4zUtKpQDaVyED2DgkJ7w(byte[] bytes)
	{
		DUt0a6FCClF9uncpHt4baoWwu dut0a6FCClF9uncpHt4baoWwu = new DUt0a6FCClF9uncpHt4baoWwu(bytes);
		ushort num = dut0a6FCClF9uncpHt4baoWwu.DmAu4cEiGWLGp7NLhkOyVsRbx();
		for (int i = 0; i < (int)num; i++)
		{
			DaTYqALDIRJJkrPUKrsyqwNAB daTYqALDIRJJkrPUKrsyqwNAB = new DaTYqALDIRJJkrPUKrsyqwNAB
			{
				DyWe6UdHStNKUCV3RmTzrh7W0 = (DB4sKfAKsIGV0Br9TKMRWTO1U)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU(),
				DcagFYj0mQmYtui4Jwz8tWrVQ = dut0a6FCClF9uncpHt4baoWwu.DwZMJgiflLxDLkLNV8ljFfb8p()
			};
			switch (daTYqALDIRJJkrPUKrsyqwNAB.DyWe6UdHStNKUCV3RmTzrh7W0)
			{
			case DB4sKfAKsIGV0Br9TKMRWTO1U.Mesh:
			{
				Mesh mesh = new Mesh();
				Vector3[] array = new Vector3[dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx()];
				for (int j = 0; j < array.Length; j++)
				{
					array[j] = new Vector3(dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o(), dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o(), dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o());
				}
				int[] array2 = new int[dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx()];
				for (int k = 0; k < array2.Length; k++)
				{
					array2[k] = dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx();
				}
				Vector3[] array3 = new Vector3[dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx()];
				for (int l = 0; l < array3.Length; l++)
				{
					array3[l] = new Vector3(dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o(), dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o(), dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o());
				}
				Vector2[] array4 = new Vector2[dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx()];
				for (int m = 0; m < array4.Length; m++)
				{
					array4[m] = new Vector2(dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o(), dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o());
				}
				mesh.vertices = array;
				mesh.triangles = array2;
				mesh.normals = array3;
				mesh.uv = array4;
				mesh.RecalculateNormals();
				daTYqALDIRJJkrPUKrsyqwNAB.DwlC9au41qTutPh1QajC5WDNW = mesh;
				break;
			}
			case DB4sKfAKsIGV0Br9TKMRWTO1U.Texture:
			{
				Texture2D texture2D = new Texture2D(dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx(), dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx());
				texture2D.filterMode = (FilterMode)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
				texture2D.anisoLevel = (int)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
				texture2D.wrapMode = (TextureWrapMode)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
				Color32[] array5 = new Color32[dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx()];
				for (int n = 0; n < array5.Length; n++)
				{
					array5[n] = dut0a6FCClF9uncpHt4baoWwu.DAZt0HibzmGVGH7r5UTPXQryY();
				}
				texture2D.SetPixels32(array5);
				texture2D.Apply();
				daTYqALDIRJJkrPUKrsyqwNAB.DwlC9au41qTutPh1QajC5WDNW = texture2D;
				break;
			}
			case DB4sKfAKsIGV0Br9TKMRWTO1U.Audio:
			{
				int num2 = dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx();
				float[] array6 = new float[dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx()];
				for (int num3 = 0; num3 < array6.Length; num3++)
				{
					array6[num3] = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
				}
				AudioClip audioClip = AudioClip.Create("LoadedAudio", array6.Length, 1, num2, false);
				audioClip.SetData(array6, 0);
				daTYqALDIRJJkrPUKrsyqwNAB.DwlC9au41qTutPh1QajC5WDNW = audioClip;
				break;
			}
			}
			DHTB5RKsHUihFrfj9ewuLh1f9.D8s0GJ48pUxIBk0rnoKdNCabn.Add(daTYqALDIRJJkrPUKrsyqwNAB.DcagFYj0mQmYtui4Jwz8tWrVQ, daTYqALDIRJJkrPUKrsyqwNAB);
		}
	}

	// Token: 0x0600021E RID: 542 RVA: 0x0001DE7C File Offset: 0x0001C07C
	public static byte[] Dj1ahcVhrlouz2EB9N2Wxdqwe(Player p)
	{
		bool flag = p.equipment.asset is ItemGunAsset;
		byte[] array;
		if (flag)
		{
			Attachments attachments = DHTB5RKsHUihFrfj9ewuLh1f9.DI1FounRN1RfV6XgzRhk3fZMv.GetValue(p.equipment.useable) as Attachments;
			array = (p.equipment.asset as ItemGunAsset).getState(attachments.sightID, attachments.tacticalID, attachments.gripID, attachments.barrelID, attachments.magazineID, 0);
		}
		else
		{
			array = p.equipment.asset.getState(EItemOrigin.WORLD);
		}
		return array;
	}

	// Token: 0x0600021F RID: 543 RVA: 0x0001DF10 File Offset: 0x0001C110
	public static Texture2D DPF1WELNU4huo63e3q4cLtYAP(Player player)
	{
		ushort num = ((player.equipment.asset != null) ? player.equipment.asset.id : player.equipment.itemID);
		bool flag = num == 0;
		Texture2D texture2D;
		if (flag)
		{
			texture2D = null;
		}
		else
		{
			texture2D = DHTB5RKsHUihFrfj9ewuLh1f9.DE5o3G4s3QZBWDFv6GseVzWV0(num, DHTB5RKsHUihFrfj9ewuLh1f9.Dj1ahcVhrlouz2EB9N2Wxdqwe(player));
		}
		return texture2D;
	}

	// Token: 0x06000220 RID: 544 RVA: 0x0001DF68 File Offset: 0x0001C168
	public static Texture2D D2i9HvfMKR0b89tKGqIxSWvrG(ushort id)
	{
		return DHTB5RKsHUihFrfj9ewuLh1f9.DE5o3G4s3QZBWDFv6GseVzWV0(id, new byte[0]);
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0001DF88 File Offset: 0x0001C188
	public static Texture2D DE5o3G4s3QZBWDFv6GseVzWV0(ushort id, byte[] state)
	{
		bool flag = !DHTB5RKsHUihFrfj9ewuLh1f9.DrutkZpt8iv0bRTM8DuO2281R.ContainsKey(id);
		Texture2D texture2D;
		if (flag)
		{
			DHTB5RKsHUihFrfj9ewuLh1f9.DrutkZpt8iv0bRTM8DuO2281R.Add(id, new DPtBTIvImbNsY0wJMuNEEHVIe(id));
			DHTB5RKsHUihFrfj9ewuLh1f9.DrutkZpt8iv0bRTM8DuO2281R[id].DQc9tmkTvoXN6ifrjZgm786ab.Add(state, null);
			ItemTool.getIcon(id, 100, state, delegate(int handle, Texture2D icon)
			{
				bool flag3 = DHTB5RKsHUihFrfj9ewuLh1f9.DrutkZpt8iv0bRTM8DuO2281R.ContainsKey(id) && DHTB5RKsHUihFrfj9ewuLh1f9.DrutkZpt8iv0bRTM8DuO2281R[id].DQc9tmkTvoXN6ifrjZgm786ab.ContainsKey(state);
				if (flag3)
				{
					DHTB5RKsHUihFrfj9ewuLh1f9.DrutkZpt8iv0bRTM8DuO2281R[id].DQc9tmkTvoXN6ifrjZgm786ab[state] = icon;
				}
			});
			texture2D = null;
		}
		else
		{
			bool flag2 = !DHTB5RKsHUihFrfj9ewuLh1f9.DrutkZpt8iv0bRTM8DuO2281R[id].D4yDTPZG015oGu0zbkQBd1cS7(state);
			if (flag2)
			{
				DHTB5RKsHUihFrfj9ewuLh1f9.DrutkZpt8iv0bRTM8DuO2281R[id].DQc9tmkTvoXN6ifrjZgm786ab.Add(state, null);
				ItemTool.getIcon(id, 100, state, delegate(int handle, Texture2D icon)
				{
					bool flag4 = DHTB5RKsHUihFrfj9ewuLh1f9.DrutkZpt8iv0bRTM8DuO2281R.ContainsKey(id) && DHTB5RKsHUihFrfj9ewuLh1f9.DrutkZpt8iv0bRTM8DuO2281R[id].DQc9tmkTvoXN6ifrjZgm786ab.ContainsKey(state);
					if (flag4)
					{
						DHTB5RKsHUihFrfj9ewuLh1f9.DrutkZpt8iv0bRTM8DuO2281R[id].DQc9tmkTvoXN6ifrjZgm786ab[state] = icon;
					}
				});
				texture2D = null;
			}
			else
			{
				texture2D = DHTB5RKsHUihFrfj9ewuLh1f9.DrutkZpt8iv0bRTM8DuO2281R[id].DT090naXqz4YZPMfIY5MVIHP2(state);
			}
		}
		return texture2D;
	}

	// Token: 0x06000222 RID: 546 RVA: 0x0001E0B8 File Offset: 0x0001C2B8
	public static Texture2D DQdqAKDPElShRsYiPvNwY1WVe(CSteamID playerId)
	{
		bool flag = !DHTB5RKsHUihFrfj9ewuLh1f9.DH5mbGG0XOKdSXq4If5Dw0fm7.ContainsKey(playerId.m_SteamID);
		if (flag)
		{
			DHTB5RKsHUihFrfj9ewuLh1f9.DH5mbGG0XOKdSXq4If5Dw0fm7.Add(playerId.m_SteamID, Provider.provider.communityService.getIcon(playerId, true));
		}
		return DHTB5RKsHUihFrfj9ewuLh1f9.DH5mbGG0XOKdSXq4If5Dw0fm7[playerId.m_SteamID];
	}

	// Token: 0x06000223 RID: 547 RVA: 0x0001E118 File Offset: 0x0001C318
	public static void DoMnYqzW8ywgQA5TrKgU0psBE(GUISkin defaultSkin)
	{
		DHTB5RKsHUihFrfj9ewuLh1f9.DdIP5zwwtYcXMytV3Kd3Ddp9u = true;
		DHTB5RKsHUihFrfj9ewuLh1f9.DArq80YDH1VSXFAWC7hFLeX3A = new GUIStyle(GUI.skin.label);
		DHTB5RKsHUihFrfj9ewuLh1f9.DArq80YDH1VSXFAWC7hFLeX3A.alignment = TextAnchor.MiddleCenter;
		DHTB5RKsHUihFrfj9ewuLh1f9.DArq80YDH1VSXFAWC7hFLeX3A.normal.textColor = new Color32(225, 225, 225, byte.MaxValue);
		DHTB5RKsHUihFrfj9ewuLh1f9.DArq80YDH1VSXFAWC7hFLeX3A.fontSize = 30;
		DHTB5RKsHUihFrfj9ewuLh1f9.DArq80YDH1VSXFAWC7hFLeX3A.richText = true;
		Font font = Font.CreateDynamicFontFromOSFont("Trebuchet MS", 30);
		bool flag = font == null;
		if (flag)
		{
			font = Font.CreateDynamicFontFromOSFont("Verdana", 30);
		}
		bool flag2 = font == null;
		if (flag2)
		{
			font = ((defaultSkin != null) ? defaultSkin.font : GUI.skin.font);
		}
		DHTB5RKsHUihFrfj9ewuLh1f9.DArq80YDH1VSXFAWC7hFLeX3A.font = font;
		DHTB5RKsHUihFrfj9ewuLh1f9.DArq80YDH1VSXFAWC7hFLeX3A.fontStyle = FontStyle.Bold;
		DRiUgFwe1bGGW0FKHIPOjT4PT.DBnnqOFz4Q43TJmECcblR0OPO.Add(DHTB5RKsHUihFrfj9ewuLh1f9.DArq80YDH1VSXFAWC7hFLeX3A.font);
		DHTB5RKsHUihFrfj9ewuLh1f9.DWfZBauk02v1VFXlXoVXyBq2Q = new GUIStyle(DHTB5RKsHUihFrfj9ewuLh1f9.DArq80YDH1VSXFAWC7hFLeX3A);
		DHTB5RKsHUihFrfj9ewuLh1f9.DWfZBauk02v1VFXlXoVXyBq2Q.normal.textColor = new Color32(20, 20, 20, byte.MaxValue);
		DHTB5RKsHUihFrfj9ewuLh1f9.DDOTP7O8otI0NkB1nfLBCsfkq = new GUIStyle(GUI.skin.label);
		DHTB5RKsHUihFrfj9ewuLh1f9.DDOTP7O8otI0NkB1nfLBCsfkq.alignment = TextAnchor.MiddleCenter;
		DHTB5RKsHUihFrfj9ewuLh1f9.DDOTP7O8otI0NkB1nfLBCsfkq.normal.textColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
		DHTB5RKsHUihFrfj9ewuLh1f9.DDOTP7O8otI0NkB1nfLBCsfkq.fontSize = 6;
		DHTB5RKsHUihFrfj9ewuLh1f9.DgrS1Khe0pBTJtuNOOIFIMr6Z = new GUIStyle(GUI.skin.label);
		DHTB5RKsHUihFrfj9ewuLh1f9.DgrS1Khe0pBTJtuNOOIFIMr6Z.alignment = TextAnchor.UpperLeft;
		DHTB5RKsHUihFrfj9ewuLh1f9.DgrS1Khe0pBTJtuNOOIFIMr6Z.normal.textColor = new Color32(100, 100, 100, byte.MaxValue);
		DHTB5RKsHUihFrfj9ewuLh1f9.DgrS1Khe0pBTJtuNOOIFIMr6Z.fontSize = 20;
		DHTB5RKsHUihFrfj9ewuLh1f9.D2WyUaRYHTMSsc1TPGyIZkTii = new GUIStyle(DHTB5RKsHUihFrfj9ewuLh1f9.D9lfSmJj7uBt2LIqhfmUnXfZe);
		DHTB5RKsHUihFrfj9ewuLh1f9.D2WyUaRYHTMSsc1TPGyIZkTii.normal.background = D45oCja1emRGTf1Vx97hiw7OW.DN0jqdSPVYa0UfF3KaVnSw4hS(new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0));
		DHTB5RKsHUihFrfj9ewuLh1f9.DiEJSsZXl9p0Vlp6M1APxSQZF = new GUIStyle(GUI.skin.label);
		DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd = new GUIStyle(DHTB5RKsHUihFrfj9ewuLh1f9.DiEJSsZXl9p0Vlp6M1APxSQZF);
		DHTB5RKsHUihFrfj9ewuLh1f9.DK4wVqNZgtC25Y4aNreZoDyxd.normal.textColor = new Color32(5, 5, 5, byte.MaxValue);
		DHTB5RKsHUihFrfj9ewuLh1f9.DSqLh3shLXYAnX4d0AcIljoVC = new GUIStyle(GUI.skin.label);
		DHTB5RKsHUihFrfj9ewuLh1f9.DSqLh3shLXYAnX4d0AcIljoVC.alignment = TextAnchor.MiddleCenter;
		DHTB5RKsHUihFrfj9ewuLh1f9.DcCtNCaSVWm57cNorggPJBWVH = new GUIStyle(DHTB5RKsHUihFrfj9ewuLh1f9.DSqLh3shLXYAnX4d0AcIljoVC);
		DHTB5RKsHUihFrfj9ewuLh1f9.DcCtNCaSVWm57cNorggPJBWVH.normal.textColor = new Color32(5, 5, 5, byte.MaxValue);
		DDddnUl0gHJ8ZiQTaRLEUBUS2.D1rNNQTbeXAuJzU4GQai0CSAx(GUI.skin.label);
		DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2 = new GUIStyle(GUI.skin.label);
		DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2.alignment = TextAnchor.MiddleLeft;
		DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2.fontSize = 11;
		Font font2 = Font.CreateDynamicFontFromOSFont("Arial Bold", 11);
		bool flag3 = font2 == null;
		if (flag3)
		{
			font2 = Font.CreateDynamicFontFromOSFont("Arial", 11);
		}
		bool flag4 = font2 == null;
		if (flag4)
		{
			font2 = ((defaultSkin != null) ? defaultSkin.font : GUI.skin.font);
		}
		DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2.font = font2;
		DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2.normal.textColor = new Color32(105, 105, 105, byte.MaxValue);
		DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2.fontStyle = FontStyle.Bold;
		DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2.clipping = TextClipping.Overflow;
		DHTB5RKsHUihFrfj9ewuLh1f9.Dd5vRcSR9u1ktCkgQDEs9F4oM = new GUIStyle(GUI.skin.label);
		DHTB5RKsHUihFrfj9ewuLh1f9.Dd5vRcSR9u1ktCkgQDEs9F4oM.alignment = TextAnchor.UpperLeft;
		DHTB5RKsHUihFrfj9ewuLh1f9.Dd5vRcSR9u1ktCkgQDEs9F4oM.fontSize = 11;
		Font font3 = Font.CreateDynamicFontFromOSFont("Arial Bold", 11);
		bool flag5 = font3 == null;
		if (flag5)
		{
			font3 = Font.CreateDynamicFontFromOSFont("Arial", 11);
		}
		bool flag6 = font3 == null;
		if (flag6)
		{
			font3 = ((defaultSkin != null) ? defaultSkin.font : GUI.skin.font);
		}
		DHTB5RKsHUihFrfj9ewuLh1f9.Dd5vRcSR9u1ktCkgQDEs9F4oM.font = font3;
		DHTB5RKsHUihFrfj9ewuLh1f9.Dd5vRcSR9u1ktCkgQDEs9F4oM.normal.textColor = new Color32(225, 225, 225, byte.MaxValue);
		DHTB5RKsHUihFrfj9ewuLh1f9.Dd5vRcSR9u1ktCkgQDEs9F4oM.fontStyle = FontStyle.Bold;
		DHTB5RKsHUihFrfj9ewuLh1f9.Dd5vRcSR9u1ktCkgQDEs9F4oM.clipping = TextClipping.Overflow;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0v7TFwwdUbomPtPbcvC0PO6U = new Texture2D(50, 50);
		for (int i = 0; i < 50; i++)
		{
			for (int j = 0; j < 50; j++)
			{
				DHTB5RKsHUihFrfj9ewuLh1f9.D0v7TFwwdUbomPtPbcvC0PO6U.SetPixel(i, j, Color.clear);
			}
		}
		for (int k = 10; k < 40; k++)
		{
			for (int l = 20 - (k - 10) / 2; l < 30 + (k - 10) / 2; l++)
			{
				DHTB5RKsHUihFrfj9ewuLh1f9.D0v7TFwwdUbomPtPbcvC0PO6U.SetPixel(k, l, Color.white);
			}
		}
		DHTB5RKsHUihFrfj9ewuLh1f9.D0v7TFwwdUbomPtPbcvC0PO6U.Apply();
		try
		{
			DHTB5RKsHUihFrfj9ewuLh1f9.DXAzLwDEGNzwx68xLgxU33xbi(defaultSkin);
		}
		catch
		{
		}
		DHTB5RKsHUihFrfj9ewuLh1f9.Dfelp1DQxFJtUs6YpVWOJ91GM = new GUIStyle(DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle);
	}

	// Token: 0x06000224 RID: 548 RVA: 0x0001E654 File Offset: 0x0001C854
	private static void DXAzLwDEGNzwx68xLgxU33xbi(GUISkin defaultSkin)
	{
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj = ScriptableObject.CreateInstance<GUISkin>();
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.font = defaultSkin.font;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.box = new GUIStyle(defaultSkin.box);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button = new GUIStyle(defaultSkin.button);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.normal.background = D45oCja1emRGTf1Vx97hiw7OW.DN0jqdSPVYa0UfF3KaVnSw4hS(new Color32(62, 62, 62, byte.MaxValue));
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.active.background = D45oCja1emRGTf1Vx97hiw7OW.DN0jqdSPVYa0UfF3KaVnSw4hS(new Color32(32, 32, 33, byte.MaxValue));
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.focused.background = D45oCja1emRGTf1Vx97hiw7OW.DN0jqdSPVYa0UfF3KaVnSw4hS(new Color32(32, 32, 33, byte.MaxValue));
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.hover.background = D45oCja1emRGTf1Vx97hiw7OW.DN0jqdSPVYa0UfF3KaVnSw4hS(new Color32(42, 42, 43, byte.MaxValue));
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.alignment = TextAnchor.MiddleCenter;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.fixedHeight = 14f;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.fontSize = 11;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.stretchWidth = true;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.stretchHeight = false;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.contentOffset = new Vector2(0f, 3f);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.border = new RectOffset(4, 4, 0, -1);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.margin = new RectOffset(4, 4, 4, 6);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.padding = new RectOffset(0, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.overflow = new RectOffset(0, 0, -4, 4);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.label = new GUIStyle(defaultSkin.label);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.label.fontSize = 11;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.label.wordWrap = true;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.label.contentOffset = Vector2.zero;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.label.border = new RectOffset(0, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.label.margin = new RectOffset(4, 4, 4, 4);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.label.padding = new RectOffset(0, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.label.overflow = new RectOffset(0, 0, 0, 0);
		Texture2D texture2D = D45oCja1emRGTf1Vx97hiw7OW.DuVHuj2uJYqXLiOMmkRlVCl92(52, 40, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0));
		D45oCja1emRGTf1Vx97hiw7OW.DgN0vS0PdHNILt6bdhC5PSVbQ(new Rect(0f, 37f, 52f, 3f), new Color32(137, 207, 240, byte.MaxValue), ref texture2D);
		DHTB5RKsHUihFrfj9ewuLh1f9.DtextFieldBorderTex = texture2D;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField = new GUIStyle(defaultSkin.textField);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.normal.textColor = Color.white;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.normal.background = texture2D;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.hover.textColor = Color.white;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.hover.background = texture2D;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.active.textColor = Color.white;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.active.background = texture2D;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.focused.textColor = Color.white;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.focused.background = texture2D;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.onActive.textColor = Color.white;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.onActive.background = texture2D;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.onFocused.textColor = Color.white;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.onFocused.background = texture2D;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.onHover.textColor = Color.white;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.onHover.background = texture2D;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.onNormal.textColor = Color.white;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.onNormal.background = texture2D;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.alignment = TextAnchor.UpperCenter;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.fixedHeight = 25f;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.border = new RectOffset(4, 4, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.margin = new RectOffset(4, 4, 4, 4);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.padding = new RectOffset(3, 3, 3, 3);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.overflow = new RectOffset(0, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.textField.active.background = texture2D;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle = new GUIStyle(defaultSkin.toggle);
		Texture2D texture2D2 = D45oCja1emRGTf1Vx97hiw7OW.DuVHuj2uJYqXLiOMmkRlVCl92(15, 15, new Color32(40, 40, 40, byte.MaxValue));
		Texture2D texture2D3 = D45oCja1emRGTf1Vx97hiw7OW.DuVHuj2uJYqXLiOMmkRlVCl92(15, 15, new Color32(137, 207, 240, byte.MaxValue));
		DHTB5RKsHUihFrfj9ewuLh1f9.DtoggleActiveTex = texture2D3;
		D45oCja1emRGTf1Vx97hiw7OW.DgN0vS0PdHNILt6bdhC5PSVbQ(new Rect(4f, 4f, 7f, 7f), new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), ref texture2D3);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.normal.background = texture2D2;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.hover.background = null;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.active.background = texture2D3;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.onNormal.background = texture2D3;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.onHover.background = texture2D3;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.onActive.background = texture2D3;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.fixedHeight = 15f;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.fixedWidth = 15f;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.stretchHeight = false;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.stretchWidth = false;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.clipping = TextClipping.Overflow;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.fontSize = 0;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.contentOffset = Vector2.zero;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.alignment = TextAnchor.MiddleLeft;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.border = new RectOffset(15, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.margin = new RectOffset(4, 4, 4, 4);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.padding = new RectOffset(23, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.toggle.overflow = new RectOffset(0, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSlider = new GUIStyle(defaultSkin.horizontalSlider);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSlider.normal.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSlider.border = new RectOffset(0, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSlider.margin = new RectOffset(0, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSlider.padding = new RectOffset(0, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSlider.overflow = new RectOffset(0, 0, 0, 0);
		Texture2D texture2D4 = D45oCja1emRGTf1Vx97hiw7OW.DuVHuj2uJYqXLiOMmkRlVCl92(13, 12, new Color32(137, 207, 240, byte.MaxValue));
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSliderThumb = new GUIStyle(defaultSkin.horizontalSliderThumb);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSliderThumb.normal.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSliderThumb.active.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSliderThumb.focused.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSliderThumb.hover.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSliderThumb.fixedHeight = 5f;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSliderThumb.fixedWidth = 1f;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSliderThumb.border = new RectOffset(0, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSliderThumb.margin = new RectOffset(0, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSliderThumb.padding = new RectOffset(0, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSliderThumb.overflow = new RectOffset(-1, -1, -9, 8);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSliderThumb.contentOffset = Vector2.zero;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalSlider = new GUIStyle(defaultSkin.verticalSlider);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalSlider.normal.background = DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSlider.normal.background;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalSliderThumb = new GUIStyle(defaultSkin.verticalSliderThumb);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalSliderThumb.normal.background = DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSliderThumb.normal.background;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalScrollbar = new GUIStyle(defaultSkin.horizontalScrollbar);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalScrollbar.normal.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalScrollbar.active.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalScrollbar.hover.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalScrollbar.focused.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalScrollbarThumb = new GUIStyle(defaultSkin.horizontalScrollbarThumb);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalScrollbarThumb.normal.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalScrollbarThumb.active.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalScrollbarThumb.hover.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalScrollbarThumb.focused.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalScrollbarLeftButton = new GUIStyle(defaultSkin.horizontalScrollbarLeftButton);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalScrollbarRightButton = new GUIStyle(defaultSkin.horizontalScrollbarRightButton);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalScrollbar = new GUIStyle(defaultSkin.verticalScrollbar);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalScrollbar.fixedWidth = 6f;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalScrollbar.normal.background = D45oCja1emRGTf1Vx97hiw7OW.DuVHuj2uJYqXLiOMmkRlVCl92(6, 16, new Color32(30, 30, 30, byte.MaxValue));
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalScrollbarThumb = new GUIStyle(defaultSkin.verticalScrollbarThumb);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalScrollbarThumb.normal.background = D45oCja1emRGTf1Vx97hiw7OW.DuVHuj2uJYqXLiOMmkRlVCl92(4, 12, new Color32(137, 207, 240, byte.MaxValue));
		DHTB5RKsHUihFrfj9ewuLh1f9.DscrollbarThumbTex = DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalScrollbarThumb.normal.background;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalScrollbar.fixedWidth = 4f;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalScrollbarDownButton = new GUIStyle(defaultSkin.verticalScrollbarDownButton);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalScrollbarUpButton = new GUIStyle(defaultSkin.verticalScrollbarUpButton);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.scrollView = new GUIStyle(defaultSkin.scrollView);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.window = new GUIStyle(defaultSkin.window);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.window.normal.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.window.hover.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.window.active.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.window.focused.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.window.onNormal.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.window.onHover.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.window.onActive.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.window.onFocused.background = DHTB5RKsHUihFrfj9ewuLh1f9.Dyp5jV5Y4tOILYuxmsSHPUJTj;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.customStyles = new GUIStyle[1];
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.customStyles[0] = new GUIStyle(DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.box);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.customStyles[0].normal.background = D45oCja1emRGTf1Vx97hiw7OW.DuVHuj2uJYqXLiOMmkRlVCl92(100, 40, new Color32(52, 52, 52, byte.MaxValue));
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.customStyles[0].fontSize = 10;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.customStyles[0].alignment = TextAnchor.MiddleCenter;
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.customStyles[0].border = new RectOffset(2, 2, 2, 2);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.customStyles[0].margin = new RectOffset(4, 4, 4, 4);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.customStyles[0].padding = new RectOffset(0, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.customStyles[0].overflow = new RectOffset(0, 0, 0, 0);
		DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.name = "CustomSkin";
		global::UnityEngine.Object.DontDestroyOnLoad(DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj);
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("customStyles[0].normal", DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.customStyles[0].normal.background);
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("customStyles[0].active", DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.customStyles[0].active.background);
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("customStyles[0].hover", DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.customStyles[0].hover.background);
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("toggle.normal", texture2D2);
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("activeTexture", texture2D3);
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("textFieldTexture", texture2D);
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("horizontalSlider.normal", DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.horizontalSlider.normal.background);
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("horizontalSliderThumb.normal", texture2D4);
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("verticalScrollbar.normal", DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalScrollbar.normal.background);
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("verticalScrollbarThumb.normal", DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalScrollbarThumb.normal.background);
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("button.normal", DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.normal.background);
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("button.active", DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.active.background);
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("button.focused", DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.focused.background);
		DHTB5RKsHUihFrfj9ewuLh1f9.DPpZoLhs3j2CWT7lxGY09wjQi.Add("button.hover", DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.button.hover.background);
	}

	// Token: 0x06000225 RID: 549 RVA: 0x0001F600 File Offset: 0x0001D800
	private static void DadjTKiX0E1Mn7rl8IGo9jnVk()
	{
		try
		{
			DHTB5RKsHUihFrfj9ewuLh1f9.DJu8jOJDqPUBFfpVNdDwkec3H = new GameObject("Circle");
			global::UnityEngine.Object.DontDestroyOnLoad(DHTB5RKsHUihFrfj9ewuLh1f9.DJu8jOJDqPUBFfpVNdDwkec3H);
			DHTB5RKsHUihFrfj9ewuLh1f9.DJu8jOJDqPUBFfpVNdDwkec3H.transform.position = new Vector3(0f, -245f, 0f);
			DHTB5RKsHUihFrfj9ewuLh1f9.DJu8jOJDqPUBFfpVNdDwkec3H.transform.eulerAngles += new Vector3(0f, 0f, 90f);
			MeshFilter meshFilter = DHTB5RKsHUihFrfj9ewuLh1f9.DJu8jOJDqPUBFfpVNdDwkec3H.AddComponent<MeshFilter>();
			MeshRenderer meshRenderer = DHTB5RKsHUihFrfj9ewuLh1f9.DJu8jOJDqPUBFfpVNdDwkec3H.AddComponent<MeshRenderer>();
			DHTB5RKsHUihFrfj9ewuLh1f9.DJu8jOJDqPUBFfpVNdDwkec3H.layer = 16;
			Mesh mesh = new Mesh();
			meshFilter.mesh = mesh;
			List<Vector3> list = new List<Vector3>();
			List<int> list2 = new List<int>();
			float num = 0.09817477f;
			for (int i = 0; i <= 64; i++)
			{
				float num2 = (float)i * num;
				float num3 = Mathf.Cos(num2);
				float num4 = Mathf.Sin(num2);
				list.Add(new Vector3(num3, num4, 0f));
				bool flag = i > 0;
				if (flag)
				{
					list2.Add(i - 1);
					list2.Add(i);
				}
			}
			list2.Add(64);
			list2.Add(0);
			mesh.vertices = list.ToArray();
			mesh.SetIndices(list2.ToArray(), MeshTopology.Lines, 0);
			Material material = new Material(Shader.Find("Hidden/Internal-Colored"))
			{
				hideFlags = HideFlags.HideAndDontSave
			};
			material.SetInt("_SrcBlend", 5);
			material.SetInt("_DstBlend", 10);
			material.SetInt("_Cull", 0);
			material.SetInt("_ZWrite", 0);
			material.SetInt("_ZTest", 8);
			meshRenderer.sharedMaterial = new Material(material);
		}
		catch (Exception ex)
		{
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.Message);
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.StackTrace);
		}
	}

	// Token: 0x06000226 RID: 550 RVA: 0x0001F810 File Offset: 0x0001DA10
	private static void DzcdNE09MmyJxge0D2v9fsUNF()
	{
		try
		{
			DHTB5RKsHUihFrfj9ewuLh1f9.DwFaODFnGogvbEmCIybqOhCtW = new GameObject("Tracer");
			global::UnityEngine.Object.DontDestroyOnLoad(DHTB5RKsHUihFrfj9ewuLh1f9.DwFaODFnGogvbEmCIybqOhCtW);
			DHTB5RKsHUihFrfj9ewuLh1f9.DwFaODFnGogvbEmCIybqOhCtW.transform.position = new Vector3(0f, -245f, 0f);
			DHTB5RKsHUihFrfj9ewuLh1f9.DwFaODFnGogvbEmCIybqOhCtW.transform.eulerAngles += new Vector3(0f, 0f, 90f);
			MeshFilter meshFilter = DHTB5RKsHUihFrfj9ewuLh1f9.DwFaODFnGogvbEmCIybqOhCtW.AddComponent<MeshFilter>();
			MeshRenderer meshRenderer = DHTB5RKsHUihFrfj9ewuLh1f9.DwFaODFnGogvbEmCIybqOhCtW.AddComponent<MeshRenderer>();
			DHTB5RKsHUihFrfj9ewuLh1f9.DwFaODFnGogvbEmCIybqOhCtW.layer = 16;
			Mesh mesh = new Mesh();
			meshFilter.mesh = mesh;
			float num = 0.2f;
			float num2 = 0.2f;
			Vector3[] array = new Vector3[]
			{
				new Vector3(-num / 2f, 0f, -num2 / 2f),
				new Vector3(-num / 2f, 0f, num2 / 2f),
				new Vector3(num / 2f, 0f, num2 / 2f),
				new Vector3(num / 2f, 0f, -num2 / 2f)
			};
			int[] array2 = new int[] { 0, 1, 2, 2, 3, 0 };
			Vector2[] array3 = new Vector2[]
			{
				new Vector2(0f, 0f),
				new Vector2(0f, 1f),
				new Vector2(1f, 1f),
				new Vector2(1f, 0f)
			};
			mesh.vertices = array;
			mesh.triangles = array2;
			mesh.uv = array3;
			mesh.RecalculateNormals();
			Material material = new Material(Shader.Find("Hidden/Internal-Colored"))
			{
				hideFlags = HideFlags.HideAndDontSave
			};
			material.SetInt("_SrcBlend", 5);
			material.SetInt("_DstBlend", 10);
			material.SetInt("_Cull", 0);
			material.SetInt("_ZWrite", 0);
			meshRenderer.sharedMaterial = new Material(material);
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(DHTB5RKsHUihFrfj9ewuLh1f9.DwFaODFnGogvbEmCIybqOhCtW);
			gameObject.transform.SetParent(DHTB5RKsHUihFrfj9ewuLh1f9.DwFaODFnGogvbEmCIybqOhCtW.transform);
			gameObject.transform.localEulerAngles = new Vector3(0f, 0f, 180f);
			CombineInstance[] array4 = new CombineInstance[2];
			array4[0] = default(CombineInstance);
			array4[0].mesh = mesh;
			array4[0].transform = meshRenderer.transform.localToWorldMatrix;
			array4[1] = default(CombineInstance);
			array4[1].mesh = gameObject.GetComponent<MeshFilter>().sharedMesh;
			array4[1].transform = gameObject.transform.localToWorldMatrix;
			new Mesh().CombineMeshes(array4);
			global::UnityEngine.Object.Destroy(gameObject);
		}
		catch (Exception ex)
		{
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.Message);
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.StackTrace);
		}
	}

	// Token: 0x06000227 RID: 551 RVA: 0x0001FB64 File Offset: 0x0001DD64
	public static void DupdateAccentTextures(Color32 accent)
	{
		bool flag = DHTB5RKsHUihFrfj9ewuLh1f9.DtextFieldBorderTex != null;
		if (flag)
		{
			D45oCja1emRGTf1Vx97hiw7OW.DgN0vS0PdHNILt6bdhC5PSVbQ(new Rect(0f, 37f, 52f, 3f), accent, ref DHTB5RKsHUihFrfj9ewuLh1f9.DtextFieldBorderTex);
		}
		bool flag2 = DHTB5RKsHUihFrfj9ewuLh1f9.DtoggleActiveTex != null;
		if (flag2)
		{
			D45oCja1emRGTf1Vx97hiw7OW.DgN0vS0PdHNILt6bdhC5PSVbQ(new Rect(0f, 0f, 15f, 15f), accent, ref DHTB5RKsHUihFrfj9ewuLh1f9.DtoggleActiveTex);
			D45oCja1emRGTf1Vx97hiw7OW.DgN0vS0PdHNILt6bdhC5PSVbQ(new Rect(4f, 4f, 7f, 7f), new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), ref DHTB5RKsHUihFrfj9ewuLh1f9.DtoggleActiveTex);
		}
		bool flag3 = DHTB5RKsHUihFrfj9ewuLh1f9.DscrollbarThumbTex != null;
		if (flag3)
		{
			Texture2D texture2D = D45oCja1emRGTf1Vx97hiw7OW.DuVHuj2uJYqXLiOMmkRlVCl92(4, 12, accent);
			DHTB5RKsHUihFrfj9ewuLh1f9.DscrollbarThumbTex = texture2D;
			DHTB5RKsHUihFrfj9ewuLh1f9.D0jJqMLncoCHu9QgXhMcOabgj.verticalScrollbarThumb.normal.background = texture2D;
		}
		DHTB5RKsHUihFrfj9ewuLh1f9.DlastAccentColor = accent;
	}

	// Token: 0x06000228 RID: 552 RVA: 0x0001FC6C File Offset: 0x0001DE6C
	public static void DcheckAccentUpdate()
	{
		Color32 accentColor = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
		bool flag = accentColor.r != DHTB5RKsHUihFrfj9ewuLh1f9.DlastAccentColor.r || accentColor.g != DHTB5RKsHUihFrfj9ewuLh1f9.DlastAccentColor.g || accentColor.b != DHTB5RKsHUihFrfj9ewuLh1f9.DlastAccentColor.b;
		if (flag)
		{
			DHTB5RKsHUihFrfj9ewuLh1f9.DupdateAccentTextures(accentColor);
		}
	}

	// Token: 0x0400029B RID: 667
	public static Dictionary<string, Texture2D> DPpZoLhs3j2CWT7lxGY09wjQi = new Dictionary<string, Texture2D>();

	// Token: 0x0400029C RID: 668
	public static Dictionary<string, DaTYqALDIRJJkrPUKrsyqwNAB> D8s0GJ48pUxIBk0rnoKdNCabn = new Dictionary<string, DaTYqALDIRJJkrPUKrsyqwNAB>();

	// Token: 0x0400029D RID: 669
	public static StaticResourceRef<Texture2D> DJ5ccrBkXzthVBZKvdtf0TbaS = new StaticResourceRef<Texture2D>("UI/Glazier_IMGUI/Cursor");

	// Token: 0x0400029E RID: 670
	public static Texture2D DazBzygjoFMvkTR5WZh79oJmJ;

	// Token: 0x0400029F RID: 671
	public static Texture2D Dyp5jV5Y4tOILYuxmsSHPUJTj;

	// Token: 0x040002A0 RID: 672
	public static Texture2D DcMsFq9dEczuCVCtMOhgvyOqi;

	// Token: 0x040002A1 RID: 673
	public static Texture2D D0v7TFwwdUbomPtPbcvC0PO6U;

	// Token: 0x040002A2 RID: 674
	public static bool DdIP5zwwtYcXMytV3Kd3Ddp9u = false;

	// Token: 0x040002A3 RID: 675
	public static GUISkin D0jJqMLncoCHu9QgXhMcOabgj;

	// Token: 0x040002A4 RID: 676
	public static GUIStyle D2WyUaRYHTMSsc1TPGyIZkTii;

	// Token: 0x040002A5 RID: 677
	public static GUIStyle D9lfSmJj7uBt2LIqhfmUnXfZe;

	// Token: 0x040002A6 RID: 678
	public static GUIStyle DArq80YDH1VSXFAWC7hFLeX3A;

	// Token: 0x040002A7 RID: 679
	public static GUIStyle DWfZBauk02v1VFXlXoVXyBq2Q;

	// Token: 0x040002A8 RID: 680
	public static GUIStyle DDOTP7O8otI0NkB1nfLBCsfkq;

	// Token: 0x040002A9 RID: 681
	public static GUIStyle DgrS1Khe0pBTJtuNOOIFIMr6Z;

	// Token: 0x040002AA RID: 682
	public static GUIStyle DiEJSsZXl9p0Vlp6M1APxSQZF;

	// Token: 0x040002AB RID: 683
	public static GUIStyle DK4wVqNZgtC25Y4aNreZoDyxd;

	// Token: 0x040002AC RID: 684
	public static GUIStyle DSqLh3shLXYAnX4d0AcIljoVC;

	// Token: 0x040002AD RID: 685
	public static GUIStyle DcCtNCaSVWm57cNorggPJBWVH;

	// Token: 0x040002AE RID: 686
	public static GUIStyle DtwXQKSBGkPc5vLHkpnmJXyJ2;

	// Token: 0x040002AF RID: 687
	public static GUIStyle Dd5vRcSR9u1ktCkgQDEs9F4oM;

	// Token: 0x040002B0 RID: 688
	public static GUIStyle Dfelp1DQxFJtUs6YpVWOJ91GM;

	// Token: 0x040002B1 RID: 689
	public static string[] D50CQJe2EthMU30M7FeGyJFY1 = new string[] { "Fart sound", "Nya", "Roblox death", "Cheat hit", "Uwu", "Random" };

	// Token: 0x040002B2 RID: 690
	private const string DyQxhaKsUfSmAL7bPKbNAxJoE = "Resources\\unity_builtin_postprocess";

	// Token: 0x040002B3 RID: 691
	private static byte[] DM8oJgbgaJTK7ZXdMzDDfeZV4;

	// Token: 0x040002B4 RID: 692
	public static GameObject DwFaODFnGogvbEmCIybqOhCtW;

	// Token: 0x040002B5 RID: 693
	public static GameObject DJu8jOJDqPUBFfpVNdDwkec3H;

	// Token: 0x040002B6 RID: 694
	private static FieldInfo DI1FounRN1RfV6XgzRhk3fZMv;

	// Token: 0x040002B7 RID: 695
	private static Dictionary<ushort, DPtBTIvImbNsY0wJMuNEEHVIe> DrutkZpt8iv0bRTM8DuO2281R = new Dictionary<ushort, DPtBTIvImbNsY0wJMuNEEHVIe>();

	// Token: 0x040002B8 RID: 696
	private static Dictionary<ulong, Texture2D> DH5mbGG0XOKdSXq4If5Dw0fm7 = new Dictionary<ulong, Texture2D>();

	// Token: 0x040002B9 RID: 697
	private static Texture2D DtextFieldBorderTex;

	// Token: 0x040002BA RID: 698
	private static Texture2D DtoggleActiveTex;

	// Token: 0x040002BB RID: 699
	private static Texture2D DscrollbarThumbTex;

	// Token: 0x040002BC RID: 700
	private static Color32 DlastAccentColor = new Color32(0, 180, 216, byte.MaxValue);
}
