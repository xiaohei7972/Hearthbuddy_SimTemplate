
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TOY_000 : SimTemplate // 避免报错
    {
        // 在这里可以定义卡牌的属性，如法力值消耗、卡牌类型、效果等等
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                p.minionGetBuffed(triggerEffectMinion, 2, 0);
            }
        }

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                p.minionGetBuffed(triggerEffectMinion, -2, 0);
            }
        }
    }
}
