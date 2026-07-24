using System;
using System.Reflection;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

// Token: 0x020000DA RID: 218
public class DyeZ3VGPOIURoB79RzeiyEoDq : MonoBehaviour
{
	// Token: 0x06000418 RID: 1048 RVA: 0x0003D89C File Offset: 0x0003BA9C
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DgDM47ZeGG7huNNut34XHVIHI()
	{
		Provider.onClientConnected = (Provider.ClientConnected)Delegate.Remove(Provider.onClientConnected, new Provider.ClientConnected(DyeZ3VGPOIURoB79RzeiyEoDq.D0TAe3bbhF5FfGfg0Yu6uQf1n));
		Provider.onServerConnected = (Provider.ServerConnected)Delegate.Remove(Provider.onServerConnected, new Provider.ServerConnected(DyeZ3VGPOIURoB79RzeiyEoDq.OnServerConnected));
		Provider.onClientDisconnected = (Provider.ClientDisconnected)Delegate.Remove(Provider.onClientDisconnected, new Provider.ClientDisconnected(DyeZ3VGPOIURoB79RzeiyEoDq.Doy4aGaMQzxhKT7pej0UeRboT));
		Provider.onClientConnected = (Provider.ClientConnected)Delegate.Combine(Provider.onClientConnected, new Provider.ClientConnected(DyeZ3VGPOIURoB79RzeiyEoDq.D0TAe3bbhF5FfGfg0Yu6uQf1n));
		Provider.onServerConnected = (Provider.ServerConnected)Delegate.Combine(Provider.onServerConnected, new Provider.ServerConnected(DyeZ3VGPOIURoB79RzeiyEoDq.OnServerConnected));
		Provider.onClientDisconnected = (Provider.ClientDisconnected)Delegate.Combine(Provider.onClientDisconnected, new Provider.ClientDisconnected(DyeZ3VGPOIURoB79RzeiyEoDq.Doy4aGaMQzxhKT7pej0UeRboT));
		bool flag = D0Kr0NqRHBD41IMsgv7ajeW8M.DxcVo94CW4Y8vQkyhpKozFmcW && Provider.isConnected;
		if (flag)
		{
			DyeZ3VGPOIURoB79RzeiyEoDq.D0TAe3bbhF5FfGfg0Yu6uQf1n();
		}
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x0003D988 File Offset: 0x0003BB88
	private static void D0TAe3bbhF5FfGfg0Yu6uQf1n()
	{
		bool flag = DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51 == null;
		if (flag)
		{
			DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51 = D0Kr0NqRHBD41IMsgv7ajeW8M.D1tYt6KxEmATG67AhmCiQjAGN.AddComponent<DyeZ3VGPOIURoB79RzeiyEoDq>();
		}
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x0003D9B6 File Offset: 0x0003BBB6
	private static void Doy4aGaMQzxhKT7pej0UeRboT()
	{
		global::UnityEngine.Object.Destroy(DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51);
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x0003D9C4 File Offset: 0x0003BBC4
	public static void DruGluWrWebuNTt8G7dCKebiV()
	{
		bool flag = DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51 != null && DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.D0ELnekK0qU385gCnZRB3HOHG != null;
		if (flag)
		{
			DyeZ3VGPOIURoB79RzeiyEoDq.Dh4w9Tga1SdtxToA5FlSMGQKx.applyTo(DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.D0ELnekK0qU385gCnZRB3HOHG);
			D08iy2XFQpUQteL0XRzAbg2IE.Dr06TnUlTEh4Mt9XdzQtoz0Lb(typeof(VehicleAsset), "_steerMax", DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.D0ELnekK0qU385gCnZRB3HOHG.asset, DyeZ3VGPOIURoB79RzeiyEoDq.DdpWFHwmEs62wdkdOEHdvRl4l);
			D08iy2XFQpUQteL0XRzAbg2IE.Dr06TnUlTEh4Mt9XdzQtoz0Lb(typeof(VehicleAsset), "_steerMin", DyeZ3VGPOIURoB79RzeiyEoDq.DHBCpgdFvd0pFE3v5kMWVYx51.D0ELnekK0qU385gCnZRB3HOHG.asset, DyeZ3VGPOIURoB79RzeiyEoDq.DqLTES02MdvCkFRqeSMmLJpXV);
		}
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x0003DA6C File Offset: 0x0003BC6C
	public static void D359mO0W0qNaatQVw3l9iTtdj(InteractableVehicle vehicle)
	{
		DyeZ3VGPOIURoB79RzeiyEoDq.DdpWFHwmEs62wdkdOEHdvRl4l = vehicle.asset.steerMax;
		DyeZ3VGPOIURoB79RzeiyEoDq.DqLTES02MdvCkFRqeSMmLJpXV = vehicle.asset.steerMin;
		bool flag = DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx == null;
		if (flag)
		{
			DyeZ3VGPOIURoB79RzeiyEoDq.Dh4w9Tga1SdtxToA5FlSMGQKx = DyeZ3VGPOIURoB79RzeiyEoDq.DSQCLm3UbYB6fHRg8Y895T2OG(vehicle.GetComponent<Rigidbody>(), vehicle);
			DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx = DyeZ3VGPOIURoB79RzeiyEoDq.DSQCLm3UbYB6fHRg8Y895T2OG(vehicle.GetComponent<Rigidbody>(), vehicle);
		}
		bool flag2 = D5l46jlssr4TRAzUSXzLj0uqu.customVehicleBehaviour && !D5l46jlssr4TRAzUSXzLj0uqu.vehicleNoclip;
		if (flag2)
		{
			D08iy2XFQpUQteL0XRzAbg2IE.Dr06TnUlTEh4Mt9XdzQtoz0Lb(typeof(VehicleAsset), "_steerMax", vehicle.asset, DyeZ3VGPOIURoB79RzeiyEoDq.DDhNxYvtf1DcoxjUKjAeBs0hB);
			D08iy2XFQpUQteL0XRzAbg2IE.Dr06TnUlTEh4Mt9XdzQtoz0Lb(typeof(VehicleAsset), "_steerMin", vehicle.asset, DyeZ3VGPOIURoB79RzeiyEoDq.DZYz0Xr7W62jYmI0jRen8PvE2);
			DyeZ3VGPOIURoB79RzeiyEoDq.D2yM00hif0YewkmEgxleJZ0jx.applyTo(vehicle);
		}
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x0003DB38 File Offset: 0x0003BD38
	public static VehiclePhysicsProfileAsset DSQCLm3UbYB6fHRg8Y895T2OG(Rigidbody rigid, InteractableVehicle vehicle)
	{
		VehiclePhysicsProfileAsset vehiclePhysicsProfileAsset = new VehiclePhysicsProfileAsset();
		Type typeFromHandle = typeof(VehiclePhysicsProfileAsset);
		typeFromHandle.GetProperty("rootMassOverride").SetValue(vehiclePhysicsProfileAsset, rigid.mass);
		typeFromHandle.GetProperty("rootMassMultiplier").SetValue(vehiclePhysicsProfileAsset, 1f);
		typeFromHandle.GetProperty("rootDragMultiplier").SetValue(vehiclePhysicsProfileAsset, 1f);
		typeFromHandle.GetProperty("rootAngularDragMultiplier").SetValue(vehiclePhysicsProfileAsset, 1f);
		typeFromHandle.GetProperty("wheelStiffnessTractionMultiplier").SetValue(vehiclePhysicsProfileAsset, vehicle.tires[0].stiffnessTractionMultiplier);
		typeFromHandle.GetProperty("wheelDampingRate").SetValue(vehiclePhysicsProfileAsset, vehicle.tires[0].wheel.wheelDampingRate);
		typeFromHandle.GetProperty("wheelSuspensionForce").SetValue(vehiclePhysicsProfileAsset, vehicle.tires[0].wheel.suspensionSpring.spring);
		typeFromHandle.GetProperty("wheelSuspensionDamper").SetValue(vehiclePhysicsProfileAsset, vehicle.tires[0].wheel.suspensionSpring.damper);
		typeFromHandle.GetProperty("wheelMassOverride").SetValue(vehiclePhysicsProfileAsset, vehicle.tires[0].wheel.mass);
		typeFromHandle.GetProperty("wheelMassMultiplier").SetValue(vehiclePhysicsProfileAsset, 1f);
		typeFromHandle.GetProperty("motorTorqueMultiplier").SetValue(vehiclePhysicsProfileAsset, vehicle.tires[0].motorTorqueMultiplier);
		typeFromHandle.GetProperty("motorTorqueClampMultiplier").SetValue(vehiclePhysicsProfileAsset, vehicle.tires[0].motorTorqueClampMultiplier);
		typeFromHandle.GetProperty("brakeTorqueMultiplier").SetValue(vehiclePhysicsProfileAsset, vehicle.tires[0].brakeTorqueMultiplier);
		typeFromHandle.GetProperty("brakeTorqueTractionMultiplier").SetValue(vehiclePhysicsProfileAsset, vehicle.tires[0].brakeTorqueTractionMultiplier);
		typeFromHandle.GetProperty("carjackForceMultiplier").SetValue(vehiclePhysicsProfileAsset, 1f);
		PropertyInfo property = typeFromHandle.GetProperty("sidewaysFriction");
		object obj = vehiclePhysicsProfileAsset;
		property.SetValue(obj, new VehiclePhysicsProfileAsset.Friction
		{
			stiffness = vehicle.tires[0].stiffnessSideways,
			asymptoteSlip = vehicle.tires[0].wheel.sidewaysFriction.asymptoteSlip,
			asymptoteValue = vehicle.tires[0].wheel.sidewaysFriction.asymptoteValue,
			extremumSlip = vehicle.tires[0].wheel.sidewaysFriction.extremumSlip,
			extremumValue = vehicle.tires[0].wheel.sidewaysFriction.extremumValue
		});
		PropertyInfo property2 = typeFromHandle.GetProperty("forwardFriction");
		object obj2 = vehiclePhysicsProfileAsset;
		property2.SetValue(obj2, new VehiclePhysicsProfileAsset.Friction
		{
			stiffness = vehicle.tires[0].stiffnessForward,
			asymptoteSlip = vehicle.tires[0].wheel.forwardFriction.asymptoteSlip,
			asymptoteValue = vehicle.tires[0].wheel.forwardFriction.asymptoteValue,
			extremumSlip = vehicle.tires[0].wheel.forwardFriction.extremumSlip,
			extremumValue = vehicle.tires[0].wheel.forwardFriction.extremumValue
		});
		return vehiclePhysicsProfileAsset;
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x0003DEF0 File Offset: 0x0003C0F0
	public static VehiclePhysicsProfileAsset D10ynXjYOXWz82CyXFMTjTxcK(VehiclePhysicsProfileAsset asset)
	{
		VehiclePhysicsProfileAsset vehiclePhysicsProfileAsset = new VehiclePhysicsProfileAsset();
		Type typeFromHandle = typeof(VehiclePhysicsProfileAsset);
		typeFromHandle.GetProperty("rootMassOverride").SetValue(vehiclePhysicsProfileAsset, asset.rootMassOverride);
		typeFromHandle.GetProperty("rootMassMultiplier").SetValue(vehiclePhysicsProfileAsset, asset.rootMassMultiplier);
		typeFromHandle.GetProperty("rootDragMultiplier").SetValue(vehiclePhysicsProfileAsset, asset.rootDragMultiplier);
		typeFromHandle.GetProperty("rootAngularDragMultiplier").SetValue(vehiclePhysicsProfileAsset, asset.rootAngularDragMultiplier);
		typeFromHandle.GetProperty("wheelStiffnessTractionMultiplier").SetValue(vehiclePhysicsProfileAsset, asset.wheelStiffnessTractionMultiplier);
		typeFromHandle.GetProperty("wheelDampingRate").SetValue(vehiclePhysicsProfileAsset, asset.wheelDampingRate);
		typeFromHandle.GetProperty("wheelSuspensionForce").SetValue(vehiclePhysicsProfileAsset, asset.wheelSuspensionForce);
		typeFromHandle.GetProperty("wheelSuspensionDamper").SetValue(vehiclePhysicsProfileAsset, asset.wheelSuspensionDamper);
		typeFromHandle.GetProperty("wheelMassOverride").SetValue(vehiclePhysicsProfileAsset, asset.wheelMassOverride);
		typeFromHandle.GetProperty("wheelMassMultiplier").SetValue(vehiclePhysicsProfileAsset, asset.wheelMassMultiplier);
		typeFromHandle.GetProperty("motorTorqueMultiplier").SetValue(vehiclePhysicsProfileAsset, asset.motorTorqueMultiplier);
		typeFromHandle.GetProperty("motorTorqueClampMultiplier").SetValue(vehiclePhysicsProfileAsset, asset.motorTorqueClampMultiplier);
		typeFromHandle.GetProperty("brakeTorqueMultiplier").SetValue(vehiclePhysicsProfileAsset, asset.brakeTorqueMultiplier);
		typeFromHandle.GetProperty("brakeTorqueTractionMultiplier").SetValue(vehiclePhysicsProfileAsset, asset.brakeTorqueTractionMultiplier);
		typeFromHandle.GetProperty("carjackForceMultiplier").SetValue(vehiclePhysicsProfileAsset, asset.carjackForceMultiplier);
		PropertyInfo property = typeFromHandle.GetProperty("sidewaysFriction");
		object obj = vehiclePhysicsProfileAsset;
		property.SetValue(obj, new VehiclePhysicsProfileAsset.Friction
		{
			stiffness = asset.forwardFriction.Value.stiffness,
			asymptoteSlip = asset.forwardFriction.Value.asymptoteSlip,
			asymptoteValue = asset.forwardFriction.Value.asymptoteValue,
			extremumSlip = asset.forwardFriction.Value.extremumSlip,
			extremumValue = asset.forwardFriction.Value.extremumValue
		});
		PropertyInfo property2 = typeFromHandle.GetProperty("forwardFriction");
		object obj2 = vehiclePhysicsProfileAsset;
		property2.SetValue(obj2, new VehiclePhysicsProfileAsset.Friction
		{
			stiffness = asset.forwardFriction.Value.stiffness,
			asymptoteSlip = asset.forwardFriction.Value.asymptoteSlip,
			asymptoteValue = asset.forwardFriction.Value.asymptoteValue,
			extremumSlip = asset.forwardFriction.Value.extremumSlip,
			extremumValue = asset.forwardFriction.Value.extremumValue
		});
		return vehiclePhysicsProfileAsset;
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x0003E228 File Offset: 0x0003C428
	private void FixedUpdate()
	{
		bool flag = D5l46jlssr4TRAzUSXzLj0uqu.customVehicleBehaviour && D5l46jlssr4TRAzUSXzLj0uqu.vehicleNoclip;
		if (flag)
		{
			this.D0ELnekK0qU385gCnZRB3HOHG = Player.player.movement.getVehicle();
			bool flag2 = !(this.D0ELnekK0qU385gCnZRB3HOHG == null);
			if (flag2)
			{
				this.DBbFWh5f0i7R4pZC3PhoeVZn9 = this.D0ELnekK0qU385gCnZRB3HOHG.GetComponent<Rigidbody>();
				bool flag3 = !(this.DBbFWh5f0i7R4pZC3PhoeVZn9 == null);
				if (flag3)
				{
					try
					{
						this.DBbFWh5f0i7R4pZC3PhoeVZn9.constraints = RigidbodyConstraints.None;
						this.DBbFWh5f0i7R4pZC3PhoeVZn9.freezeRotation = false;
						this.DBbFWh5f0i7R4pZC3PhoeVZn9.useGravity = false;
						this.DBbFWh5f0i7R4pZC3PhoeVZn9.isKinematic = true;
						Transform transform = this.DBbFWh5f0i7R4pZC3PhoeVZn9.transform;
						Vector3 vector = Vector3.zero;
						bool key = InputEx.GetKey(ControlsSettings.up);
						if (key)
						{
							bool useVehiclePhysics = D5l46jlssr4TRAzUSXzLj0uqu.useVehiclePhysics;
							if (useVehiclePhysics)
							{
								this.DBbFWh5f0i7R4pZC3PhoeVZn9.MovePosition(transform.position + transform.forward * (this.D0ELnekK0qU385gCnZRB3HOHG.asset.TargetForwardSpeed * D5l46jlssr4TRAzUSXzLj0uqu.vehicleSpeed * Time.fixedDeltaTime));
							}
							else
							{
								vector += transform.forward * (this.D0ELnekK0qU385gCnZRB3HOHG.asset.TargetForwardSpeed * D5l46jlssr4TRAzUSXzLj0uqu.vehicleSpeed * Time.fixedDeltaTime);
							}
						}
						else
						{
							bool key2 = InputEx.GetKey(ControlsSettings.down);
							if (key2)
							{
								bool useVehiclePhysics2 = D5l46jlssr4TRAzUSXzLj0uqu.useVehiclePhysics;
								if (useVehiclePhysics2)
								{
									this.DBbFWh5f0i7R4pZC3PhoeVZn9.MovePosition(transform.position - transform.forward * (this.D0ELnekK0qU385gCnZRB3HOHG.asset.TargetForwardSpeed * D5l46jlssr4TRAzUSXzLj0uqu.vehicleSpeed * Time.fixedDeltaTime));
								}
								else
								{
									vector -= transform.forward * (this.D0ELnekK0qU385gCnZRB3HOHG.asset.TargetForwardSpeed * D5l46jlssr4TRAzUSXzLj0uqu.vehicleSpeed * Time.fixedDeltaTime);
								}
							}
						}
						Vector3 vector2 = Vector3.zero;
						Vector3 zero = Vector3.zero;
						bool key3 = Input.GetKey(ControlsSettings.left);
						if (key3)
						{
							zero.y -= 2f;
						}
						bool key4 = Input.GetKey(ControlsSettings.right);
						if (key4)
						{
							zero.y += 2f;
						}
						bool key5 = Input.GetKey(ControlsSettings.leanLeft);
						if (key5)
						{
							zero.x -= 1.5f;
						}
						bool key6 = Input.GetKey(ControlsSettings.leanRight);
						if (key6)
						{
							zero.x += 1.5f;
						}
						bool key7 = Input.GetKey(KeyCode.UpArrow);
						if (key7)
						{
							zero.x -= 1.5f;
						}
						bool key8 = Input.GetKey(KeyCode.DownArrow);
						if (key8)
						{
							zero.x += 1.5f;
						}
						bool key9 = Input.GetKey(KeyCode.LeftArrow);
						if (key9)
						{
							zero.z += 1.5f;
						}
						bool key10 = Input.GetKey(KeyCode.RightArrow);
						if (key10)
						{
							zero.z -= 1.5f;
						}
						bool key11 = Input.GetKey(ControlsSettings.jump);
						if (key11)
						{
							vector2 += new Vector3(0f, 0.2f, 0f) * D5l46jlssr4TRAzUSXzLj0uqu.vehicleSpeed;
						}
						else
						{
							bool key12 = Input.GetKey(ControlsSettings.crouch);
							if (key12)
							{
								vector2 -= new Vector3(0f, 0.2f, 0f) * D5l46jlssr4TRAzUSXzLj0uqu.vehicleSpeed;
							}
						}
						bool flag4 = zero != Vector3.zero;
						if (flag4)
						{
							transform.Rotate(zero);
						}
						bool flag5 = vector2 != Vector3.zero;
						if (flag5)
						{
							transform.position += vector2;
						}
						bool flag6 = vector != Vector3.zero;
						if (flag6)
						{
							transform.position += vector;
						}
					}
					catch
					{
					}
				}
			}
		}
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x0003E63C File Offset: 0x0003C83C
	private static void OnServerConnected(CSteamID steamid)
	{
		DyeZ3VGPOIURoB79RzeiyEoDq.D0TAe3bbhF5FfGfg0Yu6uQf1n();
	}

	// Token: 0x0400045C RID: 1116
	public static DyeZ3VGPOIURoB79RzeiyEoDq DHBCpgdFvd0pFE3v5kMWVYx51;

	// Token: 0x0400045D RID: 1117
	public Rigidbody DBbFWh5f0i7R4pZC3PhoeVZn9;

	// Token: 0x0400045E RID: 1118
	public InteractableVehicle D0ELnekK0qU385gCnZRB3HOHG;

	// Token: 0x0400045F RID: 1119
	public static VehiclePhysicsProfileAsset D2yM00hif0YewkmEgxleJZ0jx;

	// Token: 0x04000460 RID: 1120
	public static VehiclePhysicsProfileAsset Dh4w9Tga1SdtxToA5FlSMGQKx;

	// Token: 0x04000461 RID: 1121
	public static float DdpWFHwmEs62wdkdOEHdvRl4l;

	// Token: 0x04000462 RID: 1122
	public static float DqLTES02MdvCkFRqeSMmLJpXV;

	// Token: 0x04000463 RID: 1123
	public static float DDhNxYvtf1DcoxjUKjAeBs0hB;

	// Token: 0x04000464 RID: 1124
	public static float DZYz0Xr7W62jYmI0jRen8PvE2;
}
