using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_871 : SimTemplate //* 士兵车队 Soldier's Caravan
	{
		//[x]At the start of your turn,summon two 1/1Silver Hand Recruits.
		//在你的回合开始时，召唤两个1/1的白银之手新兵。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t);
		
		public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
		{
			if (turnStartOfOwner == triggerEffectMinion.own)
			{
				int pos = (triggerEffectMinion.own) ? p.ownMinions.Count : p.enemyMinions.Count;
            	p.callKid(kid, pos, triggerEffectMinion.own);
			}
		}
	}
}
