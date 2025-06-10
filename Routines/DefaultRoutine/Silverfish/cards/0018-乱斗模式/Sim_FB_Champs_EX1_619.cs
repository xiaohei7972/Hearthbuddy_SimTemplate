using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_EX1_619 : SimTemplate //* 生而平等 Equality
	{
		//Change the Health of ALL minions to 1.
		//将所有随从的生命值变为1。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			foreach (Minion m in p.ownMinions)
			{
				p.minionSetLifetoX(m, 1);
			}
			foreach (Minion m in p.enemyMinions)
			{
				p.minionSetLifetoX(m, 1);
			}
		}

	}
}
