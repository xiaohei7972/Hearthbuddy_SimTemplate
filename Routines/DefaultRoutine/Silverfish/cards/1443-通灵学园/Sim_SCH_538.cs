using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_538 : SimTemplate //* 金牌猎手克里 Ace Hunter Kreen
	{
        //Your other characters are <b>Immune</b> while attacking.
        //你的其他角色在攻击时具有<b>免疫</b>。
        public override void onAuraStarts(Playfield p, Minion m)
        {
            if (m.own)
            {
                foreach (Minion mm in p.ownMinions)
                {
                    if (mm.entitiyID == m.entitiyID) continue;
                    mm.immuneWhileAttacking = true;
                }
                p.ownHero.immuneWhileAttacking = true;
            }
        }

    }
}
