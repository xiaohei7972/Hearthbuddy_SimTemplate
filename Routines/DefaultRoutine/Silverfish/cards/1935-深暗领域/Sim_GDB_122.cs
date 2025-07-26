using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：3
	//Infernal Stratagem
	//狱火邪谋
	//[x]Give a minion +3/+3.If it's a Demon, yournext one costs (2) less.
	//使一个随从获得+3/+3。如果该随从是恶魔，你的下一张恶魔牌法力值消耗减少（2）点。
	class Sim_GDB_122 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				target.Angr += 3;
				target.Hp += 3;
				//TODO:恶魔减费以后再说
				// if (target.handcard.card.race == CardDB.Race.DEMON)
					// p.demon
			}

		}

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), //只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET) // 目标只能是随从

			};

		}
		
	}
}
