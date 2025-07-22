using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_066 : SimTemplate //* 酸性沼泽软泥怪 Acidic Swamp Ooze
	{
		//<b>Battlecry:</b> Destroy your opponent's weapon.
		//<b>战吼：</b>摧毁对手的武器。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.lowerWeaponDurability(1000, !own.own);
		}


	}
}