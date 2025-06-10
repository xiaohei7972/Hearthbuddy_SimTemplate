using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOTA_812 : SimTemplate //* 急速之靴 Boots of Haste
	{
		//Your minions cost (0) this turn.
		//在本回合中，你的随从牌的法力值消耗为（0）点。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
