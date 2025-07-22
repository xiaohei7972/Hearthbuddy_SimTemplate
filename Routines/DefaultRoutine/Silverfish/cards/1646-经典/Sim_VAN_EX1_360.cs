using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_360 : SimTemplate //* 谦逊 Humility
	{
		//Change a minion's Attack to 1.
		//使一个随从的攻击力变为1。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionSetAngrToX(target, 1);
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
