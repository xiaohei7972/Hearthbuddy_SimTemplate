using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_282t2 : SimTemplate //* 堆塑雪怪 buildasnowbrute
	{
		//召唤一个6/6的可以<b>冻结</b>攻击目标的雪怪。将一张堆塑巨怪置入你的手牌。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_282t3);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.callKid(kid, target.zonepos, true);
            p.drawACard(CardDB.cardIDEnum.AV_282t4, target.own, false);
        }
		
	}
}
