using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：2
	//Falling Stalactite
	//钟乳落石
	//Deal $3 damageto a minion and theenemy hero.
	//对一个随从和敌方英雄造成$3点伤害。
	class Sim_WW_001t5 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				// 对目标造成3点伤害
				p.minionGetDamageOrHeal(target, damage);
				p.minionGetDamageOrHeal(ownplay ? p.enemyHero : p.ownHero, damage);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2. REQ_TARGET_TO_PLAY),
			};
		}
		
	}
}
