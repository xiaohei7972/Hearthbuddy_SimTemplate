using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_076 : SimTemplate //* 卑劣的窃蛋者 Eggnapper
//<b>Deathrattle:</b> Summon two 1/1 Raptors.
//<b>亡语：</b>召唤两个1/1的迅猛龙。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_076t1); 
        
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own);
            p.callKid(kid, m.zonepos-1, m.own);
        }
	}
}