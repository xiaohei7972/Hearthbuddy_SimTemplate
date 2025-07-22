using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DS1_233 : SimTemplate //* 心灵震爆 Mind Blast
//Deal $5 damage to the enemy hero.
//对敌方英雄造成$5点伤害。 
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);

            p.minionGetDamageOrHeal(ownplay ? p.enemyHero : p.ownHero, dmg);
        }
    }
}