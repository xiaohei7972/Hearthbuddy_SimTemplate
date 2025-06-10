using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_032 : SimTemplate //* 烈焰风暴 Flamestrike
	{
		//Deal $4 damage to all enemy minions.
		//对所有敌方随从造成$4点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
            p.allMinionOfASideGetDamage(!ownplay, dmg);
		}

	}
}