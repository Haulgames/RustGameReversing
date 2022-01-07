using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000080 RID: 128
[Token(Token = "0x2000047")]
public class CarvablePumpkin : BaseOven, ILOD, ISignage
{
	// Token: 0x06000919 RID: 2329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x659180", Offset = "0x657F80", VA = "0x180659180", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x0600091A RID: 2330 RVA: 0x000051C0 File Offset: 0x000033C0
	[Token(Token = "0x17000084")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x65B200", Offset = "0x65A000", VA = "0x18065B200", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x000051D8 File Offset: 0x000033D8
	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x659FF0", Offset = "0x658DF0", VA = "0x180659FF0", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x0600091C RID: 2332 RVA: 0x000051F0 File Offset: 0x000033F0
	[Token(Token = "0x17000085")]
	public Vector2i TextureSize
	{
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x65B3F0", Offset = "0x65A1F0", VA = "0x18065B3F0", Slot = "158")]
		get
		{
			return default(Vector2i);
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x0600091D RID: 2333 RVA: 0x00005208 File Offset: 0x00003408
	[Token(Token = "0x17000086")]
	public int TextureCount
	{
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x65B3D0", Offset = "0x65A1D0", VA = "0x18065B3D0", Slot = "159")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x65A820", Offset = "0x659620", VA = "0x18065A820", Slot = "84")]
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x659070", Offset = "0x657E70", VA = "0x180659070")]
	private void FreeTexture()
	{
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x65AE20", Offset = "0x659C20", VA = "0x18065AE20")]
	protected void RequestTextureUpdate()
	{
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x659970", Offset = "0x658770", VA = "0x180659970")]
	private void LoadTexture(int frame, uint id, byte[] data)
	{
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x659E50", Offset = "0x658C50", VA = "0x180659E50")]
	[Attribute(Name = "Menu", RVA = "0xC20F0", Offset = "0xC14F0")]
	[Attribute(Name = "Icon", RVA = "0xC20F0", Offset = "0xC14F0")]
	[Attribute(Name = "Description", RVA = "0xC20F0", Offset = "0xC14F0")]
	[Attribute(Name = "ShowIf", RVA = "0xC20F0", Offset = "0xC14F0")]
	public void Menu_ChangeText(global::BasePlayer player)
	{
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x65A440", Offset = "0x659240", VA = "0x18065A440", Slot = "164")]
	public virtual void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = false)
	{
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x65AB80", Offset = "0x659980", VA = "0x18065AB80")]
	[global::BaseEntity.RPC_Client]
	public void RecieveTexture(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x658F90", Offset = "0x657D90", VA = "0x180658F90")]
	private void EnsureInitialized()
	{
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x65B120", Offset = "0x659F20", VA = "0x18065B120")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x702E0", Offset = "0x6F6E0")]
	private static void SignDebugLog(string str)
	{
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000927 RID: 2343 RVA: 0x00005220 File Offset: 0x00003420
	[Token(Token = "0x17000087")]
	public FileStorage.Type FileType
	{
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "162")]
		get
		{
			return FileStorage.Type.png;
		}
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x659960", Offset = "0x658760", VA = "0x180659960", Slot = "160")]
	public uint[] GetTextureCRCs()
	{
		return null;
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06000929 RID: 2345 RVA: 0x00005238 File Offset: 0x00003438
	[Token(Token = "0x17000088")]
	public uint NetworkID
	{
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x611A70", Offset = "0x610870", VA = "0x180611A70", Slot = "161")]
		get
		{
			return 0U;
		}
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00005250 File Offset: 0x00003450
	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x60F170", Offset = "0x60DF70", VA = "0x18060F170", Slot = "165")]
	public virtual bool CanUpdateSign(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00005268 File Offset: 0x00003468
	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x658BB0", Offset = "0x6579B0", VA = "0x180658BB0")]
	public bool CanUnlockSign(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00005280 File Offset: 0x00003480
	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x658B60", Offset = "0x657960", VA = "0x180658B60")]
	public bool CanLockSign(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x659C10", Offset = "0x658A10", VA = "0x180659C10", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x0600092E RID: 2350 RVA: 0x00005298 File Offset: 0x00003498
	// (set) Token: 0x0600092F RID: 2351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000089")]
	private protected bool withinTextureRange
	{
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x65B4B0", Offset = "0x65A2B0", VA = "0x18065B4B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected get
		{
			return default(bool);
		}
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x65B4C0", Offset = "0x65A2C0", VA = "0x18065B4C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x658D30", Offset = "0x657B30", VA = "0x180658D30", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x658DC0", Offset = "0x657BC0", VA = "0x180658DC0", Slot = "19")]
	protected override void DoClientDestroy()
	{
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x65ADA0", Offset = "0x659BA0", VA = "0x18065ADA0", Slot = "155")]
	public void RefreshLOD()
	{
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x658C30", Offset = "0x657A30", VA = "0x180658C30", Slot = "154")]
	public void ChangeLOD()
	{
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "166")]
	protected virtual void OnEnterTextureRange()
	{
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "167")]
	protected virtual void OnExitTextureRange()
	{
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x659F70", Offset = "0x658D70", VA = "0x180659F70")]
	[Attribute(Name = "Menu", RVA = "0x704F0", Offset = "0x6F8F0")]
	[Attribute(Name = "Icon", RVA = "0x704F0", Offset = "0x6F8F0")]
	[Attribute(Name = "Description", RVA = "0x704F0", Offset = "0x6F8F0")]
	[Attribute(Name = "ShowIf", RVA = "0x704F0", Offset = "0x6F8F0")]
	public void Menu_LockSign(global::BasePlayer player)
	{
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x659FB0", Offset = "0x658DB0", VA = "0x180659FB0")]
	[Attribute(Name = "Menu", RVA = "0x70730", Offset = "0x6FB30")]
	[Attribute(Name = "Icon", RVA = "0x70730", Offset = "0x6FB30")]
	[Attribute(Name = "Description", RVA = "0x70730", Offset = "0x6FB30")]
	[Attribute(Name = "ShowIf", RVA = "0x70730", Offset = "0x6FB30")]
	public void Menu_UnLockSign(global::BasePlayer player)
	{
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x65A900", Offset = "0x659700", VA = "0x18065A900")]
	public static void RebuildAll()
	{
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x658C00", Offset = "0x657A00", VA = "0x180658C00", Slot = "121")]
	public override string Categorize()
	{
		return null;
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x65B1F0", Offset = "0x659FF0", VA = "0x18065B1F0")]
	public CarvablePumpkin()
	{
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x65B180", Offset = "0x659F80", VA = "0x18065B180")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private void <Menu_ChangeText>b__21_0(int i, Texture2D x)
	{
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x000052B0 File Offset: 0x000034B0
	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x6117A0", Offset = "0x6105A0", VA = "0x1806117A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	internal static bool <OnTextureWasEdited>g__IsClear|22_0(Color32[] data)
	{
		return default(bool);
	}

	// Token: 0x040004D9 RID: 1241
	[Token(Token = "0x40003EC")]
	[FieldOffset(Offset = "0x4E0")]
	private Option __menuOption_Menu_ChangeText;

	// Token: 0x040004DA RID: 1242
	[Token(Token = "0x40003ED")]
	[FieldOffset(Offset = "0x538")]
	private Option __menuOption_Menu_LockSign;

	// Token: 0x040004DB RID: 1243
	[Token(Token = "0x40003EE")]
	[FieldOffset(Offset = "0x590")]
	private Option __menuOption_Menu_UnLockSign;

	// Token: 0x040004DC RID: 1244
	[Token(Token = "0x40003EF")]
	private const float TextureRequestTimeout = 15f;

	// Token: 0x040004DD RID: 1245
	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0x5E8")]
	public GameObjectRef changeTextDialog;

	// Token: 0x040004DE RID: 1246
	[Token(Token = "0x40003F1")]
	[FieldOffset(Offset = "0x5F0")]
	public MeshPaintableSource[] paintableSources;

	// Token: 0x040004DF RID: 1247
	[Token(Token = "0x40003F2")]
	[FieldOffset(Offset = "0x5F8")]
	[NonSerialized]
	public uint[] textureIDs;

	// Token: 0x040004E0 RID: 1248
	[Token(Token = "0x40003F3")]
	[FieldOffset(Offset = "0x600")]
	internal RealTimeSince[] timeSinceRequest;

	// Token: 0x040004E1 RID: 1249
	[Token(Token = "0x40003F4")]
	[FieldOffset(Offset = "0x608")]
	internal uint[] loadedTextures;

	// Token: 0x040004E2 RID: 1250
	[Token(Token = "0x40003F5")]
	[FieldOffset(Offset = "0x0")]
	[ClientVar]
	public static float textureRequestDistance;

	// Token: 0x040004E3 RID: 1251
	[Token(Token = "0x40003F6")]
	[FieldOffset(Offset = "0x610")]
	private bool textureRequestSent;

	// Token: 0x040004E4 RID: 1252
	[Token(Token = "0x40003F7")]
	[FieldOffset(Offset = "0x611")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <withinTextureRange>k__BackingField;

	// Token: 0x040004E5 RID: 1253
	[Token(Token = "0x40003F8")]
	[FieldOffset(Offset = "0x618")]
	private LODCell cell;
}
