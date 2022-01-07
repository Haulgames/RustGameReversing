using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F5 RID: 501
[Token(Token = "0x2000145")]
public class EggAmmoRepresentation : MonoBehaviour, IInventoryChanged, IClientComponent
{
	// Token: 0x0600173B RID: 5947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F9")]
	[Address(RVA = "0x98A3A0", Offset = "0x9891A0", VA = "0x18098A3A0")]
	public void OnEnable()
	{
	}

	// Token: 0x0600173C RID: 5948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FA")]
	[Address(RVA = "0x98A320", Offset = "0x989120", VA = "0x18098A320")]
	public void OnDisable()
	{
	}

	// Token: 0x0600173D RID: 5949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FB")]
	[Address(RVA = "0x98A420", Offset = "0x989220", VA = "0x18098A420", Slot = "4")]
	public void OnInventoryChanged()
	{
	}

	// Token: 0x0600173E RID: 5950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FC")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public EggAmmoRepresentation()
	{
	}

	// Token: 0x040010FD RID: 4349
	[Token(Token = "0x4000DBC")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] eggAmmo;
}
