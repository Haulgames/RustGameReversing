using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000238 RID: 568
[Token(Token = "0x200017F")]
public class ConversationManager : MonoBehaviour
{
	// Token: 0x06001829 RID: 6185 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
	[Token(Token = "0x60012DB")]
	[Address(RVA = "0x6D2390", Offset = "0x6D1190", VA = "0x1806D2390")]
	public static bool InConversation()
	{
		return default(bool);
	}

	// Token: 0x0600182A RID: 6186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DC")]
	[Address(RVA = "0x6D2350", Offset = "0x6D1150", VA = "0x1806D2350")]
	public static ConversationManager.Conversation GetActiveConversation()
	{
		return null;
	}

	// Token: 0x0600182B RID: 6187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012DD")]
	[Address(RVA = "0x6D2250", Offset = "0x6D1050", VA = "0x1806D2250")]
	public static void FastForward()
	{
	}

	// Token: 0x0600182C RID: 6188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012DE")]
	[Address(RVA = "0x6D2400", Offset = "0x6D1200", VA = "0x1806D2400")]
	public static void ModifyCamera()
	{
	}

	// Token: 0x0600182D RID: 6189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012DF")]
	[Address(RVA = "0x6D2730", Offset = "0x6D1530", VA = "0x1806D2730")]
	public static void StartConversation(ConversationData conversationData, IConversationProvider provider, string startIndex = "intro")
	{
	}

	// Token: 0x0600182E RID: 6190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E0")]
	[Address(RVA = "0x6D20A0", Offset = "0x6D0EA0", VA = "0x1806D20A0")]
	public static void CancelConversation(bool fromServer)
	{
	}

	// Token: 0x0600182F RID: 6191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E1")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public ConversationManager()
	{
	}

	// Token: 0x04001242 RID: 4674
	[Token(Token = "0x4000EDB")]
	[FieldOffset(Offset = "0x16E0")]
	private static ConversationManager.Conversation activeConversation;

	// Token: 0x02000239 RID: 569
	[Token(Token = "0x2000AEE")]
	public class Conversation : MonoBehaviour
	{
		// Token: 0x06001830 RID: 6192 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		[Token(Token = "0x6004CCC")]
		[Address(RVA = "0x6D29E0", Offset = "0x6D17E0", VA = "0x1806D29E0")]
		public int GetSpeechNodeIndex(string name)
		{
			return 0;
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		[Token(Token = "0x6004CCD")]
		[Address(RVA = "0x6D29D0", Offset = "0x6D17D0", VA = "0x1806D29D0")]
		public int GetSpeechCharacterIndex()
		{
			return 0;
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		[Token(Token = "0x6004CCE")]
		[Address(RVA = "0x6D2B00", Offset = "0x6D1900", VA = "0x1806D2B00")]
		public bool IsTalking()
		{
			return default(bool);
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CCF")]
		[Address(RVA = "0x6D2C30", Offset = "0x6D1A30", VA = "0x1806D2C30")]
		public void SwitchToSpeechNode(int index)
		{
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CD0")]
		[Address(RVA = "0x6D2B80", Offset = "0x6D1980", VA = "0x1806D2B80")]
		public void ResponsePressed(int index)
		{
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x0000CA08 File Offset: 0x0000AC08
		[Token(Token = "0x6004CD1")]
		[Address(RVA = "0x6D29C0", Offset = "0x6D17C0", VA = "0x1806D29C0")]
		public float GetConversationAge()
		{
			return 0f;
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0000CA20 File Offset: 0x0000AC20
		[Token(Token = "0x6004CD2")]
		[Address(RVA = "0x6D2AF0", Offset = "0x6D18F0", VA = "0x1806D2AF0")]
		public bool HasConversationStarted()
		{
			return default(bool);
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CD3")]
		[Address(RVA = "0x6D2E20", Offset = "0x6D1C20", VA = "0x1806D2E20")]
		public void Update()
		{
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CD4")]
		[Address(RVA = "0x6D2950", Offset = "0x6D1750", VA = "0x1806D2950")]
		public void FastFowardSpeech()
		{
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CD5")]
		[Address(RVA = "0x6D2C40", Offset = "0x6D1A40", VA = "0x1806D2C40")]
		public void UpdateSpeechCharacterIndex(float delta)
		{
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CD6")]
		[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
		public Conversation()
		{
		}

		// Token: 0x04001243 RID: 4675
		[Token(Token = "0x400407D")]
		[FieldOffset(Offset = "0x18")]
		public ConversationData data;

		// Token: 0x04001244 RID: 4676
		[Token(Token = "0x400407E")]
		[FieldOffset(Offset = "0x20")]
		public int currentSpeechNodeIndex;

		// Token: 0x04001245 RID: 4677
		[Token(Token = "0x400407F")]
		[FieldOffset(Offset = "0x28")]
		public IConversationProvider provider;

		// Token: 0x04001246 RID: 4678
		[Token(Token = "0x4004080")]
		[FieldOffset(Offset = "0x30")]
		private float age;

		// Token: 0x04001247 RID: 4679
		[Token(Token = "0x4004081")]
		[FieldOffset(Offset = "0x34")]
		private float speechNodeAge;

		// Token: 0x04001248 RID: 4680
		[Token(Token = "0x4004082")]
		[FieldOffset(Offset = "0x38")]
		private int speechCharacterIndex;

		// Token: 0x04001249 RID: 4681
		[Token(Token = "0x4004083")]
		[FieldOffset(Offset = "0x3C")]
		private float timeOnChar;
	}
}
