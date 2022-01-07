using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000595 RID: 1429
[Token(Token = "0x200042C")]
public class EngineDamageOverTime
{
	// Token: 0x060028CB RID: 10443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600222E")]
	[Address(RVA = "0x992780", Offset = "0x991580", VA = "0x180992780")]
	public EngineDamageOverTime(float triggerDamage, float maxSeconds, Action trigger)
	{
	}

	// Token: 0x060028CC RID: 10444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600222F")]
	[Address(RVA = "0x992610", Offset = "0x991410", VA = "0x180992610")]
	public void TakeDamage(float amount)
	{
	}

	// Token: 0x060028CD RID: 10445 RVA: 0x00011CB8 File Offset: 0x0000FEB8
	[Token(Token = "0x6002230")]
	[Address(RVA = "0x992500", Offset = "0x991300", VA = "0x180992500")]
	private float GetRecentDamage()
	{
		return 0f;
	}

	// Token: 0x0400242C RID: 9260
	[Token(Token = "0x4001DA0")]
	[FieldOffset(Offset = "0x10")]
	private readonly List<EngineDamageOverTime.RecentDamage> recentDamage;

	// Token: 0x0400242D RID: 9261
	[Token(Token = "0x4001DA1")]
	[FieldOffset(Offset = "0x18")]
	private readonly float maxSeconds;

	// Token: 0x0400242E RID: 9262
	[Token(Token = "0x4001DA2")]
	[FieldOffset(Offset = "0x1C")]
	private readonly float triggerDamage;

	// Token: 0x0400242F RID: 9263
	[Token(Token = "0x4001DA3")]
	[FieldOffset(Offset = "0x20")]
	private readonly Action trigger;

	// Token: 0x02000596 RID: 1430
	[Token(Token = "0x2000B9C")]
	private struct RecentDamage
	{
		// Token: 0x060028CE RID: 10446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E19")]
		[Address(RVA = "0xF5C30", Offset = "0xF5030", VA = "0x1800F5C30")]
		public RecentDamage(float time, float amount)
		{
		}

		// Token: 0x04002430 RID: 9264
		[Token(Token = "0x4004396")]
		[FieldOffset(Offset = "0x0")]
		public readonly float time;

		// Token: 0x04002431 RID: 9265
		[Token(Token = "0x4004397")]
		[FieldOffset(Offset = "0x4")]
		public readonly float amount;
	}
}
