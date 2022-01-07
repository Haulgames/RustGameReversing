using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004F4 RID: 1268
[Token(Token = "0x20003AA")]
public class CardGameSounds : PrefabAttribute
{
	// Token: 0x06002571 RID: 9585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EF6")]
	[Address(RVA = "0x64EB90", Offset = "0x64D990", VA = "0x18064EB90", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x06002572 RID: 9586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EF7")]
	[Address(RVA = "0x64EBF0", Offset = "0x64D9F0", VA = "0x18064EBF0")]
	public void PlaySound(CardGameSounds.SoundType sound, GameObject forGameObject)
	{
	}

	// Token: 0x06002573 RID: 9587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EF8")]
	[Address(RVA = "0x64ED20", Offset = "0x64DB20", VA = "0x18064ED20")]
	public CardGameSounds()
	{
	}

	// Token: 0x04002006 RID: 8198
	[Token(Token = "0x4001A0B")]
	[FieldOffset(Offset = "0x98")]
	public SoundDefinition ChipsSfx;

	// Token: 0x04002007 RID: 8199
	[Token(Token = "0x4001A0C")]
	[FieldOffset(Offset = "0xA0")]
	public SoundDefinition DrawSfx;

	// Token: 0x04002008 RID: 8200
	[Token(Token = "0x4001A0D")]
	[FieldOffset(Offset = "0xA8")]
	public SoundDefinition PlaySfx;

	// Token: 0x04002009 RID: 8201
	[Token(Token = "0x4001A0E")]
	[FieldOffset(Offset = "0xB0")]
	public SoundDefinition ShuffleSfx;

	// Token: 0x0400200A RID: 8202
	[Token(Token = "0x4001A0F")]
	[FieldOffset(Offset = "0xB8")]
	public SoundDefinition WinSfx;

	// Token: 0x0400200B RID: 8203
	[Token(Token = "0x4001A10")]
	[FieldOffset(Offset = "0xC0")]
	public SoundDefinition YourTurnSfx;

	// Token: 0x0400200C RID: 8204
	[Token(Token = "0x4001A11")]
	[FieldOffset(Offset = "0xC8")]
	public SoundDefinition CheckSfx;

	// Token: 0x020004F5 RID: 1269
	[Token(Token = "0x2000B7D")]
	public enum SoundType
	{
		// Token: 0x0400200E RID: 8206
		[Token(Token = "0x4004306")]
		Chips,
		// Token: 0x0400200F RID: 8207
		[Token(Token = "0x4004307")]
		Draw,
		// Token: 0x04002010 RID: 8208
		[Token(Token = "0x4004308")]
		Play,
		// Token: 0x04002011 RID: 8209
		[Token(Token = "0x4004309")]
		Shuffle,
		// Token: 0x04002012 RID: 8210
		[Token(Token = "0x400430A")]
		Win,
		// Token: 0x04002013 RID: 8211
		[Token(Token = "0x400430B")]
		YourTurn,
		// Token: 0x04002014 RID: 8212
		[Token(Token = "0x400430C")]
		Check
	}
}
