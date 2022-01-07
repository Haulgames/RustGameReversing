using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000411 RID: 1041
[Token(Token = "0x20002ED")]
public class EmissionScaledByLight : MonoBehaviour, IClientComponent
{
	// Token: 0x06002196 RID: 8598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B54")]
	[Address(RVA = "0x990700", Offset = "0x98F500", VA = "0x180990700")]
	public void OnEnable()
	{
	}

	// Token: 0x06002197 RID: 8599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B55")]
	[Address(RVA = "0x9908D0", Offset = "0x98F6D0", VA = "0x1809908D0")]
	public void Update()
	{
	}

	// Token: 0x06002198 RID: 8600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B56")]
	[Address(RVA = "0x990B30", Offset = "0x98F930", VA = "0x180990B30")]
	public EmissionScaledByLight()
	{
	}

	// Token: 0x04001C2D RID: 7213
	[Token(Token = "0x40016E0")]
	[FieldOffset(Offset = "0x18")]
	private Color emissionColor;

	// Token: 0x04001C2E RID: 7214
	[Token(Token = "0x40016E1")]
	[FieldOffset(Offset = "0x28")]
	public Renderer[] targetRenderers;

	// Token: 0x04001C2F RID: 7215
	[Token(Token = "0x40016E2")]
	[FieldOffset(Offset = "0x30")]
	public int materialIndex;

	// Token: 0x04001C30 RID: 7216
	[Token(Token = "0x40016E3")]
	[FieldOffset(Offset = "0x0")]
	private static MaterialPropertyBlock block;

	// Token: 0x04001C31 RID: 7217
	[Token(Token = "0x40016E4")]
	[FieldOffset(Offset = "0x38")]
	public Light lightToFollow;

	// Token: 0x04001C32 RID: 7218
	[Token(Token = "0x40016E5")]
	[FieldOffset(Offset = "0x40")]
	public float maxEmissionValue;

	// Token: 0x04001C33 RID: 7219
	[Token(Token = "0x40016E6")]
	[FieldOffset(Offset = "0x44")]
	private int index;
}
