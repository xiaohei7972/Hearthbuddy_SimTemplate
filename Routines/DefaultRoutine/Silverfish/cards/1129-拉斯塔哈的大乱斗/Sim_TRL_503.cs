using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_503 : SimTemplate //* 甲虫卵 Scarab Egg
//<b>Deathrattle:</b> Summon three 1/1 Scarabs.
//<b>亡语：</b>召唤三只1/1的甲虫。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_503t);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own);
            p.callKid(kid, m.zonepos-1, m.own);
			p.callKid(kid, m.zonepos-1, m.own);
        }
	}
}