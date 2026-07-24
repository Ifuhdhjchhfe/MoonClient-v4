using System;

// Token: 0x02000050 RID: 80
public class DeG0yqZQSzGDZwWhwFA9i61Xy : DDRiSE1kWP2thWXq8UXA03so7
{
	// Token: 0x06000177 RID: 375 RVA: 0x00014D3C File Offset: 0x00012F3C
	public DeG0yqZQSzGDZwWhwFA9i61Xy(string varName, DgUEmivgUF9Zrh6s02llP6xFP valueProvider)
		: base(varName, valueProvider)
	{
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00014D50 File Offset: 0x00012F50
	public override void DrawConfigureTab()
	{
		bool flag = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(this.Dc9AVGsg02CyMxqvf76YVlFHo + ".Reverse()");
		bool flag2 = flag;
		if (flag2)
		{
			this.DRGhJyxOqUMIJmFgfMY8mr3df = DFtqQcs1Do1myIUC3O0JeHmei.Reverse;
		}
		bool flag3 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(this.Dc9AVGsg02CyMxqvf76YVlFHo + "->True");
		bool flag4 = flag3;
		if (flag4)
		{
			this.DRGhJyxOqUMIJmFgfMY8mr3df = DFtqQcs1Do1myIUC3O0JeHmei.True;
		}
		bool flag5 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(this.Dc9AVGsg02CyMxqvf76YVlFHo + "->False");
		bool flag6 = flag5;
		if (flag6)
		{
			this.DRGhJyxOqUMIJmFgfMY8mr3df = DFtqQcs1Do1myIUC3O0JeHmei.False;
		}
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00014DD0 File Offset: 0x00012FD0
	public override string GetOperandValue()
	{
		bool flag = this.DRGhJyxOqUMIJmFgfMY8mr3df == DFtqQcs1Do1myIUC3O0JeHmei.Reverse;
		bool flag2 = flag;
		string text;
		if (flag2)
		{
			text = this.Dc9AVGsg02CyMxqvf76YVlFHo + ".Reverse()";
		}
		else
		{
			text = this.Dc9AVGsg02CyMxqvf76YVlFHo + "->" + this.DRGhJyxOqUMIJmFgfMY8mr3df.ToString();
		}
		return text;
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00014E2C File Offset: 0x0001302C
	public override void Proceed()
	{
		bool flag = this.DRGhJyxOqUMIJmFgfMY8mr3df == DFtqQcs1Do1myIUC3O0JeHmei.True;
		bool flag2 = flag;
		if (flag2)
		{
			this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM(true);
		}
		else
		{
			bool flag3 = this.DRGhJyxOqUMIJmFgfMY8mr3df == DFtqQcs1Do1myIUC3O0JeHmei.False;
			bool flag4 = flag3;
			if (flag4)
			{
				this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM(false);
			}
			else
			{
				this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM(!(bool)this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc());
			}
		}
	}

	// Token: 0x040001D5 RID: 469
	public DFtqQcs1Do1myIUC3O0JeHmei DRGhJyxOqUMIJmFgfMY8mr3df = DFtqQcs1Do1myIUC3O0JeHmei.Reverse;
}
