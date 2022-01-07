using System;
using Il2CppDummyDll;
using Network;

// Token: 0x0200011D RID: 285
[Token(Token = "0x20000A8")]
public class CameraTool : HeldEntity
{
	// Token: 0x06001145 RID: 4421 RVA: 0x0000A2F0 File Offset: 0x000084F0
	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0x64D5A0", Offset = "0x64C3A0", VA = "0x18064D5A0", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0x64D0C0", Offset = "0x64BEC0", VA = "0x18064D0C0", Slot = "134")]
	public override void EditViewAngles()
	{
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0x64D350", Offset = "0x64C150", VA = "0x18064D350", Slot = "136")]
	public override void OnFrame()
	{
	}

	// Token: 0x06001148 RID: 4424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7F")]
	[Address(RVA = "0x64D4F0", Offset = "0x64C2F0", VA = "0x18064D4F0", Slot = "137")]
	public override void OnInput()
	{
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C80")]
	[Address(RVA = "0x64D240", Offset = "0x64C040", VA = "0x18064D240", Slot = "145")]
	public override void ModifyCamera()
	{
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C81")]
	[Address(RVA = "0x64D690", Offset = "0x64C490", VA = "0x18064D690")]
	public CameraTool()
	{
	}

	// Token: 0x04000BC3 RID: 3011
	[Token(Token = "0x4000969")]
	[FieldOffset(Offset = "0x1F0")]
	public GameObjectRef screenshotEffect;

	// Token: 0x04000BC4 RID: 3012
	[Token(Token = "0x400096A")]
	[FieldOffset(Offset = "0x1F8")]
	[NonSerialized]
	public float cameraFOV;

	// Token: 0x04000BC5 RID: 3013
	[Token(Token = "0x400096B")]
	[FieldOffset(Offset = "0x1FC")]
	[NonSerialized]
	public float focalDistance;

	// Token: 0x04000BC6 RID: 3014
	[Token(Token = "0x400096C")]
	[FieldOffset(Offset = "0x200")]
	internal float focalDistanceSmooth;
}
