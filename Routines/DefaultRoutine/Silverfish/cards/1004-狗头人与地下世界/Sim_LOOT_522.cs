using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_522 : SimTemplate //* 碾压墙 Crushing Walls
//Destroy your opponent's left and right-most minions.
//消灭对手场上最左边和最右边的随从。 
	{
        

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            Minion m = p.searchRandomMinion(ownplay ? p.enemyMinions : p.ownMinions, searchmode.searchLowestHP);
            if (m != null) p.minionGetDestroyed(m);
		}

	}
}