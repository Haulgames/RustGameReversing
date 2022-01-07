using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000300 RID: 768
[Token(Token = "0x2000219")]
public class ConstructionSocket : Socket_Base
{
	// Token: 0x06001C15 RID: 7189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001671")]
	[Address(RVA = "0x6CA140", Offset = "0x6C8F40", VA = "0x1806CA140")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06001C16 RID: 7190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001672")]
	[Address(RVA = "0x6CA080", Offset = "0x6C8E80", VA = "0x1806CA080")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06001C17 RID: 7191 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
	[Token(Token = "0x6001673")]
	[Address(RVA = "0x6CA5B0", Offset = "0x6C93B0", VA = "0x1806CA5B0", Slot = "8")]
	public override bool TestTarget(Construction.Target target)
	{
		return default(bool);
	}

	// Token: 0x06001C18 RID: 7192 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
	[Token(Token = "0x6001674")]
	[Address(RVA = "0x6C9F80", Offset = "0x6C8D80", VA = "0x1806C9F80", Slot = "9")]
	public override bool IsCompatible(Socket_Base socket)
	{
		return default(bool);
	}

	// Token: 0x06001C19 RID: 7193 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
	[Token(Token = "0x6001675")]
	[Address(RVA = "0x6C8AC0", Offset = "0x6C78C0", VA = "0x1806C8AC0", Slot = "10")]
	public override bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation)
	{
		return default(bool);
	}

	// Token: 0x06001C1A RID: 7194 RVA: 0x0000DB00 File Offset: 0x0000BD00
	[Token(Token = "0x6001676")]
	[Address(RVA = "0x6CA3F0", Offset = "0x6C91F0", VA = "0x1806CA3F0")]
	public bool TestRestrictedAngles(Vector3 suggestedPos, Quaternion suggestedAng, Construction.Target target)
	{
		return default(bool);
	}

	// Token: 0x06001C1B RID: 7195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001677")]
	[Address(RVA = "0x6C9080", Offset = "0x6C7E80", VA = "0x1806C9080", Slot = "11")]
	public override Construction.Placement DoPlacement(Construction.Target target)
	{
		return null;
	}

	// Token: 0x06001C1C RID: 7196 RVA: 0x0000DB18 File Offset: 0x0000BD18
	[Token(Token = "0x6001678")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "13")]
	protected virtual bool CanConnectToEntity(Construction.Target target)
	{
		return default(bool);
	}

	// Token: 0x06001C1D RID: 7197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001679")]
	[Address(RVA = "0x6CA660", Offset = "0x6C9460", VA = "0x1806CA660")]
	public ConstructionSocket()
	{
	}

	// Token: 0x040016F6 RID: 5878
	[Token(Token = "0x40012C5")]
	[FieldOffset(Offset = "0xE8")]
	public ConstructionSocket.Type socketType;

	// Token: 0x040016F7 RID: 5879
	[Token(Token = "0x40012C6")]
	[FieldOffset(Offset = "0xEC")]
	public int rotationDegrees;

	// Token: 0x040016F8 RID: 5880
	[Token(Token = "0x40012C7")]
	[FieldOffset(Offset = "0xF0")]
	public int rotationOffset;

	// Token: 0x040016F9 RID: 5881
	[Token(Token = "0x40012C8")]
	[FieldOffset(Offset = "0xF4")]
	public bool restrictPlacementRotation;

	// Token: 0x040016FA RID: 5882
	[Token(Token = "0x40012C9")]
	[FieldOffset(Offset = "0xF5")]
	public bool restrictPlacementAngle;

	// Token: 0x040016FB RID: 5883
	[Token(Token = "0x40012CA")]
	[FieldOffset(Offset = "0xF8")]
	public float faceAngle;

	// Token: 0x040016FC RID: 5884
	[Token(Token = "0x40012CB")]
	[FieldOffset(Offset = "0xFC")]
	public float angleAllowed;

	// Token: 0x040016FD RID: 5885
	[Token(Token = "0x40012CC")]
	[FieldOffset(Offset = "0x100")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6CE90", Offset = "0x6C290")]
	public float support;

	// Token: 0x02000301 RID: 769
	[Token(Token = "0x2000B1C")]
	public enum Type
	{
		// Token: 0x040016FF RID: 5887
		[Token(Token = "0x4004148")]
		None,
		// Token: 0x04001700 RID: 5888
		[Token(Token = "0x4004149")]
		Foundation,
		// Token: 0x04001701 RID: 5889
		[Token(Token = "0x400414A")]
		Floor,
		// Token: 0x04001702 RID: 5890
		[Token(Token = "0x400414B")]
		Misc,
		// Token: 0x04001703 RID: 5891
		[Token(Token = "0x400414C")]
		Doorway,
		// Token: 0x04001704 RID: 5892
		[Token(Token = "0x400414D")]
		Wall,
		// Token: 0x04001705 RID: 5893
		[Token(Token = "0x400414E")]
		Block,
		// Token: 0x04001706 RID: 5894
		[Token(Token = "0x400414F")]
		Ramp,
		// Token: 0x04001707 RID: 5895
		[Token(Token = "0x4004150")]
		StairsTriangle,
		// Token: 0x04001708 RID: 5896
		[Token(Token = "0x4004151")]
		Stairs,
		// Token: 0x04001709 RID: 5897
		[Token(Token = "0x4004152")]
		FloorFrameTriangle,
		// Token: 0x0400170A RID: 5898
		[Token(Token = "0x4004153")]
		Window,
		// Token: 0x0400170B RID: 5899
		[Token(Token = "0x4004154")]
		Shutters,
		// Token: 0x0400170C RID: 5900
		[Token(Token = "0x4004155")]
		WallFrame,
		// Token: 0x0400170D RID: 5901
		[Token(Token = "0x4004156")]
		FloorFrame,
		// Token: 0x0400170E RID: 5902
		[Token(Token = "0x4004157")]
		WindowDressing,
		// Token: 0x0400170F RID: 5903
		[Token(Token = "0x4004158")]
		DoorDressing,
		// Token: 0x04001710 RID: 5904
		[Token(Token = "0x4004159")]
		Elevator,
		// Token: 0x04001711 RID: 5905
		[Token(Token = "0x400415A")]
		DoubleDoorDressing
	}
}
