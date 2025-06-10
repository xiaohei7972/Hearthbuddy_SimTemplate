using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULDA_113 : SimTemplate //* 硬壳横行蟹 Crusty the Crustacean
	{
		//<b>Battlecry:</b> Destroy a minion.Gain double its Attack and Health.
		//<b>战吼：</b>消灭一个随从。获得其双倍的攻击力和生命值。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
