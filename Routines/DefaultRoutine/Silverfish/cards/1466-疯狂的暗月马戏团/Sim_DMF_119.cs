using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_119 : SimTemplate //* 邪恶低语 Wicked Whispers
	{
		//Discard your lowest Cost card. Give your minions +1/+1.
		//弃掉你手牌中法力值消耗最低的牌。使你的所有随从获得+1/+1。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int minCost = 10;
			Handmanager.Handcard hcc = null;
			bool found = false;
			foreach (Handmanager.Handcard hc in p.owncards)
			{
				if (!found && hc.card.nameCN == CardDB.cardNameCN.邪恶低语 )
                {
					found = true;
                    continue;
                }
				if(hc.card.cost < minCost){
					hcc = hc;
					minCost = hc.card.cost;
				}
			}
			if(hcc != null){
				Helpfunctions.Instance.ErrorLog("邪恶低语将弃掉" + hcc.card.nameCN);
				p.removeCard(hcc);
			}
			p.allMinionOfASideGetBuffed(ownplay, 1, 1);
		}
	}
}
