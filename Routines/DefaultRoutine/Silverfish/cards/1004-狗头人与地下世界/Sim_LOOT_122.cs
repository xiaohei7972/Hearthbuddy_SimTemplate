using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_122 : SimTemplate //* 腐蚀淤泥 Corrosive Sludge
//<b>Battlecry:</b> Destroy your opponent's weapon.
//<b>战吼：</b>摧毁对手的武器。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.lowerWeaponDurability(1000, !own.own);
		}


	}
}