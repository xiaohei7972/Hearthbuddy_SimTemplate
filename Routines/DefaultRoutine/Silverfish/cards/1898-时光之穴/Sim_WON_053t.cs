using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 圣骑士 费用：3
	//Outskirts of Lordaeron
	//洛丹伦城郊
	//Choose a minion. Destroy all minions with less Attack than it.
	//选择一个随从，消灭所有攻击力小于它的随从。
	class Sim_WON_053t : SimTemplate
	{
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
		{
			if (triggerMinion.handcard.card.CooldownTurn == 0)
			{
				if (target != null)
				{
					List<Minion> minions = new List<Minion>();
					minions.AddRange(p.ownMinions);
					minions.AddRange(p.enemyMinions);
					minions.Remove(target);
					int angr = target.Angr;
					minions.ForEach((m) =>
					{
						if (m.Angr < angr)
							p.minionGetDestroyed(m);
					});
				}
			}

		}

		public override PlayReq[] GetUseAbilityReqs()
		{
			return new PlayReq[]
			{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标才能使用
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标必须是一个随从
			};
		}

	}
}
