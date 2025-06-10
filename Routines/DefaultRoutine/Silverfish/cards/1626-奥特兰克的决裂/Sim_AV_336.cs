using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_336 : SimTemplate //* 空军指挥官艾克曼 wingcommanderichman
	{
		//<b>战吼：</b>从你的牌库中召唤一只野兽并使其获得<b>突袭</b>。如果它在本回合中消灭了一个随从，重复此效果。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 遍历卡组
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
                // 看看还有没有随从?
                if (deckMinion.type == CardDB.cardtype.MOB && deckMinion.race == CardDB.Race.BEAST)
                {
                    deckMinion.Rush = true;
                    int pos = p.ownMinions.Count;
                    p.callKid(deckMinion, pos, own.own);
                    //p.minionGetBuffed(p.ownMinions[pos], p.deckAngrBuff, p.deckHpBuff);
                    break;
                }
            }
        }		
		
	}
}
