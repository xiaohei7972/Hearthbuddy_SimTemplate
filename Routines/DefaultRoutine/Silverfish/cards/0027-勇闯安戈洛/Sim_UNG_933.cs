using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_933 : SimTemplate //* 暴龙之王摩什 King Mosh
//<b>Battlecry:</b> Destroy all damaged minions.
//<b>战吼：</b>消灭所有受伤的随从。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            foreach (Minion m in p.ownMinions)
            {
                if (m.wounded)  p.minionGetDestroyed(m);
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m.wounded) p.minionGetDestroyed(m);
            }
        }
    }
}