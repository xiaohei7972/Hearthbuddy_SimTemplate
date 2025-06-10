using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRGA_BOSS_35p : SimTemplate //* 召唤元素 Summon Elemental
	{
		//[x]<b>Hero Power</b>Summon a 2/3 Elemental.It copies your spells.
		//<b>英雄技能</b>召唤一个2/3的元素。它会复制你的法术。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
