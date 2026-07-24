using System;

// Token: 0x0200002F RID: 47
public class AnimationState
{
	// Token: 0x04000103 RID: 259
	public string Key;

	// Token: 0x04000104 RID: 260
	public AnimationType Type;

	// Token: 0x04000105 RID: 261
	public float Duration;

	// Token: 0x04000106 RID: 262
	public float ElapsedTime;

	// Token: 0x04000107 RID: 263
	public float Progress;

	// Token: 0x04000108 RID: 264
	public bool IsPlaying;

	// Token: 0x04000109 RID: 265
	public bool IsLooping;

	// Token: 0x0400010A RID: 266
	public float SpeedMultiplier;

	// Token: 0x0400010B RID: 267
	public Action<float> OnUpdate;

	// Token: 0x0400010C RID: 268
	public Action OnComplete;

	// Token: 0x0400010D RID: 269
	public EasingType EasingType;
}
