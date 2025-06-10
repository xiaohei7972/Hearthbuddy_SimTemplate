using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_05_ForbiddenWords : SimTemplate //* 禁忌咒文 Forbidden Words
	{
		//[x]Spend all your Mana.Destroy a minion with thatmuch Attack or less.
		//消耗你所有的法力值。消灭一个攻击力小于或等于所消耗法力值的随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
