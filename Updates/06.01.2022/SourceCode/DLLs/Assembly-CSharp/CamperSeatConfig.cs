using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200058D RID: 1421
[Token(Token = "0x2000425")]
public class CamperSeatConfig : MonoBehaviour
{
	// Token: 0x0600288A RID: 10378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021EE")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public CamperSeatConfig()
	{
	}

	// Token: 0x040023D9 RID: 9177
	[Token(Token = "0x4001D57")]
	[FieldOffset(Offset = "0x18")]
	public Transform[] SeatPositions;

	// Token: 0x040023DA RID: 9178
	[Token(Token = "0x4001D58")]
	[FieldOffset(Offset = "0x20")]
	public Transform StovePosition;

	// Token: 0x040023DB RID: 9179
	[Token(Token = "0x4001D59")]
	[FieldOffset(Offset = "0x28")]
	public Transform StoragePosition;
}
