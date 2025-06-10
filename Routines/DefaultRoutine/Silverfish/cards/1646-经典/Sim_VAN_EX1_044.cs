using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_044 : SimTemplate //* 任务达人 Questing Adventurer
	{
		//Whenever you play a card, gain +1/+1.
		//每当你使用一张牌时，便获得+1/+1。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard)
            {
                p.minionGetBuffed(triggerEffectMinion, 1, 1);
            }
        }
	}
}