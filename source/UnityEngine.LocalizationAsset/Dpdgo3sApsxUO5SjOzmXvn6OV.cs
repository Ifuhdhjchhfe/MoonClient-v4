using System;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

// Token: 0x0200009D RID: 157
public class Dpdgo3sApsxUO5SjOzmXvn6OV : PlayerMovement
{
	// Token: 0x06000304 RID: 772 RVA: 0x0002D400 File Offset: 0x0002B600
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DVeaXfMPZUW0qA5mMeoiWsN91()
	{
		Provider.onClientConnected = (Provider.ClientConnected)Delegate.Combine(Provider.onClientConnected, new Provider.ClientConnected(Dpdgo3sApsxUO5SjOzmXvn6OV.DGGssuVmXRvd5HyJkTGkhlP27));
		Provider.onServerConnected = (Provider.ServerConnected)Delegate.Combine(Provider.onServerConnected, new Provider.ServerConnected(delegate(CSteamID steamid)
		{
			Dpdgo3sApsxUO5SjOzmXvn6OV.DGGssuVmXRvd5HyJkTGkhlP27();
		}));
	}

	// Token: 0x06000305 RID: 773 RVA: 0x0002D461 File Offset: 0x0002B661
	public static void DGGssuVmXRvd5HyJkTGkhlP27()
	{
		Dpdgo3sApsxUO5SjOzmXvn6OV.DKwYJGn906AeKwYjot5qDFpaG = false;
	}

