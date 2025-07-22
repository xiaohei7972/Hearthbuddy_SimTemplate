using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_084 : SimTemplate //* 猎人印记 Hunter's Mark
	{
		//Change a minion's Health to 1.
		//使一个随从的生命值变为1。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionSetLifetoX(target, 1);
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