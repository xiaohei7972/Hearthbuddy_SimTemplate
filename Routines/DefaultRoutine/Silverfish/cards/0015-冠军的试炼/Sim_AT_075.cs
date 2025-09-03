using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 战马训练师 Warhorse Trainer
    //Your Silver Hand Recruits have +1 Attack.
    //你的白银之手新兵获得+1攻击力。 
    class Sim_AT_075 : SimTemplate
    {
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own) p.anzOwnWarhorseTrainer++;
            else p.anzEnemyWarhorseTrainer++;

            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.name == CardDB.cardNameEN.silverhandrecruit)
                {
                    p.minionGetBuffed(m, 2, 0);
                    m.taunt = true;
                }
            }
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own) p.anzOwnWarhorseTrainer--;
            else p.anzEnemyWarhorseTrainer--;

            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.name == CardDB.cardNameEN.silverhandrecruit)
                {
                    p.minionGetBuffed(m, -2, 0);
                    m.taunt = false;
                }
            }
        }

    }
}