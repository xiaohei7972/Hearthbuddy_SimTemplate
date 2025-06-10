using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_505 : SimTemplate //* 无助的幼雏 Helpless Hatchling
//<b>Deathrattle:</b> Reduce the Cost of a Beast in your hand by (1).
//<b>亡语：</b>使你手牌中的一张野兽牌法力值消耗减少（1）点。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.Mob);
                if (hc != null)
                {
                    
                }
            }
        }
	}
}