using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005DE RID: 1502
[Token(Token = "0x2000461")]
public class DeployVolumeEntityBoundsReverse : DeployVolume
{
	// Token: 0x060029F0 RID: 10736 RVA: 0x00012360 File Offset: 0x00010560
	[Token(Token = "0x600231A")]
	[Address(RVA = "0xB608C0", Offset = "0xB5F6C0", VA = "0x180B608C0", Slot = "8")]
	protected override bool Check(Vector3 position, Quaternion rotation, int mask = -1)
	{
		return default(bool);
	}

	// Token: 0x060029F1 RID: 10737 RVA: 0x00012378 File Offset: 0x00010578
	[Token(Token = "0x600231B")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "9")]
	protected override bool Check(Vector3 position, Quaternion rotation, OBB test, int mask = -1)
	{
		return default(bool);
	}

	// Token: 0x060029F2 RID: 10738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600231C")]
	[Address(RVA = "0xB60830", Offset = "0xB5F630", VA = "0x180B60830", Slot = "6")]
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x060029F3 RID: 10739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600231D")]
	[Address(RVA = "0xB60FA0", Offset = "0xB5FDA0", VA = "0x180B60FA0")]
	public DeployVolumeEntityBoundsReverse()
	{
	}

	// Token: 0x04002541 RID: 9537
	[Token(Token = "0x4001E6A")]
	[FieldOffset(Offset = "0xB0")]
	private Bounds bounds;

	// Token: 0x04002542 RID: 9538
	[Token(Token = "0x4001E6B")]
	[FieldOffset(Offset = "0xC8")]
	private int layer;
}
