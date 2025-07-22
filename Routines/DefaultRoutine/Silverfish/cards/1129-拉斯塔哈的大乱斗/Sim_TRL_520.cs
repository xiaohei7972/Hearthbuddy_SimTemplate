using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_520 : SimTemplate //* 鱼人大厨 Murloc Tastyfin
//[x]<b>Deathrattle:</b> Draw 2 Murlocsfrom your deck.
//<b>亡语：</b>从你的牌库中抽两张鱼人牌。 
	{
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardNameEN.unknown, m.own);
			p.drawACard(CardDB.cardNameEN.unknown, m.own);
        }

	}
}