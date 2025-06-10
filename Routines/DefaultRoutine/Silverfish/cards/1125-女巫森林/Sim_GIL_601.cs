using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_601 : SimTemplate //* 巨鳞蠕虫 Scaleworm
//<b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Rush</b>.
//<b>战吼：</b>如果你的手牌中有龙牌，便获得+1攻击力和<b>突袭</b>。 
	{
		

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
				if(dragonInHand)
				{
					p.minionGetBuffed(m, 1, 0);
					p.minionGetRush(m);
                }
			}
			else
			{
				if (p.enemyAnzCards >= 2)
				{
					p.minionGetBuffed(m, 1, 0);
					p.minionGetRush(m);
                }					
			}
        }
    }
}