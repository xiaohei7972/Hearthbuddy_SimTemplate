using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：2
	//Obliterate
	//湮灭
	//Destroy a minion. Your hero takes damage equal to its Health.
	//消灭一个随从。你的英雄受到等同于该随从生命值的伤害。
	class Sim_RLK_Prologue_RLK_125_AI : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int dmg = (ownplay) ? p.getSpellDamageDamage(target.Hp) : p.getEnemySpellDamageDamage(target.Hp);

				p.minionGetDestroyed(target);
				p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, dmg);

			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				// new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
			};
		}
		
	}
}
