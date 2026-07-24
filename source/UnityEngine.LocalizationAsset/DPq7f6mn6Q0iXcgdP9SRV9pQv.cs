using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200009F RID: 159
public class DPq7f6mn6Q0iXcgdP9SRV9pQv
{
	// Token: 0x0600030D RID: 781 RVA: 0x0002DB10 File Offset: 0x0002BD10
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerPauseUI), "onClickedExitButton", new Type[] { })]
	private static void DF9000BxwJJKz6ntXxNzOoY3F(SleekButtonIconConfirm button)
	{
		bool flag = PlayerPauseUI.shouldExitButtonRespectTimer && Time.realtimeSinceStartup - PlayerPauseUI.lastLeave < Provider.modeConfigData.Gameplay.Timer_Exit && !D5l46jlssr4TRAzUSXzLj0uqu.ignoreLeaveTimer;
		bool flag2 = !flag;
		if (flag2)
		{
			Provider.RequestDisconnect("clicked exit button from in-game pause menu");
		}
	}

	// Token: 0x0600030E RID: 782 RVA: 0x0002DB64 File Offset: 0x0002BD64
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(PlayerPauseUI), "onClickedQuitButton", new Type[] { })]
	private static void D0qHBlaU9yHZnRhK4bk3VmieU(SleekButtonIconConfirm button)
	{
		bool flag = PlayerPauseUI.shouldExitButtonRespectTimer && Time.realtimeSinceStartup - PlayerPauseUI.lastLeave < Provider.modeConfigData.Gameplay.Timer_Exit && !D5l46jlssr4TRAzUSXzLj0uqu.ignoreLeaveTimer;
		bool flag2 = !flag;
		if (flag2)
		{
			Provider.QuitGame("clicked quit from in-game pause menu");
		}
	}
}
