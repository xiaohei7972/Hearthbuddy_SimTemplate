using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_651 : SimTemplate //* 纳迦海盗 Naga Corsair
//<b>Battlecry:</b> Give your weapon +1 Attack.
//<b>战吼：</b>使你的武器获得+1攻击力。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own)
            {
                if (p.ownWeapon.Durability > 0)
                {
                    p.ownWeapon.Angr++;
                    p.minionGetBuffed(p.ownHero, 1, 0);
                }
            }
            else
            {
                if (p.enemyWeapon.Durability > 0)
                {
                    p.enemyWeapon.Angr++;
                    p.minionGetBuffed(p.enemyHero, 1, 0);
                }
            }
        }
    }
}