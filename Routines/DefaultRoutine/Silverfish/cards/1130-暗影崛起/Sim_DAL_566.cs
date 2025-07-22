using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_566 : SimTemplate //* 古怪的铭文师 Eccentric Scribe
//<b>Deathrattle:</b> Summonfour 1/1 Vengeful Scrolls.
//<b>亡语：</b>召唤四个1/1的复仇卷轴。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_566t);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own);
            p.callKid(kid, m.zonepos-1, m.own);
			p.callKid(kid, m.zonepos-1, m.own);
			p.callKid(kid, m.zonepos-1, m.own);
        }
	}
}