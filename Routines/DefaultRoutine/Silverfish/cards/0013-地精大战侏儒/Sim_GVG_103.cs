using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_103 : SimTemplate //* 微型战斗机甲 Micro Machine
//At the start of each turn, gain +1 Attack.
//在每个回合开始时，获得+1攻击力。 
    {

        

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            p.minionGetBuffed(triggerEffectMinion, 1, 0);
        }


    }

}