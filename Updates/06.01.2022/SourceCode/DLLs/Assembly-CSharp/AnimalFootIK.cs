using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000337 RID: 823
[Token(Token = "0x2000249")]
public class AnimalFootIK : MonoBehaviour
{
	// Token: 0x06001CD1 RID: 7377 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
	[Token(Token = "0x600172A")]
	[Address(RVA = "0x8310F0", Offset = "0x82FEF0", VA = "0x1808310F0")]
	public bool GroundSample(Vector3 origin, out RaycastHit hit)
	{
		return default(bool);
	}

	// Token: 0x06001CD2 RID: 7378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600172B")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void Start()
	{
	}

	// Token: 0x06001CD3 RID: 7379 RVA: 0x0000E100 File Offset: 0x0000C300
	[Token(Token = "0x600172C")]
	[Address(RVA = "0x8310C0", Offset = "0x82FEC0", VA = "0x1808310C0")]
	public AvatarIKGoal GoalFromIndex(int index)
	{
		return AvatarIKGoal.LeftFoot;
	}

	// Token: 0x06001CD4 RID: 7380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600172D")]
	[Address(RVA = "0x831220", Offset = "0x830020", VA = "0x180831220")]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	// Token: 0x06001CD5 RID: 7381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600172E")]
	[Address(RVA = "0x8316E0", Offset = "0x8304E0", VA = "0x1808316E0")]
	public AnimalFootIK()
	{
	}

	// Token: 0x040017D6 RID: 6102
	[Token(Token = "0x4001372")]
	[FieldOffset(Offset = "0x18")]
	public Transform[] Feet;

	// Token: 0x040017D7 RID: 6103
	[Token(Token = "0x4001373")]
	[FieldOffset(Offset = "0x20")]
	public Animator animator;

	// Token: 0x040017D8 RID: 6104
	[Token(Token = "0x4001374")]
	[FieldOffset(Offset = "0x28")]
	public float maxWeightDistance;

	// Token: 0x040017D9 RID: 6105
	[Token(Token = "0x4001375")]
	[FieldOffset(Offset = "0x2C")]
	public float minWeightDistance;

	// Token: 0x040017DA RID: 6106
	[Token(Token = "0x4001376")]
	[FieldOffset(Offset = "0x30")]
	public float actualFootOffset;
}
