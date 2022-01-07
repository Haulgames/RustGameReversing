using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005DF RID: 1503
[Token(Token = "0x2000462")]
public class DeployVolumeOBB : DeployVolume
{
	// Token: 0x060029F4 RID: 10740 RVA: 0x00012390 File Offset: 0x00010590
	[Token(Token = "0x600231E")]
	[Address(RVA = "0xB615C0", Offset = "0xB603C0", VA = "0x180B615C0", Slot = "8")]
	protected override bool Check(Vector3 position, Quaternion rotation, int mask = -1)
	{
		return default(bool);
	}

	// Token: 0x060029F5 RID: 10741 RVA: 0x000123A8 File Offset: 0x000105A8
	[Token(Token = "0x600231F")]
	[Address(RVA = "0xB61990", Offset = "0xB60790", VA = "0x180B61990", Slot = "9")]
	protected override bool Check(Vector3 position, Quaternion rotation, OBB test, int mask = -1)
	{
		return default(bool);
	}

	// Token: 0x060029F6 RID: 10742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002320")]
	[Address(RVA = "0xB61D80", Offset = "0xB60B80", VA = "0x180B61D80")]
	public DeployVolumeOBB()
	{
	}

	// Token: 0x04002543 RID: 9539
	[Token(Token = "0x4001E6C")]
	[FieldOffset(Offset = "0xB0")]
	public Bounds bounds;
}
