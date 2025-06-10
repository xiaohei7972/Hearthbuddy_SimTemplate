using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_110 : SimTemplate //* 凯恩·血蹄 Cairne Bloodhoof
	{
		//<b>Deathrattle:</b> Summon a 5/5 Baine Bloodhoof.
		//<b>亡语：</b>召唤一个5/5的贝恩·血蹄。

        CardDB.Card blaine = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_110t);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(blaine, m.zonepos-1, m.own);
        }
	}
}
