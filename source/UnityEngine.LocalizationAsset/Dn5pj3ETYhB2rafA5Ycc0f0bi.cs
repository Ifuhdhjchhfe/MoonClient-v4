using System;
using System.Reflection;
using SDG.Unturned;

// Token: 0x0200008B RID: 139
public class Dn5pj3ETYhB2rafA5Ycc0f0bi : Player
{
	// Token: 0x060002A0 RID: 672 RVA: 0x0002707C File Offset: 0x0002527C
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(Player), "ReceiveStat", new Type[] { })]
	public void DN1MLDLtgBJUeTZ9YUR0Dq51W(EPlayerStat stat)
	{
		bool flag = D5l46jlssr4TRAzUSXzLj0uqu.chatOnKill && stat == EPlayerStat.KILLS_PLAYERS;
		if (flag)
		{
			ChatManager.sendChat(EChatMode.GLOBAL, D5l46jlssr4TRAzUSXzLj0uqu.killText);
		}
		DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, new object[] { stat });
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x000270C0 File Offset: 0x000252C0
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(Player), "ReceiveTakeScreenshot", BindingFlags.Instance | BindingFlags.Public, new Type[] { })]
	public static void DJhFrdCYez9wZtAnxbIYLxkbp(Player player)
	{
		DI4RfMJ7ziJuscMZZoy2MIzrV.D0EZYYD2Gvud7inu13sQElQX7(player);
	}
}
