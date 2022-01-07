using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005A4 RID: 1444
[Token(Token = "0x2000436")]
public class DeployGuide : BaseMonoBehaviour
{
	// Token: 0x060028EC RID: 10476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600224D")]
	[Address(RVA = "0xB5F480", Offset = "0xB5E280", VA = "0x180B5F480")]
	public static void HideFor(float seconds)
	{
	}

	// Token: 0x060028ED RID: 10477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600224E")]
	[Address(RVA = "0xB5FEE0", Offset = "0xB5ECE0", VA = "0x180B5FEE0")]
	private void UnHide()
	{
	}

	// Token: 0x060028EE RID: 10478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600224F")]
	[Address(RVA = "0xB5FE50", Offset = "0xB5EC50", VA = "0x180B5FE50")]
	public static void Start(Deployable deployable)
	{
	}

	// Token: 0x060028EF RID: 10479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002250")]
	[Address(RVA = "0xB5F3A0", Offset = "0xB5E1A0", VA = "0x180B5F3A0")]
	public static void End()
	{
	}

	// Token: 0x060028F0 RID: 10480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002251")]
	[Address(RVA = "0xB5F570", Offset = "0xB5E370", VA = "0x180B5F570")]
	public static void Place(Vector3 pos, [Optional] Quaternion rot)
	{
	}

	// Token: 0x060028F1 RID: 10481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002252")]
	[Address(RVA = "0xB5F210", Offset = "0xB5E010", VA = "0x180B5F210")]
	public static DeployGuide Create(Deployable source)
	{
		return null;
	}

	// Token: 0x060028F2 RID: 10482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002253")]
	[Address(RVA = "0xB5FD20", Offset = "0xB5EB20", VA = "0x180B5FD20")]
	public void Setup(Deployable source)
	{
	}

	// Token: 0x060028F3 RID: 10483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002254")]
	[Address(RVA = "0xB5F970", Offset = "0xB5E770", VA = "0x180B5F970")]
	public void SetGood()
	{
	}

	// Token: 0x060028F4 RID: 10484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002255")]
	[Address(RVA = "0xB5F670", Offset = "0xB5E470", VA = "0x180B5F670")]
	public void SetBad()
	{
	}

	// Token: 0x060028F5 RID: 10485 RVA: 0x00011D78 File Offset: 0x0000FF78
	[Token(Token = "0x6002256")]
	[Address(RVA = "0xB5FEF0", Offset = "0xB5ECF0", VA = "0x180B5FEF0")]
	public static bool Update()
	{
		return default(bool);
	}

	// Token: 0x060028F6 RID: 10486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002257")]
	[Address(RVA = "0xB5FC70", Offset = "0xB5EA70", VA = "0x180B5FC70")]
	public static void SetValid(bool valid)
	{
	}

	// Token: 0x060028F7 RID: 10487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002258")]
	[Address(RVA = "0x46B5C0", Offset = "0x46A3C0", VA = "0x18046B5C0")]
	public DeployGuide()
	{
	}

	// Token: 0x04002483 RID: 9347
	[Token(Token = "0x4001DE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DeployGuide current;

	// Token: 0x04002484 RID: 9348
	[Token(Token = "0x4001DE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool hidden;

	// Token: 0x04002485 RID: 9349
	[Token(Token = "0x4001DE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[NonSerialized]
	public bool isGoodPlacement;

	// Token: 0x04002486 RID: 9350
	[Token(Token = "0x4001DE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[NonSerialized]
	private MeshRenderer meshRenderer;

	// Token: 0x04002487 RID: 9351
	[Token(Token = "0x4001DE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[NonSerialized]
	private MeshFilter meshFilter;
}
