using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：1
	//Monstrous Form
	//魔化形态
	//Give a friendlyminion +3/+3 until your next turn.
	//直到你的下个回合，使一个友方随从获得+3/+3。
	class Sim_TTN_486 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				// 增加临时3点攻击力和临时3点生命值
				p.minionGetTempBuff(target, 3, 3);
			}
			
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
            };
		}

	}
}
