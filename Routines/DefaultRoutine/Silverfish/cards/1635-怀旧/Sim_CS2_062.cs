using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_062 : SimTemplate //* 地狱烈焰 Hellfire
	{
		//Deal $3 damage to ALL_characters.
		//对所有角色造成$3点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.allCharsGetDamage(dmg);
		}

	}
}