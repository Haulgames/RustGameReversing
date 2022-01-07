using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020A RID: 522
[Token(Token = "0x2000159")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x9EF90", Offset = "0x9E390")]
public class DeliveryDroneConfig : BaseScriptableObject
{
	// Token: 0x06001775 RID: 6005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001232")]
	[Address(RVA = "0x8C8260", Offset = "0x8C7060", VA = "0x1808C8260")]
	public void FindDescentPoints(VendingMachine vendingMachine, float currentY, out Vector3 waitPosition, out Vector3 descendPosition)
	{
	}

	// Token: 0x06001776 RID: 6006 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
	[Token(Token = "0x6001233")]
	[Address(RVA = "0x8C86F0", Offset = "0x8C74F0", VA = "0x1808C86F0")]
	public bool IsVendingMachineAccessible(VendingMachine vendingMachine, Vector3 offset, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	// Token: 0x06001777 RID: 6007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001234")]
	[Address(RVA = "0x8C8970", Offset = "0x8C7770", VA = "0x1808C8970")]
	public DeliveryDroneConfig()
	{
	}

	// Token: 0x04001145 RID: 4421
	[Token(Token = "0x4000E01")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 vendingMachineOffset;

	// Token: 0x04001146 RID: 4422
	[Token(Token = "0x4000E02")]
	[FieldOffset(Offset = "0x2C")]
	public float maxDistanceFromVendingMachine;

	// Token: 0x04001147 RID: 4423
	[Token(Token = "0x4000E03")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 halfExtents;

	// Token: 0x04001148 RID: 4424
	[Token(Token = "0x4000E04")]
	[FieldOffset(Offset = "0x3C")]
	public float testHeight;

	// Token: 0x04001149 RID: 4425
	[Token(Token = "0x4000E05")]
	[FieldOffset(Offset = "0x40")]
	public LayerMask layerMask;
}
