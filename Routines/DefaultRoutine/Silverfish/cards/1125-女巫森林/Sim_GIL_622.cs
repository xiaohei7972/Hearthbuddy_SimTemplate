using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_622 : SimTemplate //* 吸血蚊 Lifedrinker
//[x]<b>Battlecry:</b> Deal 3 damage tothe enemy hero. Restore#3 Health to your hero.
//<b>战吼：</b>对敌方英雄造成3点伤害。为你的英雄恢复#3点生命值。 
    {

        
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, 3);
			int heal = p.getMinionHeal(3);
			p.minionGetDamageOrHeal(p.ownHero, -heal);
        }

    }
}