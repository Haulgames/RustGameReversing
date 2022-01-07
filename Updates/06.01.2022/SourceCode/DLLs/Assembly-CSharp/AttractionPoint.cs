using System;
using Il2CppDummyDll;

// Token: 0x020002F4 RID: 756
[Token(Token = "0x2000212")]
public class AttractionPoint : PrefabAttribute
{
	// Token: 0x06001BE2 RID: 7138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001648")]
	[Address(RVA = "0x83D700", Offset = "0x83C500", VA = "0x18083D700", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001649")]
	[Address(RVA = "0x83D760", Offset = "0x83C560", VA = "0x18083D760")]
	public AttractionPoint()
	{
	}

	// Token: 0x040016B4 RID: 5812
	[Token(Token = "0x4001299")]
	[FieldOffset(Offset = "0x98")]
	public string groupName;
}
