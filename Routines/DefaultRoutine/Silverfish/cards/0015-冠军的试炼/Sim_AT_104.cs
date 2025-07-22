using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_104 : SimTemplate //* 海象人龟骑士 Tuskarr Jouster
//<b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, restore #7 Health to your hero.
//<b>战吼：</b>揭示双方牌库里的一张随从牌。如果你的牌法力值消耗较大，则为你的英雄恢复#7点生命值。 
	{
		
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int heal = (own.own) ? p.getMinionHeal(7) : p.getEnemyMinionHeal(7);
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, -heal); 
        }
    }
}