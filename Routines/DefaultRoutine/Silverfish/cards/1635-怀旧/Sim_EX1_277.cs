using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_277 : SimTemplate //* 奥术飞弹 Arcane Missiles
	{
		//Deal $3 damage randomly split among all enemies.
		//造成$3点伤害，随机分配到所有敌人身上。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int times = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.allCharsOfASideGetRandomDamage(!ownplay, times);
        }
    }
}