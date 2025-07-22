using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_286 : SimTemplate //* 邪能行者 felwalker
	{
		//<b>嘲讽</b>，<b>战吼：</b>从你的手牌中施放法力值消耗最高的邪能法术。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Handmanager.Handcard> temp = p.owncards;
            temp.Sort((a, b) => -a.card.cost.CompareTo(b.card.cost));
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.SpellSchool == CardDB.SpellSchool.FEL && hc.card.type == CardDB.cardtype.SPELL)
                {
                    hc.card.sim_card.onCardPlay(p, own.own, target,0);
                }
            }


            //int maxCost = 0;
            //Handmanager.Handcard hcc = null;
            //bool found = false;
            //foreach (Handmanager.Handcard hc in p.owncards)
            //{
            //    if (!found && hc.card.SpellSchool == CardDB.SpellSchool.FEL && hc.card.type == CardDB.cardtype.SPELL)
            //    {
            //        found = true;
            //        continue;
            //    }
            //    if (hc.card.cost > maxCost)
            //    {
            //        hcc = hc;
            //        maxCost = hc.card.cost;
            //    }
            //}
            //if (hcc != null)
            //{
            //    p.drawACard(hcc.card.nameEN, own.own, true);
            //}
        }
		
	}
}
