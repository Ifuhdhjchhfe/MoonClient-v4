using System;
using System.Reflection;

// Token: 0x020000A7 RID: 167
public class DQyA1nzDa0rZuYtgcLmIWOUf8
{
	// Token: 0x0600034D RID: 845 RVA: 0x00030FD6 File Offset: 0x0002F1D6
	public DQyA1nzDa0rZuYtgcLmIWOUf8(Type _class, string name)
	{
		this.DmHg07QSmNzCFPUJalTZOta1q = _class.GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00030FF6 File Offset: 0x0002F1F6
	public DQyA1nzDa0rZuYtgcLmIWOUf8(Type _class, string name, BindingFlags reflectionFlags)
	{
		this.DmHg07QSmNzCFPUJalTZOta1q = _class.GetMethod(name, reflectionFlags);
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00031015 File Offset: 0x0002F215
	public DQyA1nzDa0rZuYtgcLmIWOUf8(string _class, string name)
	{
		this.DmHg07QSmNzCFPUJalTZOta1q = D08iy2XFQpUQteL0XRzAbg2IE.DFmzX7ViryVFbfSQqzLlVj0VW(_class).GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	// Token: 0x06000350 RID: 848 RVA: 0x0003103A File Offset: 0x0002F23A
	public DQyA1nzDa0rZuYtgcLmIWOUf8(string _class, string name, BindingFlags reflectionFlags)
	{
		this.DmHg07QSmNzCFPUJalTZOta1q = D08iy2XFQpUQteL0XRzAbg2IE.DFmzX7ViryVFbfSQqzLlVj0VW(_class).GetMethod(name, reflectionFlags);
	}

	// Token: 0x06000351 RID: 849 RVA: 0x0003105E File Offset: 0x0002F25E
	public void D8cIakwQwndQLLxaGpd0WmH3U(object instance)
	{
		this.DerhlrP250jJEynZcsnFOlHLG = instance;
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00031068 File Offset: 0x0002F268
	public void D8bo6z6P4C0fkdfFioOF82Ftk(params object[] objs)
	{
		this.DmHg07QSmNzCFPUJalTZOta1q.Invoke(this.DerhlrP250jJEynZcsnFOlHLG, objs);
	}

	// Token: 0x06000353 RID: 851 RVA: 0x0003107E File Offset: 0x0002F27E
	public void DGHrF0Ht2QRxL0NBgNHj6ZpZX(object instance, params object[] objs)
	{
		this.DmHg07QSmNzCFPUJalTZOta1q.Invoke(instance, objs);
	}

	// Token: 0x04000393 RID: 915
	public MethodInfo DmHg07QSmNzCFPUJalTZOta1q;

	// Token: 0x04000394 RID: 916
	public object DerhlrP250jJEynZcsnFOlHLG = null;
}
