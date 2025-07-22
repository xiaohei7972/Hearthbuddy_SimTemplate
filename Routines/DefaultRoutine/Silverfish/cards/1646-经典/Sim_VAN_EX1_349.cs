using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_349 : SimTemplate //* 神恩术 Divine Favor
//Draw cards until you have as many in hand as your opponent.
//抽若干数量的牌，直到你的手牌数量等同于你对手的手牌数量。 
	{


		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int diff = (ownplay) ? p.enemyAnzCards - p.owncards.Count :  p.owncards.Count - p.enemyAnzCards;
            if (diff >= 1)
            {
                for (int i = 0; i < diff; i++)
                {
                    
                    p.drawACard(CardDB.cardIDEnum.None, ownplay);
                }
            }
		}

	}
}