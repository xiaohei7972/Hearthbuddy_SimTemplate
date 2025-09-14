using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：1
	//Heart Strike
	//心脏打击
	//Deal $3 damage toa minion. If that kills it, gain a <b>Corpse</b>.
	//对一个随从造成$3点伤害。如果消灭该随从，获得一份<b>残骸</b>。
	class Sim_RLK_034 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				p.minionGetDamageOrHeal(target, dmg);
				if (target.Hp <= dmg)
					p.addCorpses(1);

			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                // new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
		}
		
	}
}
