using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 圣骑士 费用：2
	//Great Hall
	//大厅
	//Set a minion's Attack and Health to 3.
	//将一个随从的攻击力和生命值变为3。
	class Sim_CORE_REV_983 : SimTemplate
	{
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
		{
			if (triggerMinion.handcard.card.CooldownTurn == 0)
			{
				if (target != null)
				{
					p.minionSetAngrToX(target, 3);
					p.minionSetLifetoX(target, 3);

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
