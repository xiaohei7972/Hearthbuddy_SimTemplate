using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_086 : SimTemplate //* 禁忌烈焰 Forbidden Flame
//Spend all your Mana. Deal that much damage to a minion.
//消耗你所有的法力值，对一个随从造成等同于所消耗法力值数量的伤害。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(p.mana) : p.getEnemySpellDamageDamage(p.enemyMaxMana);
            p.minionGetDamageOrHeal(target, dmg);
			if (ownplay) p.mana = 0;
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