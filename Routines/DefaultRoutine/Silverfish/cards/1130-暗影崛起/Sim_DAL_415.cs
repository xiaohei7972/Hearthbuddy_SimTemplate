using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_415 : SimTemplate //* 怪盗恶霸 EVIL Miscreant
//<b>Combo:</b> Add two random <b>Lackeys</b> to your hand.
//<b>连击：</b>随机将两张<b>跟班</b>牌置入你的手牌。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			if (p.cardsPlayedThisTurn >= 1)
			{
				CardDB.Card c;
				int count = 0;
				foreach (KeyValuePair<CardDB.cardIDEnum, int> cid in p.prozis.turnDeck)
				{
					c = CardDB.Instance.getCardDataFromID(cid.Key);
					for (int i = 0; i < cid.Value; i++)
					{
						p.drawACard(c.nameEN, true);
						count++;
						if (count > 1) break;
					}	
					if (count > 1) break;
				}
				
			}	
        }
    }
}