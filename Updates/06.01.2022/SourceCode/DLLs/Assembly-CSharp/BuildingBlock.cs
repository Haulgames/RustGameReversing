using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000119 RID: 281
[Token(Token = "0x20000A7")]
public class BuildingBlock : global::StabilityEntity
{
	// Token: 0x0600110C RID: 4364 RVA: 0x0000A0F8 File Offset: 0x000082F8
	[Token(Token = "0x6000C48")]
	[Address(RVA = "0x46E940", Offset = "0x46D740", VA = "0x18046E940", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C49")]
	[Address(RVA = "0x46C860", Offset = "0x46B660", VA = "0x18046C860", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C4A")]
	[Address(RVA = "0x46EE50", Offset = "0x46DC50", VA = "0x18046EE50", Slot = "16")]
	public override void PostNetworkUpdate()
	{
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0x46CCC0", Offset = "0x46BAC0", VA = "0x18046CCC0")]
	public List<Option> GetBuildMenu(global::BasePlayer player)
	{
		return null;
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C4C")]
	[Address(RVA = "0x46EEB0", Offset = "0x46DCB0", VA = "0x18046EEB0")]
	[global::BaseEntity.RPC_Client]
	private void RefreshSkin(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C4D")]
	[Address(RVA = "0x46F3E0", Offset = "0x46E1E0", VA = "0x18046F3E0", Slot = "62")]
	protected override void SpawnGibs()
	{
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x0000A110 File Offset: 0x00008310
	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "58")]
	public override bool ShouldLerp()
	{
		return default(bool);
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x0000A128 File Offset: 0x00008328
	[Token(Token = "0x6000C4F")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "72")]
	public override bool NeedsCrosshair()
	{
		return default(bool);
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x0000A140 File Offset: 0x00008340
	[Token(Token = "0x6000C50")]
	[Address(RVA = "0x46C2B0", Offset = "0x46B0B0", VA = "0x18046C2B0")]
	private bool CanDemolish(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06001115 RID: 4373 RVA: 0x0000A158 File Offset: 0x00008358
	[Token(Token = "0x6000C51")]
	[Address(RVA = "0x46E0A0", Offset = "0x46CEA0", VA = "0x18046E0A0")]
	private bool IsDemolishable()
	{
		return default(bool);
	}

	// Token: 0x06001116 RID: 4374 RVA: 0x0000A170 File Offset: 0x00008370
	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x46D6A0", Offset = "0x46C4A0", VA = "0x18046D6A0")]
	private bool HasDemolishPrivilege(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C53")]
	[Address(RVA = "0x46CAB0", Offset = "0x46B8B0", VA = "0x18046CAB0")]
	private void Demolish(global::BasePlayer player)
	{
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C54")]
	[Address(RVA = "0x46C940", Offset = "0x46B740", VA = "0x18046C940")]
	private void DemolishOptions(ref List<Option> options, global::BasePlayer player)
	{
	}

	// Token: 0x06001119 RID: 4377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C55")]
	[Address(RVA = "0x46F2A0", Offset = "0x46E0A0", VA = "0x18046F2A0")]
	public void SetConditionalModel(int state)
	{
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x0000A188 File Offset: 0x00008388
	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x46CE90", Offset = "0x46BC90", VA = "0x18046CE90")]
	public bool GetConditionalModel(int index)
	{
		return default(bool);
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x0600111B RID: 4379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015C")]
	public ConstructionGrade currentGrade
	{
		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x46FC20", Offset = "0x46EA20", VA = "0x18046FC20")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600111C RID: 4380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C58")]
	[Address(RVA = "0x46CEB0", Offset = "0x46BCB0", VA = "0x18046CEB0")]
	private ConstructionGrade GetGrade(BuildingGrade.Enum iGrade)
	{
		return null;
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x0000A1A0 File Offset: 0x000083A0
	[Token(Token = "0x6000C59")]
	[Address(RVA = "0x46C280", Offset = "0x46B080", VA = "0x18046C280")]
	private bool CanChangeToGrade(BuildingGrade.Enum iGrade, global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x0000A1B8 File Offset: 0x000083B8
	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0x46D860", Offset = "0x46C660", VA = "0x18046D860")]
	private bool HasUpgradePrivilege(BuildingGrade.Enum iGrade, global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600111F RID: 4383 RVA: 0x0000A1D0 File Offset: 0x000083D0
	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0x46E580", Offset = "0x46D380", VA = "0x18046E580")]
	private bool IsUpgradeBlocked()
	{
		return default(bool);
	}

	// Token: 0x06001120 RID: 4384 RVA: 0x0000A1E8 File Offset: 0x000083E8
	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0x46C0B0", Offset = "0x46AEB0", VA = "0x18046C0B0")]
	private bool CanAffordUpgrade(BuildingGrade.Enum iGrade, global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06001121 RID: 4385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5D")]
	[Address(RVA = "0x46F2B0", Offset = "0x46E0B0", VA = "0x18046F2B0")]
	public void SetGrade(BuildingGrade.Enum iGradeID)
	{
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0x46F470", Offset = "0x46E270", VA = "0x18046F470")]
	private void UpdateGrade()
	{
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0x46F860", Offset = "0x46E660", VA = "0x18046F860")]
	private void UpgradeToGrade(BuildingGrade.Enum i, global::BasePlayer player)
	{
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C60")]
	[Address(RVA = "0x46D250", Offset = "0x46C050", VA = "0x18046D250")]
	private void GradeChangingOptions(ref List<Option> options, global::BasePlayer player)
	{
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x0000A200 File Offset: 0x00008400
	[Token(Token = "0x6000C61")]
	[Address(RVA = "0x46E8A0", Offset = "0x46D6A0", VA = "0x18046E8A0")]
	private bool NeedsSkinChange()
	{
		return default(bool);
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C62")]
	[Address(RVA = "0x46F590", Offset = "0x46E390", VA = "0x18046F590")]
	public void UpdateSkin(bool force = false)
	{
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C63")]
	[Address(RVA = "0x46CB20", Offset = "0x46B920", VA = "0x18046CB20")]
	private void DestroySkin()
	{
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C64")]
	[Address(RVA = "0x46F4B0", Offset = "0x46E2B0", VA = "0x18046F4B0")]
	private void UpdatePlaceholder(bool state)
	{
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C65")]
	[Address(RVA = "0x46C6E0", Offset = "0x46B4E0", VA = "0x18046C6E0")]
	private void ChangeSkin()
	{
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C66")]
	[Address(RVA = "0x46C4C0", Offset = "0x46B2C0", VA = "0x18046C4C0")]
	private void ChangeSkin(GameObjectRef prefab)
	{
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x0000A218 File Offset: 0x00008418
	[Token(Token = "0x6000C67")]
	[Address(RVA = "0x46F3D0", Offset = "0x46E1D0", VA = "0x18046F3D0", Slot = "126")]
	public override bool ShouldBlockProjectiles()
	{
		return default(bool);
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x0000A230 File Offset: 0x00008430
	[Token(Token = "0x6000C68")]
	[Address(RVA = "0x46E870", Offset = "0x46D670", VA = "0x18046E870", Slot = "110")]
	public override float MaxHealth()
	{
		return 0f;
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C69")]
	[Address(RVA = "0x46C080", Offset = "0x46AE80", VA = "0x18046C080", Slot = "136")]
	public override List<ItemAmount> BuildCost()
	{
		return null;
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6A")]
	[Address(RVA = "0x46CBD0", Offset = "0x46B9D0", VA = "0x18046CBD0")]
	public void DrawHighlight()
	{
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6B")]
	[Address(RVA = "0x46D9B0", Offset = "0x46C7B0", VA = "0x18046D9B0")]
	public void Highlight(MeshRenderer renderer)
	{
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x0000A248 File Offset: 0x00008448
	[Token(Token = "0x6000C6C")]
	[Address(RVA = "0x46C410", Offset = "0x46B210", VA = "0x18046C410")]
	private bool CanRotate(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x0000A260 File Offset: 0x00008460
	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0x46E3B0", Offset = "0x46D1B0", VA = "0x18046E3B0")]
	private bool IsRotatable()
	{
		return default(bool);
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x0000A278 File Offset: 0x00008478
	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0x46E400", Offset = "0x46D200", VA = "0x18046E400")]
	private bool IsRotationBlocked()
	{
		return default(bool);
	}

	// Token: 0x06001133 RID: 4403 RVA: 0x0000A290 File Offset: 0x00008490
	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0x46D780", Offset = "0x46C580", VA = "0x18046D780")]
	private bool HasRotationPrivilege(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C70")]
	[Address(RVA = "0x46F1F0", Offset = "0x46DFF0", VA = "0x18046F1F0")]
	private void Rotation(global::BasePlayer player)
	{
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C71")]
	[Address(RVA = "0x46EFB0", Offset = "0x46DDB0", VA = "0x18046EFB0")]
	private void RotationOptions(ref List<Option> options, global::BasePlayer player)
	{
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C72")]
	[Address(RVA = "0x46E700", Offset = "0x46D500", VA = "0x18046E700", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06001137 RID: 4407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C73")]
	[Address(RVA = "0x46EF40", Offset = "0x46DD40", VA = "0x18046EF40", Slot = "27")]
	public override void ResetState()
	{
	}

	// Token: 0x06001138 RID: 4408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C74")]
	[Address(RVA = "0x46E020", Offset = "0x46CE20", VA = "0x18046E020", Slot = "28")]
	public override void InitShared()
	{
	}

	// Token: 0x06001139 RID: 4409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C75")]
	[Address(RVA = "0x46EDE0", Offset = "0x46DBE0", VA = "0x18046EDE0", Slot = "30")]
	public override void PostInitShared()
	{
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C76")]
	[Address(RVA = "0x46CB10", Offset = "0x46B910", VA = "0x18046CB10", Slot = "31")]
	public override void DestroyShared()
	{
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x46C490", Offset = "0x46B290", VA = "0x18046C490", Slot = "121")]
	public override string Categorize()
	{
		return null;
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x0000A2A8 File Offset: 0x000084A8
	[Token(Token = "0x6000C78")]
	[Address(RVA = "0x2F7A50", Offset = "0x2F6850", VA = "0x1802F7A50", Slot = "112")]
	public override float BoundsPadding()
	{
		return 0f;
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x0000A2C0 File Offset: 0x000084C0
	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x46E120", Offset = "0x46CF20", VA = "0x18046E120", Slot = "105")]
	public override bool IsOutside()
	{
		return default(bool);
	}

	// Token: 0x0600113E RID: 4414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0x46FC00", Offset = "0x46EA00", VA = "0x18046FC00")]
	public BuildingBlock()
	{
	}

	// Token: 0x04000BB1 RID: 2993
	[Token(Token = "0x400095B")]
	[FieldOffset(Offset = "0x260")]
	private bool forceSkinRefresh;

	// Token: 0x04000BB2 RID: 2994
	[Token(Token = "0x400095C")]
	[FieldOffset(Offset = "0x264")]
	private int modelState;

	// Token: 0x04000BB3 RID: 2995
	[Token(Token = "0x400095D")]
	[FieldOffset(Offset = "0x268")]
	private int lastModelState;

	// Token: 0x04000BB4 RID: 2996
	[Token(Token = "0x400095E")]
	[FieldOffset(Offset = "0x26C")]
	public BuildingGrade.Enum grade;

	// Token: 0x04000BB5 RID: 2997
	[Token(Token = "0x400095F")]
	[FieldOffset(Offset = "0x270")]
	private BuildingGrade.Enum lastGrade;

	// Token: 0x04000BB6 RID: 2998
	[Token(Token = "0x4000960")]
	[FieldOffset(Offset = "0x278")]
	private ConstructionSkin currentSkin;

	// Token: 0x04000BB7 RID: 2999
	[Token(Token = "0x4000961")]
	[FieldOffset(Offset = "0x280")]
	private DeferredAction skinChange;

	// Token: 0x04000BB8 RID: 3000
	[Token(Token = "0x4000962")]
	[FieldOffset(Offset = "0x288")]
	private MeshRenderer placeholderRenderer;

	// Token: 0x04000BB9 RID: 3001
	[Token(Token = "0x4000963")]
	[FieldOffset(Offset = "0x290")]
	private MeshCollider placeholderCollider;

	// Token: 0x04000BBA RID: 3002
	[Token(Token = "0x4000964")]
	[FieldOffset(Offset = "0x0")]
	private static Material HighlightMaterial;

	// Token: 0x04000BBB RID: 3003
	[Token(Token = "0x4000965")]
	[FieldOffset(Offset = "0x8")]
	public static global::BuildingBlock.UpdateSkinWorkQueue updateSkinQueueClient;

	// Token: 0x04000BBC RID: 3004
	[Token(Token = "0x4000966")]
	[FieldOffset(Offset = "0x298")]
	public bool CullBushes;

	// Token: 0x04000BBD RID: 3005
	[Token(Token = "0x4000967")]
	[FieldOffset(Offset = "0x2A0")]
	[NonSerialized]
	public Construction blockDefinition;

	// Token: 0x04000BBE RID: 3006
	[Token(Token = "0x4000968")]
	[FieldOffset(Offset = "0x10")]
	private static Vector3[] outsideLookupOffsets;

	// Token: 0x0200011A RID: 282
	[Token(Token = "0x2000AAA")]
	public static class BlockFlags
	{
		// Token: 0x04000BBF RID: 3007
		[Token(Token = "0x4003F7C")]
		public const global::BaseEntity.Flags CanRotate = global::BaseEntity.Flags.Reserved1;

		// Token: 0x04000BC0 RID: 3008
		[Token(Token = "0x4003F7D")]
		public const global::BaseEntity.Flags CanDemolish = global::BaseEntity.Flags.Reserved2;
	}

	// Token: 0x0200011B RID: 283
	[Token(Token = "0x2000AAB")]
	public class UpdateSkinWorkQueue : ObjectWorkQueue<global::BuildingBlock>
	{
		// Token: 0x06001140 RID: 4416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C42")]
		[Address(RVA = "0x65BFD0", Offset = "0x65ADD0", VA = "0x18065BFD0", Slot = "6")]
		protected override void RunJob(global::BuildingBlock entity)
		{
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[Token(Token = "0x6004C43")]
		[Address(RVA = "0x65C010", Offset = "0x65AE10", VA = "0x18065C010", Slot = "5")]
		protected override bool ShouldAdd(global::BuildingBlock entity)
		{
			return default(bool);
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C44")]
		[Address(RVA = "0x65C020", Offset = "0x65AE20", VA = "0x18065C020")]
		public UpdateSkinWorkQueue()
		{
		}
	}

	// Token: 0x0200011C RID: 284
	[Token(Token = "0x2000AAC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass31_0
	{
		// Token: 0x06001143 RID: 4419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C45")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass31_0()
		{
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C46")]
		[Address(RVA = "0x65BFA0", Offset = "0x65ADA0", VA = "0x18065BFA0")]
		internal void <GradeChangingOptions>b__0(global::BasePlayer ply)
		{
		}

		// Token: 0x04000BC1 RID: 3009
		[Token(Token = "0x4003F7E")]
		[FieldOffset(Offset = "0x10")]
		public BuildingGrade.Enum iNewGrade;

		// Token: 0x04000BC2 RID: 3010
		[Token(Token = "0x4003F7F")]
		[FieldOffset(Offset = "0x18")]
		public global::BuildingBlock <>4__this;
	}
}
