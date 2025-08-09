using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：2
	//Delicious Cheese
	//美味奶酪
	//Summon three random @-Cost minions. <i>(Upgrades each turn!)</i>
	//随机召唤三个法力值消耗为（@）的随从。<i>（每回合都会升级！）</i>
	class Sim_VAC_955t : SimTemplate
	{

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;

			p.callKid(p.getRandomCardForManaMinion(hc.card.TAG_SCRIPT_DATA_NUM_1), pos, ownplay);
			p.callKid(p.getRandomCardForManaMinion(hc.card.TAG_SCRIPT_DATA_NUM_1), pos, ownplay);
			p.callKid(p.getRandomCardForManaMinion(hc.card.TAG_SCRIPT_DATA_NUM_1), pos, ownplay);
		}

	}
}
