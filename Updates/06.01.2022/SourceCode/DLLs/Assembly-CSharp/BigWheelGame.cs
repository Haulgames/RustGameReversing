using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D3 RID: 467
[Token(Token = "0x2000128")]
public class BigWheelGame : SpinnerWheel
{
	// Token: 0x0600166C RID: 5740 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
	[Token(Token = "0x600112C")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "172")]
	public override bool AllowPlayerSpins()
	{
		return default(bool);
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x0000C408 File Offset: 0x0000A608
	[Token(Token = "0x600112D")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "169")]
	public override bool CanUpdateSign(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600112E")]
	[Address(RVA = "0x45AFB0", Offset = "0x459DB0", VA = "0x18045AFB0")]
	public HitNumber GetCurrentHitType()
	{
		return null;
	}

	// Token: 0x0600166F RID: 5743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600112F")]
	[Address(RVA = "0x45B170", Offset = "0x459F70", VA = "0x18045B170")]
	[Attribute(Name = "ContextMenu", RVA = "0x9E490", Offset = "0x9D890")]
	private void LoadHitNumbers()
	{
	}

	// Token: 0x06001670 RID: 5744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001130")]
	[Address(RVA = "0x45B1C0", Offset = "0x459FC0", VA = "0x18045B1C0")]
	public BigWheelGame()
	{
	}

	// Token: 0x04001026 RID: 4134
	[Token(Token = "0x4000CFC")]
	[FieldOffset(Offset = "0x518")]
	public HitNumber[] hitNumbers;

	// Token: 0x04001027 RID: 4135
	[Token(Token = "0x4000CFD")]
	[FieldOffset(Offset = "0x520")]
	public GameObject indicator;

	// Token: 0x04001028 RID: 4136
	[Token(Token = "0x4000CFE")]
	[FieldOffset(Offset = "0x528")]
	public GameObjectRef winEffect;
}
