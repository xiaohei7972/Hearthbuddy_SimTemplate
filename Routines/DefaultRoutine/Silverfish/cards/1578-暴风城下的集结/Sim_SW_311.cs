using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_311 : SimTemplate //* 锁喉 Garrote
	{
		//[x]Deal $2 damage to theenemy hero. Shuffle 3Bleeds into your deck thatdeal $2 more when drawn.
		//对敌方英雄造成$2点伤害，将三张流血洗入你的牌库。抽到流血时，再造成$2点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);

            p.minionGetDamageOrHeal(ownplay ? p.enemyHero : p.ownHero, dmg);

        }
		
	}
}
