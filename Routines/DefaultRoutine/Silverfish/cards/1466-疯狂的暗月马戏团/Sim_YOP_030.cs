using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_030 : SimTemplate //* 邪火神射手 Felfire Deadeye
	{
        //Your Hero Power costs (1) less.
        //你的英雄技能的法力值消耗减少（1）点。
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                if (p.ownHeroAblility.manacost > 0) p.ownHeroAblility.manacost--;
            }
            else
            {
                if (p.enemyHeroAblility.manacost > 0) p.enemyHeroAblility.manacost--;
            }
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            bool another = false;
            if (own.own)
            {
                foreach (Minion m in p.ownMinions)
                {
                    if (m.name == CardDB.cardNameEN.felfiredeadeye && !m.silenced && own.entitiyID != m.entitiyID) another = true;
                }
                if (!another) p.ownHeroAblility.manacost++;
            }
            else
            {
                foreach (Minion m in p.enemyMinions)
                {
                    if (m.name == CardDB.cardNameEN.felfiredeadeye && !m.silenced && own.entitiyID != m.entitiyID) another = true;
                }
                if (!another) p.enemyHeroAblility.manacost++;
            }
        }
    }
}
