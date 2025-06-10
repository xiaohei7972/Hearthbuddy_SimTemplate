using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_024 : SimTemplate //* 绿洲长尾鳄 Oasis Thrasher
	{
		//<b>Frenzy:</b> Deal 3 damage to the enemy Hero.
		//<b>暴怒：</b>对敌方英雄造成3点伤害。
        public override void onEnrageStart(Playfield p, Minion m)
        {
            if (!m.own)
            {
                p.minionGetDamageOrHeal(p.ownHero, 3);
            }
            else
            {
                p.minionGetDamageOrHeal(p.enemyHero, 3);
            }
        }		
		
	}
}
