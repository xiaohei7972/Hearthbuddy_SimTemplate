using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：2 攻击力：1 生命值：3
	//Prospector's Caravan
	//勘探者车队
	//At the start of your turn, give all minions in your hand +1/+1.
	//在你的回合开始时，使你手牌中的所有随从牌获得+1/+1。
	class Sim_BAR_033 : SimTemplate
	{
		public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
		{
			if (triggerEffectMinion.own = turnStartOfOwner)
			{
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.type == CardDB.cardtype.MOB)
					{
						hc.addattack++;
						hc.addHp++;
						p.anzOwnExtraAngrHp += 2;
					}
				}
			}

		}

	}
}
