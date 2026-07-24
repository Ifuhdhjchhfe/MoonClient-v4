using System;
using System.Collections.Generic;
using System.Reflection;
using SDG.Unturned;

// Token: 0x02000088 RID: 136
public class DMkRmB9x1tCMUY9gJrDDfwiTu
{
	// Token: 0x06000286 RID: 646 RVA: 0x00025B9C File Offset: 0x00023D9C
	public static void DpM0GFGlrNaQhJRtJsRX6OaNO()
	{
		DMkRmB9x1tCMUY9gJrDDfwiTu.DciNRxefGPpxmVxfJNEEiDCqN.Clear();
		DMkRmB9x1tCMUY9gJrDDfwiTu.DEHEaA2OjZzMvn4LKaA2DVfhb.Clear();
		DMkRmB9x1tCMUY9gJrDDfwiTu.DEzWsw5jvnnLHadQ7NpSnAjub.Clear();
		DMkRmB9x1tCMUY9gJrDDfwiTu.Dr0QEbsTcYemCze7pwTosuRbB.Clear();
		DMkRmB9x1tCMUY9gJrDDfwiTu.DYFpp1gBDzm2fAoZvq8oaSEoS.Clear();
		DMkRmB9x1tCMUY9gJrDDfwiTu.DfSsuZOKLEHNalgYxb5Ldllnj.Clear();
		DMkRmB9x1tCMUY9gJrDDfwiTu.DzJcjWdqG6hDZXgX3RY5e2vcQ.Clear();
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00025BF7 File Offset: 0x00023DF7
	[DyRHDWg89xeNs0wA42v5OHmTi]
	public static void DD886iaOAlWr2uX0ckNkkiyuH()
	{
		DMkRmB9x1tCMUY9gJrDDfwiTu.DIRXUGeUBRgcYYvlLXqiq2JZB = typeof(Interactable).GetField("_netId", BindingFlags.Instance | BindingFlags.NonPublic);
		Provider.onClientDisconnected = (Provider.ClientDisconnected)Delegate.Combine(Provider.onClientDisconnected, new Provider.ClientDisconnected(DMkRmB9x1tCMUY9gJrDDfwiTu.DpM0GFGlrNaQhJRtJsRX6OaNO));
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00025C35 File Offset: 0x00023E35
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(Interactable), "AssignNetId", BindingFlags.Instance | BindingFlags.NonPublic, new Type[] { })]
	public static void DZiHv5TnhPDgdDE1k0UvCFKka(Interactable instance, NetId netId)
	{
		DMkRmB9x1tCMUY9gJrDDfwiTu.DIRXUGeUBRgcYYvlLXqiq2JZB.SetValue(instance, netId);
		NetIdRegistry.Assign(netId, instance);
		DMkRmB9x1tCMUY9gJrDDfwiTu.DbAdQa384Zw3rT9JWfzJFDHSw(instance);
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00025C5C File Offset: 0x00023E5C
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(Interactable), "ReleaseNetId", BindingFlags.Instance | BindingFlags.NonPublic, new Type[] { })]
	public static void DLyHSm3g3t3mX6F96GWPmprNw(Interactable instance, NetId netId)
	{
		NetIdRegistry.Release(netId);
		((NetId)DMkRmB9x1tCMUY9gJrDDfwiTu.DIRXUGeUBRgcYYvlLXqiq2JZB.GetValue(instance)).Clear();
		DMkRmB9x1tCMUY9gJrDDfwiTu.DEItiLRA9KWM8ILzUI60xbvQg(instance);
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00025C94 File Offset: 0x00023E94
	public static void DbAdQa384Zw3rT9JWfzJFDHSw(Interactable i)
	{
		bool flag = i is InteractableStorage;
		bool flag2 = flag;
		if (flag2)
		{
			DMkRmB9x1tCMUY9gJrDDfwiTu.DciNRxefGPpxmVxfJNEEiDCqN.Add(i as InteractableStorage);
		}
		else
		{
			bool flag3 = i is InteractableBed;
			bool flag4 = flag3;
			if (flag4)
			{
				DMkRmB9x1tCMUY9gJrDDfwiTu.DEHEaA2OjZzMvn4LKaA2DVfhb.Add(i as InteractableBed);
			}
			else
			{
				bool flag5 = i is InteractableClaim;
				bool flag6 = flag5;
				if (flag6)
				{
					DMkRmB9x1tCMUY9gJrDDfwiTu.DEzWsw5jvnnLHadQ7NpSnAjub.Add(i as InteractableClaim);
				}
				else
				{
					bool flag7 = i is InteractableGenerator;
					bool flag8 = flag7;
					if (flag8)
					{
						DMkRmB9x1tCMUY9gJrDDfwiTu.Dr0QEbsTcYemCze7pwTosuRbB.Add(i as InteractableGenerator);
					}
					else
					{
						bool flag9 = i is InteractableSentry;
						bool flag10 = flag9;
						if (flag10)
						{
							DMkRmB9x1tCMUY9gJrDDfwiTu.DYFpp1gBDzm2fAoZvq8oaSEoS.Add(i as InteractableSentry);
						}
						else
						{
							bool flag11 = i is InteractableForage;
							bool flag12 = flag11;
							if (flag12)
							{
								DMkRmB9x1tCMUY9gJrDDfwiTu.DfSsuZOKLEHNalgYxb5Ldllnj.Add(i as InteractableForage);
							}
							else
							{
								bool flag13 = i is InteractableMannequin;
								bool flag14 = flag13;
								if (flag14)
								{
									DMkRmB9x1tCMUY9gJrDDfwiTu.DzJcjWdqG6hDZXgX3RY5e2vcQ.Add(i as InteractableMannequin);
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00025DC8 File Offset: 0x00023FC8
	public static void DEItiLRA9KWM8ILzUI60xbvQg(Interactable i)
	{
		bool flag = i is InteractableStorage;
		bool flag2 = flag;
		if (flag2)
		{
			DMkRmB9x1tCMUY9gJrDDfwiTu.DciNRxefGPpxmVxfJNEEiDCqN.Remove(i as InteractableStorage);
		}
		else
		{
			bool flag3 = i is InteractableBed;
			bool flag4 = flag3;
			if (flag4)
			{
				DMkRmB9x1tCMUY9gJrDDfwiTu.DEHEaA2OjZzMvn4LKaA2DVfhb.Remove(i as InteractableBed);
			}
			else
			{
				bool flag5 = i is InteractableClaim;
				bool flag6 = flag5;
				if (flag6)
				{
					DMkRmB9x1tCMUY9gJrDDfwiTu.DEzWsw5jvnnLHadQ7NpSnAjub.Remove(i as InteractableClaim);
				}
				else
				{
					bool flag7 = i is InteractableGenerator;
					bool flag8 = flag7;
					if (flag8)
					{
						DMkRmB9x1tCMUY9gJrDDfwiTu.Dr0QEbsTcYemCze7pwTosuRbB.Remove(i as InteractableGenerator);
					}
					else
					{
						bool flag9 = i is InteractableSentry;
						bool flag10 = flag9;
						if (flag10)
						{
							DMkRmB9x1tCMUY9gJrDDfwiTu.DYFpp1gBDzm2fAoZvq8oaSEoS.Remove(i as InteractableSentry);
						}
						else
						{
							bool flag11 = i is InteractableForage;
							bool flag12 = flag11;
							if (flag12)
							{
								DMkRmB9x1tCMUY9gJrDDfwiTu.DfSsuZOKLEHNalgYxb5Ldllnj.Remove(i as InteractableForage);
							}
							else
							{
								bool flag13 = i is InteractableMannequin;
								bool flag14 = flag13;
								if (flag14)
								{
									DMkRmB9x1tCMUY9gJrDDfwiTu.DzJcjWdqG6hDZXgX3RY5e2vcQ.Remove(i as InteractableMannequin);
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x04000311 RID: 785
	public static FieldInfo DIRXUGeUBRgcYYvlLXqiq2JZB;

	// Token: 0x04000312 RID: 786
	public static List<InteractableStorage> DciNRxefGPpxmVxfJNEEiDCqN = new List<InteractableStorage>();

	// Token: 0x04000313 RID: 787
	public static List<InteractableBed> DEHEaA2OjZzMvn4LKaA2DVfhb = new List<InteractableBed>();

	// Token: 0x04000314 RID: 788
	public static List<InteractableClaim> DEzWsw5jvnnLHadQ7NpSnAjub = new List<InteractableClaim>();

	// Token: 0x04000315 RID: 789
	public static List<InteractableGenerator> Dr0QEbsTcYemCze7pwTosuRbB = new List<InteractableGenerator>();

	// Token: 0x04000316 RID: 790
	public static List<InteractableSentry> DYFpp1gBDzm2fAoZvq8oaSEoS = new List<InteractableSentry>();

	// Token: 0x04000317 RID: 791
	public static List<InteractableForage> DfSsuZOKLEHNalgYxb5Ldllnj = new List<InteractableForage>();

	// Token: 0x04000318 RID: 792
	public static List<InteractableMannequin> DzJcjWdqG6hDZXgX3RY5e2vcQ = new List<InteractableMannequin>();
}
