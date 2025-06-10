using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_004 : SimTemplate //* 真言术：盾 Power Word: Shield
	{
		//Give a minion +2_Health.Draw a card.
		//使一个随从获得+2生命值。抽一张牌。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetBuffed(target, 0, 2);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
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
