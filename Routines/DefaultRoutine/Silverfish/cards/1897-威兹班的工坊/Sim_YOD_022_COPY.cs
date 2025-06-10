using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：1 攻击力：1 生命值：3
	//Risky Skipper
	//冒进的艇长
	//After you play a minion, deal 1 damage to all_minions.
	//在你使用一张随从牌后，对所有随从造成1点伤害。
	class Sim_YOD_022_COPY : SimTemplate
	{
        public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            // 在己方召唤随从后，对所有随从造成1点伤害
            p.allMinionOfASideGetDamage(true, 1);
            p.allMinionOfASideGetDamage(false, 1);
        }
    }
}
