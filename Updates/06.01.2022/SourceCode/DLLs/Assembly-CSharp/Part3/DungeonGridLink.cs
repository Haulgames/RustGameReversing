using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007BD RID: 1981
[Token(Token = "0x20005C4")]
public class DungeonGridLink : MonoBehaviour
{
	// Token: 0x06003148 RID: 12616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600299E")]
	[Address(RVA = "0x9806C0", Offset = "0x97F4C0", VA = "0x1809806C0")]
	protected void Start()
	{
	}

	// Token: 0x06003149 RID: 12617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600299F")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public DungeonGridLink()
	{
	}

	// Token: 0x04002E34 RID: 11828
	[Token(Token = "0x4002488")]
	[FieldOffset(Offset = "0x18")]
	public Transform UpSocket;

	// Token: 0x04002E35 RID: 11829
	[Token(Token = "0x4002489")]
	[FieldOffset(Offset = "0x20")]
	public Transform DownSocket;

	// Token: 0x04002E36 RID: 11830
	[Token(Token = "0x400248A")]
	[FieldOffset(Offset = "0x28")]
	public DungeonGridLinkType UpType;

	// Token: 0x04002E37 RID: 11831
	[Token(Token = "0x400248B")]
	[FieldOffset(Offset = "0x2C")]
	public DungeonGridLinkType DownType;

	// Token: 0x04002E38 RID: 11832
	[Token(Token = "0x400248C")]
	[FieldOffset(Offset = "0x30")]
	public int Priority;

	// Token: 0x04002E39 RID: 11833
	[Token(Token = "0x400248D")]
	[FieldOffset(Offset = "0x34")]
	public int Rotation;
}
