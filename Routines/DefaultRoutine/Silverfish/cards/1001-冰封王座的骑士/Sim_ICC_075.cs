using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_075: SimTemplate //* 卑鄙的恐惧魔王 Despicable Dreadlord
//At the end of your turn, deal 1 damage to all enemy minions.
//在你的回合结束时，对所有敌方随从造成1点伤害。 
    {
        

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                p.allMinionOfASideGetDamage(!triggerEffectMinion.own, 1);
            }
        }
    }
}