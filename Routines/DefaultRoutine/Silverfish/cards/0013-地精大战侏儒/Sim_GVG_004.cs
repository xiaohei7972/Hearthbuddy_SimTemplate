using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_004 : SimTemplate //* 地精炎术师 Goblin Blastmage
//<b>Battlecry:</b> If you have a Mech, deal 4 damage randomly split among all enemies.
//<b>战吼：</b>如果你控制任何机械，则造成4点伤害，随机分配到所有敌人身上。 
    {
        

        public override void  getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MECHANICAL)
				{
                    p.allCharsOfASideGetRandomDamage(!own.own, 4);
					break;
				}
            }
        }
    }
}