using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：5 生命值：5
	//Tormented Dreadwing
	//受难的恐翼巨龙
	//<b>Deathrattle:</b> Draw 2 Dragons. Reduce their Costs by (1).
	//<b>亡语：</b>抽两张龙牌，其法力值消耗减少（1）点。
	class Sim_EDR_572 : SimTemplate
	{
        public override void onDeathrattle(Playfield p, Minion m)
        {
            for (int i = 0; i < 2; i++)
			{
				foreach (CardDB.Card card in p.ownDeck)
				{
					if ((TAG_RACE)card.race == TAG_RACE.DRAGON)
					{
						p.drawACard(card.cardIDenum, m.own);
						p.owncards[p.owncards.Count - 1].card.cost -= 1;
						continue;
					}
				}
			}
        }
		
	}
}
