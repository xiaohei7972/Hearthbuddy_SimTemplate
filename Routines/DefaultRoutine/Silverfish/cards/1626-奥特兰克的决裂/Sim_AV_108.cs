using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_108 : SimTemplate //* 裂盾一击 shieldshatter
	{
		//对所有随从造成$5点伤害。你每有1点护甲值，该牌的法力值消耗减少（1）点。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
			p.allMinionsGetDamage(dmg);
		}

	}
}
