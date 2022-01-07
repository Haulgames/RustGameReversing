using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

// Token: 0x020008C6 RID: 2246
[Token(Token = "0x2000654")]
public class CommandBufferDesc
{
	// Token: 0x17000474 RID: 1140
	// (get) Token: 0x0600367D RID: 13949 RVA: 0x00016C80 File Offset: 0x00014E80
	// (set) Token: 0x0600367E RID: 13950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003F5")]
	public CameraEvent CameraEvent
	{
		[Token(Token = "0x6002DD0")]
		[Address(RVA = "0x451780", Offset = "0x450580", VA = "0x180451780")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return CameraEvent.BeforeDepthTexture;
		}
		[Token(Token = "0x6002DD1")]
		[Address(RVA = "0x49F890", Offset = "0x49E690", VA = "0x18049F890")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000475 RID: 1141
	// (get) Token: 0x0600367F RID: 13951 RVA: 0x00016C98 File Offset: 0x00014E98
	// (set) Token: 0x06003680 RID: 13952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003F6")]
	public int OrderId
	{
		[Token(Token = "0x6002DD2")]
		[Address(RVA = "0x49F880", Offset = "0x49E680", VA = "0x18049F880")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002DD3")]
		[Address(RVA = "0x49F8A0", Offset = "0x49E6A0", VA = "0x18049F8A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000476 RID: 1142
	// (get) Token: 0x06003681 RID: 13953 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003682 RID: 13954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003F7")]
	public Action<CommandBuffer> FillDelegate
	{
		[Token(Token = "0x6002DD4")]
		[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002DD5")]
		[Address(RVA = "0x484E20", Offset = "0x483C20", VA = "0x180484E20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x06003683 RID: 13955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DD6")]
	[Address(RVA = "0x49F7E0", Offset = "0x49E5E0", VA = "0x18049F7E0")]
	public CommandBufferDesc(CameraEvent cameraEvent, int orderId, CommandBufferDesc.FillCommandBuffer fill)
	{
	}

	// Token: 0x040032EE RID: 13038
	[Token(Token = "0x4002745")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private CameraEvent <CameraEvent>k__BackingField;

	// Token: 0x040032EF RID: 13039
	[Token(Token = "0x4002746")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int <OrderId>k__BackingField;

	// Token: 0x040032F0 RID: 13040
	[Token(Token = "0x4002747")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private Action<CommandBuffer> <FillDelegate>k__BackingField;

	// Token: 0x020008C7 RID: 2247
	// (Invoke) Token: 0x06003685 RID: 13957
	[Token(Token = "0x2000C9E")]
	public delegate void FillCommandBuffer(CommandBuffer cb);
}
