using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_693 : SimTemplate //* 鲜血女巫 Blood Witch
//At the start of your turn, deal 1 damage to your_hero.
//在你的回合开始时，对你的英雄造成1点伤害。 
	{



        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                int dmg = 1;
				p.minionGetDamageOrHeal(p.ownHero, dmg, true);
            }
        }

	}
}