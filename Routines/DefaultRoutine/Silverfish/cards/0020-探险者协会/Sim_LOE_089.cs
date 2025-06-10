using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_089 : SimTemplate //* 摇摆的俾格米 Wobbling Runts
//<b>Deathrattle:</b> Summon three 2/2 Runts.
//<b>亡语：</b>召唤三个2/2的俾格米。 
	{
		
        
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOE_089t), m.zonepos - 1, m.own); 
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOE_089t2), m.zonepos, m.own); 
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOE_089t3), m.zonepos + 1, m.own); 
        }
	}
}