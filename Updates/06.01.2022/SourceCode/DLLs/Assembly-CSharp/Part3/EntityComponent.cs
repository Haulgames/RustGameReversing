using System;
using Il2CppDummyDll;

// Token: 0x0200049D RID: 1181
[Token(Token = "0x200036B")]
public class EntityComponent<T> : EntityComponentBase where T : BaseEntity
{
	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x06002441 RID: 9281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000286")]
	protected T baseEntity
	{
		[Token(Token = "0x6001DE5")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002442 RID: 9282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DE6")]
	protected void UpdateBaseEntity()
	{
	}

	// Token: 0x06002443 RID: 9283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DE7")]
	protected override BaseEntity GetBaseEntity()
	{
		return null;
	}

	// Token: 0x06002444 RID: 9284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DE8")]
	public EntityComponent()
	{
	}

	// Token: 0x04001E81 RID: 7809
	[Token(Token = "0x40018FE")]
	[FieldOffset(Offset = "0x0")]
	[NonSerialized]
	private T _baseEntity;
}
