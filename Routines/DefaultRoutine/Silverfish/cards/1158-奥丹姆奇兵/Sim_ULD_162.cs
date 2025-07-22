using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_162 : SimTemplate //* 怪盗征募官 EVIL Recruiter
	{
		//<b>Battlecry:</b> Destroy a friendly <b>Lackey</b> to summon a 5/5 Demon.
		//<b>战吼：</b>消灭一个友方<b>跟班</b>，召唤一个5/5的恶魔。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
