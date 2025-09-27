using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：6
	//Blizzard
	//暴风雪
	//Deal $2 damage to all enemy minions and <b>Freeze</b> them.
	//对所有敌方随从造成$2点伤害，并使其<b>冻结</b>。
	class Sim_CORE_CS2_028 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.allMinionOfASideGetDamage(!ownplay, dmg);
			List<Minion> temp = (ownplay) ? p.enemyMinions : p.ownMinions;
            foreach (Minion t in temp)
            {
                p.minionGetFrozen(t);
            }
		}
		
	}
}
