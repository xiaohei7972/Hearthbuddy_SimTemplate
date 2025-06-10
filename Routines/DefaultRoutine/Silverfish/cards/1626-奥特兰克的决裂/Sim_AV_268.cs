using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_268 : SimTemplate //* 蛮爪洞穴 wildpawcavern
	{
		//在你的回合结束时，召唤一个3/4的可以<b>冻结</b>攻击目标的元素。持续3回合。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_257t);
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            p.callKid(kid, triggerEffectMinion.zonepos, true);
        }
	}
}
