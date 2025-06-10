using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_272 : SimTemplate //* 暮光召唤师 Twilight Summoner
//<b>Deathrattle:</b> Summon a 5/5 Faceless Destroyer.
//<b>亡语：</b>召唤一个5/5的无面破坏者。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_272t);

        public override void onDeathrattle(Playfield p, Minion m)
        {
			p.callKid(kid, m.zonepos-1, m.own);
        }
	}
}