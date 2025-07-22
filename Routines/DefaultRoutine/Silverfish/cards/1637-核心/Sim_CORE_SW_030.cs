using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：3 攻击力：2 生命值：4
	//Cargo Guard
	//货物保镖
	//At the end of your turn, gain 3 Armor.
	//在你的回合结束时，获得3点护甲值。
	class Sim_CORE_SW_030 : SimTemplate
	{
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                if (triggerEffectMinion.own)
                {
                    p.minionGetArmor(p.ownHero, 3);
                    
                }
                else
                {
                    p.minionGetArmor(p.enemyHero, 3);
                }
            }
        }
		
	}
}
