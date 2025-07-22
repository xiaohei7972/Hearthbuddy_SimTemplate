using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_120 : SimTemplate //* 亡灵药剂师 Mistress of Mixtures
//<b>Deathrattle:</b> Restore #4 Health to each hero.
//<b>亡语：</b>为每个英雄恢复#4点生命值。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            int heal = (m.own) ? p.getMinionHeal(4) : p.getEnemyMinionHeal(4);
            p.minionGetDamageOrHeal(p.ownHero, -heal);
            p.minionGetDamageOrHeal(p.enemyHero, -heal);
        }
    }
}