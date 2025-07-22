using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_07_AlexstraszaDormant : SimTemplate //* 阿莱克丝塔萨 Alexstrasza
	{
		//<b>Dormant</b>
		//<b>休眠</b>
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_HERO_TARGET),
            };
        }
	}
}