	// Token: 0x06000306 RID: 774 RVA: 0x0002D46C File Offset: 0x0002B66C
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerMovement), "setVehicle", new Type[] { })]
	public void DwG90y0uRQcC16y4tsev5li89(InteractableVehicle newVehicle, byte newSeat, Transform newSeatingTransform, Vector3 newSeatingPosition, byte newSeatingAngle, bool forceUpdate)
	{
		try
		{
			bool flag = base.channel.IsLocalPlayer || Provider.isServer;
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = newVehicle != null && newSeat == 0 && !Dpdgo3sApsxUO5SjOzmXvn6OV.DKwYJGn906AeKwYjot5qDFpaG;
				bool flag4 = flag3;
				if (flag4)
				{
					Dpdgo3sApsxUO5SjOzmXvn6OV.DKwYJGn906AeKwYjot5qDFpaG = true;
					DyeZ3VGPOIURoB79RzeiyEoDq.D359mO0W0qNaatQVw3l9iTtdj(newVehicle);
				}
				else
				{
					bool flag5 = (newVehicle == null || newSeat != 0) && Dpdgo3sApsxUO5SjOzmXvn6OV.DKwYJGn906AeKwYjot5qDFpaG;
					bool flag6 = flag5;
					if (flag6)
					{
						Dpdgo3sApsxUO5SjOzmXvn6OV.DKwYJGn906AeKwYjot5qDFpaG = false;
						DyeZ3VGPOIURoB79RzeiyEoDq.DruGluWrWebuNTt8G7dCKebiV();
					}
				}
			}
		}
		catch
		{
		}
		DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, new object[] { newVehicle, newSeat, newSeatingTransform, newSeatingPosition, newSeatingAngle, forceUpdate });
	}

	// Token: 0x06000307 RID: 775 RVA: 0x0002D548 File Offset: 0x0002B748
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerMovement), "PlayFootstepAudioClip", new Type[] { })]
	private static void DErqNjtLGZao5C6tMXdRX1x0n(PlayerMovement movement)
	{
		string text = ((movement.player.stance.stance == EPlayerStance.SPRINT) ? "FootstepRun" : "FootstepWalk");
		OneShotAudioDefinition oneShotAudioDefinition = Dpdgo3sApsxUO5SjOzmXvn6OV.DvZfm5xYcBalGmKlgenwiV6lN.Invoke(new object[]
		{
			Dpdgo3sApsxUO5SjOzmXvn6OV.DgI4x9iMjGszjTFXcDscjo2S9.Get(movement),
			text
		});
		bool flag = oneShotAudioDefinition == null;
		bool flag2 = !flag;
		if (flag2)
		{
			AudioClip randomClip = oneShotAudioDefinition.GetRandomClip();
			bool flag3 = randomClip == null;
			bool flag4 = !flag3;
			if (flag4)
			{
				float num = 1f - movement.player.skills.mastery(1, 0) * 0.75f;
				bool flag5 = movement.player.stance.stance == EPlayerStance.CROUCH;
				bool flag6 = flag5;
				if (flag6)
				{
					num *= 0.5f;
				}
				bool flag7 = DfU4wrswBK5kLyiyV6mHZwOg8.playerStepsCircle && (DfU4wrswBK5kLyiyV6mHZwOg8.seeOwnSteps || !movement.channel.IsLocalPlayer) && movement.player.stance.stance != EPlayerStance.PRONE && movement.player.stance.stance != EPlayerStance.SWIM;
				bool flag8 = flag7;
				if (flag8)
				{
					DmPNupos8Sd6cXJNxXG0GuRXC.DK8CcwvxKW0XeoKUzC0AcaVPv(movement, false);
				}
				num *= 0.125f;
				OneShotAudioParameters oneShotAudioParameters = new OneShotAudioParameters(movement.transform, randomClip);
				oneShotAudioParameters.volume = num * oneShotAudioDefinition.volumeMultiplier;
				oneShotAudioParameters.RandomizePitch(oneShotAudioDefinition.minPitch, oneShotAudioDefinition.maxPitch);
				oneShotAudioParameters.SetLinearRolloff(1f, 32f);
				oneShotAudioParameters.Play();
			}
		}
	}

	// Token: 0x06000308 RID: 776 RVA: 0x0002D6CC File Offset: 0x0002B8CC
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerMovement), "PlayLandAudioClip", new Type[] { })]
	private static bool D3nWfp2ibwLXluLd3R2Ll4ud1(PlayerMovement movement)
	{
		bool flag = movement.player.stance.stance == EPlayerStance.PRONE || string.IsNullOrEmpty(Dpdgo3sApsxUO5SjOzmXvn6OV.DgI4x9iMjGszjTFXcDscjo2S9.Get(movement));
		bool flag2 = flag;
		bool flag3;
		if (flag2)
		{
			flag3 = false;
		}
		else
		{
			OneShotAudioDefinition oneShotAudioDefinition = Dpdgo3sApsxUO5SjOzmXvn6OV.DvZfm5xYcBalGmKlgenwiV6lN.Invoke(new object[]
			{
				Dpdgo3sApsxUO5SjOzmXvn6OV.DgI4x9iMjGszjTFXcDscjo2S9.Get(movement),
				"BipedLand"
			});
			bool flag4 = oneShotAudioDefinition == null;
			bool flag5 = flag4;
			if (flag5)
			{
				flag3 = false;
			}
			else
			{
				AudioClip randomClip = oneShotAudioDefinition.GetRandomClip();
				bool flag6 = randomClip == null;
				bool flag7 = flag6;
				if (flag7)
				{
					flag3 = false;
				}
				else
				{
					float num = 1f - movement.player.skills.mastery(1, 0) * 0.75f;
					bool flag8 = movement.player.stance.stance == EPlayerStance.CROUCH;
					bool flag9 = flag8;
					if (flag9)
					{
						num *= 0.5f;
					}
					bool flag10 = DfU4wrswBK5kLyiyV6mHZwOg8.playerStepsCircle && (DfU4wrswBK5kLyiyV6mHZwOg8.seeOwnSteps || !movement.channel.IsLocalPlayer) && movement.player.stance.stance != EPlayerStance.PRONE && movement.player.stance.stance != EPlayerStance.SWIM;
					bool flag11 = flag10;
					if (flag11)
					{
						DmPNupos8Sd6cXJNxXG0GuRXC.DK8CcwvxKW0XeoKUzC0AcaVPv(movement, true);
					}
					num *= 0.15f;
					OneShotAudioParameters oneShotAudioParameters = new OneShotAudioParameters(movement.transform, randomClip);
					oneShotAudioParameters.volume = num * oneShotAudioDefinition.volumeMultiplier;
					oneShotAudioParameters.RandomizePitch(oneShotAudioDefinition.minPitch, oneShotAudioDefinition.maxPitch);
					oneShotAudioParameters.SetLinearRolloff(1f, 24f);
					oneShotAudioParameters.Play();
					Dpdgo3sApsxUO5SjOzmXvn6OV.Deo0G0bGtgV48bZ2xKPbNmBLu.Set(movement, Time.time);
					flag3 = true;
				}
			}
		}
		return flag3;
	}

	// Token: 0x04000368 RID: 872
	private static DGZv08vQyz81zrHxUqhmYuCdY<string> DgI4x9iMjGszjTFXcDscjo2S9 = new DGZv08vQyz81zrHxUqhmYuCdY<string>(typeof(PlayerMovement), "materialName");

	// Token: 0x04000369 RID: 873
	private static DGZv08vQyz81zrHxUqhmYuCdY<float> Deo0G0bGtgV48bZ2xKPbNmBLu = new DGZv08vQyz81zrHxUqhmYuCdY<float>(typeof(PlayerMovement), "lastFootstep");

	// Token: 0x0400036A RID: 874
	private static DfHljpul4p88ytp3JZtoSRq7w<OneShotAudioDefinition> DvZfm5xYcBalGmKlgenwiV6lN = new DfHljpul4p88ytp3JZtoSRq7w<OneShotAudioDefinition>("PhysicMaterialCustomData", "GetAudioDef");

	// Token: 0x0400036B RID: 875
	public static bool DKwYJGn906AeKwYjot5qDFpaG = false;
}
