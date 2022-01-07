using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x020001E4 RID: 484
[Token(Token = "0x2000136")]
public class BaseArcadeGame : BaseMonoBehaviour
{
	// Token: 0x060016CA RID: 5834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118A")]
	[Address(RVA = "0x846D00", Offset = "0x845B00", VA = "0x180846D00")]
	public void SendArcadeEntityMessage(ArcadeEntity ent, string msg)
	{
	}

	// Token: 0x060016CB RID: 5835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118B")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "6")]
	public virtual void OnNoHost()
	{
	}

	// Token: 0x060016CC RID: 5836 RVA: 0x0000C540 File Offset: 0x0000A740
	[Token(Token = "0x600118C")]
	[Address(RVA = "0x8465C0", Offset = "0x8453C0", VA = "0x1808465C0")]
	public bool IsGameAuthorative()
	{
		return default(bool);
	}

	// Token: 0x060016CD RID: 5837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118D")]
	[Address(RVA = "0x846DE0", Offset = "0x845BE0", VA = "0x180846DE0")]
	public void SetGameAuthorative(bool wants)
	{
	}

	// Token: 0x060016CE RID: 5838 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600118E")]
	[Address(RVA = "0x846370", Offset = "0x845170", VA = "0x180846370")]
	public Sprite GetSprite(uint index)
	{
		return null;
	}

	// Token: 0x060016CF RID: 5839 RVA: 0x0000C558 File Offset: 0x0000A758
	[Token(Token = "0x600118F")]
	[Address(RVA = "0x846280", Offset = "0x845080", VA = "0x180846280")]
	public uint GetSpriteIndex(Sprite sprite)
	{
		return 0U;
	}

	// Token: 0x060016D0 RID: 5840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001190")]
	[Address(RVA = "0x845D20", Offset = "0x844B20", VA = "0x180845D20")]
	public ArcadeEntityController CreateEntityViaController(ArcadeEntityController controllerPrefab, Vector3 pos, Vector3 heading)
	{
		return null;
	}

	// Token: 0x060016D1 RID: 5841 RVA: 0x0000C570 File Offset: 0x0000A770
	[Token(Token = "0x6001191")]
	[Address(RVA = "0x8455C0", Offset = "0x8443C0", VA = "0x1808455C0")]
	public float ClampMouseDelta(float delta)
	{
		return 0f;
	}

	// Token: 0x060016D2 RID: 5842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001192")]
	[Address(RVA = "0x846900", Offset = "0x845700", VA = "0x180846900")]
	public void RenderGame()
	{
	}

	// Token: 0x060016D3 RID: 5843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001193")]
	[Address(RVA = "0x846630", Offset = "0x845430", VA = "0x180846630")]
	public void OnDisable()
	{
	}

	// Token: 0x060016D4 RID: 5844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001194")]
	[Address(RVA = "0x846200", Offset = "0x845000", VA = "0x180846200")]
	public ArcadeEntity GetByID(uint id)
	{
		return null;
	}

	// Token: 0x060016D5 RID: 5845 RVA: 0x0000C588 File Offset: 0x0000A788
	[Token(Token = "0x6001195")]
	[Address(RVA = "0x8460E0", Offset = "0x844EE0", VA = "0x1808460E0")]
	public int GetArcadeEntityManifestIndex(ArcadeEntity source)
	{
		return 0;
	}

	// Token: 0x060016D6 RID: 5846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001196")]
	[Address(RVA = "0x846860", Offset = "0x845660", VA = "0x180846860")]
	public void RegisterArcadeEntity(ArcadeEntity ent, bool onHost = false, uint idOverride = 0U)
	{
	}

