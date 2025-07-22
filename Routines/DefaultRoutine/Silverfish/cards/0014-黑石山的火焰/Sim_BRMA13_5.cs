using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA13_5 : SimTemplate //* 烈焰之子 Son of the Flame
//<b>Battlecry:</b> Deal 6 damage.
//<b>战吼：</b>造成6点伤害。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
