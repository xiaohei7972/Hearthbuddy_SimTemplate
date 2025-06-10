using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_357l : SimTemplate //* 大师宝箱 Master Chest
//<b>Deathrattle:</b> Give your opponent a fantastic treasure!
//<b>亡语：</b>使你的对手获得一张宝藏牌！ 
	{
		
        
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
	        int cardsCount = (m.own) ? p.enemyAnzCards : p.owncards.Count;
			if (cardsCount > 9)
			{
				if (m.own) p.evaluatePenality -= 45;
				else p.evaluatePenality += 45;
			}
			
            p.drawACard(CardDB.cardNameEN.unknown, !m.own);
        }
	}
}