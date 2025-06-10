using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_061 : SimTemplate //* 阿努比萨斯哨兵 Anubisath Sentinel
//<b>Deathrattle:</b> Give a random friendly minion +3/+3.
//<b>亡语：</b>随机使一个友方随从获得+3/+3。 
	{
		
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
			Minion target = (m.own) ? p.searchRandomMinion(p.ownMinions, searchmode.searchLowestAttack) : p.searchRandomMinion(p.enemyMinions, searchmode.searchLowestAttack);
			if (target != null) p.minionGetBuffed(target, 3, 3);
        }
    }
}