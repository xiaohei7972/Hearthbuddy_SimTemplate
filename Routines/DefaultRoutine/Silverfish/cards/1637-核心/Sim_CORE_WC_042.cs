using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：1 攻击力：1 生命值：3
	//Wailing Vapor
	//哀嚎蒸汽
	//[x]After you play an Elemental,gain +1 Attack.
	//在你使用一张元素牌后，获得+1攻击力。
	class Sim_CORE_WC_042 : SimTemplate
	{
		public override void onCardIsAfterToBePlayed(Playfield p, Minion playedMinion, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard)
            {
                if ((CardDB.Race)playedMinion.handcard.card.race == CardDB.Race.ELEMENTAL || (CardDB.Race)playedMinion.handcard.card.race == CardDB.Race.ALL)
                {
					p.minionGetBuffed(triggerEffectMinion, 1, 1);
                }
            }
        }
		
	}
}
