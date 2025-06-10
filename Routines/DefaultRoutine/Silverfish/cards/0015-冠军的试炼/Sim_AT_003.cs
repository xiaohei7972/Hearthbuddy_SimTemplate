using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_003 : SimTemplate //* 英雄之魂 Fallen Hero
//Your Hero Power deals 1_extra damage.
//你的英雄技能会额外造成1点伤害。 
	{
		

        public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own) p.ownHeroPowerExtraDamage++;
            else p.enemyHeroPowerExtraDamage++;
		}

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own) p.ownHeroPowerExtraDamage--;
            else p.enemyHeroPowerExtraDamage--;
        }
	}
}