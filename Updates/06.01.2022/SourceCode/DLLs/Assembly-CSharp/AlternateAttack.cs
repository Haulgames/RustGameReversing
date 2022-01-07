using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000BBB RID: 3003
[Token(Token = "0x2000870")]
public class AlternateAttack : StateMachineBehaviour
{
	// Token: 0x0600455D RID: 17757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AA6")]
	[Address(RVA = "0x823CD0", Offset = "0x822AD0", VA = "0x180823CD0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600455E RID: 17758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AA7")]
	[Address(RVA = "0x50A1C0", Offset = "0x508FC0", VA = "0x18050A1C0")]
	public AlternateAttack()
	{
	}

	// Token: 0x04004192 RID: 16786
	[Token(Token = "0x400328D")]
	[FieldOffset(Offset = "0x18")]
	public bool random;

	// Token: 0x04004193 RID: 16787
	[Token(Token = "0x400328E")]
	[FieldOffset(Offset = "0x19")]
	public bool dontIncrement;

	// Token: 0x04004194 RID: 16788
	[Token(Token = "0x400328F")]
	[FieldOffset(Offset = "0x20")]
	public string[] targetTransitions;
}
