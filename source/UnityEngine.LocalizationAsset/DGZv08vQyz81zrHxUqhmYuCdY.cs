using System;
using System.Reflection;

// Token: 0x02000062 RID: 98
public class DGZv08vQyz81zrHxUqhmYuCdY<T>
{
	// Token: 0x1700001E RID: 30
	// (get) Token: 0x060001D1 RID: 465 RVA: 0x00018B54 File Offset: 0x00016D54
	// (set) Token: 0x060001D2 RID: 466 RVA: 0x00018B7C File Offset: 0x00016D7C
	public T value
	{
		get
		{
			return (T)((object)this.fi.GetValue(this.instance));
		}
		set
		{
			this.fi.SetValue(this.instance, value);
		}
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00018B97 File Offset: 0x00016D97
	public DGZv08vQyz81zrHxUqhmYuCdY(Type _class, string name)
	{
		this.fi = _class.GetField(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00018BB7 File Offset: 0x00016DB7
	public DGZv08vQyz81zrHxUqhmYuCdY(Type _class, string name, BindingFlags reflectionFlags)
	{
		this.fi = _class.GetField(name, reflectionFlags);
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00018BD6 File Offset: 0x00016DD6
	public DGZv08vQyz81zrHxUqhmYuCdY(string _class, string name)
	{
		this.fi = D08iy2XFQpUQteL0XRzAbg2IE.DFmzX7ViryVFbfSQqzLlVj0VW(_class).GetField(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00018BFB File Offset: 0x00016DFB
	public DGZv08vQyz81zrHxUqhmYuCdY(string _class, string name, BindingFlags reflectionFlags)
	{
		this.fi = D08iy2XFQpUQteL0XRzAbg2IE.DFmzX7ViryVFbfSQqzLlVj0VW(_class).GetField(name, reflectionFlags);
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x00018C1F File Offset: 0x00016E1F
	public void RefereshFieldValue()
	{
		this.fldValue = this.Get();
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00018C2E File Offset: 0x00016E2E
	public void RefereshFieldValue(object instance)
	{
		this.fldValue = this.Get(instance);
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00018C3E File Offset: 0x00016E3E
	public void Instance(object instance)
	{
		this.instance = instance;
	}

	// Token: 0x060001DA RID: 474 RVA: 0x00018C48 File Offset: 0x00016E48
	public void Set(object value)
	{
		this.fi.SetValue(this.instance, value);
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00018C5E File Offset: 0x00016E5E
	public void Set(object instance, object value)
	{
		this.fi.SetValue(instance, value);
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00018C70 File Offset: 0x00016E70
	public T Get()
	{
		return (T)((object)this.fi.GetValue(this.instance));
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00018C98 File Offset: 0x00016E98
	public T Get(object instance)
	{
		return (T)((object)this.fi.GetValue(instance));
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00018CBC File Offset: 0x00016EBC
	public static implicit operator T(DGZv08vQyz81zrHxUqhmYuCdY<T> field)
	{
		return (T)((object)field.fi.GetValue(field.instance));
	}

	// Token: 0x04000264 RID: 612
	public FieldInfo fi;

	// Token: 0x04000265 RID: 613
	public T fldValue;

	// Token: 0x04000266 RID: 614
	public object instance = null;
}
