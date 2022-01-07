using System;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x020001E1 RID: 481
[Token(Token = "0x2000133")]
public class ArcadeEntity : BaseMonoBehaviour
{
	// Token: 0x06001693 RID: 5779 RVA: 0x0000C450 File Offset: 0x0000A650
	[Token(Token = "0x6001153")]
	[Address(RVA = "0x834BD0", Offset = "0x8339D0", VA = "0x180834BD0")]
	public bool IsMapEntity()
	{
		return default(bool);
	}

	// Token: 0x06001694 RID: 5780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001154")]
	[Address(RVA = "0x8357D0", Offset = "0x8345D0", VA = "0x1808357D0")]
	public void SendEntityMessage(string msg)
	{
	}

	// Token: 0x06001695 RID: 5781 RVA: 0x0000C468 File Offset: 0x0000A668
	[Token(Token = "0x6001155")]
	[Address(RVA = "0x8350C0", Offset = "0x833EC0", VA = "0x1808350C0", Slot = "6")]
	public virtual bool OnEntityMessage(string msg, bool predicted = false)
	{
		return default(bool);
	}

	// Token: 0x06001696 RID: 5782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001156")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void OnNewChild(ArcadeEntity newChild)
	{
	}

	// Token: 0x06001697 RID: 5783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001157")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void OnChildUnparented(ArcadeEntity lostChild)
	{
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001158")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void OnNewParent()
	{
	}

	// Token: 0x06001699 RID: 5785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001159")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void OnUnparented()
	{
	}

	// Token: 0x0600169A RID: 5786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115A")]
	[Address(RVA = "0x835440", Offset = "0x834240", VA = "0x180835440")]
	public void Remove()
	{
	}

	// Token: 0x0600169B RID: 5787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115B")]
	[Address(RVA = "0x835930", Offset = "0x834730", VA = "0x180835930")]
	public void SetArcadeParent(ArcadeEntity desiredParent)
	{
	}

	// Token: 0x0600169C RID: 5788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115C")]
	[Address(RVA = "0x8347A0", Offset = "0x8335A0", VA = "0x1808347A0", Slot = "7")]
	public virtual void Hurt(ArcadeEntity damageSource, float damage, Vector3 hitPos, Collider collider)
	{
	}

	// Token: 0x0600169D RID: 5789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115D")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "8")]
	public virtual void OnKilled()
	{
	}

	// Token: 0x0600169E RID: 5790 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600115E")]
	[Address(RVA = "0x834720", Offset = "0x833520", VA = "0x180834720")]
	public ArcadeEntity GetArcadeEntityFromCollider(Collider hitCol)
	{
		return null;
	}

	// Token: 0x0600169F RID: 5791 RVA: 0x0000C480 File Offset: 0x0000A680
	[Token(Token = "0x600115F")]
	[Address(RVA = "0x834B30", Offset = "0x833930", VA = "0x180834B30")]
	public bool IsAuthorative()
	{
		return default(bool);
	}

	// Token: 0x060016A0 RID: 5792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001160")]
	[Address(RVA = "0x835A70", Offset = "0x834870", VA = "0x180835A70")]
	public void SetLocalAuthorative(bool wants)
	{
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x060016A1 RID: 5793 RVA: 0x0000C498 File Offset: 0x0000A698
	// (set) Token: 0x060016A2 RID: 5794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000183")]
	public Vector3 positionLocal
	{
		[Token(Token = "0x6001161")]
		[Address(RVA = "0x2FA890", Offset = "0x2F9690", VA = "0x1802FA890")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001162")]
		[Address(RVA = "0x836120", Offset = "0x834F20", VA = "0x180836120")]
		set
		{
		}
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x060016A3 RID: 5795 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
	// (set) Token: 0x060016A4 RID: 5796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000184")]
	public Vector3 positionWorld
	{
		[Token(Token = "0x6001163")]
		[Address(RVA = "0x4B1A60", Offset = "0x4B0860", VA = "0x1804B1A60")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x836170", Offset = "0x834F70", VA = "0x180836170")]
		set
		{
		}
	}

	// Token: 0x060016A5 RID: 5797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001165")]
	[Address(RVA = "0x4EEDE0", Offset = "0x4EDBE0", VA = "0x1804EEDE0")]
	public void SetController(ArcadeEntityController newController)
	{
	}

	// Token: 0x060016A6 RID: 5798 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001166")]
	[Address(RVA = "0x4EED50", Offset = "0x4EDB50", VA = "0x1804EED50")]
	public ArcadeEntityController GetController()
	{
		return null;
	}

	// Token: 0x060016A7 RID: 5799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001167")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "9")]
	public virtual void AuthorativeThink(float delta)
	{
	}

	// Token: 0x060016A8 RID: 5800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001168")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "10")]
	public virtual void SlaveThink(float delta)
	{
	}

	// Token: 0x060016A9 RID: 5801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001169")]
	[Address(RVA = "0x835030", Offset = "0x833E30", VA = "0x180835030")]
	public void MarkDirty()
	{
	}

	// Token: 0x060016AA RID: 5802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116A")]
	[Address(RVA = "0x8347E0", Offset = "0x8335E0", VA = "0x1808347E0", Slot = "11")]
	public virtual void Initialize()
	{
	}

	// Token: 0x060016AB RID: 5803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116B")]
	[Address(RVA = "0x835040", Offset = "0x833E40", VA = "0x180835040")]
	public void OnDestroy()
	{
	}

	// Token: 0x060016AC RID: 5804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116C")]
	[Address(RVA = "0x835B50", Offset = "0x834950", VA = "0x180835B50")]
	public void Shutdown()
	{
	}

	// Token: 0x060016AD RID: 5805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116D")]
	[Address(RVA = "0x8358C0", Offset = "0x8346C0", VA = "0x1808358C0", Slot = "12")]
	public virtual void SetArcadeGameParent(BaseArcadeGame newParent)
	{
	}

	// Token: 0x060016AE RID: 5806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116E")]
	[Address(RVA = "0x835B10", Offset = "0x834910", VA = "0x180835B10")]
	public void SetupCollider(int type, Vector3 scale)
	{
	}

	// Token: 0x060016AF RID: 5807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116F")]
	[Address(RVA = "0x835DE0", Offset = "0x834BE0", VA = "0x180835DE0", Slot = "13")]
	public virtual void UpdateSave(bool force = false)
	{
	}

	// Token: 0x060016B0 RID: 5808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001170")]
	[Address(RVA = "0x834BE0", Offset = "0x8339E0", VA = "0x180834BE0", Slot = "14")]
	public virtual void Load(ArcadeGame.arcadeEnt proto)
	{
	}

	// Token: 0x060016B1 RID: 5809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001171")]
	[Address(RVA = "0x8350D0", Offset = "0x833ED0", VA = "0x1808350D0", Slot = "15")]
	public virtual void PostLoad()
	{
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001172")]
	[Address(RVA = "0x835A80", Offset = "0x834880", VA = "0x180835A80", Slot = "16")]
	public virtual void SetPositionWorld(Vector3 newPos)
	{
	}

	// Token: 0x060016B3 RID: 5811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001173")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "17")]
	public virtual void SetVisible(bool wantsVis)
	{
	}

	// Token: 0x060016B4 RID: 5812 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
	[Token(Token = "0x6001174")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "18")]
	public virtual bool IsVisible()
	{
		return default(bool);
	}

	// Token: 0x060016B5 RID: 5813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001175")]
	[Address(RVA = "0x8360B0", Offset = "0x834EB0", VA = "0x1808360B0")]
	public ArcadeEntity()
	{
	}

	// Token: 0x0400106D RID: 4205
	[Token(Token = "0x4000D36")]
	[FieldOffset(Offset = "0x18")]
	public uint id;

	// Token: 0x0400106E RID: 4206
	[Token(Token = "0x4000D37")]
	[FieldOffset(Offset = "0x1C")]
	public uint spriteID;

	// Token: 0x0400106F RID: 4207
	[Token(Token = "0x4000D38")]
	[FieldOffset(Offset = "0x20")]
	public uint soundID;

	// Token: 0x04001070 RID: 4208
	[Token(Token = "0x4000D39")]
	[FieldOffset(Offset = "0x24")]
	public bool visible;

	// Token: 0x04001071 RID: 4209
	[Token(Token = "0x4000D3A")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 heading;

	// Token: 0x04001072 RID: 4210
	[Token(Token = "0x4000D3B")]
	[FieldOffset(Offset = "0x34")]
	public bool isEnabled;

	// Token: 0x04001073 RID: 4211
	[Token(Token = "0x4000D3C")]
	[FieldOffset(Offset = "0x35")]
	public bool dirty;

	// Token: 0x04001074 RID: 4212
	[Token(Token = "0x4000D3D")]
	[FieldOffset(Offset = "0x38")]
	public float alpha;

	// Token: 0x04001075 RID: 4213
	[Token(Token = "0x4000D3E")]
	[FieldOffset(Offset = "0x40")]
	public BoxCollider boxCollider;

	// Token: 0x04001076 RID: 4214
	[Token(Token = "0x4000D3F")]
	[FieldOffset(Offset = "0x48")]
	public bool host;

	// Token: 0x04001077 RID: 4215
	[Token(Token = "0x4000D40")]
	[FieldOffset(Offset = "0x49")]
	public bool localAuthorativeOverride;

	// Token: 0x04001078 RID: 4216
	[Token(Token = "0x4000D41")]
	[FieldOffset(Offset = "0x50")]
	public ArcadeEntity arcadeEntityParent;

	// Token: 0x04001079 RID: 4217
	[Token(Token = "0x4000D42")]
	[FieldOffset(Offset = "0x58")]
	public uint prefabID;

	// Token: 0x0400107A RID: 4218
	[Token(Token = "0x4000D43")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x9E930", Offset = "0x9DD30")]
	public bool takesDamage;

	// Token: 0x0400107B RID: 4219
	[Token(Token = "0x4000D44")]
	[FieldOffset(Offset = "0x60")]
	public float health;

	// Token: 0x0400107C RID: 4220
	[Token(Token = "0x4000D45")]
	[FieldOffset(Offset = "0x64")]
	public float maxHealth;

	// Token: 0x0400107D RID: 4221
	[Token(Token = "0x4000D46")]
	[FieldOffset(Offset = "0x68")]
	[NonSerialized]
	public bool mapLoadedEntiy;

	// Token: 0x0400107E RID: 4222
	[Token(Token = "0x4000D47")]
	[FieldOffset(Offset = "0x70")]
	private Sprite spriteRef;

	// Token: 0x0400107F RID: 4223
	[Token(Token = "0x4000D48")]
	[FieldOffset(Offset = "0x78")]
	protected BaseArcadeGame arcadeGameParent;

	// Token: 0x04001080 RID: 4224
	[Token(Token = "0x4000D49")]
	[FieldOffset(Offset = "0x80")]
	private ArcadeEntityController controller;

	// Token: 0x04001081 RID: 4225
	[Token(Token = "0x4000D4A")]
	[FieldOffset(Offset = "0x0")]
	public static uint PARENTID_INVALID;

	// Token: 0x04001082 RID: 4226
	[Token(Token = "0x4000D4B")]
	[FieldOffset(Offset = "0x88")]
	[NonSerialized]
	public ArcadeGame.arcadeEnt savedState;
}
