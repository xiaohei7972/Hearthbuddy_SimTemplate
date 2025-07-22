using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_A10_33 : SimTemplate //* 作弊 Cheat
	{
		//<b>Hero Power</b>Destroy the left-most enemy minion.
		//<b>英雄技能</b>消灭最左边的敌方随从。

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
	}
}
