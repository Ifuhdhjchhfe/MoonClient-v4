using System;
using System.Reflection;

// Token: 0x02000056 RID: 86
public class DfHljpul4p88ytp3JZtoSRq7w<T>
{
	// Token: 0x0600018F RID: 399 RVA: 0x000162E4 File Offset: 0x000144E4
	public DfHljpul4p88ytp3JZtoSRq7w(Type _class, string name)
	{
		this.mi = _class.GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00016304 File Offset: 0x00014504
	public DfHljpul4p88ytp3JZtoSRq7w(Type _class, string name, BindingFlags reflectionFlags)
	{
		this.mi = _class.GetMethod(name, reflectionFlags);
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00016323 File Offset: 0x00014523
	public DfHljpul4p88ytp3JZtoSRq7w(string _class, string name)
	{
		this.mi = D08iy2XFQpUQteL0XRzAbg2IE.DFmzX7ViryVFbfSQqzLlVj0VW(_class).GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00016348 File Offset: 0x00014548
	public DfHljpul4p88ytp3JZtoSRq7w(string _class, string name, BindingFlags reflectionFlags)
	{
		this.mi = D08iy2XFQpUQteL0XRzAbg2IE.DFmzX7ViryVFbfSQqzLlVj0VW(_class).GetMethod(name, reflectionFlags);
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0001636C File Offset: 0x0001456C
	public void Instance(object instance)
	{
		this.instance = instance;
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00016378 File Offset: 0x00014578
	public T Invoke(params object[] objs)
	{
		return (T)((object)this.mi.Invoke(this.instance, objs));
	}

	// Token: 0x06000195 RID: 405 RVA: 0x000163A4 File Offset: 0x000145A4
	public T InvokeI(object instance, params object[] objs)
	{
		return (T)((object)this.mi.Invoke(instance, objs));
	}

	// Token: 0x06000196 RID: 406 RVA: 0x000163C8 File Offset: 0x000145C8
	public static implicit operator T(DfHljpul4p88ytp3JZtoSRq7w<T> method)
	{
		return method.Invoke(new object[] { method.instance });
	}

	// Token: 0x040001E6 RID: 486
	public MethodInfo mi;

	// Token: 0x040001E7 RID: 487
	public object instance = null;
}
