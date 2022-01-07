using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005D8 RID: 1496
[Token(Token = "0x200045C")]
public class CullingVolume : MonoBehaviour, IClientComponent
{
	// Token: 0x060029CE RID: 10702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022F8")]
	[Address(RVA = "0x6DB010", Offset = "0x6D9E10", VA = "0x1806DB010")]
	protected void Awake()
	{
	}

	// Token: 0x060029CF RID: 10703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022F9")]
	[Address(RVA = "0x6DB8E0", Offset = "0x6DA6E0", VA = "0x1806DB8E0")]
	protected void Start()
	{
	}

	// Token: 0x060029D0 RID: 10704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022FA")]
	[Address(RVA = "0x6DB8F0", Offset = "0x6DA6F0", VA = "0x1806DB8F0")]
	private void UpdateBounds()
	{
	}

	// Token: 0x060029D1 RID: 10705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022FB")]
	[Address(RVA = "0x6DBC80", Offset = "0x6DAA80", VA = "0x1806DBC80")]
	private void UpdateTrigger()
	{
	}

	// Token: 0x060029D2 RID: 10706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022FC")]
	[Address(RVA = "0x6DB940", Offset = "0x6DA740", VA = "0x1806DB940")]
	private void UpdateComponents()
	{
	}

	// Token: 0x060029D3 RID: 10707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022FD")]
	[Address(RVA = "0x6DBB10", Offset = "0x6DA910", VA = "0x1806DBB10")]
	private void UpdateLights()
	{
	}

	// Token: 0x060029D4 RID: 10708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022FE")]
	[Address(RVA = "0x6DB530", Offset = "0x6DA330", VA = "0x1806DB530")]
	protected void OnDrawGizmosSelected()
	{
	}

	// Token: 0x060029D5 RID: 10709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022FF")]
	[Address(RVA = "0x6DB3D0", Offset = "0x6DA1D0", VA = "0x1806DB3D0")]
	public void MarkSeen(bool recursive = true)
	{
	}

	// Token: 0x060029D6 RID: 10710 RVA: 0x000121F8 File Offset: 0x000103F8
	[Token(Token = "0x6002300")]
	[Address(RVA = "0x6DBDB0", Offset = "0x6DABB0", VA = "0x1806DBDB0")]
	public bool UpdateVisible(bool recursive = true)
	{
		return default(bool);
	}

	// Token: 0x060029D7 RID: 10711 RVA: 0x00012210 File Offset: 0x00010410
	[Token(Token = "0x6002301")]
	[Address(RVA = "0x6DB3A0", Offset = "0x6DA1A0", VA = "0x1806DB3A0")]
	private bool IsVisible()
	{
		return default(bool);
	}

	// Token: 0x060029D8 RID: 10712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002302")]
	[Address(RVA = "0x6DB6B0", Offset = "0x6DA4B0", VA = "0x1806DB6B0")]
	private void SetVisible(bool state)
	{
	}

	// Token: 0x060029D9 RID: 10713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002303")]
	[Address(RVA = "0x6DBF10", Offset = "0x6DAD10", VA = "0x1806DBF10")]
	public CullingVolume()
	{
	}

	// Token: 0x0400252C RID: 9516
	[Token(Token = "0x4001E58")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x75ED0", Offset = "0x752D0")]
	public GameObject OccludeeRoot;

	// Token: 0x0400252D RID: 9517
	[Token(Token = "0x4001E59")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x76000", Offset = "0x75400")]
	public bool Invert;

	// Token: 0x0400252E RID: 9518
	[Token(Token = "0x4001E5A")]
	[FieldOffset(Offset = "0x21")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x760F0", Offset = "0x754F0")]
	public bool Portal;

	// Token: 0x0400252F RID: 9519
	[Token(Token = "0x4001E5B")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x762E0", Offset = "0x756E0")]
	public List<CullingVolume> Connections;

	// Token: 0x04002530 RID: 9520
	[Token(Token = "0x4001E5C")]
	[FieldOffset(Offset = "0x30")]
	private Transform root;

	// Token: 0x04002531 RID: 9521
	[Token(Token = "0x4001E5D")]
	[FieldOffset(Offset = "0x38")]
	private Bounds bounds;

	// Token: 0x04002532 RID: 9522
	[Token(Token = "0x4001E5E")]
	[FieldOffset(Offset = "0x50")]
	private List<LODComponent> components;

	// Token: 0x04002533 RID: 9523
	[Token(Token = "0x4001E5F")]
	[FieldOffset(Offset = "0x58")]
	private List<LightOccludee> lights;

	// Token: 0x04002534 RID: 9524
	[Token(Token = "0x4001E60")]
	[FieldOffset(Offset = "0x60")]
	private float lastSeen;
}
