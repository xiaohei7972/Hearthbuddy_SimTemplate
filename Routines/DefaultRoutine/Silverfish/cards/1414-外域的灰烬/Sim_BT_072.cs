using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_072 : SimTemplate //* 深度冻结 Deep Freeze
	{
		//<b>Freeze</b> an enemy. Summon two 3/6 Water Elementals.
		//<b>冻结</b>一个敌人。召唤两个3/6的水元素。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
