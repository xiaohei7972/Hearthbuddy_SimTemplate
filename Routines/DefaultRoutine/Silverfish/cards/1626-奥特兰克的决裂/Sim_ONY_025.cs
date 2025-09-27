using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：1
	//Shoulder Check
	//铁肩冲撞
	//<b>Tradeable</b>Give a minion +2/+1 and <b>Rush</b>.
	//<b>可交易</b>使一个随从获得+2/+1和<b>突袭</b>。
	class Sim_ONY_025 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 2, 1);
				p.minionGetRush(target);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
			};
		}

	}
}
