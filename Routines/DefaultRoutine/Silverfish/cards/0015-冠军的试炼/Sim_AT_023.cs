using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_023 : SimTemplate //* 虚空碾压者 Void Crusher
//<b>Inspire:</b> Destroy a random minion for each player.
//<b>激励：</b>随机消灭每个玩家的一个随从。 
	{
		

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
                Minion found = p.searchRandomMinion(p.enemyMinions, searchmode.searchLowestHP);
                if (found != null)
                {
                    p.minionGetDestroyed(found);
                }
				found = p.searchRandomMinion(p.ownMinions, searchmode.searchHighHPLowAttack);
                if (found != null)
                {
                    p.minionGetDestroyed(found);
                }
            }
        }
	}
}