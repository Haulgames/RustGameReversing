using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A7 RID: 679
[Token(Token = "0x20001E0")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xA5700", Offset = "0xA4B00")]
public class AmbienceDefinitionList : ScriptableObject
{
	// Token: 0x060019DA RID: 6618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001471")]
	[Address(RVA = "0x484650", Offset = "0x483450", VA = "0x180484650")]
	public AmbienceDefinitionList()
	{
	}

	// Token: 0x04001466 RID: 5222
	[Token(Token = "0x40010CE")]
	[FieldOffset(Offset = "0x18")]
	public List<AmbienceDefinition> defs;
}
