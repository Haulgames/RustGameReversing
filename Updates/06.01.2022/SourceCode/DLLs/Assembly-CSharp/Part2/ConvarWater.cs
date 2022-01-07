using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B40 RID: 2880
[Token(Token = "0x200080A")]
public class ConvarWater : MonoBehaviour
{
	// Token: 0x06004307 RID: 17159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600388F")]
	[Address(RVA = "0x6D1D50", Offset = "0x6D0B50", VA = "0x1806D1D50")]
	private void OnEnable()
	{
	}

	// Token: 0x06004308 RID: 17160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003890")]
	[Address(RVA = "0x6D1C90", Offset = "0x6D0A90", VA = "0x1806D1C90")]
	private void OnDisable()
	{
	}

	// Token: 0x06004309 RID: 17161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003891")]
	[Address(RVA = "0x6D1C30", Offset = "0x6D0A30", VA = "0x1806D1C30")]
	private void OnConvarChanged(ConsoleSystem.Command cmd)
	{
	}

	// Token: 0x0600430A RID: 17162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003892")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public ConvarWater()
	{
	}

	// Token: 0x0400402E RID: 16430
	[Token(Token = "0x400317B")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74B00", Offset = "0x73F00")]
	public WaterSystem water;

	// Token: 0x0400402F RID: 16431
	[Token(Token = "0x400317C")]
	[FieldOffset(Offset = "0x20")]
	internal ConsoleSystem.Command water_quality;
}
