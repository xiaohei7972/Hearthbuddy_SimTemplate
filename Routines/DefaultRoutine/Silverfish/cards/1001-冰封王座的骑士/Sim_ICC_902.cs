using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_902: SimTemplate //* 摧心者 Mindbreaker
//Hero Powers are disabled.
//双方英雄技能均无法使用。 
    {
        

        public override void onAuraStarts(Playfield p, Minion own)
        {
            p.ownHeroAblility.manacost = 100;
            p.enemyHeroAblility.manacost = 100;
            p.ownAbilityReady = false;
            p.ownAbilityReady = false;
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            bool another = false;
            foreach (Minion m in p.ownMinions)
            {
                if (m.name == CardDB.cardNameEN.mindbreaker && own.entitiyID != m.entitiyID) another = true;
            }
            if (!another)
            {
                foreach (Minion m in p.enemyMinions)
                {
                    if (m.name == CardDB.cardNameEN.mindbreaker && own.entitiyID != m.entitiyID) another = true;
                }
            }
            if (!another)
            {
                p.ownHeroAblility.manacost = 2;
                p.enemyHeroAblility.manacost = 2;
                p.ownAbilityReady = true;
                p.ownAbilityReady = true;
            }
        }
    }
}