using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 刺豚拳手 Pufferfist
    //在你的英雄攻击后，对所有敌人造成1点伤害。
    //After your hero attacks, deal 1 damage to all enemies.
    class Sim_TSC_002 : SimTemplate
    {
        public override void afterHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
        {
            if (triggerMinion.own == hero.own)
                p.allCharsOfASideGetDamage(!triggerMinion.own, 1);

        }

    }
}