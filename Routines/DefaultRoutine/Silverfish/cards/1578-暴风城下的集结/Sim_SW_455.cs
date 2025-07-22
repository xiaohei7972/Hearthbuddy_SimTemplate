using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_455 : SimTemplate //* 老鼠窝 Rodent Nest
	{
		//<b>Deathrattle:</b> Summon five 1/1 Rats.
		//<b>亡语：</b>召唤五只1/1的老鼠。

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SW_455t);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own);
            p.callKid(kid, m.zonepos-1, m.own);
            p.callKid(kid, m.zonepos-1, m.own);
            p.callKid(kid, m.zonepos-1, m.own);
            p.callKid(kid, m.zonepos-1, m.own);

        }
	}
}