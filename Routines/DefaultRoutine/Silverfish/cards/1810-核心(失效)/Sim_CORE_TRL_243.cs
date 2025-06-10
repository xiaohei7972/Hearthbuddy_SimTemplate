using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_TRL_243 : SimTemplate //飞扑
	{

//    在本回合中,使你的英雄获得+2攻击力.
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.minionGetTempBuff(p.ownHero, 2, 0);
            }
            else
            {
                p.minionGetTempBuff(p.enemyHero, 2, 0);
            }
		}

	}
}