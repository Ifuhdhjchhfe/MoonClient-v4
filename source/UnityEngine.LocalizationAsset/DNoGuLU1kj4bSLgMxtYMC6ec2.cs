using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000090 RID: 144
public static class DNoGuLU1kj4bSLgMxtYMC6ec2
{
	// Token: 0x060002BB RID: 699 RVA: 0x00028CD4 File Offset: 0x00026ED4
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(RandomEx), "GetRandomForwardVectorInCone", new Type[] { })]
	public static Vector3 DM04jC5Ob7xBV8mkIjo7bHLy2(float halfAngleRadians)
	{
		halfAngleRadians *= D5l46jlssr4TRAzUSXzLj0uqu.spreadMultiplier;
		halfAngleRadians = Mathf.Min(halfAngleRadians, 1.5697963f);
		float num = Mathf.Sin(halfAngleRadians * Mathf.Sqrt(global::UnityEngine.Random.value));
		float num2 = 6.2831855f * global::UnityEngine.Random.value;
		float num3 = Mathf.Cos(num2);
		float num4 = Mathf.Sin(num2);
		float num5 = num3 * num;
		float num6 = num4 * num;
		float num7 = Mathf.Sqrt(1f - num5 * num5 - num6 * num6);
		return new Vector3(num5, num6, num7);
	}
}
