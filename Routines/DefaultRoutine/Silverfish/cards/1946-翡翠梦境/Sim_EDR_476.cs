using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：7
	//Moonwell
	//月亮井
	//Deal $4 damage to all enemy characters. Restore #4 Health to all friendly characters.
	//对所有敌方角色造成$4点伤害。为所有友方角色恢复#4点生命值。
	class Sim_EDR_476 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int damage = ownplay ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
			int heal = ownplay ? p.getSpellHeal(-4) : p.getEnemySpellHeal(-4);
			p.allCharsOfASideGetDamage(!ownplay, damage);
			p.allCharsOfASideGetDamage(ownplay, heal);

        }
		
	}
}
