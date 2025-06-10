using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOE_119 : SimTemplate //* 复活的铠甲 Animated Armor
//Your hero can only take 1 damage at a time.
//你的英雄每次只会受到1点伤害。 
	{
		
		
        public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own) p.anzOwnAnimatedArmor++;
            else p.anzEnemyAnimatedArmor++;
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.anzOwnAnimatedArmor--;
            else p.anzEnemyAnimatedArmor--;
        }
	}
}