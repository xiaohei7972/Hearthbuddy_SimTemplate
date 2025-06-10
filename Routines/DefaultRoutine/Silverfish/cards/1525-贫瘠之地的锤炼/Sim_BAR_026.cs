using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_026 : SimTemplate //* 亡首教徒 Death's Head Cultist
	{
        //<b>Taunt</b><b>Deathrattle:</b> Restore 4 Health to your hero.
        //<b>嘲讽</b>，<b>亡语：</b>为你的英雄恢复4点生命值。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.minionGetDamageOrHeal(p.ownHero, -4);
            }
            else
            {
                p.minionGetDamageOrHeal(p.enemyHero, -4);
            }
        }

    }
}
