using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_089: SimTemplate //* 冰钓术 Ice Fishing
//Draw 2 Murlocs from your deck.
//从你的牌库中抽两张鱼人牌。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                CardDB.Card c;
                int count = 0;
                foreach (KeyValuePair<CardDB.cardIDEnum, int> cid in p.prozis.turnDeck)
                {
                    c = CardDB.Instance.getCardDataFromID(cid.Key);
                    if ((TAG_RACE)c.race == TAG_RACE.MURLOC)
                    {
                        for (int i = 0; i < cid.Value; i++)
                        {
                            p.drawACard(cid.Key, ownplay);
                            count++;
                            if (count > 1) break;
                        }
                        if (count > 1) break;
                    }
                }
            }
            else
            {
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
            }
        }
    }
}