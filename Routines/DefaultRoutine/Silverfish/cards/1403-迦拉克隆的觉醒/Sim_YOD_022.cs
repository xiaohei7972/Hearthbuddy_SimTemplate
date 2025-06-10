using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOD_022 : SimTemplate //* 冒进的艇长 Risky Skipper
	{
		//After you play a minion, deal 1 damage to all_minions.
		//在你使用一张随从牌后，对所有随从造成1点伤害。
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {
            if (m.own == ownplay && (TAG_RACE)hc.card.race == TAG_RACE.PIRATE) p.allMinionsGetDamage(1);
        }
		
	}
}
