using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_068: SimTemplate //* 寒冰行者 Ice Walker
//Your Hero Power also <b><b>Freeze</b>s</b> the target.
//你的英雄技能还会<b>冻结</b>目标。 
    {
        

        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own) p.ownAbilityFreezesTarget++;
            else p.enemyAbilityFreezesTarget++;
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own) p.ownAbilityFreezesTarget--;
            else p.enemyAbilityFreezesTarget--;
        }
    }
}