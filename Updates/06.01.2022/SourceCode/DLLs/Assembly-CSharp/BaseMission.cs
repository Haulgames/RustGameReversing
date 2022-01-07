using System;
using System.Collections.Generic;
using Facepunch;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200072E RID: 1838
[Token(Token = "0x2000566")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x8FB10", Offset = "0x8EF10")]
public class BaseMission : BaseScriptableObject
{
	// Token: 0x170003BA RID: 954
	// (get) Token: 0x06002F64 RID: 12132 RVA: 0x000145F8 File Offset: 0x000127F8
	[Token(Token = "0x17000365")]
	public uint id
	{
		[Token(Token = "0x600280D")]
		[Address(RVA = "0x2F3990", Offset = "0x2F2790", VA = "0x1802F3990")]
		get
		{
			return 0U;
		}
	}

	// Token: 0x170003BB RID: 955
	// (get) Token: 0x06002F65 RID: 12133 RVA: 0x00014610 File Offset: 0x00012810
	[Token(Token = "0x17000366")]
	public bool isRepeatable
	{
		[Token(Token = "0x600280E")]
		[Address(RVA = "0x2F39F0", Offset = "0x2F27F0", VA = "0x1802F39F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002F66 RID: 12134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600280F")]
	[Address(RVA = "0x2F3810", Offset = "0x2F2610", VA = "0x1802F3810", Slot = "4")]
	public virtual Sprite GetIcon(BaseMission.MissionInstance instance)
	{
		return null;
	}

	// Token: 0x06002F67 RID: 12135 RVA: 0x00014628 File Offset: 0x00012828
	[Token(Token = "0x6002810")]
	[Address(RVA = "0x2F3820", Offset = "0x2F2620", VA = "0x1802F3820")]
	public bool IsEligableForMission(BasePlayer player, IMissionProvider provider)
	{
		return default(bool);
	}

	// Token: 0x06002F68 RID: 12136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002811")]
	[Address(RVA = "0x2F3980", Offset = "0x2F2780", VA = "0x1802F3980")]
	public BaseMission()
	{
	}

	// Token: 0x04002B23 RID: 11043
	[Token(Token = "0x4002300")]
	[FieldOffset(Offset = "0x20")]
	public string shortname;

	// Token: 0x04002B24 RID: 11044
	[Token(Token = "0x4002301")]
	[FieldOffset(Offset = "0x28")]
	public Translate.Phrase missionName;

	// Token: 0x04002B25 RID: 11045
	[Token(Token = "0x4002302")]
	[FieldOffset(Offset = "0x30")]
	public Translate.Phrase missionDesc;

	// Token: 0x04002B26 RID: 11046
	[Token(Token = "0x4002303")]
	[FieldOffset(Offset = "0x38")]
	public BaseMission.MissionObjectiveEntry[] objectives;

	// Token: 0x04002B27 RID: 11047
	[Token(Token = "0x4002304")]
	[FieldOffset(Offset = "0x40")]
	public GameObjectRef acceptEffect;

	// Token: 0x04002B28 RID: 11048
	[Token(Token = "0x4002305")]
	[FieldOffset(Offset = "0x48")]
	public GameObjectRef failedEffect;

	// Token: 0x04002B29 RID: 11049
	[Token(Token = "0x4002306")]
	[FieldOffset(Offset = "0x50")]
	public GameObjectRef victoryEffect;

	// Token: 0x04002B2A RID: 11050
	[Token(Token = "0x4002307")]
	[FieldOffset(Offset = "0x58")]
	public int repeatDelaySecondsSuccess;

	// Token: 0x04002B2B RID: 11051
	[Token(Token = "0x4002308")]
	[FieldOffset(Offset = "0x5C")]
	public int repeatDelaySecondsFailed;

	// Token: 0x04002B2C RID: 11052
	[Token(Token = "0x4002309")]
	[FieldOffset(Offset = "0x60")]
	public float timeLimitSeconds;

	// Token: 0x04002B2D RID: 11053
	[Token(Token = "0x400230A")]
	[FieldOffset(Offset = "0x68")]
	public Sprite icon;

	// Token: 0x04002B2E RID: 11054
	[Token(Token = "0x400230B")]
	[FieldOffset(Offset = "0x70")]
	public Sprite providerIcon;

	// Token: 0x04002B2F RID: 11055
	[Token(Token = "0x400230C")]
	[FieldOffset(Offset = "0x78")]
	public BaseMission.MissionDependancy[] acceptDependancies;

	// Token: 0x04002B30 RID: 11056
	[Token(Token = "0x400230D")]
	[FieldOffset(Offset = "0x80")]
	public BaseMission.MissionDependancy[] completionDependancies;

	// Token: 0x04002B31 RID: 11057
	[Token(Token = "0x400230E")]
	[FieldOffset(Offset = "0x88")]
	public BaseMission.MissionEntityEntry[] missionEntities;

	// Token: 0x04002B32 RID: 11058
	[Token(Token = "0x400230F")]
	[FieldOffset(Offset = "0x90")]
	public BaseMission.PositionGenerator[] positionGenerators;

	// Token: 0x04002B33 RID: 11059
	[Token(Token = "0x4002310")]
	[FieldOffset(Offset = "0x98")]
	public ItemAmount[] baseRewards;

	// Token: 0x0200072F RID: 1839
	[Token(Token = "0x2000BFA")]
	[Serializable]
	public class MissionDependancy
	{
		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06002F69 RID: 12137 RVA: 0x00014640 File Offset: 0x00012840
		[Token(Token = "0x17000740")]
		public uint targetMissionID
		{
			[Token(Token = "0x6004ED2")]
			[Address(RVA = "0x326610", Offset = "0x325410", VA = "0x180326610")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED3")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public MissionDependancy()
		{
		}

		// Token: 0x04002B34 RID: 11060
		[Token(Token = "0x400452B")]
		[FieldOffset(Offset = "0x10")]
		public string targetMissionShortname;

		// Token: 0x04002B35 RID: 11061
		[Token(Token = "0x400452C")]
		[FieldOffset(Offset = "0x18")]
		public BaseMission.MissionStatus targetMissionDesiredStatus;

		// Token: 0x04002B36 RID: 11062
		[Token(Token = "0x400452D")]
		[FieldOffset(Offset = "0x1C")]
		public bool everAttempted;
	}

	// Token: 0x02000730 RID: 1840
	[Token(Token = "0x2000BFB")]
	public enum MissionStatus
	{
		// Token: 0x04002B38 RID: 11064
		[Token(Token = "0x400452F")]
		Default,
		// Token: 0x04002B39 RID: 11065
		[Token(Token = "0x4004530")]
		Active,
		// Token: 0x04002B3A RID: 11066
		[Token(Token = "0x4004531")]
		Accomplished,
		// Token: 0x04002B3B RID: 11067
		[Token(Token = "0x4004532")]
		Failed,
		// Token: 0x04002B3C RID: 11068
		[Token(Token = "0x4004533")]
		Completed
	}

	// Token: 0x02000731 RID: 1841
	[Token(Token = "0x2000BFC")]
	public enum MissionEventType
	{
		// Token: 0x04002B3E RID: 11070
		[Token(Token = "0x4004535")]
		CUSTOM,
		// Token: 0x04002B3F RID: 11071
		[Token(Token = "0x4004536")]
		HARVEST,
		// Token: 0x04002B40 RID: 11072
		[Token(Token = "0x4004537")]
		CONVERSATION,
		// Token: 0x04002B41 RID: 11073
		[Token(Token = "0x4004538")]
		KILL_ENTITY,
		// Token: 0x04002B42 RID: 11074
		[Token(Token = "0x4004539")]
		ACQUIRE_ITEM,
		// Token: 0x04002B43 RID: 11075
		[Token(Token = "0x400453A")]
		FREE_CRATE
	}

	// Token: 0x02000732 RID: 1842
	[Token(Token = "0x2000BFD")]
	[Serializable]
	public class MissionObjectiveEntry
	{
		// Token: 0x06002F6B RID: 12139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ED4")]
		[Address(RVA = "0x326940", Offset = "0x325740", VA = "0x180326940")]
		public MissionObjective Get()
		{
			return null;
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED5")]
		[Address(RVA = "0x326950", Offset = "0x325750", VA = "0x180326950")]
		public MissionObjectiveEntry()
		{
		}

		// Token: 0x04002B44 RID: 11076
		[Token(Token = "0x400453B")]
		[FieldOffset(Offset = "0x10")]
		public Translate.Phrase description;

		// Token: 0x04002B45 RID: 11077
		[Token(Token = "0x400453C")]
		[FieldOffset(Offset = "0x18")]
		public int[] startAfterCompletedObjectives;

		// Token: 0x04002B46 RID: 11078
		[Token(Token = "0x400453D")]
		[FieldOffset(Offset = "0x20")]
		public int[] autoCompleteOtherObjectives;

		// Token: 0x04002B47 RID: 11079
		[Token(Token = "0x400453E")]
		[FieldOffset(Offset = "0x28")]
		public bool onlyProgressIfStarted;

		// Token: 0x04002B48 RID: 11080
		[Token(Token = "0x400453F")]
		[FieldOffset(Offset = "0x30")]
		public MissionObjective objective;
	}

	// Token: 0x02000733 RID: 1843
	[Token(Token = "0x2000BFE")]
	public class MissionInstance : Pool.IPooled
	{
		// Token: 0x06002F6D RID: 12141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ED6")]
		[Address(RVA = "0x326760", Offset = "0x325560", VA = "0x180326760")]
		public BaseMission GetMission()
		{
			return null;
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00014658 File Offset: 0x00012858
		[Token(Token = "0x6004ED7")]
		[Address(RVA = "0x326820", Offset = "0x325620", VA = "0x180326820")]
		public bool ShouldShowOnMap()
		{
			return default(bool);
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x00014670 File Offset: 0x00012870
		[Token(Token = "0x6004ED8")]
		[Address(RVA = "0x326820", Offset = "0x325620", VA = "0x180326820")]
		public bool ShouldShowOnCompass()
		{
			return default(bool);
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED9")]
		[Address(RVA = "0x326670", Offset = "0x325470", VA = "0x180326670", Slot = "4")]
		public void EnterPool()
		{
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EDA")]
		[Address(RVA = "0x3267B0", Offset = "0x3255B0", VA = "0x1803267B0", Slot = "5")]
		public void LeavePool()
		{
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EDB")]
		[Address(RVA = "0x3268D0", Offset = "0x3256D0", VA = "0x1803268D0")]
		public MissionInstance()
		{
		}

		// Token: 0x04002B49 RID: 11081
		[Token(Token = "0x4004540")]
		[FieldOffset(Offset = "0x10")]
		private BaseEntity _cachedProviderEntity;

		// Token: 0x04002B4A RID: 11082
		[Token(Token = "0x4004541")]
		[FieldOffset(Offset = "0x18")]
		private BaseMission _cachedMission;

		// Token: 0x04002B4B RID: 11083
		[Token(Token = "0x4004542")]
		[FieldOffset(Offset = "0x20")]
		public uint providerID;

		// Token: 0x04002B4C RID: 11084
		[Token(Token = "0x4004543")]
		[FieldOffset(Offset = "0x24")]
		public uint missionID;

		// Token: 0x04002B4D RID: 11085
		[Token(Token = "0x4004544")]
		[FieldOffset(Offset = "0x28")]
		public BaseMission.MissionStatus status;

		// Token: 0x04002B4E RID: 11086
		[Token(Token = "0x4004545")]
		[FieldOffset(Offset = "0x2C")]
		public float completionScale;

		// Token: 0x04002B4F RID: 11087
		[Token(Token = "0x4004546")]
		[FieldOffset(Offset = "0x30")]
		public float startTime;

		// Token: 0x04002B50 RID: 11088
		[Token(Token = "0x4004547")]
		[FieldOffset(Offset = "0x34")]
		public float endTime;

		// Token: 0x04002B51 RID: 11089
		[Token(Token = "0x4004548")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 missionLocation;

		// Token: 0x04002B52 RID: 11090
		[Token(Token = "0x4004549")]
		[FieldOffset(Offset = "0x44")]
		public float timePassed;

		// Token: 0x04002B53 RID: 11091
		[Token(Token = "0x400454A")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, Vector3> missionPoints;

		// Token: 0x04002B54 RID: 11092
		[Token(Token = "0x400454B")]
		[FieldOffset(Offset = "0x50")]
		public BaseMission.MissionInstance.ObjectiveStatus[] objectiveStatuses;

		// Token: 0x04002B55 RID: 11093
		[Token(Token = "0x400454C")]
		[FieldOffset(Offset = "0x58")]
		public List<MissionEntity> createdEntities;

		// Token: 0x04002B56 RID: 11094
		[Token(Token = "0x400454D")]
		[FieldOffset(Offset = "0x60")]
		public ItemAmount[] rewards;

		// Token: 0x02000734 RID: 1844
		[Token(Token = "0x2000E6D")]
		[Serializable]
		public class ObjectiveStatus
		{
			// Token: 0x06002F73 RID: 12147 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005413")]
			[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
			public ObjectiveStatus()
			{
			}

			// Token: 0x04002B57 RID: 11095
			[Token(Token = "0x400501F")]
			[FieldOffset(Offset = "0x10")]
			public bool started;

			// Token: 0x04002B58 RID: 11096
			[Token(Token = "0x4005020")]
			[FieldOffset(Offset = "0x11")]
			public bool completed;

			// Token: 0x04002B59 RID: 11097
			[Token(Token = "0x4005021")]
			[FieldOffset(Offset = "0x12")]
			public bool failed;

			// Token: 0x04002B5A RID: 11098
			[Token(Token = "0x4005022")]
			[FieldOffset(Offset = "0x14")]
			public int genericInt1;

			// Token: 0x04002B5B RID: 11099
			[Token(Token = "0x4005023")]
			[FieldOffset(Offset = "0x18")]
			public float genericFloat1;
		}

		// Token: 0x02000735 RID: 1845
		[Token(Token = "0x2000E6E")]
		public enum ObjectiveType
		{
			// Token: 0x04002B5D RID: 11101
			[Token(Token = "0x4005025")]
			MOVE,
			// Token: 0x04002B5E RID: 11102
			[Token(Token = "0x4005026")]
			KILL
		}
	}

	// Token: 0x02000736 RID: 1846
	[Token(Token = "0x2000BFF")]
	[Serializable]
	public class PositionGenerator
	{
		// Token: 0x06002F74 RID: 12148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EDC")]
		[Address(RVA = "0x3269A0", Offset = "0x3257A0", VA = "0x1803269A0")]
		public string GetIdentifier()
		{
			return null;
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EDD")]
		[Address(RVA = "0x3269B0", Offset = "0x3257B0", VA = "0x1803269B0")]
		public PositionGenerator()
		{
		}

		// Token: 0x04002B5F RID: 11103
		[Token(Token = "0x400454E")]
		[FieldOffset(Offset = "0x10")]
		public string identifier;

		// Token: 0x04002B60 RID: 11104
		[Token(Token = "0x400454F")]
		[FieldOffset(Offset = "0x18")]
		public float minDistForMovePoint;

		// Token: 0x04002B61 RID: 11105
		[Token(Token = "0x4004550")]
		[FieldOffset(Offset = "0x1C")]
		public float maxDistForMovePoint;

		// Token: 0x04002B62 RID: 11106
		[Token(Token = "0x4004551")]
		[FieldOffset(Offset = "0x20")]
		public bool centerOnProvider;

		// Token: 0x04002B63 RID: 11107
		[Token(Token = "0x4004552")]
		[FieldOffset(Offset = "0x21")]
		public bool centerOnPlayer;

		// Token: 0x04002B64 RID: 11108
		[Token(Token = "0x4004553")]
		[FieldOffset(Offset = "0x24")]
		public BaseMission.PositionGenerator.PositionType positionType;

		// Token: 0x04002B65 RID: 11109
		[Token(Token = "0x4004554")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x8FC10", Offset = "0x8F010")]
		[global::InspectorFlags]
		public MissionPoint.MissionPointEnum Flags;

		// Token: 0x04002B66 RID: 11110
		[Token(Token = "0x4004555")]
		[FieldOffset(Offset = "0x2C")]
		[global::InspectorFlags]
		public MissionPoint.MissionPointEnum ExclusionFlags;

		// Token: 0x04002B67 RID: 11111
		[Token(Token = "0x4004556")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x8FEE0", Offset = "0x8F2E0")]
		public WorldPositionGenerator worldPositionGenerator;

		// Token: 0x02000737 RID: 1847
		[Token(Token = "0x2000E6F")]
		public enum PositionType
		{
			// Token: 0x04002B69 RID: 11113
			[Token(Token = "0x4005028")]
			MissionPoint,
			// Token: 0x04002B6A RID: 11114
			[Token(Token = "0x4005029")]
			WorldPositionGenerator
		}
	}

	// Token: 0x02000738 RID: 1848
	[Token(Token = "0x2000C00")]
	[Serializable]
	public class MissionEntityEntry
	{
		// Token: 0x06002F76 RID: 12150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EDE")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public MissionEntityEntry()
		{
		}

		// Token: 0x04002B6B RID: 11115
		[Token(Token = "0x4004557")]
		[FieldOffset(Offset = "0x10")]
		public GameObjectRef entityRef;

		// Token: 0x04002B6C RID: 11116
		[Token(Token = "0x4004558")]
		[FieldOffset(Offset = "0x18")]
		public string spawnPositionToUse;

		// Token: 0x04002B6D RID: 11117
		[Token(Token = "0x4004559")]
		[FieldOffset(Offset = "0x20")]
		public bool cleanupOnMissionFailed;

		// Token: 0x04002B6E RID: 11118
		[Token(Token = "0x400455A")]
		[FieldOffset(Offset = "0x21")]
		public bool cleanupOnMissionSuccess;
	}
}
