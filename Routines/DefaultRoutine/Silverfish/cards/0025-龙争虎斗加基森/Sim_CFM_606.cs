using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_606 : SimTemplate //* 法力晶簇 Mana Geode
//Whenever this minion is_healed, summon a 2/2_Crystal.
//每当该随从获得治疗时，便召唤一颗2/2的水晶。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_606t); 

        public override void onAMinionGotHealedTrigger(Playfield p, Minion triggerEffectMinion, int minionsGotHealed)
        {
            if (triggerEffectMinion.anzGotHealed > 0)
            {
                int tmp = triggerEffectMinion.anzGotHealed;
                triggerEffectMinion.anzGotHealed = 0;
                for (int i = 0; i < tmp; i++)
                {
                    p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);
                }
            }
        }
    }
}