using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_249: SimTemplate //* 残酷集结 Grim Rally
//Destroy a friendly minion. Give your minions +1/+1.
//消灭一个友方随从。使你的所有随从获得+1/+1。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {                       
            p.minionGetDestroyed(target);
		    List<Minion> sss = (ownplay) ? p.ownMinions : p.enemyMinions;
			foreach(Minion m in sss)
			{
                if(m!=target)p.minionGetBuffed(m, 1, 1);  				
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