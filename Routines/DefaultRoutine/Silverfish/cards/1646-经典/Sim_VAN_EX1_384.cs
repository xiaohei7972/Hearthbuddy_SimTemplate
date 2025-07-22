using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_384 : SimTemplate //* 复仇之怒 Avenging Wrath
	{
		//Deal $8 damage randomly split among all enemies.
		//造成$8点伤害，随机分配到所有敌人身上。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int times = (ownplay) ? p.getSpellDamageDamage(8) : p.getEnemySpellDamageDamage(8);
            p.allCharsOfASideGetRandomDamage(!ownplay, times);
        }
    }
}