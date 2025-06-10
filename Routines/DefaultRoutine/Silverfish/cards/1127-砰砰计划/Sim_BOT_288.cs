using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_288 : SimTemplate //* 实验室招募员 Lab Recruiter
	{
		//<b>Battlecry:</b> Shuffle 3 copies of a friendly minion into your deck.
		//<b>战吼：</b>将一个友方随从的三张复制洗入你的牌库。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
