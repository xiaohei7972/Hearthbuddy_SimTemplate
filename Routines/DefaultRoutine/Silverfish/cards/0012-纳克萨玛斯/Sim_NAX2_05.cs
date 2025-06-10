using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX2_05 : SimTemplate //* 膜拜者 Worshipper
//Your hero has +1 Attack on your turn.
//你的英雄在你的回合获得+1攻击力。 
	{
		

        public override void onAuraStarts(Playfield p, Minion own)
		{
            p.minionGetBuffed(own.own ? p.ownHero : p.enemyHero, 1, 0);
		}

        public override void onAuraEnds(Playfield p, Minion own)
        {
            p.minionGetBuffed(own.own ? p.ownHero : p.enemyHero, -1, 0);
        }
	}
}