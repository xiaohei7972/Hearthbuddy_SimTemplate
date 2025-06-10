using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_071 : SimTemplate //* 突变 Mutate
//Transform a friendly minion into a random one that costs (1) more.
//将一个友方随从随机变形成为一个法力值消耗增加（1）点的随从。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if(target == null) return;
            p.minionTransform(target, p.getRandomCardForManaMinion(target.handcard.card.cost + 1));
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