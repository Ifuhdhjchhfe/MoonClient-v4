using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000093 RID: 147
public class DOEkZ1zoBEuvfUmOs9QSpfX0X
{
	// Token: 0x060002CB RID: 715 RVA: 0x00029768 File Offset: 0x00027968
	public void DMo7BsXx7dZ72VKnI3P4NzkYZ(int index)
	{
		Rect rect = new Rect(DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.x + 10f, DL3tNdrQzY7o8FV1oIOKODOLQ.DChWvgFM7dwLa4Qziaq5j4CZ4.y + 85f + (float)(index * 20), 120f, 20f);
		bool flag = Input.GetMouseButtonDown(0) && rect.Contains(Event.current.mousePosition);
		bool flag2 = flag;
		if (flag2)
		{
			DL3tNdrQzY7o8FV1oIOKODOLQ.DyuQWqXsYmbwkeFm6eDaas9Zb = null;
			DL3tNdrQzY7o8FV1oIOKODOLQ.DcLM0w9WaAvagqTbdgB0vfG8A = this;
		}
		bool flag3 = Event.current.type != EventType.Repaint;
		bool flag4 = !flag3;
		if (flag4)
		{
			bool flag5 = this.DpG9earyl1u6F9hpF9E0GlEBd > 0f;
			bool flag6 = flag5;
			if (flag6)
			{
				this.DWiNKbAl9y0ZmEcNSs89ix8MU = 1f;
			}
			else
			{
				bool flag7 = rect.Contains(Event.current.mousePosition);
				bool flag8 = flag7;
				if (flag8)
				{
					this.DWiNKbAl9y0ZmEcNSs89ix8MU += Time.deltaTime * 4f;
				}
				else
				{
					this.DWiNKbAl9y0ZmEcNSs89ix8MU -= Time.deltaTime * 8f;
				}
			}
			this.DWiNKbAl9y0ZmEcNSs89ix8MU = Mathf.Clamp(this.DWiNKbAl9y0ZmEcNSs89ix8MU, 0f, 1f);
			bool flag9 = DL3tNdrQzY7o8FV1oIOKODOLQ.D7CNlmL58D0jGJezjQxztg0NY == this;
			bool flag10 = flag9;
			if (flag10)
			{
				this.DpG9earyl1u6F9hpF9E0GlEBd += Time.deltaTime * 3.6f;
			}
			else
			{
				this.DpG9earyl1u6F9hpF9E0GlEBd -= Time.deltaTime * 5f;
			}
			this.DpG9earyl1u6F9hpF9E0GlEBd = Mathf.Clamp(this.DpG9earyl1u6F9hpF9E0GlEBd, 0f, 1f);
		}
		float num = Mathf.Max(this.DWiNKbAl9y0ZmEcNSs89ix8MU, this.DpG9earyl1u6F9hpF9E0GlEBd);
		bool flag11 = num > 0f;
		if (flag11)
		{
			Color32 color = new Color32(24, 24, 28, (byte)(num * 255f));
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(rect, color, false, ScaleMode.StretchToFill);
		}
		bool flag12 = this.DpG9earyl1u6F9hpF9E0GlEBd > 0f;
		if (flag12)
		{
			Color32 accentColor = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor((byte)(this.DpG9earyl1u6F9hpF9E0GlEBd * 255f));
			DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, 3f, rect.height), accentColor, false, ScaleMode.StretchToFill);
		}
		else
		{
			bool flag13 = this.DWiNKbAl9y0ZmEcNSs89ix8MU > 0f;
			if (flag13)
			{
				Color32 accentColor2 = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor((byte)(this.DWiNKbAl9y0ZmEcNSs89ix8MU * 100f));
				DrysTRTjdLdFqu5GJBDif6AoV.DytkmjKQAK1tAtNzrP40DgjrU(new Rect(rect.x, rect.y, 3f, rect.height), accentColor2, false, ScaleMode.StretchToFill);
			}
		}
		GUIStyle dtwXQKSBGkPc5vLHkpnmJXyJ = DHTB5RKsHUihFrfj9ewuLh1f9.DtwXQKSBGkPc5vLHkpnmJXyJ2;
		Color32 color2 = dtwXQKSBGkPc5vLHkpnmJXyJ.normal.textColor;
		bool flag14 = this.DpG9earyl1u6F9hpF9E0GlEBd > 0.5f;
		if (flag14)
		{
			dtwXQKSBGkPc5vLHkpnmJXyJ.normal.textColor = DrysTRTjdLdFqu5GJBDif6AoV.GetAccentColor(byte.MaxValue);
		}
		else
		{
			bool flag15 = this.DWiNKbAl9y0ZmEcNSs89ix8MU > 0.5f;
			if (flag15)
			{
				dtwXQKSBGkPc5vLHkpnmJXyJ.normal.textColor = new Color32(180, 180, 180, byte.MaxValue);
			}
		}
		GUI.Label(new Rect(rect.x + 30f, rect.y, rect.width - 30f, rect.height), this.GetName(), dtwXQKSBGkPc5vLHkpnmJXyJ);
		dtwXQKSBGkPc5vLHkpnmJXyJ.normal.textColor = color2;
		GUILayout.Space(6f);
	}

	// Token: 0x060002CC RID: 716 RVA: 0x00029AC8 File Offset: 0x00027CC8
	public virtual string GetName()
	{
		return "Null";
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00029AE0 File Offset: 0x00027CE0
	public virtual int SortId()
	{
		return -1;
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00016AB7 File Offset: 0x00014CB7
	public virtual void DoTab(DYIPJORHeVCfbpocFHvJty4OE tc)
	{
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00029AF4 File Offset: 0x00027CF4
	public virtual DYIPJORHeVCfbpocFHvJty4OE GetTabCounts()
	{
		return DYIPJORHeVCfbpocFHvJty4OE.Two;
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x00029B08 File Offset: 0x00027D08
	public void DGLNJE6Ld056OViYFjOM7IeMS(string text)
	{
		Rect rect = GUILayoutUtility.GetRect(-1f, 18f);
		GUI.Label(new Rect(rect.x + 20f, rect.y, rect.width - 20f, rect.height), text, DHTB5RKsHUihFrfj9ewuLh1f9.Dd5vRcSR9u1ktCkgQDEs9F4oM);
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00029B60 File Offset: 0x00027D60
	[CompilerGenerated]
	private Color32 Dn6blguiwO8233UUiBIsoeT2I(byte r, byte g, byte b)
	{
		return new Color32(r, g, b, (byte)(255f * (this.DWiNKbAl9y0ZmEcNSs89ix8MU / 2f + this.DpG9earyl1u6F9hpF9E0GlEBd / 2f)));
	}

	// Token: 0x04000335 RID: 821
	public float DWiNKbAl9y0ZmEcNSs89ix8MU = 0f;

	// Token: 0x04000336 RID: 822
	public float DpG9earyl1u6F9hpF9E0GlEBd = 0f;
}
