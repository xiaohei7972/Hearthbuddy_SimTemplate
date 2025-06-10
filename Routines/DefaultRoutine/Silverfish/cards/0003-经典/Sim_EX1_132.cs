using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_132 : SimTemplate //* 以眼还眼 Eye for an Eye
	{
		//<b>Secret:</b> When your hero takes damage, deal_that much damage to the enemy hero.
		//<b>奥秘：</b>当你的英雄受到伤害时，对敌方英雄造成等量伤害。
        //todo secret
        //    geheimnis:/ wenn euer held schaden erleidet, wird dem feindlichen helden ebenso viel schaden zugefügt.
        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(number) : p.getEnemySpellDamageDamage(number);

            p.minionGetDamageOrHeal(ownplay ? p.enemyHero : p.ownHero, dmg);
        }

    }

}