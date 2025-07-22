using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_047t2 : SimTemplate //* 命运织网蛛 Fatespinner
//<b>Deathrattle:</b> Deal 3 damage to all minions and give them +2/+2.
//<b>亡语：</b>对所有随从造成3点伤害，并使所有随从获得+2/+2。 
    {
        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.allMinionOfASideGetBuffed(true, 2, 2);
            p.allMinionOfASideGetBuffed(false, 2, 2);
            p.allMinionsGetDamage(3);
        }
    }
}