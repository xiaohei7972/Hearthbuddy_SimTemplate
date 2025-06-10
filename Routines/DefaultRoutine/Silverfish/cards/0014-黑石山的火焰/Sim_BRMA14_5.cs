using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA14_5 : SimTemplate //* 剧毒金刚 Toxitron
//At the start of your turn, deal 1 damage to all other minions.
//在你的回合开始时，对所有其他随从造成1点伤害。 
	{
		

		public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
		{
		   if (triggerEffectMinion.own == turnStartOfOwner)
           {
               p.allMinionsGetDamage(1, triggerEffectMinion.entitiyID);
		   }
		}

	}
}