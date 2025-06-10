using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_714 : SimTemplate //* 冰霜织影者 Frozen Shadoweaver
	{
		//<b>Battlecry:</b> <b>Freeze</b> an_enemy.
		//<b>战吼：</b><b>冻结</b>一个敌人。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
