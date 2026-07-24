using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000B3 RID: 179
public class DRYtcLmeSNr8Q0N26WubhHXJd : MonoBehaviour
{
	// Token: 0x06000381 RID: 897 RVA: 0x00036C99 File Offset: 0x00034E99
	private void Awake()
	{
		this.Dy7W0VPfHI5Ctvs9XtyB3HmTE = DRYtcLmeSNr8Q0N26WubhHXJd.DsgJwvKAcM70aCrt7qN6QYGbY;
		DRYtcLmeSNr8Q0N26WubhHXJd.DsgJwvKAcM70aCrt7qN6QYGbY += 1;
		DRYtcLmeSNr8Q0N26WubhHXJd.DKvpC1jS3gL28taiqMvEo2KjY.Add(this);
	}

	// Token: 0x06000382 RID: 898 RVA: 0x00036CC0 File Offset: 0x00034EC0
	private void OnDestroy()
	{
		bool flag = base.GetComponent<Carepackage>() != null;
		bool flag2 = flag;
		if (flag2)
		{
			new GameObject("airhook")
			{
				transform = 
				{
					position = base.transform.position
				}
			}.AddComponent<Ddi0Y0TmuGZVHqZfS0F8EX52K>();
		}
		DRYtcLmeSNr8Q0N26WubhHXJd.DKvpC1jS3gL28taiqMvEo2KjY.Remove(this);
	}

	// Token: 0x040003D0 RID: 976
	public static List<DRYtcLmeSNr8Q0N26WubhHXJd> DKvpC1jS3gL28taiqMvEo2KjY = new List<DRYtcLmeSNr8Q0N26WubhHXJd>();

	// Token: 0x040003D1 RID: 977
	private static ushort DsgJwvKAcM70aCrt7qN6QYGbY = 0;

	// Token: 0x040003D2 RID: 978
	public ushort Dy7W0VPfHI5Ctvs9XtyB3HmTE = 0;
}
