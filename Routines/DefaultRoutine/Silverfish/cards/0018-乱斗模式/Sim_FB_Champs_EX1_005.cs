using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_EX1_005 : SimTemplate //* 王牌猎人 Big Game Hunter
//<b>Battlecry:</b> Destroy a minion with 7 or more Attack.
//<b>战吼：</b>消灭一个攻击力大于或等于7的随从。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_MIN_ATTACK, 7),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
