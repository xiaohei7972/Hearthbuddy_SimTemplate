using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_516 : SimTemplate //* 古拉巴什供品 Gurubashi Offering
//At the start of your turn, destroy this and gain 8_Armor.
//在你的回合开始时，消灭该随从，并获得8点护甲值。 
    {
        

         public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own)
            {
				p.minionGetDestroyed(triggerEffectMinion);
				p.minionGetArmor(triggerEffectMinion.own ? p.ownHero : p.enemyHero, 8);
			}
			else
            {
				p.minionGetDestroyed(triggerEffectMinion);
				p.minionGetArmor(triggerEffectMinion.own ? p.ownHero : p.enemyHero, 8);
			}
        }
    }
}