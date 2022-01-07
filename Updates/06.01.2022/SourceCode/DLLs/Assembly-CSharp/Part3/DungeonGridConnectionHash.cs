using System;
using Il2CppDummyDll;

// Token: 0x020007BB RID: 1979
[Token(Token = "0x20005C2")]
public struct DungeonGridConnectionHash
{
	// Token: 0x170003EE RID: 1006
	// (get) Token: 0x06003140 RID: 12608 RVA: 0x00015150 File Offset: 0x00013350
	[Token(Token = "0x17000385")]
	public int Value
	{
		[Token(Token = "0x6002996")]
		[Address(RVA = "0xF5BA0", Offset = "0xF4FA0", VA = "0x1800F5BA0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x04002E2C RID: 11820
	[Token(Token = "0x4002480")]
	[FieldOffset(Offset = "0x0")]
	public bool North;

	// Token: 0x04002E2D RID: 11821
	[Token(Token = "0x4002481")]
	[FieldOffset(Offset = "0x1")]
	public bool South;

	// Token: 0x04002E2E RID: 11822
	[Token(Token = "0x4002482")]
	[FieldOffset(Offset = "0x2")]
	public bool West;

	// Token: 0x04002E2F RID: 11823
	[Token(Token = "0x4002483")]
	[FieldOffset(Offset = "0x3")]
	public bool East;
}
