
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_MAW_003 : SimTemplate //* 图腾物证 Totemic Evidence
                                    //选择一个基础图腾并召唤它。&lt;b&gt;注能（3个图腾）：&lt;/b&gt;改为召唤全部4个。
                                    //Choose a basic Totem and summon it.&lt;b&gt;Infuse (3 Totems):&lt;/b&gt;Summon all 4 instead.
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
        