using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_RoadToNR_Finley_HP : SimTemplate //* 力量强化 Power Up!
//[x]<b>Hero Power</b>Give a minion<b>Divine Shield</b> & <b>Windfury</b>.
//<b>英雄技能</b>使一个随从获得<b>圣盾</b>和<b>风怒</b>。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
