using System;

namespace MobaProtocol
{
	public enum PvpCode : byte
	{
		C2P_NetworkStatus = 1,
		G2L_JoinQueue = 11,
		L2G_JoinQueue = 11,
		L2G_OutQueue,
		G2L_OutQueue = 12,
		P2L_StartGame,
		L2G_StartGame = 13,
		L2G_Newbie = 56,
		L2P_QueryPvpState = 14,
		P2L_QueryPvpState = 14,
		RefreshPlayerPvpState,
		L2P_ForceQuitPvp,
		P2L_ForceQuitPvp = 16,
		L2G_ForceQuitPvp = 16,
		G2L_ForceQuitPvp = 16,
		L2G_LobbyShutdown,
		G2C_LobbyShutdown = 17,
		G2L_OnUserQuit,
		P2C_PlayerOutline,
		P2L_PlayerOutline = 19,
		L2G_PlayerOutline = 19,
		P2L_Playerconnect,
		L2G_Playerconnect = 20,
		PvpStartCode = 50,
		Unknow = 50,
		C2L_LoginLobby,
		C2L_FakeLoginLobby,
		L2C_LoginLobby,
		C2L_JoinQueueTeam,
		C2L_JoinSefDefineTeam,
		L2P_UpateNewRoom,
		G2P_UpateNewPveRoom,
		P2G_UpateNewPveRoom = 57,
		G2C_UpateNewPveRoom = 57,
		C2P_LoginFight,
		P2C_LoginFight,
		C2P_Reconnect,
		P2C_Reconnect,
		C2P_BackGame,
		P2C_BackGame,
		C2P_LoadProcess,
		P2C_LoadProcess = 64,
		C2P_LoadingOK,
		P2L_LoadingOK,
		P2C_LoadingOK,
		P2C_BackLoadingInfo,
		L2C_PlayerFightEnd,
		FightMsgBegin,
		BattleStart,
		BattleEnd,
		L2P_BattleEndCheck = 72,
		C2P_NewbieInBattle,
		P2C_NewbieInBattle = 73,
		P2C_UnitsVisiableChanged,
		FightInfoBegin,
		P2C_CreateHero,
		P2C_CreateUnits,
		P2C_CreateScriptItem,
		P2C_CreateMapItem,
		C2P_GetMapItem,
		P2C_GetMapItem = 80,
		P2C_RotatoTo,
		C2P_MoveToPosWithPath,
		P2C_MoveToPosWithPath = 82,
		C2P_Ping,
		P2C_Ping = 83,
		P2C_AddPlayerControlUnit,
		P2C_RemovePlayerControlUnit,
		C2P_Kill,
		P2C_Kill = 86,
		P2C_ReliveHero,
		P2C_ActiveUnit,
		P2C_AddExp,
		C2P_DataChange,
		P2C_DataChange = 90,
		C2P_JumpFont,
		P2C_JumpFont = 91,
		C2P_AddBuff,
		P2C_AddBuff = 92,
		C2P_DoBuff,
		P2C_DoBuff = 93,
		C2P_RemoveBuff,
		P2C_RemoveBuff = 94,
		P2C_AddBuffExt,
		C2P_AddHighEffect,
		P2C_AddHighEffect = 96,
		C2P_DoHighEffect,
		P2C_DoHighEffect = 97,
		C2P_RemoveHighEffect,
		P2C_RemoveHighEffect = 98,
		C2P_DataUpdate,
		P2C_DataUpdate = 99,
		C2P_Wound,
		P2C_Wound = 100,
		FightTransMsgBegin,
		FightTransMsgEnd,
		FightTransMsgAllBegin,
		C2P_NotifyTeamPos,
		P2C_NotifyTeamPos = 104,
		C2P_NotifyTeamTarget,
		P2C_NotifyTeamTarget = 105,
		FightTransMsgAllEnd,
		FightMsgEnd,
		C2P_QueryInFightInfo,
		P2C_QueryInFightInfo = 108,
		P2C_KillHore,
		P2C_LastKillMonster,
		P2C_LastTeamKillMonster,
		P2C_RefreshInFightInfo,
		P2C_TipMessage,
		P2C_SetSceneValue,
		C2P_WatchPlayer,
		P2C_OtherLogin,
		G2L_OtherLogin,
		C2P_UpSkillLevel,
		P2C_UpSkillLevel = 118,
		P2C_AddSkillPoint,
		P2C_AddMoney,
		P2C_KillAddMoney,
		P2C_Rebirth,
		C2P_ReadySkillCheck,
		P2C_ReadySkillCheck = 123,
		P2C_SynSkillInfo,
		P2C_StartSkillCD,
		C2P_BuyItem,
		P2C_BuyItem = 126,
		C2P_SellItem,
		P2C_SellItem = 127,
		C2P_RevertShop,
		P2C_RevertShop = 128,
		C2P_UseItem,
		P2C_UseItem = 129,
		P2C_AddItem,
		P2C_RemoveItem,
		P2C_UpdateItem,
		P2C_RestoreData,
		P2C_AIDebugInfo,
		P2C_PlayerReconnect,
		C2P_LoginAsViewer,
		C2P_ViewerChat,
		P2C_ViewerChat = 137,
		P2C_ViewerDelaySceneData,
		P2C_ViewerUpdate,
		P2C_CheckPing,
		C2P_CheckPing = 140,
		P2L_CheckMd5,
		G2L_CheckMd5 = 141,
		P2C_MonsterPseudoDeath,
		P2C_Packages,
		P2C_FrameSync,
		C2P_LoginPve,
		P2C_LoginPve = 145,
		C2P_PveReconnect,
		P2C_PveReconnect = 146,
		C2P_PvePause,
		P2C_PvePause = 147,
		C2P_PveQuit,
		C2P_GMCheat,
		P2C_GMCheat = 149,
		C2P_Caption,
		P2C_Caption = 150,
		P2C_NotifySpawnSuperSoldier,
		P2C_NotifyMonsterCreepAiStatus,
		C2P_StartSurrender,
		P2C_StartSurrender = 153,
		C2P_VoteSurrender,
		P2C_VoteSurrender = 154,
		P2C_SurrenderTakeEffect,
		G2L_CloseServer,
		P2C_DebugCollider,
		C2L_RoomSelectRandomHero,
		L2C_RoomSelectRandomHero = 158,
		G2L_RoomSelectRandomHeroId,
		L2G_RoomSelectRandomHeroId = 159,
		C2L_RoomReqChangeHero,
		L2C_RoomReqChangeHero = 160,
		C2L_RoomRespChangeHero,
		L2C_RoomRespChangeHero = 161,
		C2L_RoomRandomHero,
		L2C_RoomRandomHero = 162,
		L2C_CanExchangeHeroList,
		L2C_ModifyState,
		C2L_RoomCancelReqChangeHero,
		L2C_RoomCancelReqChangeHero = 165,
		L2P_UpatePvpserverData,
		P2L_UpatePvpserverData = 166,
		C2P_SetPlayerVar,
		C2P_QueryUnit,
		P2C_QueryUnit,
		L2G_AllBattleEnd,
		P2L_BattleNotification,
		P2C_ACK = 240,
		C2P_ACK = 240,
		P2C_DestroyChannel,
		C2P_UseSkill,
		C2P_ReadySkill,
		P2C_ReadySkill = 243,
		C2P_StartSkill,
		P2C_StartSkill = 244,
		C2P_DoSkill,
		P2C_DoSkill = 245,
		C2P_HitSkill,
		P2C_HitSkill = 246,
		C2P_StopSkill,
		P2C_StopSkill = 247,
		C2P_EndSkill,
		P2C_EndSkill = 248,
		C2P_FlashTo,
		C2P_UnitsSnap,
		P2C_UnitsSnap = 250,
		C2P_MoveToPos,
		P2C_MoveToPos = 251,
		C2P_MoveToTarget,
		P2C_MoveToTarget = 252,
		C2P_StopMove,
		P2C_StopMove = 253,
		L2G_PunishMatch,
		G2C_PunishMatch = 254
	}
}