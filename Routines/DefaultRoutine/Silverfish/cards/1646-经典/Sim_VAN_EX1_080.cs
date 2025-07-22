using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_080 : SimTemplate //* 奥秘守护者 Secretkeeper
	{
		//Whenever a <b>Secret</b> is played, gain +1/+1.
		//每当有一张<b>奥秘</b>牌被使用时，便获得+1/+1。

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {
            if (hc.card.Secret) p.minionGetBuffed(m, 1, 1);
        }

	}
}