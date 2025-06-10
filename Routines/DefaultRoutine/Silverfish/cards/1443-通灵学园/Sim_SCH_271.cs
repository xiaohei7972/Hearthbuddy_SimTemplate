using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_271 : SimTemplate //* 岩浆爆裂 Molten Blast
	{
		//Deal $2 damage. Summon that many 1/1 Elementals.
		//造成$2点伤害，每造成一点伤害，便召唤一个1/1的元素。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
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
