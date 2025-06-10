using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_019 : SimTemplate //* 恐惧战马 Dreadsteed
//<b>Deathrattle:</b> At the end of the turn, summon a Dreadsteed.
//<b>亡语：</b>在回合结束时，召唤一匹恐惧战马。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_019);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
        }
	}
}