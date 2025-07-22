using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_314t8 : SimTemplate //* 死亡凋零 Death and Decay
//Deal $3 damage to all enemies.
//对所有敌人造成$3点伤害。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.allCharsOfASideGetDamage(!ownplay, dmg);
        }
    }
}