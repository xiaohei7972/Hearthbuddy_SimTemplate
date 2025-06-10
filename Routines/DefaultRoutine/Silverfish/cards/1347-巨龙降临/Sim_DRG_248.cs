using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_248 : SimTemplate //* 霜之祈咒 Invocation of Frost
	{
		//<b>Freeze</b> an enemy. <b>Invoke</b> Galakrond.
		//<b>冻结</b>一个敌人。<b>祈求</b>迦拉克隆。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
