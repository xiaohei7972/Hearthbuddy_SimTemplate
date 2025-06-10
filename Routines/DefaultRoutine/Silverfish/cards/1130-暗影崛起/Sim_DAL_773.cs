using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_773 : SimTemplate //* 魔法飞毯 Magic Carpet
//After you play a 1-Cost minion, give it +1 Attack and <b>Rush</b>.
//在你使用一张法力值消耗为（1）的随从牌后，使其获得+1攻击力和<b>突袭</b>。 
	{
		
		public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
		{
			if (summonedMinion.playedFromHand && summonedMinion.own == m.own && summonedMinion.entitiyID != m.entitiyID&&summonedMinion.handcard.card.cost==1)				
			{ 
				p.minionGetBuffed(summonedMinion,1,0);
				p.minionGetRush(summonedMinion);
			}	
		}
	}
}