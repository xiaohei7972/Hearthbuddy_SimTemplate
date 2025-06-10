using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_701: SimTemplate //* 游荡恶鬼 Skulking Geist
//<b>Battlecry:</b> Destroy all1-Cost spells in both hands and decks.
//<b>战吼：</b>摧毁双方手牌中和牌库中所有法力值消耗为（1）的法术牌。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards.ToArray())
                {
                    if (hc.manacost == 1 && hc.card.type == CardDB.cardtype.SPELL) p.owncards.Remove(hc);
                }
                p.renumHandCards(p.owncards);
            }
		}
	}
}