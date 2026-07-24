using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x02000097 RID: 151
public static class DoLw5vYd2Gq0BYuUfcIXuj4Vo
{
	// Token: 0x060002E0 RID: 736 RVA: 0x00029F63 File Offset: 0x00028163
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DVG6e4oTsICVTrGFwqGCJHFxh()
	{
		DoLw5vYd2Gq0BYuUfcIXuj4Vo.DJCB8nFq4AlMkcvaCk3iazVNC();
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x00029F6C File Offset: 0x0002816C
	public static void DyG23mGej0mSGFU2U84sGnFdR()
	{
		DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY = DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY.OrderBy<DaqXfD9Fjc9IG7oF0OAH4hEOR, float>((DaqXfD9Fjc9IG7oF0OAH4hEOR so) => so.DFB9pSE2QrWJVKlgzNeEboOFV).ToList<DaqXfD9Fjc9IG7oF0OAH4hEOR>();
		DoLw5vYd2Gq0BYuUfcIXuj4Vo.DJCB8nFq4AlMkcvaCk3iazVNC();
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00029FA8 File Offset: 0x000281A8
	public static void DJCB8nFq4AlMkcvaCk3iazVNC()
	{
		DCS4Jf0LRzsehKFc5QOLL06qw.Db55lznlFok53zZBv0jDuw4gi = 0f;
		Vector3[][] array = new Vector3[DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY.Count][];
		int num = 0;
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = DoLw5vYd2Gq0BYuUfcIXuj4Vo.DSdXSqhwR7EQmNpyBQ0fWuzR4(DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY[i].DeBQaoNESDqUn4pQ12mM1Ic7r, DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY[i].DFB9pSE2QrWJVKlgzNeEboOFV);
			num += (DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY[i].DeBQaoNESDqUn4pQ12mM1Ic7r + 1) * (DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY[i].DeBQaoNESDqUn4pQ12mM1Ic7r + 1);
			DCS4Jf0LRzsehKFc5QOLL06qw.Db55lznlFok53zZBv0jDuw4gi = Mathf.Max(DCS4Jf0LRzsehKFc5QOLL06qw.Db55lznlFok53zZBv0jDuw4gi, DCS4Jf0LRzsehKFc5QOLL06qw.DktrbPy2H7CKo1hvmcfRd62lY[i].DFB9pSE2QrWJVKlgzNeEboOFV);
		}
		DoLw5vYd2Gq0BYuUfcIXuj4Vo.DfCAnLXlM0BjQRdGSl6900LuF = new Vector3[num];
		int num2 = 0;
		foreach (Vector3[] array3 in array)
		{
			Array.Copy(array3, 0, DoLw5vYd2Gq0BYuUfcIXuj4Vo.DfCAnLXlM0BjQRdGSl6900LuF, num2, array3.Length);
			num2 += array3.Length;
		}
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x0002A0A4 File Offset: 0x000282A4
	private static Vector3[] DSdXSqhwR7EQmNpyBQ0fWuzR4(int segments, float sphereSize)
	{
		Vector3[] array3;
		try
		{
			int num = (segments + 1) * (segments + 1);
			Vector3[] array = new Vector3[num];
			int num2 = 0;
			for (int i = 0; i <= segments; i++)
			{
				float num3 = (float)i / (float)segments;
				float num4 = num3 * 3.1415927f;
				for (int j = 0; j <= segments; j++)
				{
					float num5 = (float)j / (float)segments;
					float num6 = num5 * 2f * 3.1415927f;
					float num7 = Mathf.Sin(num4) * Mathf.Cos(num6) * sphereSize;
					float num8 = Mathf.Cos(num4) * sphereSize;
					float num9 = Mathf.Sin(num4) * Mathf.Sin(num6) * sphereSize;
					array[num2] = new Vector3(num7, num8, num9);
					num2++;
				}
			}
			List<Vector3> list = array.ToList<Vector3>();
			foreach (Vector3 vector in array)
			{
				bool flag = false;
				for (int l = 0; l < list.Count; l++)
				{
					bool flag2 = vector == list[l];
					bool flag3 = flag2;
					if (flag3)
					{
						bool flag4 = !flag;
						bool flag5 = flag4;
						if (flag5)
						{
							flag = true;
						}
						else
						{
							list.RemoveAt(l);
						}
					}
				}
			}
			array3 = list.ToArray();
		}
		catch
		{
			array3 = new Vector3[] { Vector3.up * 5f };
		}
		return array3;
	}

	// Token: 0x04000342 RID: 834
	public static Vector3[] DfCAnLXlM0BjQRdGSl6900LuF = new Vector3[0];
}
