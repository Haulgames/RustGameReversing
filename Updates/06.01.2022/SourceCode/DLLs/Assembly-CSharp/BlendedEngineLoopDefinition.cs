using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B1 RID: 689
[Token(Token = "0x20001E7")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xA6050", Offset = "0xA5450")]
public class BlendedEngineLoopDefinition : ScriptableObject
{
	// Token: 0x06001A2E RID: 6702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014C1")]
	[Address(RVA = "0x45C700", Offset = "0x45B500", VA = "0x18045C700")]
	public BlendedEngineLoopDefinition()
	{
	}

	// Token: 0x040014AB RID: 5291
	[Token(Token = "0x4001108")]
	[FieldOffset(Offset = "0x18")]
	public BlendedEngineLoopDefinition.EngineLoopDefinition[] engineLoops;

	// Token: 0x040014AC RID: 5292
	[Token(Token = "0x4001109")]
	[FieldOffset(Offset = "0x20")]
	public float minRPM;

	// Token: 0x040014AD RID: 5293
	[Token(Token = "0x400110A")]
	[FieldOffset(Offset = "0x24")]
	public float maxRPM;

	// Token: 0x040014AE RID: 5294
	[Token(Token = "0x400110B")]
	[FieldOffset(Offset = "0x28")]
	public float RPMChangeRateUp;

	// Token: 0x040014AF RID: 5295
	[Token(Token = "0x400110C")]
	[FieldOffset(Offset = "0x2C")]
	public float RPMChangeRateDown;

	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x2000AFF")]
	[Serializable]
	public class EngineLoopDefinition
	{
		// Token: 0x06001A2F RID: 6703 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		[Token(Token = "0x6004CEB")]
		[Address(RVA = "0x46FE20", Offset = "0x46EC20", VA = "0x18046FE20")]
		public float GetPitchForRPM(float targetRPM)
		{
			return 0f;
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEC")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public EngineLoopDefinition()
		{
		}

		// Token: 0x040014B0 RID: 5296
		[Token(Token = "0x40040B9")]
		[FieldOffset(Offset = "0x10")]
		public SoundDefinition soundDefinition;

		// Token: 0x040014B1 RID: 5297
		[Token(Token = "0x40040BA")]
		[FieldOffset(Offset = "0x18")]
		public float RPM;

		// Token: 0x040014B2 RID: 5298
		[Token(Token = "0x40040BB")]
		[FieldOffset(Offset = "0x1C")]
		public float startRPM;

		// Token: 0x040014B3 RID: 5299
		[Token(Token = "0x40040BC")]
		[FieldOffset(Offset = "0x20")]
		public float startFullRPM;

		// Token: 0x040014B4 RID: 5300
		[Token(Token = "0x40040BD")]
		[FieldOffset(Offset = "0x24")]
		public float stopFullRPM;

		// Token: 0x040014B5 RID: 5301
		[Token(Token = "0x40040BE")]
		[FieldOffset(Offset = "0x28")]
		public float stopRPM;
	}
}
