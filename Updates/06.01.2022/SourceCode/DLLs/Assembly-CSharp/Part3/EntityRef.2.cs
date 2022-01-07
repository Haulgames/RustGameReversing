using System;
using Il2CppDummyDll;

// Token: 0x020004C9 RID: 1225
[Token(Token = "0x2000390")]
public struct EntityRef<T> where T : BaseEntity
{
	// Token: 0x060024C9 RID: 9417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E60")]
	public EntityRef(uint uid)
	{
	}

	// Token: 0x170002C8 RID: 712
	// (get) Token: 0x060024CA RID: 9418 RVA: 0x000104D0 File Offset: 0x0000E6D0
	[Token(Token = "0x17000293")]
	public bool IsSet
	{
		[Token(Token = "0x6001E61")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060024CB RID: 9419 RVA: 0x000104E8 File Offset: 0x0000E6E8
	[Token(Token = "0x6001E62")]
	public bool IsValid(bool serverside)
	{
		return default(bool);
	}

	// Token: 0x060024CC RID: 9420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E63")]
	public void Set(T entity)
	{
	}

	// Token: 0x060024CD RID: 9421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E64")]
	public T Get(bool serverside)
	{
		return null;
	}

	// Token: 0x060024CE RID: 9422 RVA: 0x00010500 File Offset: 0x0000E700
	[Token(Token = "0x6001E65")]
	public bool TryGet(bool serverside, out T entity)
	{
		return default(bool);
	}

	// Token: 0x170002C9 RID: 713
	// (get) Token: 0x060024CF RID: 9423 RVA: 0x00010518 File Offset: 0x0000E718
	// (set) Token: 0x060024D0 RID: 9424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000294")]
	public uint uid
	{
		[Token(Token = "0x6001E66")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6001E67")]
		set
		{
		}
	}

	// Token: 0x04001EFA RID: 7930
	[Token(Token = "0x4001953")]
	[FieldOffset(Offset = "0x0")]
	private EntityRef entityRef;
}
