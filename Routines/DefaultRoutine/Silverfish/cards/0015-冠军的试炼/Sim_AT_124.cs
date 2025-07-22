using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_124 : SimTemplate //* 博尔夫·碎盾 Bolf Ramshield
//Whenever your hero takes damage, this minion takes it instead.
//每当你的英雄受到伤害，便会由该随从来承担。 
	{
		

        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnBolfRamshield++;
            }
            else
            {
                p.anzEnemyBolfRamshield++;
            }
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnBolfRamshield--;
            }
            else
            {
                p.anzEnemyBolfRamshield--;
            }
        }
    }
}