using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_010 : SimTemplate //* 臃肿的蛇颈龙 Sated Threshadon
//<b>Deathrattle:</b> Summon three 1/1 Murlocs.
//<b>亡语：</b>召唤三个1/1的鱼人。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_201t); 
        
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own);
            p.callKid(kid, m.zonepos-1, m.own);
            p.callKid(kid, m.zonepos-1, m.own);
        }
	}
}