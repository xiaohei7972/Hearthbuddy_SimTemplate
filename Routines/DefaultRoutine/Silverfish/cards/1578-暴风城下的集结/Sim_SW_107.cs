using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_107 : SimTemplate //* 火热促销 Fire Sale
	{
		//<b>Tradeable</b>Deal $3 damageto all minions.
		//<b>可交易</b>对所有随从造成$3点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
			p.allMinionsGetDamage(dmg);
		}

	}
}
