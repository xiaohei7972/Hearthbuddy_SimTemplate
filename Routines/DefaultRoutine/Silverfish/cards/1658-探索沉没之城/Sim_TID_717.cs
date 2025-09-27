using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：3 攻击力：4 生命值：2
	//Herald of Shadows
	//暗影使徒
	//<b>Battlecry:</b> If you've cast a Shadow spell while holding this, steal 2 Health from a minion.
	//<b>战吼：</b>如果你在此牌在你手中时施放过暗影法术，从一个随从处偷取2点生命值。
	class Sim_TID_717 : SimTemplate
	{

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 0, -2);
				p.minionGetBuffed(own, 0, 2);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
			};
		}

	}
}
