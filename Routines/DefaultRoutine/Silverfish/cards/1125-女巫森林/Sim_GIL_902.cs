using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_902 : SimTemplate //* 刺喉海盗 Cutthroat Buccaneer
//<b>Combo:</b> Give your weapon +1 Attack.
//<b>连击：</b>使你的武器获得+1攻击力。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (p.cardsPlayedThisTurn >= 1 && target != null)
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
}