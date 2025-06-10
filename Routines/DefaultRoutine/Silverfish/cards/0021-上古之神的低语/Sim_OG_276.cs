using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_276 : SimTemplate //* 苦战傀儡 Blood Warriors
//Add a copy of each damaged friendly minion to your hand.
//复制所有受伤的友方随从，并将其置入你的手牌。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;

            foreach (Minion m in temp)
            {
                if (m.wounded) p.drawACard(m.handcard.card.nameEN, ownplay, true);
            }
        }
    }
}