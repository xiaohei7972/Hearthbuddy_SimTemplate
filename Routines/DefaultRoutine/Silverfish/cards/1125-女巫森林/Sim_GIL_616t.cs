using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_616t : SimTemplate //* 分裂树苗 Splitting Sapling
//<b>Deathrattle:</b> Summon two 1/1 Woodchips.
//<b>亡语：</b>召唤两个1/1的树枝。 
	{
        

        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_616t2);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(c, m.zonepos-1, m.own);
            p.callKid(c, m.zonepos-1, m.own);
        }
	}
}