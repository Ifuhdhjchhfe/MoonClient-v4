using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000A0 RID: 160
public class DPtBTIvImbNsY0wJMuNEEHVIe
{
	// Token: 0x06000310 RID: 784 RVA: 0x0002DBB8 File Offset: 0x0002BDB8
	public DPtBTIvImbNsY0wJMuNEEHVIe(ushort itemId)
	{
		this.DWIIMdoRU9Gg6ljjZ406dneW0 = itemId;
		this.DQc9tmkTvoXN6ifrjZgm786ab = new Dictionary<byte[], Texture2D>();
	}

	// Token: 0x06000311 RID: 785 RVA: 0x0002DBD4 File Offset: 0x0002BDD4
	public bool D4yDTPZG015oGu0zbkQBd1cS7(byte[] state)
	{
		foreach (byte[] array in this.DQc9tmkTvoXN6ifrjZgm786ab.Keys)
		{
			bool flag = true;
			bool flag2 = state.Length != array.Length;
			bool flag3 = !flag2;
			if (flag3)
			{
				for (int i = 0; i < array.Length; i++)
				{
					bool flag4 = state[i] != array[i];
					bool flag5 = flag4;
					if (flag5)
					{
						flag = false;
						break;
					}
				}
				bool flag6 = flag;
				bool flag7 = flag6;
				if (flag7)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06000312 RID: 786 RVA: 0x0002DC94 File Offset: 0x0002BE94
	public Texture2D DT090naXqz4YZPMfIY5MVIHP2(byte[] state)
	{
		foreach (byte[] array in this.DQc9tmkTvoXN6ifrjZgm786ab.Keys)
		{
			bool flag = true;
			bool flag2 = state.Length != array.Length;
			bool flag3 = !flag2;
			if (flag3)
			{
				for (int i = 0; i < array.Length; i++)
				{
					bool flag4 = state[i] != array[i];
					bool flag5 = flag4;
					if (flag5)
					{
						flag = false;
						break;
					}
				}
				bool flag6 = flag;
				bool flag7 = flag6;
				if (flag7)
				{
					return this.DQc9tmkTvoXN6ifrjZgm786ab[array];
				}
			}
		}
		return null;
	}

	// Token: 0x04000370 RID: 880
	public ushort DWIIMdoRU9Gg6ljjZ406dneW0;

	// Token: 0x04000371 RID: 881
	public Dictionary<byte[], Texture2D> DQc9tmkTvoXN6ifrjZgm786ab;
}
