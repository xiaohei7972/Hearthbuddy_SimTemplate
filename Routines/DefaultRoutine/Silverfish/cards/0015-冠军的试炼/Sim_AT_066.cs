using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 奥格瑞玛狼骑士 Orgrimmar Aspirant
    //<b>Inspire:</b> Give your weapon +1 Attack.
    //<b>激励：</b>使你的武器获得+1攻击力。 
    class Sim_AT_066 : SimTemplate
    {
        public override void onInspire(Playfield p, Minion m, bool own)
        {
            if (m.own == own)
            {
                if (m.own)
                {
                    if (p.ownWeapon.Durability >= 1)
                    {
                        p.ownWeapon.Angr++;
                        p.minionGetBuffed(p.ownHero, 1, 0);
                    }

                }
                else
                {
                    if (p.enemyWeapon.Durability >= 1)
                    {
                        p.enemyWeapon.Angr++;
                        p.minionGetBuffed(p.enemyHero, 1, 0);
                    }

                }
            }
        }
    }
}