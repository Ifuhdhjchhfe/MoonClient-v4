using System;
using System.Reflection;
using SDG.Unturned;

// Token: 0x02000085 RID: 133
public class DM3X95QSKqqZ7jbMq0u2ou2HG
{
	// Token: 0x06000277 RID: 631 RVA: 0x000255A4 File Offset: 0x000237A4
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(UnturnedLog), "info", new Type[] { typeof(string) })]
	public static void D2lKF1kC3oZHx9UlR3EqQqwLM(string message)
	{
		bool flag = DM3X95QSKqqZ7jbMq0u2ou2HG.DpJlqfrmBalGnb768IVWvvhVp;
		bool flag2 = !flag;
		if (flag2)
		{
			try
			{
				DM3X95QSKqqZ7jbMq0u2ou2HG.DpJlqfrmBalGnb768IVWvvhVp.value = true;
				Logs.printLine(message);
				DovA0560C5xwc06yYBWmht6vA.D7albBMQESa0fbdFJ1bbTI6zK(message);
			}
			finally
			{
				DM3X95QSKqqZ7jbMq0u2ou2HG.DpJlqfrmBalGnb768IVWvvhVp.value = false;
			}
		}
	}

	// Token: 0x06000278 RID: 632 RVA: 0x00025604 File Offset: 0x00023804
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(UnturnedLog), "warn", new Type[] { typeof(string) })]
	public static void DUUviLODM0rCwrC0yVTFkIUmG(string message)
	{
		bool flag = DM3X95QSKqqZ7jbMq0u2ou2HG.DpJlqfrmBalGnb768IVWvvhVp;
		bool flag2 = !flag;
		if (flag2)
		{
			try
			{
				DM3X95QSKqqZ7jbMq0u2ou2HG.DpJlqfrmBalGnb768IVWvvhVp.value = true;
				Logs.printLine(message);
				DovA0560C5xwc06yYBWmht6vA.D7albBMQESa0fbdFJ1bbTI6zK(message);
			}
			finally
			{
				DM3X95QSKqqZ7jbMq0u2ou2HG.DpJlqfrmBalGnb768IVWvvhVp.value = false;
			}
		}
	}

	// Token: 0x06000279 RID: 633 RVA: 0x00025664 File Offset: 0x00023864
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(UnturnedLog), "error", new Type[] { typeof(string) })]
	public static void DBIS3O7zGerjrUL0tTipcT47N(string message)
	{
		bool flag = DM3X95QSKqqZ7jbMq0u2ou2HG.DpJlqfrmBalGnb768IVWvvhVp;
		bool flag2 = !flag;
		if (flag2)
		{
			try
			{
				DM3X95QSKqqZ7jbMq0u2ou2HG.DpJlqfrmBalGnb768IVWvvhVp.value = true;
				Logs.printLine(message);
				CommandWindow.LogError(message);
				DovA0560C5xwc06yYBWmht6vA.D7albBMQESa0fbdFJ1bbTI6zK(message);
			}
			finally
			{
				DM3X95QSKqqZ7jbMq0u2ou2HG.DpJlqfrmBalGnb768IVWvvhVp.value = false;
			}
		}
	}

	// Token: 0x0400030F RID: 783
	public static DGZv08vQyz81zrHxUqhmYuCdY<bool> DpJlqfrmBalGnb768IVWvvhVp = new DGZv08vQyz81zrHxUqhmYuCdY<bool>(typeof(UnturnedLog), "insideLog", BindingFlags.Static | BindingFlags.NonPublic);
}
