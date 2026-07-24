using System;
using UnityEngine;

// Token: 0x0200005B RID: 91
public static class Dg1g88fq9HrwapVlAVu52TAWS
{
	// Token: 0x060001B0 RID: 432 RVA: 0x00016C3C File Offset: 0x00014E3C
	public static bool DGxZdvjodtrVw5BNkkaZ9SGFr(this Vector3 pos)
	{
		bool dpxZp2Jw9ifhgtZ5Fai9okn4i = DDddnUl0gHJ8ZiQTaRLEUBUS2.DPxZp2Jw9ifhgtZ5Fai9okn4i;
		bool flag = dpxZp2Jw9ifhgtZ5Fai9okn4i;
		bool flag2;
		if (flag)
		{
			pos = DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.WorldToViewportPoint(pos);
			flag2 = pos.z > 0f && pos.x > 0f && pos.x < 1f && pos.y > 0f && pos.y < 1f;
		}
		else
		{
			Dg1g88fq9HrwapVlAVu52TAWS.DTlMEQ2hyhIkYMiYm6GqTKLNB = Vector3.Normalize(pos - DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.position);
			Dg1g88fq9HrwapVlAVu52TAWS.Dyvo1HUEnaCq9anKwabQbLy5n = Mathf.Acos(Vector3.Dot(DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.forward, Dg1g88fq9HrwapVlAVu52TAWS.DTlMEQ2hyhIkYMiYm6GqTKLNB)) * 57.29578f;
			flag2 = Vector3.Dot(DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.transform.forward, Dg1g88fq9HrwapVlAVu52TAWS.DTlMEQ2hyhIkYMiYm6GqTKLNB) > 0f && Dg1g88fq9HrwapVlAVu52TAWS.Dyvo1HUEnaCq9anKwabQbLy5n <= DhNbDL0xpxhG1wADC5uXvFshQ.Dr38GGKdBZ2EXiNCUdvVjgmhc.fieldOfView / 1.5f;
		}
		return flag2;
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x00016D3C File Offset: 0x00014F3C
	public static Vector2 DEfdLut9iGJvTAJNGrXHRFglR(this Vector3 pos)
	{
		Dg1g88fq9HrwapVlAVu52TAWS.D70K6CTyXDY01spYh0MGqU5jz = DhNbDL0xpxhG1wADC5uXvFshQ.D0dFeYUac5o0ycmUFaeSj1J46 * DhNbDL0xpxhG1wADC5uXvFshQ.Dvnc7NMv3T5T0nPfgcO28KXhC;
		Vector4 vector = Dg1g88fq9HrwapVlAVu52TAWS.D70K6CTyXDY01spYh0MGqU5jz * new Vector4(pos.x, pos.y, pos.z, 1f);
		bool flag = vector.w <= 0f;
		Vector2 vector2;
		if (flag)
		{
			vector2 = new Vector2(float.NaN, float.NaN);
		}
		else
		{
			Dg1g88fq9HrwapVlAVu52TAWS.DN20ii7XoVI0I05ggs0kbx6J4 = new Vector3(vector.x / vector.w, vector.y / vector.w, 0f);
			Dg1g88fq9HrwapVlAVu52TAWS.DN20ii7XoVI0I05ggs0kbx6J4 = new Vector3((Dg1g88fq9HrwapVlAVu52TAWS.DN20ii7XoVI0I05ggs0kbx6J4.x + 1f) * (float)Screen.width, (Dg1g88fq9HrwapVlAVu52TAWS.DN20ii7XoVI0I05ggs0kbx6J4.y + 1f) * (float)Screen.height, 0f) / 2f;
			vector2 = new Vector2(Dg1g88fq9HrwapVlAVu52TAWS.DN20ii7XoVI0I05ggs0kbx6J4.x, (float)Screen.height - Dg1g88fq9HrwapVlAVu52TAWS.DN20ii7XoVI0I05ggs0kbx6J4.y);
		}
		return vector2;
	}

	// Token: 0x04000221 RID: 545
	private static Matrix4x4 D70K6CTyXDY01spYh0MGqU5jz;

	// Token: 0x04000222 RID: 546
	private static Vector3 DN20ii7XoVI0I05ggs0kbx6J4;

	// Token: 0x04000223 RID: 547
	private static Vector3 DTlMEQ2hyhIkYMiYm6GqTKLNB;

	// Token: 0x04000224 RID: 548
	private static float Dyvo1HUEnaCq9anKwabQbLy5n;
}
