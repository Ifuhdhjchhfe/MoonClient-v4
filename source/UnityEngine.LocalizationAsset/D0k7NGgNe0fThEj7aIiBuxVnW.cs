using System;
using System.Reflection;

// Token: 0x02000008 RID: 8
public class D0k7NGgNe0fThEj7aIiBuxVnW<T>
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000018 RID: 24 RVA: 0x0000335C File Offset: 0x0000155C
	// (set) Token: 0x06000019 RID: 25 RVA: 0x00003384 File Offset: 0x00001584
	public T value
	{
		get
		{
			return (T)((object)this.pi.GetValue(this.instance));
		}
		set
		{
			this.pi.SetValue(this.instance, value);
		}
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0000339F File Offset: 0x0000159F
	public D0k7NGgNe0fThEj7aIiBuxVnW(Type _class, string name)
	{
		this.pi = _class.GetProperty(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000033BF File Offset: 0x000015BF
	public D0k7NGgNe0fThEj7aIiBuxVnW(Type _class, string name, BindingFlags reflectionFlags)
	{
		this.pi = _class.GetProperty(name, reflectionFlags);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000033DE File Offset: 0x000015DE
	public D0k7NGgNe0fThEj7aIiBuxVnW(string _class, string name)
	{
		this.pi = D08iy2XFQpUQteL0XRzAbg2IE.DFmzX7ViryVFbfSQqzLlVj0VW(_class).GetProperty(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00003403 File Offset: 0x00001603
	public D0k7NGgNe0fThEj7aIiBuxVnW(string _class, string name, BindingFlags reflectionFlags)
	{
		this.pi = D08iy2XFQpUQteL0XRzAbg2IE.DFmzX7ViryVFbfSQqzLlVj0VW(_class).GetProperty(name, reflectionFlags);
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00003427 File Offset: 0x00001627
	public void Instance(object instance)
	{
		this.instance = instance;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00003431 File Offset: 0x00001631
	public void Set(object value)
	{
		this.pi.SetValue(this.instance, value);
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00003447 File Offset: 0x00001647
	public void Set(object instance, object value)
	{
		this.pi.SetValue(instance, value);
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00003458 File Offset: 0x00001658
	public T Get()
	{
		return (T)((object)this.pi.GetValue(this.instance));
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00003480 File Offset: 0x00001680
	public T Get(object instance)
	{
		return (T)((object)this.pi.GetValue(instance));
	}

	// Token: 0x06000023 RID: 35 RVA: 0x000034A4 File Offset: 0x000016A4
	public static implicit operator T(D0k7NGgNe0fThEj7aIiBuxVnW<T> field)
	{
		return (T)((object)field.pi.GetValue(field.instance));
	}

	// Token: 0x0400000F RID: 15
	public PropertyInfo pi;

	// Token: 0x04000010 RID: 16
	public object instance = null;
}
