using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_002 : SimTemplate //* 鬼灵爬行者 Haunted Creeper
//<b>Deathrattle:</b> Summon two 1/1 Spectral Spiders.
//<b>亡语：</b>召唤两只1/1的鬼灵蜘蛛。 
	{
        

        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.FP1_002t);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(c, m.zonepos-1, m.own);
            p.callKid(c, m.zonepos-1, m.own);
        }
	}
}