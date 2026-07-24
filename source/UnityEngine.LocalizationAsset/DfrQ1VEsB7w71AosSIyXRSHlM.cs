using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000058 RID: 88
public static class DfrQ1VEsB7w71AosSIyXRSHlM
{
	// Token: 0x0600019B RID: 411 RVA: 0x000163F0 File Offset: 0x000145F0
	public static T D5GDf6NDOOXtOKVhMfOJBmfW5<T>(this T src) where T : struct
	{
		bool flag = !typeof(T).IsEnum;
		if (flag)
		{
			throw new ArgumentException(string.Format("Argument {0} is not an Enum", typeof(T).FullName));
		}
		T[] array = (T[])Enum.GetValues(src.GetType());
		int num = Array.IndexOf<T>(array, src) + 1;
		bool flag2 = array.Length != num;
		T t;
		if (flag2)
		{
			t = array[num];
		}
		else
		{
			t = array[0];
		}
		return t;
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0001647C File Offset: 0x0001467C
	public static T DSv8futchp2HZ7PmaXj2bCMZQ<T>(this T src) where T : struct
	{
		bool flag = !typeof(T).IsEnum;
		if (flag)
		{
			throw new ArgumentException(string.Format("Argument {0} is not an Enum", typeof(T).FullName));
		}
		T[] array = (T[])Enum.GetValues(src.GetType());
		int num = Array.IndexOf<T>(array, src) - 1;
		bool flag2 = 0 <= num;
		T t;
		if (flag2)
		{
			t = array[num];
		}
		else
		{
			t = array[array.Length - 1];
		}
		return t;
	}

	// Token: 0x0600019D RID: 413 RVA: 0x0001650C File Offset: 0x0001470C
	public static ELightingVision D6HbJZ2NUXUKMVsndz6x1ZFtz(this DvbEzC20KPBbYRjl1eW9ilgCU nvt)
	{
		ELightingVision elightingVision;
		switch (nvt)
		{
		case DvbEzC20KPBbYRjl1eW9ilgCU.Military:
			elightingVision = ELightingVision.MILITARY;
			break;
		case DvbEzC20KPBbYRjl1eW9ilgCU.Civilian:
			elightingVision = ELightingVision.CIVILIAN;
			break;
		case DvbEzC20KPBbYRjl1eW9ilgCU.Custom:
			elightingVision = ELightingVision.MILITARY;
			break;
		default:
			elightingVision = ELightingVision.NONE;
			break;
		}
		return elightingVision;
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00016548 File Offset: 0x00014748
	public static string DZFMFmrqCczLVGAHUj4B9oP5G(this DcyOGWtOfXF1Fhr1GWr4wf6Ww tom)
	{
		string text;
		switch (tom)
		{
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.RightDownSided:
			text = "Right down sided";
			break;
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.RightTopSided:
			text = "Right top sided";
			break;
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.LeftTopSided:
			text = "Left top sided";
			break;
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.LeftDownSided:
			text = "Left down sided";
			break;
		case DcyOGWtOfXF1Fhr1GWr4wf6Ww.FourSided:
			text = "Four sided";
			break;
		default:
			text = "None";
			break;
		}
		return text;
	}

	// Token: 0x0600019F RID: 415 RVA: 0x000165B0 File Offset: 0x000147B0
	public static string DhxxszNNT65SPllEv6XuYmIEa(this DVeWYqH4HEAYXL5Vu3HrmvSnF tct)
	{
		DVeWYqH4HEAYXL5Vu3HrmvSnF dveWYqH4HEAYXL5Vu3HrmvSnF = tct;
		bool flag = dveWYqH4HEAYXL5Vu3HrmvSnF != DVeWYqH4HEAYXL5Vu3HrmvSnF.UpperCase;
		string text;
		if (flag)
		{
			bool flag2 = dveWYqH4HEAYXL5Vu3HrmvSnF != DVeWYqH4HEAYXL5Vu3HrmvSnF.LowerCase;
			if (flag2)
			{
				text = tct.ToString();
			}
			else
			{
				text = "Lower case";
			}
		}
		else
		{
			text = "Upper case";
		}
		return text;
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00016604 File Offset: 0x00014804
	public static ELimb DG8Vk5LC0j20si9xsv3no34VC(this Drvin9V0cgPlOe7ofbFCim7y0 limb)
	{
		ELimb elimb;
		switch (limb)
		{
		case Drvin9V0cgPlOe7ofbFCim7y0.Head:
			elimb = ELimb.SKULL;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.Body:
			elimb = ELimb.SPINE;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.LeftLeg:
			elimb = ELimb.LEFT_LEG;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.RightLeg:
			elimb = ELimb.RIGHT_LEG;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.LeftHand:
			elimb = ELimb.LEFT_HAND;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.RightHand:
			elimb = ELimb.RIGHT_HAND;
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.Random:
		{
			bool flag = global::UnityEngine.Random.Range(0, 100) < DCS4Jf0LRzsehKFc5QOLL06qw.randomLimbHeadHitChance;
			if (flag)
			{
				elimb = ELimb.SKULL;
			}
			else
			{
				ELimb[] array = new ELimb[]
				{
					ELimb.SPINE,
					ELimb.LEFT_LEG,
					ELimb.RIGHT_LEG,
					ELimb.LEFT_HAND,
					ELimb.RIGHT_HAND
				};
				elimb = array[global::UnityEngine.Random.Range(0, array.Length)];
			}
			break;
		}
		default:
			elimb = ELimb.SPINE;
			break;
		}
		return elimb;
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x000166A0 File Offset: 0x000148A0
	public static Dr5qliNNQh3jZolh9fn7SFNyi Ddqyz74I7QJMuE9u85cwfj76F(this object o)
	{
		bool flag = o is Player;
		Dr5qliNNQh3jZolh9fn7SFNyi dr5qliNNQh3jZolh9fn7SFNyi;
		if (flag)
		{
			dr5qliNNQh3jZolh9fn7SFNyi = Dr5qliNNQh3jZolh9fn7SFNyi.Player;
		}
		else
		{
			bool flag2 = o is InteractableClaim;
			if (flag2)
			{
				dr5qliNNQh3jZolh9fn7SFNyi = Dr5qliNNQh3jZolh9fn7SFNyi.ClaimFlags;
			}
			else
			{
				bool flag3 = o is InteractableBed;
				if (flag3)
				{
					dr5qliNNQh3jZolh9fn7SFNyi = Dr5qliNNQh3jZolh9fn7SFNyi.Beds;
				}
				else
				{
					bool flag4 = o is InteractableStorage;
					if (flag4)
					{
						dr5qliNNQh3jZolh9fn7SFNyi = Dr5qliNNQh3jZolh9fn7SFNyi.Storages;
					}
					else
					{
						bool flag5 = o is Zombie;
						if (flag5)
						{
							dr5qliNNQh3jZolh9fn7SFNyi = Dr5qliNNQh3jZolh9fn7SFNyi.Zombies;
						}
						else
						{
							bool flag6 = o is Animal;
							if (flag6)
							{
								dr5qliNNQh3jZolh9fn7SFNyi = Dr5qliNNQh3jZolh9fn7SFNyi.Animals;
							}
							else
							{
								bool flag7 = o is InteractableVehicle;
								if (flag7)
								{
									dr5qliNNQh3jZolh9fn7SFNyi = Dr5qliNNQh3jZolh9fn7SFNyi.Vehicles;
								}
								else
								{
									dr5qliNNQh3jZolh9fn7SFNyi = Dr5qliNNQh3jZolh9fn7SFNyi.ClaimFlags;
								}
							}
						}
					}
				}
			}
		}
		return dr5qliNNQh3jZolh9fn7SFNyi;
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00016748 File Offset: 0x00014948
	public static string DuubTBloaQZGfJumICGlMLU54(this DyZOPUgVlLGDIfwra38xGmDBF hst)
	{
		switch (hst)
		{
		case DyZOPUgVlLGDIfwra38xGmDBF.SendRandomHWID:
			return "Send random HWID";
		case DyZOPUgVlLGDIfwra38xGmDBF.UsePseudoHWID:
			return "Use pseudo HWID";
		case DyZOPUgVlLGDIfwra38xGmDBF.SendRealHWID:
			return "Send real HWID";
		case DyZOPUgVlLGDIfwra38xGmDBF.SendNoHWID:
			return "Don't send HWID";
		}
		return hst.ToString();
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x000167A8 File Offset: 0x000149A8
	public static string DjQEl00wkokoQvcg4zoynePAI(this DEaNNGRxJag20zwKVRmcuyQsU st)
	{
		string text;
		switch (st)
		{
		case DEaNNGRxJag20zwKVRmcuyQsU.DontOverride:
			text = "Dont override";
			break;
		case DEaNNGRxJag20zwKVRmcuyQsU.SendCustomImage:
			text = "Send custom image";
			break;
		case DEaNNGRxJag20zwKVRmcuyQsU.SpyWithDelay:
			text = "Spy with delay";
			break;
		case DEaNNGRxJag20zwKVRmcuyQsU.SpyInFourFrames:
			text = "Bypass spy in four frames";
			break;
		case DEaNNGRxJag20zwKVRmcuyQsU.SpyInOneFrame:
			text = "Bypass spy in one frame";
			break;
		case DEaNNGRxJag20zwKVRmcuyQsU.DeclineSpy:
			text = "Decline spy";
			break;
		default:
			text = st.ToString();
			break;
		}
		return text;
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x00016820 File Offset: 0x00014A20
	public static string DfTb0KIxut8BiYm5E7g8noDnd(this DokdtlMHqRTX0KbeCtveFDTNT sat)
	{
		string text;
		switch (sat)
		{
		case DokdtlMHqRTX0KbeCtveFDTNT.Aim:
			text = "Silent";
			break;
		case DokdtlMHqRTX0KbeCtveFDTNT.Distance:
			text = "Distance";
			break;
		case DokdtlMHqRTX0KbeCtveFDTNT.Sphere:
			text = "Sphere";
			break;
		default:
			text = sat.ToString();
			break;
		}
		return text;
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x00016874 File Offset: 0x00014A74
	public static string D2uLy2Wbnd3dl3UpzAGrd6DCL(this DjTmlwWXHjmuTJsdebq9LFq0y sat)
	{
		string text;
		switch (sat)
		{
		case DjTmlwWXHjmuTJsdebq9LFq0y.WalkLeft:
			text = "Left";
			break;
		case DjTmlwWXHjmuTJsdebq9LFq0y.WalkRight:
			text = "Right";
			break;
		case DjTmlwWXHjmuTJsdebq9LFq0y.WalkBack:
			text = "Backwards";
			break;
		case DjTmlwWXHjmuTJsdebq9LFq0y.TwoTactSpin:
			text = "180 Spin";
			break;
		case DjTmlwWXHjmuTJsdebq9LFq0y.FourTactSpin:
			text = "360 Spin";
			break;
		default:
			text = sat.ToString();
			break;
		}
		return text;
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x000168E0 File Offset: 0x00014AE0
	public static string Dq6eNqgaZn6PYh50FMK07NzNt(this Drvin9V0cgPlOe7ofbFCim7y0 sat)
	{
		string text;
		switch (sat)
		{
		case Drvin9V0cgPlOe7ofbFCim7y0.Head:
			text = "Head";
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.Body:
			text = "Body";
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.LeftLeg:
			text = "Left leg";
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.RightLeg:
			text = "Right leg";
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.LeftHand:
			text = "Left hand";
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.RightHand:
			text = "Right hand";
			break;
		case Drvin9V0cgPlOe7ofbFCim7y0.Random:
			text = "Random";
			break;
		default:
			text = sat.ToString();
			break;
		}
		return text;
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x00016964 File Offset: 0x00014B64
	public static string DSddEPkLiOTPfTgVxiX4VviQ0(this D5VsESizw2NoAi19PtCEVYVgW tt)
	{
		D5VsESizw2NoAi19PtCEVYVgW d5VsESizw2NoAi19PtCEVYVgW = tt;
		bool flag = d5VsESizw2NoAi19PtCEVYVgW != D5VsESizw2NoAi19PtCEVYVgW.BallisticProceed;
		string text;
		if (flag)
		{
			bool flag2 = d5VsESizw2NoAi19PtCEVYVgW != D5VsESizw2NoAi19PtCEVYVgW.BallisticMoved;
			if (flag2)
			{
				text = tt.ToString();
			}
			else
			{
				text = "Ballistic moved";
			}
		}
		else
		{
			text = "Ballistic proceed";
		}
		return text;
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x000169B8 File Offset: 0x00014BB8
	public static string DpXfJCAOJsDVYtirwFecNMSdS(this string s, DA7EjeELhPnQjMBiXW309VJV4 vt)
	{
		return s + "->" + vt.ToString() + "s";
	}
}
