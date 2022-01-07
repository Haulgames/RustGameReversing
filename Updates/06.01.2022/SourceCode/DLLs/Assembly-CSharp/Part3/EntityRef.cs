using System;
using Il2CppDummyDll;

// Token: 0x020004C8 RID: 1224
[Token(Token = "0x200038F")]
public struct EntityRef
{
	// Token: 0x060024C3 RID: 9411 RVA: 0x00010488 File Offset: 0x0000E688
	[Token(Token = "0x6001E5A")]
	[Address(RVA = "0xF4010", Offset = "0xF3410", VA = "0x1800F4010")]
	public bool IsSet()
	{
		return default(bool);
	}

	// Token: 0x060024C4 RID: 9412 RVA: 0x000104A0 File Offset: 0x0000E6A0
	[Token(Token = "0x6001E5B")]
	[Address(RVA = "0xF4020", Offset = "0xF3420", VA = "0x1800F4020")]
	public bool IsValid(bool serverside)
	{
		return default(bool);
	}

	// Token: 0x060024C5 RID: 9413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E5C")]
	[Address(RVA = "0xF4040", Offset = "0xF3440", VA = "0x1800F4040")]
	public void Set(BaseEntity ent)
	{
	}

	// Token: 0x060024C6 RID: 9414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E5D")]
	[Address(RVA = "0xF4000", Offset = "0xF3400", VA = "0x1800F4000")]
	public BaseEntity Get(bool serverside)
	{
		return null;
	}

	// Token: 0x170002C7 RID: 711
	// (get) Token: 0x060024C7 RID: 9415 RVA: 0x000104B8 File Offset: 0x0000E6B8
	// (set) Token: 0x060024C8 RID: 9416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000292")]
	public uint uid
	{
		[Token(Token = "0x6001E5E")]
		[Address(RVA = "0xF4090", Offset = "0xF3490", VA = "0x1800F4090")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6001E5F")]
		[Address(RVA = "0xF40D0", Offset = "0xF34D0", VA = "0x1800F40D0")]
		set
		{
		}
	}

	// Token: 0x04001EF8 RID: 7928
	[Token(Token = "0x4001951")]
	[FieldOffset(Offset = "0x0")]
	internal BaseEntity ent_cached;

	// Token: 0x04001EF9 RID: 7929
	[Token(Token = "0x4001952")]
	[FieldOffset(Offset = "0x8")]
	internal uint id_cached;
}
