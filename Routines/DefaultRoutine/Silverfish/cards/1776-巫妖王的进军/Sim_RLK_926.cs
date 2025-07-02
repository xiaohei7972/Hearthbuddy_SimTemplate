using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：4 生命值：5
	//Bloodied Knight
	//浴血骑士
	//[x]At the end of your turn,deal 2 damage toyour hero.
	//在你的回合结束时，对你的英雄造成2点伤害。
	class Sim_RLK_926 : SimTemplate
	{
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
			if (triggerEffectMinion.own == turnEndOfOwner)
			{
				p.minionGetDamageOrHeal(triggerEffectMinion.own ? p.ownHero : p.enemyHero, 2);
			}
        }
		
	}
}
