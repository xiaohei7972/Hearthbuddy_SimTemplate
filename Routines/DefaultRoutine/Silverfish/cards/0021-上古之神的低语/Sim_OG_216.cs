using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_216 : SimTemplate //* 寄生恶狼 Infested Wolf
//<b>Deathrattle:</b> Summon two 1/1 Spiders.
//<b>亡语：</b>召唤两只1/1的蜘蛛。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_216a);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own);
            p.callKid(kid, m.zonepos-1, m.own);
        }
	}
}