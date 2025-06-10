using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_120 : SimTemplate //* 赫米特·奈辛瓦里 Hemet Nesingwary
//<b>Battlecry:</b> Destroy a Beast.
//<b>战吼：</b>消灭一个野兽。 
    {

        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target == null) return;

            p.minionGetDestroyed(target);
        }




        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 20),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }

}