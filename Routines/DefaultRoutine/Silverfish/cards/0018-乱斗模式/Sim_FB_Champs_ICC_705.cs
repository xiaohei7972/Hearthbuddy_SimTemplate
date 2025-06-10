using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_ICC_705 : SimTemplate //* 骨魇 Bonemare
//<b>Battlecry:</b> Give a friendly minion +4/+4 and <b>Taunt</b>.
//<b>战吼：</b>使一个友方随从获得+4/+4和<b>嘲讽</b>。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
