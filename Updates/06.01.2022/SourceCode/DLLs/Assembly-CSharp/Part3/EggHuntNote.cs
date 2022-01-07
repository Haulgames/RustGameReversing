using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001FE RID: 510
[Token(Token = "0x200014D")]
public class EggHuntNote : MonoBehaviour, IClientComponent
{
	// Token: 0x0600175D RID: 5981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121A")]
	[Address(RVA = "0x98ADA0", Offset = "0x989BA0", VA = "0x18098ADA0")]
	public void Update()
	{
	}

	// Token: 0x0600175E RID: 5982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121B")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public EggHuntNote()
	{
	}

	// Token: 0x04001123 RID: 4387
	[Token(Token = "0x4000DDF")]
	[FieldOffset(Offset = "0x18")]
	public CanvasGroup mainGroup;

	// Token: 0x04001124 RID: 4388
	[Token(Token = "0x4000DE0")]
	[FieldOffset(Offset = "0x20")]
	public CanvasGroup timerGroup;

	// Token: 0x04001125 RID: 4389
	[Token(Token = "0x4000DE1")]
	[FieldOffset(Offset = "0x28")]
	public Text timerText;
}
