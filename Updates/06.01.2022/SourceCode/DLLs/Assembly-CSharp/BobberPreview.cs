using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200024F RID: 591
[Token(Token = "0x2000193")]
public class BobberPreview : MonoBehaviour
{
	// Token: 0x0600189B RID: 6299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001341")]
	[Address(RVA = "0x4607F0", Offset = "0x45F5F0", VA = "0x1804607F0")]
	public void SetState(bool state)
	{
	}

	// Token: 0x0600189C RID: 6300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001342")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public BobberPreview()
	{
	}

	// Token: 0x040012E2 RID: 4834
	[Token(Token = "0x4000F6E")]
	[FieldOffset(Offset = "0x18")]
	public Material ValidMaterial;

	// Token: 0x040012E3 RID: 4835
	[Token(Token = "0x4000F6F")]
	[FieldOffset(Offset = "0x20")]
	public Material InvalidMaterial;

	// Token: 0x040012E4 RID: 4836
	[Token(Token = "0x4000F70")]
	[FieldOffset(Offset = "0x28")]
	public MeshRenderer TargetRenderer;
}
