using System;
using System.Reflection;

// Token: 0x0200003B RID: 59
public struct DC0nl3r18TU0Q6PA1kJbeydPJ
{
	// Token: 0x060000FA RID: 250 RVA: 0x0000A748 File Offset: 0x00008948
	public DC0nl3r18TU0Q6PA1kJbeydPJ(DA7EjeELhPnQjMBiXW309VJV4 varType, Type originalType, string originalVarName, string varName, bool isProperty)
	{
		this.DJlJTMsR8q8RN0RCA0fyq7LLD = varType;
		this.DOHjafDmqS0IFz4rXV88tZ5yS = originalType;
		this.Deh6uXv55TBzpNCpPjFRI6uvY = originalVarName;
		this.DY023HqubRJHq5VeFVgWZNqT7 = varName;
		this.DrxWLpNmkNm6CNZBgQJwRBebB = isProperty;
	}

	// Token: 0x060000FB RID: 251 RVA: 0x0000A770 File Offset: 0x00008970
	public object Dzty2JTTfrqCDWb8RtFsz2QeF()
	{
		bool drxWLpNmkNm6CNZBgQJwRBebB = this.DrxWLpNmkNm6CNZBgQJwRBebB;
		bool flag = drxWLpNmkNm6CNZBgQJwRBebB;
		object obj;
		if (flag)
		{
			obj = this.DOHjafDmqS0IFz4rXV88tZ5yS.GetProperty(this.Deh6uXv55TBzpNCpPjFRI6uvY, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).GetValue(null);
		}
		else
		{
			obj = this.DOHjafDmqS0IFz4rXV88tZ5yS.GetField(this.Deh6uXv55TBzpNCpPjFRI6uvY, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).GetValue(null);
		}
		return obj;
	}

	// Token: 0x060000FC RID: 252 RVA: 0x0000A7CC File Offset: 0x000089CC
	public T DBCMP09X3dhTzG7ltpdUYMITv<T>()
	{
		bool drxWLpNmkNm6CNZBgQJwRBebB = this.DrxWLpNmkNm6CNZBgQJwRBebB;
		bool flag = drxWLpNmkNm6CNZBgQJwRBebB;
		T t;
		if (flag)
		{
			t = (T)((object)this.DOHjafDmqS0IFz4rXV88tZ5yS.GetProperty(this.Deh6uXv55TBzpNCpPjFRI6uvY, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).GetValue(null));
		}
		else
		{
			t = (T)((object)this.DOHjafDmqS0IFz4rXV88tZ5yS.GetField(this.Deh6uXv55TBzpNCpPjFRI6uvY, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).GetValue(null));
		}
		return t;
	}

	// Token: 0x060000FD RID: 253 RVA: 0x0000A830 File Offset: 0x00008A30
	public Type Dz6tW57BxFns2BxXLi0S2TXiF()
	{
		bool drxWLpNmkNm6CNZBgQJwRBebB = this.DrxWLpNmkNm6CNZBgQJwRBebB;
		bool flag = drxWLpNmkNm6CNZBgQJwRBebB;
		Type type;
		if (flag)
		{
			type = this.DOHjafDmqS0IFz4rXV88tZ5yS.GetProperty(this.Deh6uXv55TBzpNCpPjFRI6uvY, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).PropertyType;
		}
		else
		{
			type = this.DOHjafDmqS0IFz4rXV88tZ5yS.GetField(this.Deh6uXv55TBzpNCpPjFRI6uvY, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).FieldType;
		}
		return type;
	}

	// Token: 0x060000FE RID: 254 RVA: 0x0000A888 File Offset: 0x00008A88
	public void DQUVdiEFDb2ugi6tiKPbDRuQV(object o)
	{
		try
		{
			bool drxWLpNmkNm6CNZBgQJwRBebB = this.DrxWLpNmkNm6CNZBgQJwRBebB;
			bool flag = drxWLpNmkNm6CNZBgQJwRBebB;
			if (flag)
			{
				this.DOHjafDmqS0IFz4rXV88tZ5yS.GetProperty(this.Deh6uXv55TBzpNCpPjFRI6uvY, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).SetValue(null, o);
			}
			else
			{
				this.DOHjafDmqS0IFz4rXV88tZ5yS.GetField(this.Deh6uXv55TBzpNCpPjFRI6uvY, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).SetValue(null, o);
			}
		}
		catch
		{
		}
	}

	// Token: 0x0400012F RID: 303
	public DA7EjeELhPnQjMBiXW309VJV4 DJlJTMsR8q8RN0RCA0fyq7LLD;

	// Token: 0x04000130 RID: 304
	public Type DOHjafDmqS0IFz4rXV88tZ5yS;

	// Token: 0x04000131 RID: 305
	public string DY023HqubRJHq5VeFVgWZNqT7;

	// Token: 0x04000132 RID: 306
	public string Deh6uXv55TBzpNCpPjFRI6uvY;

	// Token: 0x04000133 RID: 307
	public bool DrxWLpNmkNm6CNZBgQJwRBebB;
}
