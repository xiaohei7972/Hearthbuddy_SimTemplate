using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_099: SimTemplate //* 自爆憎恶 Ticking Abomination
//<b>Deathrattle:</b> Deal 5 damage to your minions.
//<b>亡语：</b>对你所有的随从造成5点伤害。 
    {
        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.allMinionOfASideGetDamage(m.own, 5);
        }
    }
}