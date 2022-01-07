using System;
using Il2CppDummyDll;

// Token: 0x02000303 RID: 771
[Token(Token = "0x200021B")]
public class Construction_SleepingBag : Construction
{
	// Token: 0x06001C21 RID: 7201 RVA: 0x0000DB60 File Offset: 0x0000BD60
	[Token(Token = "0x600167D")]
	[Address(RVA = "0x6CB770", Offset = "0x6CA570", VA = "0x1806CB770", Slot = "8")]
	public override bool ShowAsNeutral(Construction.Target target)
	{
		return default(bool);
	}

	// Token: 0x06001C22 RID: 7202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600167E")]
	[Address(RVA = "0x6CBA50", Offset = "0x6CA850", VA = "0x1806CBA50")]
	public Construction_SleepingBag()
	{
	}

	// Token: 0x04001713 RID: 5907
	[Token(Token = "0x40012CE")]
	[FieldOffset(Offset = "0x17E0")]
	public static bool ShowSleepingBagProximityWarning;
}
