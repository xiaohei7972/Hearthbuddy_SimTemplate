using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_005 : SimTemplate //* 慈祥的外婆 Kindly Grandmother
//<b>Deathrattle:</b> Summon a 3/2 Big Bad Wolf.
//<b>亡语：</b>召唤一只3/2的大灰狼。 
	{
		
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_005a);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own);
        }
	}
}