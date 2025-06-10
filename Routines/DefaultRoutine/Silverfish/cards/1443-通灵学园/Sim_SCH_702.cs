using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_702 : SimTemplate //* 邪能学说 Felosophy
	{
		//[x]Copy the lowest CostDemon in your hand.<b>Outcast:</b> Give both +1/+1.
		//复制你手牌中法力值消耗最低的恶魔牌。<b>流放：</b>使这两张恶魔牌获得+1/+1。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
		{
			CardDB.Card card = null;
			int mincost = 10;
			foreach(Handmanager.Handcard hc in p.owncards)
            {
				if(hc.card.race == CardDB.Race.DEMON || hc.card.race == CardDB.Race.ALL)
                {
					if(mincost > hc.manacost)
                    {
						mincost = hc.manacost;
						card = hc.card;
                    }
				}
            }
			if(card != null)
            {
				p.drawACard(card.cardIDenum, ownplay, true);
				if (outcast)
				{
					foreach (Handmanager.Handcard hc in p.owncards)
					{
						if (hc.card.cardIDenum == card.cardIDenum)
						{
							hc.addattack++;
							hc.addHp++;
						}
					}
					p.evaluatePenality -= 5;
				}
			}
			
		}
	}
}
