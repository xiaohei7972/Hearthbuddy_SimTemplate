using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOTA_200 : SimTemplate //* 卧底记者 Undercover Reporter
	{
		//<b>Battlecry:</b> Choose a minion. Put two copies of it on top of your deck.
		//<b>战吼：</b>选择一个随从，将它的两张复制置入你的牌库顶。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
