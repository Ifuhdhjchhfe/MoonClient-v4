using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200002E RID: 46
public static class DAnimationManager
{
	// Token: 0x060000D1 RID: 209 RVA: 0x00009C24 File Offset: 0x00007E24
	public static void Update()
	{
		float deltaTime = Time.deltaTime;
		foreach (KeyValuePair<string, AnimationState> keyValuePair in DAnimationManager.activeAnimations)
		{
			AnimationState value = keyValuePair.Value;
			bool flag = !value.IsPlaying;
			if (!flag)
			{
				value.ElapsedTime += deltaTime * value.SpeedMultiplier;
				value.Progress = Mathf.Clamp01(value.ElapsedTime / value.Duration);
				bool flag2 = value.OnUpdate != null;
				if (flag2)
				{
					float num = DAnimationManager.ApplyEasing(value.Progress, value.EasingType);
					value.OnUpdate(num);
				}
				bool flag3 = value.ElapsedTime >= value.Duration;
				if (flag3)
				{
					bool isLooping = value.IsLooping;
					if (isLooping)
					{
						value.ElapsedTime = 0f;
						value.Progress = 0f;
					}
					else
					{
						value.IsPlaying = false;
						value.Progress = 1f;
						bool flag4 = value.OnComplete != null;
						if (flag4)
						{
							value.OnComplete();
						}
						DAnimationManager.animationsToRemove.Add(keyValuePair.Key);
					}
				}
			}
		}
		foreach (string text in DAnimationManager.animationsToRemove)
		{
			DAnimationManager.activeAnimations.Remove(text);
		}
		DAnimationManager.animationsToRemove.Clear();
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00009DF0 File Offset: 0x00007FF0
	public static void RegisterAnimation(string key, AnimationType type, float duration, Action<float> onUpdate, Action onComplete = null, bool looping = false, float speedMultiplier = 1f)
	{
		AnimationState animationState = new AnimationState
		{
			Key = key,
			Type = type,
			Duration = duration,
			ElapsedTime = 0f,
			Progress = 0f,
			IsPlaying = true,
			IsLooping = looping,
			SpeedMultiplier = speedMultiplier,
			OnUpdate = onUpdate,
			OnComplete = onComplete,
			EasingType = EasingType.EaseInOutCubic
		};
		DAnimationManager.activeAnimations[key] = animationState;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00009E6C File Offset: 0x0000806C
	public static float GetAnimationValue(string key, float defaultValue = 0f)
	{
		bool flag = DAnimationManager.activeAnimations.ContainsKey(key);
		float num;
		if (flag)
		{
			num = DAnimationManager.activeAnimations[key].Progress;
		}
		else
		{
			num = defaultValue;
		}
		return num;
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00009EA4 File Offset: 0x000080A4
	public static bool HasAnimation(string key)
	{
		return DAnimationManager.activeAnimations.ContainsKey(key) && DAnimationManager.activeAnimations[key].IsPlaying;
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00009ED8 File Offset: 0x000080D8
	public static void CancelAnimation(string key)
	{
		bool flag = DAnimationManager.activeAnimations.ContainsKey(key);
		if (flag)
		{
			DAnimationManager.activeAnimations.Remove(key);
		}
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00009F03 File Offset: 0x00008103
	public static void CancelAllAnimations()
	{
		DAnimationManager.activeAnimations.Clear();
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00009F14 File Offset: 0x00008114
	private static float ApplyEasing(float t, EasingType easing)
	{
		float num;
		switch (easing)
		{
		case EasingType.Linear:
			num = t;
			break;
		case EasingType.EaseInQuad:
			num = t * t;
			break;
		case EasingType.EaseOutQuad:
			num = t * (2f - t);
			break;
		case EasingType.EaseInOutQuad:
			num = ((t < 0.5f) ? (2f * t * t) : (-1f + (4f - 2f * t) * t));
			break;
		case EasingType.EaseInCubic:
			num = t * t * t;
			break;
		case EasingType.EaseOutCubic:
			num = (t -= 1f) * t * t + 1f;
			break;
		case EasingType.EaseInOutCubic:
			num = ((t < 0.5f) ? (4f * t * t * t) : ((t - 1f) * (2f * t - 2f) * (2f * t - 2f) + 1f));
			break;
		case EasingType.EaseOutBack:
		{
			float num2 = 1.70158f;
			float num3 = num2 + 1f;
			num = 1f + num3 * Mathf.Pow(t - 1f, 3f) + num2 * Mathf.Pow(t - 1f, 2f);
			break;
		}
		case EasingType.ElasticOut:
		{
			float num4 = 2.0943952f;
			num = Mathf.Pow(2f, -10f * t) * Mathf.Sin((t * 10f - 0.75f) * num4) + 1f;
			break;
		}
		case EasingType.BounceOut:
		{
			float num5 = 7.5625f;
			float num6 = 2.75f;
			bool flag = t < 1f / num6;
			if (flag)
			{
				num = num5 * t * t;
			}
			else
			{
				bool flag2 = t < 2f / num6;
				if (flag2)
				{
					num = num5 * (t -= 1.5f / num6) * t + 0.75f;
				}
				else
				{
					bool flag3 = t < 2.5f / num6;
					if (flag3)
					{
						num = num5 * (t -= 2.25f / num6) * t + 0.9375f;
					}
					else
					{
						num = num5 * (t -= 2.625f / num6) * t + 0.984375f;
					}
				}
			}
			break;
		}
		default:
			num = t;
			break;
		}
		return num;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x0000A13C File Offset: 0x0000833C
	public static float EaseOutBack(float t)
	{
		float num = 1.70158f;
		float num2 = num + 1f;
		return 1f + num2 * Mathf.Pow(t - 1f, 3f) + num * Mathf.Pow(t - 1f, 2f);
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x0000A18C File Offset: 0x0000838C
	public static float EaseInOutCubic(float t)
	{
		return (t < 0.5f) ? (4f * t * t * t) : ((t - 1f) * (2f * t - 2f) * (2f * t - 2f) + 1f);
	}

	// Token: 0x060000DA RID: 218 RVA: 0x0000A1DC File Offset: 0x000083DC
	public static float ElasticOut(float t)
	{
		float num = 2.0943952f;
		return Mathf.Pow(2f, -10f * t) * Mathf.Sin((t * 10f - 0.75f) * num) + 1f;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x0000A220 File Offset: 0x00008420
	public static float BounceOut(float t)
	{
		float num = 7.5625f;
		float num2 = 2.75f;
		bool flag = t < 1f / num2;
		float num3;
		if (flag)
		{
			num3 = num * t * t;
		}
		else
		{
			bool flag2 = t < 2f / num2;
			if (flag2)
			{
				num3 = num * (t -= 1.5f / num2) * t + 0.75f;
			}
			else
			{
				bool flag3 = t < 2.5f / num2;
				if (flag3)
				{
					num3 = num * (t -= 2.25f / num2) * t + 0.9375f;
				}
				else
				{
					num3 = num * (t -= 2.625f / num2) * t + 0.984375f;
				}
			}
		}
		return num3;
	}

	// Token: 0x04000101 RID: 257
	private static Dictionary<string, AnimationState> activeAnimations = new Dictionary<string, AnimationState>();

	// Token: 0x04000102 RID: 258
	private static List<string> animationsToRemove = new List<string>();
}
