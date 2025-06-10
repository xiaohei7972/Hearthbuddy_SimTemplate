using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_325 : SimTemplate //* 蹩脚海盗 Small-Time Buccaneer
//Has +2 Attack while you have a weapon equipped.
//如果你装备一把武器，该随从具有+2攻击力。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own)
            {
                if (p.ownWeapon.Durability > 0) p.minionGetBuffed(m, 2, 0);
            }
            else
            {
                if (p.enemyWeapon.Durability > 0) p.minionGetBuffed(m, 2, 0);
            }
        }
    }
}