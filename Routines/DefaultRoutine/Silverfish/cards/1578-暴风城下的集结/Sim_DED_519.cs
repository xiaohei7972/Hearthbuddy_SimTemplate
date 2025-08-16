using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 迪菲亚炮手 Defias Cannoneer
    //在你的英雄攻击后，随机对一个敌人造成2点伤害，触发两次。
    //fter your hero attacks, deal 2 damage to a random enemy twice.
    class Sim_DED_519 : SimTemplate
    {
        public override void afterHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
        {
            if (triggerMinion.own == hero.own)
            {
                p.minionGetDamageOrHeal(p.getEnemyCharTargetForRandomSingleDamage(2), 2);
                p.minionGetDamageOrHeal(p.getEnemyCharTargetForRandomSingleDamage(2), 2);

            }
        }

    }
}
