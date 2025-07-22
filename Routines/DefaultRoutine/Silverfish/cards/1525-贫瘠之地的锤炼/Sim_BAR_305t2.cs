using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_305t2 : SimTemplate //* 冰风暴（等级3） Flurry (Rank 3)
	{
		//<b>Freeze</b> three random enemy minions.
		//随机<b>冻结</b>三个敌方随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
