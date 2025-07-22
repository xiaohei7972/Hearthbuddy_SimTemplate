using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：2
	//Obliterate
	//湮灭
	//Destroy a minion. Deal_3 damage to your hero.
	//消灭一个随从。对你的英雄造成3点伤害。
	class Sim_LEG_RLK_125 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetDestroyed(target);
				p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, 3);
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
