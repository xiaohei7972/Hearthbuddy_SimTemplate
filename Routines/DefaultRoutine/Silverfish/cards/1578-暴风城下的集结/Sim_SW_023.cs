using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：0
	//Provoke
	//挑衅
	//[x]<b>Tradeable</b>Choose a friendly minion.Enemy minions attack it.
	//<b>可交易</b>选择一个友方随从，使所有敌方随从攻击该随从。
	class Sim_SW_023 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			if (target != null)
			{
				List<Minion> minions = ownplay ? p.enemyMinions : p.ownMinions;
				foreach (Minion minion in minions.ToArray())
				{
					p.minionAttacksMinion(minion, target);
				}
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
