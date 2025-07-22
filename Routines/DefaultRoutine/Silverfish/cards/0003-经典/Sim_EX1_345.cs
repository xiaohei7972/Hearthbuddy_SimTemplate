using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_345 : SimTemplate //* 控心术 Mindgames
	{
		//Put a copy ofa random minion fromyour opponent's deck into the battlefield.
		//随机将你对手的牌库中的一张随从牌的复制置入战场。

        CardDB.Card copymin = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_182); // we take a icewindjety :D

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (p.enemyDeckSize < 1) copymin = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_345t); // Shadow of Nothing
            p.callKid(copymin, p.ownMinions.Count, ownplay, false);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}