using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：9 攻击力：3 生命值：3
	//Travelmaster Dungar
	//旅行管理员杜加尔
	//[x]<b>Battlecry:</b> Summon threeminions from yourdeck that are fromdifferent expansions.
	//<b>战吼：</b>从你的牌库中召唤三个来自不同扩展包的随从。
	class Sim_WORK_043 : SimTemplate
	{
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_179);
		CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_172);
		CardDB.Card kid3 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS1_069);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_179), own.zonepos, own.own);
			p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_172), own.zonepos, own.own);
			p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS1_069), own.zonepos, own.own);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 3), // 空位大于等于3
			};
		}
		
	}
}
