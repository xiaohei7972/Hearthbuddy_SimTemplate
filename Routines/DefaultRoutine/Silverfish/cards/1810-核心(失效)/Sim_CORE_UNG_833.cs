using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_UNG_833 : SimTemplate //* Lakkari Felhound
	{
		//Taunt. Battlecry: Discard two random cards.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int minCost = 10;
			Handmanager.Handcard hcc = null;
			bool found = false;
			foreach (Handmanager.Handcard hc in p.owncards)
			{
				if (!found && hc.card.nameCN == CardDB.cardNameCN.拉卡利地狱犬 )
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
				Helpfunctions.Instance.ErrorLog("拉卡利地狱犬将弃掉1" + hcc.card.nameCN);
				p.removeCard(hcc);
			}

            minCost = 10;
			hcc = null;
			found = false;
			foreach (Handmanager.Handcard hc in p.owncards)
			{
				if (!found && hc.card.nameCN == CardDB.cardNameCN.拉卡利地狱犬 )
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
				Helpfunctions.Instance.ErrorLog("拉卡利地狱犬将弃掉2" + hcc.card.nameCN);
				p.removeCard(hcc);
			}
        }
    }
}