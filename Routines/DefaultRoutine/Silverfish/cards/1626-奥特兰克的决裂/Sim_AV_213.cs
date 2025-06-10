using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_213 : SimTemplate //* 活力涌现 vitalitysurge
	{
		//抽一张随从牌。为你的英雄恢复等同于其法力值消耗的生命值。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 遍历卡组
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card deckSpell = CardDB.Instance.getCardDataFromID(deckCard);
                if (deckSpell.type == CardDB.cardtype.MOB)
                {
                    p.drawACard(deckCard, true);
                    p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -deckSpell.cost);
                }
            }
        }
		
	}
}
