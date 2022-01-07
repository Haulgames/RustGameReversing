using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000028 RID: 40
[Token(Token = "0x200001C")]
public class CargoShipInteriorSoundTrigger : MonoBehaviour, IClientComponent
{
	// Token: 0x060000D1 RID: 209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x656650", Offset = "0x655450", VA = "0x180656650")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x6568F0", Offset = "0x6556F0", VA = "0x1806568F0")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public CargoShipInteriorSoundTrigger()
	{
	}

	// Token: 0x040000E8 RID: 232
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x18")]
	public CargoShipSounds cargoShipSounds;
}
