using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_408 : SimTemplate //* 致死打击 Mortal Strike
	{
		//Deal $4 damage. If you have 12 or less Health, deal $6 instead.
		//造成$4点伤害；如果你的生命值小于或等于12点，则改为造成$6点伤害。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = 0;

            if (ownplay)
            {
                dmg = (p.ownHero.Hp <= 12) ? p.getSpellDamageDamage(6) : p.getSpellDamageDamage(4);
            }
            else
            {
                dmg = (p.enemyHero.Hp <= 12) ? p.getEnemySpellDamageDamage(6) : p.getEnemySpellDamageDamage(4);
            }
            p.minionGetDamageOrHeal(target, dmg);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}