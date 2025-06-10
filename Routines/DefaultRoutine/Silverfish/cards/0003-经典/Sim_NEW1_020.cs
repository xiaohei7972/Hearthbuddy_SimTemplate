using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NEW1_020 : SimTemplate //* 狂野炎术师 Wild Pyromancer
	{
		//After you cast a spell, deal 1 damage to ALL minions.
		//在你施放一个法术后，对所有随从造成1点伤害。

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {
            if (m.own == ownplay && hc.card.type == CardDB.cardtype.SPELL) p.allMinionsGetDamage(1);
        }
	}
}