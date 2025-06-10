using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_041 : SimTemplate //* 鱼勇可贾 Nofin Can Stop Us
	{
		//[x]Give your minions+1/+1. Give yourMurlocs an extra +1/+1.
		//使你的所有随从获得+1/+1。使你的鱼人额外获得+1/+1。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			List<Minion> temp = (ownplay)? p.ownMinions : p.enemyMinions;
			foreach (Minion m in temp)
			{
				if((TAG_RACE)m.handcard.card.race == TAG_RACE.MURLOC)
				{
					p.minionGetBuffed(m,2,2);
				}
				else
				{
					p.minionGetBuffed(m,1,1);
				}
			}

		}		
		
	}
}
