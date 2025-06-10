using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_DS1_175 : SimTemplate //* 森林狼 Timber Wolf
	{
		//Your other Beasts have +1_Attack.
		//你的其他野兽获得+1攻击力。
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnTimberWolfs++;
                foreach (Minion m in p.ownMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PET && m.entitiyID != own.entitiyID) p.minionGetBuffed(m, 1, 0);
                }
            }
            else
            {
                p.anzEnemyTimberWolfs++;
                foreach (Minion m in p.enemyMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PET && m.entitiyID != own.entitiyID) p.minionGetBuffed(m, 1, 0);
                }
            }

        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnTimberWolfs--;
                foreach (Minion m in p.ownMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PET && m.entitiyID != own.entitiyID) p.minionGetBuffed(m, -1, 0);
                }
            }
            else
            {
                p.anzEnemyTimberWolfs--;
                foreach (Minion m in p.enemyMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PET && m.entitiyID != own.entitiyID) p.minionGetBuffed(m, -1, 0);
                }
            }
        }

	}
}