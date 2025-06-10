using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_512 : SimTemplate //* 心中的恶魔 Inner Demon
	{
		//Give your hero +8_Attack this turn.
		//在本回合中，使你的英雄获得+8攻击力。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetTempBuff(ownplay ? p.ownHero : p.enemyHero, 8, 0);
        }		
		
	}
}
