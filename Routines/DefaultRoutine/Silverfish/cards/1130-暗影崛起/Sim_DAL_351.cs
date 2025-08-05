using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 远古祝福 Blessing of the Ancients
    //<b>Twinspell</b>Give your minions +1/+1.
    //<b>双生法术</b>使你的所有随从获得+1/+1。 
    class Sim_DAL_351 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.ownMinions.Count < 3) p.evaluatePenality += 30;
            p.allMinionOfASideGetBuffed(ownplay, 1, 1);
            p.drawACard(CardDB.cardIDEnum.DAL_351ts, ownplay, true);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS,2), //最少有两个随从才用
            };
        }

    }
}