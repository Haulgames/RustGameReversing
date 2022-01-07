using System;
using Il2CppDummyDll;

// Token: 0x020001A1 RID: 417
[Token(Token = "0x20000FD")]
public class ElevatorStatic : Elevator
{
	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06001591 RID: 5521 RVA: 0x0000BF58 File Offset: 0x0000A158
	[Token(Token = "0x17000182")]
	protected override bool IsStatic
	{
		[Token(Token = "0x6001066")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "159")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001592 RID: 5522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001067")]
	[Address(RVA = "0x98F270", Offset = "0x98E070", VA = "0x18098F270")]
	public ElevatorStatic()
	{
	}

	// Token: 0x04000F42 RID: 3906
	[Token(Token = "0x4000C34")]
	[FieldOffset(Offset = "0x2F0")]
	public bool StaticTop;

	// Token: 0x04000F43 RID: 3907
	[Token(Token = "0x4000C35")]
	private const BaseEntity.Flags LiftRecentlyArrived = BaseEntity.Flags.Reserved3;
}
