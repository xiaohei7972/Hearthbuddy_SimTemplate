using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_NEW1_008 : SimTemplate //* 知识古树 Ancient of Lore
//<b>Choose One -</b> Draw 2 cards; or Restore #5 Health.
//<b>抉择：</b>抽两张牌；或者恢复#5点生命值。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
