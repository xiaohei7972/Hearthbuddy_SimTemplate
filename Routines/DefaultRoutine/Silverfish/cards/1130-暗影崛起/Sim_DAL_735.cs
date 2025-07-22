using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_735 : SimTemplate //* 达拉然图书管理员 Dalaran Librarian
//<b>Battlecry:</b> <b>Silence</b>adjacent minions.
//<b>战吼：</b><b>沉默</b>相邻的随从。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
			foreach (Minion m in temp)
			{
				if (m.zonepos == own.zonepos - 1 || m.zonepos == own.zonepos + 1)
				{
					p.minionGetSilenced(target);
				}
			}
        }
    }
}