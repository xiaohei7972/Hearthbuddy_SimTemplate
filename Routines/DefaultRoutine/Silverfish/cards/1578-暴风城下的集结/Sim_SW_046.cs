using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_046 : SimTemplate //* 城建税 City Tax
	{
		//[x]<b>Tradeable</b><b>Lifesteal</b>. Deal $1 damageto all enemy minions.
		//<b>可交易</b><b>吸血</b>，对所有敌方随从造成$1点伤害。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
			p.allMinionOfASideGetDamage(!ownplay, dmg);
		}
	}
}
