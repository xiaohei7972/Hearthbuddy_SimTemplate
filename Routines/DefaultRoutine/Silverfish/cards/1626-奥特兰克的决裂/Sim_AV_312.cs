using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_312 : SimTemplate //* 献祭召唤者 sacrificialsummoner
	{
		//<b>战吼：</b>消灭一个友方随从。从你的牌库中召唤一个法力值消耗增加（1）点的随从。

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetDestroyed(target);
                foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
                {
                    // ID 转卡
                    CardDB.cardIDEnum deckCard = kvp.Key;
                    CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
                    // 法力值消耗增加（1）点的随
                    if (deckMinion.type == CardDB.cardtype.MOB && deckMinion.cost == (target.handcard.card.cost + 1))
                    {
                        int pos = p.ownMinions.Count;
                        p.callKid(deckMinion, pos, own.own);
                    }
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
		
	}
}
