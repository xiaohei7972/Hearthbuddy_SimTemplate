using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOD_013 : SimTemplate //* 龙鳞祭司 Cleric of Scales
	{
		//<b>Battlecry:</b> If you're holding a Dragon, <b>Discover</b> a spell from your deck.
		//<b>战吼：</b>如果你的手牌中有龙牌，便<b>发现</b>你牌库中的一张法术牌。
		
		
		 public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
			if(m.own)
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
				if(dragonInHand) p.drawACard(CardDB.cardNameEN.shieldbearer, m.own, true);
			}
			else
			{
                if (p.enemyAnzCards >= 2) p.drawACard(CardDB.cardNameEN.shieldbearer, m.own, true);
			}
        }
	}
}
