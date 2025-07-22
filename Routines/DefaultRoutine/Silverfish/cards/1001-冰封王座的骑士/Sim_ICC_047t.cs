using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_047t : SimTemplate //* 命运织网蛛 Fatespinner
//<b>Secret Deathrattle:</b> Deal 3 damage to all minions; or Give them +2/+2.@<b>Secret Deathrattle:</b> Give +2/+2 to all minions.@<b>Secret Deathrattle:</b> Deal 3 damage to all minions.
//<b>秘密亡语：</b>对所有随从造成3点伤害；或者使所有随从获得+2/+2。@<b>秘密亡语：</b>使所有随从获得+2/+2。@<b>秘密亡语：</b>对所有随从造成3点伤害。 
    {
        
        
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                if (m.hChoice == 1)
                {
                    p.allMinionOfASideGetBuffed(true, 2, 2);
                    p.allMinionOfASideGetBuffed(false, 2, 2);
                }
                else if (m.hChoice == 2) p.allMinionsGetDamage(3);
            }
            else if (!m.silenced)
            {
                if (p.prozis.enemyMinions.Count > p.prozis.ownMinions.Count)
                {
                    p.allMinionOfASideGetBuffed(false, 2, 2);
                }
                else p.allMinionsGetDamage(3);
            }
        }
    }
}