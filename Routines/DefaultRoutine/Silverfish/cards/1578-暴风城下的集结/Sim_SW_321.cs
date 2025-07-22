using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_321 : SimTemplate //* 瞄准射击 Aimed Shot
	{
		//Deal $3 damage. Your next Hero Power deals 2 more damage.
		//造成$3点伤害。你的下一个英雄技能会额外造成2点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
			p.ownHeroPowerExtraDamage += 2;
			p.minionGetDamageOrHeal(target, dmg);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
			};
		}

	}
}
