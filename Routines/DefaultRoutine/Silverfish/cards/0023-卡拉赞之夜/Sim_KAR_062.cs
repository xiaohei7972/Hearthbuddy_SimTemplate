using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_062 : SimTemplate //* 虚空幽龙史学家 Netherspite Historian
//<b>Battlecry:</b> If you're holding a Dragon, <b>Discover</b>a Dragon.
//<b>战吼：</b>如果你的手牌中有龙牌，便<b>发现</b>一张龙牌。 
	{
		
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			if(own.own)
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
				if(dragonInHand)
				{
					p.drawACard(CardDB.cardNameEN.drakonidcrusher, own.own, true);
                }
			}
			else
			{
				if (p.enemyAnzCards >= 2)
				{
					p.drawACard(CardDB.cardNameEN.drakonidcrusher, own.own, true);
                }					
			}
        }
    }
}