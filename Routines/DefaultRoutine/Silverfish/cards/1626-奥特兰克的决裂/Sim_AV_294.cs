using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_294 : SimTemplate //* 怒爪精锐 clawfuryadept
	{
		//<b>战吼：</b>在本回合中，使所有其他友方角色获得+1攻击力。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = own.own ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                p.minionGetTempBuff(m, 1, 0);
            }
            var hero = own.own ? p.ownHero : p.enemyHero;
            p.minionGetTempBuff(hero, 1, 0);
            hero.updateReadyness();
        }

        //public override void onAuraEnds(Playfield p, Minion m)
        //{
        //    List<Minion> temp = m.own ? p.ownMinions : p.enemyMinions;
        //    foreach (Minion mm in temp)
        //    {
        //        p.minionGetTempBuff(mm, -1, 0);
        //    }
        //}
	}
}
