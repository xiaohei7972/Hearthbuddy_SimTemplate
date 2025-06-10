using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_099t4 : SimTemplate //* 毁灭 Annihilation
	{
		//Deal 5 damage to all other minions.
		//对所有其他随从造成5点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
			p.allMinionsGetDamage(dmg);
		}
	}
}