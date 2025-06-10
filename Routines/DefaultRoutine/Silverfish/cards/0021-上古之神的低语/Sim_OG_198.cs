using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_198 : SimTemplate //* 禁忌治疗 Forbidden Healing
//Spend all your Mana. Restore twice that much Health.
//消耗你所有的法力值，恢复等同于所消耗法力值数量两倍的生命值。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				p.minionGetDamageOrHeal(target, -p.getSpellHeal(2 * p.mana));
				p.mana = 0;
			}
			else p.minionGetDamageOrHeal(target, -p.getSpellHeal(2 * p.enemyMaxMana));
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}