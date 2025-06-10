using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_030 : SimTemplate //* 赞美迦拉克隆 Praise Galakrond!
	{
		//[x]Give a minion +1 Attack.<b>Invoke</b> Galakrond.
		//使一个随从获得+1攻击力。<b>祈求</b>迦拉克隆。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
