using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_044 : SimTemplate //* 莫罗斯 Moroes
//<b>Stealth</b>At the end of your turn, summon a 1/1 Steward.
//<b>潜行</b>在你的回合结束时，召唤一个1/1的家仆。 
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