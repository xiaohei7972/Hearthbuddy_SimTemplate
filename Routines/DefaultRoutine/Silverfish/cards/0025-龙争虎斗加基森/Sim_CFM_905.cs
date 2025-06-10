using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_905 : SimTemplate //* 三教九流 Small-Time Recruits
//[x]Draw three 1-Costminions from your deck.
//从你的牌库中抽三张法力值消耗为（1）的随从牌。 
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
                    if (c.cost == 1)
                    {
                        for (int i = 0; i < cid.Value; i++)
                        {
                            p.drawACard(c.nameEN, true);
                            count++;
                            if (count > 2) break;
                        }
						if (count > 2) break;
                    }
                }
            }
        }
    }
}