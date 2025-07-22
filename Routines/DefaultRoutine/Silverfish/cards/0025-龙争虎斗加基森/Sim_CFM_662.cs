using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_662 : SimTemplate //* 龙息药水 Dragonfire Potion
//[x]Deal $5 damage to allminions except Dragons.
//对除了龙之外的所有随从造成$5点伤害。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
            foreach (Minion m in p.ownMinions)
            {
                if ((TAG_RACE)m.handcard.card.race != TAG_RACE.DRAGON) p.minionGetDamageOrHeal(m, dmg);
            }
            foreach (Minion m in p.enemyMinions)
            {
                if ((TAG_RACE)m.handcard.card.race != TAG_RACE.DRAGON) p.minionGetDamageOrHeal(m, dmg);
            }
        }
    }
}