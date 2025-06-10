using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_044 : SimTemplate //* 腐根 Mulch
//Destroy a minion.Add a random minion to your opponent's hand.
//消灭一个随从。随机将一张随从牌置入对手的手牌。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.minionGetDestroyed(target);
            p.drawACard(CardDB.cardIDEnum.None, !ownplay, true);
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