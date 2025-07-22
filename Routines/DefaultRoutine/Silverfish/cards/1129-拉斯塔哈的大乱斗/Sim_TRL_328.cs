using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_328: SimTemplate //* 指挥官沃恩 War Master Voone
//<b>Battlecry:</b> Copy allDragons in your hand.
//<b>战吼：</b>复制你手牌中的所有龙牌。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
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
                if (hcCopy != null) p.drawACard(hcCopy.card.nameEN, own.own, true);
            }
        }
    }
}