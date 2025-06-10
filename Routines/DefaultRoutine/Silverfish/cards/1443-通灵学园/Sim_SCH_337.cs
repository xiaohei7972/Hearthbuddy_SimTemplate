using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_337 : SimTemplate //* 问题学生 Troublemaker
	{
        //At the end of your turn, summon two 3/3 Ruffians that attack random enemies.
        //在你的回合结束时，召唤两个3/3的无赖并使其攻击随机敌人。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_337t); //Scarab
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int place = triggerEffectMinion.zonepos;
                p.callKid(kid, place, triggerEffectMinion.own);
                p.callKid(kid, place, triggerEffectMinion.own);
            }
        }
    }
}
