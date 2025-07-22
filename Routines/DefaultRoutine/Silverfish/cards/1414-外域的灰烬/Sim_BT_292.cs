using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_292 : SimTemplate //* 阿达尔之手 Hand of A'dal
	{
		//Give a minion +2/+2.Draw a card.
		//使一个随从获得+2/+2。抽一张牌。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionGetBuffed(target, 2, 1);
			p.drawACard(CardDB.cardIDEnum.SW_024, ownplay);
		}


		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
