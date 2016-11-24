using Happy_BuYu.BaseLogic;
using Happy_BuYu.Common;
using Happy_BuYu.Game;
using Happy_BuYu.GlobalVO;
using Happy_BuYus.Util;
using PokerCommon.Model.Msg;
using PokerCommon.MsgIntercept.Interface;
using PokerCommon.Net.Interface;
using PokerCommon.Util;
using PokerUtil;
using System;
using System.Collections.Generic;
using UnityEngine;


namespace Happy_BuYu.Lobby
{
	public class BY_LbMainCommand 
	{
		// Limited support!
		// You can only reference methods or fields defined in the class (not in ancestors classes)
		// Fields and methods stubs are needed for compilation purposes only.
		// Reflexil will automaticaly map current type, fields or methods to original references.
// Happy_BuYu.Lobby.BY_LbMainCommand
private void HandleReceiveGiftRes(byte[] pMsg)
{
	Debug.Log("HandleReceiveGiftRes");
	GameUtil gutil = new GameUtil();
	if(gutil.EnterGame)BY_LbMainMediator.Instance.m_pLbChooseScenePanel.ClickStartBtn();
	ReceiveGiftResDef receiveGiftResDef = XConvert.ToObject<ReceiveGiftResDef>(pMsg);
	if (receiveGiftResDef.iResult == 0)
	{
		int num = 0;
		int objectSize = XConvert.GetObjectSize<ReceiveGiftResDef>();
		int objectSize2 = XConvert.GetObjectSize<PresentInfo>();
		int num2 = objectSize;
		num = num2;
		BY_LbPlayerNode bY_LbPlayerNode = GDUtil.myPlay as BY_LbPlayerNode;
		bY_LbPlayerNode.m_listPresentInfo.Clear();
		Debug.Log("msg.iGiftNum" + receiveGiftResDef.iGiftNum);
		int num3 = PlayerPrefs.GetInt("RECEIVE_GIFT_RECORD_ID" + Happy_BuYu.GlobalVO.BY_GlobalData.m_iUserId);
		for (int i = 0; i < receiveGiftResDef.iGiftNum; i++)
		{
			num = num2;
			PresentInfo presentInfo = XConvert.ToObject<PresentInfo>(pMsg, ref num);
			bY_LbPlayerNode.m_listPresentInfo.Add(presentInfo);
			num2 += objectSize2;
			int iRecordID = presentInfo.iRecordID;
			if (iRecordID > num3)
			{
				num3 = iRecordID;
			}
		}
		PlayerPrefs.SetInt("RECEIVE_GIFT_RECORD_ID" + Happy_BuYu.GlobalVO.BY_GlobalData.m_iUserId, num3);
		PlayerPrefs.Save();
		if (!Happy_BuYu.GlobalVO.BY_GlobalData.g_bReturnFromGame)
		{
			BY_LBGlobalParam.m_iUserInfoStep++;
			if (BY_LBGlobalParam.m_iUserInfoStep == BY_LBGlobalParam.USER_INFO_STEPS)
			{
				BY_LbMainMediator.Instance.CallAuthenRes();
			}
		}
		this.ShowPresent();
	}
}

		
		#region " Methods stubs "
		// Do not add or update any method. If compilation fails because of a method declaration, comment it
		BY_LbMainCommand()
		{
		}
		
		void HandleInsideMsg(string strMsgType, object msgContent)
		{
		}
		
		void HandleNetMsg(int iMsgType, System.Byte[] pMsg, int iLen, string strSocketDispatcherKey)
		{
		}
		
		void UpdateFiftyMs()
		{
		}
		
		void HandleAuthenRes(System.Byte[] pMsg)
		{
		}
		
		void HandleGetRoomListInfoRes(System.Byte[] pMsg)
		{
		}
		
		int CompareServerId(Happy_BuYu.GlobalVO.FishLobbyInfoDef x, Happy_BuYu.GlobalVO.FishLobbyInfoDef y)
		{
			return default(int);
		}
		
		void AddFishLobbyInfo(Happy_BuYu.GlobalVO.FishLobbyInfoDef pInfo)
		{
		}
		
		void HandleGetPropAndEquipmentRes(System.Byte[] pMsg)
		{
		}
		
		void HandleBuyGoodsRes(System.Byte[] pMsg)
		{
		}
		
		void HandleGetShopInfoRes(System.Byte[] pMsg)
		{
		}
		
		void HandlePresentGiftRes(System.Byte[] pMsg)
		{
		}
		
		void HandleEquipGunRes(System.Byte[] pMsg)
		{
		}
		
		void ShowPresent()
		{
		}
		
		void HandleMailRecordRes(System.Byte[] pMsg)
		{
		}
		
		void ShowMail()
		{
		}
		
		void HandleExchangeAwardRes(System.Byte[] pMsg)
		{
		}
		
		void HandleDailyGet(System.Byte[] pMsg)
		{
		}
		
		void HandleReceiveVipGun(System.Byte[] pMsg)
		{
		}
		
