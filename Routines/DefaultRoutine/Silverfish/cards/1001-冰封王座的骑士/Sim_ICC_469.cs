using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_469: SimTemplate //* 强制牺牲 Unwilling Sacrifice
//Choose a friendly minion. Destroy it and a random enemy minion.
//选择一个友方随从，消灭该随从和一个随机敌方随从。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetDestroyed(target);
            Minion found = null;
            if (ownplay) found = p.searchRandomMinion(p.enemyMinions, searchmode.searchLowestHP);
            else found = p.searchRandomMinion(p.ownMinions, searchmode.searchHighHPLowAttack);
            if (found != null) p.minionGetDestroyed(found);
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