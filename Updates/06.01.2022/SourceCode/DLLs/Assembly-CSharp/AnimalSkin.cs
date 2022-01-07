using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000333 RID: 819
[Token(Token = "0x2000246")]
public class AnimalSkin : MonoBehaviour, IClientComponent
{
	// Token: 0x06001CBF RID: 7359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001719")]
	[Address(RVA = "0x831940", Offset = "0x830740", VA = "0x180831940")]
	private void Start()
	{
	}

	// Token: 0x06001CC0 RID: 7360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600171A")]
	[Address(RVA = "0x831710", Offset = "0x830510", VA = "0x180831710")]
	public void ChangeSkin(int iSkin)
	{
	}

	// Token: 0x06001CC1 RID: 7361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600171B")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public AnimalSkin()
	{
	}

	// Token: 0x040017BF RID: 6079
	[Token(Token = "0x400135D")]
	[FieldOffset(Offset = "0x18")]
	public SkinnedMeshRenderer[] animalMesh;

	// Token: 0x040017C0 RID: 6080
	[Token(Token = "0x400135E")]
	[FieldOffset(Offset = "0x20")]
	public AnimalMultiSkin[] animalSkins;

	// Token: 0x040017C1 RID: 6081
	[Token(Token = "0x400135F")]
	[FieldOffset(Offset = "0x28")]
	private Model model;

	// Token: 0x040017C2 RID: 6082
	[Token(Token = "0x4001360")]
	[FieldOffset(Offset = "0x30")]
	public bool dontRandomizeOnStart;
}
