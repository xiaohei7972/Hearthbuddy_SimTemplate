using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DREAM_05 : SimTemplate //* 噩梦 Nightmare
    {
        //Give a minion +4/+4. At the start of your next turn, destroy it.
        //使一个随从获得+4/+4，在你的下个回合开始时，消灭该随从。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 4, 4);
            if (ownplay)
            {
                target.destroyOnOwnTurnStart = true;
            }
            else
            {
                target.destroyOnEnemyTurnStart = true;
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
