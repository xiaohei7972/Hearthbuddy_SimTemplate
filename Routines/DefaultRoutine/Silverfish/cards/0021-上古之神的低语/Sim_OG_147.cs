using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_147 : SimTemplate //* 腐化治疗机器人 Corrupted Healbot
//<b>Deathrattle:</b> Restore #8 Health to the enemy hero.
//<b>亡语：</b>为敌方英雄恢复#8点生命值。 
	{
		
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            int heal = (m.own) ? p.getMinionHeal(8) : p.getEnemyMinionHeal(8);

            p.minionGetDamageOrHeal(m.own ? p.enemyHero : p.ownHero, -heal);
        }
    }
}