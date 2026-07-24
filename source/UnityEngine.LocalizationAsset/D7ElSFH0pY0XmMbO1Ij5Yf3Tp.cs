using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000022 RID: 34
public class D7ElSFH0pY0XmMbO1Ij5Yf3Tp : MonoBehaviour
{
	// Token: 0x06000092 RID: 146 RVA: 0x00007C03 File Offset: 0x00005E03
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void Dm3RBxl6PEVNUdNhLljMpDOaI()
	{
		Provider.onClientDisconnected = (Provider.ClientDisconnected)Delegate.Combine(Provider.onClientDisconnected, new Provider.ClientDisconnected(D7ElSFH0pY0XmMbO1Ij5Yf3Tp.DNkvz4hmgUqQvHtfp1QvGI8w0));
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00007C28 File Offset: 0x00005E28
	public void Awake()
	{
		try
		{
			this.D9cECCoifnOJeCtYnk8Sdqx15 = base.GetComponent<Player>();
			D7ElSFH0pY0XmMbO1Ij5Yf3Tp.Dvs6QtvhDlgYO3NyBTyui6hw6.Add(this.D9cECCoifnOJeCtYnk8Sdqx15.GetNetId().id, this);
			D7ElSFH0pY0XmMbO1Ij5Yf3Tp.DI6hlaHSvDDrbtUXgu1QazZzt.Add(this.D9cECCoifnOJeCtYnk8Sdqx15, this);
			this.DSfxGJPe3ZOlAsawowRUbmvp8 = default(DzhV1YtDW49AaPKWmZABrRSE5);
			this.DbYaabEAoeQT7srrwM3GwfLLq();
		}
		catch (Exception ex)
		{
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.Message);
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.StackTrace);
		}
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00007CB4 File Offset: 0x00005EB4
	public Vector3 Dzo9lNH7U2XEdXM6IlStBGiUs(Drvin9V0cgPlOe7ofbFCim7y0 al)
	{
		this.DKgyzghAOETrnG9eE8jNamNsX();
		Vector3 vector;
		switch (al)
		{
		case Drvin9V0cgPlOe7ofbFCim7y0.Head:
			vector = this.DSfxGJPe3ZOlAsawowRUbmvp8.DPohcXu0LdIpAbvwEoaPmsnHn.transform.position + Vector3.up * 0.4f;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.Body:
			vector = this.DSfxGJPe3ZOlAsawowRUbmvp8.DOuzO1Z3EynV0WxLnBxaF55Sp.transform.position;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.LeftLeg:
			vector = this.DSfxGJPe3ZOlAsawowRUbmvp8.De7LNoaEI0w3IXiQXrQFSDwAZ.transform.position;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.RightLeg:
			vector = this.DSfxGJPe3ZOlAsawowRUbmvp8.DEyuwCRKAjMvK0kV0UEUs3d0N.transform.position;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.LeftHand:
			vector = this.DSfxGJPe3ZOlAsawowRUbmvp8.DGTjP5RGX5DKCRhyDCQFwQ6WT.transform.position;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.RightHand:
			vector = this.DSfxGJPe3ZOlAsawowRUbmvp8.DUYqfENVTbBSX41ROvgSAjGpy.transform.position;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.Random:
			vector = this.Dzo9lNH7U2XEdXM6IlStBGiUs((Drvin9V0cgPlOe7ofbFCim7y0)global::UnityEngine.Random.Range(0, 6));
			break;
		default:
			vector = base.transform.position;
			break;
		}
		return vector;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00007DC0 File Offset: 0x00005FC0
	public Vector3 DB8DY4PxMp5j6tymH8MuHtu8L()
	{
		this.DKgyzghAOETrnG9eE8jNamNsX();
		bool flag = !Physics.Linecast(DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.position, this.DSfxGJPe3ZOlAsawowRUbmvp8.DPohcXu0LdIpAbvwEoaPmsnHn.position, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
		Vector3 vector;
		if (flag)
		{
			vector = this.DSfxGJPe3ZOlAsawowRUbmvp8.DPohcXu0LdIpAbvwEoaPmsnHn.position + Vector3.up * 0.4f;
		}
		else
		{
			bool flag2 = !Physics.Linecast(DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.position, this.DSfxGJPe3ZOlAsawowRUbmvp8.DOuzO1Z3EynV0WxLnBxaF55Sp.position, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
			if (flag2)
			{
				vector = this.DSfxGJPe3ZOlAsawowRUbmvp8.DOuzO1Z3EynV0WxLnBxaF55Sp.position;
			}
			else
			{
				bool flag3 = !Physics.Linecast(DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.position, this.DSfxGJPe3ZOlAsawowRUbmvp8.DGTjP5RGX5DKCRhyDCQFwQ6WT.position, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
				if (flag3)
				{
					vector = this.DSfxGJPe3ZOlAsawowRUbmvp8.DGTjP5RGX5DKCRhyDCQFwQ6WT.position;
				}
				else
				{
					bool flag4 = !Physics.Linecast(DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.position, this.DSfxGJPe3ZOlAsawowRUbmvp8.DUYqfENVTbBSX41ROvgSAjGpy.position, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
					if (flag4)
					{
						vector = this.DSfxGJPe3ZOlAsawowRUbmvp8.DUYqfENVTbBSX41ROvgSAjGpy.position;
					}
					else
					{
						bool flag5 = !Physics.Linecast(DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.position, this.DSfxGJPe3ZOlAsawowRUbmvp8.De7LNoaEI0w3IXiQXrQFSDwAZ.position, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
						if (flag5)
						{
							vector = this.DSfxGJPe3ZOlAsawowRUbmvp8.De7LNoaEI0w3IXiQXrQFSDwAZ.position;
						}
						else
						{
							bool flag6 = !Physics.Linecast(DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.position, this.DSfxGJPe3ZOlAsawowRUbmvp8.DEyuwCRKAjMvK0kV0UEUs3d0N.position, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
							if (flag6)
							{
								vector = this.DSfxGJPe3ZOlAsawowRUbmvp8.DEyuwCRKAjMvK0kV0UEUs3d0N.position;
							}
							else
							{
								vector = this.DSfxGJPe3ZOlAsawowRUbmvp8.DPohcXu0LdIpAbvwEoaPmsnHn.position + Vector3.up * 0.4f;
							}
						}
					}
				}
			}
		}
		return vector;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00007FD0 File Offset: 0x000061D0
	public Transform DqNMwhnf1mKfT3pnYxoJt0pPe(Drvin9V0cgPlOe7ofbFCim7y0 al)
	{
		this.DKgyzghAOETrnG9eE8jNamNsX();
		Transform transform;
		switch (al)
		{
		case Drvin9V0cgPlOe7ofbFCim7y0.Head:
			transform = this.DSfxGJPe3ZOlAsawowRUbmvp8.DPohcXu0LdIpAbvwEoaPmsnHn.transform;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.Body:
			transform = this.DSfxGJPe3ZOlAsawowRUbmvp8.DOuzO1Z3EynV0WxLnBxaF55Sp.transform;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.LeftLeg:
			transform = this.DSfxGJPe3ZOlAsawowRUbmvp8.De7LNoaEI0w3IXiQXrQFSDwAZ.transform;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.RightLeg:
			transform = this.DSfxGJPe3ZOlAsawowRUbmvp8.DEyuwCRKAjMvK0kV0UEUs3d0N.transform;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.LeftHand:
			transform = this.DSfxGJPe3ZOlAsawowRUbmvp8.DGTjP5RGX5DKCRhyDCQFwQ6WT.transform;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.RightHand:
			transform = this.DSfxGJPe3ZOlAsawowRUbmvp8.DUYqfENVTbBSX41ROvgSAjGpy.transform;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.Random:
			transform = this.DqNMwhnf1mKfT3pnYxoJt0pPe((Drvin9V0cgPlOe7ofbFCim7y0)global::UnityEngine.Random.Range(0, 6));
			break;
		default:
			transform = base.transform;
			break;
		}
		return transform;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x000080A0 File Offset: 0x000062A0
	public Transform Di1EVHMrJyeCCJIVX4L04N0Mf()
	{
		this.DKgyzghAOETrnG9eE8jNamNsX();
		bool flag = !Physics.Linecast(DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.position, this.DSfxGJPe3ZOlAsawowRUbmvp8.DPohcXu0LdIpAbvwEoaPmsnHn.position, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
		Transform transform;
		if (flag)
		{
			transform = this.DSfxGJPe3ZOlAsawowRUbmvp8.DPohcXu0LdIpAbvwEoaPmsnHn;
		}
		else
		{
			bool flag2 = !Physics.Linecast(DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.position, this.DSfxGJPe3ZOlAsawowRUbmvp8.DOuzO1Z3EynV0WxLnBxaF55Sp.position, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
			if (flag2)
			{
				transform = this.DSfxGJPe3ZOlAsawowRUbmvp8.DOuzO1Z3EynV0WxLnBxaF55Sp;
			}
			else
			{
				bool flag3 = !Physics.Linecast(DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.position, this.DSfxGJPe3ZOlAsawowRUbmvp8.DGTjP5RGX5DKCRhyDCQFwQ6WT.position, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
				if (flag3)
				{
					transform = this.DSfxGJPe3ZOlAsawowRUbmvp8.DGTjP5RGX5DKCRhyDCQFwQ6WT;
				}
				else
				{
					bool flag4 = !Physics.Linecast(DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.position, this.DSfxGJPe3ZOlAsawowRUbmvp8.DUYqfENVTbBSX41ROvgSAjGpy.position, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
					if (flag4)
					{
						transform = this.DSfxGJPe3ZOlAsawowRUbmvp8.DUYqfENVTbBSX41ROvgSAjGpy;
					}
					else
					{
						bool flag5 = !Physics.Linecast(DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.position, this.DSfxGJPe3ZOlAsawowRUbmvp8.De7LNoaEI0w3IXiQXrQFSDwAZ.position, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
						if (flag5)
						{
							transform = this.DSfxGJPe3ZOlAsawowRUbmvp8.De7LNoaEI0w3IXiQXrQFSDwAZ;
						}
						else
						{
							bool flag6 = !Physics.Linecast(DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.position, this.DSfxGJPe3ZOlAsawowRUbmvp8.DEyuwCRKAjMvK0kV0UEUs3d0N.position, RayMasks.DAMAGE_CLIENT, QueryTriggerInteraction.Ignore);
							if (flag6)
							{
								transform = this.DSfxGJPe3ZOlAsawowRUbmvp8.DEyuwCRKAjMvK0kV0UEUs3d0N;
							}
							else
							{
								transform = this.DSfxGJPe3ZOlAsawowRUbmvp8.DPohcXu0LdIpAbvwEoaPmsnHn;
							}
						}
					}
				}
			}
		}
		return transform;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00008264 File Offset: 0x00006464
	private void DKgyzghAOETrnG9eE8jNamNsX()
	{
		bool flag = this.DSfxGJPe3ZOlAsawowRUbmvp8.DPohcXu0LdIpAbvwEoaPmsnHn == null || this.DSfxGJPe3ZOlAsawowRUbmvp8.DOuzO1Z3EynV0WxLnBxaF55Sp == null || this.DSfxGJPe3ZOlAsawowRUbmvp8.DGTjP5RGX5DKCRhyDCQFwQ6WT == null || this.DSfxGJPe3ZOlAsawowRUbmvp8.DUYqfENVTbBSX41ROvgSAjGpy == null || this.DSfxGJPe3ZOlAsawowRUbmvp8.De7LNoaEI0w3IXiQXrQFSDwAZ == null || this.DSfxGJPe3ZOlAsawowRUbmvp8.DEyuwCRKAjMvK0kV0UEUs3d0N == null;
		if (flag)
		{
			this.DbYaabEAoeQT7srrwM3GwfLLq();
		}
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000082F4 File Offset: 0x000064F4
	public void DbYaabEAoeQT7srrwM3GwfLLq()
	{
		foreach (Collider collider in base.gameObject.GetComponentsInChildren<Collider>())
		{
			string name = collider.name;
			bool flag = !(name == "Skull");
			if (flag)
			{
				bool flag2 = !(name == "Spine");
				if (flag2)
				{
					bool flag3 = !(name == "Right_Arm");
					if (flag3)
					{
						bool flag4 = !(name == "Left_Arm");
						if (flag4)
						{
							bool flag5 = !(name == "Left_Leg");
							if (flag5)
							{
								bool flag6 = name == "Right_Leg";
								if (flag6)
								{
									this.DSfxGJPe3ZOlAsawowRUbmvp8.DVWVESlVhjLWEmU409bDSvX8S = collider.transform;
									foreach (Transform transform in collider.GetComponentsInChildren<Transform>())
									{
										bool flag7 = transform.name == "Right_Foot";
										if (flag7)
										{
											this.DSfxGJPe3ZOlAsawowRUbmvp8.DEyuwCRKAjMvK0kV0UEUs3d0N = transform;
											break;
										}
									}
								}
							}
							else
							{
								this.DSfxGJPe3ZOlAsawowRUbmvp8.DVplHhAHoaIRjUBGSCrH3iWfs = collider.transform;
								foreach (Transform transform2 in collider.GetComponentsInChildren<Transform>())
								{
									bool flag8 = transform2.name == "Left_Foot";
									if (flag8)
									{
										this.DSfxGJPe3ZOlAsawowRUbmvp8.De7LNoaEI0w3IXiQXrQFSDwAZ = transform2;
										break;
									}
								}
							}
						}
						else
						{
							this.DSfxGJPe3ZOlAsawowRUbmvp8.DwW4dPtyRXoOtvUSvFv823zI4 = collider.transform;
							foreach (Transform transform3 in collider.GetComponentsInChildren<Transform>())
							{
								bool flag9 = transform3.name == "Left_Hand";
								if (flag9)
								{
									this.DSfxGJPe3ZOlAsawowRUbmvp8.DGTjP5RGX5DKCRhyDCQFwQ6WT = transform3;
								}
								else
								{
									bool flag10 = transform3.name == "Left_Hook";
									if (flag10)
									{
										this.DSfxGJPe3ZOlAsawowRUbmvp8.D3SCrtV6CPWxlnb4N2clUA3dW = transform3;
									}
								}
							}
						}
					}
					else
					{
						this.DSfxGJPe3ZOlAsawowRUbmvp8.DBVgM7zxhtntTBg44bfU0tdGo = collider.transform;
						foreach (Transform transform4 in collider.GetComponentsInChildren<Transform>())
						{
							bool flag11 = transform4.name == "Right_Hand";
							if (flag11)
							{
								this.DSfxGJPe3ZOlAsawowRUbmvp8.DUYqfENVTbBSX41ROvgSAjGpy = transform4;
							}
							else
							{
								bool flag12 = transform4.name == "Right_Hook";
								if (flag12)
								{
									this.DSfxGJPe3ZOlAsawowRUbmvp8.Dlrbbm0qfKAMYLQxtTmJHEfY1 = transform4;
								}
							}
						}
					}
				}
				else
				{
					this.DSfxGJPe3ZOlAsawowRUbmvp8.DOuzO1Z3EynV0WxLnBxaF55Sp = collider.transform;
				}
			}
			else
			{
				this.DSfxGJPe3ZOlAsawowRUbmvp8.DPohcXu0LdIpAbvwEoaPmsnHn = collider.transform;
			}
		}
	}

	// Token: 0x0600009A RID: 154 RVA: 0x000085BB File Offset: 0x000067BB
	public void OnDestroy()
	{
		D7ElSFH0pY0XmMbO1Ij5Yf3Tp.Dvs6QtvhDlgYO3NyBTyui6hw6.Remove(this.D9cECCoifnOJeCtYnk8Sdqx15.GetNetId().id);
		D7ElSFH0pY0XmMbO1Ij5Yf3Tp.DI6hlaHSvDDrbtUXgu1QazZzt.Remove(this.D9cECCoifnOJeCtYnk8Sdqx15);
	}

	// Token: 0x0600009B RID: 155 RVA: 0x000085EC File Offset: 0x000067EC
	public static void DKA0lfUf4pi3epPY0Utt9yFSo(uint playerNetId, Player p = null)
	{
		bool flag = D7ElSFH0pY0XmMbO1Ij5Yf3Tp.Dvs6QtvhDlgYO3NyBTyui6hw6.ContainsKey(playerNetId);
		if (flag)
		{
			D7ElSFH0pY0XmMbO1Ij5Yf3Tp.Dvs6QtvhDlgYO3NyBTyui6hw6.Remove(playerNetId);
		}
		bool flag2 = p != null;
		if (flag2)
		{
			D7ElSFH0pY0XmMbO1Ij5Yf3Tp.DI6hlaHSvDDrbtUXgu1QazZzt.Remove(p);
		}
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00008630 File Offset: 0x00006830
	public static void DNkvz4hmgUqQvHtfp1QvGI8w0()
	{
		D7ElSFH0pY0XmMbO1Ij5Yf3Tp.Dvs6QtvhDlgYO3NyBTyui6hw6.Clear();
		D7ElSFH0pY0XmMbO1Ij5Yf3Tp.DI6hlaHSvDDrbtUXgu1QazZzt.Clear();
	}

	// Token: 0x040000D0 RID: 208
	public static Dictionary<Player, D7ElSFH0pY0XmMbO1Ij5Yf3Tp> DI6hlaHSvDDrbtUXgu1QazZzt = new Dictionary<Player, D7ElSFH0pY0XmMbO1Ij5Yf3Tp>();

	// Token: 0x040000D1 RID: 209
	public static Dictionary<uint, D7ElSFH0pY0XmMbO1Ij5Yf3Tp> Dvs6QtvhDlgYO3NyBTyui6hw6 = new Dictionary<uint, D7ElSFH0pY0XmMbO1Ij5Yf3Tp>();

	// Token: 0x040000D2 RID: 210
	public static Dictionary<uint, ushort> DaicsnJorHulnampu0JgsPlC0 = new Dictionary<uint, ushort>();

	// Token: 0x040000D3 RID: 211
	public static Dictionary<uint, ushort> DohYvCb2o7W6QvQ0VgkYyEHx9 = new Dictionary<uint, ushort>();

	// Token: 0x040000D4 RID: 212
	public GameObject D7WlY6wMBa05qw5mCTl3NsttE;

	// Token: 0x040000D5 RID: 213
	public DzhV1YtDW49AaPKWmZABrRSE5 DSfxGJPe3ZOlAsawowRUbmvp8;

	// Token: 0x040000D6 RID: 214
	public Player D9cECCoifnOJeCtYnk8Sdqx15;
}
