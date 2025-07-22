using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_016 : SimTemplate //* 潜伏帷幕 Shroud of Concealment
	{
        //Draw 2 minions. Any played this turn gain <b>Stealth</b> for 1 turn.
        //抽两张随从牌，在本回合中使用则使其获得<b>潜行</b>一回合。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int cnt = 2;
            // 遍历卡组
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card minion = CardDB.Instance.getCardDataFromID(deckCard);
                if (cnt > 0 && minion.type == CardDB.cardtype.MOB)
                {
                    p.drawACard(deckCard, true);
                    cnt--;
                }
            }
        }

    }
}
