using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_616 : SimTemplate //* 分裂腐树 Splitting Festeroot
//<b>Deathrattle:</b> Summon two 2/2 Splitting Saplings.
//<b>亡语：</b>召唤两个2/2的分裂树苗。 
	{
        

        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_616t);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(c, m.zonepos-1, m.own);
            p.callKid(c, m.zonepos-1, m.own);
        }
	}
}