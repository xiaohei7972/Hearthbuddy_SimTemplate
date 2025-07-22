using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_BT_351 : SimTemplate //* 战斗邪犬 Battlefiend
	{
		//After your hero attacks, gain +1 Attack.
		//在你的英雄攻击后，获得+1攻击力。
		public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            p.minionGetBuffed(own, 1, 0);
        }
		
		
	}
}
