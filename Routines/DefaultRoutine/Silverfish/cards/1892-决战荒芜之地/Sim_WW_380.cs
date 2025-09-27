using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：2
	//Blast Charge
	//起爆炸药
	//Destroy a damaged enemy minion. <b>Excavate</b> a treasure.
	//消灭一个受伤的敌方随从。<b>发掘</b>一个宝藏。
	class Sim_WW_380 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetDestroyed(target);
				p.drawACard(p.handleExcavation().cardIDenum, ownplay, true);

			}
		}
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_DAMAGED_TARGET), // 目标只能是受伤随从
			};
		}

	}
}
