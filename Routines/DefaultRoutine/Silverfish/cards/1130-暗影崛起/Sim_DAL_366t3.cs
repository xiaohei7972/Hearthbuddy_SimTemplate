using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_366t3 : SimTemplate //* 赏金合约 Lucrative Contract
//Destroy a minion. Add 2 Coins to your hand.
//消灭一个随从。将两个幸运币置入你的手牌。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetDestroyed(target);
			p.drawACard(CardDB.cardNameEN.thecoin, ownplay);
            p.drawACard(CardDB.cardNameEN.thecoin, ownplay);
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