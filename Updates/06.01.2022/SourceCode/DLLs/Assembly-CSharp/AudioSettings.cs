using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x0200033C RID: 828
[Token(Token = "0x200024E")]
public class AudioSettings : MonoBehaviour
{
	// Token: 0x06001CE8 RID: 7400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001741")]
	[Address(RVA = "0x83DB70", Offset = "0x83C970", VA = "0x18083DB70")]
	private void Update()
	{
	}

	// Token: 0x06001CE9 RID: 7401 RVA: 0x0000E178 File Offset: 0x0000C378
	[Token(Token = "0x6001742")]
	[Address(RVA = "0x83DAF0", Offset = "0x83C8F0", VA = "0x18083DAF0")]
	private float LinearToDecibel(float linear)
	{
		return 0f;
	}

	// Token: 0x06001CEA RID: 7402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001743")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public AudioSettings()
	{
	}

	// Token: 0x04001807 RID: 6151
	[Token(Token = "0x40013A3")]
	[FieldOffset(Offset = "0x18")]
	public AudioMixer mixer;
}
