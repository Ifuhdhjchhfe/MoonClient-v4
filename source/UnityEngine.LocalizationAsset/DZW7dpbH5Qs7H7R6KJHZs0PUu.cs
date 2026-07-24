using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x020000E4 RID: 228
public class DZW7dpbH5Qs7H7R6KJHZs0PUu : MonoBehaviour
{
	// Token: 0x06000436 RID: 1078 RVA: 0x0003F0DC File Offset: 0x0003D2DC
	[DyRHDWg89xeNs0wA42v5OHmTi]
	private static void DI5PgXqbZRgiwLi6OIkSJO2C4()
	{
		DI4RfMJ7ziJuscMZZoy2MIzrV.De2hBwLmnyYClZ9fwAmbPOhqc = (DIDzNgrvnOa5xIZrJtz5ZO48o)Delegate.Combine(DI4RfMJ7ziJuscMZZoy2MIzrV.De2hBwLmnyYClZ9fwAmbPOhqc, new DIDzNgrvnOa5xIZrJtz5ZO48o(DZW7dpbH5Qs7H7R6KJHZs0PUu.DsYUzsezO6lXnhmJBHGJvCQI0));
		DI4RfMJ7ziJuscMZZoy2MIzrV.DU6EO20XNycI0rg03jSyQr0k6 = (DIDzNgrvnOa5xIZrJtz5ZO48o)Delegate.Combine(DI4RfMJ7ziJuscMZZoy2MIzrV.DU6EO20XNycI0rg03jSyQr0k6, new DIDzNgrvnOa5xIZrJtz5ZO48o(DZW7dpbH5Qs7H7R6KJHZs0PUu.DGRtuq6qDFBuBlvDImRTsKeNu));
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x0003F12C File Offset: 0x0003D32C
	private void Awake()
	{
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		DZW7dpbH5Qs7H7R6KJHZs0PUu.DSnFwyDSJiRcayfNoTM5EALne = base.gameObject.AddComponent<Camera>();
		bool flag = MainCamera.instance != null;
		bool flag2 = flag;
		if (flag2)
		{
			base.transform.position = MainCamera.instance.transform.position;
			DZW7dpbH5Qs7H7R6KJHZs0PUu.DSnFwyDSJiRcayfNoTM5EALne.clearFlags = MainCamera.instance.clearFlags;
			DZW7dpbH5Qs7H7R6KJHZs0PUu.DSnFwyDSJiRcayfNoTM5EALne.fieldOfView = MainCamera.instance.fieldOfView;
			DZW7dpbH5Qs7H7R6KJHZs0PUu.DSnFwyDSJiRcayfNoTM5EALne.farClipPlane = MainCamera.instance.farClipPlane;
			DZW7dpbH5Qs7H7R6KJHZs0PUu.DSnFwyDSJiRcayfNoTM5EALne.nearClipPlane = MainCamera.instance.nearClipPlane;
			DZW7dpbH5Qs7H7R6KJHZs0PUu.DSnFwyDSJiRcayfNoTM5EALne.cullingMask = MainCamera.instance.cullingMask;
			DZW7dpbH5Qs7H7R6KJHZs0PUu.DrxO1AR0UlmyT50wY1U0WYU3w = MainCamera.instance;
			DZW7dpbH5Qs7H7R6KJHZs0PUu.DrxO1AR0UlmyT50wY1U0WYU3w.enabled = false;
		}
		base.gameObject.tag = "MainCamera";
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x0003F218 File Offset: 0x0003D418
	private void OnDestroy()
	{
		bool flag = DZW7dpbH5Qs7H7R6KJHZs0PUu.DrxO1AR0UlmyT50wY1U0WYU3w != null;
		bool flag2 = flag;
		if (flag2)
		{
			DZW7dpbH5Qs7H7R6KJHZs0PUu.DrxO1AR0UlmyT50wY1U0WYU3w.enabled = true;
		}
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x0003F248 File Offset: 0x0003D448
	private static void DsYUzsezO6lXnhmJBHGJvCQI0()
	{
		bool flag = DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr != null && DZW7dpbH5Qs7H7R6KJHZs0PUu.DrxO1AR0UlmyT50wY1U0WYU3w != null;
		bool flag2 = flag;
		if (flag2)
		{
			DZW7dpbH5Qs7H7R6KJHZs0PUu.DrxO1AR0UlmyT50wY1U0WYU3w.enabled = true;
			DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.enabled = false;
			DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.gameObject.tag = "Default";
		}
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x0003F2A8 File Offset: 0x0003D4A8
	private static void DGRtuq6qDFBuBlvDImRTsKeNu()
	{
		bool flag = DZW7dpbH5Qs7H7R6KJHZs0PUu.DrxO1AR0UlmyT50wY1U0WYU3w != null && DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr != null;
		bool flag2 = flag;
		if (flag2)
		{
			DZW7dpbH5Qs7H7R6KJHZs0PUu.DrxO1AR0UlmyT50wY1U0WYU3w.enabled = false;
			DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.enabled = true;
			DZW7dpbH5Qs7H7R6KJHZs0PUu.DEQ0M7cOQx0LtOkV0KMVDU8Wr.gameObject.tag = "MainCamera";
		}
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x0003F308 File Offset: 0x0003D508
	private void Update()
	{
		this.D6ONPjNIk5EMYwaGjCjiuZA03 = 0f;
		this.DzMOhgtkFgcPReuKPL6A5JymX = 0f;
		this.DLo9jfT02UK9if0ekzYFwT1jA = 0f;
		bool key = InputEx.GetKey(ControlsSettings.sprint);
		bool flag = key;
		if (flag)
		{
			this.DWSJbiBWDpCIJKI78wAX9OpPT = D5l46jlssr4TRAzUSXzLj0uqu.freeCameraSpeed * 2;
		}
		else
		{
			this.DWSJbiBWDpCIJKI78wAX9OpPT = D5l46jlssr4TRAzUSXzLj0uqu.freeCameraSpeed;
		}
		bool key2 = InputEx.GetKey(ControlsSettings.jump);
		bool flag2 = key2;
		if (flag2)
		{
			this.D6ONPjNIk5EMYwaGjCjiuZA03 = (float)this.DWSJbiBWDpCIJKI78wAX9OpPT * Time.deltaTime;
		}
		else
		{
			bool key3 = InputEx.GetKey(ControlsSettings.crouch);
			bool flag3 = key3;
			if (flag3)
			{
				this.D6ONPjNIk5EMYwaGjCjiuZA03 = -((float)this.DWSJbiBWDpCIJKI78wAX9OpPT * Time.deltaTime);
			}
		}
		bool key4 = InputEx.GetKey(ControlsSettings.left);
		bool flag4 = key4;
		if (flag4)
		{
			this.DzMOhgtkFgcPReuKPL6A5JymX = -((float)this.DWSJbiBWDpCIJKI78wAX9OpPT * Time.deltaTime);
		}
		else
		{
			bool key5 = InputEx.GetKey(ControlsSettings.right);
			bool flag5 = key5;
			if (flag5)
			{
				this.DzMOhgtkFgcPReuKPL6A5JymX = (float)this.DWSJbiBWDpCIJKI78wAX9OpPT * Time.deltaTime;
			}
		}
		bool key6 = InputEx.GetKey(ControlsSettings.up);
		bool flag6 = key6;
		if (flag6)
		{
			this.DLo9jfT02UK9if0ekzYFwT1jA = (float)this.DWSJbiBWDpCIJKI78wAX9OpPT * Time.deltaTime;
		}
		else
		{
			bool key7 = InputEx.GetKey(ControlsSettings.down);
			bool flag7 = key7;
			if (flag7)
			{
				this.DLo9jfT02UK9if0ekzYFwT1jA = -((float)this.DWSJbiBWDpCIJKI78wAX9OpPT * Time.deltaTime);
			}
		}
		bool flag8 = Input.mouseScrollDelta.y != 0f;
		bool flag9 = flag8;
		if (flag9)
		{
			D5l46jlssr4TRAzUSXzLj0uqu.freeCameraSpeed = (int)Mathf.Clamp((float)D5l46jlssr4TRAzUSXzLj0uqu.freeCameraSpeed + Input.mouseScrollDelta.y * 4f, 3f, 35f);
		}
		this.DDV48bI2Z3Aah3QfNC8SrEKxg += ControlsSettings.mouseAimSensitivity * Input.GetAxis("mouse_x");
		this.DJlkAnXKQKcPXEE2BJ7QXvHax -= ControlsSettings.mouseAimSensitivity * Input.GetAxis("mouse_y");
		base.transform.eulerAngles = new Vector3(this.DJlkAnXKQKcPXEE2BJ7QXvHax, this.DDV48bI2Z3Aah3QfNC8SrEKxg, 0f);
		base.transform.Translate(this.DzMOhgtkFgcPReuKPL6A5JymX, this.D6ONPjNIk5EMYwaGjCjiuZA03, this.DLo9jfT02UK9if0ekzYFwT1jA);
	}

	// Token: 0x04000488 RID: 1160
	public static DZW7dpbH5Qs7H7R6KJHZs0PUu DEQ0M7cOQx0LtOkV0KMVDU8Wr;

	// Token: 0x04000489 RID: 1161
	public static Camera DrxO1AR0UlmyT50wY1U0WYU3w;

	// Token: 0x0400048A RID: 1162
	public static Camera DSnFwyDSJiRcayfNoTM5EALne;

	// Token: 0x0400048B RID: 1163
	private float DJlkAnXKQKcPXEE2BJ7QXvHax = 0f;

	// Token: 0x0400048C RID: 1164
	private float DDV48bI2Z3Aah3QfNC8SrEKxg = 0f;

	// Token: 0x0400048D RID: 1165
	private int DWSJbiBWDpCIJKI78wAX9OpPT = 5;

	// Token: 0x0400048E RID: 1166
	private float DzMOhgtkFgcPReuKPL6A5JymX = 0f;

	// Token: 0x0400048F RID: 1167
	private float DLo9jfT02UK9if0ekzYFwT1jA = 0f;

	// Token: 0x04000490 RID: 1168
	private float D6ONPjNIk5EMYwaGjCjiuZA03 = 0f;
}
