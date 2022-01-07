using System;
using Il2CppDummyDll;
using UnityEngine.AI;

// Token: 0x020004B2 RID: 1202
[Token(Token = "0x200037A")]
public class Barricade : DecayEntity
{
	// Token: 0x06002480 RID: 9344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E17")]
	[Address(RVA = "0x844740", Offset = "0x843540", VA = "0x180844740")]
	public Barricade()
	{
	}

	// Token: 0x04001ECE RID: 7886
	[Token(Token = "0x4001928")]
	[FieldOffset(Offset = "0x250")]
	public float reflectDamage;

	// Token: 0x04001ECF RID: 7887
	[Token(Token = "0x4001929")]
	[FieldOffset(Offset = "0x258")]
	public GameObjectRef reflectEffect;

	// Token: 0x04001ED0 RID: 7888
	[Token(Token = "0x400192A")]
	[FieldOffset(Offset = "0x260")]
	public bool canNpcSmash;

	// Token: 0x04001ED1 RID: 7889
	[Token(Token = "0x400192B")]
	[FieldOffset(Offset = "0x268")]
	public NavMeshModifierVolume NavMeshVolumeAnimals;

	// Token: 0x04001ED2 RID: 7890
	[Token(Token = "0x400192C")]
	[FieldOffset(Offset = "0x270")]
	public NavMeshModifierVolume NavMeshVolumeHumanoids;
}
