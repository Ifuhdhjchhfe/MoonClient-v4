using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;

// Token: 0x02000029 RID: 41
public static class DA1dZHkBmPouE1WuakM2TW4QH
{
	// Token: 0x060000B5 RID: 181 RVA: 0x00008B88 File Offset: 0x00006D88
	public static void DvYwyZ1bxY64hLQk7ArMwMTwk()
	{
		foreach (MethodInfo methodInfo in DHGBgVGlvxZ0K3LOA9TG3GHJ9.D4PCGkb4q83QWwcj54aGMUKvr[typeof(DK25cIW1nkfhHjlmZqnMOqUJq)])
		{
			try
			{
				DK25cIW1nkfhHjlmZqnMOqUJq dk25cIW1nkfhHjlmZqnMOqUJq = (DK25cIW1nkfhHjlmZqnMOqUJq)methodInfo.GetCustomAttribute(typeof(DK25cIW1nkfhHjlmZqnMOqUJq));
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("[ov_section] Starting Override -> " + dk25cIW1nkfhHjlmZqnMOqUJq.DnUKvAhpaRIACMAN2nEbUasYx.Name + "." + dk25cIW1nkfhHjlmZqnMOqUJq.DS0EULwgrnJ1tLoOuTogRXVKb);
				DA1dZHkBmPouE1WuakM2TW4QH.DTj9Yl5Az90Fx9I8AXZGuVkyZ(dk25cIW1nkfhHjlmZqnMOqUJq.DnUKvAhpaRIACMAN2nEbUasYx, dk25cIW1nkfhHjlmZqnMOqUJq.DS0EULwgrnJ1tLoOuTogRXVKb, dk25cIW1nkfhHjlmZqnMOqUJq.D8Iq57jMJrxAZe1HOCYdDo4P6, methodInfo.DeclaringType, methodInfo.Name, (methodInfo.IsPublic ? BindingFlags.Public : BindingFlags.NonPublic) | (methodInfo.IsStatic ? BindingFlags.Static : BindingFlags.Instance), dk25cIW1nkfhHjlmZqnMOqUJq.D3j09tZIhrJFN3gew5oHC4Zgi);
			}
			catch (Exception ex)
			{
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("[ov_section] failed!!! contact support");
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.Message);
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.StackTrace);
			}
		}
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00008CA8 File Offset: 0x00006EA8
	public static D9Tzj1SkWAoyZl0owsCmbQM3M DRQkd4CLeC14dmhsOkLjV5XPH(Type originalClass, string originalMethodName, Type modifiedClass, string hookMethodName, params Type[] memberIndentifiers)
	{
		return DA1dZHkBmPouE1WuakM2TW4QH.DTj9Yl5Az90Fx9I8AXZGuVkyZ(originalClass, originalMethodName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, modifiedClass, hookMethodName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, memberIndentifiers);
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00008CCC File Offset: 0x00006ECC
	public static D9Tzj1SkWAoyZl0owsCmbQM3M DYjhB0KLXuN4upu60RSxQHslL(Type originalClass, string originalMethodName, bool isOriginalPublic, bool isOriginalStatic, Type modifiedClass, string hookMethodName, bool isHookPublic, bool isHookStatic, params Type[] memberIndentifiers)
	{
		return DA1dZHkBmPouE1WuakM2TW4QH.DTj9Yl5Az90Fx9I8AXZGuVkyZ(originalClass, originalMethodName, (isOriginalPublic ? BindingFlags.Public : BindingFlags.NonPublic) | (isOriginalStatic ? BindingFlags.Static : BindingFlags.Instance), modifiedClass, hookMethodName, (isHookPublic ? BindingFlags.Public : BindingFlags.NonPublic) | (isHookStatic ? BindingFlags.Static : BindingFlags.Instance), memberIndentifiers);
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00008D10 File Offset: 0x00006F10
	public static D9Tzj1SkWAoyZl0owsCmbQM3M DOoFI9XZIILih1hhU0BxOeJVB(Type originalClass, string originalMethodName, bool isOriginalPublic, bool isOriginalStatic, Type modifiedClass, string hookMethodName, params Type[] memberIndentifiers)
	{
		return DA1dZHkBmPouE1WuakM2TW4QH.DTj9Yl5Az90Fx9I8AXZGuVkyZ(originalClass, originalMethodName, (isOriginalPublic ? BindingFlags.Public : BindingFlags.NonPublic) | (isOriginalStatic ? BindingFlags.Static : BindingFlags.Instance), modifiedClass, hookMethodName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, memberIndentifiers);
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00008D44 File Offset: 0x00006F44
	public static D9Tzj1SkWAoyZl0owsCmbQM3M DTj9Yl5Az90Fx9I8AXZGuVkyZ(Type originalClass, string originalMethodName, BindingFlags originalFlags, Type modifiedClass, string hookMethodName, BindingFlags hookFlags, params Type[] memberIndentifiers)
	{
		MemberInfo[] member = originalClass.GetMember(originalMethodName, originalFlags);
		MethodInfo methodInfo = null;
		bool flag = member.Length == 0;
		D9Tzj1SkWAoyZl0owsCmbQM3M d9Tzj1SkWAoyZl0owsCmbQM3M;
		if (flag)
		{
			global::UnityEngine.Debug.LogError("[ov_section] member/function could not be found");
			d9Tzj1SkWAoyZl0owsCmbQM3M = null;
		}
		else
		{
			bool flag2 = member.Length == 1;
			if (flag2)
			{
				methodInfo = member[0] as MethodInfo;
			}
			else
			{
				foreach (MemberInfo memberInfo in member)
				{
					bool flag3 = memberIndentifiers.Length == 0 && ((MethodInfo)memberInfo).GetParameters().Length == 0;
					if (flag3)
					{
						methodInfo = memberInfo as MethodInfo;
						break;
					}
					ParameterInfo[] parameters = ((MethodInfo)memberInfo).GetParameters();
					bool flag4 = memberIndentifiers.Length != parameters.Length;
					if (flag4)
					{
						break;
					}
					bool flag5 = true;
					for (int j = 0; j < parameters.Length; j++)
					{
						bool flag6 = parameters[j].ParameterType != memberIndentifiers[j];
						if (flag6)
						{
							flag5 = false;
							break;
						}
					}
					bool flag7 = flag5;
					if (flag7)
					{
						methodInfo = memberInfo as MethodInfo;
						break;
					}
				}
			}
			bool flag8 = methodInfo == null;
			if (flag8)
			{
				global::UnityEngine.Debug.LogError("original info is not found!");
				d9Tzj1SkWAoyZl0owsCmbQM3M = null;
			}
			else
			{
				MethodInfo method = modifiedClass.GetMethod(hookMethodName, hookFlags);
				bool flag9 = method == null;
				if (flag9)
				{
					global::UnityEngine.Debug.LogError("hook info is not found!");
					d9Tzj1SkWAoyZl0owsCmbQM3M = null;
				}
				else
				{
					D9Tzj1SkWAoyZl0owsCmbQM3M d9Tzj1SkWAoyZl0owsCmbQM3M2 = new D9Tzj1SkWAoyZl0owsCmbQM3M(methodInfo, method);
					d9Tzj1SkWAoyZl0owsCmbQM3M2.DEz4GruecNL42mD0UmFBxiEs0();
					DA1dZHkBmPouE1WuakM2TW4QH.DAbb78SP9e45DxByspkgZhgQZ.Add(method.MetadataToken, d9Tzj1SkWAoyZl0owsCmbQM3M2);
					DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(string.Concat(new string[]
					{
						"hooked function ",
						methodInfo.DeclaringType.Name,
						".",
						methodInfo.Name,
						" successfully"
					}));
					d9Tzj1SkWAoyZl0owsCmbQM3M = d9Tzj1SkWAoyZl0owsCmbQM3M2;
				}
			}
		}
		return d9Tzj1SkWAoyZl0owsCmbQM3M;
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00008F24 File Offset: 0x00007124
	public static T DbnCove2eID4Rs6wqrevxPwBP<T>()
	{
		return (T)((object)DA1dZHkBmPouE1WuakM2TW4QH.D2cRvNT26jwbsIz7pRTVg5cuE(new StackTrace(false).GetFrame(1).GetMethod(), null, new object[0]));
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00008F58 File Offset: 0x00007158
	public static T DV5fBuuwwtgOKLKyiAmdzlRoa<T>(object instance, params object[] args)
	{
		return (T)((object)DA1dZHkBmPouE1WuakM2TW4QH.D2cRvNT26jwbsIz7pRTVg5cuE(new StackTrace(false).GetFrame(1).GetMethod(), instance, args));
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00008F88 File Offset: 0x00007188
	public static object DElQjEDm4573wecG7fo2S4dus()
	{
		return DA1dZHkBmPouE1WuakM2TW4QH.D2cRvNT26jwbsIz7pRTVg5cuE(new StackTrace(false).GetFrame(1).GetMethod(), null, new object[0]);
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00008FB8 File Offset: 0x000071B8
	public static object DVQNp76PYYTgyxPuzAgm1P01g(object instance, params object[] args)
	{
		return DA1dZHkBmPouE1WuakM2TW4QH.D2cRvNT26jwbsIz7pRTVg5cuE(new StackTrace(false).GetFrame(1).GetMethod(), instance, args);
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00008FE4 File Offset: 0x000071E4
	public static object D2cRvNT26jwbsIz7pRTVg5cuE(MethodBase hookMethod, object instance, params object[] args)
	{
		D9Tzj1SkWAoyZl0owsCmbQM3M d9Tzj1SkWAoyZl0owsCmbQM3M;
		bool flag = DA1dZHkBmPouE1WuakM2TW4QH.DAbb78SP9e45DxByspkgZhgQZ.TryGetValue(hookMethod.MetadataToken, out d9Tzj1SkWAoyZl0owsCmbQM3M);
		object obj2;
		if (flag)
		{
			d9Tzj1SkWAoyZl0owsCmbQM3M.D0KXuUYPpRii5N7p0sVOu7eK9();
			object obj = d9Tzj1SkWAoyZl0owsCmbQM3M.DzCVnnM8yCzxGHvUi1flI3Eyv.Invoke(instance, args);
			d9Tzj1SkWAoyZl0owsCmbQM3M.DEz4GruecNL42mD0UmFBxiEs0();
			obj2 = obj;
		}
		else
		{
			global::UnityEngine.Debug.LogError("hook info is not found!");
			obj2 = null;
		}
		return obj2;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00009040 File Offset: 0x00007240
	public static void D8IYzSlM0eqRyQn0ykjxyYkdm()
	{
		foreach (D9Tzj1SkWAoyZl0owsCmbQM3M d9Tzj1SkWAoyZl0owsCmbQM3M in DA1dZHkBmPouE1WuakM2TW4QH.DAbb78SP9e45DxByspkgZhgQZ.Values)
		{
			d9Tzj1SkWAoyZl0owsCmbQM3M.D0KXuUYPpRii5N7p0sVOu7eK9();
		}
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x0000909C File Offset: 0x0000729C
	public static void D9YD48SpzzZgIZ41iQ2jE9vsp(string name)
	{
		foreach (D9Tzj1SkWAoyZl0owsCmbQM3M d9Tzj1SkWAoyZl0owsCmbQM3M in DA1dZHkBmPouE1WuakM2TW4QH.DAbb78SP9e45DxByspkgZhgQZ.Values)
		{
			bool flag = d9Tzj1SkWAoyZl0owsCmbQM3M.DzCVnnM8yCzxGHvUi1flI3Eyv.DeclaringType.Name + "." + d9Tzj1SkWAoyZl0owsCmbQM3M.DzCVnnM8yCzxGHvUi1flI3Eyv.Name == name;
			if (flag)
			{
				d9Tzj1SkWAoyZl0owsCmbQM3M.D0KXuUYPpRii5N7p0sVOu7eK9();
				break;
			}
		}
	}

	// Token: 0x040000E1 RID: 225
	public static Dictionary<int, D9Tzj1SkWAoyZl0owsCmbQM3M> DAbb78SP9e45DxByspkgZhgQZ = new Dictionary<int, D9Tzj1SkWAoyZl0owsCmbQM3M>();
}
