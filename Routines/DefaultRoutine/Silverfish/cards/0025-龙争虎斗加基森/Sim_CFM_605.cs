using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_605 : SimTemplate //* 龙人侦测者 Drakonid Operative
//[x]<b>Battlecry:</b> If you're holdinga Dragon, <b>Discover</b> acopy of a card in youropponent's deck.
//<b>战吼：</b>如果你的手牌中有龙牌，便<b>发现</b>你对手牌库中一张牌的复制。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own)
            {
                bool dragonInHand = false;
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if ((TAG_RACE)hc.card.race == TAG_RACE.DRAGON)
                    {
                        dragonInHand = true;
                        break;
                    }
                }
                if (dragonInHand)
                {
                    p.drawACard(CardDB.cardNameEN.enchantedraven, m.own, true);
                }
            }
            else
            {
                if (p.enemyAnzCards >= 2)
                {
                    p.drawACard(CardDB.cardNameEN.drakonidcrusher, m.own, true);
                }
            }
        }
    }
}