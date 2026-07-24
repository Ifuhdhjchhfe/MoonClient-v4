using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000AB RID: 171
public class DRfaViSbhRReUGGQM34DgBKbE
{
	// Token: 0x06000359 RID: 857 RVA: 0x000310B4 File Offset: 0x0002F2B4
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(EffectManager), "internalSpawnEffect", new Type[]
	{
		typeof(EffectAsset),
		typeof(Vector3),
		typeof(Quaternion),
		typeof(Vector3),
		typeof(bool),
		typeof(Transform)
	})]
	internal static Transform DL6YwlSzyzEou00LyP2ch6bco(EffectAsset asset, Vector3 point, Quaternion rotation, Vector3 scaleMultiplier, bool wasInstigatedByPlayer, Transform parent)
	{
		bool disallowParticles = DfU4wrswBK5kLyiyV6mHZwOg8.disallowParticles;
		bool flag = disallowParticles;
		Transform transform;
		if (flag)
		{
			transform = null;
		}
		else
		{
			transform = DA1dZHkBmPouE1WuakM2TW4QH.DV5fBuuwwtgOKLKyiAmdzlRoa<Transform>(null, new object[] { asset, point, rotation, scaleMultiplier, wasInstigatedByPlayer, parent });
		}
		return transform;
	}
}
