using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 中立 费用：4
	//Badlands Jail
	//荒芜之地监狱
	//Make a minion go <b>Dormant</b> for 3 turns.
	//使一个随从<b>休眠</b>3回合。
	class Sim_WW_359t : SimTemplate
	{
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
		{
			if (p.enemyMinions.Count > 0)
				p.evaluatePenality -= 200;
			// 检查目标是否为有效的敌方非休眠随从
			// if (target != null && !target.own && target.dormant == 0 && (CardDB.cardtype)target.handcard.card.type == CardDB.cardtype.MOB)
			if (triggerMinion.handcard.card.CooldownTurn == 0)
			{
				if (target != null)
				{
					target.dormant += 3;
				}
			}
			
		}

		public override PlayReq[] GetUseAbilityReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 目标必须敌方随从
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
			};
		}

	}
}
