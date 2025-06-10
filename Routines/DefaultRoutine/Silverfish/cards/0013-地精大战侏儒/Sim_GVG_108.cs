using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_108 : SimTemplate //* 侏儒变形师 Recombobulator
//<b>Battlecry:</b> Transform a friendly minion into a random minion with the same Cost.
//<b>战吼：</b>将一个友方随从随机变形成为一个法力值消耗相同的随从。 
    {

        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if(target == null) return;
            p.minionTransform(target, target.handcard.card);
        }


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