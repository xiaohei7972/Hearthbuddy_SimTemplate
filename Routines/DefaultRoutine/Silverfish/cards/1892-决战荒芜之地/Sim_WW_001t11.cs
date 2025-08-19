using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 中立 费用：3
	//Ogrefist Boulder
	//魔拳岩
	//Set a minion's statsto 6/7.
	//将一个随从的属性值变为6/7。
	class Sim_WW_001t11 : SimTemplate
	{
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
		{
			if (triggerMinion.handcard.card.CooldownTurn == 0)
			{
				if (target != null)
				{
					p.minionSetAngrToX(target, 6);
					p.minionSetLifetoX(target, 7);
				}
			}

		}

		public override PlayReq[] GetUseAbilityReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				// new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 目标必须敌方随从
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
			};
		}

	}
}
