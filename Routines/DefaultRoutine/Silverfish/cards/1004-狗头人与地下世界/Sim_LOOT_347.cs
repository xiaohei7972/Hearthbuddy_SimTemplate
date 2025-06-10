using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_347 : SimTemplate //* 狗头人学徒 Kobold Apprentice
//<b>Battlecry:</b> Deal 3 damage randomly split among all_enemies.
//<b>战吼：</b>造成3点伤害，随机分配到所有敌人身上。 
	{
        

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MECHANICAL)
				{
                    p.allCharsOfASideGetRandomDamage(!own.own, 3);
					break;
				}
            }
		}
	}
}