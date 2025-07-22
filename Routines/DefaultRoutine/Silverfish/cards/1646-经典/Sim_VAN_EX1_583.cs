using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_583 : SimTemplate //* 艾露恩的女祭司 Priestess of Elune
	{
		//<b>Battlecry:</b> Restore #4 Health to your hero.
		//<b>战吼：</b>为你的英雄恢复#4点生命值。
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int heal = (own.own) ? p.getMinionHeal(4) : p.getEnemyMinionHeal(4);
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, -heal);
        }


    }
}