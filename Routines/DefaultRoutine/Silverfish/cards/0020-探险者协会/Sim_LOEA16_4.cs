using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOEA16_4 : SimTemplate //* 恐怖丧钟 Timepiece of Horror
//Deal $10 damage randomly split among all enemies.
//造成$10点伤害，随机分配到所有敌人身上。 
	{
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int times = (ownplay) ? p.getSpellDamageDamage(10) : p.getEnemySpellDamageDamage(10);
            p.allCharsOfASideGetRandomDamage(!ownplay, times);
        }
    }
}