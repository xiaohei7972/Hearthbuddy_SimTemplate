using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：5 攻击力：4 生命值：5
	//Ara'lon
	//艾拉隆
	//<b>Battlecry:</b> Summon one of each <b>Dormant</b> Wildseed.
	//<b>战吼：</b>召唤每种<b>休眠</b>灵种各一个。
	class Sim_CORE_REV_363 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_360t);
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_360t1);
		CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_360t2);

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.callKid(kid, own.zonepos, own.own);
			p.callKid(kid1, own.zonepos + 1, own.own);
			p.callKid(kid2, own.zonepos + 2, own.own);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 2) // 最少需要两个空位
			};
		}

	}
}
