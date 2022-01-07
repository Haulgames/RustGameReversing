using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x02000341 RID: 833
[Token(Token = "0x2000253")]
public class ClimateOverlay : MonoBehaviour
{
	// Token: 0x06001CF9 RID: 7417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001752")]
	[Address(RVA = "0x49AE00", Offset = "0x499C00", VA = "0x18049AE00")]
	private void Awake()
	{
	}

	// Token: 0x06001CFA RID: 7418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001753")]
	[Address(RVA = "0x49B0C0", Offset = "0x499EC0", VA = "0x18049B0C0")]
	private void UpdateBlendTargets()
	{
	}

	// Token: 0x06001CFB RID: 7419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001754")]
	[Address(RVA = "0x49B4D0", Offset = "0x49A2D0", VA = "0x18049B4D0")]
	private void Update()
	{
	}

	// Token: 0x06001CFC RID: 7420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001755")]
	[Address(RVA = "0x49B760", Offset = "0x49A560", VA = "0x18049B760")]
	public ClimateOverlay()
	{
	}

	// Token: 0x04001816 RID: 6166
	[Token(Token = "0x40013B2")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6CE90", Offset = "0x6C290")]
	public float blendingSpeed;

	// Token: 0x04001817 RID: 6167
	[Token(Token = "0x40013B3")]
	[FieldOffset(Offset = "0x20")]
	public PostProcessVolume[] biomeVolumes;

	// Token: 0x04001818 RID: 6168
	[Token(Token = "0x40013B4")]
	[FieldOffset(Offset = "0x28")]
	private float cycleBlendTime;

	// Token: 0x04001819 RID: 6169
	[Token(Token = "0x40013B5")]
	[FieldOffset(Offset = "0x2C")]
	private bool isBlending;

	// Token: 0x0400181A RID: 6170
	[Token(Token = "0x40013B6")]
	[FieldOffset(Offset = "0x30")]
	private float[] weights;

	// Token: 0x0400181B RID: 6171
	[Token(Token = "0x40013B7")]
	[FieldOffset(Offset = "0x38")]
	private float[] srcWeights;

	// Token: 0x0400181C RID: 6172
	[Token(Token = "0x40013B8")]
	[FieldOffset(Offset = "0x40")]
	private float[] dstWeights;
}
