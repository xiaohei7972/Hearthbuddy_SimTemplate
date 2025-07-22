using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_258 : SimTemplate //* 无羁元素 Unbound Elemental
	{
		//Whenever you play a card_with <b>Overload</b>, gain_+1/+1.
		//每当你使用一张具有<b>过载</b>的牌，便获得+1/+1。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (wasOwnCard == triggerEffectMinion.own && hc.card.overload > 0)
            {
                p.minionGetBuffed(triggerEffectMinion, 1, 1);
            }
        }

    }
}
