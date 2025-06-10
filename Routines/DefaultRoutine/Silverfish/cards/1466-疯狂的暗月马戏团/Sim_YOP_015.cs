using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_YOP_015 : SimTemplate //* 氮素制剂 Nitroboost Poison
    {
        //Give a minion +2 Attack.<b>Corrupt:</b> And your weapon.
        //使一个随从获得+2攻击力。<b>腐蚀：</b>并使你的武器获得+2攻击力。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
        {
            if (ownplay && target != null)
            {
                p.minionGetBuffed(target, 2, 0);
            }
        }          

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }      
}
