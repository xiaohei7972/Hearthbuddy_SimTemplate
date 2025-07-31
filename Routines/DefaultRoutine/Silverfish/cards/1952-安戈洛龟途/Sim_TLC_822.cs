using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：2 攻击力：2 生命值：3
	//Dinositter
	//恐龙保育师
	//[x]At the end of yourturn, reduce the Costof a random Beast inyour hand by (1).
	//在你的回合结束时，随机使你手牌中一张野兽牌的法力值消耗减少（1）点。
	class Sim_TLC_822 : SimTemplate
	{
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			if (triggerEffectMinion.own == turnEndOfOwner)
			{
				if (triggerEffectMinion.own)
				{
					foreach (Handmanager.Handcard handcard in p.owncards)
					{
						if (handcard.card.type == CardDB.cardtype.MOB && handcard.card.race == CardDB.Race.PET)
							handcard.card.cost = Math.Min(0, handcard.card.cost--);
					}
				}
			}
			
		}

	}
}
