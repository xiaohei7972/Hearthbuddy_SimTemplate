using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_029 : SimTemplate //* 符文蛋 Runic Egg
//<b>Deathrattle:</b> Draw a card.
//<b>亡语：</b>抽一张牌。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own);
        }
	}
}