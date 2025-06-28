using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：2 攻击力：2 生命值：3
	//Twisted Webweaver
	//扭曲的织网蛛
	//[x]Whenever you play anotherminion you've alreadyplayed, draw a card.
	//每当你使用其他的你已经使用过的随从牌，抽一张牌。
	class Sim_EDR_540 : SimTemplate
	{
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
			if (p.ownMinionsPlayedThisGame.Exists((MinionsPlayedThisGame) => MinionsPlayedThisGame == hc.card.cardIDenum))
			{
				p.drawACard(CardDB.cardNameEN.unknown, triggerEffectMinion.own);
			}
        }
		
	}
}
