using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_088 : SimTemplate //* 列王守卫 Guardian of Kings
	{
		//<b>Battlecry:</b> Restore #6 Health to your hero.
		//<b>战吼：</b>为你的英雄恢复#6点生命值。s
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int heal = (own.own) ? p.getMinionHeal(6) : p.getEnemyMinionHeal(6);

            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, -heal);
        }


    }
}