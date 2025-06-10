using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_007 : SimTemplate //* 蛛魔之卵 Nerubian Egg
//<b>Deathrattle:</b> Summon a 4/4 Nerubian.
//<b>亡语：</b>召唤一个4/4的蛛魔。 
	{
        
        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.FP1_007t);
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(c, m.zonepos-1, m.own);
        }
	}
}