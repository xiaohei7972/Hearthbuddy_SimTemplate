using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_446 : SimTemplate //* 虚触侍从 Voidtouched Attendant
	{
        //Both heroes take one extra damage from all sources.
        // 双方英雄受到的所有伤害提高一点。
        // 随从异能写在 Minion.cs 的 getDamageOrHeal 里了

        public override void onAuraStarts(Playfield p, Minion m)
        {
            p.anzOldWoman++;
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            p.anzOldWoman--;
        }
    }
}
