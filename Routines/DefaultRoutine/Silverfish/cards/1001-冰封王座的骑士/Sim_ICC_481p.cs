using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_481p: SimTemplate //* 灵体转化 Transmute Spirit
//<b>Hero Power:</b> Transform a friendly minion into a random one that costs (1) more.
//<b>英雄技能</b>将一个友方随从随机变形成为一个法力值消耗增加（1）点的随从。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
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