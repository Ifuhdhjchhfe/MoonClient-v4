using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200003F RID: 63
public struct DCJW8k4jS5tnCUQXemffRym03
{
	// Token: 0x0600010D RID: 269 RVA: 0x0000B9CC File Offset: 0x00009BCC
	public DCJW8k4jS5tnCUQXemffRym03(PlayerMovement movement, bool isLand, bool isRun)
	{
		this.DwHtMROXjYUxWOIrRjUZbeHsI = (isLand ? DfU4wrswBK5kLyiyV6mHZwOg8.stepsDropDistanceMultiplier : (isRun ? DfU4wrswBK5kLyiyV6mHZwOg8.stepsRunDistanceMultiplier : 1f));
		this.Dt5M4m3QoFvnQkn3VZzhTSHVU = global::UnityEngine.Object.Instantiate<GameObject>(DHTB5RKsHUihFrfj9ewuLh1f9.DJu8jOJDqPUBFfpVNdDwkec3H);
		this.Dt5M4m3QoFvnQkn3VZzhTSHVU.transform.position = movement.transform.position;
		this.Dt5M4m3QoFvnQkn3VZzhTSHVU.transform.localScale = Vector3.zero;
		this.Dt5M4m3QoFvnQkn3VZzhTSHVU.transform.eulerAngles = new Vector3(90f, 0f, 0f);
		this.Dt5M4m3QoFvnQkn3VZzhTSHVU.SetActive(!DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6);
		this.DwRw5XKeCbb0aL1lTzgFwBIb0 = this.Dt5M4m3QoFvnQkn3VZzhTSHVU.GetComponent<MeshRenderer>().material;
		this.DwRw5XKeCbb0aL1lTzgFwBIb0.color = DNbYBVifu73t6Hq5vgTtgKwS7.DrSB8TQE4TKOVm1uXhaoi8B0G("Player step color");
		this.D87mvhEC6atad8piZhPzdF71E = 0f;
	}

	// Token: 0x04000139 RID: 313
	public GameObject Dt5M4m3QoFvnQkn3VZzhTSHVU;

	// Token: 0x0400013A RID: 314
	public Material DwRw5XKeCbb0aL1lTzgFwBIb0;

	// Token: 0x0400013B RID: 315
	public float D87mvhEC6atad8piZhPzdF71E;

	// Token: 0x0400013C RID: 316
	public float DwHtMROXjYUxWOIrRjUZbeHsI;
}
