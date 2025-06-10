using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_343 : SimTemplate //* 石炉守备官 stonehearthvindicator
	{
		//<b>战吼：</b>抽一张法力值消耗小于或等于（3）点的法术牌。在本回合中，其法力值消耗为（0）点。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            bool found1 = false;
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card deckSpell = CardDB.Instance.getCardDataFromID(deckCard);
                if (deckSpell.type == CardDB.cardtype.SPELL)
                {
                    if (!found1 && deckSpell.cost <= 3)
                    {
                        found1 = true;
                        deckSpell.cost = 0;
                        p.drawACard(deckCard, true);                       
                    }
                }
            }
        }
	}
}
