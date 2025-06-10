using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_177 : SimTemplate //* 八爪巨怪
	{

//    todesröcheln:/ zieht eine karte.

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardNameEN.unknown, m.own);
            p.drawACard(CardDB.cardNameEN.unknown, m.own);
            p.drawACard(CardDB.cardNameEN.unknown, m.own);
            p.drawACard(CardDB.cardNameEN.unknown, m.own);
            p.drawACard(CardDB.cardNameEN.unknown, m.own);
            p.drawACard(CardDB.cardNameEN.unknown, m.own);
            p.drawACard(CardDB.cardNameEN.unknown, m.own);
            p.drawACard(CardDB.cardNameEN.unknown, m.own);
        }

	}
}