using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_CS2_188 : SimTemplate //* 叫嚣的中士 Abusive Sergeant
//<b>Battlecry:</b> Give a minion +2_Attack this turn.
//<b>战吼：</b>在本回合中，使一个随从获得+2攻击力。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
