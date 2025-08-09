using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 裂隙屠夫 Riftcleaver
	//<b>Battlecry:</b> Destroy a minion. Your hero takes damage equal to its Health.
	//<b>战吼：</b>消灭一个随从。你的英雄受到等同于该随从生命值的伤害。 
	class Sim_ULD_165 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetDestroyed(target);
				p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, target.Hp);

			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),	// 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 没有目标时也能用
			};
		}
		
	}
}