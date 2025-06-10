using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_EX1_096 : SimTemplate //* loothoarder
	{

//    todesrÃ¶cheln:/ zieht eine karte.

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own);
        }

	}
}