using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_803 : SimTemplate //* 民兵指挥官
	{
		//突袭，战吼：在本回合获得+3攻击力。

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.minionGetTempBuff(own, 3, 0);
			int num = (own.own) ? p.enemyMinions.Count : p.ownMinions.Count;
			if (num == 0) p.evaluatePenality += 10;
		}
	}
}