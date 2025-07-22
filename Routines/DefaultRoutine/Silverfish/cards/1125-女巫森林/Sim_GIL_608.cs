using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_608 : SimTemplate //* 女巫森林小鬼 Witchwood Imp
//[x]<b>Stealth</b><b>Deathrattle:</b> Give a random  friendly minion +2 Health.
//<b>潜行，亡语：</b>随机使一个友方随从获得+2生命值。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
			Minion target = (m.own) ? p.searchRandomMinion(p.ownMinions, searchmode.searchLowestAttack) : p.searchRandomMinion(p.enemyMinions, searchmode.searchLowestAttack);
			if (target != null) p.minionGetBuffed(target, 0, 2);
        }
    }
}