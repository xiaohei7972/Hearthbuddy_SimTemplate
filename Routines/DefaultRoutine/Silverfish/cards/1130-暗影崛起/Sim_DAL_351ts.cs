using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 远古祝福 Blessing of the Ancients
    //Give your minions +1/+1.
    //使你的所有随从获得+1/+1。 
    class Sim_DAL_351ts : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.ownMinions.Count > 4) p.evaluatePenality -= 20;
            p.allMinionOfASideGetBuffed(ownplay, 1, 1);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS,2), //最少有两个随从才用
            };
        }

    }
}