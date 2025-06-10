using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_027 : SimTemplate //* 暗矛狂战士 Darkspear Berserker
	{
		//<b>Deathrattle:</b> Deal 5 damage to your hero.
		//<b>亡语：</b>对你的英雄造成5点伤害。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.minionGetDamageOrHeal(p.ownHero, 5);
            }
            else
            {
                p.minionGetDamageOrHeal(p.enemyHero, 5);
            }
        }		
		
	}
}
