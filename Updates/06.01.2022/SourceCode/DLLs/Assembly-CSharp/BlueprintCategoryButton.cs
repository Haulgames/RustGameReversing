using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000A15 RID: 2581
[Token(Token = "0x200073F")]
public class BlueprintCategoryButton : MonoBehaviour, IInventoryChanged, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x06003CEB RID: 15595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600337D")]
	[Address(RVA = "0x45E490", Offset = "0x45D290", VA = "0x18045E490")]
	private void OnEnable()
	{
	}

	// Token: 0x06003CEC RID: 15596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600337E")]
	[Address(RVA = "0x45E3E0", Offset = "0x45D1E0", VA = "0x18045E3E0")]
	private void OnDisable()
	{
	}

	// Token: 0x06003CED RID: 15597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600337F")]
	[Address(RVA = "0x45E880", Offset = "0x45D680", VA = "0x18045E880")]
	private void Update()
	{
	}

	// Token: 0x06003CEE RID: 15598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003380")]
	[Address(RVA = "0x45E510", Offset = "0x45D310", VA = "0x18045E510", Slot = "4")]
	public void OnInventoryChanged()
	{
	}

	// Token: 0x06003CEF RID: 15599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003381")]
	[Address(RVA = "0x45E780", Offset = "0x45D580", VA = "0x18045E780")]
	private void UpdateValue()
	{
	}

	// Token: 0x06003CF0 RID: 15600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003382")]
	[Address(RVA = "0x45E9B0", Offset = "0x45D7B0", VA = "0x18045E9B0")]
	public void ValueChanged(bool b)
	{
	}

	// Token: 0x06003CF1 RID: 15601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003383")]
	[Address(RVA = "0x45E520", Offset = "0x45D320", VA = "0x18045E520", Slot = "5")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06003CF2 RID: 15602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003384")]
	[Address(RVA = "0x45E700", Offset = "0x45D500", VA = "0x18045E700", Slot = "6")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06003CF3 RID: 15603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003385")]
	[Address(RVA = "0x45E2B0", Offset = "0x45D0B0", VA = "0x18045E2B0")]
	public void DoBounceAnim()
	{
	}

	// Token: 0x06003CF4 RID: 15604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003386")]
	[Address(RVA = "0x45ED40", Offset = "0x45DB40", VA = "0x18045ED40")]
	public BlueprintCategoryButton()
	{
	}

	// Token: 0x04003A14 RID: 14868
	[Token(Token = "0x4002CDC")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI amountLabel;

	// Token: 0x04003A15 RID: 14869
	[Token(Token = "0x4002CDD")]
	[FieldOffset(Offset = "0x20")]
	public ItemCategory Category;

	// Token: 0x04003A16 RID: 14870
	[Token(Token = "0x4002CDE")]
	[FieldOffset(Offset = "0x24")]
	public bool AlwaysShow;

	// Token: 0x04003A17 RID: 14871
	[Token(Token = "0x4002CDF")]
	[FieldOffset(Offset = "0x25")]
	public bool ShowItemCount;

	// Token: 0x04003A18 RID: 14872
	[Token(Token = "0x4002CE0")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BackgroundHighlight;

	// Token: 0x04003A19 RID: 14873
	[Token(Token = "0x4002CE1")]
	[FieldOffset(Offset = "0x30")]
	public SoundDefinition clickSound;

	// Token: 0x04003A1A RID: 14874
	[Token(Token = "0x4002CE2")]
	[FieldOffset(Offset = "0x38")]
	public SoundDefinition hoverSound;

	// Token: 0x04003A1B RID: 14875
	[Token(Token = "0x4002CE3")]
	[FieldOffset(Offset = "0x40")]
	private bool needsRefresh;

	// Token: 0x04003A1C RID: 14876
	[Token(Token = "0x4002CE4")]
	[FieldOffset(Offset = "0x44")]
	private int CurrentAmount;

	// Token: 0x04003A1D RID: 14877
	[Token(Token = "0x4002CE5")]
	[FieldOffset(Offset = "0x48")]
	private bool Selected;
}
