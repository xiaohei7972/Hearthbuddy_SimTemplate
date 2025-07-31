using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：0
	//Recruit a Minion
	//招募随从
	//Put a copy of an enemy minion into your hand. Your opponent gets 3 Coins.
	//将一个敌方随从的一张复制置入你的手牌。你的对手获取3张幸运币。
	class Sim_BG31_BOBt2 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.drawACard(target.handcard.card.cardIDenum, ownplay, true);
				p.drawACard(CardDB.cardIDEnum.GAME_005, !ownplay, true);
				p.drawACard(CardDB.cardIDEnum.GAME_005, !ownplay, true);
				p.drawACard(CardDB.cardIDEnum.GAME_005, !ownplay, true);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS,1),
			};
		}

	}
}
