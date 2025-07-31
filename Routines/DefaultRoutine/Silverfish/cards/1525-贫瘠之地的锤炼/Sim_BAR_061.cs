using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 棘齿城私掠者 Ratchet Privateer
    //<b>Battlecry:</b> Give your weapon +1 Attack.
    //<b>战吼：</b>使你的武器获得+1攻击力。
    class Sim_BAR_061 : SimTemplate
    {
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
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
