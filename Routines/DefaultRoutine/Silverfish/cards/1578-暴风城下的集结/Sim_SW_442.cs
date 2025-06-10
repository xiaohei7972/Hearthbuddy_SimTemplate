using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_442 : SimTemplate //* 虚空碎片 Void Shard
	{
		//<b>Lifesteal</b>Deal $4 damage.
		//<b>吸血</b>造成$4点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
            int heal = 4;
			p.minionGetDamageOrHeal(target, dmg);
            p.applySpellLifesteal(heal, ownplay);
        }
		
		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
