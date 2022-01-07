using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200047F RID: 1151
[Token(Token = "0x2000352")]
public class AudioInterceptComponent : MonoBehaviour
{
	// Token: 0x06002374 RID: 9076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D28")]
	[Address(RVA = "0x83D820", Offset = "0x83C620", VA = "0x18083D820")]
	private void OnAudioFilterRead(float[] data, int channels)
	{
	}

	// Token: 0x06002375 RID: 9077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D29")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public AudioInterceptComponent()
	{
	}

	// Token: 0x04001DFE RID: 7678
	[Token(Token = "0x4001884")]
	[FieldOffset(Offset = "0x18")]
	public OggEncoder Encoder;

	// Token: 0x04001DFF RID: 7679
	[Token(Token = "0x4001885")]
	[FieldOffset(Offset = "0x20")]
	private float[] strippedData;

	// Token: 0x04001E00 RID: 7680
	[Token(Token = "0x4001886")]
	[FieldOffset(Offset = "0x0")]
	[ClientVar]
	public static bool debugChannels;
}
