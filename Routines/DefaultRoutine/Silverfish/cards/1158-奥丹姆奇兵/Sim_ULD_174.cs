using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_174 : SimTemplate //* 海蛇蛋 Serpent Egg
//<b>Deathrattle:</b> Summon a 3/4 Sea Serpent.
//<b>亡语：</b>召唤一条3/4的海蛇。 
	{
        
        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_174t);
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(c, m.zonepos-1, m.own);
        }
	}
}