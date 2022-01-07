using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005DD RID: 1501
[Token(Token = "0x2000460")]
public class DeployVolumeEntityBounds : DeployVolume
{
	// Token: 0x060029EC RID: 10732 RVA: 0x00012330 File Offset: 0x00010530
	[Token(Token = "0x6002316")]
	[Address(RVA = "0xB61150", Offset = "0xB5FF50", VA = "0x180B61150", Slot = "8")]
	protected override bool Check(Vector3 position, Quaternion rotation, int mask = -1)
	{
		return default(bool);
	}

	// Token: 0x060029ED RID: 10733 RVA: 0x00012348 File Offset: 0x00010548
	[Token(Token = "0x6002317")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "9")]
	protected override bool Check(Vector3 position, Quaternion rotation, OBB obb, int mask = -1)
	{
		return default(bool);
	}

	// Token: 0x060029EE RID: 10734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002318")]
	[Address(RVA = "0xB610D0", Offset = "0xB5FED0", VA = "0x180B610D0", Slot = "6")]
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x060029EF RID: 10735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002319")]
	[Address(RVA = "0xB61490", Offset = "0xB60290", VA = "0x180B61490")]
	public DeployVolumeEntityBounds()
	{
	}

	// Token: 0x04002540 RID: 9536
	[Token(Token = "0x4001E69")]
	[FieldOffset(Offset = "0xB0")]
	private Bounds bounds;
}
