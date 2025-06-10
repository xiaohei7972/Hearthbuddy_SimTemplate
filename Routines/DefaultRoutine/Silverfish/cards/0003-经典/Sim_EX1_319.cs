using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_319 : SimTemplate //* 烈焰小鬼 Flame Imp
	{
		//<b>Battlecry:</b> Deal 3 damage to your hero.
		//<b>战吼：</b>对你的英雄造成3点伤害。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, 3);
        }


    }
}