using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_037 : SimTemplate //* 始祖龟执盾者 Tortollan Shellraiser
//[x]<b>Taunt</b><b>Deathrattle:</b> Give a random_friendly minion +1/+1.
//<b>嘲讽，亡语：</b>随机使一个友方随从获得+1/+1。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
			Minion target = (m.own) ? p.searchRandomMinion(p.ownMinions, searchmode.searchLowestAttack) : p.searchRandomMinion(p.enemyMinions, searchmode.searchLowestAttack);
			if (target != null) p.minionGetBuffed(target, 1, 1);
        }
    }
}