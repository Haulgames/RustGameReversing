using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005D7 RID: 1495
[Token(Token = "0x200045B")]
public class CullingManager : SingletonComponent<CullingManager>
{
	// Token: 0x060029CA RID: 10698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022F4")]
	[Address(RVA = "0x6DACB0", Offset = "0x6D9AB0", VA = "0x1806DACB0")]
	public void MarkSeen(Vector3 pos)
	{
	}

	// Token: 0x060029CB RID: 10699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022F5")]
	[Address(RVA = "0x6DAEC0", Offset = "0x6D9CC0", VA = "0x1806DAEC0")]
	private void RemoveInvisible()
	{
	}

	// Token: 0x060029CC RID: 10700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022F6")]
	[Address(RVA = "0x6DAB60", Offset = "0x6D9960", VA = "0x1806DAB60")]
	protected void LateUpdate()
	{
	}

	// Token: 0x060029CD RID: 10701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022F7")]
	[Address(RVA = "0x6DAF80", Offset = "0x6D9D80", VA = "0x1806DAF80")]
	public CullingManager()
	{
	}

	// Token: 0x0400252B RID: 9515
	[Token(Token = "0x4001E57")]
	[FieldOffset(Offset = "0x18")]
	private List<CullingVolume> volumes;
}
