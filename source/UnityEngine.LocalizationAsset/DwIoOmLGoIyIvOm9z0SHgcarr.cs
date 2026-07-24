using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000CD RID: 205
public class DwIoOmLGoIyIvOm9z0SHgcarr
{
	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060003EB RID: 1003 RVA: 0x0003AEC8 File Offset: 0x000390C8
	// (set) Token: 0x060003EC RID: 1004 RVA: 0x0003AEE0 File Offset: 0x000390E0
	public bool enabled
	{
		get
		{
			return this.DnKHJ7nbx91rflUgZ0Y1Sy8zj;
		}
		set
		{
			bool flag = this.DnKHJ7nbx91rflUgZ0Y1Sy8zj != value;
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = !value;
				bool flag4 = flag3;
				if (flag4)
				{
					Dvtdh0bRL5i9duanOvOedNrxe.D6lKBBailJv45eiTaBuR9ZGZb.Remove(this);
					for (int i = 0; i < this.DkmSDgjWzDEGk9LlxfGsyvt1n.Count; i++)
					{
						bool flag5 = this.DkmSDgjWzDEGk9LlxfGsyvt1n[i] == null;
						bool flag6 = !flag5;
						if (flag6)
						{
							try
							{
								this.DkmSDgjWzDEGk9LlxfGsyvt1n[i].D4k1u7qUj150ToIfAvqtwjeWZ();
								global::UnityEngine.Object.Destroy(this.DkmSDgjWzDEGk9LlxfGsyvt1n[i]);
							}
							catch
							{
							}
						}
					}
					this.DkmSDgjWzDEGk9LlxfGsyvt1n.Clear();
				}
				else
				{
					Dvtdh0bRL5i9duanOvOedNrxe.D6lKBBailJv45eiTaBuR9ZGZb.Add(this);
				}
			}
			this.DnKHJ7nbx91rflUgZ0Y1Sy8zj = value;
		}
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x0003AFC8 File Offset: 0x000391C8
	public DwIoOmLGoIyIvOm9z0SHgcarr(string categoryName, string formattedText, DqWv2tAJ8M4UsP9TTlRN9Yax9 refreshAction, DqWv2tAJ8M4UsP9TTlRN9Yax9 drawAction, ValueTuple<Color32, string>[] lineLists, params DybM0vc9ssOBM9irEDd2jwWNG[] options)
	{
		this.DoPWvO0WVOwAUvSnyhJR6OUcc = formattedText;
		this.DqSpUexyUaj9Pigk4vFsBKbrq = categoryName;
		this.DFCShSexFkCl8bbf0IH0bNRLZ = new List<DRTZ0MPdBhZh1V5PmbtgwG0pX>
		{
			new DRTZ0MPdBhZh1V5PmbtgwG0pX(formattedText)
		};
		this.DEegswi3dUjIGqHqtW5pRDUWz = refreshAction;
		this.DEWUrBSzaCIINQ9M4uQ40rTh2 = drawAction;
		this.DTyDRC9cdG8IGn9zMpTt5eaiL = options;
		this.DytdRk0oVzSXoI44WWs8r2oSt = new DSuKLIF35AtXmFdSPtbkEXBdM[lineLists.Length];
		for (int i = 0; i < lineLists.Length; i++)
		{
			this.DytdRk0oVzSXoI44WWs8r2oSt[i] = new DSuKLIF35AtXmFdSPtbkEXBdM(lineLists[i].Item1, lineLists[i].Item2, false);
		}
		this.DPj9pJiOCBkdpbQQpbru7CEN5 = new Material(Shader.Find("Hidden/Internal-Colored"))
		{
			hideFlags = HideFlags.HideAndDontSave,
			color = Color.white
		};
		this.DPj9pJiOCBkdpbQQpbru7CEN5.SetInt("_SrcBlend", 5);
		this.DPj9pJiOCBkdpbQQpbru7CEN5.SetInt("_DstBlend", 10);
		this.DPj9pJiOCBkdpbQQpbru7CEN5.SetInt("_Cull", 0);
		this.DPj9pJiOCBkdpbQQpbru7CEN5.SetInt("_ZWrite", 0);
		this.DPj9pJiOCBkdpbQQpbru7CEN5.SetInt("_ZTest", 0);
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x0003B194 File Offset: 0x00039394
	public void D2SEMg8l3dYQ7jgNctsqltz77(DTQTgBvjhehJ9nKOGQCJPsaGO writer)
	{
		writer.DvmRndmWftv5PwWn9pkcnfpAR(8);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.DnKHJ7nbx91rflUgZ0Y1Sy8zj);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.Dmk5zVuQk0jGUFJWxk9EnD7G9);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.D30iUXR8sxNNzAAzBtRq0xi0n);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.DctnEhAURtzTQjQG5HovyX10f);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.D0VJlj2dXjM6lM16rhlHPeVsM);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.DAJq3CYTvDIFQrH3BffYoksFp);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.DIzjSZiKvyMuCh4R3JSe5Gs7x);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.DaL9kFSE3cYbY6LHeOtuNQDbi);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.DR1UbOEjagrEGWBLZB7U0v8b2);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.DVtjrAY5Cz62UbS0LPV1ZGVzB);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.DJnj0hQt83CIdO8VU5hfm2Svw);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.DSY8h4Odqh4GzyIBRSA0YZwCx);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.DBbuE0zU9gDLa80kNfgXhIB4w);
		writer.DAnd9k0eKEJkMQRg0Qgw4jBGq(this.DNnkDSEpd89rrO8PFsBXenp3A);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.DAvrKLDCvmAu7NRTbchmgnI2B);
		writer.DwTWdG1zkzaGlxDGRH2ahyh0C(this.DJBq8HET3vb5Y6umbwtysjB5v);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.DARar3adCBuubvdP0AmlvE03C);
		writer.DzjcnttV9066oi9WNYph9lY9r(this.D2JTP060dwZSwDD85nvmWwK0A);
		writer.DvmRndmWftv5PwWn9pkcnfpAR((byte)this.DFCShSexFkCl8bbf0IH0bNRLZ.Count);
		foreach (DRTZ0MPdBhZh1V5PmbtgwG0pX drtz0MPdBhZh1V5PmbtgwG0pX in this.DFCShSexFkCl8bbf0IH0bNRLZ)
		{
			writer.DzjcnttV9066oi9WNYph9lY9r(drtz0MPdBhZh1V5PmbtgwG0pX.Dipo7alXhWGyUN5HTO5CUfNnm);
			writer.DzjcnttV9066oi9WNYph9lY9r(drtz0MPdBhZh1V5PmbtgwG0pX.DeV5GjY0k0ZOYYVfX37oYpDZE);
			writer.DGDUglHFhs4KI2tPvrxsuSjzz(drtz0MPdBhZh1V5PmbtgwG0pX.DCxCJp6yyGw68XtIKAu2wuoEn);
			writer.DzjcnttV9066oi9WNYph9lY9r(drtz0MPdBhZh1V5PmbtgwG0pX.D9N2d7gO9JnbsDwXr0pIcoOOf);
			writer.DAnd9k0eKEJkMQRg0Qgw4jBGq(drtz0MPdBhZh1V5PmbtgwG0pX.DJxQE7ww0bdFY31yVKuBrFMXO);
			writer.DlUO1sc1rY9HsqzRwFFbNmM0k(drtz0MPdBhZh1V5PmbtgwG0pX.D6ubYZcOfRdbBHTQPmKwewPMs);
			writer.DvmRndmWftv5PwWn9pkcnfpAR((byte)drtz0MPdBhZh1V5PmbtgwG0pX.DmohNcisfE9XlQBxYIbs4iR1c._enum);
			writer.DzjcnttV9066oi9WNYph9lY9r(drtz0MPdBhZh1V5PmbtgwG0pX.DuK00g4qH3jQKRmilg39vTfHi);
			writer.Drus0Za74WiC3LqWecY3tibut(drtz0MPdBhZh1V5PmbtgwG0pX.Da5g52fxWsEDiZwsDNgSXZYVf.DkJGdJpvFP4j4uWN4CyFixyQ3);
			writer.DzjcnttV9066oi9WNYph9lY9r(drtz0MPdBhZh1V5PmbtgwG0pX.Da5g52fxWsEDiZwsDNgSXZYVf.DBlJ2ATqDOg2Ki1YCFzsbNYu2);
			writer.DwTWdG1zkzaGlxDGRH2ahyh0C(drtz0MPdBhZh1V5PmbtgwG0pX.Dx7ud2LZjVAh5oMukhPNbVcbP);
			writer.DzjcnttV9066oi9WNYph9lY9r(drtz0MPdBhZh1V5PmbtgwG0pX.D2Dz7Uaa1ngijd9u4MUUh6Ewj);
			writer.DwTWdG1zkzaGlxDGRH2ahyh0C(drtz0MPdBhZh1V5PmbtgwG0pX.DSJ0X51xLXKKUUKYvhr16s5IG);
			writer.DwTWdG1zkzaGlxDGRH2ahyh0C(drtz0MPdBhZh1V5PmbtgwG0pX.DZK5LlgvCYoXx5YJxGq2R4UIC);
			writer.DwTWdG1zkzaGlxDGRH2ahyh0C(drtz0MPdBhZh1V5PmbtgwG0pX.DswdRfsVN0euTerbxOJL1tw48);
			writer.DwTWdG1zkzaGlxDGRH2ahyh0C(drtz0MPdBhZh1V5PmbtgwG0pX.D1I0p7yzFiMIXRGqBXSuLvKlV);
			writer.DwTWdG1zkzaGlxDGRH2ahyh0C(drtz0MPdBhZh1V5PmbtgwG0pX.DGpmNFnsk8OWC3s0A9mZGdzff);
		}
		writer.DGDUglHFhs4KI2tPvrxsuSjzz(this.DtECvjV4pdRgipzbc5gFB02hU);
		writer.DvmRndmWftv5PwWn9pkcnfpAR((byte)this.DTyDRC9cdG8IGn9zMpTt5eaiL.Length);
		writer.DvmRndmWftv5PwWn9pkcnfpAR((byte)this.DytdRk0oVzSXoI44WWs8r2oSt.Length);
		byte b = 0;
		while ((int)b < this.DytdRk0oVzSXoI44WWs8r2oSt.Length)
		{
			writer.Drus0Za74WiC3LqWecY3tibut(this.DytdRk0oVzSXoI44WWs8r2oSt[(int)b].DkJGdJpvFP4j4uWN4CyFixyQ3);
			b += 1;
		}
		for (int i = 0; i < this.DTyDRC9cdG8IGn9zMpTt5eaiL.Length; i++)
		{
			this.DTyDRC9cdG8IGn9zMpTt5eaiL[i].Serialize(writer);
		}
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x0003B474 File Offset: 0x00039674
	public void DzWDkDyS4l90nNUmR0KW0x152(DUt0a6FCClF9uncpHt4baoWwu reader)
	{
		byte b = reader.DHk10Sr15Ttt5vv1GYpcpUkoU();
		this.enabled = reader.DugoucznVJ1iWS8iior9p4Yvb();
		this.Dmk5zVuQk0jGUFJWxk9EnD7G9 = reader.DugoucznVJ1iWS8iior9p4Yvb();
		this.D30iUXR8sxNNzAAzBtRq0xi0n = reader.DugoucznVJ1iWS8iior9p4Yvb();
		this.DctnEhAURtzTQjQG5HovyX10f = reader.DugoucznVJ1iWS8iior9p4Yvb();
		bool flag = b >= 3;
		bool flag2 = flag;
		if (flag2)
		{
			this.D0VJlj2dXjM6lM16rhlHPeVsM = reader.DugoucznVJ1iWS8iior9p4Yvb();
			this.DAJq3CYTvDIFQrH3BffYoksFp = reader.DugoucznVJ1iWS8iior9p4Yvb();
			this.DIzjSZiKvyMuCh4R3JSe5Gs7x = reader.DugoucznVJ1iWS8iior9p4Yvb();
			this.DaL9kFSE3cYbY6LHeOtuNQDbi = reader.DugoucznVJ1iWS8iior9p4Yvb();
			this.DR1UbOEjagrEGWBLZB7U0v8b2 = reader.DugoucznVJ1iWS8iior9p4Yvb();
			this.DVtjrAY5Cz62UbS0LPV1ZGVzB = reader.DugoucznVJ1iWS8iior9p4Yvb();
			this.DJnj0hQt83CIdO8VU5hfm2Svw = reader.DugoucznVJ1iWS8iior9p4Yvb();
		}
		this.DSY8h4Odqh4GzyIBRSA0YZwCx = reader.DugoucznVJ1iWS8iior9p4Yvb();
		bool flag3 = b >= 3;
		bool flag4 = flag3;
		if (flag4)
		{
			this.DBbuE0zU9gDLa80kNfgXhIB4w = reader.DugoucznVJ1iWS8iior9p4Yvb();
		}
		this.DNnkDSEpd89rrO8PFsBXenp3A = reader.DpC96gxaM3lOPP0gXfzEgISl5();
		this.DAvrKLDCvmAu7NRTbchmgnI2B = reader.DugoucznVJ1iWS8iior9p4Yvb();
		this.DJBq8HET3vb5Y6umbwtysjB5v = reader.D4A9IMafSh9GwdPdbI0EZOAxx();
		this.DARar3adCBuubvdP0AmlvE03C = reader.DugoucznVJ1iWS8iior9p4Yvb();
		bool flag5 = b >= 8;
		bool flag6 = flag5;
		if (flag6)
		{
			this.D2JTP060dwZSwDD85nvmWwK0A = reader.DugoucznVJ1iWS8iior9p4Yvb();
		}
		bool flag7 = b >= 3;
		bool flag8 = flag7;
		if (flag8)
		{
			this.DFCShSexFkCl8bbf0IH0bNRLZ.Clear();
			byte b2 = reader.DHk10Sr15Ttt5vv1GYpcpUkoU();
			for (byte b3 = 0; b3 < b2; b3 += 1)
			{
				this.DFCShSexFkCl8bbf0IH0bNRLZ.Add(new DRTZ0MPdBhZh1V5PmbtgwG0pX(""));
				this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].Dipo7alXhWGyUN5HTO5CUfNnm = reader.DugoucznVJ1iWS8iior9p4Yvb();
				this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].DeV5GjY0k0ZOYYVfX37oYpDZE = reader.DugoucznVJ1iWS8iior9p4Yvb();
				this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].DCxCJp6yyGw68XtIKAu2wuoEn = reader.DwZMJgiflLxDLkLNV8ljFfb8p();
				this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].D9N2d7gO9JnbsDwXr0pIcoOOf = reader.DugoucznVJ1iWS8iior9p4Yvb();
				this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].DJxQE7ww0bdFY31yVKuBrFMXO = reader.DpC96gxaM3lOPP0gXfzEgISl5();
				this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].D6ubYZcOfRdbBHTQPmKwewPMs = reader.D3tQ8L6WcTtVOztJUYgcXDaCD();
				this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].DmohNcisfE9XlQBxYIbs4iR1c = (DcyOGWtOfXF1Fhr1GWr4wf6Ww)reader.DHk10Sr15Ttt5vv1GYpcpUkoU();
				bool flag9 = b >= 4;
				bool flag10 = flag9;
				if (flag10)
				{
					this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].DuK00g4qH3jQKRmilg39vTfHi = reader.DugoucznVJ1iWS8iior9p4Yvb();
					this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].Da5g52fxWsEDiZwsDNgSXZYVf.settedColor = reader.DAZt0HibzmGVGH7r5UTPXQryY();
					this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].Da5g52fxWsEDiZwsDNgSXZYVf.isGradient = reader.DugoucznVJ1iWS8iior9p4Yvb();
				}
				this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].Dx7ud2LZjVAh5oMukhPNbVcbP = reader.D4A9IMafSh9GwdPdbI0EZOAxx();
				bool flag11 = b >= 5;
				bool flag12 = flag11;
				if (flag12)
				{
					this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].D2Dz7Uaa1ngijd9u4MUUh6Ewj = reader.DugoucznVJ1iWS8iior9p4Yvb();
					this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].DSJ0X51xLXKKUUKYvhr16s5IG = reader.D4A9IMafSh9GwdPdbI0EZOAxx();
					this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].DZK5LlgvCYoXx5YJxGq2R4UIC = reader.D4A9IMafSh9GwdPdbI0EZOAxx();
					this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].DswdRfsVN0euTerbxOJL1tw48 = reader.D4A9IMafSh9GwdPdbI0EZOAxx();
					this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].D1I0p7yzFiMIXRGqBXSuLvKlV = reader.D4A9IMafSh9GwdPdbI0EZOAxx();
				}
				bool flag13 = b >= 7;
				bool flag14 = flag13;
				if (flag14)
				{
					this.DFCShSexFkCl8bbf0IH0bNRLZ[(int)b3].DGpmNFnsk8OWC3s0A9mZGdzff = reader.D4A9IMafSh9GwdPdbI0EZOAxx();
				}
			}
		}
		else
		{
			this.DFCShSexFkCl8bbf0IH0bNRLZ = new List<DRTZ0MPdBhZh1V5PmbtgwG0pX>
			{
				new DRTZ0MPdBhZh1V5PmbtgwG0pX("")
			};
			this.DFCShSexFkCl8bbf0IH0bNRLZ[0].DeV5GjY0k0ZOYYVfX37oYpDZE = reader.DugoucznVJ1iWS8iior9p4Yvb();
			this.DFCShSexFkCl8bbf0IH0bNRLZ[0].DCxCJp6yyGw68XtIKAu2wuoEn = reader.DwZMJgiflLxDLkLNV8ljFfb8p();
			this.DFCShSexFkCl8bbf0IH0bNRLZ[0].D9N2d7gO9JnbsDwXr0pIcoOOf = reader.DugoucznVJ1iWS8iior9p4Yvb();
			this.DFCShSexFkCl8bbf0IH0bNRLZ[0].DJxQE7ww0bdFY31yVKuBrFMXO = reader.DpC96gxaM3lOPP0gXfzEgISl5();
			this.DFCShSexFkCl8bbf0IH0bNRLZ[0].D6ubYZcOfRdbBHTQPmKwewPMs = reader.D3tQ8L6WcTtVOztJUYgcXDaCD();
			this.DFCShSexFkCl8bbf0IH0bNRLZ[0].DmohNcisfE9XlQBxYIbs4iR1c = (DcyOGWtOfXF1Fhr1GWr4wf6Ww)reader.DHk10Sr15Ttt5vv1GYpcpUkoU();
			this.DFCShSexFkCl8bbf0IH0bNRLZ[0].Dx7ud2LZjVAh5oMukhPNbVcbP = reader.D4A9IMafSh9GwdPdbI0EZOAxx();
		}
		bool flag15 = b >= 6;
		bool flag16 = flag15;
		if (flag16)
		{
			string text = reader.DwZMJgiflLxDLkLNV8ljFfb8p();
			this.DtECvjV4pdRgipzbc5gFB02hU = text;
			bool flag17 = !string.IsNullOrEmpty(text);
			bool flag18 = flag17;
			if (flag18)
			{
				this.D0x2CpNPv5G0vo17K1zILyhFc.font = DRiUgFwe1bGGW0FKHIPOjT4PT.DHhYdV8x6Xwu6z0tQ7DGWzWik[text];
				this.Dxn8NngmWnv3B0QlK16ladv8o.font = DRiUgFwe1bGGW0FKHIPOjT4PT.DHhYdV8x6Xwu6z0tQ7DGWzWik[text];
			}
			else
			{
				this.D0x2CpNPv5G0vo17K1zILyhFc.font = DHTB5RKsHUihFrfj9ewuLh1f9.DSqLh3shLXYAnX4d0AcIljoVC.font;
				this.Dxn8NngmWnv3B0QlK16ladv8o.font = DHTB5RKsHUihFrfj9ewuLh1f9.DcCtNCaSVWm57cNorggPJBWVH.font;
			}
		}
		byte b4 = reader.DHk10Sr15Ttt5vv1GYpcpUkoU();
		bool flag19 = b >= 2;
		bool flag20 = flag19;
		if (flag20)
		{
			byte b5 = reader.DHk10Sr15Ttt5vv1GYpcpUkoU();
			byte b6 = 0;
			while ((int)b6 < Mathf.Min((int)b5, this.DytdRk0oVzSXoI44WWs8r2oSt.Length))
			{
				this.DytdRk0oVzSXoI44WWs8r2oSt[(int)b6].settedColor = reader.DAZt0HibzmGVGH7r5UTPXQryY();
				b6 += 1;
			}
		}
		for (int i = 0; i < (int)b4; i++)
		{
			this.DTyDRC9cdG8IGn9zMpTt5eaiL[i].Deserialize(reader);
		}
	}

	// Token: 0x04000417 RID: 1047
	private const byte D7edmA8LNPyJ0kCPOqh1bpPzo = 7;

	// Token: 0x04000418 RID: 1048
	public bool DnKHJ7nbx91rflUgZ0Y1Sy8zj = false;

	// Token: 0x04000419 RID: 1049
	public string DqSpUexyUaj9Pigk4vFsBKbrq;

	// Token: 0x0400041A RID: 1050
	public bool Dmk5zVuQk0jGUFJWxk9EnD7G9 = false;

	// Token: 0x0400041B RID: 1051
	public bool D0VJlj2dXjM6lM16rhlHPeVsM = false;

	// Token: 0x0400041C RID: 1052
	public bool DAJq3CYTvDIFQrH3BffYoksFp = false;

	// Token: 0x0400041D RID: 1053
	public bool DIzjSZiKvyMuCh4R3JSe5Gs7x = false;

	// Token: 0x0400041E RID: 1054
	public bool D30iUXR8sxNNzAAzBtRq0xi0n = true;

	// Token: 0x0400041F RID: 1055
	public bool DaL9kFSE3cYbY6LHeOtuNQDbi = false;

	// Token: 0x04000420 RID: 1056
	public bool DR1UbOEjagrEGWBLZB7U0v8b2 = false;

	// Token: 0x04000421 RID: 1057
	public bool DctnEhAURtzTQjQG5HovyX10f = false;

	// Token: 0x04000422 RID: 1058
	public bool DVtjrAY5Cz62UbS0LPV1ZGVzB = false;

	// Token: 0x04000423 RID: 1059
	public bool DJnj0hQt83CIdO8VU5hfm2Svw = false;

	// Token: 0x04000424 RID: 1060
	public bool D2JTP060dwZSwDD85nvmWwK0A = false;

	// Token: 0x04000425 RID: 1061
	public bool DAvrKLDCvmAu7NRTbchmgnI2B = true;

	// Token: 0x04000426 RID: 1062
	public int DJBq8HET3vb5Y6umbwtysjB5v = 360;

	// Token: 0x04000427 RID: 1063
	public bool DARar3adCBuubvdP0AmlvE03C = true;

	// Token: 0x04000428 RID: 1064
	public List<DRTZ0MPdBhZh1V5PmbtgwG0pX> DFCShSexFkCl8bbf0IH0bNRLZ;

	// Token: 0x04000429 RID: 1065
	public Vector2 DVn0hy9NK3tGPCWaJDSbWNuxl;

	// Token: 0x0400042A RID: 1066
	public bool DSY8h4Odqh4GzyIBRSA0YZwCx = true;

	// Token: 0x0400042B RID: 1067
	public bool DBbuE0zU9gDLa80kNfgXhIB4w = false;

	// Token: 0x0400042C RID: 1068
	public Vector2 DNnkDSEpd89rrO8PFsBXenp3A = new Vector2(0.5f, 1f);

	// Token: 0x0400042D RID: 1069
	public DSuKLIF35AtXmFdSPtbkEXBdM[] DytdRk0oVzSXoI44WWs8r2oSt;

	// Token: 0x0400042E RID: 1070
	public Vector2 DmlRC3nHmar8K91IyoSKPQJHG;

	// Token: 0x0400042F RID: 1071
	public Material DPj9pJiOCBkdpbQQpbru7CEN5;

	// Token: 0x04000430 RID: 1072
	public List<Dg7HgPuhdjH1X6wkz4QJsSTzj> DkmSDgjWzDEGk9LlxfGsyvt1n = new List<Dg7HgPuhdjH1X6wkz4QJsSTzj>();

	// Token: 0x04000431 RID: 1073
	public DybM0vc9ssOBM9irEDd2jwWNG[] DTyDRC9cdG8IGn9zMpTt5eaiL;

	// Token: 0x04000432 RID: 1074
	public DqWv2tAJ8M4UsP9TTlRN9Yax9 DEegswi3dUjIGqHqtW5pRDUWz;

	// Token: 0x04000433 RID: 1075
	public DqWv2tAJ8M4UsP9TTlRN9Yax9 DEWUrBSzaCIINQ9M4uQ40rTh2;

	// Token: 0x04000434 RID: 1076
	public GUIStyle D0x2CpNPv5G0vo17K1zILyhFc;

	// Token: 0x04000435 RID: 1077
	public GUIStyle Dxn8NngmWnv3B0QlK16ladv8o;

	// Token: 0x04000436 RID: 1078
	public string DoPWvO0WVOwAUvSnyhJR6OUcc;

	// Token: 0x04000437 RID: 1079
	public string DtECvjV4pdRgipzbc5gFB02hU = "";
}
