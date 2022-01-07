using System;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009E9 RID: 2537
[Token(Token = "0x200071B")]
public class ContactsPanel : SingletonComponent<ContactsPanel>
{
	// Token: 0x06003BF2 RID: 15346 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003290")]
	[Address(RVA = "0x6CE9C0", Offset = "0x6CD7C0", VA = "0x1806CE9C0")]
	public RectTransform BucketFromType(RelationshipManager.RelationshipType type)
	{
		return null;
	}

	// Token: 0x06003BF3 RID: 15347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003291")]
	[Address(RVA = "0x6CEF60", Offset = "0x6CDD60", VA = "0x1806CEF60")]
	public void Repopulate()
	{
	}

	// Token: 0x06003BF4 RID: 15348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003292")]
	[Address(RVA = "0x6CF530", Offset = "0x6CE330", VA = "0x1806CF530")]
	public void SelectRelationshipType(int type)
	{
	}

	// Token: 0x06003BF5 RID: 15349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003293")]
	[Address(RVA = "0x6CED60", Offset = "0x6CDB60", VA = "0x1806CED60")]
	public static RelationshipManager.PlayerRelationshipInfo GetSelectedContact()
	{
		return null;
	}

	// Token: 0x06003BF6 RID: 15350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003294")]
	[Address(RVA = "0x6CEC80", Offset = "0x6CDA80", VA = "0x1806CEC80")]
	public void DeselectContact(ContactsEntry deselected)
	{
	}

	// Token: 0x06003BF7 RID: 15351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003295")]
	[Address(RVA = "0x6CEC90", Offset = "0x6CDA90", VA = "0x1806CEC90")]
	public static void DeselectContact()
	{
	}

	// Token: 0x06003BF8 RID: 15352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003296")]
	[Address(RVA = "0x6CE9F0", Offset = "0x6CD7F0", VA = "0x1806CE9F0")]
	public void ContactClicked(ContactsEntry selected)
	{
	}

	// Token: 0x06003BF9 RID: 15353 RVA: 0x00017D30 File Offset: 0x00015F30
	[Token(Token = "0x6003297")]
	[Address(RVA = "0x6CF680", Offset = "0x6CE480", VA = "0x1806CF680")]
	private bool WantsUpdate()
	{
		return default(bool);
	}

	// Token: 0x06003BFA RID: 15354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003298")]
	[Address(RVA = "0x6CF5E0", Offset = "0x6CE3E0", VA = "0x1806CF5E0")]
	public void Update()
	{
	}

	// Token: 0x06003BFB RID: 15355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003299")]
	[Address(RVA = "0x6CEEE0", Offset = "0x6CDCE0", VA = "0x1806CEEE0")]
	public void MarkDirty()
	{
	}

	// Token: 0x06003BFC RID: 15356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600329A")]
	[Address(RVA = "0x6CEEF0", Offset = "0x6CDCF0", VA = "0x1806CEEF0")]
	public static void ReceivedNewContacts()
	{
	}

	// Token: 0x06003BFD RID: 15357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600329B")]
	[Address(RVA = "0x506080", Offset = "0x504E80", VA = "0x180506080", Slot = "6")]
	protected override void Awake()
	{
	}

	// Token: 0x06003BFE RID: 15358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600329C")]
	[Address(RVA = "0x6CF6B0", Offset = "0x6CE4B0", VA = "0x1806CF6B0")]
	public ContactsPanel()
	{
	}

	// Token: 0x040038FC RID: 14588
	[Token(Token = "0x4002BD6")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform alliesBucket;

	// Token: 0x040038FD RID: 14589
	[Token(Token = "0x4002BD7")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform seenBucket;

	// Token: 0x040038FE RID: 14590
	[Token(Token = "0x4002BD8")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform enemiesBucket;

	// Token: 0x040038FF RID: 14591
	[Token(Token = "0x4002BD9")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform contentsBucket;

	// Token: 0x04003900 RID: 14592
	[Token(Token = "0x4002BDA")]
	[FieldOffset(Offset = "0x38")]
	public ContactsEntry contactEntryPrefab;

	// Token: 0x04003901 RID: 14593
	[Token(Token = "0x4002BDB")]
	[FieldOffset(Offset = "0x40")]
	public RawImage mugshotTest;

	// Token: 0x04003902 RID: 14594
	[Token(Token = "0x4002BDC")]
	[FieldOffset(Offset = "0x48")]
	public RawImage fullBodyTest;

	// Token: 0x04003903 RID: 14595
	[Token(Token = "0x4002BDD")]
	[FieldOffset(Offset = "0x50")]
	public RustButton[] filterButtons;

	// Token: 0x04003904 RID: 14596
	[Token(Token = "0x4002BDE")]
	[FieldOffset(Offset = "0x58")]
	public RelationshipManager.RelationshipType selectedRelationshipType;

	// Token: 0x04003905 RID: 14597
	[Token(Token = "0x4002BDF")]
	[FieldOffset(Offset = "0x60")]
	private ulong selectedPlayerID;

	// Token: 0x04003906 RID: 14598
	[Token(Token = "0x4002BE0")]
	[FieldOffset(Offset = "0x68")]
	private float nextUpdateTime;

	// Token: 0x04003907 RID: 14599
	[Token(Token = "0x4002BE1")]
	[FieldOffset(Offset = "0x6C")]
	private bool dirty;
}
