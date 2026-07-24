using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200005C RID: 92
public class Dg7HgPuhdjH1X6wkz4QJsSTzj : MonoBehaviour
{
	// Token: 0x060001B2 RID: 434 RVA: 0x00016E44 File Offset: 0x00015044
	private void Awake()
	{
		this.DAtZsfrmedn463iBb9x6JIanO = base.GetComponent<Renderer>();
		this.originalMaterials = this.DAtZsfrmedn463iBb9x6JIanO.sharedMaterials;
		this.DLOIdVfauEw0BxeZhRcmjEzZb = this.DAtZsfrmedn463iBb9x6JIanO.material;
		this.originalMaterialCount = this.originalMaterials.Length;
		bool flag = this.originalMaterialCount == 0;
		if (flag)
		{
			this.originalMaterialCount = 1;
		}
		Dg7HgPuhdjH1X6wkz4QJsSTzj.DLMXXTHY91pphkSNfe1aeHy3z.Add(this);
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00016EB0 File Offset: 0x000150B0
	private void OnDestroy()
	{
		Dg7HgPuhdjH1X6wkz4QJsSTzj.DLMXXTHY91pphkSNfe1aeHy3z.Remove(this);
		bool flag = this.DAtZsfrmedn463iBb9x6JIanO != null;
		if (flag)
		{
			this.D4k1u7qUj150ToIfAvqtwjeWZ();
		}
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00016EE4 File Offset: 0x000150E4
	public void DppB0fzXN5LcC63CiB3odb5qW(Material m)
	{
		this.Dy0gZ6iQlODpcERkM2RTH1IfP = m;
		bool flag = !DI4RfMJ7ziJuscMZZoy2MIzrV.DBJV74arVJtUMAqsSN0cWr9w6;
		bool flag2 = flag;
		if (flag2)
		{
			bool flag3 = this.myInstancedMaterial == null;
			if (flag3)
			{
				this.myInstancedMaterial = new Material(m);
			}
			else
			{
				this.myInstancedMaterial.CopyPropertiesFromMaterial(m);
			}
			bool flag4 = this.myInstancedMaterialHidden == null;
			if (flag4)
			{
				this.myInstancedMaterialHidden = new Material(m);
			}
			else
			{
				this.myInstancedMaterialHidden.CopyPropertiesFromMaterial(m);
			}
			this.myInstancedMaterial.shader = Shader.Find("Hidden/Internal-Colored");
			this.myInstancedMaterialHidden.shader = Shader.Find("Hidden/Internal-Colored");
			bool chamVisibilityCheck = DC1rDxetZPj7HetYbH0e8mKBb.ChamVisibilityCheck;
			if (chamVisibilityCheck)
			{
				Color color = Dvtdh0bRL5i9duanOvOedNrxe.ChamVisibleColor;
				Color color2 = Dvtdh0bRL5i9duanOvOedNrxe.ChamInvisibleColor;
				this.myInstancedMaterial.color = color;
				this.myInstancedMaterialHidden.color = color2;
			}
			else
			{
				this.myInstancedMaterial.color = m.color;
				this.myInstancedMaterialHidden.color = m.color;
			}
			bool chamVisibilityCheck2 = DC1rDxetZPj7HetYbH0e8mKBb.ChamVisibilityCheck;
			bool flag5 = chamVisibilityCheck2;
			if (flag5)
			{
				this.myInstancedMaterial.SetInt("_ZTest", 4);
				this.myInstancedMaterialHidden.SetInt("_ZTest", 6);
				bool flag6 = this.cachedDoubleMaterialArray == null || this.cachedDoubleMaterialArray.Length != this.originalMaterialCount * 2;
				if (flag6)
				{
					this.cachedDoubleMaterialArray = new Material[this.originalMaterialCount * 2];
				}
				for (int i = 0; i < this.originalMaterialCount; i++)
				{
					this.cachedDoubleMaterialArray[i] = this.myInstancedMaterialHidden;
					this.cachedDoubleMaterialArray[i + this.originalMaterialCount] = this.myInstancedMaterial;
				}
				this.DAtZsfrmedn463iBb9x6JIanO.sharedMaterials = this.cachedDoubleMaterialArray;
			}
			else
			{
				this.myInstancedMaterial.SetInt("_ZTest", 8);
				bool flag7 = this.cachedSingleMaterialArray == null || this.cachedSingleMaterialArray.Length != 1;
				if (flag7)
				{
					this.cachedSingleMaterialArray = new Material[] { this.myInstancedMaterial };
				}
				this.cachedSingleMaterialArray[0] = this.myInstancedMaterial;
				this.DAtZsfrmedn463iBb9x6JIanO.sharedMaterials = this.cachedSingleMaterialArray;
			}
		}
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x0001712C File Offset: 0x0001532C
	public void DOmk4uF60EkKTKlUquF0xzCpU()
	{
		bool flag = this.Dy0gZ6iQlODpcERkM2RTH1IfP != null;
		if (flag)
		{
			this.DppB0fzXN5LcC63CiB3odb5qW(this.Dy0gZ6iQlODpcERkM2RTH1IfP);
		}
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x0001715C File Offset: 0x0001535C
	public void D4k1u7qUj150ToIfAvqtwjeWZ()
	{
		bool flag = this.originalMaterials != null;
		if (flag)
		{
			this.DAtZsfrmedn463iBb9x6JIanO.sharedMaterials = this.originalMaterials;
		}
		else
		{
			this.DAtZsfrmedn463iBb9x6JIanO.material = this.DLOIdVfauEw0BxeZhRcmjEzZb;
		}
	}

	// Token: 0x04000225 RID: 549
	public static List<Dg7HgPuhdjH1X6wkz4QJsSTzj> DLMXXTHY91pphkSNfe1aeHy3z = new List<Dg7HgPuhdjH1X6wkz4QJsSTzj>();

	// Token: 0x04000226 RID: 550
	private Material DLOIdVfauEw0BxeZhRcmjEzZb;

	// Token: 0x04000227 RID: 551
	private Material Dy0gZ6iQlODpcERkM2RTH1IfP;

	// Token: 0x04000228 RID: 552
	private Renderer DAtZsfrmedn463iBb9x6JIanO;

	// Token: 0x04000229 RID: 553
	private Material[] originalMaterials;

	// Token: 0x0400022A RID: 554
	private Material myInstancedMaterial;

	// Token: 0x0400022B RID: 555
	private Material myInstancedMaterialHidden;

	// Token: 0x0400022C RID: 556
	private int originalMaterialCount = 1;

	// Token: 0x0400022D RID: 557
	private Material[] cachedSingleMaterialArray;

	// Token: 0x0400022E RID: 558
	private Material[] cachedDoubleMaterialArray;
}
