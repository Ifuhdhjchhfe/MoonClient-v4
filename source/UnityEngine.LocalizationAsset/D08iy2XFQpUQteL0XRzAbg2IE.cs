using System;
using System.Collections.Generic;
using System.Reflection;
using SDG.Unturned;

// Token: 0x02000004 RID: 4
public static class D08iy2XFQpUQteL0XRzAbg2IE
{
	// Token: 0x0600000B RID: 11 RVA: 0x00002F10 File Offset: 0x00001110
	public static Type D690dQkfd9Ye1iupKYZFiSJkW(string type)
	{
		return D08iy2XFQpUQteL0XRzAbg2IE.D2PEo2OSBVGwHaZiaIj318Nmp(type, typeof(Setup));
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002F34 File Offset: 0x00001134
	public static Type D2PEo2OSBVGwHaZiaIj318Nmp(string type, Type assemblyRefType)
	{
		bool flag = D08iy2XFQpUQteL0XRzAbg2IE.Dc0Z6WcrqTvhTq6BassBFF3tq.ContainsKey(type);
		bool flag2 = flag;
		Type type2;
		if (flag2)
		{
			type2 = D08iy2XFQpUQteL0XRzAbg2IE.Dc0Z6WcrqTvhTq6BassBFF3tq[type];
		}
		else
		{
			foreach (Type type3 in Assembly.GetAssembly(assemblyRefType).GetTypes())
			{
				bool flag3 = type3.Name == type;
				bool flag4 = flag3;
				if (flag4)
				{
					D08iy2XFQpUQteL0XRzAbg2IE.Dc0Z6WcrqTvhTq6BassBFF3tq.Add(type3.Name, type3);
					return type3;
				}
			}
			type2 = null;
		}
		return type2;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002FC8 File Offset: 0x000011C8
	public static Type DFmzX7ViryVFbfSQqzLlVj0VW(string type)
	{
		foreach (Type type2 in Assembly.GetAssembly(typeof(Setup)).GetTypes())
		{
			bool flag = type2.Name == type;
			bool flag2 = flag;
			if (flag2)
			{
				return type2;
			}
		}
		return null;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00003024 File Offset: 0x00001224
	public static T D6WfOu184mT2tP3LWMqZEzUjd<T>(Type script, string varName, object obj)
	{
		return (T)((object)D08iy2XFQpUQteL0XRzAbg2IE.DnNL1SGsF3trBXsR4aT63oXVe(script, varName, obj));
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00003044 File Offset: 0x00001244
	public static object DnNL1SGsF3trBXsR4aT63oXVe(Type script, string varName, object obj)
	{
		BindingFlags bindingFlags = ((obj == null) ? BindingFlags.Static : BindingFlags.Instance);
		string text = string.Concat(new string[]
		{
			script.FullName,
			":",
			varName,
			":",
			(obj == null) ? "static" : "instance"
		});
		FieldInfo fieldInfo;
		bool flag = D08iy2XFQpUQteL0XRzAbg2IE.DcxxUPR4c0SCzdlTrpyKKlNJq.TryGetValue(text, out fieldInfo);
		bool flag2 = flag;
		FieldInfo fieldInfo2;
		if (flag2)
		{
			fieldInfo2 = fieldInfo;
		}
		else
		{
			fieldInfo2 = script.GetField(varName, BindingFlags.NonPublic | bindingFlags);
			D08iy2XFQpUQteL0XRzAbg2IE.DcxxUPR4c0SCzdlTrpyKKlNJq.Add(text, fieldInfo2);
		}
		bool flag3 = fieldInfo2 == null;
		object obj2;
		if (flag3)
		{
			obj2 = null;
		}
		else
		{
			obj2 = fieldInfo2.GetValue(obj);
		}
		return obj2;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000030F0 File Offset: 0x000012F0
	public static void Dr06TnUlTEh4Mt9XdzQtoz0Lb(Type script, string varName, object obj, object value)
	{
		try
		{
			BindingFlags bindingFlags = ((obj == null) ? BindingFlags.Static : BindingFlags.Instance);
			string text = string.Concat(new string[]
			{
				script.FullName,
				":",
				varName,
				":",
				(obj == null) ? "static" : "instance"
			});
			FieldInfo fieldInfo;
			bool flag = D08iy2XFQpUQteL0XRzAbg2IE.DcxxUPR4c0SCzdlTrpyKKlNJq.TryGetValue(text, out fieldInfo);
			bool flag2 = flag;
			FieldInfo fieldInfo2;
			if (flag2)
			{
				fieldInfo2 = fieldInfo;
			}
			else
			{
				fieldInfo2 = script.GetField(varName, BindingFlags.NonPublic | bindingFlags);
				D08iy2XFQpUQteL0XRzAbg2IE.DcxxUPR4c0SCzdlTrpyKKlNJq.Add(text, fieldInfo2);
			}
			bool flag3 = fieldInfo2 != null;
			if (flag3)
			{
				fieldInfo2.SetValue(obj, value);
			}
		}
		catch (Exception ex)
		{
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(string.Concat(new string[] { "Cannot set a ", varName, " value in ", script.Name, " class: ", ex.Message, " ||||| ", ex.StackTrace }));
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00003200 File Offset: 0x00001400
	public static T DTTVzTiDxk8nh6pQAaCsJ0ItC<T>(Type script, string methodName, object obj, params object[] arguments)
	{
		return (T)((object)D08iy2XFQpUQteL0XRzAbg2IE.DJRjdxfvw98Ox0FYU1cSOKdGb(script, methodName, obj, arguments));
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00003220 File Offset: 0x00001420
	public static object DJRjdxfvw98Ox0FYU1cSOKdGb(Type script, string methodName, object obj, params object[] arguments)
	{
		BindingFlags bindingFlags = ((obj == null) ? BindingFlags.Static : BindingFlags.Instance);
		string text = string.Concat(new string[]
		{
			script.FullName,
			":",
			methodName,
			":",
			(obj == null) ? "static" : "instance"
		});
		MethodInfo methodInfo;
		bool flag = D08iy2XFQpUQteL0XRzAbg2IE.D8BFwKXbVanGHgUtWmJJKgo9O.TryGetValue(text, out methodInfo);
		bool flag2 = flag;
		MethodInfo methodInfo2;
		if (flag2)
		{
			methodInfo2 = methodInfo;
		}
		else
		{
			methodInfo2 = script.GetMethod(methodName, BindingFlags.NonPublic | bindingFlags);
			D08iy2XFQpUQteL0XRzAbg2IE.D8BFwKXbVanGHgUtWmJJKgo9O.Add(text, methodInfo2);
		}
		bool flag3 = methodInfo2 == null;
		object obj2;
		if (flag3)
		{
			obj2 = null;
		}
		else
		{
			obj2 = methodInfo2.Invoke(obj, arguments);
		}
		return obj2;
	}

	// Token: 0x04000007 RID: 7
	public static Dictionary<string, Type> Dc0Z6WcrqTvhTq6BassBFF3tq = new Dictionary<string, Type>();

	// Token: 0x04000008 RID: 8
	public static Dictionary<string, FieldInfo> DcxxUPR4c0SCzdlTrpyKKlNJq = new Dictionary<string, FieldInfo>();

	// Token: 0x04000009 RID: 9
	public static Dictionary<string, MethodInfo> D8BFwKXbVanGHgUtWmJJKgo9O = new Dictionary<string, MethodInfo>();
}
