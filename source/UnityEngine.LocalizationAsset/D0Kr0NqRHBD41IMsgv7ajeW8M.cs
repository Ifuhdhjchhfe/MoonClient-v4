using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x02000009 RID: 9
public class D0Kr0NqRHBD41IMsgv7ajeW8M : MonoBehaviour
{
	// Token: 0x06000024 RID: 36 RVA: 0x000034CC File Offset: 0x000016CC
	private void Awake()
	{
		bool flag = !D0Kr0NqRHBD41IMsgv7ajeW8M.DxcVo94CW4Y8vQkyhpKozFmcW;
		if (flag)
		{
			this.Update();
		}
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000034F0 File Offset: 0x000016F0
	private void Update()
	{
		switch (this.DGg12XzhlBY4ScdtA0hbs5YPy)
		{
		case 1:
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::CLIENT");
			goto IL_0253;
		case 2:
		case 6:
		case 7:
			goto IL_0253;
		case 3:
			global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			D0Kr0NqRHBD41IMsgv7ajeW8M.D1tYt6KxEmATG67AhmCiQjAGN = base.gameObject;
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::OBJECTS");
			goto IL_0253;
		case 4:
			DTm52FQgIZyHlgsIe52RDqzcZ.DpdLw2SJ0vATI1xEZlg6dIq1A();
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::MANAGER");
			goto IL_0253;
		case 5:
			try
			{
				DHGBgVGlvxZ0K3LOA9TG3GHJ9.DUoMtu6s9z5IoFE7yZh747Nlc();
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::ATR_MANAGER");
			}
			catch (Exception ex)
			{
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::ATR_MANAGER FAILED!!!");
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.Message);
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex.StackTrace);
			}
			try
			{
				DHTB5RKsHUihFrfj9ewuLh1f9.Dv9BsDgHAnyYwdk6Cl3uqWZk7();
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::ASSET_MANAGER");
			}
			catch (Exception ex2)
			{
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::ASSET_MANAGER FAILED!!!");
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex2.Message);
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex2.StackTrace);
			}
			try
			{
				DA1dZHkBmPouE1WuakM2TW4QH.DvYwyZ1bxY64hLQk7ArMwMTwk();
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::OV_MANAGER");
				goto IL_0253;
			}
			catch (Exception ex3)
			{
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::OV_MANAGER FAILED!!!");
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex3.Message);
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex3.StackTrace);
				goto IL_0253;
			}
			break;
		case 8:
			break;
		case 9:
			try
			{
				D78avTg9KcyX9xog2Gp420bvj.DcMNDYAkieAsYXlck9rasxOz6();
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::BIND_MANAGER");
				goto IL_0253;
			}
			catch (Exception ex4)
			{
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::BIND_MANAGER FAILED!!!");
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex4.Message);
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex4.StackTrace);
				goto IL_0253;
			}
			break;
		case 10:
			D0Kr0NqRHBD41IMsgv7ajeW8M.D1tYt6KxEmATG67AhmCiQjAGN.AddComponent<DA99SI5vQ2bocOplrJX51I0fZ>();
			D0Kr0NqRHBD41IMsgv7ajeW8M.D1tYt6KxEmATG67AhmCiQjAGN.AddComponent<DctFo1N3H1REM7tTTbNS0zMFm>();
			try
			{
				D0Kr0NqRHBD41IMsgv7ajeW8M.D1tYt6KxEmATG67AhmCiQjAGN.AddComponent<PostProcessDebug>();
			}
			catch
			{
				DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("PostProcessDebug not available");
			}
			D0Kr0NqRHBD41IMsgv7ajeW8M.D1tYt6KxEmATG67AhmCiQjAGN.AddComponent<DL3tNdrQzY7o8FV1oIOKODOLQ>();
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::COMPONENTS");
			goto IL_0253;
		case 11:
			goto IL_023E;
		default:
			goto IL_0253;
		}
		try
		{
			Dxg2tDZdImJqrX71UMTW47xIk.DrTvkWcwJ8jJGDW9YWF7SBkmo();
			DHL4u9JW55KHn4yqahAsAca0g.DsGCzavTMhjHZxZrxP0lFBdPj();
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::CONFIGS");
			goto IL_0253;
		}
		catch (Exception ex5)
		{
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::CONFIGS FAILED!!!");
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex5.Message);
			DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti(ex5.StackTrace);
			goto IL_0253;
		}
		IL_023E:
		global::UnityEngine.Object.Destroy(this);
		DovA0560C5xwc06yYBWmht6vA.DC7YaTDHyZQRGosJeT1YY4oti("INIT::CLEAN");
		return;
		IL_0253:
		this.DGg12XzhlBY4ScdtA0hbs5YPy += 1;
		bool flag = !D0Kr0NqRHBD41IMsgv7ajeW8M.DxcVo94CW4Y8vQkyhpKozFmcW;
		if (flag)
		{
			this.Update();
		}
	}

	// Token: 0x04000011 RID: 17
	public static GameObject D1tYt6KxEmATG67AhmCiQjAGN;

	// Token: 0x04000012 RID: 18
	public static bool DxcVo94CW4Y8vQkyhpKozFmcW;

	// Token: 0x04000013 RID: 19
	public static bool DPUGQ6g8UxL9EdNwvkEHyMBy6;

	// Token: 0x04000014 RID: 20
	private byte DGg12XzhlBY4ScdtA0hbs5YPy;
}
