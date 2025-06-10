using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOD_036 : SimTemplate //* 腐巢幼龙 Rotnest Drake
	{
		//[x]<b>Battlecry:</b> If you're holdinga Dragon, destroy a randomenemy minion.
		//<b>战吼：</b>如果你的手牌中有龙牌，随机消灭一个敌方随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
