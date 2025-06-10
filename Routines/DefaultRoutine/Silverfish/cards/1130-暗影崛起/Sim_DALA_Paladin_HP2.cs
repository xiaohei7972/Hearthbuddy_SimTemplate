using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DALA_Paladin_HP2 : SimTemplate //* 圣光恩泽 Boon of Light
	{
		//<b>Hero Power</b>Give a friendly minion <b>Divine Shield</b>.
		//<b>英雄技能</b>使一个友方随从获得<b>圣盾</b>。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
