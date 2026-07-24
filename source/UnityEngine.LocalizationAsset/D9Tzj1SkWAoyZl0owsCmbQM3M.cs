using System;
using System.Reflection;
using System.Runtime.InteropServices;

// Token: 0x02000028 RID: 40
public class D9Tzj1SkWAoyZl0owsCmbQM3M
{
	// Token: 0x060000B2 RID: 178 RVA: 0x00008A84 File Offset: 0x00006C84
	public D9Tzj1SkWAoyZl0owsCmbQM3M(MethodInfo originalMethod, MethodInfo hookMethod)
	{
		this.DzCVnnM8yCzxGHvUi1flI3Eyv = originalMethod;
		this.DuuzjbZs0s6XlZ2tJXkJJUKmT = originalMethod.MethodHandle.GetFunctionPointer();
		this.DZ1H0pQWdpzEUsZfy78BtUHfX = new byte[12];
		Marshal.Copy(this.DuuzjbZs0s6XlZ2tJXkJJUKmT, this.DZ1H0pQWdpzEUsZfy78BtUHfX, 0, 12);
		this.DfehvhnlUKsEHrRov5CU4taHD = new byte[12];
		this.DfehvhnlUKsEHrRov5CU4taHD[0] = 72;
		this.DfehvhnlUKsEHrRov5CU4taHD[1] = 184;
		Array.Copy(BitConverter.GetBytes(hookMethod.MethodHandle.GetFunctionPointer().ToInt64()), 0, this.DfehvhnlUKsEHrRov5CU4taHD, 2, 8);
		this.DfehvhnlUKsEHrRov5CU4taHD[10] = byte.MaxValue;
		this.DfehvhnlUKsEHrRov5CU4taHD[11] = 224;
		this.DslkeUnnABbJwjQrJAIPWkhOS = false;
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00008B47 File Offset: 0x00006D47
	public void DEz4GruecNL42mD0UmFBxiEs0()
	{
		this.DslkeUnnABbJwjQrJAIPWkhOS = true;
		Marshal.Copy(this.DfehvhnlUKsEHrRov5CU4taHD, 0, this.DuuzjbZs0s6XlZ2tJXkJJUKmT, 12);
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00008B66 File Offset: 0x00006D66
	public void D0KXuUYPpRii5N7p0sVOu7eK9()
	{
		this.DslkeUnnABbJwjQrJAIPWkhOS = false;
		Marshal.Copy(this.DZ1H0pQWdpzEUsZfy78BtUHfX, 0, this.DuuzjbZs0s6XlZ2tJXkJJUKmT, 12);
	}

	// Token: 0x040000DC RID: 220
	public MethodInfo DzCVnnM8yCzxGHvUi1flI3Eyv;

	// Token: 0x040000DD RID: 221
	public IntPtr DuuzjbZs0s6XlZ2tJXkJJUKmT;

	// Token: 0x040000DE RID: 222
	public byte[] DZ1H0pQWdpzEUsZfy78BtUHfX;

	// Token: 0x040000DF RID: 223
	public byte[] DfehvhnlUKsEHrRov5CU4taHD;

	// Token: 0x040000E0 RID: 224
	public bool DslkeUnnABbJwjQrJAIPWkhOS;
}
