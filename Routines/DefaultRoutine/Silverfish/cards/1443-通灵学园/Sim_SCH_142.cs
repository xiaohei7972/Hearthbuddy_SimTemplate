using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_142 : SimTemplate //* 贪婪的书虫 Voracious Reader
	{
		//At the end of your turn, draw until you have 3 cards.
		//在你的回合结束时，抽若干牌，直至手牌数量达到3张。
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {

            int cardstodraw = 0;
			int cardnum = (triggerEffectMinion.own) ? p.owncards.Count : p.enemyAnzCards;
            if (cardnum <= 2)
            {
                cardstodraw = 3 - cardnum; 
            }

            for (int i = 0; i < cardstodraw; i++)
            {
                p.drawACard(CardDB.cardIDEnum.None, triggerEffectMinion.own);
            }
        }
		
	}
}
