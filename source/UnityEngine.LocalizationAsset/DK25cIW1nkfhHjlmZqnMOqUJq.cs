using System;
using System.Reflection;

// Token: 0x02000077 RID: 119
[AttributeUsage(AttributeTargets.Method)]
public class DK25cIW1nkfhHjlmZqnMOqUJq : Attribute
{
	// Token: 0x0600024E RID: 590 RVA: 0x00020E47 File Offset: 0x0001F047
	public DK25cIW1nkfhHjlmZqnMOqUJq(Type t, string methodName, params Type[] memberIndentifiers)
	{
		this.DnUKvAhpaRIACMAN2nEbUasYx = t;
		this.D8Iq57jMJrxAZe1HOCYdDo4P6 = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		this.DS0EULwgrnJ1tLoOuTogRXVKb = methodName;
		this.D3j09tZIhrJFN3gew5oHC4Zgi = memberIndentifiers;
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00020E6E File Offset: 0x0001F06E
	public DK25cIW1nkfhHjlmZqnMOqUJq(Type t, string methodName, BindingFlags flags, params Type[] memberIndentifiers)
	{
		this.DnUKvAhpaRIACMAN2nEbUasYx = t;
		this.DS0EULwgrnJ1tLoOuTogRXVKb = methodName;
		this.D8Iq57jMJrxAZe1HOCYdDo4P6 = flags;
		this.D3j09tZIhrJFN3gew5oHC4Zgi = memberIndentifiers;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00020E95 File Offset: 0x0001F095
	public DK25cIW1nkfhHjlmZqnMOqUJq(string t, string methodName, params Type[] memberIndentifiers)
	{
		this.DnUKvAhpaRIACMAN2nEbUasYx = D08iy2XFQpUQteL0XRzAbg2IE.DFmzX7ViryVFbfSQqzLlVj0VW(t);
		this.D8Iq57jMJrxAZe1HOCYdDo4P6 = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		this.DS0EULwgrnJ1tLoOuTogRXVKb = methodName;
		this.D3j09tZIhrJFN3gew5oHC4Zgi = memberIndentifiers;
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00020EC1 File Offset: 0x0001F0C1
	public DK25cIW1nkfhHjlmZqnMOqUJq(string t, string methodName, BindingFlags flags, params Type[] memberIndentifiers)
	{
		this.DnUKvAhpaRIACMAN2nEbUasYx = D08iy2XFQpUQteL0XRzAbg2IE.DFmzX7ViryVFbfSQqzLlVj0VW(t);
		this.DS0EULwgrnJ1tLoOuTogRXVKb = methodName;
		this.D8Iq57jMJrxAZe1HOCYdDo4P6 = flags;
		this.D3j09tZIhrJFN3gew5oHC4Zgi = memberIndentifiers;
	}

	// Token: 0x040002DB RID: 731
	public Type DnUKvAhpaRIACMAN2nEbUasYx;

	// Token: 0x040002DC RID: 732
	public string DS0EULwgrnJ1tLoOuTogRXVKb;

	// Token: 0x040002DD RID: 733
	public BindingFlags D8Iq57jMJrxAZe1HOCYdDo4P6;

	// Token: 0x040002DE RID: 734
	public Type[] D3j09tZIhrJFN3gew5oHC4Zgi;
}
