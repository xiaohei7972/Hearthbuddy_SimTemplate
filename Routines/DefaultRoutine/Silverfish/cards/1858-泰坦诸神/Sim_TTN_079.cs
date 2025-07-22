using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Always a Bigger Jormungar
	//虫外有虫
	//Give a minion +2_Attack and "Excess damage dealt by attacks hits the enemy hero."
	//使一个随从获得+2攻击力和“超过目标生命值的攻击伤害会命中敌方英雄。”
	class Sim_TTN_079 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 2, 0);
			}
		}
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 只能是友方
			};
		}
		
	}
}
