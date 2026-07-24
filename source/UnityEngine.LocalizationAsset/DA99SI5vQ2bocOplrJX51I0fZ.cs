using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200002B RID: 43
public class DA99SI5vQ2bocOplrJX51I0fZ : MonoBehaviour
{
	// Token: 0x060000C2 RID: 194 RVA: 0x00009138 File Offset: 0x00007338
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DnZ5sfgWYbdbAqTuRWYLamJGw()
	{
		Provider.onClientDisconnected = (Provider.ClientDisconnected)Delegate.Combine(Provider.onClientDisconnected, new Provider.ClientDisconnected(delegate
		{
			DA99SI5vQ2bocOplrJX51I0fZ.DjtxfhaKbxGwHbQRcC0h27L6t = 0;
		}));
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00009170 File Offset: 0x00007370
	private void Update()
	{
		this.DmLKxv8evBsLCW0cqlpgRZojy += Time.deltaTime;
		this.DcvMyeNI42INLfaM3P7XYoZnV += 1;
		bool flag = this.DmLKxv8evBsLCW0cqlpgRZojy > 1f;
		bool flag2 = flag;
		if (flag2)
		{
			DA99SI5vQ2bocOplrJX51I0fZ.DfXGp5saXCGNsfyCyrfp7YByx = this.DcvMyeNI42INLfaM3P7XYoZnV;
			this.DcvMyeNI42INLfaM3P7XYoZnV = 0;
			this.DmLKxv8evBsLCW0cqlpgRZojy -= 1f;
			bool flag3 = Provider.isConnected && Player.player != null;
			bool flag4 = flag3;
			if (flag4)
			{
				DA99SI5vQ2bocOplrJX51I0fZ.DjtxfhaKbxGwHbQRcC0h27L6t += 1;
			}
		}
	}

	// Token: 0x040000EE RID: 238
	public static byte DfXGp5saXCGNsfyCyrfp7YByx;

	// Token: 0x040000EF RID: 239
	public static ushort DjtxfhaKbxGwHbQRcC0h27L6t;

	// Token: 0x040000F0 RID: 240
	private byte DcvMyeNI42INLfaM3P7XYoZnV = 0;

	// Token: 0x040000F1 RID: 241
	private float DmLKxv8evBsLCW0cqlpgRZojy = 0f;
}
