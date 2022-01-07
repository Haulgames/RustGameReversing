using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200033E RID: 830
[Token(Token = "0x2000250")]
public class BoneDictionary
{
	// Token: 0x17000200 RID: 512
	// (get) Token: 0x06001CEE RID: 7406 RVA: 0x0000E190 File Offset: 0x0000C390
	[Token(Token = "0x170001E2")]
	public int Count
	{
		[Token(Token = "0x6001747")]
		[Address(RVA = "0x461090", Offset = "0x45FE90", VA = "0x180461090")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001CEF RID: 7407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001748")]
	[Address(RVA = "0x460C30", Offset = "0x45FA30", VA = "0x180460C30")]
	public BoneDictionary(Transform rootBone)
	{
	}

	// Token: 0x06001CF0 RID: 7408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001749")]
	[Address(RVA = "0x460EF0", Offset = "0x45FCF0", VA = "0x180460EF0")]
	public BoneDictionary(Transform rootBone, Transform[] boneTransforms, string[] boneNames)
	{
	}

	// Token: 0x06001CF1 RID: 7409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600174A")]
	[Address(RVA = "0x460820", Offset = "0x45F620", VA = "0x180460820")]
	private void BuildBoneDictionary()
	{
	}

	// Token: 0x06001CF2 RID: 7410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174B")]
	[Address(RVA = "0x460B80", Offset = "0x45F980", VA = "0x180460B80")]
	public Transform FindBone(string name, bool defaultToRoot = true)
	{
		return null;
	}

	// Token: 0x06001CF3 RID: 7411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174C")]
	[Address(RVA = "0x460AD0", Offset = "0x45F8D0", VA = "0x180460AD0")]
	public Transform FindBone(uint hash, bool defaultToRoot = true)
	{
		return null;
	}

	// Token: 0x06001CF4 RID: 7412 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
	[Token(Token = "0x600174D")]
	[Address(RVA = "0x460A20", Offset = "0x45F820", VA = "0x180460A20")]
	public uint FindBoneID(Transform transform)
	{
		return 0U;
	}

	// Token: 0x0400180E RID: 6158
	[Token(Token = "0x40013AA")]
	[FieldOffset(Offset = "0x10")]
	public Transform transform;

	// Token: 0x0400180F RID: 6159
	[Token(Token = "0x40013AB")]
	[FieldOffset(Offset = "0x18")]
	public Transform[] transforms;

	// Token: 0x04001810 RID: 6160
	[Token(Token = "0x40013AC")]
	[FieldOffset(Offset = "0x20")]
	public string[] names;

	// Token: 0x04001811 RID: 6161
	[Token(Token = "0x40013AD")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, Transform> nameDict;

	// Token: 0x04001812 RID: 6162
	[Token(Token = "0x40013AE")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<uint, Transform> hashDict;

	// Token: 0x04001813 RID: 6163
	[Token(Token = "0x40013AF")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<Transform, uint> transformDict;
}
