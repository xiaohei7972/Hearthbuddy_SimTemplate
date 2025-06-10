using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_111 : SimTemplate //* 机械异种蝎 Scorp-o-matic
	{
		//<b>Battlecry:</b> Destroy a minion with 1 or less Attack.
		//<b>战吼：</b>消灭一个攻击力小于或等于1的随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_MAX_ATTACK, 1),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
