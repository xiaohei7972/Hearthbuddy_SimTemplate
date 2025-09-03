using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：8
	//Devilsaur Mask
	//魔暴龙面具
	//Set a minion's stats to 8/8. Give it <b>Charge</b>.
	//将一个随从的属性值变为8/8。使其获得<b>冲锋</b>。
	class Sim_DINO_403 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionSetAngrToX(target, 8);
				p.minionSetLifetoX(target, 8);
				p.minionGetCharge(target);
			}
		}
		public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
			};
        }
	}
}
