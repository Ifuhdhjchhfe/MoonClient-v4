using System;
using UnityEngine;

// Token: 0x02000025 RID: 37
public class D8RNjZL0DHRKCDooaHk3bqIVI : DOEkZ1zoBEuvfUmOs9QSpfX0X
{
	// Token: 0x060000A7 RID: 167 RVA: 0x0000871C File Offset: 0x0000691C
	public override string GetName()
	{
		return "Overrides";
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00008734 File Offset: 0x00006934
	public override DYIPJORHeVCfbpocFHvJty4OE GetTabCounts()
	{
		return DYIPJORHeVCfbpocFHvJty4OE.One;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00008748 File Offset: 0x00006948
	public override void DoTab(DYIPJORHeVCfbpocFHvJty4OE tc)
	{
		try
		{
			GUILayout.Label("Displays only successfull overides, so you can disable only workable overrides", Array.Empty<GUILayoutOption>());
			this.DoOtbWuyRk1i0cTlm1fJnCQ0M = GUILayout.BeginScrollView(this.DoOtbWuyRk1i0cTlm1fJnCQ0M, Array.Empty<GUILayoutOption>());
			foreach (D9Tzj1SkWAoyZl0owsCmbQM3M d9Tzj1SkWAoyZl0owsCmbQM3M in DA1dZHkBmPouE1WuakM2TW4QH.DAbb78SP9e45DxByspkgZhgQZ.Values)
			{
				string text = d9Tzj1SkWAoyZl0owsCmbQM3M.DzCVnnM8yCzxGHvUi1flI3Eyv.DeclaringType.Name + "." + d9Tzj1SkWAoyZl0owsCmbQM3M.DzCVnnM8yCzxGHvUi1flI3Eyv.Name;
				bool flag = !(text == "File.InternalWriteAllBytes") && !(text == "Type.GetFields") && !(text == "Type.GetTypes") && !(text == "MethodBase.GetMethodBody") && DrysTRTjdLdFqu5GJBDif6AoV.DVkWLbfI0YmUX0p9Ex8l2OuXv((d9Tzj1SkWAoyZl0owsCmbQM3M.DslkeUnnABbJwjQrJAIPWkhOS ? "[Overrided] " : "[Reverted] ") + text, -1, true, null);
				if (flag)
				{
					bool dslkeUnnABbJwjQrJAIPWkhOS = d9Tzj1SkWAoyZl0owsCmbQM3M.DslkeUnnABbJwjQrJAIPWkhOS;
					if (dslkeUnnABbJwjQrJAIPWkhOS)
					{
						d9Tzj1SkWAoyZl0owsCmbQM3M.D0KXuUYPpRii5N7p0sVOu7eK9();
					}
					else
					{
						d9Tzj1SkWAoyZl0owsCmbQM3M.DEz4GruecNL42mD0UmFBxiEs0();
					}
				}
			}
			GUILayout.EndScrollView();
		}
		catch
		{
		}
	}

	// Token: 0x040000DB RID: 219
	public Vector2 DoOtbWuyRk1i0cTlm1fJnCQ0M = Vector2.zero;
}