	// Token: 0x060016D7 RID: 5847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001197")]
	[Address(RVA = "0x845B90", Offset = "0x844990", VA = "0x180845B90")]
	public ArcadeEntity CreateArcadeEntity(ArcadeEntity source, bool onHost = false, uint idOverride = 0U)
	{
		return null;
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001198")]
	[Address(RVA = "0x845630", Offset = "0x844430", VA = "0x180845630")]
	public ArcadeEntity CreateArcadeEntity(uint prefabIndex, bool onHost = false, uint idOverride = 0U)
	{
		return null;
	}

	// Token: 0x060016D9 RID: 5849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001199")]
	[Address(RVA = "0x845EC0", Offset = "0x844CC0", VA = "0x180845EC0")]
	public void DestroyEntity(uint entityID)
	{
	}

	// Token: 0x060016DA RID: 5850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119A")]
	[Address(RVA = "0x846A60", Offset = "0x845860", VA = "0x180846A60")]
	public void Retire(ArcadeEntity toRetire)
	{
	}

	// Token: 0x060016DB RID: 5851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119B")]
	[Address(RVA = "0x846790", Offset = "0x845590", VA = "0x180846790")]
	public void OnGameVisibilityChanged(bool isVisible)
	{
	}

	// Token: 0x060016DC RID: 5852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119C")]
	[Address(RVA = "0x8463B0", Offset = "0x8451B0", VA = "0x1808463B0", Slot = "7")]
	public virtual void Initialize()
	{
	}

	// Token: 0x060016DD RID: 5853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119D")]
	[Address(RVA = "0x846630", Offset = "0x845430", VA = "0x180846630")]
	public void Shutdown()
	{
	}

	// Token: 0x060016DE RID: 5854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119E")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "8")]
	public virtual void MenuAction(string message)
	{
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119F")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "9")]
	public virtual void PlayerInput(InputState inputState, global::BasePlayer player, int playerIndex = 0, bool clientside = false)
	{
	}

	// Token: 0x060016E0 RID: 5856 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A0")]
	[Address(RVA = "0x846B00", Offset = "0x845900", VA = "0x180846B00")]
	public ArcadeGame SaveSnapshot(bool force = true)
	{
		return null;
	}

	// Token: 0x060016E1 RID: 5857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A1")]
	[Address(RVA = "0x846060", Offset = "0x844E60", VA = "0x180846060")]
	public ArcadeEntity GetArcadeEntityFromCollider(Collider hitCol)
	{
		return null;
	}

	// Token: 0x060016E2 RID: 5858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A2")]
	[Address(RVA = "0x846F00", Offset = "0x845D00", VA = "0x180846F00", Slot = "10")]
	public virtual void UpdateGameFromSnapshot(ArcadeGame game)
	{
	}

	// Token: 0x060016E3 RID: 5859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A3")]
	[Address(RVA = "0x8471F0", Offset = "0x845FF0", VA = "0x1808471F0")]
	public BaseArcadeGame()
	{
	}

	// Token: 0x04001087 RID: 4231
	[Token(Token = "0x4000D50")]
	[FieldOffset(Offset = "0x0")]
	public static List<BaseArcadeGame> globalActiveGames;

	// Token: 0x04001088 RID: 4232
	[Token(Token = "0x4000D51")]
	[FieldOffset(Offset = "0x18")]
	public Camera cameraToRender;

	// Token: 0x04001089 RID: 4233
	[Token(Token = "0x4000D52")]
	[FieldOffset(Offset = "0x20")]
	public RenderTexture renderTexture;

	// Token: 0x0400108A RID: 4234
	[Token(Token = "0x4000D53")]
	[FieldOffset(Offset = "0x28")]
	public Texture2D distantTexture;

	// Token: 0x0400108B RID: 4235
	[Token(Token = "0x4000D54")]
	[FieldOffset(Offset = "0x30")]
	public Transform center;

	// Token: 0x0400108C RID: 4236
	[Token(Token = "0x4000D55")]
	[FieldOffset(Offset = "0x38")]
	public int frameRate;

	// Token: 0x0400108D RID: 4237
	[Token(Token = "0x4000D56")]
	[FieldOffset(Offset = "0x40")]
	public Dictionary<uint, ArcadeEntity> activeArcadeEntities;

	// Token: 0x0400108E RID: 4238
	[Token(Token = "0x4000D57")]
	[FieldOffset(Offset = "0x48")]
	public Sprite[] spriteManifest;

	// Token: 0x0400108F RID: 4239
	[Token(Token = "0x4000D58")]
	[FieldOffset(Offset = "0x50")]
	public ArcadeEntity[] entityManifest;

	// Token: 0x04001090 RID: 4240
	[Token(Token = "0x4000D59")]
	[FieldOffset(Offset = "0x58")]
	public bool clientside;

	// Token: 0x04001091 RID: 4241
	[Token(Token = "0x4000D5A")]
	[FieldOffset(Offset = "0x59")]
	public bool clientsideInput;

	// Token: 0x04001092 RID: 4242
	[Token(Token = "0x4000D5B")]
	public const int spriteIndexInvisible = 1555;

	// Token: 0x04001093 RID: 4243
	[Token(Token = "0x4000D5C")]
	[FieldOffset(Offset = "0x60")]
	public GameObject arcadeEntityPrefab;

	// Token: 0x04001094 RID: 4244
	[Token(Token = "0x4000D5D")]
	[FieldOffset(Offset = "0x68")]
	public BaseArcadeMachine ownerMachine;

	// Token: 0x04001095 RID: 4245
	[Token(Token = "0x4000D5E")]
	[FieldOffset(Offset = "0x8")]
	public static int gameOffsetIndex;

	// Token: 0x04001096 RID: 4246
	[Token(Token = "0x4000D5F")]
	[FieldOffset(Offset = "0x70")]
	private bool isAuthorative;

	// Token: 0x04001097 RID: 4247
	[Token(Token = "0x4000D60")]
	[FieldOffset(Offset = "0x78")]
	public Canvas canvas;

	// Token: 0x04001098 RID: 4248
	[Token(Token = "0x4000D61")]
	[FieldOffset(Offset = "0x80")]
	private float lastFrameRate;

	// Token: 0x04001099 RID: 4249
	[Token(Token = "0x4000D62")]
	[FieldOffset(Offset = "0x84")]
	private uint lastEntityID;

	// Token: 0x0400109A RID: 4250
	[Token(Token = "0x4000D63")]
	[FieldOffset(Offset = "0x88")]
	private bool currentGameVisibility;

	// Token: 0x0400109B RID: 4251
	[Token(Token = "0x4000D64")]
	[FieldOffset(Offset = "0x8C")]
	private float lastSnapshotTime;
}
