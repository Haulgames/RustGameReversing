using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000A14 RID: 2580
[Token(Token = "0x200073E")]
public class BlueprintButton : MonoBehaviour, IClientComponent, IInventoryChanged, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	// Token: 0x06003CDD RID: 15581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600336F")]
	[Address(RVA = "0x45E040", Offset = "0x45CE40", VA = "0x18045E040")]
	public void Setup(ItemBlueprint bp, UIBlueprints parent)
	{
	}

	// Token: 0x06003CDE RID: 15582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003370")]
	[Address(RVA = "0x45D470", Offset = "0x45C270", VA = "0x18045D470")]
	public void Awake()
	{
	}

	// Token: 0x06003CDF RID: 15583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003371")]
	[Address(RVA = "0x45D4F0", Offset = "0x45C2F0", VA = "0x18045D4F0")]
	public void OnDestroy()
	{
	}

	// Token: 0x06003CE0 RID: 15584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003372")]
	[Address(RVA = "0x45E230", Offset = "0x45D030", VA = "0x18045E230")]
	private void Update()
	{
	}

	// Token: 0x06003CE1 RID: 15585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003373")]
	[Address(RVA = "0x45E200", Offset = "0x45D000", VA = "0x18045E200")]
	private void UpdateSelection()
	{
	}

	// Token: 0x06003CE2 RID: 15586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003374")]
	[Address(RVA = "0x45D840", Offset = "0x45C640", VA = "0x18045D840")]
	private void Refresh()
	{
	}

	// Token: 0x06003CE3 RID: 15587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003375")]
	[Address(RVA = "0x45D6A0", Offset = "0x45C4A0", VA = "0x18045D6A0", Slot = "4")]
	public void OnInventoryChanged()
	{
	}

	// Token: 0x06003CE4 RID: 15588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003376")]
	[Address(RVA = "0x45D6B0", Offset = "0x45C4B0", VA = "0x18045D6B0", Slot = "5")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x06003CE5 RID: 15589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003377")]
	[Address(RVA = "0x45D7C0", Offset = "0x45C5C0", VA = "0x18045D7C0")]
	public void OnToggleFavouriteClicked()
	{
	}

	// Token: 0x06003CE6 RID: 15590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003378")]
	[Address(RVA = "0x45D760", Offset = "0x45C560", VA = "0x18045D760", Slot = "6")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06003CE7 RID: 15591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003379")]
	[Address(RVA = "0x45D790", Offset = "0x45C590", VA = "0x18045D790", Slot = "7")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06003CE8 RID: 15592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600337A")]
	[Address(RVA = "0x45D5A0", Offset = "0x45C3A0", VA = "0x18045D5A0")]
	public void OnFavouriteHovered()
	{
	}

	// Token: 0x06003CE9 RID: 15593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600337B")]
	[Address(RVA = "0x45D620", Offset = "0x45C420", VA = "0x18045D620")]
	public void OnFavouriteUnhovered()
	{
	}

	// Token: 0x06003CEA RID: 15594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600337C")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public BlueprintButton()
	{
	}

	// Token: 0x04003A07 RID: 14855
	[Token(Token = "0x4002CCF")]
	[FieldOffset(Offset = "0x18")]
	public Image image;

	// Token: 0x04003A08 RID: 14856
	[Token(Token = "0x4002CD0")]
	[FieldOffset(Offset = "0x20")]
	public Image imageFavourite;

	// Token: 0x04003A09 RID: 14857
	[Token(Token = "0x4002CD1")]
	[FieldOffset(Offset = "0x28")]
	public Button button;

	// Token: 0x04003A0A RID: 14858
	[Token(Token = "0x4002CD2")]
	[FieldOffset(Offset = "0x30")]
	public CanvasGroup group;

	// Token: 0x04003A0B RID: 14859
	[Token(Token = "0x4002CD3")]
	[FieldOffset(Offset = "0x38")]
	public GameObject newNotification;

	// Token: 0x04003A0C RID: 14860
	[Token(Token = "0x4002CD4")]
	[FieldOffset(Offset = "0x40")]
	public GameObject lockedOverlay;

	// Token: 0x04003A0D RID: 14861
	[Token(Token = "0x4002CD5")]
	[FieldOffset(Offset = "0x48")]
	public Tooltip Tip;

	// Token: 0x04003A0E RID: 14862
	[Token(Token = "0x4002CD6")]
	[FieldOffset(Offset = "0x50")]
	public Image FavouriteIcon;

	// Token: 0x04003A0F RID: 14863
	[Token(Token = "0x4002CD7")]
	[FieldOffset(Offset = "0x58")]
	internal bool needsRefresh;

	// Token: 0x04003A10 RID: 14864
	[Token(Token = "0x4002CD8")]
	[FieldOffset(Offset = "0x60")]
	internal ItemBlueprint blueprint;

	// Token: 0x04003A11 RID: 14865
	[Token(Token = "0x4002CD9")]
	[FieldOffset(Offset = "0x68")]
	private UIBlueprints parentBlueprints;

	// Token: 0x04003A12 RID: 14866
	[Token(Token = "0x4002CDA")]
	[FieldOffset(Offset = "0x70")]
	private bool favourited;

	// Token: 0x04003A13 RID: 14867
	[Token(Token = "0x4002CDB")]
	[FieldOffset(Offset = "0x71")]
	private bool hovered;
}
