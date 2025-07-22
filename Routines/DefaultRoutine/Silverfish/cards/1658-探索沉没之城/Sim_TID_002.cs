using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TID_002 : SimTemplate //* 自然使徒 Herald of Nature
                                    //战吼：如果你在此牌在你手中时施放过自然法术，使你的其他随从获得+1/+2。
                                    //Battlecry: If you've cast a Nature spell while holding this, give your other minions +1/+2.
    {

        //public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Handmanager.Handcard triggerhc)
        //{
        //    if (ownplay && hc.card.Nature)
        //    {
        //        bool usenature = true;
        //    }
        //}
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            //if (p.useNature > 0)
            {
                List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
                foreach (Minion m in temp)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 1, 2);
                }
            }
        }

        //public override PlayReq[] GetPlayReqs()
        //{
        //    return new PlayReq[] {
        //        new PlayReq(CardDB.ErrorType2.REQ_TARGET_NO_NATURE),
        //    };
        //}

    }


}