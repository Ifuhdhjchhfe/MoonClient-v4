using System;
using System.Reflection;
using SDG.Unturned;

// Token: 0x020000B8 RID: 184
public class DT3wqbk0VtJ3bqexJjyIkSl2K
{
	// Token: 0x0600039C RID: 924 RVA: 0x000373D1 File Offset: 0x000355D1
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(Provider), "awake", new Type[] { })]
	public void DMftuJvXSSWSFcpAyCNsBvsqS()
	{
		DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(this, Array.Empty<object>());
		DNvjrDV53gpGJEJwnNwmyFRZw.DHiIrr2YEci0nxWrzSBI7cgvW();
	}

	// Token: 0x0600039D RID: 925 RVA: 0x000373E8 File Offset: 0x000355E8
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(Provider), "receiveWorkshopResponse", new Type[] { })]
	internal static void D56ryGV6BOlv5UqkEbumINa9f(object response)
	{
		D5l46jlssr4TRAzUSXzLj0uqu.D66xkrBp6Z1GTuSAAF2uDhRmK = (ECameraMode)response.GetType().GetField("cameraMode", BindingFlags.Instance | BindingFlags.Public).GetValue(response);
		bool modifyPlayerPerspective = D5l46jlssr4TRAzUSXzLj0uqu.modifyPlayerPerspective;
		if (modifyPlayerPerspective)
		{
			D08iy2XFQpUQteL0XRzAbg2IE.Dr06TnUlTEh4Mt9XdzQtoz0Lb(typeof(SteamServerAdvertisement), "_cameraMode", D08iy2XFQpUQteL0XRzAbg2IE.DnNL1SGsF3trBXsR4aT63oXVe(typeof(Provider), "_currentServerAdvertisement", null), D5l46jlssr4TRAzUSXzLj0uqu.playerPerspective);
			response.GetType().GetField("cameraMode", BindingFlags.Instance | BindingFlags.Public).SetValue(response, D5l46jlssr4TRAzUSXzLj0uqu.playerPerspective);
		}
		DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(null, new object[] { response });
	}

	// Token: 0x0600039E RID: 926 RVA: 0x0003748C File Offset: 0x0003568C
	[DK25cIW1nkfhHjlmZqnMOqUJq(typeof(Provider), "removePlayer", new Type[] { })]
	internal static void D0N5pPc0HELTsxXUjZVmTVzAF(byte index)
	{
		bool flag = index < 0 || (int)index >= Provider.clients.Count;
		if (flag)
		{
			UnturnedLog.error("Failed to find player: " + index.ToString());
		}
		else
		{
			try
			{
				D7ElSFH0pY0XmMbO1Ij5Yf3Tp.DKA0lfUf4pi3epPY0Utt9yFSo(Provider.clients[(int)index].GetNetId().id, null);
			}
			catch
			{
			}
			DA1dZHkBmPouE1WuakM2TW4QH.DVQNp76PYYTgyxPuzAgm1P01g(null, new object[] { index });
		}
	}
}
