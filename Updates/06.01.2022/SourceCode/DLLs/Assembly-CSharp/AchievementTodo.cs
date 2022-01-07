using System;
using Il2CppDummyDll;
using Steamworks.Data;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000977 RID: 2423
[Token(Token = "0x20006CA")]
public class AchievementTodo : BaseMonoBehaviour
{
	// Token: 0x06003977 RID: 14711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003061")]
	[Address(RVA = "0x81A3C0", Offset = "0x8191C0", VA = "0x18081A3C0")]
	private void Awake()
	{
	}

	// Token: 0x06003978 RID: 14712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003062")]
	[Address(RVA = "0x81A620", Offset = "0x819420", VA = "0x18081A620")]
	private void OnAchievementStateChanged(Achievement ach, int currentProgress, int progress)
	{
	}

	// Token: 0x06003979 RID: 14713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003063")]
	[Address(RVA = "0x81A6E0", Offset = "0x8194E0", VA = "0x18081A6E0")]
	internal void Unlock()
	{
	}

	// Token: 0x0600397A RID: 14714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003064")]
	[Address(RVA = "0x81A430", Offset = "0x819230", VA = "0x18081A430")]
	internal void Init(AchievementGroup.AchievementItem item)
	{
	}

	// Token: 0x0600397B RID: 14715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003065")]
	[Address(RVA = "0x81A9C0", Offset = "0x8197C0", VA = "0x18081A9C0")]
	private void UpdateState()
	{
	}

	// Token: 0x0600397C RID: 14716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003066")]
	[Address(RVA = "0x46B5C0", Offset = "0x46A3C0", VA = "0x18046B5C0")]
	public AchievementTodo()
	{
	}

	// Token: 0x04003649 RID: 13897
	[Token(Token = "0x4002991")]
	[FieldOffset(Offset = "0x18")]
	public Text text;

	// Token: 0x0400364A RID: 13898
	[Token(Token = "0x4002992")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform checkIcon;

	// Token: 0x0400364B RID: 13899
	[Token(Token = "0x4002993")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform checkBox;

	// Token: 0x0400364C RID: 13900
	[Token(Token = "0x4002994")]
	[FieldOffset(Offset = "0x30")]
	public UnityEngine.Color AliveColor;

	// Token: 0x0400364D RID: 13901
	[Token(Token = "0x4002995")]
	[FieldOffset(Offset = "0x40")]
	public UnityEngine.Color DeadColor;

	// Token: 0x0400364E RID: 13902
	[Token(Token = "0x4002996")]
	[FieldOffset(Offset = "0x50")]
	public UnityEngine.Color HighlightColor;

	// Token: 0x0400364F RID: 13903
	[Token(Token = "0x4002997")]
	[FieldOffset(Offset = "0x60")]
	private AchievementGroup.AchievementItem Item;

	// Token: 0x04003650 RID: 13904
	[Token(Token = "0x4002998")]
	[FieldOffset(Offset = "0x68")]
	internal bool State;
}
