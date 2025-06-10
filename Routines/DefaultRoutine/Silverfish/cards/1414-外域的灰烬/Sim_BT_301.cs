using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_301 : SimTemplate //* 夜影主母 Nightshade Matron
	{
		//<b>Rush</b><b>Battlecry:</b> Discard your highest Cost card.
		//<b>突袭，战吼：</b>弃掉你的法力值消耗最高的牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int maxCost = 0;
			Handmanager.Handcard hcc = null;
			bool found = false;
			foreach (Handmanager.Handcard hc in p.owncards)
			{
				if (!found && hc.card.nameCN == CardDB.cardNameCN.夜影主母 )
                {
					found = true;
                    continue;
                }
				if(hc.card.cost > maxCost){
					hcc = hc;
					maxCost = hc.card.cost;
				}
			}
			if(hcc != null){
				Helpfunctions.Instance.ErrorLog("夜影主母将弃掉" + hcc.card.nameCN);
				p.removeCard(hcc);
			}
		}

	}
}
