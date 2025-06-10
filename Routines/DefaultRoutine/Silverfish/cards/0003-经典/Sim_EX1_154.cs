using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_154 : SimTemplate //* 愤怒 Wrath
	{
		//<b>Choose One -</b>Deal $3 damage to a minion; or $1 damageand draw a card.
		//<b>抉择：</b>对一个随从造成$3点伤害；或者造成$1点伤害并抽一张牌。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int damage = 0;
            if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                damage += (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                damage += (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            }

            p.minionGetDamageOrHeal(target, damage);

            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
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