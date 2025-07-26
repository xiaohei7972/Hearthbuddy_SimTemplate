using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：2
	//Bones
	//骸骨
	//Give a minion +{0}/+{1}.
	//使一个随从获得+{0}/+{1}。
	class Sim_TLC_829t : SimTemplate
	{
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_829t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				// p.minionGetBuffed(target, card.TAG_SCRIPT_DATA_NUM_1, card.TAG_SCRIPT_DATA_NUM_2);
				p.minionGetBuffed(target, 0, 1);

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
