using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_004 : SimTemplate //* 奥术冲击 Arcane Blast
//Deal $2 damage to a minion. This spell gets double bonus from <b>Spell Damage</b>.
//对一个随从造成$2点伤害。该法术受到的<b>法术伤害</b>增益效果翻倍。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(2 + p.spellpower) : p.getEnemySpellDamageDamage(2 + p.enemyspellpower);
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