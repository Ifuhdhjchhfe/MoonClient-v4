using System;
using SDG.NetTransport;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000C1 RID: 193
public class DvalM0fb9bXZsn09ekov22pPh
{
	// Token: 0x060003D6 RID: 982 RVA: 0x000381D0 File Offset: 0x000363D0
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(VehicleManager), "exitVehicle", new Type[] { })]
	public static void DwBc0W0itLNf8Qola9waZDwUk()
	{
		bool flag = Player.player.movement.getVehicle() != null;
		bool flag2 = flag;
		if (flag2)
		{
			DvalM0fb9bXZsn09ekov22pPh.SendExitVehicleRequest.Invoke(ENetReliability.Unreliable, D5l46jlssr4TRAzUSXzLj0uqu.changeVehicleLeaveVelocity ? (D5l46jlssr4TRAzUSXzLj0uqu.useForwardVelocity ? (Player.player.movement.getVehicle().transform.forward * (float)D5l46jlssr4TRAzUSXzLj0uqu.vehilceVelocityForward) : new Vector3((float)D5l46jlssr4TRAzUSXzLj0uqu.vehilceVelocityX, (float)D5l46jlssr4TRAzUSXzLj0uqu.vehilceVelocityY, (float)D5l46jlssr4TRAzUSXzLj0uqu.vehilceVelocityZ)) : Player.player.movement.getVehicle().GetComponent<Rigidbody>().velocity);
		}
	}

	// Token: 0x040003EC RID: 1004
	public static readonly ServerStaticMethod<Vector3> SendExitVehicleRequest = ServerStaticMethod<Vector3>.Get(new ServerStaticMethod<Vector3>.ReceiveDelegateWithContext(VehicleManager.ReceiveExitVehicleRequest));
}
