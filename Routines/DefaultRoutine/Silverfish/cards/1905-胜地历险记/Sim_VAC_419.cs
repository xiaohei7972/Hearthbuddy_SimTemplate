using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：1
	//Acupuncture
	//针灸
	//[x]Deal $4 damageto both heroes.
	//对双方英雄造成$4点伤害。
	class Sim_VAC_419 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);

            // 对己方英雄造成伤害
            p.minionGetDamageOrHeal(p.ownHero, dmg);

            // 对敌方英雄造成伤害
            p.minionGetDamageOrHeal(p.enemyHero, dmg);
        }
    }
}
