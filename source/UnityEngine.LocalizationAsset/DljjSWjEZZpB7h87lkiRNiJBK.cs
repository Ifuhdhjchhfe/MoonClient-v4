using System;

// Token: 0x02000081 RID: 129
public static class DljjSWjEZZpB7h87lkiRNiJBK
{
	// Token: 0x0600026D RID: 621 RVA: 0x000252D0 File Offset: 0x000234D0
	public static object DmJ0X6k0mQJUdkXmd9U0rLyg3(object src)
	{
		Array values = Enum.GetValues(src.GetType());
		int num = Array.IndexOf(values, src) + 1;
		return (values.Length == num) ? values.GetValue(0) : values.GetValue(num);
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00025314 File Offset: 0x00023514
	public static object D83IhlJRvi7w1q5WPsWiAYd6S(object src)
	{
		Array values = Enum.GetValues(src.GetType());
		int num = Array.IndexOf(values, src) - 1;
		return (0 > num) ? values.GetValue(values.Length - 1) : values.GetValue(num);
	}
}
