using System;
using Il2CppDummyDll;

// Token: 0x02000566 RID: 1382
[Token(Token = "0x2000402")]
public class BaseVehicleSeat : BaseVehicleMountPoint
{
	// Token: 0x060027F2 RID: 10226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002158")]
	[Address(RVA = "0x9A94B0", Offset = "0x9A82B0", VA = "0x1809A94B0", Slot = "157")]
	public override void OnClientInput(BasePlayer player)
	{
	}

	// Token: 0x060027F3 RID: 10227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002159")]
	[Address(RVA = "0x9A9570", Offset = "0x9A8370", VA = "0x1809A9570", Slot = "170")]
	public override void UpdatePlayerModel(BasePlayer player)
	{
	}

	// Token: 0x060027F4 RID: 10228 RVA: 0x000117D8 File Offset: 0x0000F9D8
	[Token(Token = "0x600215A")]
	[Address(RVA = "0x9A94A0", Offset = "0x9A82A0", VA = "0x1809A94A0", Slot = "163")]
	protected override float GetMountedAnimationSpeed()
	{
		return 0f;
	}

	// Token: 0x060027F5 RID: 10229 RVA: 0x000117F0 File Offset: 0x0000F9F0
	[Token(Token = "0x600215B")]
	[Address(RVA = "0x9A9490", Offset = "0x9A8290", VA = "0x1809A9490", Slot = "158")]
	public override bool ForceUpdatePlayerModel(BasePlayer p)
	{
		return default(bool);
	}

	// Token: 0x060027F6 RID: 10230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600215C")]
	[Address(RVA = "0x6AF0E0", Offset = "0x6ADEE0", VA = "0x1806AF0E0")]
	public BaseVehicleSeat()
	{
	}

	// Token: 0x0400230D RID: 8973
	[Token(Token = "0x4001C99")]
	[FieldOffset(Offset = "0x318")]
	public float mountedAnimationSpeed;

	// Token: 0x0400230E RID: 8974
	[Token(Token = "0x4001C9A")]
	[FieldOffset(Offset = "0x31C")]
	public bool sendClientInputToVehicleParent;

	// Token: 0x0400230F RID: 8975
	[Token(Token = "0x4001C9B")]
	[FieldOffset(Offset = "0x31D")]
	public bool forcePlayerModelUpdate;
}
