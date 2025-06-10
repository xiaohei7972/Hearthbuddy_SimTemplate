using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_723 : SimTemplate //* 禁忌咒文
	{
		//消耗你所有的法力值。消灭一个攻击力小于或等于所消耗法力值的随从。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(p.mana) : p.getEnemySpellDamageDamage(p.enemyMaxMana);

			if (dmg >= target.Angr) p.minionGetDestroyed(target);

			if (ownplay) p.mana = 0;
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}