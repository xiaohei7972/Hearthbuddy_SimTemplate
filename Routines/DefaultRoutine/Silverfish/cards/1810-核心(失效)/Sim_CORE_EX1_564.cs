using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_CORE_EX1_564 : SimTemplate //facelessmanipulator
    {

        //    kampfschrei:/ wÃ¤hlt einen diener aus, um gesichtsloser manipulator in eine kopie desselben zu verwandeln.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                //p.copyMinion(own, target);
                bool source = own.own;
                own.setMinionToMinion(target);
                own.own = source;
                own.handcard.card.sim_card.onAuraStarts(p, own);
            }
        }



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
            };
        }
    }
}