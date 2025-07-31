using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 南海畸变船长 Southsea Squidface
    //<b>Deathrattle:</b> Give your weapon +2 Attack.
    //<b>亡语：</b>使你的武器获得+2攻击力。
    class Sim_OG_267 : SimTemplate
    {
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                if (p.ownWeapon.Durability >= 1)
                {
                    p.ownWeapon.Angr += 2;
                    p.minionGetBuffed(p.ownHero, 2, 0);
                }

            }
            else
            {
                if (p.enemyWeapon.Durability >= 1)
                {
                    p.enemyWeapon.Angr += 2;
                    p.minionGetBuffed(p.enemyHero, 2, 0);
                }

            }

        }
        
    }
}