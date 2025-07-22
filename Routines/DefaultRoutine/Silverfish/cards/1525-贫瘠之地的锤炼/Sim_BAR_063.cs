using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_063 : SimTemplate //* 甜水鱼人斥候 Lushwater Scout
	{
		//After you summon a Murloc, give it +1 Attack and <b>Rush</b>.
		//在你召唤一个鱼人后，使其获得+1攻击力和<b>突袭</b>。
		public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
		{
			if((TAG_RACE)summonedMinion.handcard.card.race == TAG_RACE.MURLOC && summonedMinion.own == m.own )
			{
				// Helpfunctions.Instance.ErrorLog("斥候buff"+summonedMinion.handcard.card.chnName);
           		p.minionGetBuffed(summonedMinion, 1, 0);
				p.minionGetRush(summonedMinion);
			}
		}		
	}
}
