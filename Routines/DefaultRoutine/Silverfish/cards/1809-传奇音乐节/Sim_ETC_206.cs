using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：2
	//Infinitize the Maxitude
	//巅峰无限
	//<b>Discover</b> a spell.Reduce its Cost by (1).<b>Finale:</b> Return this toyour hand at end of turn.
	//<b>发现</b>一张法术牌，其法力值消耗减少（1）点。<b>压轴：</b>在回合结束时将本牌移回你的手牌。
	class Sim_ETC_206 : SimTemplate
	{

		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{


			if (m.own && p.prozis.noDuplicates)
			{
				p.drawACard(CardDB.cardIDEnum.None, m.own, true);
			}

			foreach (Handmanager.Handcard hc in p.owncards)
            {

                if (p.mana == hc.card.getManaCost(p, hc.manacost))
                {
					p.cardsToReturnAtEndOfTurn.Add(CardDB.cardIDEnum.ETC_206);
				}
			}
		}

	}
}
		
