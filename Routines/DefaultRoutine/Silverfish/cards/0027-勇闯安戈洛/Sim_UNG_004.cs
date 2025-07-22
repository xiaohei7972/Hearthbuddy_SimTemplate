using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_004 : SimTemplate //* 巨化术 Dinosize
//Set a minion's Attack and Health to 10.
//将一个随从的攻击力和生命值变为10。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionSetAngrToX(target, 10);
			p.minionSetLifetoX(target, 10);
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