using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_513 : SimTemplate //* 脆骨破坏者 Brittlebone Destroyer
	{
		//[x]<b>Battlecry:</b> If your hero'sHealth changed this turn,destroy a minion.
		//<b>战吼：</b>在本回合中，如果你的英雄的生命值发生变化，消灭一个随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
