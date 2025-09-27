using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：4 攻击力：1 生命值：1
	//Tamsin's Dreadsteed
	//塔姆辛的恐惧战马
	//[x]<b>Deathrattle:</b> At the endof the turn, summon Tamsin's Dreadsteed.
	//<b>亡语：</b>在回合结束时，召唤塔姆辛的恐惧战马。
	class Sim_SW_087t : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 1, 1);
			}

		}

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), //只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从

			};

		}
		
	}
}
