using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_117 : SimTemplate //* 剑刃风暴 Bladestorm
	{
        //Deal $1 damage to all minions. Repeat until one dies.
        //对所有随从造成$1点伤害。重复此效果，直到某个随从死亡。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            p.allMinionsGetDamage(dmg);
            int minHp = 100000;
            foreach (Minion m in p.ownMinions)
            {
                if (m.Hp < minHp) minHp = m.Hp;
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m.Hp < minHp) minHp = m.Hp;
            }

            int dmgdone = (int)Math.Ceiling((double)minHp / (double)dmg) * dmg;

            p.allMinionsGetDamage(dmgdone);
        }
    }
}
