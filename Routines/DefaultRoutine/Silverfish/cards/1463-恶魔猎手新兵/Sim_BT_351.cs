using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_351 : SimTemplate //* 战斗邪犬 Battlefiend
	{
        //After your hero attacks, gain +1 Attack.
        //在你的英雄攻击后，获得+1攻击力。
        public override void onHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
		{
			if (triggerMinion.own == hero.own) p.minionGetBuffed(triggerMinion, 1, 0);
		}

	}
}
