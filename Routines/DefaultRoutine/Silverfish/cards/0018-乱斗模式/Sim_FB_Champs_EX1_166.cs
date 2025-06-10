using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_EX1_166 : SimTemplate //* 丛林守护者 Keeper of the Grove
//<b>Choose One -</b> Deal_2_damage; or <b>Silence</b> a minion.
//<b>抉择：</b>造成2点伤害；或者<b>沉默</b>一个随从。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
