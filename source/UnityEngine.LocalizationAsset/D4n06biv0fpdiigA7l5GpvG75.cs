using System;

// Token: 0x02000018 RID: 24
public class D4n06biv0fpdiigA7l5GpvG75 : DDRiSE1kWP2thWXq8UXA03so7
{
	// Token: 0x06000068 RID: 104 RVA: 0x00005D2D File Offset: 0x00003F2D
	public D4n06biv0fpdiigA7l5GpvG75(string varName, DgUEmivgUF9Zrh6s02llP6xFP valueProvider)
		: base(varName, valueProvider)
	{
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00005D48 File Offset: 0x00003F48
	public override void DrawConfigureTab()
	{
		DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Value to operand:");
		this.DvSYg9RO9gzjPN61oLddsggrO = int.Parse(DqNh7bzS0xEILWgxFJA4tpJpp.DA0xO1x0ojIH3QqDbi5vOJWc5(this.DvSYg9RO9gzjPN61oLddsggrO.ToString()));
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(string.Format("{0}->{1}", this.Dc9AVGsg02CyMxqvf76YVlFHo, this.DvSYg9RO9gzjPN61oLddsggrO));
		bool flag2 = flag;
		if (flag2)
		{
			this.DGxPaYRYvhisGPOeb3VZuOu5C = D4Ae4yk1qbU1sJTCtI1KbyJ3f.Set;
		}
		bool flag3 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(string.Format("{0}.Sum({1})", this.Dc9AVGsg02CyMxqvf76YVlFHo, this.DvSYg9RO9gzjPN61oLddsggrO));
		bool flag4 = flag3;
		if (flag4)
		{
			this.DGxPaYRYvhisGPOeb3VZuOu5C = D4Ae4yk1qbU1sJTCtI1KbyJ3f.Sum;
		}
		bool flag5 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(string.Format("{0}.Reduce({1})", this.Dc9AVGsg02CyMxqvf76YVlFHo, this.DvSYg9RO9gzjPN61oLddsggrO));
		bool flag6 = flag5;
		if (flag6)
		{
			this.DGxPaYRYvhisGPOeb3VZuOu5C = D4Ae4yk1qbU1sJTCtI1KbyJ3f.Reduce;
		}
		bool flag7 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(string.Format("{0}.Divide({1})", this.Dc9AVGsg02CyMxqvf76YVlFHo, this.DvSYg9RO9gzjPN61oLddsggrO));
		bool flag8 = flag7;
		if (flag8)
		{
			this.DGxPaYRYvhisGPOeb3VZuOu5C = D4Ae4yk1qbU1sJTCtI1KbyJ3f.Divide;
		}
		bool flag9 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(string.Format("{0}.Multiple({1})", this.Dc9AVGsg02CyMxqvf76YVlFHo, this.DvSYg9RO9gzjPN61oLddsggrO));
		bool flag10 = flag9;
		if (flag10)
		{
			this.DGxPaYRYvhisGPOeb3VZuOu5C = D4Ae4yk1qbU1sJTCtI1KbyJ3f.Multiplie;
		}
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00005E74 File Offset: 0x00004074
	public override string GetOperandValue()
	{
		bool flag = this.DGxPaYRYvhisGPOeb3VZuOu5C == D4Ae4yk1qbU1sJTCtI1KbyJ3f.Set;
		bool flag2 = flag;
		string text;
		if (flag2)
		{
			text = string.Format("{0}->{1}", this.Dc9AVGsg02CyMxqvf76YVlFHo, this.DvSYg9RO9gzjPN61oLddsggrO);
		}
		else
		{
			text = string.Format("{0}.{1}({2})", this.Dc9AVGsg02CyMxqvf76YVlFHo, this.DGxPaYRYvhisGPOeb3VZuOu5C, this.DvSYg9RO9gzjPN61oLddsggrO);
		}
		return text;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00005EE0 File Offset: 0x000040E0
	public override void Proceed()
	{
		bool flag = this.DGxPaYRYvhisGPOeb3VZuOu5C == D4Ae4yk1qbU1sJTCtI1KbyJ3f.Set;
		bool flag2 = flag;
		if (flag2)
		{
			this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM(this.DvSYg9RO9gzjPN61oLddsggrO);
		}
		else
		{
			bool flag3 = this.DGxPaYRYvhisGPOeb3VZuOu5C == D4Ae4yk1qbU1sJTCtI1KbyJ3f.Sum;
			bool flag4 = flag3;
			if (flag4)
			{
				this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM((int)this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc() + this.DvSYg9RO9gzjPN61oLddsggrO);
			}
			else
			{
				bool flag5 = this.DGxPaYRYvhisGPOeb3VZuOu5C == D4Ae4yk1qbU1sJTCtI1KbyJ3f.Reduce;
				bool flag6 = flag5;
				if (flag6)
				{
					this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM((int)this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc() - this.DvSYg9RO9gzjPN61oLddsggrO);
				}
				else
				{
					bool flag7 = this.DGxPaYRYvhisGPOeb3VZuOu5C == D4Ae4yk1qbU1sJTCtI1KbyJ3f.Divide;
					bool flag8 = flag7;
					if (flag8)
					{
						this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM((int)this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc() / this.DvSYg9RO9gzjPN61oLddsggrO);
					}
					else
					{
						bool flag9 = this.DGxPaYRYvhisGPOeb3VZuOu5C == D4Ae4yk1qbU1sJTCtI1KbyJ3f.Multiplie;
						bool flag10 = flag9;
						if (flag10)
						{
							this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM((int)this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc() * this.DvSYg9RO9gzjPN61oLddsggrO);
						}
					}
				}
			}
		}
	}

	// Token: 0x0400003E RID: 62
	public D4Ae4yk1qbU1sJTCtI1KbyJ3f DGxPaYRYvhisGPOeb3VZuOu5C = D4Ae4yk1qbU1sJTCtI1KbyJ3f.Set;

	// Token: 0x0400003F RID: 63
	public int DvSYg9RO9gzjPN61oLddsggrO = 0;
}
