using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 圣骑士 费用：3
	//Temple of Earth
	//大地神殿
	//[x]Choose a friendly minion.Summon a copy of it with+3_Health and <b>Taunt</b>that can't attack.
	//选择一个友方随从。召唤一个它的具有+3生命值和<b>嘲讽</b>且无法攻击的复制。
	class Sim_WON_053t7 : SimTemplate
	{
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
		{
			if (triggerMinion.handcard.card.CooldownTurn == 0)
			{
				if (target != null)
				{
					p.callKid(target.handcard.card, target.zonepos, triggerMinion.own);
				}
			}

		}

		public override PlayReq[] GetUseAbilityReqs()
		{
			return new PlayReq[]
			{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标才能使用
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标必须是友方随从
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标必须是一个随从
			};
		}
		
	}
}
