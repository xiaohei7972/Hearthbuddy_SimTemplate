using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_005 : SimTemplate //* 麦迪文的残影 Echo of Medivh
//Put a copy of each friendly minion into your hand.
//复制你的所有随从，并将其置入你的手牌。 
    {

        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;

            foreach (Minion m in temp)
            {
                p.drawACard(m.handcard.card.nameEN, ownplay, true);
            }
            
        }


    }

}