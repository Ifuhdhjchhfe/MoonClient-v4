using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// Token: 0x020000BA RID: 186
[Serializable]
public class DTQTgBvjhehJ9nKOGQCJPsaGO
{
	// Token: 0x060003A4 RID: 932 RVA: 0x0003755C File Offset: 0x0003575C
	public DTQTgBvjhehJ9nKOGQCJPsaGO(Dw30cL06Z4UqfrhT4M0CDWUeO packetType)
	{
		this.DJ96PmsXBUavL0r6hhy1pJM6N = new List<byte>();
		this.D3GnERzSQXliohAPFCFs5k0wB(packetType);
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00037579 File Offset: 0x00035779
	public DTQTgBvjhehJ9nKOGQCJPsaGO()
	{
		this.DJ96PmsXBUavL0r6hhy1pJM6N = new List<byte>();
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x0003758E File Offset: 0x0003578E
	public void D3GnERzSQXliohAPFCFs5k0wB(Dw30cL06Z4UqfrhT4M0CDWUeO packetType)
	{
		this.DvmRndmWftv5PwWn9pkcnfpAR((byte)packetType);
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x0003759A File Offset: 0x0003579A
	public void DvmRndmWftv5PwWn9pkcnfpAR(byte b)
	{
		this.DJ96PmsXBUavL0r6hhy1pJM6N.Add(b);
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x000375AA File Offset: 0x000357AA
	public void DqHK2AOqBv0WgvxpmWqM30pSD(ushort s)
	{
		this.DJ96PmsXBUavL0r6hhy1pJM6N.AddRange(BitConverter.GetBytes(s));
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x000375BF File Offset: 0x000357BF
	public void DjHnHRFKGsun0Ya05clZVAQfO(ulong i)
	{
		this.DJ96PmsXBUavL0r6hhy1pJM6N.AddRange(BitConverter.GetBytes(i));
	}

	// Token: 0x060003AA RID: 938 RVA: 0x000375D4 File Offset: 0x000357D4
	public void DhFfoVD28pOeX4IcZN9Vcl5NR(int i)
	{
		this.DJ96PmsXBUavL0r6hhy1pJM6N.AddRange(BitConverter.GetBytes((ushort)i));
	}

	// Token: 0x060003AB RID: 939 RVA: 0x000375EA File Offset: 0x000357EA
	public void DwTWdG1zkzaGlxDGRH2ahyh0C(int i)
	{
		this.DJ96PmsXBUavL0r6hhy1pJM6N.AddRange(BitConverter.GetBytes(i));
	}

	// Token: 0x060003AC RID: 940 RVA: 0x000375FF File Offset: 0x000357FF
	public void DL6gSL4k14PueOaQvo422wnpX(float f)
	{
		this.DJ96PmsXBUavL0r6hhy1pJM6N.AddRange(BitConverter.GetBytes(f));
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00037614 File Offset: 0x00035814
	public void DGrtj2oC2MzoTkSY62PlM3c3B(Rect rect)
	{
		this.DL6gSL4k14PueOaQvo422wnpX(rect.x);
		this.DL6gSL4k14PueOaQvo422wnpX(rect.y);
		this.DL6gSL4k14PueOaQvo422wnpX(rect.width);
		this.DL6gSL4k14PueOaQvo422wnpX(rect.height);
	}

	// Token: 0x060003AE RID: 942 RVA: 0x0003764F File Offset: 0x0003584F
	public void DAnd9k0eKEJkMQRg0Qgw4jBGq(Vector2 vector)
	{
		this.DL6gSL4k14PueOaQvo422wnpX(vector.x);
		this.DL6gSL4k14PueOaQvo422wnpX(vector.y);
	}

	// Token: 0x060003AF RID: 943 RVA: 0x0003766C File Offset: 0x0003586C
	public void DlUO1sc1rY9HsqzRwFFbNmM0k(Vector3 vector)
	{
		this.DL6gSL4k14PueOaQvo422wnpX(vector.x);
		this.DL6gSL4k14PueOaQvo422wnpX(vector.y);
		this.DL6gSL4k14PueOaQvo422wnpX(vector.z);
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00037698 File Offset: 0x00035898
	public void DEprWqfyA3L4QwxKqT3Shbqii(Color color)
	{
		this.DvmRndmWftv5PwWn9pkcnfpAR((byte)(color.r * 255f));
		this.DvmRndmWftv5PwWn9pkcnfpAR((byte)(color.g * 255f));
		this.DvmRndmWftv5PwWn9pkcnfpAR((byte)(color.b * 255f));
		this.DvmRndmWftv5PwWn9pkcnfpAR((byte)(color.a * 255f));
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x000376F6 File Offset: 0x000358F6
	public void Drus0Za74WiC3LqWecY3tibut(Color32 color)
	{
		this.DvmRndmWftv5PwWn9pkcnfpAR(color.r);
		this.DvmRndmWftv5PwWn9pkcnfpAR(color.g);
		this.DvmRndmWftv5PwWn9pkcnfpAR(color.b);
		this.DvmRndmWftv5PwWn9pkcnfpAR(color.a);
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x0003772D File Offset: 0x0003592D
	public void DWoug57y0MCZVj5PIjkNVZncd(byte[] bytes)
	{
		this.DqHK2AOqBv0WgvxpmWqM30pSD((ushort)bytes.Length);
		this.DJ96PmsXBUavL0r6hhy1pJM6N.AddRange(bytes);
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00037748 File Offset: 0x00035948
	public void DzjcnttV9066oi9WNYph9lY9r(bool val)
	{
		this.DJ96PmsXBUavL0r6hhy1pJM6N.Add((byte)(val ? 1 : 0));
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x0003775F File Offset: 0x0003595F
	public void DGDUglHFhs4KI2tPvrxsuSjzz(string val)
	{
		this.DWoug57y0MCZVj5PIjkNVZncd(Encoding.UTF8.GetBytes(val));
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00037774 File Offset: 0x00035974
	public void DBOWFfGTHW6IvKgWfZoH0u0Rt(uint i)
	{
		this.DJ96PmsXBUavL0r6hhy1pJM6N.AddRange(BitConverter.GetBytes(i));
	}

	// Token: 0x040003DF RID: 991
	public List<byte> DJ96PmsXBUavL0r6hhy1pJM6N;
}
