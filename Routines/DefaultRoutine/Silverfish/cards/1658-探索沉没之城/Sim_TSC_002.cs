using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TSC_002 : SimTemplate //* 刺豚拳手 Pufferfist
                                    //在你的英雄攻击后，对所有敌人造成1点伤害。
                                    //After your hero attacks, deal 1 damage to all enemies.
    {

        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            p.allCharsOfASideGetDamage(!own.own, 1);
        }

    }
}