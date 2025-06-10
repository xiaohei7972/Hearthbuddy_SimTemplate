using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_004t6 : SimTemplate //* 燃烧权杖 Rod of Roasting
	{
		//Cast 'Pyroblast' randomly until a player dies.
		//随机施放炎爆术直到一名玩家死亡。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
