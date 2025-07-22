using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_610 : SimTemplate //* 爆炸陷阱 Explosive Trap
	{
		//<b>Secret:</b> When your hero is attacked, deal $2 damage to all enemies.
		//<b>奥秘：</b>当你的英雄受到攻击，对所有敌人造成$2点伤害。
		
        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.allMinionOfASideGetDamage(!ownplay, dmg);
        }

	}

}