using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：4
	//Caustic Fumes
	//烧蚀毒雾
	//Destroy an enemy minion. <b>Kindred:</b> Deal $2 damage to all minions.
	//消灭一个敌方随从。<b>延系：</b>对所有随从造成$2点伤害。
	class Sim_TLC_447 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetDestroyed(target);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方

			};
		}

	}
}
