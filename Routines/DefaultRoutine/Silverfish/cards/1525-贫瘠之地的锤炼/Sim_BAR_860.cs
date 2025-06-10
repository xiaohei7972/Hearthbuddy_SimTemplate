using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_860 : SimTemplate //* 火焰术士弗洛格尔 Firemancer Flurgl
	{
		//[x]After you play a Murloc,deal 1 damage toall enemies.
		//在你使用一张鱼人牌后，对所有敌人造成1点伤害。
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
		{
			if (triggerEffectMinion.own == wasOwnCard)
			{
				// 我方打出鱼人
				if (triggerEffectMinion.own && hc.card.race == CardDB.Race.MURLOC || hc.card.race == CardDB.Race.ALL)
				{
					//p.evaluatePenality -= 2;
					p.allCharsOfASideGetDamage(!wasOwnCard, 1);
					//p.allMinionOfASideGetDamage(!wasOwnCard, 1);
					// 剧毒，杀死所有敌方随从
                    if (triggerEffectMinion.poisonous)
                    {
						foreach (Minion m in p.enemyMinions)
						{
							p.evaluatePenality -= (m.Hp + m.Angr) * 2;
							p.minionGetDestroyed(m);
						}
					}
				}
				// 敌方出牌，默认全是鱼人
				//else if(!triggerEffectMinion.own) {
				//	p.allMinionOfASideGetDamage(!wasOwnCard, 1);
				//}
				
			}
		}
		
	}
}
