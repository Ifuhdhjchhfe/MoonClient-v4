using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000B6 RID: 182
public class DSuKLIF35AtXmFdSPtbkEXBdM
{
	// Token: 0x1700002A RID: 42
	// (get) Token: 0x0600038A RID: 906 RVA: 0x00036E00 File Offset: 0x00035000
	// (set) Token: 0x0600038B RID: 907 RVA: 0x00036E18 File Offset: 0x00035018
	public Color32 settedColor
	{
		get
		{
			return this.DkJGdJpvFP4j4uWN4CyFixyQ3;
		}
		set
		{
			bool flag = (value.r != this.DkJGdJpvFP4j4uWN4CyFixyQ3.r || value.g != this.DkJGdJpvFP4j4uWN4CyFixyQ3.g || value.b != this.DkJGdJpvFP4j4uWN4CyFixyQ3.b || value.a != this.DkJGdJpvFP4j4uWN4CyFixyQ3.a) && this.DjotWVBUwldprZFxf3VQwQdG5 != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.DjotWVBUwldprZFxf3VQwQdG5(value);
			}
			this.DkJGdJpvFP4j4uWN4CyFixyQ3 = value;
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x0600038C RID: 908 RVA: 0x00036E9C File Offset: 0x0003509C
	// (set) Token: 0x0600038D RID: 909 RVA: 0x00036EB4 File Offset: 0x000350B4
	public bool isGradient
	{
		get
		{
			return this.DBlJ2ATqDOg2Ki1YCFzsbNYu2;
		}
		set
		{
			bool flag = this.DBlJ2ATqDOg2Ki1YCFzsbNYu2 != value;
			bool flag2 = flag;
			if (flag2)
			{
				if (value)
				{
					this.DqW3s0mTQvPzsflmSjWcF4Gyk = this.DkJGdJpvFP4j4uWN4CyFixyQ3;
					DSuKLIF35AtXmFdSPtbkEXBdM.DXrHadqPnOIBDIPSelSOaz2ov.Add(this);
				}
				else
				{
					DSuKLIF35AtXmFdSPtbkEXBdM.DXrHadqPnOIBDIPSelSOaz2ov.Remove(this);
					this.DkJGdJpvFP4j4uWN4CyFixyQ3 = this.DqW3s0mTQvPzsflmSjWcF4Gyk;
				}
			}
			this.DBlJ2ATqDOg2Ki1YCFzsbNYu2 = value;
		}
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00036F18 File Offset: 0x00035118
	public DSuKLIF35AtXmFdSPtbkEXBdM(Color32 color, string colorName, bool isGradient = false)
	{
		this.DyuiZVHlez37wZyzRLw1Q85BY = colorName;
		this.DkJGdJpvFP4j4uWN4CyFixyQ3 = color;
		this.DP0vPDFDOZUt4qFigtsVpWTYq = 0f;
		this.DpvkqvtTMG2lpoFl08AKmUDtD = 0.4f;
		this.DBlJ2ATqDOg2Ki1YCFzsbNYu2 = isGradient;
		this.DjotWVBUwldprZFxf3VQwQdG5 = null;
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00036F54 File Offset: 0x00035154
	public DSuKLIF35AtXmFdSPtbkEXBdM(Color32 color, string colorName, DFLy9NFsx04MU2rUp1sjM00D5 onColorChanged, bool isGradient = false)
	{
		this.DyuiZVHlez37wZyzRLw1Q85BY = colorName;
		this.DkJGdJpvFP4j4uWN4CyFixyQ3 = color;
		this.DP0vPDFDOZUt4qFigtsVpWTYq = 0f;
		this.DpvkqvtTMG2lpoFl08AKmUDtD = 0.4f;
		this.DBlJ2ATqDOg2Ki1YCFzsbNYu2 = isGradient;
		this.DjotWVBUwldprZFxf3VQwQdG5 = onColorChanged;
	}

	// Token: 0x040003D5 RID: 981
	public static List<DSuKLIF35AtXmFdSPtbkEXBdM> DXrHadqPnOIBDIPSelSOaz2ov = new List<DSuKLIF35AtXmFdSPtbkEXBdM>();

	// Token: 0x040003D6 RID: 982
	public Color32 DkJGdJpvFP4j4uWN4CyFixyQ3;

	// Token: 0x040003D7 RID: 983
	public string DyuiZVHlez37wZyzRLw1Q85BY;

	// Token: 0x040003D8 RID: 984
	public bool DBlJ2ATqDOg2Ki1YCFzsbNYu2;

	// Token: 0x040003D9 RID: 985
	public float DP0vPDFDOZUt4qFigtsVpWTYq;

	// Token: 0x040003DA RID: 986
	public float DpvkqvtTMG2lpoFl08AKmUDtD;

	// Token: 0x040003DB RID: 987
	public DFLy9NFsx04MU2rUp1sjM00D5 DjotWVBUwldprZFxf3VQwQdG5;

	// Token: 0x040003DC RID: 988
	public Color32 DqW3s0mTQvPzsflmSjWcF4Gyk;
}
