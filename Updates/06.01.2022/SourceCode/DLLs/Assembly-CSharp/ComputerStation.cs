using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x0200012E RID: 302
[Token(Token = "0x20000B0")]
public class ComputerStation : BaseMountable
{
	// Token: 0x060011C8 RID: 4552 RVA: 0x0000A548 File Offset: 0x00008748
	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0x4A7070", Offset = "0x4A5E70", VA = "0x1804A7070", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060011C9 RID: 4553 RVA: 0x0000A560 File Offset: 0x00008760
	[Token(Token = "0x6000CE9")]
	[Address(RVA = "0x4A6CF0", Offset = "0x4A5AF0", VA = "0x1804A6CF0")]
	public static bool IsValidIdentifier(string str)
	{
		return default(bool);
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEA")]
	[Address(RVA = "0x46CB10", Offset = "0x46B910", VA = "0x18046CB10", Slot = "31")]
	public override void DestroyShared()
	{
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEB")]
	[Address(RVA = "0x4A6D70", Offset = "0x4A5B70", VA = "0x1804A6D70", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060011CC RID: 4556 RVA: 0x0000A578 File Offset: 0x00008778
	[Token(Token = "0x6000CEC")]
	[Address(RVA = "0x4A6BF0", Offset = "0x4A59F0", VA = "0x1804A6BF0", Slot = "172")]
	public override Quaternion GetMountedRotation()
	{
		return default(Quaternion);
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CED")]
	[Address(RVA = "0x4A78D0", Offset = "0x4A66D0", VA = "0x1804A78D0")]
	[BaseEntity.RPC_Client]
	public void ReceiveBookmarks(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEE")]
	[Address(RVA = "0x4A74C0", Offset = "0x4A62C0", VA = "0x1804A74C0", Slot = "174")]
	public override void PlayerDismounted(BasePlayer player, bool wasSwap)
	{
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x0000A590 File Offset: 0x00008790
	[Token(Token = "0x6000CEF")]
	[Address(RVA = "0x4A6B50", Offset = "0x4A5950", VA = "0x1804A6B50", Slot = "145")]
	public override BasePlayer.CameraMode GetMountedCameraMode()
	{
		return BasePlayer.CameraMode.FirstPerson;
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF0")]
	[Address(RVA = "0x4A6FB0", Offset = "0x4A5DB0", VA = "0x1804A6FB0")]
	public void MenuShutdown()
	{
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF1")]
	[Address(RVA = "0x4A7630", Offset = "0x4A6430", VA = "0x1804A7630", Slot = "173")]
	public override void PlayerMounted(BasePlayer player, bool wasSwap)
	{
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x0000A5A8 File Offset: 0x000087A8
	[Token(Token = "0x6000CF2")]
	[Address(RVA = "0x4A6B10", Offset = "0x4A5910", VA = "0x1804A6B10", Slot = "148")]
	public override Quaternion GetMountedBodyAngles()
	{
		return default(Quaternion);
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x0000A5C0 File Offset: 0x000087C0
	[Token(Token = "0x6000CF3")]
	[Address(RVA = "0x4A6900", Offset = "0x4A5700", VA = "0x1804A6900", Slot = "153")]
	public override Vector3 EyePositionForPlayer(BasePlayer player, Quaternion lookRot)
	{
		return default(Vector3);
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x0000A5D8 File Offset: 0x000087D8
	[Token(Token = "0x6000CF4")]
	[Address(RVA = "0x4A6FD0", Offset = "0x4A5DD0", VA = "0x1804A6FD0", Slot = "149")]
	public override bool ModifiesThirdPersonCamera()
	{
		return default(bool);
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CF5")]
	[Address(RVA = "0x4A6A50", Offset = "0x4A5850", VA = "0x1804A6A50", Slot = "147")]
	public override Transform GetEyeOverride()
	{
		return null;
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x0000A5F0 File Offset: 0x000087F0
	[Token(Token = "0x6000CF6")]
	[Address(RVA = "0x2F7A30", Offset = "0x2F6830", VA = "0x1802F7A30", Slot = "150")]
	public override Vector2 GetPitchClamp()
	{
		return default(Vector2);
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x0000A608 File Offset: 0x00008808
	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0x2F7A60", Offset = "0x2F6860", VA = "0x1802F7A60", Slot = "151")]
	public override Vector2 GetYawClamp()
	{
		return default(Vector2);
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0x4A7B10", Offset = "0x4A6910", VA = "0x1804A7B10", Slot = "170")]
	public override void UpdatePlayerModel(BasePlayer player)
	{
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x4A7C30", Offset = "0x4A6A30", VA = "0x1804A7C30")]
	public ComputerStation()
	{
	}

	// Token: 0x04000C34 RID: 3124
	[Token(Token = "0x40009C2")]
	[FieldOffset(Offset = "0x318")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x91740", Offset = "0x90B40")]
	public GameObjectRef menuPrefab;

	// Token: 0x04000C35 RID: 3125
	[Token(Token = "0x40009C3")]
	[FieldOffset(Offset = "0x320")]
	public ComputerMenu computerMenu;

	// Token: 0x04000C36 RID: 3126
	[Token(Token = "0x40009C4")]
	[FieldOffset(Offset = "0x328")]
	public EntityRef currentlyControllingEnt;

	// Token: 0x04000C37 RID: 3127
	[Token(Token = "0x40009C5")]
	[FieldOffset(Offset = "0x338")]
	public Dictionary<string, uint> controlBookmarks;

	// Token: 0x04000C38 RID: 3128
	[Token(Token = "0x40009C6")]
	[FieldOffset(Offset = "0x340")]
	public Transform leftHandIKPosition;

	// Token: 0x04000C39 RID: 3129
	[Token(Token = "0x40009C7")]
	[FieldOffset(Offset = "0x348")]
	public Transform rightHandIKPosition;

	// Token: 0x04000C3A RID: 3130
	[Token(Token = "0x40009C8")]
	[FieldOffset(Offset = "0x350")]
	public SoundDefinition turnOnSoundDef;

	// Token: 0x04000C3B RID: 3131
	[Token(Token = "0x40009C9")]
	[FieldOffset(Offset = "0x358")]
	public SoundDefinition turnOffSoundDef;

	// Token: 0x04000C3C RID: 3132
	[Token(Token = "0x40009CA")]
	[FieldOffset(Offset = "0x360")]
	public SoundDefinition onLoopSoundDef;

	// Token: 0x04000C3D RID: 3133
	[Token(Token = "0x40009CB")]
	[FieldOffset(Offset = "0x368")]
	public bool isStatic;

	// Token: 0x04000C3E RID: 3134
	[Token(Token = "0x40009CC")]
	[FieldOffset(Offset = "0x36C")]
	public float autoGatherRadius;

	// Token: 0x04000C3F RID: 3135
	[Token(Token = "0x40009CD")]
	[FieldOffset(Offset = "0x370")]
	private Sound onLoopSound;
}
