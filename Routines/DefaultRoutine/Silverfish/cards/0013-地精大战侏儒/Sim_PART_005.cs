using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_PART_005 : SimTemplate //* 紧急冷冻剂 Emergency Coolant
//<b>Freeze</b> a minion.
//<b>冻结</b>一个随从。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetFrozen(target);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}