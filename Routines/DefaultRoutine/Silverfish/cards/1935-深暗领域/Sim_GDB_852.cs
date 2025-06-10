using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：1
	//Arkonite Revelation
	//阿肯尼特的启示
	//Draw a card. If it's a spell, it costs (1) less.
	//抽一张牌。如果该牌是法术牌，则其法力值消耗减少（1）点。
	class Sim_GDB_852 : SimTemplate
	{
		/// <summary>
        /// 施放法术时的效果
        /// </summary>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 抽一张牌
            p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);

            // 获取最新抽到的牌
            Handmanager.Handcard drawnCard = p.owncards[p.owncards.Count - 1];

			// 抽一张牌
            // Handmanager.Handcard drawnCard = p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);

            // 如果抽到的牌是法术牌，减少其法力值消耗
            if (drawnCard.card.type == CardDB.cardtype.SPELL)
            {
                drawnCard.manacost = Math.Max(0, drawnCard.manacost - 1);
            }
        }
		
	}
}
