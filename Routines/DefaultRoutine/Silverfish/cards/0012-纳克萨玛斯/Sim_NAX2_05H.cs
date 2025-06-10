using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX2_05H : SimTemplate //* 膜拜者 Worshipper
//Your hero has +3 Attack on your turn.
//你的英雄在你的回合获得+3攻击力。 
	{
		

        public override void onAuraStarts(Playfield p, Minion own)
		{
            p.minionGetBuffed(own.own ? p.ownHero : p.enemyHero, 3, 0);
		}

        public override void onAuraEnds(Playfield p, Minion own)
        {
            p.minionGetBuffed(own.own ? p.ownHero : p.enemyHero, -3, 0);
        }
	}
}