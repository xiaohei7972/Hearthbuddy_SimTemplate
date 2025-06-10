
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TOY_330t5 : SimTemplate // 避免报错
    {
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnStormwindChamps++;
                foreach (Minion m in p.ownMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 1, 1);
                }
            }
            else
            {
                p.anzEnemyStormwindChamps++;
                foreach (Minion m in p.enemyMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 1, 1);
                }
            }

        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnStormwindChamps--;
                foreach (Minion m in p.ownMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, -1, -1);
                }
            }
            else
            {
                p.anzEnemyStormwindChamps--;
                foreach (Minion m in p.enemyMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, -1, -1);
                }
            }
        }
    }
}
