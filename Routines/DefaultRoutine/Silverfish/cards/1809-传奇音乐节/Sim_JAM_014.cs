
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_JAM_014 : SimTemplate //* 后台保镖 Backstage Bouncer
                                    //&lt;b&gt;嘲讽&lt;/b&gt;。&lt;b&gt;战吼：&lt;/b&gt;将一个友方随从变形成为本随从的复制。
                                    //&lt;b&gt;Taunt&lt;/b&gt;&lt;b&gt;Battlecry:&lt;/b&gt; Transform a friendly minion into a copy of this.
    {
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice) 
        { 
            if (target != null) 
            { 
               p.minionTransform(target, m.handcard.card); 
            } 
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
    }


}
        