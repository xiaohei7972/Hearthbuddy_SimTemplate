using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_NEW1_025 : SimTemplate //* 血帆海盗 Bloodsail Corsair
	{
		//[x]<b>Battlecry:</b> Remove1 Durability from youropponent's weapon.
		//<b>战吼：</b>使对手的武器失去1点耐久度。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.lowerWeaponDurability(1, !own.own);
		}


	}
}