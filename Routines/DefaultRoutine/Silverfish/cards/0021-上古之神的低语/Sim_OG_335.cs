using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_335 : SimTemplate //* 变幻之影 Shifting Shade
//[x]<b>Deathrattle:</b> Copy a cardfrom your opponent's deck_and add it to your hand.
//<b>亡语：</b>复制你对手的牌库中的一张牌，并将其置入你的手牌。 
	{
		
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own, true);
        }
	}
}