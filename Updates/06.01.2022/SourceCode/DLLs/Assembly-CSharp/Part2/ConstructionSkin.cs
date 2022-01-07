using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002FF RID: 767
[Token(Token = "0x2000218")]
public class ConstructionSkin : BasePrefab
{
	// Token: 0x06001C0D RID: 7181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001669")]
	[Address(RVA = "0x6C84D0", Offset = "0x6C72D0", VA = "0x1806C84D0")]
	private void RefreshRendererBatching()
	{
	}

	// Token: 0x06001C0E RID: 7182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166A")]
	[Address(RVA = "0x6C8810", Offset = "0x6C7610", VA = "0x1806C8810")]
	public void SpawnGibs(BuildingBlock parent)
	{
	}

	// Token: 0x06001C0F RID: 7183 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
	[Token(Token = "0x600166B")]
	[Address(RVA = "0x6C83D0", Offset = "0x6C71D0", VA = "0x1806C83D0")]
	public int DetermineConditionalModelState(BuildingBlock parent)
	{
		return 0;
	}

	// Token: 0x06001C10 RID: 7184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166C")]
	[Address(RVA = "0x6C80D0", Offset = "0x6C6ED0", VA = "0x1806C80D0")]
	private void CreateConditionalModels(BuildingBlock parent)
	{
	}

	// Token: 0x06001C11 RID: 7185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166D")]
	[Address(RVA = "0x6C8280", Offset = "0x6C7080", VA = "0x1806C8280")]
	private void DestroyConditionalModels(BuildingBlock parent)
	{
	}

	// Token: 0x06001C12 RID: 7186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166E")]
	[Address(RVA = "0x6C8590", Offset = "0x6C7390", VA = "0x1806C8590")]
	public void Refresh(BuildingBlock parent)
	{
	}

	// Token: 0x06001C13 RID: 7187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166F")]
	[Address(RVA = "0x6C8370", Offset = "0x6C7170", VA = "0x1806C8370")]
	public void Destroy(BuildingBlock parent)
	{
	}

	// Token: 0x06001C14 RID: 7188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001670")]
	[Address(RVA = "0x50C980", Offset = "0x50B780", VA = "0x18050C980")]
	public ConstructionSkin()
	{
	}

	// Token: 0x040016F4 RID: 5876
	[Token(Token = "0x40012C3")]
	[FieldOffset(Offset = "0x20")]
	private RendererBatch[] rendererBatches;

	// Token: 0x040016F5 RID: 5877
	[Token(Token = "0x40012C4")]
	[FieldOffset(Offset = "0x28")]
	private List<GameObject> conditionals;
}
