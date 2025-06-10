using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_410 : SimTemplate //* 盾牌猛击 Shield Slam
	{
		//Deal 1 damage to a minion for each Armor you have.
		//你每有1点护甲值，便对一个随从造成1点伤害。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{


            int dmg = (ownplay) ? p.getSpellDamageDamage(p.ownHero.armor) : p.getEnemySpellDamageDamage(p.enemyHero.armor);
            p.minionGetDamageOrHeal(target, dmg);
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