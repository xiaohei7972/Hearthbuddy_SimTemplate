using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_075 : SimTemplate //* 影袭 Sinister Strike
	{
		//Deal $3 damage to the_enemy hero.
		//对敌方英雄造成$3点伤害。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);

            p.minionGetDamageOrHeal(ownplay ? p.enemyHero : p.ownHero, dmg);

        }

    }
}