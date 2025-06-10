using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_REV_515 : SimTemplate //* 豪宅管家俄里翁 orionmansionmanager
//在一个友方奥秘被揭示后，施放一个不同的法师奥秘并获得+2/+2。
//After a friendly Secret is revealed, cast a different Mage Secret and gain +2/+2.
	{

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                p.minionGetBuffed(triggerEffectMinion, 2, 2);
            }
        }
    }
}
