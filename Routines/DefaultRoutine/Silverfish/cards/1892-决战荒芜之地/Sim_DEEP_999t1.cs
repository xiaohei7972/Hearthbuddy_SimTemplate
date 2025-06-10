using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Heartblossom
	//心灵之花
	//Give a friendly minion +2/+2. Deal $2 damage to a random enemy minion.
	//使一个友方随从获得+2/+2。随机对一个敌方随从造成$2点伤害。
	class Sim_DEEP_999t1 : SimTemplate
	{
		// fixMe 心灵之花无法选中己方目标
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null && target.own == ownplay)
			{
				// 使一个友方随从获得+2/+2
				p.minionGetBuffed(target, 2, 2);
			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1), // 对面有没有随从都可以用 但为了不浪费两点伤害还是限制一下
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
			};
		}
	}
}
