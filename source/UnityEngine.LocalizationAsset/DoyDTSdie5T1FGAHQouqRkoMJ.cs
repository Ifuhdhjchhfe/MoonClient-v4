using System;
using SDG.NetTransport;
using SDG.Unturned;
using UnityEngine;

// Token: 0x0200009B RID: 155
public class DoyDTSdie5T1FGAHQouqRkoMJ : MonoBehaviour
{
	// Token: 0x060002F2 RID: 754 RVA: 0x0002A9F0 File Offset: 0x00028BF0
	public static void DC3MLEkwgi2UAEOLDoCp7lyYI(bool state)
	{
		bool flag = state && DoyDTSdie5T1FGAHQouqRkoMJ.DvtEGgufelH22TZKf1WBAzVCx == null;
		bool flag2 = flag;
		if (flag2)
		{
			DoyDTSdie5T1FGAHQouqRkoMJ.DvtEGgufelH22TZKf1WBAzVCx = D0Kr0NqRHBD41IMsgv7ajeW8M.D1tYt6KxEmATG67AhmCiQjAGN.AddComponent<DoyDTSdie5T1FGAHQouqRkoMJ>();
		}
		else
		{
			bool flag3 = !state && DoyDTSdie5T1FGAHQouqRkoMJ.DvtEGgufelH22TZKf1WBAzVCx != null;
			bool flag4 = flag3;
			if (flag4)
			{
				global::UnityEngine.Object.Destroy(DoyDTSdie5T1FGAHQouqRkoMJ.DvtEGgufelH22TZKf1WBAzVCx);
			}
		}
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x0002AA50 File Offset: 0x00028C50
	private void Update()
	{
		this.DPPPRHbhx90pjlQomUtWDSAfH += Time.deltaTime;
		bool flag = this.DPPPRHbhx90pjlQomUtWDSAfH > D5l46jlssr4TRAzUSXzLj0uqu.chatSpamDelay;
		bool flag2 = flag;
		if (flag2)
		{
			this.DPPPRHbhx90pjlQomUtWDSAfH = 0f;
			DoyDTSdie5T1FGAHQouqRkoMJ.SendChatRequest.Invoke(ENetReliability.Unreliable, (byte)D5l46jlssr4TRAzUSXzLj0uqu.spamChatZone, D5l46jlssr4TRAzUSXzLj0uqu.spamText);
		}
	}

	// Token: 0x0400034A RID: 842
	private static DoyDTSdie5T1FGAHQouqRkoMJ DvtEGgufelH22TZKf1WBAzVCx;

	// Token: 0x0400034B RID: 843
	private float DPPPRHbhx90pjlQomUtWDSAfH = 0f;

	// Token: 0x0400034C RID: 844
	private static readonly ServerStaticMethod<byte, string> SendChatRequest = ServerStaticMethod<byte, string>.Get(new ServerStaticMethod<byte, string>.ReceiveDelegateWithContext(ChatManager.ReceiveChatRequest));
}
