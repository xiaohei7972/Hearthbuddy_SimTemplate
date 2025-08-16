using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 作弊的狗头人 cheatysnobold
    //在一个敌人被<b>冻结</b>后，对其造成3点 伤害。
    class Sim_AV_251 : SimTemplate
    {
        public override void onMinionFrozen(Playfield p, Minion triggerMinion, Minion frozentarget)
        {

            if (frozentarget != null)
            {
                if (!frozentarget.own)
                    p.minionGetDamageOrHeal(frozentarget, 3);
            }
        }

    }
}
