using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_098: SimTemplate //* 墓穴潜伏者 Tomb Lurker
//[x]<b>Battlecry:</b> Add a random<b>Deathrattle</b> minion that diedthis game to your hand.
//<b>战吼：</b>随机将一个在本局对战中死亡并具有<b>亡语</b>的随从置入你的手牌。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            var temp = (own.own) ? Probabilitymaker.Instance.ownGraveyard : Probabilitymaker.Instance.enemyGraveyard;
            CardDB.Card c;
            bool found = false;
            foreach (var gi in temp)
            {
                c = CardDB.Instance.getCardDataFromID(gi.Key);
                if (c.deathrattle)
                {
                    p.drawACard(c.nameEN, own.own, true);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                foreach (var gi in p.diedMinions)
                {
                    if (gi.own == own.own)
                    {
                        c = CardDB.Instance.getCardDataFromID(gi.cardid);
                        if (c.deathrattle)
                        {
                            p.drawACard(c.nameEN, own.own, true);
                            break;
                        }
                    }
                }
            }
        }
    }
}