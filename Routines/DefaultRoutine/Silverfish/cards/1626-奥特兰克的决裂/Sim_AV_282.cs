using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_282 : SimTemplate //* 堆塑雪人 buildasnowman
	{
		//召唤一个3/3的可以<b>冻结</b>攻击目标的雪人。将一张堆塑雪怪置入你的手牌。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_282t);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.callKid(kid, target.zonepos, true);
            p.drawACard(CardDB.cardIDEnum.AV_282t2, target.own, false);
        }
		
	}
}
