using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_100 : SimTemplate //* 德雷克塔尔 drekthar
	{
		//<b>战吼：</b>如果该随从的法力值消耗大于你牌库中的所有随从牌，则召唤其中的2个。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 遍历卡组
            bool check = true;
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card deckSpell = CardDB.Instance.getCardDataFromID(deckCard);
                if (deckSpell.type == CardDB.cardtype.MOB && deckSpell.cost >= own.handcard.card.cost)
                {
                    check = false;
                }
            }

            if (check)
            {
                CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.None);
                List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
                int pos = temp.Count;
                p.callKid(kid, pos, (own.own) ? true : false);
                p.callKid(kid, pos + 1, (own.own) ? true : false);
            }
        }
		
	}
}
