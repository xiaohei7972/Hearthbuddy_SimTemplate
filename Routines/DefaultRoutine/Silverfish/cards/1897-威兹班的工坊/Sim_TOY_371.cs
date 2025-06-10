using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：5
	//Manufacturing Error
	//加工失误
	//Draw 3 cards. If your deck has no minions, they cost (3) less.
	//抽三张牌。如果你的牌库里没有随从牌，这三张牌的法力值消耗减少（3）点。
	class Sim_TOY_371 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            bool noMinionsInDeck = !p.ownDeck.Any(card => card.type == CardDB.cardtype.MOB);  // 检查牌库中是否有随从牌

            // 抽三张牌
            for (int i = 0; i < 3; i++)
            {
                p.drawACard(CardDB.cardIDEnum.None, ownplay);

                if (noMinionsInDeck && ownplay && p.owncards.Count > 0)
                {
                    // 取刚抽到的牌
                    Handmanager.Handcard lastDrawnCard = p.owncards[p.owncards.Count - 1];
                    // 减少这张牌的法力值消耗
                    lastDrawnCard.manacost = Math.Max(0, lastDrawnCard.manacost - 3);
                }
            }
        }
    }
}
