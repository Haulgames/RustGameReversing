using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

// Token: 0x020001F7 RID: 503
[Token(Token = "0x2000147")]
public class EggHuntEvent : BaseHuntEvent
{
	// Token: 0x06001742 RID: 5954 RVA: 0x0000C618 File Offset: 0x0000A818
	[Token(Token = "0x6001200")]
	[Address(RVA = "0x98A8C0", Offset = "0x9896C0", VA = "0x18098A8C0")]
	public bool IsEventActive()
	{
		return default(bool);
	}

	// Token: 0x06001743 RID: 5955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001201")]
	[Address(RVA = "0x98A970", Offset = "0x989770", VA = "0x18098A970", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06001744 RID: 5956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001202")]
	[Address(RVA = "0x98A620", Offset = "0x989420", VA = "0x18098A620", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06001745 RID: 5957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001203")]
	[Address(RVA = "0x98A6B0", Offset = "0x9894B0", VA = "0x18098A6B0", Slot = "31")]
	public override void DestroyShared()
	{
	}

	// Token: 0x06001746 RID: 5958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001204")]
	[Address(RVA = "0x98AC20", Offset = "0x989A20", VA = "0x18098AC20")]
	public void Update()
	{
	}

	// Token: 0x06001747 RID: 5959 RVA: 0x0000C630 File Offset: 0x0000A830
	[Token(Token = "0x6001205")]
	[Address(RVA = "0x98A760", Offset = "0x989560", VA = "0x18098A760")]
	public float GetTimeRemaining()
	{
		return 0f;
	}

	// Token: 0x06001748 RID: 5960 RVA: 0x0000C648 File Offset: 0x0000A848
	[Token(Token = "0x6001206")]
	[Address(RVA = "0x98AB60", Offset = "0x989960", VA = "0x18098AB60")]
	public static bool ShowNotification()
	{
		return default(bool);
	}

	// Token: 0x06001749 RID: 5961 RVA: 0x0000C660 File Offset: 0x0000A860
	[Token(Token = "0x6001207")]
	[Address(RVA = "0x98A7D0", Offset = "0x9895D0", VA = "0x18098A7D0")]
	public static float GetWarmupSecondsLeft()
	{
		return 0f;
	}

	// Token: 0x0600174A RID: 5962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001208")]
	[Address(RVA = "0x98ACE0", Offset = "0x989AE0", VA = "0x18098ACE0")]
	public EggHuntEvent()
	{
	}

	// Token: 0x040010FF RID: 4351
	[Token(Token = "0x4000DBE")]
	[FieldOffset(Offset = "0x170")]
	public float warmupTime;

	// Token: 0x04001100 RID: 4352
	[Token(Token = "0x4000DBF")]
	[FieldOffset(Offset = "0x174")]
	public float cooldownTime;

	// Token: 0x04001101 RID: 4353
	[Token(Token = "0x4000DC0")]
	[FieldOffset(Offset = "0x178")]
	public float warnTime;

	// Token: 0x04001102 RID: 4354
	[Token(Token = "0x4000DC1")]
	[FieldOffset(Offset = "0x17C")]
	public float timeAlive;

	// Token: 0x04001103 RID: 4355
	[Token(Token = "0x4000DC2")]
	[FieldOffset(Offset = "0x0")]
	public static EggHuntEvent serverEvent;

	// Token: 0x04001104 RID: 4356
	[Token(Token = "0x4000DC3")]
	[FieldOffset(Offset = "0x8")]
	public static EggHuntEvent clientEvent;

	// Token: 0x04001105 RID: 4357
	[Token(Token = "0x4000DC4")]
	[FieldOffset(Offset = "0x10")]
	[NonSerialized]
	public static float durationSeconds;

	// Token: 0x04001106 RID: 4358
	[Token(Token = "0x4000DC5")]
	[FieldOffset(Offset = "0x180")]
	private Dictionary<ulong, EggHuntEvent.EggHunter> _eggHunters;

	// Token: 0x04001107 RID: 4359
	[Token(Token = "0x4000DC6")]
	[FieldOffset(Offset = "0x188")]
	public List<EggHuntEvent.EggHunter> clientTopHunters;

	// Token: 0x020001F8 RID: 504
	[Token(Token = "0x2000AE6")]
	public class EggHunter
	{
		// Token: 0x0600174C RID: 5964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC0")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public EggHunter()
		{
		}

		// Token: 0x04001108 RID: 4360
		[Token(Token = "0x400405F")]
		[FieldOffset(Offset = "0x10")]
		public ulong userid;

		// Token: 0x04001109 RID: 4361
		[Token(Token = "0x4004060")]
		[FieldOffset(Offset = "0x18")]
		public string displayName;

		// Token: 0x0400110A RID: 4362
		[Token(Token = "0x4004061")]
		[FieldOffset(Offset = "0x20")]
		public int numEggs;
	}
}
