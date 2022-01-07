using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B3E RID: 2878
[Token(Token = "0x2000809")]
public class ConvarComponent : MonoBehaviour
{
	// Token: 0x060042FF RID: 17151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600388B")]
	[Address(RVA = "0x6D1340", Offset = "0x6D0140", VA = "0x1806D1340")]
	protected void OnEnable()
	{
	}

	// Token: 0x06004300 RID: 17152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600388C")]
	[Address(RVA = "0x6D1140", Offset = "0x6CFF40", VA = "0x1806D1140")]
	protected void OnDisable()
	{
	}

	// Token: 0x06004301 RID: 17153 RVA: 0x00019050 File Offset: 0x00017250
	[Token(Token = "0x600388D")]
	[Address(RVA = "0x6D1460", Offset = "0x6D0260", VA = "0x1806D1460")]
	private bool ShouldRun()
	{
		return default(bool);
	}

	// Token: 0x06004302 RID: 17154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600388E")]
	[Address(RVA = "0x6D1470", Offset = "0x6D0270", VA = "0x1806D1470")]
	public ConvarComponent()
	{
	}

	// Token: 0x04004027 RID: 16423
	[Token(Token = "0x4003178")]
	[FieldOffset(Offset = "0x18")]
	public bool runOnServer;

	// Token: 0x04004028 RID: 16424
	[Token(Token = "0x4003179")]
	[FieldOffset(Offset = "0x19")]
	public bool runOnClient;

	// Token: 0x04004029 RID: 16425
	[Token(Token = "0x400317A")]
	[FieldOffset(Offset = "0x20")]
	public List<ConvarComponent.ConvarEvent> List;

	// Token: 0x02000B3F RID: 2879
	[Token(Token = "0x2000D5E")]
	[Serializable]
	public class ConvarEvent
	{
		// Token: 0x06004303 RID: 17155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E9")]
		[Address(RVA = "0x6D15B0", Offset = "0x6D03B0", VA = "0x1806D15B0")]
		public void OnEnable()
		{
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051EA")]
		[Address(RVA = "0x6D1760", Offset = "0x6D0560", VA = "0x1806D1760")]
		private void cmd_OnValueChanged(ConsoleSystem.Command obj)
		{
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051EB")]
		[Address(RVA = "0x6D14F0", Offset = "0x6D02F0", VA = "0x1806D14F0")]
		public void OnDisable()
		{
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051EC")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public ConvarEvent()
		{
		}

		// Token: 0x0400402A RID: 16426
		[Token(Token = "0x4004B99")]
		[FieldOffset(Offset = "0x10")]
		public string convar;

		// Token: 0x0400402B RID: 16427
		[Token(Token = "0x4004B9A")]
		[FieldOffset(Offset = "0x18")]
		public string on;

		// Token: 0x0400402C RID: 16428
		[Token(Token = "0x4004B9B")]
		[FieldOffset(Offset = "0x20")]
		public MonoBehaviour component;

		// Token: 0x0400402D RID: 16429
		[Token(Token = "0x4004B9C")]
		[FieldOffset(Offset = "0x28")]
		internal ConsoleSystem.Command cmd;
	}
}
