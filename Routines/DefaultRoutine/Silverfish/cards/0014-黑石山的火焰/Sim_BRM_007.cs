using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BRM_007 : SimTemplate //* 夜幕奇袭 Gang Up
//Choose a minion. Shuffle 3 copies of it into your deck.
//选择一个随从。将该随从的三张复制洗入你的牌库。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.ownDeckSize += 3;
            }
            else
            {
                p.enemyDeckSize += 3;
            }
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