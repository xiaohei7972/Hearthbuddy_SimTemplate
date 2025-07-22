using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_EX1_246 : SimTemplate //* 妖术 Hex
	{
		//Transform a minion into a 0/1 Frog with <b>Taunt</b>.
		//使一个随从变形成为一只0/1并具有<b>嘲讽</b>的青蛙。
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
