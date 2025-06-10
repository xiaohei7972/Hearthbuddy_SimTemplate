using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA09_3H : SimTemplate //* 旧部落 Old Horde
//<b>Hero Power</b>Summon two 2/2 Orcs with <b>Taunt</b>. Get a new Hero Power.
//<b>英雄技能</b>召唤两个2/2并具有<b>嘲讽</b>的兽人。获得另一个英雄技能。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
