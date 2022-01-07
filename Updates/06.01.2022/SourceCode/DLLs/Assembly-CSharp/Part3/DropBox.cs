using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200019E RID: 414
[Token(Token = "0x20000FB")]
public class DropBox : Mailbox
{
	// Token: 0x0600157F RID: 5503 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
	[Token(Token = "0x6001054")]
	[Address(RVA = "0x97CF80", Offset = "0x97BD80", VA = "0x18097CF80", Slot = "152")]
	public override bool PlayerIsOwner(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06001580 RID: 5504 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
	[Token(Token = "0x6001055")]
	[Address(RVA = "0x97CB60", Offset = "0x97B960", VA = "0x18097CB60")]
	public bool PlayerBehind(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06001581 RID: 5505 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
	[Token(Token = "0x6001056")]
	[Address(RVA = "0x97CDC0", Offset = "0x97BBC0", VA = "0x18097CDC0")]
	public bool PlayerInfront(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06001582 RID: 5506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001057")]
	[Address(RVA = "0x97CF90", Offset = "0x97BD90", VA = "0x18097CF90")]
	public DropBox()
	{
	}

	// Token: 0x04000F2D RID: 3885
	[Token(Token = "0x4000C22")]
	[FieldOffset(Offset = "0x440")]
	public Transform EyePoint;
}
