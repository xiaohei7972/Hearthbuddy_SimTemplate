using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：2
	//Cryopreservation
	//低温贮藏
	//<b>Freeze</b> an enemy. <b>Excavate</b> a treasure.
	//<b>冻结</b>一个敌人。<b>发掘</b>一个宝藏。
	class Sim_WW_009 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetFrozen(target);
				p.drawACard(p.handleExcavation().cardIDenum, ownplay, true);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2. REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2. REQ_ENEMY_TARGET),
			};
		}

	}
}
