using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A5 RID: 677
[Token(Token = "0x20001DF")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xA51E0", Offset = "0xA45E0")]
public class AmbienceDefinition : ScriptableObject
{
	// Token: 0x060019D8 RID: 6616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001470")]
	[Address(RVA = "0x823E10", Offset = "0x822C10", VA = "0x180823E10")]
	public AmbienceDefinition()
	{
	}

	// Token: 0x0400145A RID: 5210
	[Token(Token = "0x40010C4")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x748A0", Offset = "0x73CA0")]
	public List<SoundDefinition> sounds;

	// Token: 0x0400145B RID: 5211
	[Token(Token = "0x40010C5")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HorizontalAttribute", RVA = "0xA5370", Offset = "0xA4770")]
	public AmbienceDefinition.ValueRange stingFrequency;

	// Token: 0x0400145C RID: 5212
	[Token(Token = "0x40010C6")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xA5490", Offset = "0xA4890")]
	[InspectorFlags]
	public TerrainBiome.Enum biomes;

	// Token: 0x0400145D RID: 5213
	[Token(Token = "0x40010C7")]
	[FieldOffset(Offset = "0x2C")]
	[InspectorFlags]
	public TerrainTopology.Enum topologies;

	// Token: 0x0400145E RID: 5214
	[Token(Token = "0x40010C8")]
	[FieldOffset(Offset = "0x30")]
	public EnvironmentType environmentType;

	// Token: 0x0400145F RID: 5215
	[Token(Token = "0x40010C9")]
	[FieldOffset(Offset = "0x34")]
	public bool useEnvironmentType;

	// Token: 0x04001460 RID: 5216
	[Token(Token = "0x40010CA")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve time;

	// Token: 0x04001461 RID: 5217
	[Token(Token = "0x40010CB")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HorizontalAttribute", RVA = "0xA5370", Offset = "0xA4770")]
	public AmbienceDefinition.ValueRange rain;

	// Token: 0x04001462 RID: 5218
	[Token(Token = "0x40010CC")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "HorizontalAttribute", RVA = "0xA5370", Offset = "0xA4770")]
	public AmbienceDefinition.ValueRange wind;

	// Token: 0x04001463 RID: 5219
	[Token(Token = "0x40010CD")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "HorizontalAttribute", RVA = "0xA5370", Offset = "0xA4770")]
	public AmbienceDefinition.ValueRange snow;

	// Token: 0x020002A6 RID: 678
	[Token(Token = "0x2000AFB")]
	[Serializable]
	public class ValueRange
	{
		// Token: 0x060019D9 RID: 6617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE6")]
		[Address(RVA = "0x717150", Offset = "0x715F50", VA = "0x180717150")]
		public ValueRange(float min, float max)
		{
		}

		// Token: 0x04001464 RID: 5220
		[Token(Token = "0x40040AC")]
		[FieldOffset(Offset = "0x10")]
		public float min;

		// Token: 0x04001465 RID: 5221
		[Token(Token = "0x40040AD")]
		[FieldOffset(Offset = "0x14")]
		public float max;
	}
}
