using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_201 : SimTemplate //* 蛮鱼图腾 Primalfin Totem
//At the end of your turn, summon a 1/1 Murloc.
//在你的回合结束时，召唤一个1/1的鱼人。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_201t); 

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