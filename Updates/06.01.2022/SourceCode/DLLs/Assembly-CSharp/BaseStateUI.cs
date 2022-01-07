using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using ProtoBuf;
using Rust.UI;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000957 RID: 2391
[Token(Token = "0x20006AE")]
public class BaseStateUI : MonoBehaviour
{
	// Token: 0x170004A9 RID: 1193
	// (get) Token: 0x060038FD RID: 14589 RVA: 0x00017748 File Offset: 0x00015948
	// (set) Token: 0x060038FE RID: 14590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000423")]
	public int InputEntityMemorySlot
	{
		[Token(Token = "0x6002FF9")]
		[Address(RVA = "0x9A0CE0", Offset = "0x99FAE0", VA = "0x1809A0CE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002FFA")]
		[Address(RVA = "0x9A0CF0", Offset = "0x99FAF0", VA = "0x1809A0CF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x060038FF RID: 14591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FFB")]
	[Address(RVA = "0x9A0140", Offset = "0x99EF40", VA = "0x1809A0140", Slot = "4")]
	public virtual void Init(AIState stateType, int stateContainerID)
	{
	}

	// Token: 0x06003900 RID: 14592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FFC")]
	[Address(RVA = "0x99FA70", Offset = "0x99E870", VA = "0x18099FA70")]
	public void ClearEvents()
	{
	}

	// Token: 0x06003901 RID: 14593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FFD")]
	[Address(RVA = "0x99F710", Offset = "0x99E510", VA = "0x18099F710")]
	public BaseEventUI AddNewEvent(AIEventType eventType)
	{
		return null;
	}

	// Token: 0x06003902 RID: 14594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FFE")]
	[Address(RVA = "0x9A05E0", Offset = "0x99F3E0", VA = "0x1809A05E0")]
	public void PingTriggeringEvent(int id)
	{
	}

	// Token: 0x06003903 RID: 14595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FFF")]
	[Address(RVA = "0x99FEE0", Offset = "0x99ECE0", VA = "0x18099FEE0")]
	private BaseEventUI GetEvent(int id)
	{
		return null;
	}

	// Token: 0x06003904 RID: 14596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003000")]
	[Address(RVA = "0x9A0B40", Offset = "0x99F940", VA = "0x1809A0B40")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xC6A00", Offset = "0xC5E00")]
	private IEnumerator ScrollToBottom()
	{
		return null;
	}

	// Token: 0x06003905 RID: 14597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003001")]
	[Address(RVA = "0x9A0330", Offset = "0x99F130", VA = "0x1809A0330")]
	public void Load(ProtoBuf.AIStateContainer container)
	{
	}

	// Token: 0x06003906 RID: 14598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003002")]
	[Address(RVA = "0x9A0BB0", Offset = "0x99F9B0", VA = "0x1809A0BB0")]
	public void SetActiveDebugState(bool flag)
	{
	}

	// Token: 0x06003907 RID: 14599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003003")]
	[Address(RVA = "0x9A0800", Offset = "0x99F600", VA = "0x1809A0800", Slot = "5")]
	public virtual ProtoBuf.AIStateContainer Save()
	{
		return null;
	}

	// Token: 0x06003908 RID: 14600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003004")]
	[Address(RVA = "0x99FDA0", Offset = "0x99EBA0", VA = "0x18099FDA0")]
	private Transform GetEventPrefab(AIEventType eventType)
	{
		return null;
	}

	// Token: 0x06003909 RID: 14601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003005")]
	[Address(RVA = "0x99F600", Offset = "0x99E400", VA = "0x18099F600")]
	private void AddNewEventButton()
	{
	}

	// Token: 0x0600390A RID: 14602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003006")]
	[Address(RVA = "0x99FCD0", Offset = "0x99EAD0", VA = "0x18099FCD0")]
	public void DeleteStateClicked()
	{
	}

	// Token: 0x0600390B RID: 14603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003007")]
	[Address(RVA = "0x99FC60", Offset = "0x99EA60", VA = "0x18099FC60")]
	public void DeleteEvent(BaseEventUI eventUI)
	{
	}

	// Token: 0x0600390C RID: 14604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003008")]
	[Address(RVA = "0x9A0580", Offset = "0x99F380", VA = "0x1809A0580")]
	public void MoveEventUp(BaseEventUI eventUI)
	{
	}

	// Token: 0x0600390D RID: 14605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003009")]
	[Address(RVA = "0x9A04F0", Offset = "0x99F2F0", VA = "0x1809A04F0")]
	public void MoveEventDown(BaseEventUI eventUI)
	{
	}

	// Token: 0x0600390E RID: 14606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600300A")]
	[Address(RVA = "0x9A0CC0", Offset = "0x99FAC0", VA = "0x1809A0CC0")]
	public BaseStateUI()
	{
	}

	// Token: 0x04003601 RID: 13825
	[Token(Token = "0x4002954")]
	[FieldOffset(Offset = "0x18")]
	public Rust.UI.Dropdown DropdownInputMemorySlot;

	// Token: 0x04003602 RID: 13826
	[Token(Token = "0x4002955")]
	[FieldOffset(Offset = "0x20")]
	public Transform PrefabAddNewEvent;

	// Token: 0x04003603 RID: 13827
	[Token(Token = "0x4002956")]
	[FieldOffset(Offset = "0x28")]
	public Transform PrefabTimerEvent;

	// Token: 0x04003604 RID: 13828
	[Token(Token = "0x4002957")]
	[FieldOffset(Offset = "0x30")]
	public Transform PrefabPlayerDetectedEvent;

	// Token: 0x04003605 RID: 13829
	[Token(Token = "0x4002958")]
	[FieldOffset(Offset = "0x38")]
	public Transform PrefabStateErrorEvent;

	// Token: 0x04003606 RID: 13830
	[Token(Token = "0x4002959")]
	[FieldOffset(Offset = "0x40")]
	public Transform PrefabStateFinishedEvent;

	// Token: 0x04003607 RID: 13831
	[Token(Token = "0x400295A")]
	[FieldOffset(Offset = "0x48")]
	public Transform PrefabAttackedEvent;

	// Token: 0x04003608 RID: 13832
	[Token(Token = "0x400295B")]
	[FieldOffset(Offset = "0x50")]
	public Transform PrefabInAttackRangeEvent;

	// Token: 0x04003609 RID: 13833
	[Token(Token = "0x400295C")]
	[FieldOffset(Offset = "0x58")]
	public Transform PrefabHealthBelowEvent;

	// Token: 0x0400360A RID: 13834
	[Token(Token = "0x400295D")]
	[FieldOffset(Offset = "0x60")]
	public Transform PrefabInRangeEvent;

	// Token: 0x0400360B RID: 13835
	[Token(Token = "0x400295E")]
	[FieldOffset(Offset = "0x68")]
	public Transform PrefabPerformedAttackEvent;

	// Token: 0x0400360C RID: 13836
	[Token(Token = "0x400295F")]
	[FieldOffset(Offset = "0x70")]
	public Transform PrefabTirednessAboveEvent;

	// Token: 0x0400360D RID: 13837
	[Token(Token = "0x4002960")]
	[FieldOffset(Offset = "0x78")]
	public Transform PrefabHungerAboveEvent;

	// Token: 0x0400360E RID: 13838
	[Token(Token = "0x4002961")]
	[FieldOffset(Offset = "0x80")]
	public Transform PrefabThreatDetectevEvent;

	// Token: 0x0400360F RID: 13839
	[Token(Token = "0x4002962")]
	[FieldOffset(Offset = "0x88")]
	public Transform PrefabTargetDetectevEvent;

	// Token: 0x04003610 RID: 13840
	[Token(Token = "0x4002963")]
	[FieldOffset(Offset = "0x90")]
	public Transform PrefabAmmoBelowEvent;

	// Token: 0x04003611 RID: 13841
	[Token(Token = "0x4002964")]
	[FieldOffset(Offset = "0x98")]
	public Transform PrefabBestTargetDetectedEvent;

	// Token: 0x04003612 RID: 13842
	[Token(Token = "0x4002965")]
	[FieldOffset(Offset = "0xA0")]
	public Transform PrefabIsVisibleEvent;

	// Token: 0x04003613 RID: 13843
	[Token(Token = "0x4002966")]
	[FieldOffset(Offset = "0xA8")]
	public Transform PrefabAttackTickEvent;

	// Token: 0x04003614 RID: 13844
	[Token(Token = "0x4002967")]
	[FieldOffset(Offset = "0xB0")]
	public Transform PrefabIsMountedEvent;

	// Token: 0x04003615 RID: 13845
	[Token(Token = "0x4002968")]
	[FieldOffset(Offset = "0xB8")]
	public Transform PrefabAndEvent;

	// Token: 0x04003616 RID: 13846
	[Token(Token = "0x4002969")]
	[FieldOffset(Offset = "0xC0")]
	public Transform PrefabChanceEvent;

	// Token: 0x04003617 RID: 13847
	[Token(Token = "0x400296A")]
	[FieldOffset(Offset = "0xC8")]
	public Transform PrefabTargetLostEvent;

	// Token: 0x04003618 RID: 13848
	[Token(Token = "0x400296B")]
	[FieldOffset(Offset = "0xD0")]
	public Transform PrefabTimeSinceThreatEvent;

	// Token: 0x04003619 RID: 13849
	[Token(Token = "0x400296C")]
	[FieldOffset(Offset = "0xD8")]
	public Transform PrefabOnPositionMemorySetEvent;

	// Token: 0x0400361A RID: 13850
	[Token(Token = "0x400296D")]
	[FieldOffset(Offset = "0xE0")]
	public Transform PrefabAggressionTimerEvent;

	// Token: 0x0400361B RID: 13851
	[Token(Token = "0x400296E")]
	[FieldOffset(Offset = "0xE8")]
	public Transform PrefabReloadingEvent;

	// Token: 0x0400361C RID: 13852
	[Token(Token = "0x400296F")]
	[FieldOffset(Offset = "0xF0")]
	public Transform PrefabInRangeOfHomeEvent;

	// Token: 0x0400361D RID: 13853
	[Token(Token = "0x4002970")]
	[FieldOffset(Offset = "0xF8")]
	public RustText TextStateName;

	// Token: 0x0400361E RID: 13854
	[Token(Token = "0x4002971")]
	[FieldOffset(Offset = "0x100")]
	public Transform EventContainer;

	// Token: 0x0400361F RID: 13855
	[Token(Token = "0x4002972")]
	[FieldOffset(Offset = "0x108")]
	public ScrollRect Scroll;

	// Token: 0x04003620 RID: 13856
	[Token(Token = "0x4002973")]
	[FieldOffset(Offset = "0x110")]
	public AIState StateType;

	// Token: 0x04003621 RID: 13857
	[Token(Token = "0x4002974")]
	[FieldOffset(Offset = "0x114")]
	public int StateContainerID;

	// Token: 0x04003622 RID: 13858
	[Token(Token = "0x4002975")]
	[FieldOffset(Offset = "0x118")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int <InputEntityMemorySlot>k__BackingField;

	// Token: 0x04003623 RID: 13859
	[Token(Token = "0x4002976")]
	[FieldOffset(Offset = "0x120")]
	private Transform addNewEventButton;

	// Token: 0x02000958 RID: 2392
	[Token(Token = "0x2000CD4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <ScrollToBottom>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600390F RID: 14607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005079")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <ScrollToBottom>d__43(int <>1__state)
		{
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600507A")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x00017760 File Offset: 0x00015960
		[Token(Token = "0x600507B")]
		[Address(RVA = "0x9AE2B0", Offset = "0x9AD0B0", VA = "0x1809AE2B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06003912 RID: 14610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000771")]
		private object Current
		{
			[Token(Token = "0x600507C")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600507D")]
		[Address(RVA = "0x9AE3C0", Offset = "0x9AD1C0", VA = "0x1809AE3C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06003914 RID: 14612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000772")]
		private object Current
		{
			[Token(Token = "0x600507E")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04003624 RID: 13860
		[Token(Token = "0x400499F")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04003625 RID: 13861
		[Token(Token = "0x40049A0")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04003626 RID: 13862
		[Token(Token = "0x40049A1")]
		[FieldOffset(Offset = "0x20")]
		public BaseStateUI <>4__this;
	}
}
