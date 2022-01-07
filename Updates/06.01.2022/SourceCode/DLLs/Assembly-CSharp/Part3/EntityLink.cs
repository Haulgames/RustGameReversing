using System;
using System.Collections.Generic;
using Facepunch;
using Il2CppDummyDll;

// Token: 0x020004C6 RID: 1222
[Token(Token = "0x200038D")]
public class EntityLink : Pool.IPooled
{
	// Token: 0x170002C6 RID: 710
	// (get) Token: 0x060024B2 RID: 9394 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000291")]
	public string name
	{
		[Token(Token = "0x6001E49")]
		[Address(RVA = "0x851300", Offset = "0x850100", VA = "0x180851300")]
		get
		{
			return null;
		}
	}

	// Token: 0x060024B3 RID: 9395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E4A")]
	[Address(RVA = "0x851220", Offset = "0x850020", VA = "0x180851220")]
	public void Setup(BaseEntity owner, Socket_Base socket)
	{
	}

	// Token: 0x060024B4 RID: 9396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E4B")]
	[Address(RVA = "0x8510B0", Offset = "0x84FEB0", VA = "0x1808510B0", Slot = "4")]
	public void EnterPool()
	{
	}

	// Token: 0x060024B5 RID: 9397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E4C")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
	public void LeavePool()
	{
	}

	// Token: 0x060024B6 RID: 9398 RVA: 0x000103F8 File Offset: 0x0000E5F8
	[Token(Token = "0x6001E4D")]
	[Address(RVA = "0x851050", Offset = "0x84FE50", VA = "0x180851050")]
	public bool Contains(EntityLink entity)
	{
		return default(bool);
	}

	// Token: 0x060024B7 RID: 9399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E4E")]
	[Address(RVA = "0x850CC0", Offset = "0x84FAC0", VA = "0x180850CC0")]
	public void Add(EntityLink entity)
	{
	}

	// Token: 0x060024B8 RID: 9400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E4F")]
	[Address(RVA = "0x8511C0", Offset = "0x84FFC0", VA = "0x1808511C0")]
	public void Remove(EntityLink entity)
	{
	}

	// Token: 0x060024B9 RID: 9401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E50")]
	[Address(RVA = "0x850F60", Offset = "0x84FD60", VA = "0x180850F60")]
	public void Clear()
	{
	}

	// Token: 0x060024BA RID: 9402 RVA: 0x00010410 File Offset: 0x0000E610
	[Token(Token = "0x6001E51")]
	[Address(RVA = "0x8510F0", Offset = "0x84FEF0", VA = "0x1808510F0")]
	public bool IsEmpty()
	{
		return default(bool);
	}

	// Token: 0x060024BB RID: 9403 RVA: 0x00010428 File Offset: 0x0000E628
	[Token(Token = "0x6001E52")]
	[Address(RVA = "0x851170", Offset = "0x84FF70", VA = "0x180851170")]
	public bool IsOccupied()
	{
		return default(bool);
	}

	// Token: 0x060024BC RID: 9404 RVA: 0x00010440 File Offset: 0x0000E640
	[Token(Token = "0x6001E53")]
	[Address(RVA = "0x851150", Offset = "0x84FF50", VA = "0x180851150")]
	public bool IsMale()
	{
		return default(bool);
	}

	// Token: 0x060024BD RID: 9405 RVA: 0x00010458 File Offset: 0x0000E658
	[Token(Token = "0x6001E54")]
	[Address(RVA = "0x851130", Offset = "0x84FF30", VA = "0x180851130")]
	public bool IsFemale()
	{
		return default(bool);
	}

	// Token: 0x060024BE RID: 9406 RVA: 0x00010470 File Offset: 0x0000E670
	[Token(Token = "0x6001E55")]
	[Address(RVA = "0x850D20", Offset = "0x84FB20", VA = "0x180850D20")]
	public bool CanConnect(EntityLink link)
	{
		return default(bool);
	}

	// Token: 0x060024BF RID: 9407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E56")]
	[Address(RVA = "0x851280", Offset = "0x850080", VA = "0x180851280")]
	public EntityLink()
	{
	}

	// Token: 0x04001EF4 RID: 7924
	[Token(Token = "0x400194D")]
	[FieldOffset(Offset = "0x10")]
	public BaseEntity owner;

	// Token: 0x04001EF5 RID: 7925
	[Token(Token = "0x400194E")]
	[FieldOffset(Offset = "0x18")]
	public Socket_Base socket;

	// Token: 0x04001EF6 RID: 7926
	[Token(Token = "0x400194F")]
	[FieldOffset(Offset = "0x20")]
	public List<EntityLink> connections;

	// Token: 0x04001EF7 RID: 7927
	[Token(Token = "0x4001950")]
	[FieldOffset(Offset = "0x28")]
	public int capacity;
}
