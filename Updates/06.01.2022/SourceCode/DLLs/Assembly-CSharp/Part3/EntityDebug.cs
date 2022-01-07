using System;
using System.Diagnostics;
using Il2CppDummyDll;

// Token: 0x0200049F RID: 1183
[Token(Token = "0x200036D")]
public class EntityDebug : EntityComponent<BaseEntity>
{
	// Token: 0x0600244A RID: 9290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DEE")]
	[Address(RVA = "0x84F4B0", Offset = "0x84E2B0", VA = "0x18084F4B0")]
	private void Update()
	{
	}

	// Token: 0x0600244B RID: 9291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DEF")]
	[Address(RVA = "0x84F660", Offset = "0x84E460", VA = "0x18084F660")]
	public EntityDebug()
	{
	}

	// Token: 0x04001E82 RID: 7810
	[Token(Token = "0x40018FF")]
	[FieldOffset(Offset = "0x20")]
	internal Stopwatch stopwatch;
}
