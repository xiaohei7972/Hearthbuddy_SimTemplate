using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_147 : SimTemplate //* 燃烬风暴 Cinderstorm
//Deal $5 damage randomly split among all enemies.
//造成$5点伤害，随机分配到所有敌人身上。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int times = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
            p.allCharsOfASideGetRandomDamage(!ownplay, times);
        }
    }
}