		void HandlePropOpen(System.Byte[] pMsg)
		{
		}
		
		void HandleReceiveFirstCharge(System.Byte[] pMsg)
		{
		}
		
		void HandleReceiveBlueDiamond(System.Byte[] pMsg)
		{
		}
		
		void HandleReceiveYellowDiamond(System.Byte[] pMsg)
		{
		}
		
		void HandleCheckInfull(System.Byte[] pMsg)
		{
		}
		
		void HandleExchangeCode(System.Byte[] pMsg)
		{
		}
		
		void HandleForgeGunInfo(System.Byte[] pMsg)
		{
		}
		
		void HandleForgeGun(System.Byte[] pMsg)
		{
		}
		
		void HandleDecomposeMaterial(System.Byte[] pMsg)
		{
		}
		
		void ConnectRoomServer()
		{
		}
		
		void HandleVerifyPresentPwdRes(System.Byte[] pMsg)
		{
		}
		
		void HandleInvestInfoRes(System.Byte[] pMsg)
		{
		}
		
		void HandleReceiveYieldRes(System.Byte[] pMsg)
		{
		}
		
		void HandleInvestRes(System.Byte[] pMsg)
		{
		}
		
		void HandleBindCodeRes(System.Byte[] pMsg)
		{
		}
		
		void HandleReceiveTGPGift(System.Byte[] pMsg)
		{
		}
		
		void HandleSignUpFastMtchRes(System.Byte[] pMsg)
		{
		}
		
		void HandleReceiveQqpcmgrRes(System.Byte[] pMsg)
		{
		}
		
		void HandleQqpcmgrInfoRes(System.Byte[] pMsg)
		{
		}
		
		void HandlReceiveLuckyActivityRes(System.Byte[] pMsg)
		{
		}
		
		void HandleGainMonthDailySignAwardRes(System.Byte[] pMsg)
		{
		}
		
		void HandleRetroactiveRes(System.Byte[] pMsg)
		{
		}
		
		void HandleBuyItemRes(System.Byte[] pMsg)
		{
		}
		
		void HandleExchangeFishingTicketRes(System.Byte[] pMsg)
		{
		}
		
		void HandleQueryFishSkillRes(System.Byte[] pMsg)
		{
		}
		
		void HandleActivityInfoNotice(System.Byte[] pMsg)
		{
		}
		
		void HandleLearnFishSkillRes(System.Byte[] pMsg)
		{
		}
		
		void HandleEquimentFishSkillRes(System.Byte[] pMsg)
		{
		}
		
		void HandleMergeRes(System.Byte[] pMsg)
		{
		}
		
		void HandleCheckPveTimeRes(System.Byte[] pMsg)
		{
		}
		
		void HandleGetHpInfoRes(System.Byte[] pMsg)
		{
		}
		
		void HandleRecoverHpRes(System.Byte[] pMsg)
		{
		}
		
		void HandleGetNewerTaskInfoRes(System.Byte[] pMsg)
		{
		}
		
		void HandleReceiveNewerTaskAwardRes(System.Byte[] pMsg)
		{
		}
		
		void HandleGetDailyTaskInfoRes(System.Byte[] pMsg)
		{
		}
		
		void HandleReceiveDailyTaskAwardRes(System.Byte[] pMsg)
		{
		}
		
		void HandleClickInviteFriendRes(System.Byte[] pMsg)
		{
		}
		
		void HandleQQGameLobbyInfoRes(System.Byte[] pMsg)
		{
		}
		
		void HandleReceiveQQGameLobbyRes(System.Byte[] pMsg)
		{
		}
		
		void HandleCarnivalLotteryRes(System.Byte[] pMsg)
		{
		}
		
		void HandleMailRes(System.Byte[] pMsg)
		{
		}
		
		void HandleQzoneInfoRes(System.Byte[] pMsg)
		{
		}
		
		void HandleReceiveQzoneRes(System.Byte[] pMsg)
		{
		}
		
		void HandleLoginLotteryRes(System.Byte[] pMsg)
		{
		}
		
		void HandleGetVipLotteryInfoRes(System.Byte[] pMsg)
		{
		}
		
		void HandleVipLotteryRes(System.Byte[] pMsg)
		{
		}
		
		void HandleGetProxyInfoRes(System.Byte[] pMsg)
		{
		}
		
		void HandleBuyGunRes(System.Byte[] pMsg)
		{
		}
		
		void HandleOpenPiggyBankRes(System.Byte[] pMsg)
		{
		}
		
		void HandleCommonError(int iReqType, int iErrorType, string errorInfo)
		{
		}
		
		void DownloadQqpcmgr()
		{
		}
		
		void CheckKickOut()
		{
		}
		
		#endregion 
		
		#region " Fields stubs "
		// Do not add or update any field. If compilation fails because of a field declaration, comment it
		static string LB_HANDLE_MATCH;
		static string LB_INFULL_SUCCESS;
		#endregion 
	
	}
}
