using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_158 : SimTemplate //* 狂热的新兵 Zealous Initiate
//<b>Deathrattle:</b> Give a random friendly minion +1/+1.
//<b>亡语：</b>随机使一个友方随从获得+1/+1。 
	{
		
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
			Minion target = (m.own) ? p.searchRandomMinion(p.ownMinions, searchmode.searchLowestAttack) : p.searchRandomMinion(p.enemyMinions, searchmode.searchLowestAttack);
			if (target != null) p.minionGetBuffed(target, 1, 1);
        }
    }
}