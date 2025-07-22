using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_308 : SimTemplate //* 墓地污染者 gravedefiler
	{
		//<b>战吼：</b>复制你手牌中的一张邪能法术牌。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            Handmanager.Handcard hcCopy = null;
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.SpellSchool == CardDB.SpellSchool.FEL && hc.card.type == CardDB.cardtype.SPELL)
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
