using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_803 : SimTemplate //* 翡翠掠夺者 Emerald Reaver
//<b>Battlecry:</b> Deal 1 damage to each hero.
//<b>战吼：</b>对每个英雄造成1点伤害。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
				p.minionGetDamageOrHeal(p.enemyHero, 1);
				p.minionGetDamageOrHeal(p.ownHero, 1);
        }
    }
}