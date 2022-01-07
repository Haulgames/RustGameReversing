using System;
using Il2CppDummyDll;

// Token: 0x02000573 RID: 1395
[Token(Token = "0x200040C")]
public class CH47Helicopter : BaseHelicopterVehicle
{
	// Token: 0x0600282A RID: 10282 RVA: 0x00011910 File Offset: 0x0000FB10
	[Token(Token = "0x600218E")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "188")]
	protected override bool CanPushNow(BasePlayer pusher)
	{
		return default(bool);
	}

	// Token: 0x0600282B RID: 10283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600218F")]
	[Address(RVA = "0x646720", Offset = "0x645520", VA = "0x180646720")]
	public CH47Helicopter()
	{
	}

	// Token: 0x0400235C RID: 9052
	[Token(Token = "0x4001CDD")]
	[FieldOffset(Offset = "0x4C0")]
	public GameObjectRef mapMarkerEntityPrefab;
}
