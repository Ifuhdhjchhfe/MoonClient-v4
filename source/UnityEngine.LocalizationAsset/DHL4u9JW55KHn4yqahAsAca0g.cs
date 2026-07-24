using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200006A RID: 106
public static class DHL4u9JW55KHn4yqahAsAca0g
{
	// Token: 0x060001FF RID: 511 RVA: 0x00019D90 File Offset: 0x00017F90
	public static void DswlHO7qyc69Cj5RAE6XszvzY()
	{
		bool flag = !Directory.Exists(Application.dataPath + "/configs/");
		if (flag)
		{
			Directory.CreateDirectory(Application.dataPath + "/configs/");
		}
	}

	// Token: 0x06000200 RID: 512 RVA: 0x00019DD0 File Offset: 0x00017FD0
	public static void D2g4NA8rhz0woPO9q8PE9WzJz()
	{
		DHL4u9JW55KHn4yqahAsAca0g.Dv3ysxn5xWpghuiaDYKQhpp5e.Clear();
		foreach (FileInfo fileInfo in new DirectoryInfo(Application.dataPath + "/configs/").GetFiles())
		{
			bool flag = fileInfo.Name.EndsWith(".conf");
			if (flag)
			{
				DHL4u9JW55KHn4yqahAsAca0g.Dv3ysxn5xWpghuiaDYKQhpp5e.Add(fileInfo.Name);
			}
		}
	}

