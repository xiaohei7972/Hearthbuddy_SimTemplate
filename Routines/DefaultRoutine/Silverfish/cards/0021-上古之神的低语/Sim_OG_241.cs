using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_241 : SimTemplate //* 着魔村民 Possessed Villager
//<b>Deathrattle:</b> Summon a 1/1 Shadowbeast.
//<b>亡语：</b>召唤一个1/1的暗影兽。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_241a);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own);
        }
	}
}