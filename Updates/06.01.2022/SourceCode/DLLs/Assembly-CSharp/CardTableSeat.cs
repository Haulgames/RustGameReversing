using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004F7 RID: 1271
[Token(Token = "0x20003AC")]
public class CardTableSeat : BaseChair
{
	// Token: 0x06002577 RID: 9591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EFC")]
	[Address(RVA = "0x64F3A0", Offset = "0x64E1A0", VA = "0x18064F3A0", Slot = "13")]
	public override void ClientOnEnable()
	{
	}

	// Token: 0x06002578 RID: 9592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EFD")]
	[Address(RVA = "0x64F4B0", Offset = "0x64E2B0", VA = "0x18064F4B0", Slot = "176")]
	protected override void ClientOnPlayerMounted(BasePlayer player)
	{
	}

	// Token: 0x06002579 RID: 9593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EFE")]
	[Address(RVA = "0x64F440", Offset = "0x64E240", VA = "0x18064F440", Slot = "175")]
	protected override void ClientOnPlayerDismounted(BasePlayer player)
	{
	}

	// Token: 0x0600257A RID: 9594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EFF")]
	[Address(RVA = "0x64F980", Offset = "0x64E780", VA = "0x18064F980", Slot = "170")]
	public override void UpdatePlayerModel(BasePlayer player)
	{
	}

	// Token: 0x0600257B RID: 9595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F00")]
	[Address(RVA = "0x64F5C0", Offset = "0x64E3C0", VA = "0x18064F5C0")]
	private void UpdateCardPosition(BasePlayer forPlayer)
	{
	}

	// Token: 0x0600257C RID: 9596 RVA: 0x000108F0 File Offset: 0x0000EAF0
	[Token(Token = "0x6001F01")]
	[Address(RVA = "0x64F5A0", Offset = "0x64E3A0", VA = "0x18064F5A0", Slot = "163")]
	protected override float GetMountedAnimationSpeed()
	{
		return 0f;
	}

	// Token: 0x0600257D RID: 9597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F02")]
	[Address(RVA = "0x616670", Offset = "0x615470", VA = "0x180616670")]
	public CardTableSeat()
	{
	}

	// Token: 0x04002016 RID: 8214
	[Token(Token = "0x4001A13")]
	[FieldOffset(Offset = "0x318")]
	public Transform CardsMesh;

	// Token: 0x04002017 RID: 8215
	[Token(Token = "0x4001A14")]
	[FieldOffset(Offset = "0x320")]
	private CardTable table;

	// Token: 0x04002018 RID: 8216
	[Token(Token = "0x4001A15")]
	[FieldOffset(Offset = "0x328")]
	private Transform boneTarget;

	// Token: 0x04002019 RID: 8217
	[Token(Token = "0x4001A16")]
	[FieldOffset(Offset = "0x330")]
	private bool wasShowingCards;
}
