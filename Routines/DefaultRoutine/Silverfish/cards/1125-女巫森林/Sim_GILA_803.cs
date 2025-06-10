using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GILA_803 : SimTemplate //* 吉尔尼斯义警 Gilnean Vigilante
	{
		//<b>Battlecry:</b> Destroy aminion and fill yourhand with Coins.
		//<b>战吼：</b>消灭一个随从，并将幸运币置入你的手牌，直到你的手牌数量达到上限。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
