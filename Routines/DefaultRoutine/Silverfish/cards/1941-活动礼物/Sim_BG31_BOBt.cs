using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：0
	//Freeze the Shop
	//冻结商店
	//<b>Freeze</b> all enemy minions.
	//<b>冻结</b>所有敌方随从。
	class Sim_BG31_BOBt : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			List<Minion> minions = (ownplay) ? p.enemyMinions : p.ownMinions;
			foreach (Minion minion in minions)
			{
				p.minionGetFrozen(minion);
			}
		}

	}
}
