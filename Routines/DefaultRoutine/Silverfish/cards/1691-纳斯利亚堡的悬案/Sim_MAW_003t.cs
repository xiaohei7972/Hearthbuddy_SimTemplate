
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_MAW_003t : SimTemplate //* 图腾物证 Totemic Evidence
                                    //&lt;b&gt;已注能&lt;/b&gt;召唤全部4个基础图腾。
                                    //&lt;b&gt;Infused&lt;/b&gt;Summon all 4basic Totems.
    {
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }


}
        