using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_163 : SimTemplate //* 过期货物专卖商 Expired Merchant
	{
		//[x]<b>Battlecry:</b> Discard yourhighest Cost card.<b>Deathrattle:</b> Add 2 copiesof it to your hand.
		//<b>战吼：</b>弃掉你的法力值消耗最高的牌。<b>亡语：</b>将弃掉的牌的两张复制置入你的手牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int maxCost = 0;
			Handmanager.Handcard hcc = null;
			bool found = false;
			foreach (Handmanager.Handcard hc in p.owncards)
			{
				if (!found && hc.card.nameCN == CardDB.cardNameCN.过期货物专卖商 )
                {
					found = true;
                    continue;
                }
				if(hc.getManaCost(p) > maxCost){
					hcc = hc;
					maxCost = hc.getManaCost(p);
				}
			}
			if(hcc != null){
				Helpfunctions.Instance.ErrorLog(CardDB.cardNameCN.过期货物专卖商.ToString() + hcc.card.nameCN.ToString());
				own.deathrattle2 = hcc.card;
				if (hcc.card.sim_card != null) hcc.card.sim_card.onHandCardRemoved(p, hcc);
				p.removeCard(hcc);
			}
		}
		public override void onDeathrattle(Playfield p, Minion m)
		{
			if(m.deathrattle2 != null ) {
				// Helpfunctions.Instance.ErrorLog("过期商贩亡语是："+ m.deathrattle2.nameCN);
				p.drawACard(m.deathrattle2.cardIDenum, m.own, true);
				p.drawACard(m.deathrattle2.cardIDenum, m.own, true);
			}
		}
	}
}