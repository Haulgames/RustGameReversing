using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000372 RID: 882
[Token(Token = "0x2000275")]
public class DecalScale : DecalComponent
{
	// Token: 0x06001E01 RID: 7681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001836")]
	[Address(RVA = "0x8BC060", Offset = "0x8BAE60", VA = "0x1808BC060", Slot = "8")]
	public override void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale)
	{
	}

	// Token: 0x06001E02 RID: 7682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001837")]
	[Address(RVA = "0x8BC0B0", Offset = "0x8BAEB0", VA = "0x1808BC0B0")]
	public DecalScale()
	{
	}

	// Token: 0x040018FE RID: 6398
	[Token(Token = "0x4001452")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "MinMaxAttribute", RVA = "0xB2BD0", Offset = "0xB1FD0")]
	public MinMax range;
}
