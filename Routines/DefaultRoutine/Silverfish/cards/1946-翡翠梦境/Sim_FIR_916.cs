using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：2
	//Smoldering Ascent
	//焚火飞升
	//Deal ${0} damage to all enemy minions. <i>(Upgrades each turn,but discards after {1}!)</i>@Deal ${0} damage to all enemy minions.<i>(Discards this turn!)</i>
	//对所有敌方随从造成${0}点伤害。<i>（每回合都会升级，但本牌会在{1}回合后弃掉！）</i>@对所有敌方随从造成${0}点伤害。<i>（本牌会在本回合弃掉！）</i>
	class Sim_FIR_916 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			p.allMinionOfASideGetDamage(!ownplay, hc.card.TAG_SCRIPT_DATA_NUM_1);
		}

		public override void onTurnEndsTrigger(Playfield p, Handmanager.Handcard hc, bool turnEndOfOwner)
		{
			if (turnEndOfOwner)
			{
				hc.card.TAG_SCRIPT_DATA_NUM_1++;
				if (hc.card.TAG_SCRIPT_DATA_NUM_1 > 2)
				{
					hc.temporary = true;
				}
			}
		}

	}
}
