using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HREngine.Bots
{
	//法术 潜行者 费用：4
	//Serenity
	//平心静气
	//Give all enemy minions -2 Attack. Destroy any with 0 Attack.
	//使所有敌方随从获得-2攻击力。消灭具有0点攻击力的敌方随从。
	class Sim_TTN_483 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			List<Minion> minions = ownplay ? p.enemyMinions.ToList() : p.ownMinions.ToList();
			foreach (Minion minion in minions)
			{
				p.minionGetBuffed(minion, -2, 0);
				if (minion.Angr <= 0)
				{
					p.minionGetDestroyed(minion);
				}
			}
		}

	}
}
