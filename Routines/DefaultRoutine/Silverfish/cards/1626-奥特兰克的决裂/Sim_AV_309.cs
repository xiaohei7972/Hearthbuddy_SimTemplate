using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_309 : SimTemplate //* 被背小鬼 piggybackimp
	{
		//<b>亡语：</b>召唤一个4/1的小鬼。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_309t);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
        }
		
	}
}
