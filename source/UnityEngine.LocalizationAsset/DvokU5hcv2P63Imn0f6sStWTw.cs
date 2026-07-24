using System;
using UnityEngine;

// Token: 0x020000C6 RID: 198
public struct DvokU5hcv2P63Imn0f6sStWTw
{
	// Token: 0x060003DC RID: 988 RVA: 0x000382F0 File Offset: 0x000364F0
	public DvokU5hcv2P63Imn0f6sStWTw(Vector3 startPoint, Vector3 endPoint, float deleteProgression, uint tracerIndex)
	{
		this.DbzYNqzkiPiXKfymPXn5wgL6w = startPoint;
		this.DjzgyyDW7duyS17YJw456Ndsi = endPoint;
		this.DTaN0Zd5kEDhBTrt2ZZtoSHLR = tracerIndex;
		bool useGLTracers = DfU4wrswBK5kLyiyV6mHZwOg8.useGLTracers;
		bool flag = useGLTracers;
		if (flag)
		{
			this.DML2XiQQOgEOKuqQfAY7BHG2d = null;
			this.DZlSSu8C6ahV1sSnPFWXAOKD5 = null;
		}
		else
		{
			this.DML2XiQQOgEOKuqQfAY7BHG2d = global::UnityEngine.Object.Instantiate<GameObject>(DHTB5RKsHUihFrfj9ewuLh1f9.DwFaODFnGogvbEmCIybqOhCtW);
			this.DML2XiQQOgEOKuqQfAY7BHG2d.transform.position = Vector3.Lerp(startPoint, endPoint, 0.5f);
			float num = DfU4wrswBK5kLyiyV6mHZwOg8.tracersWidth * 5f;
			this.DML2XiQQOgEOKuqQfAY7BHG2d.transform.localScale = new Vector3(num, num, Vector3.Distance(startPoint, endPoint) * 5f);
			this.DML2XiQQOgEOKuqQfAY7BHG2d.transform.LookAt(endPoint);
			this.DML2XiQQOgEOKuqQfAY7BHG2d.transform.eulerAngles += new Vector3(0f, 0f, 90f);
			this.DML2XiQQOgEOKuqQfAY7BHG2d.SetActive(!DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6);
			this.DZlSSu8C6ahV1sSnPFWXAOKD5 = this.DML2XiQQOgEOKuqQfAY7BHG2d.GetComponent<MeshRenderer>().material;
			this.DZlSSu8C6ahV1sSnPFWXAOKD5.color = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Tracers color");
		}
		this.DI6mpVC2oCcVZrqNVI7hBJO2n = deleteProgression;
	}

	// Token: 0x040003F8 RID: 1016
	public GameObject DML2XiQQOgEOKuqQfAY7BHG2d;

	// Token: 0x040003F9 RID: 1017
	public Material DZlSSu8C6ahV1sSnPFWXAOKD5;

	// Token: 0x040003FA RID: 1018
	public Vector3 DbzYNqzkiPiXKfymPXn5wgL6w;

	// Token: 0x040003FB RID: 1019
	public Vector3 DjzgyyDW7duyS17YJw456Ndsi;

	// Token: 0x040003FC RID: 1020
	public float DI6mpVC2oCcVZrqNVI7hBJO2n;

	// Token: 0x040003FD RID: 1021
	public uint DTaN0Zd5kEDhBTrt2ZZtoSHLR;
}
