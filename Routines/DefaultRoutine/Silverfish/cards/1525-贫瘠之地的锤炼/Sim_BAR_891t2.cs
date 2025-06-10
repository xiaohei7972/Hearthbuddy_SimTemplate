using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_891t2 : SimTemplate //* 怒火（等级3） Fury (Rank 3)
	{
		//Give your hero +4_Attack this turn.
		//在本回合中，使你的英雄获得+4攻击力。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionGetTempBuff(p.ownHero, 4, 0);
			p.ownHero.updateReadyness();
		}

	}
}
