using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_282t4 : SimTemplate //* 堆塑巨怪 buildasnowgre
	{
		//召唤一个9/9的可以<b>冻结</b>攻击目标的冰雪巨怪。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_282t5);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.callKid(kid, target.zonepos, true);
        }
		
	}
}
