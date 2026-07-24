using System;
using System.Linq;
using UnityEngine;

// Token: 0x02000089 RID: 137
public class DmPiKLTgXJElGQkNrd35XkuQv : DOEkZ1zoBEuvfUmOs9QSpfX0X
{
	// Token: 0x0600028E RID: 654 RVA: 0x00025F50 File Offset: 0x00024150
	public override string GetName()
	{
		return "Console";
	}

	// Token: 0x0600028F RID: 655 RVA: 0x00025F68 File Offset: 0x00024168
	public override DYIPJORHeVCfbpocFHvJty4OE GetTabCounts()
	{
		return DYIPJORHeVCfbpocFHvJty4OE.Three;
	}

	// Token: 0x06000290 RID: 656 RVA: 0x00025F7C File Offset: 0x0002417C
	public override void DoTab(DYIPJORHeVCfbpocFHvJty4OE tc)
	{
		bool flag = tc == DYIPJORHeVCfbpocFHvJty4OE.One;
		if (flag)
		{
			base.DGLNJE6Ld056OViYFjOM7IeMS("Unity logs");
			this.DmxyGJEnrSwn70EIZitZ6CYyR[0] = GUILayout.BeginScrollView(this.DmxyGJEnrSwn70EIZitZ6CYyR[0], Array.Empty<GUILayoutOption>());
			foreach (string text in DovA0560C5xwc06yYBWmht6vA.DIMZq0moQ9Z4aIeIwVnQ7EjDq.Skip<string>(Math.Max(0, DovA0560C5xwc06yYBWmht6vA.DIMZq0moQ9Z4aIeIwVnQ7EjDq.Count - 100)))
			{
				GUILayout.Label(text, Array.Empty<GUILayoutOption>());
			}
			GUILayout.EndScrollView();
		}
		else
		{
			bool flag2 = tc == DYIPJORHeVCfbpocFHvJty4OE.Two;
			if (flag2)
			{
				base.DGLNJE6Ld056OViYFjOM7IeMS("Unturned logs");
				this.DmxyGJEnrSwn70EIZitZ6CYyR[1] = GUILayout.BeginScrollView(this.DmxyGJEnrSwn70EIZitZ6CYyR[1], Array.Empty<GUILayoutOption>());
				foreach (string text2 in DovA0560C5xwc06yYBWmht6vA.DCgg0qYxFHUhHRZX5T00i6ujT.Skip<string>(Math.Max(0, DovA0560C5xwc06yYBWmht6vA.DCgg0qYxFHUhHRZX5T00i6ujT.Count - 100)))
				{
					GUILayout.Label(text2, Array.Empty<GUILayoutOption>());
				}
				GUILayout.EndScrollView();
			}
			else
			{
				base.DGLNJE6Ld056OViYFjOM7IeMS("MC Client Logs");
				this.DmxyGJEnrSwn70EIZitZ6CYyR[2] = GUILayout.BeginScrollView(this.DmxyGJEnrSwn70EIZitZ6CYyR[2], Array.Empty<GUILayoutOption>());
				foreach (string text3 in DovA0560C5xwc06yYBWmht6vA.DQomy0cNRnzM0Q09KIWr8hyKI.Skip<string>(Math.Max(0, DovA0560C5xwc06yYBWmht6vA.DQomy0cNRnzM0Q09KIWr8hyKI.Count - 100)))
				{
					GUILayout.Label(text3, Array.Empty<GUILayoutOption>());
				}
				GUILayout.EndScrollView();
			}
		}
	}

	// Token: 0x04000319 RID: 793
	public Vector2[] DmxyGJEnrSwn70EIZitZ6CYyR = new Vector2[3];
}
