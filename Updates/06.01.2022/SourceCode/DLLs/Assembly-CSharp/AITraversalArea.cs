using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000272 RID: 626
[Token(Token = "0x20001B1")]
public class AITraversalArea : TriggerBase
{
	// Token: 0x06001938 RID: 6456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D7")]
	[Address(RVA = "0x8179C0", Offset = "0x8167C0", VA = "0x1808179C0")]
	public void OnValidate()
	{
	}

	// Token: 0x06001939 RID: 6457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D8")]
	[Address(RVA = "0x8174F0", Offset = "0x8162F0", VA = "0x1808174F0", Slot = "6")]
	internal override GameObject InterestedInObject(GameObject obj)
	{
		return null;
	}

	// Token: 0x0600193A RID: 6458 RVA: 0x0000CD80 File Offset: 0x0000AF80
	[Token(Token = "0x60013D9")]
	[Address(RVA = "0x816D10", Offset = "0x815B10", VA = "0x180816D10")]
	public bool CanTraverse(BaseEntity ent)
	{
		return default(bool);
	}

	// Token: 0x0600193B RID: 6459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013DA")]
	[Address(RVA = "0x816D70", Offset = "0x815B70", VA = "0x180816D70")]
	public Transform GetClosestEntry(Vector3 position)
	{
		return null;
	}

	// Token: 0x0600193C RID: 6460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013DB")]
	[Address(RVA = "0x8173C0", Offset = "0x8161C0", VA = "0x1808173C0")]
	public Transform GetFarthestEntry(Vector3 position)
	{
		return null;
	}

	// Token: 0x0600193D RID: 6461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013DC")]
	[Address(RVA = "0x817A20", Offset = "0x816820", VA = "0x180817A20")]
	public void SetBusyFor(float dur = 1f)
	{
	}

	// Token: 0x0600193E RID: 6462 RVA: 0x0000CD98 File Offset: 0x0000AF98
	[Token(Token = "0x60013DD")]
	[Address(RVA = "0x816D10", Offset = "0x815B10", VA = "0x180816D10")]
	public bool CanUse(Vector3 dirFrom)
	{
		return default(bool);
	}

	// Token: 0x0600193F RID: 6463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013DE")]
	[Address(RVA = "0x8179A0", Offset = "0x8167A0", VA = "0x1808179A0", Slot = "8")]
	internal override void OnEntityEnter(BaseEntity ent)
	{
	}

	// Token: 0x06001940 RID: 6464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013DF")]
	[Address(RVA = "0x816EA0", Offset = "0x815CA0", VA = "0x180816EA0")]
	public AITraversalWaitPoint GetEntryPointNear(Vector3 pos)
	{
		return null;
	}

	// Token: 0x06001941 RID: 6465 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
	[Token(Token = "0x60013E0")]
	[Address(RVA = "0x816D30", Offset = "0x815B30", VA = "0x180816D30")]
	public bool EntityFilter(BaseEntity ent)
	{
		return default(bool);
	}

	// Token: 0x06001942 RID: 6466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E1")]
	[Address(RVA = "0x8179B0", Offset = "0x8167B0", VA = "0x1808179B0", Slot = "9")]
	internal override void OnEntityLeave(BaseEntity ent)
	{
	}

	// Token: 0x06001943 RID: 6467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E2")]
	[Address(RVA = "0x8175F0", Offset = "0x8163F0", VA = "0x1808175F0")]
	public void OnDrawGizmos()
	{
	}

	// Token: 0x06001944 RID: 6468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E3")]
	[Address(RVA = "0x50C980", Offset = "0x50B780", VA = "0x18050C980")]
	public AITraversalArea()
	{
	}

	// Token: 0x04001377 RID: 4983
	[Token(Token = "0x4000FF9")]
	[FieldOffset(Offset = "0x30")]
	public Transform entryPoint1;

	// Token: 0x04001378 RID: 4984
	[Token(Token = "0x4000FFA")]
	[FieldOffset(Offset = "0x38")]
	public Transform entryPoint2;

	// Token: 0x04001379 RID: 4985
	[Token(Token = "0x4000FFB")]
	[FieldOffset(Offset = "0x40")]
	public AITraversalWaitPoint[] waitPoints;

	// Token: 0x0400137A RID: 4986
	[Token(Token = "0x4000FFC")]
	[FieldOffset(Offset = "0x48")]
	public Bounds movementArea;

	// Token: 0x0400137B RID: 4987
	[Token(Token = "0x4000FFD")]
	[FieldOffset(Offset = "0x60")]
	public Transform activeEntryPoint;

	// Token: 0x0400137C RID: 4988
	[Token(Token = "0x4000FFE")]
	[FieldOffset(Offset = "0x68")]
	public float nextFreeTime;
}
