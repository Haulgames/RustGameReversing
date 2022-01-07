using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007B1 RID: 1969
[Token(Token = "0x20005B8")]
[Serializable]
public class DungeonBaseFloor
{
	// Token: 0x06003131 RID: 12593 RVA: 0x000150F0 File Offset: 0x000132F0
	[Token(Token = "0x6002987")]
	[Address(RVA = "0x97ED50", Offset = "0x97DB50", VA = "0x18097ED50")]
	public float Distance(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x06003132 RID: 12594 RVA: 0x00015108 File Offset: 0x00013308
	[Token(Token = "0x6002988")]
	[Address(RVA = "0x97EE20", Offset = "0x97DC20", VA = "0x18097EE20")]
	public float SignedDistance(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x06003133 RID: 12595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002989")]
	[Address(RVA = "0x97EEB0", Offset = "0x97DCB0", VA = "0x18097EEB0")]
	public DungeonBaseFloor()
	{
	}

	// Token: 0x04002E01 RID: 11777
	[Token(Token = "0x4002455")]
	[FieldOffset(Offset = "0x10")]
	public List<DungeonBaseLink> Links;
}
