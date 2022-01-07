using System;
using Il2CppDummyDll;

// Token: 0x020004A2 RID: 1186
[Token(Token = "0x200036F")]
public class EntityFlag_TOD : EntityComponent<BaseEntity>
{
	// Token: 0x0600244F RID: 9295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DF3")]
	[Address(RVA = "0x84F900", Offset = "0x84E700", VA = "0x18084F900")]
	public EntityFlag_TOD()
	{
	}

	// Token: 0x04001E91 RID: 7825
	[Token(Token = "0x4001909")]
	[FieldOffset(Offset = "0x20")]
	public BaseEntity.Flags desiredFlag;

	// Token: 0x04001E92 RID: 7826
	[Token(Token = "0x400190A")]
	[FieldOffset(Offset = "0x24")]
	public bool onAtNight;
}
