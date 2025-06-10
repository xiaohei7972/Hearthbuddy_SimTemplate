using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_055 : SimTemplate //* 废旧螺栓机甲 Screwjank Clunker
//<b>Battlecry:</b> Give a friendly Mech +2/+2.
//<b>战吼：</b>使一个友方机械获得+2/+2。 
    {

        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

            if (target == null) return;
            p.minionGetBuffed(target, 2, 2);
        }



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 17),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }

}