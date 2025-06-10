using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS3_019 : SimTemplate //* 考瓦斯·血棘 Kor'vas Bloodthorn
	{
        //[x]<b>Charge</b>, <b>Lifesteal</b>After you play a card with<b>Outcast</b>, return this toyour hand.
        //<b>冲锋</b>，<b>吸血</b>在你使用一张<b>流放</b>牌后，将该随从移回你的手牌。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if(wasOwnCard && triggerEffectMinion.own)
            {
                if (hc.card.Outcast)
                {
                    p.minionReturnToHand(triggerEffectMinion, true, 0);
                }
            }
        }
    }
}
