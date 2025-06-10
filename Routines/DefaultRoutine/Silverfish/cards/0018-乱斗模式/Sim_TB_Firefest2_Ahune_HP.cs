using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_Firefest2_Ahune_HP : SimTemplate //* 冰冻之触 Freezing Touch
//<b>Hero Power</b> Deal $1 damage. If this kills a minion, summon a Frost Elemental.
//<b>英雄技能</b>造成$1点伤害。如果该英雄技能消灭了一个随从，则召唤一个冰霜元素。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
