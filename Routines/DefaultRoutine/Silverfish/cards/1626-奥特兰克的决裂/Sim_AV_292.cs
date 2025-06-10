using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_292 : SimTemplate //* 野性之心 heartofthewild
	{
		//使一个随从获得+2/+2，然后使你的野兽获得+1/+1。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 2, 2);
            foreach (Minion m in p.ownMinions)
            {
                if (m.handcard.card.race == CardDB.Race.BEAST) p.minionGetBuffed(target, 1, 1);
            }
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
