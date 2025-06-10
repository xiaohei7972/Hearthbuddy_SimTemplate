using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_021: SimTemplate //* 自爆肿胀蝠 Exploding Bloatbat
//<b>Deathrattle:</b>Deal 2 damage to all enemy minions.
//<b>亡语：</b>对所有敌方随从造成2点伤害。 
    {
        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.allMinionOfASideGetDamage(!m.own, 2);
        }
    }
}