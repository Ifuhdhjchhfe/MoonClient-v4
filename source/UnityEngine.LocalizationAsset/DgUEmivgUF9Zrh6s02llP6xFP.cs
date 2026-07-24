using System;
using System.Reflection;

// Token: 0x02000061 RID: 97
public class DgUEmivgUF9Zrh6s02llP6xFP
{
	// Token: 0x060001CD RID: 461 RVA: 0x00018A97 File Offset: 0x00016C97
	public DgUEmivgUF9Zrh6s02llP6xFP(FieldInfo fieldInfo)
	{
		this.D0nmmzLTehOrs8cSwfk4gB7ZF = fieldInfo;
		this.DpZQ42VnGxbAo4BnNfJeBIGO5 = null;
	}

	// Token: 0x060001CE RID: 462 RVA: 0x00018AAF File Offset: 0x00016CAF
	public DgUEmivgUF9Zrh6s02llP6xFP(PropertyInfo propertyInfo)
	{
		this.D0nmmzLTehOrs8cSwfk4gB7ZF = null;
		this.DpZQ42VnGxbAo4BnNfJeBIGO5 = propertyInfo;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00018AC8 File Offset: 0x00016CC8
	public void DcNI3NtdStOdpOlK0ELyaRxHM(object value)
	{
		bool flag = this.D0nmmzLTehOrs8cSwfk4gB7ZF != null;
		bool flag2 = flag;
		if (flag2)
		{
			this.D0nmmzLTehOrs8cSwfk4gB7ZF.SetValue(null, value);
		}
		else
		{
			this.DpZQ42VnGxbAo4BnNfJeBIGO5.SetValue(null, value);
		}
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00018B0C File Offset: 0x00016D0C
	public object Dy14zRPGLPsFa96EuljDSW8Gc()
	{
		bool flag = this.D0nmmzLTehOrs8cSwfk4gB7ZF != null;
		bool flag2 = flag;
		object obj;
		if (flag2)
		{
			obj = this.D0nmmzLTehOrs8cSwfk4gB7ZF.GetValue(null);
		}
		else
		{
			obj = this.DpZQ42VnGxbAo4BnNfJeBIGO5.GetValue(null);
		}
		return obj;
	}

	// Token: 0x04000262 RID: 610
	public FieldInfo D0nmmzLTehOrs8cSwfk4gB7ZF;

	// Token: 0x04000263 RID: 611
	public PropertyInfo DpZQ42VnGxbAo4BnNfJeBIGO5;
}
