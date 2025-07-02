using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：3
	//Seal of Blood
	//鲜血圣印
	//Give a minion +3/+3 and <b>Divine Shield</b>. Deal $3 damage to your hero.
	//使一个随从获得+3/+3和<b>圣盾</b>。对你的英雄造成$3点伤害。
	class Sim_RLK_922 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 3, 3);
				target.divineshild = true;
				p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, 3);

			}
		}
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				// new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 只能是友方
			};
		}
	}
}
