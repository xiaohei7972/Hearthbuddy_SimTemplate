using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_394 : SimTemplate //* 闪光的蘑菇 Shrieking Shroom
//At the end of your turn, summon a random1-Cost minion.
//在你的回合结束时，随机召唤一个法力值消耗为（1）的随从。 
	{
		
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_044a); 

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int pos = triggerEffectMinion.zonepos;
                p.callKid(kid, pos, triggerEffectMinion.own);
            }
        }
	}
}