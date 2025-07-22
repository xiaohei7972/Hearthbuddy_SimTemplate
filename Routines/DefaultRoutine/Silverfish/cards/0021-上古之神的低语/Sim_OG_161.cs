using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_161 : SimTemplate //* 腐化先知 Corrupted Seer
//<b>Battlecry:</b> Deal 2 damage to all non-Murloc minions.
//<b>战吼：</b>对所有非鱼人随从造成2点伤害。 
    {
        

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            foreach (Minion m in p.ownMinions)
            {
                if ((TAG_RACE)m.handcard.card.race != TAG_RACE.MURLOC) p.minionGetDamageOrHeal(m, 2);
            }
            foreach (Minion m in p.enemyMinions)
            {
                if ((TAG_RACE)m.handcard.card.race != TAG_RACE.MURLOC) p.minionGetDamageOrHeal(m, 2);
            }
		}
	}
}