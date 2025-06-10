using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_388 : SimTemplate //* 菌菇附魔师 Fungal Enchanter
//<b>Battlecry:</b> Restore #2 Health to all friendly characters.
//<b>战吼：</b>为所有友方角色恢复#2点生命值。 
	{



		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int heal = (own.own) ? p.getMinionHeal(2) : p.getEnemyMinionHeal(2);
            p.allCharsOfASideGetDamage(own.own, -heal);
		}


	}
}