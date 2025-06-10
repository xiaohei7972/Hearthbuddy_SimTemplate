using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_095 : SimTemplate //* 鼬鼠挖掘工 Weasel Tunneler
//<b>Deathrattle:</b> Shuffle this minion into your opponent's deck.
//<b>亡语：</b>将该随从洗入你对手的牌库。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own) p.enemyDeckSize++;
            else p.ownDeckSize++;
        }
    }
}