using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002AE RID: 686
[Token(Token = "0x20001E5")]
public class AmbienceZone : TriggerBase, IClientComponentEx
{
	// Token: 0x06001A21 RID: 6689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B5")]
	[Address(RVA = "0x829940", Offset = "0x828740", VA = "0x180829940")]
	private void Awake()
	{
	}

	// Token: 0x06001A22 RID: 6690 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014B6")]
	[Address(RVA = "0x829960", Offset = "0x828760", VA = "0x180829960", Slot = "6")]
	internal override GameObject InterestedInObject(GameObject obj)
	{
		return null;
	}

	// Token: 0x06001A23 RID: 6691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B7")]
	[Address(RVA = "0x829AC0", Offset = "0x8288C0", VA = "0x180829AC0", Slot = "8")]
	internal override void OnEntityEnter(BaseEntity ent)
	{
	}

	// Token: 0x06001A24 RID: 6692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B8")]
	[Address(RVA = "0x829B70", Offset = "0x828970", VA = "0x180829B70", Slot = "9")]
	internal override void OnEntityLeave(BaseEntity ent)
	{
	}

	// Token: 0x06001A25 RID: 6693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B9")]
	[Address(RVA = "0x829C20", Offset = "0x828A20", VA = "0x180829C20", Slot = "16")]
	public virtual void PreClientComponentCull(IPrefabProcessor p)
	{
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014BA")]
	[Address(RVA = "0x829D60", Offset = "0x828B60", VA = "0x180829D60")]
	public AmbienceZone()
	{
	}

	// Token: 0x040014A0 RID: 5280
	[Token(Token = "0x40010FF")]
	[FieldOffset(Offset = "0x30")]
	public AmbienceDefinitionList baseAmbience;

	// Token: 0x040014A1 RID: 5281
	[Token(Token = "0x4001100")]
	[FieldOffset(Offset = "0x38")]
	public AmbienceDefinitionList stings;

	// Token: 0x040014A2 RID: 5282
	[Token(Token = "0x4001101")]
	[FieldOffset(Offset = "0x40")]
	public float priority;

	// Token: 0x040014A3 RID: 5283
	[Token(Token = "0x4001102")]
	[FieldOffset(Offset = "0x44")]
	public bool overrideCrossfadeTime;

	// Token: 0x040014A4 RID: 5284
	[Token(Token = "0x4001103")]
	[FieldOffset(Offset = "0x48")]
	public float crossfadeTime;
}
