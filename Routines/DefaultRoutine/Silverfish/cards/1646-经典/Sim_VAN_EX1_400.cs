using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_400 : SimTemplate //* 旋风斩 Whirlwind
	{
		//Deal $1 damage to ALL_minions.
		//对所有随从造成$1点伤害。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            p.allMinionsGetDamage(dmg);
		}

	}
}