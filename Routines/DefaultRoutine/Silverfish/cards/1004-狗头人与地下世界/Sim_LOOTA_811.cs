using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOTA_811 : SimTemplate //* 毁灭之球 Orb of Destruction
	{
		//Destroy 2 of your opponent's Mana Crystals and they discard 2 cards.
		//摧毁对手的两个法力水晶，并使对手弃两张牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
