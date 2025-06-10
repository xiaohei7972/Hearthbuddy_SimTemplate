using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_125 : SimTemplate //* 疯帽客 Mad Hatter
//[x]<b>Battlecry:</b> Randomly toss3 hats to other minions.Each hat gives +1/+1.
//<b>战吼：</b>随机向其他随从丢出三顶帽子。每顶帽子可使随从获得+1/+1。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null) 
			{
				p.minionGetBuffed(target, 1, 1);
				p.minionGetBuffed(target, 1, 1);
				p.minionGetBuffed(target, 1, 1);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 11),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}