using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_029 : SimTemplate //* 舞动之剑 Dancing Swords
//<b>Deathrattle:</b> Your opponent draws a card.
//<b>亡语：</b>你的对手抽一张牌。 
	{



        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.None, !m.own);
        }

	}
}