	// Token: 0x06000201 RID: 513 RVA: 0x00019E40 File Offset: 0x00018040
	public static void DsGCzavTMhjHZxZrxP0lFBdPj()
	{
		DHL4u9JW55KHn4yqahAsAca0g.DswlHO7qyc69Cj5RAE6XszvzY();
		DHL4u9JW55KHn4yqahAsAca0g.D2g4NA8rhz0woPO9q8PE9WzJz();
		DHL4u9JW55KHn4yqahAsAca0g.DfVwnJCdaa9r9gVjbBk0OdhBj = typeof(MenuConfigurationGraphicsUI).GetMethod("updateAll", BindingFlags.Static | BindingFlags.NonPublic);
		DHL4u9JW55KHn4yqahAsAca0g.D1HuueboQ2CkBbQrUBMjFL2Jl = typeof(MenuConfigurationOptionsUI).GetMethod("updateAll", BindingFlags.Static | BindingFlags.NonPublic);
		DHL4u9JW55KHn4yqahAsAca0g.D4ppRzhEP27LsqmCRv3B06UR0 = typeof(MenuConfigurationControlsUI).GetMethod("updateAll", BindingFlags.Static | BindingFlags.NonPublic);
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00019EAC File Offset: 0x000180AC
	public static void Dp7pcTz2nINBtiXIWzFT8IOZ1(string fileName)
	{
		DHL4u9JW55KHn4yqahAsAca0g.DswlHO7qyc69Cj5RAE6XszvzY();
		try
		{
			DUt0a6FCClF9uncpHt4baoWwu dut0a6FCClF9uncpHt4baoWwu = new DUt0a6FCClF9uncpHt4baoWwu(File.ReadAllBytes(Application.dataPath + "/configs/" + fileName));
			byte b = dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.anisotropicFilteringMode = (EAnisotropicFilteringMode)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.antiAliasingType = (EAntiAliasingType)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.blast = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.blend = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.bloom = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.buffer = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.chromaticAberration = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.debris = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.effectQuality = (EGraphicQuality)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.filmGrain = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.foliageFocus = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.foliageQuality = (EGraphicQuality)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.fullscreenMode = (FullScreenMode)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.glitter = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.grassDisplacement = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.isAmbientOcclusionEnabled = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.IsItemIconAntiAliasingEnabled = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.landmarkQuality = (EGraphicQuality)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.lightingQuality = (EGraphicQuality)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.normalizedDrawDistance = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
			GraphicsSettings.NormalizedFarClipDistance = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
			GraphicsSettings.normalizedLandmarkDrawDistance = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
			GraphicsSettings.outlineQuality = (EGraphicQuality)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.planarReflectionQuality = (EGraphicQuality)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.puddle = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.ragdolls = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.reflectionQuality = (EGraphicQuality)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.renderMode = (ERenderMode)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.scopeQuality = (EGraphicQuality)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.skyboxReflection = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.sunShaftsQuality = (EGraphicQuality)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.TargetFrameRate = dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx();
			GraphicsSettings.terrainQuality = (EGraphicQuality)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			bool flag = b <= 1;
			if (flag)
			{
				dut0a6FCClF9uncpHt4baoWwu.DgTrevnMqiGTEn0P1JdH0dHcY++;
			}
			GraphicsSettings.triplanar = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.uncapLandmarks = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.UnfocusedTargetFrameRate = dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx();
			GraphicsSettings.userInterfaceScale = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
			GraphicsSettings.UseTargetFrameRate = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.UseUnfocusedTargetFrameRate = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			GraphicsSettings.waterQuality = (EGraphicQuality)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			GraphicsSettings.IsWindEnabled = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			try
			{
				GraphicsSettings.save();
			}
			catch
			{
			}
			DHL4u9JW55KHn4yqahAsAca0g.DfVwnJCdaa9r9gVjbBk0OdhBj.Invoke(null, new object[0]);
			OptionsSettings.backgroundColor = dut0a6FCClF9uncpHt4baoWwu.DnCcnTnPw5ZJ82mTIu9h2oX06();
			OptionsSettings.badColor = dut0a6FCClF9uncpHt4baoWwu.DnCcnTnPw5ZJ82mTIu9h2oX06();
			OptionsSettings.cursorColor = dut0a6FCClF9uncpHt4baoWwu.DnCcnTnPw5ZJ82mTIu9h2oX06();
			OptionsSettings.fontColor = dut0a6FCClF9uncpHt4baoWwu.DnCcnTnPw5ZJ82mTIu9h2oX06();
			OptionsSettings.foregroundColor = dut0a6FCClF9uncpHt4baoWwu.DnCcnTnPw5ZJ82mTIu9h2oX06();
			OptionsSettings.fov = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
			OptionsSettings.gameVolume = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
			OptionsSettings.metric = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.proUI = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.shadowColor = dut0a6FCClF9uncpHt4baoWwu.DnCcnTnPw5ZJ82mTIu9h2oX06();
			OptionsSettings.ShouldHitmarkersFollowWorldPosition = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.UnfocusedVolume = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
			OptionsSettings.VoiceAlwaysRecording = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.voiceVolume = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
			OptionsSettings.ambience = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.chatText = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.chatVoiceIn = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.chatVoiceOut = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.criticalHitmarkerColor = dut0a6FCClF9uncpHt4baoWwu.DnCcnTnPw5ZJ82mTIu9h2oX06();
			OptionsSettings.crosshairColor = dut0a6FCClF9uncpHt4baoWwu.DnCcnTnPw5ZJ82mTIu9h2oX06();
			OptionsSettings.crosshairShape = (ECrosshairShape)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			OptionsSettings.debug = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.enableScreenshotsOnLoadingScreen = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.enableScreenshotSupersampling = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.featuredWorkshop = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.filter = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.gore = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.hints = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.hitmarkerColor = dut0a6FCClF9uncpHt4baoWwu.DnCcnTnPw5ZJ82mTIu9h2oX06();
			OptionsSettings.hitmarkerStyle = (EHitmarkerStyle)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			OptionsSettings.loadingScreenMusicVolume = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
			bool flag2 = b == 0;
			if (flag2)
			{
				dut0a6FCClF9uncpHt4baoWwu.DgTrevnMqiGTEn0P1JdH0dHcY++;
			}
			else
			{
				OptionsSettings.MusicMasterVolume = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
				OptionsSettings.MainMenuMusicVolume = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
				OptionsSettings.ambientMusicVolume = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
				OptionsSettings.deathMusicVolume = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
				OptionsSettings.loadingScreenMusicVolume = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
			}
			OptionsSettings.pauseWhenUnfocused = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.screenshotSizeMultiplier = dut0a6FCClF9uncpHt4baoWwu.D4A9IMafSh9GwdPdbI0EZOAxx();
			OptionsSettings.shouldNametagFadeOut = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.showHotbar = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.splashscreen = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.staticCrosshairSize = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
			OptionsSettings.streamer = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.talk = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.timer = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.useStaticCrosshair = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			OptionsSettings.vehicleThirdPersonCameraMode = (EVehicleThirdPersonCameraMode)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			OptionsSettings.volume = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
			try
			{
				OptionsSettings.save();
			}
			catch
			{
			}
			DHL4u9JW55KHn4yqahAsAca0g.D1HuueboQ2CkBbQrUBMjFL2Jl.Invoke(null, new object[0]);
			ControlsSettings.aiming = (EControlMode)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			ControlsSettings.crouching = (EControlMode)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			ControlsSettings.invert = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			ControlsSettings.invertFlight = dut0a6FCClF9uncpHt4baoWwu.DugoucznVJ1iWS8iior9p4Yvb();
			ControlsSettings.leaning = (EControlMode)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			ControlsSettings.mouseAimSensitivity = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
			ControlsSettings.projectionRatioCoefficient = dut0a6FCClF9uncpHt4baoWwu.D26dIutcWHq5LifcnZlAGkD0o();
			ControlsSettings.proning = (EControlMode)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			ControlsSettings.sensitivityScalingMode = (ESensitivityScalingMode)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			ControlsSettings.sprinting = (EControlMode)dut0a6FCClF9uncpHt4baoWwu.DHk10Sr15Ttt5vv1GYpcpUkoU();
			ushort num = dut0a6FCClF9uncpHt4baoWwu.DmAu4cEiGWLGp7NLhkOyVsRbx();
			bool flag3 = ControlsSettings.bindings.Length == (int)num;
			if (flag3)
			{
				for (ushort num2 = 0; num2 < num; num2 += 1)
				{
					ControlsSettings.bindings[(int)num2].key = (KeyCode)dut0a6FCClF9uncpHt4baoWwu.DmAu4cEiGWLGp7NLhkOyVsRbx();
				}
			}
			try
			{
				ControlsSettings.save();
			}
			catch
			{
			}
			DHL4u9JW55KHn4yqahAsAca0g.D4ppRzhEP27LsqmCRv3B06UR0.Invoke(null, new object[0]);
			DHL4u9JW55KHn4yqahAsAca0g.DRqgCo1GeIbwzyos0MbbEFcz4 = fileName.Substring(0, fileName.Length - ".conf".Length);
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
			Debug.Log(ex.StackTrace);
		}
	}

	// Token: 0x06000203 RID: 515 RVA: 0x0001A4E4 File Offset: 0x000186E4
	public static void Dgn0GCDaP0rUUxtwiRI2vR4un(string name)
	{
		DHL4u9JW55KHn4yqahAsAca0g.DswlHO7qyc69Cj5RAE6XszvzY();
		DTQTgBvjhehJ9nKOGQCJPsaGO dtqtgBvjhehJ9nKOGQCJPsaGO = new DTQTgBvjhehJ9nKOGQCJPsaGO();
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR(2);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.anisotropicFilteringMode);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.antiAliasingType);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.blast);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.blend);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.bloom);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.buffer);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.chromaticAberration);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.debris);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.effectQuality);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.filmGrain);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.foliageFocus);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.foliageQuality);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.fullscreenMode);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.glitter);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.grassDisplacement);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.isAmbientOcclusionEnabled);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.IsItemIconAntiAliasingEnabled);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.landmarkQuality);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.lightingQuality);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(GraphicsSettings.normalizedDrawDistance);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(GraphicsSettings.NormalizedFarClipDistance);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(GraphicsSettings.normalizedLandmarkDrawDistance);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.outlineQuality);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.planarReflectionQuality);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.puddle);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.ragdolls);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.reflectionQuality);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.renderMode);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.scopeQuality);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.skyboxReflection);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.sunShaftsQuality);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DwTWdG1zkzaGlxDGRH2ahyh0C(GraphicsSettings.TargetFrameRate);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.terrainQuality);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.triplanar);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.uncapLandmarks);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DwTWdG1zkzaGlxDGRH2ahyh0C(GraphicsSettings.UnfocusedTargetFrameRate);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(GraphicsSettings.userInterfaceScale);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.UseTargetFrameRate);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.UseUnfocusedTargetFrameRate);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)GraphicsSettings.waterQuality);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(GraphicsSettings.IsWindEnabled);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DEprWqfyA3L4QwxKqT3Shbqii(OptionsSettings.backgroundColor);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DEprWqfyA3L4QwxKqT3Shbqii(OptionsSettings.badColor);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DEprWqfyA3L4QwxKqT3Shbqii(OptionsSettings.cursorColor);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DEprWqfyA3L4QwxKqT3Shbqii(OptionsSettings.fontColor);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DEprWqfyA3L4QwxKqT3Shbqii(OptionsSettings.foregroundColor);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(OptionsSettings.fov);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(OptionsSettings.gameVolume);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.metric);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.proUI);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DEprWqfyA3L4QwxKqT3Shbqii(OptionsSettings.shadowColor);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.ShouldHitmarkersFollowWorldPosition);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(OptionsSettings.UnfocusedVolume);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.VoiceAlwaysRecording);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(OptionsSettings.voiceVolume);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.ambience);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.chatText);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.chatVoiceIn);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.chatVoiceOut);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DEprWqfyA3L4QwxKqT3Shbqii(OptionsSettings.criticalHitmarkerColor);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DEprWqfyA3L4QwxKqT3Shbqii(OptionsSettings.crosshairColor);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)OptionsSettings.crosshairShape);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.debug);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.enableScreenshotsOnLoadingScreen);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.enableScreenshotSupersampling);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.featuredWorkshop);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.filter);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.gore);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.hints);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DEprWqfyA3L4QwxKqT3Shbqii(OptionsSettings.hitmarkerColor);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)OptionsSettings.hitmarkerStyle);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(OptionsSettings.loadingScreenMusicVolume);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(OptionsSettings.MusicMasterVolume);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(OptionsSettings.MainMenuMusicVolume);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(OptionsSettings.ambientMusicVolume);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(OptionsSettings.deathMusicVolume);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(OptionsSettings.loadingScreenMusicVolume);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.pauseWhenUnfocused);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DwTWdG1zkzaGlxDGRH2ahyh0C(OptionsSettings.screenshotSizeMultiplier);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.shouldNametagFadeOut);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.showHotbar);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.splashscreen);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(OptionsSettings.staticCrosshairSize);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.streamer);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.talk);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.timer);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(OptionsSettings.useStaticCrosshair);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)OptionsSettings.vehicleThirdPersonCameraMode);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(OptionsSettings.volume);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)ControlsSettings.aiming);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)ControlsSettings.crouching);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(ControlsSettings.invert);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DzjcnttV9066oi9WNYph9lY9r(ControlsSettings.invertFlight);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)ControlsSettings.leaning);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(ControlsSettings.mouseAimSensitivity);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DL6gSL4k14PueOaQvo422wnpX(ControlsSettings.projectionRatioCoefficient);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)ControlsSettings.proning);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)ControlsSettings.sensitivityScalingMode);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DvmRndmWftv5PwWn9pkcnfpAR((byte)ControlsSettings.sprinting);
		dtqtgBvjhehJ9nKOGQCJPsaGO.DqHK2AOqBv0WgvxpmWqM30pSD((ushort)ControlsSettings.bindings.Length);
		foreach (ControlBinding controlBinding in ControlsSettings.bindings)
		{
			dtqtgBvjhehJ9nKOGQCJPsaGO.DqHK2AOqBv0WgvxpmWqM30pSD((ushort)controlBinding.key);
		}
		File.WriteAllBytes(Application.dataPath + "/configs/" + name + ".conf", dtqtgBvjhehJ9nKOGQCJPsaGO.DJ96PmsXBUavL0r6hhy1pJM6N.ToArray());
	}

	// Token: 0x04000282 RID: 642
	public static List<string> Dv3ysxn5xWpghuiaDYKQhpp5e = new List<string>();

	// Token: 0x04000283 RID: 643
	public static string DRqgCo1GeIbwzyos0MbbEFcz4 = "config save name here";

	// Token: 0x04000284 RID: 644
	private const byte DmwPFA5Vm9oImoFpy0fvjIbLu = 2;

	// Token: 0x04000285 RID: 645
	private const string DABa2PCAn6XzOVwP9UnVFnNoU = ".conf";

	// Token: 0x04000286 RID: 646
	private static MethodInfo D1HuueboQ2CkBbQrUBMjFL2Jl;

	// Token: 0x04000287 RID: 647
	private static MethodInfo DfVwnJCdaa9r9gVjbBk0OdhBj;

	// Token: 0x04000288 RID: 648
	private static MethodInfo D4ppRzhEP27LsqmCRv3B06UR0;
}
