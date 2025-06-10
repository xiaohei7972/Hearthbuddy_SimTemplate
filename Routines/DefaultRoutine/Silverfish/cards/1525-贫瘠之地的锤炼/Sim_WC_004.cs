using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_004 : SimTemplate //* 牙缚德鲁伊 Fangbound Druid
	{
        //<b>Taunt</b><b>Deathrattle:</b> Reduce the Cost of a Beast in your hand by (2).
        //<b>嘲讽</b>，<b>亡语：</b>使你手牌中的一张野兽牌法力值消耗减少（2）点。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            foreach(Handmanager.Handcard hc in p.owncards)
            {
                if(hc.card.race == CardDB.Race.BEAST || hc.card.race == CardDB.Race.ALL)
                {
                    hc.manacost -= 2;
                    break;
                }
            }
        }

    }
}
