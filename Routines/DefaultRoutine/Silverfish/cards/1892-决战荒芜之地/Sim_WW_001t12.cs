using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：3
	//Collapse!
	//塌陷
	//Deal $3 damageto all enemies.
	//对所有敌人造成$3点伤害。
	class Sim_WW_001t12 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int damage = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellHeal(3);
			p.allCharsOfASideGetDamage(!ownplay, damage);
        }
		
	}
}
