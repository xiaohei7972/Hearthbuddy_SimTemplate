using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_119 : SimTemplate //* 坩埚元素 Cauldron Elemental
//Your other Elementals have +2 Attack.
//你的其他元素获得+2攻击力。 
	{
        

        public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own) p.anzOwnRaidleader++;
            else p.anzEnemyRaidleader++;

            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if((TAG_RACE)m.handcard.card.race == TAG_RACE.ELEMENTAL && own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 2, 0);
            }
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.anzOwnRaidleader--;
            else p.anzEnemyRaidleader--;

            List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion mn in temp)
            {
                if((TAG_RACE)mn.handcard.card.race == TAG_RACE.ELEMENTAL && mn.entitiyID != m.entitiyID) p.minionGetBuffed(m, -2, 0);
            }
		}
	}
}