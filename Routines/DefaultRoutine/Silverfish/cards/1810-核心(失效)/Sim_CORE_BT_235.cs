using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_BT_235 : SimTemplate //* 混乱新星 Chaos Nova
	{
		//Deal $4 damage to all_minions.
		//对所有随从造成$4点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
			p.allMinionsGetDamage(dmg);
		}		
		
	}
}
