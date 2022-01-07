using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000302 RID: 770
[Token(Token = "0x200021A")]
public class ConstructionSocket_Elevator : ConstructionSocket
{
	// Token: 0x06001C1E RID: 7198 RVA: 0x0000DB30 File Offset: 0x0000BD30
	[Token(Token = "0x600167A")]
	[Address(RVA = "0x6C9A70", Offset = "0x6C8870", VA = "0x1806C9A70", Slot = "13")]
	protected override bool CanConnectToEntity(Construction.Target target)
	{
		return default(bool);
	}

	// Token: 0x06001C1F RID: 7199 RVA: 0x0000DB48 File Offset: 0x0000BD48
	[Token(Token = "0x600167B")]
	[Address(RVA = "0x6C9C90", Offset = "0x6C8A90", VA = "0x1806C9C90", Slot = "10")]
	public override bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation)
	{
		return default(bool);
	}

	// Token: 0x06001C20 RID: 7200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600167C")]
	[Address(RVA = "0x6C9F50", Offset = "0x6C8D50", VA = "0x1806C9F50")]
	public ConstructionSocket_Elevator()
	{
	}

	// Token: 0x04001712 RID: 5906
	[Token(Token = "0x40012CD")]
	[FieldOffset(Offset = "0x108")]
	public int MaxFloor;
}
