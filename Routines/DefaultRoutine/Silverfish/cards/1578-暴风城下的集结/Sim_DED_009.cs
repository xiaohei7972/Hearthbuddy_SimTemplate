using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_009 : SimTemplate //* 狗狗饼干 Doggie Biscui
    {
        //可交易使一个随从获得+2/+3。在你交易此牌后，使一个友方随从获得突袭
        //Tradeable Give a minion +2/+3. After you Trade this, give a friendly minion Rush
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(own, 2, 3);
                //p.minionGetRush(own);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}
