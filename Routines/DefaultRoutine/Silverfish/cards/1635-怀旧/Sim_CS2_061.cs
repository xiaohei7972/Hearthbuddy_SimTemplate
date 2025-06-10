using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_061 : SimTemplate //* 吸取生命 Drain Life
	{
		//Deal $2 damage. Restore #2 Health to your hero.
		//造成$2点伤害，为你的英雄恢复#2点生命值。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            int heal = (ownplay) ? p.getSpellHeal(2) : p.getEnemySpellHeal(2);
            p.minionGetDamageOrHeal(target, dmg);

            p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -heal);
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}