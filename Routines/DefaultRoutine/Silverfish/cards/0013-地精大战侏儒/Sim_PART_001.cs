using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_PART_001 : SimTemplate //* 重型护甲 Armor Plating
//Give a minion +1 Health.
//使一个随从获得+1生命值。 
    {

        


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 0, 1);
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