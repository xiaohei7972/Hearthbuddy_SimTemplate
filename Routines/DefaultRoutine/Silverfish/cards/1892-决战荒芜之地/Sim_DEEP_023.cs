using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：2 攻击力：2 生命值：2
	//Hidden Gem
	//隐藏宝石
	//<b>Stealth</b>At the end of your turn, restore #2 Health to all friendly characters.
	//<b>潜行</b>。在你的回合结束时，为所有友方角色恢复#2点生命值。
	class Sim_DEEP_023 : SimTemplate
	{
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            // 在回合结束时触发效果
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                // 为所有友方角色恢复2点生命值
                p.allCharsOfASideGetDamage(!triggerEffectMinion.own, -2);
            }
        }
    }
}
