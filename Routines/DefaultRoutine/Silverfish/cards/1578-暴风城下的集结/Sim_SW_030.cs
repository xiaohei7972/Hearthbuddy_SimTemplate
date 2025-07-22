using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_030 : SimTemplate //* 货物保镖 Cargo Guard
	{   
        //At the end of your turn, gain 3 Armor.
        //在你的回合结束时，获得3点护甲值。
        
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                if (triggerEffectMinion.own)
                {
                    p.minionGetArmor(p.ownHero, 3);
                    
                }
                else
                {
                    p.minionGetArmor(p.enemyHero, 3);
                }
            }
        }

        
    }
}
