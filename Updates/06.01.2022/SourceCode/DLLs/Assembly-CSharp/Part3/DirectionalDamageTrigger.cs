using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rust;

// Token: 0x020003D4 RID: 980
[Token(Token = "0x20002BD")]
public class DirectionalDamageTrigger : TriggerBase
{
	// Token: 0x060020B4 RID: 8372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8C")]
	[Address(RVA = "0xB72FF0", Offset = "0xB71DF0", VA = "0x180B72FF0")]
	public DirectionalDamageTrigger()
	{
	}

	// Token: 0x04001B7D RID: 7037
	[Token(Token = "0x4001661")]
	[FieldOffset(Offset = "0x30")]
	public float repeatRate;

	// Token: 0x04001B7E RID: 7038
	[Token(Token = "0x4001662")]
	[FieldOffset(Offset = "0x38")]
	public List<DamageTypeEntry> damageType;

	// Token: 0x04001B7F RID: 7039
	[Token(Token = "0x4001663")]
	[FieldOffset(Offset = "0x40")]
	public GameObjectRef attackEffect;
}
