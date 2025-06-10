using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX15_04 : SimTemplate //* 锁链 Chains
//<b>Hero Power</b>Take control of a random enemy minion until end of turn.
//<b>英雄技能</b>随机获得一个敌方随从的控制权，直到回合结束。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = (ownplay) ? p.enemyMinions : p.ownMinions;
            if (temp.Count <= 0) return;
            Minion m = p.searchRandomMinion(temp, searchmode.searchLowestHP);
            if (m != null)
			{
				m.shadowmadnessed = true;
				p.shadowmadnessed++;
				p.minionGetControlled(m, ownplay, false);
			}
		}
	}
}