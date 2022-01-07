using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020008C8 RID: 2248
[Token(Token = "0x2000655")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xB9530", Offset = "0xB8930")]
public class CommandBufferManager : MonoBehaviour
{
	// Token: 0x17000477 RID: 1143
	// (get) Token: 0x06003688 RID: 13960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F8")]
	public Camera targetCamera
	{
		[Token(Token = "0x6002DD7")]
		[Address(RVA = "0x4A0E10", Offset = "0x49FC10", VA = "0x1804A0E10")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000478 RID: 1144
	// (get) Token: 0x06003689 RID: 13961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F9")]
	public Camera Camera
	{
		[Token(Token = "0x6002DD8")]
		[Address(RVA = "0x4A0D90", Offset = "0x49FB90", VA = "0x1804A0D90")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000479 RID: 1145
	// (get) Token: 0x0600368A RID: 13962 RVA: 0x00016CB0 File Offset: 0x00014EB0
	[Token(Token = "0x170003FA")]
	public bool IsReady
	{
		[Token(Token = "0x6002DD9")]
		[Address(RVA = "0x4A0DA0", Offset = "0x49FBA0", VA = "0x1804A0DA0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600368B RID: 13963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002DDA")]
	[Address(RVA = "0x4A06B0", Offset = "0x49F4B0", VA = "0x1804A06B0")]
	public static CommandBufferManager GetInstance(Camera camera)
	{
		return null;
	}

	// Token: 0x0600368C RID: 13964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DDB")]
	[Address(RVA = "0x4A03E0", Offset = "0x49F1E0", VA = "0x1804A03E0")]
	private void Awake()
	{
	}

	// Token: 0x0600368D RID: 13965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DDC")]
	[Address(RVA = "0x4A0740", Offset = "0x49F540", VA = "0x1804A0740")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600368E RID: 13966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DDD")]
	[Address(RVA = "0x4A09A0", Offset = "0x49F7A0", VA = "0x1804A09A0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600368F RID: 13967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DDE")]
	[Address(RVA = "0x4A0810", Offset = "0x49F610", VA = "0x1804A0810")]
	private void OnDisable()
	{
	}

	// Token: 0x06003690 RID: 13968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DDF")]
	[Address(RVA = "0x4A0220", Offset = "0x49F020", VA = "0x1804A0220")]
	public void AddCommands(CommandBufferDesc desc)
	{
	}

	// Token: 0x06003691 RID: 13969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DE0")]
	[Address(RVA = "0x4A0BD0", Offset = "0x49F9D0", VA = "0x1804A0BD0")]
	public void RemoveCommands(CommandBufferDesc desc)
	{
	}

	// Token: 0x06003692 RID: 13970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DE1")]
	[Address(RVA = "0x4A0470", Offset = "0x49F270", VA = "0x1804A0470")]
	private void CheckUpdateCameraEvents()
	{
	}

	// Token: 0x06003693 RID: 13971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DE2")]
	[Address(RVA = "0x4A0A30", Offset = "0x49F830", VA = "0x1804A0A30")]
	private void OnPreCull()
	{
	}

	// Token: 0x06003694 RID: 13972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DE3")]
	[Address(RVA = "0x4A0BB0", Offset = "0x49F9B0", VA = "0x1804A0BB0")]
	private void OnPreRender()
	{
	}

	// Token: 0x06003695 RID: 13973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DE4")]
	[Address(RVA = "0x4A0D20", Offset = "0x49FB20", VA = "0x1804A0D20")]
	public CommandBufferManager()
	{
	}

	// Token: 0x040032F1 RID: 13041
	[Token(Token = "0x4002748")]
	[FieldOffset(Offset = "0x18")]
	private Camera _targetCamera;

	// Token: 0x040032F2 RID: 13042
	[Token(Token = "0x4002749")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, CommandBufferManager.CommandBufferEntry> commandBuffers;

	// Token: 0x040032F3 RID: 13043
	[Token(Token = "0x400274A")]
	[FieldOffset(Offset = "0x28")]
	private bool changed;

	// Token: 0x040032F4 RID: 13044
	[Token(Token = "0x400274B")]
	[FieldOffset(Offset = "0x30")]
	public Action OnPreRenderCall;

	// Token: 0x040032F5 RID: 13045
	[Token(Token = "0x400274C")]
	[FieldOffset(Offset = "0x38")]
	public Action OnPreCullCall;

	// Token: 0x040032F6 RID: 13046
	[Token(Token = "0x400274D")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<Camera, CommandBufferManager> instances;

	// Token: 0x020008C9 RID: 2249
	[Token(Token = "0x2000C9F")]
	private struct CommandBufferEntry : IEquatable<CommandBufferManager.CommandBufferEntry>
	{
		// Token: 0x06003697 RID: 13975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005028")]
		[Address(RVA = "0xEE0D0", Offset = "0xED4D0", VA = "0x1800EE0D0")]
		public void Add(int orderId, Action<CommandBuffer> value)
		{
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005029")]
		[Address(RVA = "0xEE130", Offset = "0xED530", VA = "0x1800EE130")]
		public void Remove(int orderId)
		{
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x00016CC8 File Offset: 0x00014EC8
		[Token(Token = "0x600502A")]
		[Address(RVA = "0xEE0E0", Offset = "0xED4E0", VA = "0x1800EE0E0")]
		public bool Contains(int orderId)
		{
			return default(bool);
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x00016CE0 File Offset: 0x00014EE0
		[Token(Token = "0x600502B")]
		[Address(RVA = "0xEE0F0", Offset = "0xED4F0", VA = "0x1800EE0F0", Slot = "4")]
		public bool Equals(CommandBufferManager.CommandBufferEntry other)
		{
			return default(bool);
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x00016CF8 File Offset: 0x00014EF8
		[Token(Token = "0x600502C")]
		[Address(RVA = "0xEE100", Offset = "0xED500", VA = "0x1800EE100", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040032F7 RID: 13047
		[Token(Token = "0x400489C")]
		[FieldOffset(Offset = "0x0")]
		public CommandBuffer buffer;

		// Token: 0x040032F8 RID: 13048
		[Token(Token = "0x400489D")]
		[FieldOffset(Offset = "0x8")]
		public List<KeyValuePair<int, Action<CommandBuffer>>> orderedFill;

		// Token: 0x020008CA RID: 2250
		[Token(Token = "0x2000E73")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x0600369C RID: 13980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005417")]
			[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x0600369D RID: 13981 RVA: 0x00016D10 File Offset: 0x00014F10
			[Token(Token = "0x6005418")]
			[Address(RVA = "0x4B0480", Offset = "0x4AF280", VA = "0x1804B0480")]
			internal bool <Remove>b__0(KeyValuePair<int, Action<CommandBuffer>> s)
			{
				return default(bool);
			}

			// Token: 0x040032F9 RID: 13049
			[Token(Token = "0x4005034")]
			[FieldOffset(Offset = "0x10")]
			public int orderId;
		}
	}
}
