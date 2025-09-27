using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：2
	//Ring of Courage
	//勇气之戒
	//<b>Tradeable</b>Give a minion +1/+1. Repeat for each enemy minion.
	//<b>可交易</b>使一个随从获得+1/+1。每有一个敌方随从，重复一次。
	class Sim_ONY_027 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)// && !target.immune)
            {
				p.minionGetBuffed(target, 1, 1);
				for (int i = 0; i < (ownplay ? p.enemyMinions.Count : p.ownMinions.Count); i++)
				{
					p.minionGetBuffed(target, 1, 1);

				}
            }
		}	

		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
		
	}
}
