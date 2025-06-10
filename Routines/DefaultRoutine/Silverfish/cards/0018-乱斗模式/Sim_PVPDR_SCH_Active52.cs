using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_SCH_Active52 : SimTemplate //* 硬壳横行蟹 Crusty the Crustacean
	{
		//[x]<b>Battlecry:</b> Destroy a minion.Gain its Attack and Health.
		//<b>战吼：</b>消灭一个随从。获得其攻击力和生命值。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
