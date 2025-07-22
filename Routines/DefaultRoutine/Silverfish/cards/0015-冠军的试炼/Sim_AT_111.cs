using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_111 : SimTemplate //* 零食商贩 Refreshment Vendor
//<b>Battlecry:</b> Restore #4 Health to each hero.
//<b>战吼：</b>为每个英雄恢复#4点生命值。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int heal = (own.own) ? p.getMinionHeal(4) : p.getEnemyMinionHeal(4);
            p.minionGetDamageOrHeal(p.ownHero, -heal);
            p.minionGetDamageOrHeal(p.enemyHero, -heal);
        }
    }
}