using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：7 攻击力：4 生命值：9
	//Gonk, the Raptor
	//贡克，迅猛龙之神
	//After your hero attacks and_kills a minion, it may_attack again.
	//在你的英雄攻击并消灭一个随从后，便可再次攻击。
	class Sim_TRL_241 : SimTemplate
	{
		public override void afterHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
		{
			if (triggerMinion.own == hero.own)
			{
				if (target != null)
				{
					if (target.Hp < 1)
					{
						hero.numAttacksThisTurn = 0;
						hero.updateReadyness();
					}
				}
			}
		}

	}
}
