using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_363 : SimTemplate //* 智慧祝福 Blessing of Wisdom
	{
		//Choose a minion. Whenever it attacks, draw a card.
		//选择一个随从，每当其进行攻击，便抽一张牌。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                target.ownBlessingOfWisdom++;
            }
            else
            {
                target.enemyBlessingOfWisdom++;
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