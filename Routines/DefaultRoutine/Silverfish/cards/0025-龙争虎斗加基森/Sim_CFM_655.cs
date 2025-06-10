using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_655 : SimTemplate //* 毒性污水软泥怪 Toxic Sewer Ooze
//<b>Battlecry:</b> Remove 1 Durability from your opponent's weapon.
//<b>战吼：</b>使对手的武器失去1点耐久度。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.lowerWeaponDurability(1, !m.own);
        }
    }
}