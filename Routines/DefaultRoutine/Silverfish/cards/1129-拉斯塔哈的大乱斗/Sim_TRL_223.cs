using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_223 : SimTemplate //* 迅猛龙之灵 Spirit of the Raptor
//[x]<b>Stealth</b> for 1 turn.After your hero attacks and__kills a minion, draw a card.__
//<b>潜行</b>一回合。在你的英雄攻击并消灭一个随从后，抽一张牌。 
	{
		

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard)
            {
                p.drawACard(CardDB.cardNameEN.unknown, wasOwnCard);
            }
        }
	}
}