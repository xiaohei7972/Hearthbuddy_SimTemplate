using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_901: SimTemplate //* 达卡莱附魔师 Drakkari Enchanter
//Your end of turn effects trigger twice.
//你的回合结束效果会生效两次。 
    {
        

        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own) p.ownTurnEndEffectsTriggerTwice++;
            else p.enemyTurnEndEffectsTriggerTwice++;
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.ownTurnEndEffectsTriggerTwice--;
            else p.enemyTurnEndEffectsTriggerTwice--;
        }
    }
}