using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008C1 RID: 2241
[Token(Token = "0x2000651")]
[ExecuteInEditMode]
public class AtmosphereVolume : MonoBehaviour
{
	// Token: 0x06003661 RID: 13921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DB8")]
	[Address(RVA = "0x83C360", Offset = "0x83B160", VA = "0x18083C360")]
	private void OnEnable()
	{
	}

	// Token: 0x06003662 RID: 13922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DB9")]
	[Address(RVA = "0x83C230", Offset = "0x83B030", VA = "0x18083C230")]
	private void OnDisable()
	{
	}

	// Token: 0x06003663 RID: 13923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DBA")]
	[Address(RVA = "0x83C460", Offset = "0x83B260", VA = "0x18083C460")]
	public AtmosphereVolume()
	{
	}

	// Token: 0x040032D6 RID: 13014
	[Token(Token = "0x4002731")]
	[FieldOffset(Offset = "0x18")]
	public float MaxVisibleDistance;

	// Token: 0x040032D7 RID: 13015
	[Token(Token = "0x4002732")]
	[FieldOffset(Offset = "0x1C")]
	public float BoundsAttenuationDecay;

	// Token: 0x040032D8 RID: 13016
	[Token(Token = "0x4002733")]
	[FieldOffset(Offset = "0x20")]
	public FogSettings FogSettings;
}
