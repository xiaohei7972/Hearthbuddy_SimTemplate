using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：4 攻击力：2 生命值：7
	//High Priest Amet
	//高阶祭司阿门特
	//[x]Whenever you summon aminion, set its Health equalto this minion's.
	//每当你召唤一个随从，将其生命值变为与本随从相同。
	class Sim_ULD_262 : SimTemplate
	{
		public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
		{
			// 检查召唤的随从是否是机械
			if (triggerEffectMinion.entitiyID != summonedMinion.entitiyID && triggerEffectMinion.own == summonedMinion.own)
			{
				p.minionSetLifetoX(summonedMinion, triggerEffectMinion.Hp);
			}
		}

	}
}
