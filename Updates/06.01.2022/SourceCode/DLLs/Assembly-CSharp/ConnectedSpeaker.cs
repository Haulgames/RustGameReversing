using System;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x0200012F RID: 303
[Token(Token = "0x20000B1")]
public class ConnectedSpeaker : IOEntity
{
	// Token: 0x060011DA RID: 4570 RVA: 0x0000A620 File Offset: 0x00008820
	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0x717D00", Offset = "0x716B00", VA = "0x180717D00", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0x718680", Offset = "0x717480", VA = "0x180718680", Slot = "27")]
	public override void ResetState()
	{
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFC")]
	[Address(RVA = "0x718A30", Offset = "0x717830", VA = "0x180718A30")]
	public void SetAudio(Sound sound)
	{
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0x718CA0", Offset = "0x717AA0", VA = "0x180718CA0")]
	public void StopPlaying()
	{
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFE")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void OnSamplesReceived(float[] samples)
	{
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFF")]
	[Address(RVA = "0x717B60", Offset = "0x716960", VA = "0x180717B60")]
	private void OnAudioRead(float[] data)
	{
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D00")]
	[Address(RVA = "0x717840", Offset = "0x716640", VA = "0x180717840")]
	[BaseEntity.RPC_Client]
	private void Client_PlayAudioFrom(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D01")]
	[Address(RVA = "0x7179B0", Offset = "0x7167B0", VA = "0x1807179B0")]
	[BaseEntity.RPC_Client]
	private void Client_StopPlayingAudio(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D02")]
	[Address(RVA = "0x717750", Offset = "0x716550", VA = "0x180717750", Slot = "13")]
	public override void ClientOnEnable()
	{
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D03")]
	[Address(RVA = "0x718770", Offset = "0x717570", VA = "0x180718770")]
	public void SetAudio(AudioClip clip, float time)
	{
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x7187E0", Offset = "0x7175E0", VA = "0x1807187E0")]
	public void SetAudio(ShoutcastStreamer streamer, AudioClip clip, float time)
	{
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x718E90", Offset = "0x717C90", VA = "0x180718E90")]
	private void UpdatePlaylist()
	{
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x718BB0", Offset = "0x7179B0", VA = "0x180718BB0")]
	public void SetAudio(VoiceProcessor processor)
	{
	}

	// Token: 0x060011E7 RID: 4583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x719080", Offset = "0x717E80", VA = "0x180719080")]
	private void VoiceUpdate()
	{
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x0000A638 File Offset: 0x00008838
	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x4B1A60", Offset = "0x4B0860", VA = "0x1804B1A60")]
	public Vector3 GetWorldPosition()
	{
		return default(Vector3);
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x0000A650 File Offset: 0x00008850
	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x717AB0", Offset = "0x7168B0", VA = "0x180717AB0", Slot = "130")]
	public override bool DisplayHealthInfo(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x717C40", Offset = "0x716A40", VA = "0x180717C40", Slot = "80")]
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next)
	{
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0x717AE0", Offset = "0x7168E0", VA = "0x180717AE0", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060011EC RID: 4588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0C")]
	[Address(RVA = "0x7190B0", Offset = "0x717EB0", VA = "0x1807190B0")]
	public ConnectedSpeaker()
	{
	}

	// Token: 0x04000C40 RID: 3136
	[Token(Token = "0x40009CE")]
	[FieldOffset(Offset = "0x268")]
	public AudioSource SoundSource;

	// Token: 0x04000C41 RID: 3137
	[Token(Token = "0x40009CF")]
	[FieldOffset(Offset = "0x270")]
	private EntityRef<IOEntity> connectedTo;

	// Token: 0x04000C42 RID: 3138
	[Token(Token = "0x40009D0")]
	[FieldOffset(Offset = "0x280")]
	public VoiceProcessor VoiceProcessor;

	// Token: 0x04000C43 RID: 3139
	[Token(Token = "0x40009D1")]
	[FieldOffset(Offset = "0x288")]
	private ShoutcastStreamer connectedToStreamer;

	// Token: 0x04000C44 RID: 3140
	[Token(Token = "0x40009D2")]
	[FieldOffset(Offset = "0x290")]
	private VoiceProcessor connectedToProcessor;

	// Token: 0x04000C45 RID: 3141
	[Token(Token = "0x40009D3")]
	[FieldOffset(Offset = "0x298")]
	private bool isPlayingStreamedAudio;

	// Token: 0x04000C46 RID: 3142
	[Token(Token = "0x40009D4")]
	[FieldOffset(Offset = "0x29C")]
	private uint currentReadIndex;
}
