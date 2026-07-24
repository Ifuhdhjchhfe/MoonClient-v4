using System;
using System.Reflection;

// Token: 0x0200000C RID: 12
public class D0yGEmS3ymlCn0sF3jX0KkKE3
{
	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000031 RID: 49 RVA: 0x00003DB0 File Offset: 0x00001FB0
	// (set) Token: 0x06000032 RID: 50 RVA: 0x00003DD3 File Offset: 0x00001FD3
	public object value
	{
		get
		{
			return this.DsKgMnBJhyD4WHcUaHrlQ1HdJ.GetValue(this.DTu5mTZeu0oNNDBxtrDFVfHuZ);
		}
		set
		{
			this.DsKgMnBJhyD4WHcUaHrlQ1HdJ.SetValue(this.DTu5mTZeu0oNNDBxtrDFVfHuZ, value);
		}
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00003DE9 File Offset: 0x00001FE9
	public D0yGEmS3ymlCn0sF3jX0KkKE3(Type _class, string name)
	{
		this.DsKgMnBJhyD4WHcUaHrlQ1HdJ = _class.GetField(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00003E09 File Offset: 0x00002009
	public D0yGEmS3ymlCn0sF3jX0KkKE3(Type _class, string name, BindingFlags reflectionFlags)
	{
		this.DsKgMnBJhyD4WHcUaHrlQ1HdJ = _class.GetField(name, reflectionFlags);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003E28 File Offset: 0x00002028
	public D0yGEmS3ymlCn0sF3jX0KkKE3(string _class, string name)
	{
		this.DsKgMnBJhyD4WHcUaHrlQ1HdJ = D08iy2XFQpUQteL0XRzAbg2IE.DFmzX7ViryVFbfSQqzLlVj0VW(_class).GetField(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00003E4D File Offset: 0x0000204D
	public D0yGEmS3ymlCn0sF3jX0KkKE3(string _class, string name, BindingFlags reflectionFlags)
	{
		this.DsKgMnBJhyD4WHcUaHrlQ1HdJ = D08iy2XFQpUQteL0XRzAbg2IE.DFmzX7ViryVFbfSQqzLlVj0VW(_class).GetField(name, reflectionFlags);
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00003E71 File Offset: 0x00002071
	public void DtQUQHVgEqYata0NeLnVWzEPq()
	{
		this.DSvXuPN2sUGUiQFpcmidhwgD0 = this.value;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00003E80 File Offset: 0x00002080
	public void DmvPyRTGhVimoeuICspFdHP1d(object instance)
	{
		this.DTu5mTZeu0oNNDBxtrDFVfHuZ = instance;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003DD3 File Offset: 0x00001FD3
	public void DPzNzZDHRqDxUEVh2iXG15rm0(object value)
	{
		this.DsKgMnBJhyD4WHcUaHrlQ1HdJ.SetValue(this.DTu5mTZeu0oNNDBxtrDFVfHuZ, value);
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00003E8A File Offset: 0x0000208A
	public void D79DXEB3e1t5BDZl6n1ZsIfP3(object instance, object value)
	{
		this.DsKgMnBJhyD4WHcUaHrlQ1HdJ.SetValue(instance, value);
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00003E9C File Offset: 0x0000209C
	public object DvXI8iHhWIZsu8PJJSXGPSk8m()
	{
		return this.DsKgMnBJhyD4WHcUaHrlQ1HdJ.GetValue(this.DTu5mTZeu0oNNDBxtrDFVfHuZ);
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00003EC0 File Offset: 0x000020C0
	public object DvBB927EW3YHmvzUSmk5x5kfr(object instance)
	{
		return this.DsKgMnBJhyD4WHcUaHrlQ1HdJ.GetValue(instance);
	}

	// Token: 0x0400001A RID: 26
	public FieldInfo DsKgMnBJhyD4WHcUaHrlQ1HdJ;

	// Token: 0x0400001B RID: 27
	public object DSvXuPN2sUGUiQFpcmidhwgD0;

	// Token: 0x0400001C RID: 28
	public object DTu5mTZeu0oNNDBxtrDFVfHuZ = null;
}
