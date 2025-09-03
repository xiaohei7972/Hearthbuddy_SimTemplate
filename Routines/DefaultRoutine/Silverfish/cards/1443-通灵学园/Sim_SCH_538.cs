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
            foreach (Minion minion in m.own ? p.ownMinions : p.enemyMinions)
            {
                if (minion.entitiyID == m.entitiyID) continue;
                minion.immuneWhileAttacking = true;
            }
            if (m.own) p.ownHero.immuneWhileAttacking = true;
            else p.enemyHero.immuneWhileAttacking = true;
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            foreach (Minion minion in m.own ? p.ownMinions : p.enemyMinions)
            {
                if (minion.entitiyID == m.entitiyID) continue;
                minion.immuneWhileAttacking = false;
            }
            if (m.own) p.ownHero.immuneWhileAttacking = false;
            else p.enemyHero.immuneWhileAttacking = false;
        }

    }
}
