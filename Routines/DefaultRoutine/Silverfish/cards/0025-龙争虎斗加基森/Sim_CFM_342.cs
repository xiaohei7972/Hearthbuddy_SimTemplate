using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_342 : SimTemplate //* 土地精海盗 Luckydo Buccaneer
//<b>Battlecry:</b> If your weapon has at least 3 Attack, gain +4/+4.
//<b>战吼：</b>如果你的武器至少具有3点攻击力，便获得+4/+4。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own)
            {
                if (p.ownWeapon.Durability > 0 && p.ownWeapon.Angr > 2)
                {
                    p.minionGetBuffed(m, 4, 4);
                }
            }
            else
            {
                if (p.enemyWeapon.Durability > 0 && p.enemyWeapon.Angr > 2)
                {
                    p.minionGetBuffed(m, 4, 4);
                }
            }
        }
    }
}