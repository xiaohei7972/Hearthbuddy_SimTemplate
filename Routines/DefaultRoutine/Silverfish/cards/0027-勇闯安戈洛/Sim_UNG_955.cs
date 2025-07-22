using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_955 : SimTemplate //* 陨石术 Meteor
//Deal $15 damage to a minion and $3 damage to adjacent ones.
//对一个随从造成$15点伤害，并对其相邻的随从造成$3点伤害。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmgMain = (ownplay) ? p.getSpellDamageDamage(15) : p.getEnemySpellDamageDamage(15);
            int dmgAdj = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            List<Minion> temp = (target.own) ? p.ownMinions : p.enemyMinions;
            p.minionGetDamageOrHeal(target, dmgMain);
            foreach (Minion m in temp)
            {
                if (m.zonepos + 1 == target.zonepos || m.zonepos - 1 == target.zonepos) p.minionGetDamageOrHeal(m, dmgAdj);
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}