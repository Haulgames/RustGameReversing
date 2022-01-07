using System;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine;

// Token: 0x020009A5 RID: 2469
[Token(Token = "0x20006EF")]
public class DemoRecorder : SingletonComponent<DemoRecorder>
{
	// Token: 0x06003A79 RID: 14969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003147")]
	[Address(RVA = "0x8CAF60", Offset = "0x8C9D60", VA = "0x1808CAF60", Slot = "6")]
	protected override void Awake()
	{
	}

	// Token: 0x06003A7A RID: 14970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003148")]
	[Address(RVA = "0x8CB2B0", Offset = "0x8CA0B0", VA = "0x1808CB2B0")]
	public void Open()
	{
	}

	// Token: 0x06003A7B RID: 14971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003149")]
	[Address(RVA = "0x8CB790", Offset = "0x8CA590", VA = "0x1808CB790")]
	public void Update()
	{
	}

	// Token: 0x06003A7C RID: 14972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600314A")]
	[Address(RVA = "0x8CB070", Offset = "0x8C9E70", VA = "0x1808CB070")]
	public void Close()
	{
	}

	// Token: 0x06003A7D RID: 14973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600314B")]
	[Address(RVA = "0x8CB6D0", Offset = "0x8CA4D0", VA = "0x1808CB6D0")]
	public void SubmitRecord()
	{
	}

	// Token: 0x06003A7E RID: 14974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600314C")]
	[Address(RVA = "0x8CB650", Offset = "0x8CA450", VA = "0x1808CB650")]
	public void Record()
	{
	}

	// Token: 0x06003A7F RID: 14975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600314D")]
	[Address(RVA = "0x8CB960", Offset = "0x8CA760", VA = "0x1808CB960")]
	public DemoRecorder()
	{
	}

	// Token: 0x06003A80 RID: 14976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600314E")]
	[Address(RVA = "0x44C190", Offset = "0x44AF90", VA = "0x18044C190")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private void <Close>b__6_0()
	{
	}

	// Token: 0x04003710 RID: 14096
	[Token(Token = "0x4002A3B")]
	[FieldOffset(Offset = "0x18")]
	public RustInput Input;

	// Token: 0x04003711 RID: 14097
	[Token(Token = "0x4002A3C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject RecordingUnderlay;

	// Token: 0x04003712 RID: 14098
	[Token(Token = "0x4002A3D")]
	[FieldOffset(Offset = "0x28")]
	private bool IsOpen;
}
