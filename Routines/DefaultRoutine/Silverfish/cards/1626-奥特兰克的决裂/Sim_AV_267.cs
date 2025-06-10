using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_267 : SimTemplate //* 凯丽娅邪魂 cariafelsoul
	{
		//<b>战吼：</b> 变形成为你牌库中一个恶魔的6/6复制。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_267e2);
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
                if (deckMinion.type == CardDB.cardtype.MOB && (TAG_RACE)deckMinion.race == TAG_RACE.DEMON)
                {
                    p.minionTransform(own, kid);
                }
            }
        }
		
	}
}
