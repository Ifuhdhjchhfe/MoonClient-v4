using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200009A RID: 154
public static class DOw0kQ68Nlp70lUTSlj00W0pI
{
	// Token: 0x060002F1 RID: 753 RVA: 0x0002A930 File Offset: 0x00028B30
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(InteractableVehicle), "tellRecov", new Type[] { })]
	public static void DeXd2JBu0d5VCgm1vQRfuDD6m(InteractableVehicle instance, Vector3 newPosition, int newRecov)
	{
		Passenger passenger = instance.passengers[0];
		bool flag = passenger != null;
		bool flag2 = flag;
		Player player2;
		if (flag2)
		{
			SteamPlayer player = passenger.player;
			player2 = ((player == null) ? null : player.player);
		}
		else
		{
			player2 = null;
		}
		bool flag3 = player2 == Player.player && D5l46jlssr4TRAzUSXzLj0uqu.D0DlzyHYujfZZ6obqTbnUo6xa && D5l46jlssr4TRAzUSXzLj0uqu.DSPZ1k8DewM60xEN7D556FfkK;
		bool flag4 = flag3;
		if (flag4)
		{
			bool useVehiclePhysics = D5l46jlssr4TRAzUSXzLj0uqu.useVehiclePhysics;
			bool flag5 = useVehiclePhysics;
			if (flag5)
			{
				DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.GetComponent<Rigidbody>().MovePosition(newPosition);
			}
			else
			{
				DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.transform.position = newPosition;
			}
		}
		DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(instance, new object[] { newPosition, newRecov });
	}
}
