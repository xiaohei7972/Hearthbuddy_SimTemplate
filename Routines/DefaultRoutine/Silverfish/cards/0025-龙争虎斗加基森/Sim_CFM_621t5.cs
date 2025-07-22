using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_621t5 : SimTemplate //* 冰盖草 Icecap
//<b>Freeze</b> a random enemy minion.
//随机<b>冻结</b>一个敌方随从。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			List<Minion> temp = (ownplay) ? p.enemyMinions : p.ownMinions;
			if (temp.Count > 0)
			{
				target = p.searchRandomMinion(temp, searchmode.searchLowestHP);
                if (target != null) p.minionGetFrozen(target);
			}
        }
    }
}