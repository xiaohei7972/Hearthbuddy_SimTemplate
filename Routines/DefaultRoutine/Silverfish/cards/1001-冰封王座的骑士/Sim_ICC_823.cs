using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_823: SimTemplate //* 模拟幻影 Simulacrum
//Copy the lowest Cost minion in your hand.
//复制你手牌中法力值消耗最低的随从牌。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                Handmanager.Handcard hcCopy = null;
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.MOB)
                    {
                        if (hcCopy == null) hcCopy = hc;
                        else
                        {
                            if (hcCopy.manacost > hc.manacost) hcCopy = hc;
                        }
                    }
                }
                if (hcCopy != null) p.drawACard(hcCopy.card.nameEN, ownplay, true);
            }
        }
    }
}