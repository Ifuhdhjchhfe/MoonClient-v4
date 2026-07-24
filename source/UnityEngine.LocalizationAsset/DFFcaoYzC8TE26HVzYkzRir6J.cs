using System;

// Token: 0x02000055 RID: 85
public class DFFcaoYzC8TE26HVzYkzRir6J : DDRiSE1kWP2thWXq8UXA03so7
{
	// Token: 0x0600018B RID: 395 RVA: 0x0001606D File Offset: 0x0001426D
	public DFFcaoYzC8TE26HVzYkzRir6J(string varName, DgUEmivgUF9Zrh6s02llP6xFP valueProvider)
		: base(varName, valueProvider)
	{
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00016088 File Offset: 0x00014288
	public override void DrawConfigureTab()
	{
		Array values = Enum.GetValues(this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc().GetType());
		bool flag = this.DoYAvQ7Twbd6kvvdW7mUXh402 == DkiTethqvPCo0YhLCXzFdFzxL.Set && DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF("Operand to set: " + values.GetValue((int)this.DIYQf5O8DljaTMicEffpFsSQb).ToString());
		bool flag2 = flag;
		if (flag2)
		{
			this.DIYQf5O8DljaTMicEffpFsSQb = (byte)(((int)(this.DIYQf5O8DljaTMicEffpFsSQb + 1) == values.Length) ? 0 : (this.DIYQf5O8DljaTMicEffpFsSQb + 1));
		}
		bool flag3 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(this.Dc9AVGsg02CyMxqvf76YVlFHo + "->" + values.GetValue((int)this.DIYQf5O8DljaTMicEffpFsSQb).ToString());
		bool flag4 = flag3;
		if (flag4)
		{
			this.DoYAvQ7Twbd6kvvdW7mUXh402 = DkiTethqvPCo0YhLCXzFdFzxL.Set;
		}
		bool flag5 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(this.Dc9AVGsg02CyMxqvf76YVlFHo + ".Next()");
		bool flag6 = flag5;
		if (flag6)
		{
			this.DoYAvQ7Twbd6kvvdW7mUXh402 = DkiTethqvPCo0YhLCXzFdFzxL.Next;
		}
		bool flag7 = DqNh7bzS0xEILWgxFJA4tpJpp.DFAkpq47gdavJUYRkR3I29anF(this.Dc9AVGsg02CyMxqvf76YVlFHo + ".Back()");
		bool flag8 = flag7;
		if (flag8)
		{
			this.DoYAvQ7Twbd6kvvdW7mUXh402 = DkiTethqvPCo0YhLCXzFdFzxL.Back;
		}
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00016188 File Offset: 0x00014388
	public override string GetOperandValue()
	{
		bool flag = this.DoYAvQ7Twbd6kvvdW7mUXh402 == DkiTethqvPCo0YhLCXzFdFzxL.Next;
		bool flag2 = flag;
		string text;
		if (flag2)
		{
			text = DljjSWjEZZpB7h87lkiRNiJBK.DmJ0X6k0mQJUdkXmd9U0rLyg3(this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc()).ToString() + ".Next()";
		}
		else
		{
			bool flag3 = this.DoYAvQ7Twbd6kvvdW7mUXh402 == DkiTethqvPCo0YhLCXzFdFzxL.Back;
			bool flag4 = flag3;
			if (flag4)
			{
				text = DljjSWjEZZpB7h87lkiRNiJBK.D83IhlJRvi7w1q5WPsWiAYd6S(this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc()).ToString() + ".Back()";
			}
			else
			{
				Array values = Enum.GetValues(this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc().GetType());
				text = this.Dc9AVGsg02CyMxqvf76YVlFHo + "->" + values.GetValue((int)this.DIYQf5O8DljaTMicEffpFsSQb).ToString();
			}
		}
		return text;
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00016244 File Offset: 0x00014444
	public override void Proceed()
	{
		bool flag = this.DoYAvQ7Twbd6kvvdW7mUXh402 == DkiTethqvPCo0YhLCXzFdFzxL.Next;
		bool flag2 = flag;
		if (flag2)
		{
			this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM(DljjSWjEZZpB7h87lkiRNiJBK.DmJ0X6k0mQJUdkXmd9U0rLyg3(this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc()));
		}
		else
		{
			bool flag3 = this.DoYAvQ7Twbd6kvvdW7mUXh402 == DkiTethqvPCo0YhLCXzFdFzxL.Back;
			bool flag4 = flag3;
			if (flag4)
			{
				this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM(DljjSWjEZZpB7h87lkiRNiJBK.D83IhlJRvi7w1q5WPsWiAYd6S(this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc()));
			}
			else
			{
				Array values = Enum.GetValues(this.DMIzP1JTKERTaeV1ECjBMeiJL.Dy14zRPGLPsFa96EuljDSW8Gc().GetType());
				this.DMIzP1JTKERTaeV1ECjBMeiJL.DcNI3NtdStOdpOlK0ELyaRxHM(values.GetValue((int)this.DIYQf5O8DljaTMicEffpFsSQb));
			}
		}
	}

	// Token: 0x040001E4 RID: 484
	public DkiTethqvPCo0YhLCXzFdFzxL DoYAvQ7Twbd6kvvdW7mUXh402 = DkiTethqvPCo0YhLCXzFdFzxL.Set;

	// Token: 0x040001E5 RID: 485
	public byte DIYQf5O8DljaTMicEffpFsSQb = 0;
}
