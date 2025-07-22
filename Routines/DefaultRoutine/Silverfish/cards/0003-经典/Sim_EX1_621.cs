using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_621 : SimTemplate //* 治疗之环 Circle of Healing
	{
		//Restore #4 Health to ALL_minions.
		//为所有随从恢复#4点生命值。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int heal = (ownplay) ? p.getSpellHeal(4) : p.getEnemySpellHeal(4);
            p.allMinionsGetDamage(-heal);
		}

	}
}