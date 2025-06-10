using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_333 : SimTemplate //* 太空海盗 
	{
        //<b>Deathrattle:</b> Your next weapon costs (1) less.
        //<b>亡语：</b>你的下一张武器牌法力值消耗减少（1）点。

        public override void onDeathrattle(Playfield p, Minion m)
        {
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.type == CardDB.cardtype.WEAPON)
                {
                    hc.manacost--;
                }
            }
        }
    }
}
