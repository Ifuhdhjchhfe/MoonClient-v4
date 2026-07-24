using System;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

// Token: 0x020000BF RID: 191
[Serializable]
public class DUt0a6FCClF9uncpHt4baoWwu
{
	// Token: 0x060003BE RID: 958 RVA: 0x00037B2F File Offset: 0x00035D2F
	public DUt0a6FCClF9uncpHt4baoWwu(byte[] data)
	{
		this.DFVrvLBiTy0XjYk0UOx8YGA69 = data;
		this.DgTrevnMqiGTEn0P1JdH0dHcY = 0;
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00037B48 File Offset: 0x00035D48
	~DUt0a6FCClF9uncpHt4baoWwu()
	{
		this.DFVrvLBiTy0XjYk0UOx8YGA69 = new byte[0];
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00037B80 File Offset: 0x00035D80
	public Dw30cL06Z4UqfrhT4M0CDWUeO DUHFIY26cNWkcFf2rIzw1mvxb()
	{
		return (Dw30cL06Z4UqfrhT4M0CDWUeO)this.DHk10Sr15Ttt5vv1GYpcpUkoU();
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00037B98 File Offset: 0x00035D98
	public byte DHk10Sr15Ttt5vv1GYpcpUkoU()
	{
		this.DgTrevnMqiGTEn0P1JdH0dHcY++;
		return this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 1];
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00037BC8 File Offset: 0x00035DC8
	public ushort DmAu4cEiGWLGp7NLhkOyVsRbx()
	{
		this.DgTrevnMqiGTEn0P1JdH0dHcY += 2;
		return BitConverter.ToUInt16(new byte[]
		{
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 2],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 1]
		}, 0);
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x00037C18 File Offset: 0x00035E18
	public int D4A9IMafSh9GwdPdbI0EZOAxx()
	{
		this.DgTrevnMqiGTEn0P1JdH0dHcY += 4;
		return BitConverter.ToInt32(new byte[]
		{
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 4],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 3],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 2],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 1]
		}, 0);
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x00037C8C File Offset: 0x00035E8C
	public float D26dIutcWHq5LifcnZlAGkD0o()
	{
		this.DgTrevnMqiGTEn0P1JdH0dHcY += 4;
		return BitConverter.ToSingle(new byte[]
		{
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 4],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 3],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 2],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 1]
		}, 0);
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00037D00 File Offset: 0x00035F00
	public Color32 DAZt0HibzmGVGH7r5UTPXQryY()
	{
		return new Color32(this.DHk10Sr15Ttt5vv1GYpcpUkoU(), this.DHk10Sr15Ttt5vv1GYpcpUkoU(), this.DHk10Sr15Ttt5vv1GYpcpUkoU(), this.DHk10Sr15Ttt5vv1GYpcpUkoU());
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x00037D30 File Offset: 0x00035F30
	public Color DnCcnTnPw5ZJ82mTIu9h2oX06()
	{
		return new Color((float)this.DHk10Sr15Ttt5vv1GYpcpUkoU() / 255f, (float)this.DHk10Sr15Ttt5vv1GYpcpUkoU() / 255f, (float)this.DHk10Sr15Ttt5vv1GYpcpUkoU() / 255f, (float)this.DHk10Sr15Ttt5vv1GYpcpUkoU() / 255f);
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x00037D7C File Offset: 0x00035F7C
	public Rect DWEsi1RqSBsA0p3ExpLWIEDGu()
	{
		return new Rect(this.D26dIutcWHq5LifcnZlAGkD0o(), this.D26dIutcWHq5LifcnZlAGkD0o(), this.D26dIutcWHq5LifcnZlAGkD0o(), this.D26dIutcWHq5LifcnZlAGkD0o());
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x00037DAC File Offset: 0x00035FAC
	public Vector2 DpC96gxaM3lOPP0gXfzEgISl5()
	{
		return new Vector2(this.D26dIutcWHq5LifcnZlAGkD0o(), this.D26dIutcWHq5LifcnZlAGkD0o());
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00037DD0 File Offset: 0x00035FD0
	public Vector3 D3tQ8L6WcTtVOztJUYgcXDaCD()
	{
		return new Vector3(this.D26dIutcWHq5LifcnZlAGkD0o(), this.D26dIutcWHq5LifcnZlAGkD0o(), this.D26dIutcWHq5LifcnZlAGkD0o());
	}

	// Token: 0x060003CA RID: 970 RVA: 0x00037DFC File Offset: 0x00035FFC
	public byte[] DeSXvmRE6cQJRqrdxy42mpU54()
	{
		byte[] array = new byte[(int)this.DmAu4cEiGWLGp7NLhkOyVsRbx()];
		Array.Copy(this.DFVrvLBiTy0XjYk0UOx8YGA69, this.DgTrevnMqiGTEn0P1JdH0dHcY, array, 0, array.Length);
		this.DgTrevnMqiGTEn0P1JdH0dHcY += array.Length;
		return array;
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00037E44 File Offset: 0x00036044
	public void DWK5emzrMwn3jUFfZ5ElbgFjP(IntPtr ptr)
	{
		ushort num = this.DmAu4cEiGWLGp7NLhkOyVsRbx();
		Marshal.Copy(this.DFVrvLBiTy0XjYk0UOx8YGA69, this.DgTrevnMqiGTEn0P1JdH0dHcY, ptr, (int)num);
		this.DgTrevnMqiGTEn0P1JdH0dHcY += (int)num;
	}

	// Token: 0x060003CC RID: 972 RVA: 0x00037E7C File Offset: 0x0003607C
	public byte[] DbVaR0wGa61aZAA5brKXXsW74(int length)
	{
		byte[] array = new byte[length];
		Array.Copy(this.DFVrvLBiTy0XjYk0UOx8YGA69, this.DgTrevnMqiGTEn0P1JdH0dHcY, array, 0, array.Length);
		this.DgTrevnMqiGTEn0P1JdH0dHcY += array.Length;
		return array;
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00037EC0 File Offset: 0x000360C0
	public uint DoGNbEZaASUhjHNl6fDBJJw3Q()
	{
		this.DgTrevnMqiGTEn0P1JdH0dHcY += 4;
		return BitConverter.ToUInt32(new byte[]
		{
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 4],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 3],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 2],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 1]
		}, 0);
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00037F34 File Offset: 0x00036134
	public ulong DP82wJ7A5EJPwaDAXcpynsH0k()
	{
		this.DgTrevnMqiGTEn0P1JdH0dHcY += 8;
		return BitConverter.ToUInt64(new byte[]
		{
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 8],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 7],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 6],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 5],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 4],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 3],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 2],
			this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 1]
		}, 0);
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00037FF0 File Offset: 0x000361F0
	public string DwZMJgiflLxDLkLNV8ljFfb8p()
	{
		return Encoding.UTF8.GetString(this.DeSXvmRE6cQJRqrdxy42mpU54());
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00038014 File Offset: 0x00036214
	public string DewP0qCzIoNAqbj0vEaIUzklz(int length)
	{
		return Encoding.UTF8.GetString(this.DbVaR0wGa61aZAA5brKXXsW74(length));
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00038038 File Offset: 0x00036238
	public bool DugoucznVJ1iWS8iior9p4Yvb()
	{
		this.DgTrevnMqiGTEn0P1JdH0dHcY++;
		return this.DFVrvLBiTy0XjYk0UOx8YGA69[this.DgTrevnMqiGTEn0P1JdH0dHcY - 1] == 1;
	}

	// Token: 0x040003EA RID: 1002
	public byte[] DFVrvLBiTy0XjYk0UOx8YGA69;

	// Token: 0x040003EB RID: 1003
	public int DgTrevnMqiGTEn0P1JdH0dHcY;
}
