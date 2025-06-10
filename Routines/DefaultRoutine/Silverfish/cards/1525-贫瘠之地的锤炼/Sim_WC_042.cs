using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_042 : SimTemplate //* 哀嚎蒸汽 Wailing Vapor
	{
        //[x]After you play an Elemental,gain +1 Attack.
        //在你使用一张元素牌后，获得+1攻击力。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion m)
        {
            if (m.own)
            {
                if(hc.card.race == CardDB.Race.ELEMENTAL || hc.card.race == CardDB.Race.ALL)
                {
                    p.minionGetBuffed(m, 1, 0);
                }
            }            
        }

    }
}
