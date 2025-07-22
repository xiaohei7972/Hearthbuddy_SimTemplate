using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_324 : SimTemplate //* 小鬼油膏 Impbalming
	{
		//Destroy a minion. Shuffle 3 Worthless Imps into your deck.
		//消灭一个随从。将三张“游荡小鬼”洗入你的牌库。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
