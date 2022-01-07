using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000257 RID: 599
[Token(Token = "0x200019B")]
public class EffectMount : EntityComponent<BaseEntity>, IClientComponent
{
	// Token: 0x060018C3 RID: 6339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001369")]
	[Address(RVA = "0x986590", Offset = "0x985390", VA = "0x180986590")]
	private void LateUpdate()
	{
	}

	// Token: 0x060018C4 RID: 6340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136A")]
	[Address(RVA = "0x9867E0", Offset = "0x9855E0", VA = "0x1809867E0")]
	public void SetOn(bool isOn)
	{
	}

	// Token: 0x060018C5 RID: 6341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136B")]
	[Address(RVA = "0x9869F0", Offset = "0x9857F0", VA = "0x1809869F0")]
	public EffectMount()
	{
	}

	// Token: 0x040012F3 RID: 4851
	[Token(Token = "0x4000F7F")]
	[FieldOffset(Offset = "0x20")]
	public bool firstPerson;

	// Token: 0x040012F4 RID: 4852
	[Token(Token = "0x4000F80")]
	[FieldOffset(Offset = "0x28")]
	public GameObject effectPrefab;

	// Token: 0x040012F5 RID: 4853
	[Token(Token = "0x4000F81")]
	[FieldOffset(Offset = "0x30")]
	public GameObject spawnedEffect;

	// Token: 0x040012F6 RID: 4854
	[Token(Token = "0x4000F82")]
	[FieldOffset(Offset = "0x38")]
	public GameObject mountBone;
}
