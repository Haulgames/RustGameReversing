using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000232 RID: 562
[Token(Token = "0x200017D")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x9FCD0", Offset = "0x9F0D0")]
public class ConversationData : ScriptableObject
{
	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x0600181D RID: 6173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000192")]
	public string providerName
	{
		[Token(Token = "0x60012D7")]
		[Address(RVA = "0x6D2070", Offset = "0x6D0E70", VA = "0x1806D2070")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600181E RID: 6174 RVA: 0x0000C960 File Offset: 0x0000AB60
	[Token(Token = "0x60012D8")]
	[Address(RVA = "0x6D1FC0", Offset = "0x6D0DC0", VA = "0x1806D1FC0")]
	public int GetSpeechNodeIndex(string speechShortName)
	{
		return 0;
	}

	// Token: 0x0600181F RID: 6175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D9")]
	[Address(RVA = "0x484650", Offset = "0x483450", VA = "0x180484650")]
	public ConversationData()
	{
	}

	// Token: 0x04001228 RID: 4648
	[Token(Token = "0x4000ED5")]
	[FieldOffset(Offset = "0x18")]
	public string shortname;

	// Token: 0x04001229 RID: 4649
	[Token(Token = "0x4000ED6")]
	[FieldOffset(Offset = "0x20")]
	public Translate.Phrase providerNameTranslated;

	// Token: 0x0400122A RID: 4650
	[Token(Token = "0x4000ED7")]
	[FieldOffset(Offset = "0x28")]
	public ConversationData.SpeechNode[] speeches;

	// Token: 0x02000233 RID: 563
	[Token(Token = "0x2000AEB")]
	[Serializable]
	public class ConversationCondition
	{
		// Token: 0x06001820 RID: 6176 RVA: 0x0000C978 File Offset: 0x0000AB78
		[Token(Token = "0x6004CC4")]
		[Address(RVA = "0x6D1E60", Offset = "0x6D0C60", VA = "0x1806D1E60")]
		public bool Passes(BasePlayer player, IConversationProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC5")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public ConversationCondition()
		{
		}

		// Token: 0x0400122B RID: 4651
		[Token(Token = "0x4004071")]
		[FieldOffset(Offset = "0x10")]
		public ConversationData.ConversationCondition.ConditionType conditionType;

		// Token: 0x0400122C RID: 4652
		[Token(Token = "0x4004072")]
		[FieldOffset(Offset = "0x14")]
		public uint conditionAmount;

		// Token: 0x0400122D RID: 4653
		[Token(Token = "0x4004073")]
		[FieldOffset(Offset = "0x18")]
		public bool inverse;

		// Token: 0x0400122E RID: 4654
		[Token(Token = "0x4004074")]
		[FieldOffset(Offset = "0x20")]
		public string failedSpeechNode;

		// Token: 0x02000234 RID: 564
		[Token(Token = "0x2000E69")]
		public enum ConditionType
		{
			// Token: 0x04001230 RID: 4656
			[Token(Token = "0x400500A")]
			NONE,
			// Token: 0x04001231 RID: 4657
			[Token(Token = "0x400500B")]
			HASHEALTH,
			// Token: 0x04001232 RID: 4658
			[Token(Token = "0x400500C")]
			HASSCRAP,
			// Token: 0x04001233 RID: 4659
			[Token(Token = "0x400500D")]
			PROVIDERBUSY,
			// Token: 0x04001234 RID: 4660
			[Token(Token = "0x400500E")]
			MISSIONCOMPLETE,
			// Token: 0x04001235 RID: 4661
			[Token(Token = "0x400500F")]
			MISSIONATTEMPTED,
			// Token: 0x04001236 RID: 4662
			[Token(Token = "0x4005010")]
			CANACCEPT
		}
	}

	// Token: 0x02000235 RID: 565
	[Token(Token = "0x2000AEC")]
	[Serializable]
	public class ResponseNode
	{
		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000700")]
		public string responseText
		{
			[Token(Token = "0x6004CC6")]
			[Address(RVA = "0x6DFAC0", Offset = "0x6DE8C0", VA = "0x1806DFAC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0000C990 File Offset: 0x0000AB90
		[Token(Token = "0x6004CC7")]
		[Address(RVA = "0x6DF8E0", Offset = "0x6DE6E0", VA = "0x1806DF8E0")]
		public bool PassesConditions(BasePlayer player, IConversationProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC8")]
		[Address(RVA = "0x6DF6E0", Offset = "0x6DE4E0", VA = "0x1806DF6E0")]
		public string GetFailedSpeechNode(BasePlayer player, IConversationProvider provider)
		{
			return null;
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC9")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public ResponseNode()
		{
		}

		// Token: 0x04001237 RID: 4663
		[Token(Token = "0x4004075")]
		[FieldOffset(Offset = "0x10")]
		public Translate.Phrase responseTextLocalized;

		// Token: 0x04001238 RID: 4664
		[Token(Token = "0x4004076")]
		[FieldOffset(Offset = "0x18")]
		public ConversationData.ConversationCondition[] conditions;

		// Token: 0x04001239 RID: 4665
		[Token(Token = "0x4004077")]
		[FieldOffset(Offset = "0x20")]
		public string actionString;

		// Token: 0x0400123A RID: 4666
		[Token(Token = "0x4004078")]
		[FieldOffset(Offset = "0x28")]
		public string resultingSpeechNode;
	}

	// Token: 0x02000236 RID: 566
	[Token(Token = "0x2000AED")]
	[Serializable]
	public class SpeechNode
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000701")]
		public string statement
		{
			[Token(Token = "0x6004CCA")]
			[Address(RVA = "0x6DFAF0", Offset = "0x6DE8F0", VA = "0x1806DFAF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CCB")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public SpeechNode()
		{
		}

		// Token: 0x0400123B RID: 4667
		[Token(Token = "0x4004079")]
		[FieldOffset(Offset = "0x10")]
		public string shortname;

		// Token: 0x0400123C RID: 4668
		[Token(Token = "0x400407A")]
		[FieldOffset(Offset = "0x18")]
		public Translate.Phrase statementLocalized;

		// Token: 0x0400123D RID: 4669
		[Token(Token = "0x400407B")]
		[FieldOffset(Offset = "0x20")]
		public ConversationData.ResponseNode[] responses;

		// Token: 0x0400123E RID: 4670
		[Token(Token = "0x400407C")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 nodePosition;
	}
}
