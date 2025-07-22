using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_096 : SimTemplate //* 战利品贮藏者 Loot Hoarder
	{
		//<b>Deathrattle:</b> Draw a card.
		//<b>亡语：</b>抽一张牌。

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own);
        }

	}
}