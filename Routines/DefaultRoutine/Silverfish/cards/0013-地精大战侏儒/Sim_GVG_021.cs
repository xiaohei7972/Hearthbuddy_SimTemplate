using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_021 : SimTemplate //* 玛尔加尼斯 Mal'Ganis
//Your other Demons have +2/+2.Your hero is <b>Immune</b>.
//你的其他恶魔获得+2/+2。你的英雄获得<b>免疫</b>。 
    {

        

        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnMalGanis++;
                p.ownHero.immune = true;
                foreach (Minion m in p.ownMinions)
                {
                    if (own.entitiyID != m.entitiyID && (TAG_RACE)m.handcard.card.race == TAG_RACE.DEMON) p.minionGetBuffed(m, 2, 2);
                }
            }
            else
            {
                p.anzEnemyMalGanis++;
                p.enemyHero.immune = true;
                foreach (Minion m in p.enemyMinions)
                {
                    if (own.entitiyID != m.entitiyID && (TAG_RACE)m.handcard.card.race == TAG_RACE.DEMON) p.minionGetBuffed(m, 2, 2);
                }
            }

        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnMalGanis--;
                p.ownHero.immune = false;
                foreach (Minion m in p.ownMinions)
                {
                    if (own.entitiyID != m.entitiyID && (TAG_RACE)m.handcard.card.race == TAG_RACE.DEMON) p.minionGetBuffed(m, -2, -2);
                }
            }
            else
            {
                p.anzEnemyMalGanis--;
                p.enemyHero.immune = false;
                foreach (Minion m in p.enemyMinions)
                {
                    if (own.entitiyID != m.entitiyID && (TAG_RACE)m.handcard.card.race == TAG_RACE.DEMON) p.minionGetBuffed(m, -2, -2);
                }
            }
        }


    }

}