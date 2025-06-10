using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_351ts : SimTemplate //* 远古祝福 Blessing of the Ancients
//Give your minions +1/+1.
//使你的所有随从获得+1/+1。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.allMinionOfASideGetBuffed(ownplay, 1, 1);
			if (p.ownMinions.Count > 4) p.evaluatePenality -= 20;
			
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}