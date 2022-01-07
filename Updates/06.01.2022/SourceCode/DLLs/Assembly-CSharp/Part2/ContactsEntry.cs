using System;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009E8 RID: 2536
[Token(Token = "0x200071A")]
public class ContactsEntry : MonoBehaviour
{
	// Token: 0x06003BF0 RID: 15344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600328E")]
	[Address(RVA = "0x6CE860", Offset = "0x6CD660", VA = "0x1806CE860")]
	public void Setup(RelationshipManager.PlayerRelationshipInfo newInfo)
	{
	}

	// Token: 0x06003BF1 RID: 15345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600328F")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public ContactsEntry()
	{
	}

	// Token: 0x040038F8 RID: 14584
	[Token(Token = "0x4002BD2")]
	[FieldOffset(Offset = "0x18")]
	public RustText nameText;

	// Token: 0x040038F9 RID: 14585
	[Token(Token = "0x4002BD3")]
	[FieldOffset(Offset = "0x20")]
	public RustText reputationText;

	// Token: 0x040038FA RID: 14586
	[Token(Token = "0x4002BD4")]
	[FieldOffset(Offset = "0x28")]
	public RawImage smallMugshot;

	// Token: 0x040038FB RID: 14587
	[Token(Token = "0x4002BD5")]
	[FieldOffset(Offset = "0x30")]
	public RelationshipManager.PlayerRelationshipInfo info;
}
