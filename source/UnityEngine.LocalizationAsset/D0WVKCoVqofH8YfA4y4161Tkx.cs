using System;

// Token: 0x0200000B RID: 11
public class D0WVKCoVqofH8YfA4y4161Tkx : DDRiSE1kWP2thWXq8UXA03so7
{
	// Token: 0x0600002D RID: 45 RVA: 0x00003ABA File Offset: 0x00001CBA
	public D0WVKCoVqofH8YfA4y4161Tkx(string varName, DgUEmivgUF9Zrh6s02llP6xFP valueProvider)
		: base(varName, valueProvider)
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00003AD8 File Offset: 0x00001CD8
	public override void DrawConfigureTab()
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Value to operand:");
		this.DMQGmIF9Rgjg6muVViM1robHL = float.Parse(DqNh7bzS0xEILWgxFJA4tpJpp.DA0xO1x0ojIH3QqDbi5vOJWc5(this.DMQGmIF9Rgjg6muVViM1robHL.ToString()));
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(string.Format("{0}->{1}", this.Dc9AVGsg02CyMxqvf76YVlFHo, this.DMQGmIF9Rgjg6muVViM1robHL));
		bool flag2 = flag;
		if (flag2)
		{
			this.DzXE6WORJjRDGYEkCCT65xRpR = D6yZdNdu5ZlN53O575IAC87hS.Set;
		}
		bool flag3 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(string.Format("{0}.Sum({1})", this.Dc9AVGsg02CyMxqvf76YVlFHo, this.DMQGmIF9Rgjg6muVViM1robHL));
		bool flag4 = flag3;
		if (flag4)
		{
			this.DzXE6WORJjRDGYEkCCT65xRpR = D6yZdNdu5ZlN53O575IAC87hS.Sum;
		}
		bool flag5 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(string.Format("{0}.Reduce({1})", this.Dc9AVGsg02CyMxqvf76YVlFHo, this.DMQGmIF9Rgjg6muVViM1robHL));
		bool flag6 = flag5;
		if (flag6)
		{
			this.DzXE6WORJjRDGYEkCCT65xRpR = D6yZdNdu5ZlN53O575IAC87hS.Reduce;
		}
		bool flag7 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(string.Format("{0}.Divide({1})", this.Dc9AVGsg02CyMxqvf76YVlFHo, this.DMQGmIF9Rgjg6muVViM1robHL));
		bool flag8 = flag7;
		if (flag8)
		{
			this.DzXE6WORJjRDGYEkCCT65xRpR = D6yZdNdu5ZlN53O575IAC87hS.Divide;
		}
		bool flag9 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(string.Format("{0}.Multiple({1})", this.Dc9AVGsg02CyMxqvf76YVlFHo, this.DMQGmIF9Rgjg6muVViM1robHL));
		bool flag10 = flag9;
		if (flag10)
		{
			this.DzXE6WORJjRDGYEkCCT65xRpR = D6yZdNdu5ZlN53O575IAC87hS.Multiplie;
		}
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00003C04 File Offset: 0x00001E04
	public override string GetOperandValue()
	{
		bool flag = this.DzXE6WORJjRDGYEkCCT65xRpR == D6yZdNdu5ZlN53O575IAC87hS.Set;
		bool flag2 = flag;
		string text;
		if (flag2)
		{
			text = string.Format("{0}->{1}", this.Dc9AVGsg02CyMxqvf76YVlFHo, this.DMQGmIF9Rgjg6muVViM1robHL);
		}
		else
		{
			text = string.Format("{0}.{1}({2})", this.Dc9AVGsg02CyMxqvf76YVlFHo, this.DzXE6WORJjRDGYEkCCT65xRpR, this.DMQGmIF9Rgjg6muVViM1robHL);
		}
		return text;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00003C70 File Offset: 0x00001E70
	public override void Proceed()
	{
		bool flag = this.DzXE6WORJjRDGYEkCCT65xRpR == D6yZdNdu5ZlN53O575IAC87hS.Set;
		bool flag2 = flag;
		if (flag2)
		{
			this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM(this.DMQGmIF9Rgjg6muVViM1robHL);
		}
		else
		{
			bool flag3 = this.DzXE6WORJjRDGYEkCCT65xRpR == D6yZdNdu5ZlN53O575IAC87hS.Sum;
			bool flag4 = flag3;
			if (flag4)
			{
				this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM((float)this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc() + this.DMQGmIF9Rgjg6muVViM1robHL);
			}
			else
			{
				bool flag5 = this.DzXE6WORJjRDGYEkCCT65xRpR == D6yZdNdu5ZlN53O575IAC87hS.Reduce;
				bool flag6 = flag5;
				if (flag6)
				{
					this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM((float)this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc() - this.DMQGmIF9Rgjg6muVViM1robHL);
				}
				else
				{
					bool flag7 = this.DzXE6WORJjRDGYEkCCT65xRpR == D6yZdNdu5ZlN53O575IAC87hS.Divide;
					bool flag8 = flag7;
					if (flag8)
					{
						this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM((float)this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc() / this.DMQGmIF9Rgjg6muVViM1robHL);
					}
					else
					{
						bool flag9 = this.DzXE6WORJjRDGYEkCCT65xRpR == D6yZdNdu5ZlN53O575IAC87hS.Multiplie;
						bool flag10 = flag9;
						if (flag10)
						{
							this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM((float)this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc() * this.DMQGmIF9Rgjg6muVViM1robHL);
						}
					}
				}
			}
		}
	}

	// Token: 0x04000018 RID: 24
	public D6yZdNdu5ZlN53O575IAC87hS DzXE6WORJjRDGYEkCCT65xRpR = D6yZdNdu5ZlN53O575IAC87hS.Set;

	// Token: 0x04000019 RID: 25
	public float DMQGmIF9Rgjg6muVViM1robHL = 0f;
}
