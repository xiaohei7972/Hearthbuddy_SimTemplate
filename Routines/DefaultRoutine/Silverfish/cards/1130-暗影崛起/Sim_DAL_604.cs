using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_604 : SimTemplate //* 机械巨熊 Ursatron
//<b>Deathrattle:</b> Draw a Mech from your deck.
//<b>亡语：</b>从你的牌库中抽一张机械牌。 
	{



        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardNameEN.unknown, m.own);
        }

	}
}