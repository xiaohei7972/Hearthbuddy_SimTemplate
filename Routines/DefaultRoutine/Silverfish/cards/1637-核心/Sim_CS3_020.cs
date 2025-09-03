using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 伊利达雷审判官 Illidari Inquisitor
    //<b>Rush</b>. After your hero attacks an enemy, this attacks it too.
    //<b>突袭</b>在你的英雄攻击一个敌人后，该随从也会攻击。
    class Sim_CS3_020 : SimTemplate
    {
        public override void afterHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
        {
            if (triggerMinion.own == hero.own)
                if (target != null)
                {
                    p.minionAttacksMinion(triggerMinion, target);
                }

        }
    }
}
