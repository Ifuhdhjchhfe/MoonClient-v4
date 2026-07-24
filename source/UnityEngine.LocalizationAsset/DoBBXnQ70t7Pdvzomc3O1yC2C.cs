using System;

// Token: 0x02000092 RID: 146
public class DoBBXnQ70t7Pdvzomc3O1yC2C<T>
{
	// Token: 0x060002C6 RID: 710 RVA: 0x0002967C File Offset: 0x0002787C
	public DoBBXnQ70t7Pdvzomc3O1yC2C()
	{
		this._enum = (T)((object)Enum.GetValues(this._enum.GetType()).GetValue(0));
		this.enumValues = Enum.GetValues(this._enum.GetType());
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x000296DF File Offset: 0x000278DF
	public DoBBXnQ70t7Pdvzomc3O1yC2C(T _enum)
	{
		this._enum = _enum;
		this.enumValues = Enum.GetValues(_enum.GetType());
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x00029714 File Offset: 0x00027914
	public static implicit operator T(DoBBXnQ70t7Pdvzomc3O1yC2C<T> _enum)
	{
		return _enum._enum;
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x0002972C File Offset: 0x0002792C
	public static implicit operator DoBBXnQ70t7Pdvzomc3O1yC2C<T>(T _enum)
	{
		return new DoBBXnQ70t7Pdvzomc3O1yC2C<T>(_enum);
	}

	// Token: 0x060002CA RID: 714 RVA: 0x00029744 File Offset: 0x00027944
	public override string ToString()
	{
		return this._enum.ToString();
	}

	// Token: 0x04000332 RID: 818
	public float holdTime = 0f;

	// Token: 0x04000333 RID: 819
	public Array enumValues;

	// Token: 0x04000334 RID: 820
	public T _enum;
}
