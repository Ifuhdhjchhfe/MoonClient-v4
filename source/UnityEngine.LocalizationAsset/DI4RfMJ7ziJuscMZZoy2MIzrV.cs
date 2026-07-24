using System;
using System.Collections;
using System.Reflection;
using SDG.NetPak;
using SDG.NetTransport;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000070 RID: 112
public static class DI4RfMJ7ziJuscMZZoy2MIzrV
{
	// Token: 0x0600022B RID: 555 RVA: 0x0001FD9C File Offset: 0x0001DF9C
	public static void D0EZYYD2Gvud7inu13sQElQX7(Player p)
	{
		bool flag = D5l46jlssr4TRAzUSXzLj0uqu.spyType == DEaNNGRxJag20zwKVRmcuyQsU.DontOverride;
		if (flag)
		{
			DA1dZHkBmPouE1WuakM2TW4QH.D2cRvNT26jwbsIz7pRTVg5cuE(typeof(Dn5pj3ETYhB2rafA5Ycc0f0bi).GetMethod("ReceiveTakeScreenshot"), p, Array.Empty<object>());
		}
		else
		{
			DTm52FQgIZyHlgsIe52RDqzcZ.Dsl47nk11Gy8UerLdkoyZgICJ(DI4RfMJ7ziJuscMZZoy2MIzrV.DEkKzjqxGuxIyUIm0HRt7F1o1(p));
		}
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0001FDE5 File Offset: 0x0001DFE5
	public static IEnumerator DEkKzjqxGuxIyUIm0HRt7F1o1(Player p)
	{
		yield return null;
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0001FDF4 File Offset: 0x0001DFF4
	public static void Dxz0NPlpL0nXWGapkFTlB7aP5(Player p, byte[] image)
	{
		bool flag = image.Length < 30000;
		if (flag)
		{
			bool isServer = Provider.isServer;
			if (isServer)
			{
				DI4RfMJ7ziJuscMZZoy2MIzrV.Dv4kcxipobz185UtCOIG1ckby.DGHrF0Ht2QRxL0NBgNHj6ZpZX(p, new object[] { image });
			}
			else
			{
				DI4RfMJ7ziJuscMZZoy2MIzrV.SendScreenshotRelay.Invoke(p.GetNetId(), ENetReliability.Reliable, delegate(NetPakWriter writer)
				{
					ushort num = (ushort)image.Length;
					writer.WriteUInt16(num);
					writer.WriteBytes(image, (int)num);
				});
			}
		}
	}

	// Token: 0x040002C2 RID: 706
	public static bool DBJV74arVJtUMAqsSN0cWr9w6 = false;

	// Token: 0x040002C3 RID: 707
	public static DIDzNgrvnOa5xIZrJtz5ZO48o De2hBwLmnyYClZ9fwAmbPOhqc;

	// Token: 0x040002C4 RID: 708
	public static DIDzNgrvnOa5xIZrJtz5ZO48o DU6EO20XNycI0rg03jSyQr0k6;

	// Token: 0x040002C5 RID: 709
	private static bool DAqesfhglzs5rswmenSgl0E2P = false;

	// Token: 0x040002C6 RID: 710
	private static byte Db5KZlrScW4ixes1xRZGW4ptg = 0;

	// Token: 0x040002C7 RID: 711
	public static float DSg3kbDAJsc0hSCt25O0Jas3q = 0f;

	// Token: 0x040002C8 RID: 712
	private static Texture2D DTfAnzMJNkCpaSfuSkXhlmJru;

	// Token: 0x040002C9 RID: 713
	public static Texture2D DIhV7K2mHRLxB8hrKabx7EYI9;

	// Token: 0x040002CA RID: 714
	private static DQyA1nzDa0rZuYtgcLmIWOUf8 Dv4kcxipobz185UtCOIG1ckby = new DQyA1nzDa0rZuYtgcLmIWOUf8(typeof(Player), "HandleScreenshotData", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x040002CB RID: 715
	private static readonly ServerInstanceMethod SendScreenshotRelay = ServerInstanceMethod.Get(typeof(Player), "ReceiveScreenshotRelay");
}
